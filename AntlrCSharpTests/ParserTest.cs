using AntlrCSharp;
using Antlr4.Runtime;
using NUnit.Framework;
using AntlrCSharp.builder;

namespace AntlrCSharpTests
{
    //[TestClass]
    //public class ParserTest
    //{
    //    private SpeakParser Setup(string text)
    //    {
    //        AntlrInputStream inputStream = new AntlrInputStream(text);
    //        SpeakLexer speakLexer = new SpeakLexer(inputStream);
    //        CommonTokenStream commonTokenStream = new CommonTokenStream(speakLexer);
    //        SpeakParser speakParser = new SpeakParser(commonTokenStream);

    //        return speakParser;   
    //    }

    //    [TestMethod]
    //    public void TestChat()
    //    {
    //        SpeakParser parser = Setup("john says \"hello\" \n michael says \"world\" \n");

    //        SpeakParser.ChatContext context = parser.chat();
    //        BasicSpeakVisitor visitor = new BasicSpeakVisitor();
    //        visitor.Visit(context);

    //        Assert.AreEqual(2, visitor.Lines.Count);
    //    }

    //    [TestMethod]
    //    public void TestLine()
    //    {
    //        SpeakParser parser = Setup("john says \"hello\" \n");

    //        SpeakParser.LineContext context = parser.line();
    //        BasicSpeakVisitor visitor = new BasicSpeakVisitor();
    //        SpeakLine line = (SpeakLine) visitor.VisitLine(context);     
            
    //        Assert.AreEqual("john", line.Person);
    //        Assert.AreEqual("hello", line.Text);
    //    }

    //    [TestMethod]
    //    public void TestWrongLine()
    //    {
    //        SpeakParser parser = Setup("john sayan \"hello\" \n");

    //        var context = parser.line();
            
    //        Assert.IsInstanceOfType(context, typeof(SpeakParser.LineContext));            
    //        Assert.AreEqual("john", context.name().GetText());
    //        Assert.IsNull(context.SAYS());
    //        Assert.AreEqual("johnsayan\"hello\"\n", context.GetText());
    //    }
    //}

    [TestFixture]
    public class ScssBuilderTests
    {
        private XCSSParser Setup(string text)
        {
            AntlrInputStream inputStream = new AntlrInputStream(text);
            XCSSLexer xcssLexer = new XCSSLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(xcssLexer);
            XCSSParser xcssParser = new XCSSParser(commonTokenStream);
            var b = new XcssBuilder();
            b.Visit(xcssParser.selectorGroup());

            return xcssParser;
        }


        [TestCase("div[~'text']", "//div[contains(text(),'text')]")]
        [TestCase("div['text']", "//div[text()='text']")]
        [TestCase("div[src='1.png']['text']", "//div[@src='1.png'][text()='text']")]
        [TestCase("div[src=\"1.png\"]['text']", "//div[@src=\"1.png\"][text()='text']")]
        [TestCase(".classname#myid['text']", "//*[@id='myid'][contains(@class,'classname')][text()='text']")]
        [TestCase(".classname['mytext']", "//*[contains(@class,'classname')][text()='mytext']")]
        [TestCase("div.classname['mytext']", "//div[contains(@class,'classname')][text()='mytext']")]
        [TestCase(".classname1.classname2['mytext']",
            "//*[contains(@class,'classname1')][contains(@class,'classname2')][text()='mytext']")]
        [TestCase("div.classname1.classname2['mytext']",
            "//div[contains(@class,'classname1')][contains(@class,'classname2')][text()='mytext']")]
        [TestCase(".classname1['mytext'] .classname2['mytext']",
            "//*[contains(@class,'classname1')][text()='mytext']/descendant::*[contains(@class,'classname2')][text()='mytext']"
            )]
        [TestCase("div.classname1['mytext'] div.classname2['mytext']",
            "//div[contains(@class,'classname1')][text()='mytext']/descendant::div[contains(@class,'classname2')][text()='mytext']"
            )]
        [TestCase("#myid div['mytext']", "//*[@id='myid']/descendant::div[text()='mytext']")]
        [TestCase("div#myid div['mytext']", "//div[@id='myid']/descendant::div[text()='mytext']")]
        [TestCase("div#myid.classname div['mytext']",
            "//div[@id='myid'][contains(@class,'classname')]/descendant::div[text()='mytext']")]
        [TestCase("div#main-basket-info-div>ul>li['Тариф']>a",
            "//div[@id='main-basket-info-div']/ul/li[text()='Тариф']/a")]
        [TestCase("li[>h5>strong>a['mytext']]", "//li[h5/strong/a[text()='mytext']]")]
        [TestCase("li[>a]", "//li[a]")]
        [TestCase("li[>a[div]]", "//li[a[descendant::div]]")]
        [TestCase("tr[1]>td[last()]", "//tr[1]/td[last()]")]
        [TestCase("img[src~'111.png']", "//img[contains(@src,'111.png')]")]
        [TestCase("#showThemesPanel,.genre-filter['text']",
            "//*[@id='showThemesPanel']|//*[contains(@class,'genre-filter')][text()='text']")]
        [TestCase(">div.toggle-drop>ul>li>span['Вечером']",
            "//child::div[contains(@class,'toggle-drop')]/ul/li/span[text()='Вечером']")]
        [TestCase("li[10]>div.news-block", "//li[10]/div[contains(@class,'news-block')]")]
        [TestCase("td[h3>span['Категории, на которые вы уже подписаны']]>div>div",
            "//td[descendant::h3/span[text()='Категории, на которые вы уже подписаны']]/div/div")]
        //[TestCase("tr[span.ng-binding[descendant-or-self::*['{0}']]]", "tr[descendant::span[contains(@class,'ng-binding')][descendant-or-self::*[text()='{0}'])]]")]
        public void ConvertScssToXpath(string scssSelector, string result)
        {
            var xcss = XcssBuilder.Build(scssSelector);
            Assert.AreEqual(result, xcss.Xpath);
            Assert.IsEmpty(xcss.Css);
        }

        [TestCase("#myid", "#myid")]
        [TestCase("div#myid", "div#myid")]
        [TestCase("div#myid.classname", "div#myid.classname")]
        [TestCase(".classname", ".classname")]
        [TestCase("div.classname", "div.classname")]
        [TestCase(".classname1.classname2", ".classname1.classname2")]
        [TestCase("div.classname1.classname2", "div.classname1.classname2")]
        [TestCase(".classname1 .classname2", ".classname1 .classname2")]
        [TestCase("div.classname1 div.classname2", "div.classname1 div.classname2")]
        [TestCase("div[src='1.png']", "div[src='1.png']")]
        [TestCase("div[src=\"1.png\"]", "div[src=\"1.png\"]")]
        [TestCase(">.search-bar", ">.search-bar")]
        [TestCase(".nav-section >.search-bar", ".nav-section >.search-bar")]
        [TestCase(".nav-section >.search-bar ul", ".nav-section >.search-bar ul")]
        public void ConvertScssToCss(string scssSelector, string result)
        {
            var scss = XcssBuilder.Build(scssSelector);
            Assert.AreEqual(result, scss.Css);
            Assert.IsEmpty(scss.Xpath);
        }
    }

}

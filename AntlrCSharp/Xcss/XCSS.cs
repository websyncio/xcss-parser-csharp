using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrCSharp.builder
{
    public class XCSS
    {
        public readonly string XcssSelector;
        public readonly string CssSelector;
        public readonly string XPath;

        public XCSS(string cssSelector, string xpath)
        {
            XcssSelector = string.IsNullOrWhiteSpace(cssSelector) ? xpath : cssSelector;
            CssSelector = cssSelector;
            XPath = xpath;
        }

        public XCSS(string xcssSelector, string cssSelector, string xpath)
        {
            XcssSelector = xcssSelector;
            CssSelector = cssSelector;
            XPath = xpath;
        }

        public static XCSS ParseSelector(string xcssSelector)
        {
            AntlrInputStream inputStream = new AntlrInputStream(xcssSelector);
            XCSSLexer xcssLexer = new XCSSLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(xcssLexer);
            XCSSParser xcssParser = new XCSSParser(commonTokenStream);
            var listener = new CollectXcssSelectorsListener();
            ParseTreeWalker walker = new ParseTreeWalker();
            walker.Walk(listener, xcssParser.parse());
            //string css = CssBuilder.BuildFromParts(listener.Selectors);
            string xpath = XPathBuilder.Build(listener.Selectors);

            return new XCSS(xpath, null);
        }

        public static XCSS Concat(string scssSelector1, string scssSelector2)
        {
            return XcssBuilder.Concat(scssSelector1, scssSelector2);
        }

        public XCSS Concat(XCSS xcss2)
        {
            string resultXpath = XPathBuilder.Concat(this.XPath, xcss2.XPath);
            var resultCss = string.IsNullOrEmpty(this.CssSelector) || string.IsNullOrEmpty(xcss2.CssSelector)
                                ? string.Empty
                                : CssBuilder.Concat(this.CssSelector, xcss2.CssSelector);
            return new XCSS(resultXpath, resultCss);
        }

        public static void FromXPath(string xcssSelector, bool v)
        {
            throw new NotImplementedException();
        }

        public static void FromCss(string xcssSelector, bool v)
        {
            throw new NotImplementedException();
        }
    }
}

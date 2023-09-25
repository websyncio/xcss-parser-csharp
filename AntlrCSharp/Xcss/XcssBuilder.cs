using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrCSharp.builder
{

    public class XcssBuilder
    {
        public static XCSS Build(string xcss)
        {
            AntlrInputStream inputStream = new AntlrInputStream(xcss);
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

        internal static XCSS Concat(string scssSelector1, string scssSelector2)
        {
            throw new NotImplementedException();
        }
    }
}

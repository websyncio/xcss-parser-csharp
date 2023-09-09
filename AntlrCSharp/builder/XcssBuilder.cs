using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrCSharp.builder
{

    public class XcssBuilder
    {
        public static Xcss Build(string xcss)
        {
            AntlrInputStream inputStream = new AntlrInputStream(xcss);
            XCSSLexer xcssLexer = new XCSSLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(xcssLexer);
            XCSSParser xcssParser = new XCSSParser(commonTokenStream);
            var listener = new CollectXcssPartsListener();
            ParseTreeWalker walker = new ParseTreeWalker();
            walker.Walk(listener, xcssParser.parse());
            string css = CssBuilder.BuildFromParts(listener.Selectors);
            string xpath = XPathBuilder.BuildFromParts(listener.Selectors);

            return new Xcss(css, xpath);
        }

        internal static Xcss Concat(string scssSelector1, string scssSelector2)
        {
            throw new NotImplementedException();
        }
    }
}

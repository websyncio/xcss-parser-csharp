using Antlr4.Runtime;

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
            var visitor = new CollectXcssPartsVisitor();
            List<XCSSPart> parts = visitor.Visit(xcssParser.selectorGroup());
            string css = CssBuilder.BuildFromParts(parts);
            string xpath = XPathBuilder.BuildFromParts(parts);

            return new Xcss(css, xpath);
        }

        internal static Xcss Concat(string scssSelector1, string scssSelector2)
        {
            throw new NotImplementedException();
        }
    }
}

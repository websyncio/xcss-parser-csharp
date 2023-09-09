using Antlr4.Runtime.Misc;

namespace AntlrCSharp.builder
{
    internal class CollectXcssPartsVisitor:XCSSParserBaseVisitor<List<XCSSSelector>>
    {
        List<XCSSSelector> Parts = new List<XCSSSelector>();
        
        public override List<XCSSSelector> VisitSelector([NotNull] XCSSParser.SelectorContext context)
        {
            return base.VisitSelector(context);
        }
    }

}
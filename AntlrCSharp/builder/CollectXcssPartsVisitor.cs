using Antlr4.Runtime.Misc;

namespace AntlrCSharp.builder
{
    internal class CollectXcssPartsVisitor:XCSSParserBaseVisitor<List<XCSSPart>>
    {
        List<XCSSPart> Parts = new List<XCSSPart>();
        
        public override List<XCSSPart> VisitSelector([NotNull] XCSSParser.SelectorContext context)
        {
            return base.VisitSelector(context);
        }
    }

}
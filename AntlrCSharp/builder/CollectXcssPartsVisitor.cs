using Antlr4.Runtime.Misc;

namespace AntlrCSharp.builder
{
    internal class CollectXcssPartsVisitor:XCSSParserBaseVisitor<List<XCSSPart>>
    {
        public override List<XCSSPart> VisitSelectorGroup([NotNull] XCSSParser.SelectorGroupContext context)
        {
            return base.VisitSelectorGroup(context);
        }
    }
}
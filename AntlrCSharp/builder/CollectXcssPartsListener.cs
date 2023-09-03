using Antlr4.Runtime.Misc;

namespace AntlrCSharp.builder
{
    internal class CollectXcssPartsListener : XCSSParserBaseListener
    {
        public List<XCSSPart> Parts = new List<XCSSPart>();

        public override void EnterParse([NotNull] XCSSParser.ParseContext context)
        {
            base.EnterParse(context);
        }
    }
}
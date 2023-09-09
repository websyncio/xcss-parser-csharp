using Antlr4.Runtime.Misc;

namespace AntlrCSharp.builder
{
    internal class CollectXcssPartsListener : XCSSParserBaseListener
    {
        private XcssAttribute _currentAttribute = new XcssAttribute();
        private XCSSElement _currentElement = new XCSSElement();
        private XCSSSelector _currentSelector = new XCSSSelector();
        public List<XCSSSelector> Selectors = new List<XCSSSelector>();

        public override void EnterSelectorGroup([NotNull] XCSSParser.SelectorGroupContext context)
        {
            Selectors = new List<XCSSSelector>();
            base.EnterSelectorGroup(context);
        }

        public override void ExitSelector([NotNull] XCSSParser.SelectorContext context)
        {
            Selectors.Add(_currentSelector);
            _currentSelector = new XCSSSelector();
            base.ExitSelector(context);
        }


        public override void ExitSimpleSelectorSequence([NotNull] XCSSParser.SimpleSelectorSequenceContext context)
        {
            _currentSelector.Elements.Add(_currentElement);
            _currentElement = new XCSSElement();
            base.ExitSimpleSelectorSequence(context);
        }

        public override void EnterCombinator([NotNull] XCSSParser.CombinatorContext context)
        {
            _currentElement.Combinator = context.GetText();
            base.EnterCombinator(context);
        }

        public override void EnterTagName([NotNull] XCSSParser.TagNameContext context)
        {
            _currentElement.Tag = context.GetText();
            base.EnterTagName(context);
        }

        public override void EnterElementIdValue([NotNull] XCSSParser.ElementIdValueContext context)
        {
            _currentElement.Id = context.GetText();
            base.EnterElementIdValue(context);
        }

        public override void EnterAttrib([NotNull] XCSSParser.AttribContext context)
        {
            _currentAttribute = new XcssAttribute();
            base.EnterAttrib(context);
        }

        public override void ExitAttrib([NotNull] XCSSParser.AttribContext context)
        {
            _currentElement.Attributes.Add(_currentAttribute);
            base.ExitAttrib(context);
        }

        public override void EnterAttribName([NotNull] XCSSParser.AttribNameContext context)
        {
            _currentAttribute.Name = context.GetText();
            base.EnterAttribName(context);
        }

        public override void EnterAttribMatchStyle([NotNull] XCSSParser.AttribMatchStyleContext context)
        {
            switch (context.GetText())
            {
                case "^=":
                    _currentAttribute.MatchStyle = AttributeMatchStyle.Prefix;
                    break;
                case "$=":
                    _currentAttribute.MatchStyle = AttributeMatchStyle.Suffix;
                    break;
                case "*=":
                case "~=":
                    _currentAttribute.MatchStyle = AttributeMatchStyle.Contains;
                    break;
                case "=":
                    _currentAttribute.MatchStyle = AttributeMatchStyle.Equal;
                    break;
                default:
                    throw new ParseCanceledException("Invalid match style for attribute.");
            }
            base.EnterAttribMatchStyle(context);
        }

        public override void EnterAttribValue([NotNull] XCSSParser.AttribValueContext context)
        {
            _currentAttribute.Value = context.GetText();
            base.EnterAttribValue(context);
        }

        public override void EnterClassNameValue([NotNull] XCSSParser.ClassNameValueContext context)
        {
            _currentElement.ClassNames.Add(context.GetText());
            base.EnterClassNameValue(context);
        }

        public override void EnterPseudo([NotNull] XCSSParser.PseudoContext context)
        {
            _currentElement.Conditions.Add(context.GetText());
            base.EnterPseudo(context);
        }

        public override void EnterNegation([NotNull] XCSSParser.NegationContext context)
        {
            throw new NotImplementedException();
            //base.EnterNegation(context);
        }

    }
}
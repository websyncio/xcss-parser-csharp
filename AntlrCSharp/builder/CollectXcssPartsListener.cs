using Antlr4.Runtime.Misc;

namespace AntlrCSharp.builder
{
    internal class XcssSelectorContext
    {
        public XcssTextCondition Text = new XcssTextCondition();
        public XcssAttribute Attribute = new XcssAttribute();
        public XcssElement Element = new XcssElement();
        public XcssSelector Selector = new XcssSelector();

        private int _xpathConditionLevel=0;

        internal void StartXpathCondition(string xpathCondition)
        {
            if (_xpathConditionLevel == 0)
            {
                Element.SubelementXPathConditions.Add(xpathCondition);
            }
            _xpathConditionLevel++;
        }

        internal void FinishXpathCondition()
        {
            _xpathConditionLevel--;
        }

    }

    internal class CollectXcssPartsListener : XCSSParserBaseListener
    {
        private Stack<XcssSelectorContext> _parentContexts = new Stack<XcssSelectorContext>();
        private XcssSelectorContext _context = new XcssSelectorContext();
        public List<XcssSelector> Selectors = new List<XcssSelector>();

        public override void EnterSelectorGroup([NotNull] XCSSParser.SelectorGroupContext context)
        {
            Selectors = new List<XcssSelector>();
            base.EnterSelectorGroup(context);
        }

        public override void EnterSelector([NotNull] XCSSParser.SelectorContext context)
        {
            _context = new XcssSelectorContext();
            base.EnterSelector(context);
        }

        public override void ExitSelector([NotNull] XCSSParser.SelectorContext context)
        {
            if (!_parentContexts.Any())
            {
                // This is a root level selector, not a subelement one
                Selectors.Add(_context.Selector);
            }
            base.ExitSelector(context);
        }

        public override void EnterSubelementSelector([NotNull] XCSSParser.SubelementSelectorContext context)
        {
            _parentContexts.Push(_context);
            base.EnterSubelementSelector(context);
        }

        public override void ExitSubelementSelector([NotNull] XCSSParser.SubelementSelectorContext context)
        {
            var parentContext = _parentContexts.Pop();
            parentContext.Element.SubelementConditions.Add(_context.Selector);
            _context = parentContext;
            base.ExitSubelementSelector(context);
        }


        public override void ExitSimpleSelectorSequence([NotNull] XCSSParser.SimpleSelectorSequenceContext context)
        {
            _context.Selector.Elements.Add(_context.Element);
            _context.Element = new XcssElement();
            base.ExitSimpleSelectorSequence(context);
        }

        public override void EnterCombinator([NotNull] XCSSParser.CombinatorContext context)
        {
            _context.Element.Combinator = context.GetText();
            base.EnterCombinator(context);
        }

        public override void EnterTagName([NotNull] XCSSParser.TagNameContext context)
        {
            _context.Element.Tag = context.GetText();
            base.EnterTagName(context);
        }

        public override void EnterElementIdValue([NotNull] XCSSParser.ElementIdValueContext context)
        {
            _context.Element.Id = context.GetText();
            base.EnterElementIdValue(context);
        }

        public override void EnterText([NotNull] XCSSParser.TextContext context)
        {
            _context.Text = new XcssTextCondition();
            base.EnterText(context);
        }

        public override void ExitText([NotNull] XCSSParser.TextContext context)
        {
            _context.Element.TextConditions.Add(_context.Text);
            base.ExitText(context);
        }

        public override void EnterTextMatchStyle([NotNull] XCSSParser.TextMatchStyleContext context)
        {
            switch (context.GetText())
            {
                case "~":
                    _context.Text.MatchStyle = AttributeMatchStyle.Contains;
                    break;
                default:
                    throw new ParseCanceledException("Invalid match style for text.");
            }
            base.EnterTextMatchStyle(context);
        }

        public override void EnterTextValue([NotNull] XCSSParser.TextValueContext context)
        {
            _context.Text.Value = context.GetText();
            base.EnterTextValue(context);
        }

        public override void EnterAttrib([NotNull] XCSSParser.AttribContext context)
        {
            _context.Attribute = new XcssAttribute();
            base.EnterAttrib(context);
        }

        public override void ExitAttrib([NotNull] XCSSParser.AttribContext context)
        {
            _context.Element.Attributes.Add(_context.Attribute);
            base.ExitAttrib(context);
        }

        public override void EnterAttribName([NotNull] XCSSParser.AttribNameContext context)
        {
            _context.Attribute.Name = context.GetText();
            base.EnterAttribName(context);
        }

        public override void EnterAttribMatchStyle([NotNull] XCSSParser.AttribMatchStyleContext context)
        {
            switch (context.GetText())
            {
                case "^=":
                    _context.Attribute.MatchStyle = AttributeMatchStyle.Prefix;
                    break;
                case "$=":
                    _context.Attribute.MatchStyle = AttributeMatchStyle.Suffix;
                    break;
                case "*=":
                case "~=":
                case "~":
                    _context.Attribute.MatchStyle = AttributeMatchStyle.Contains;
                    break;
                case "=":
                    _context.Attribute.MatchStyle = AttributeMatchStyle.Equal;
                    break;
                default:
                    throw new ParseCanceledException("Invalid match style for attribute.");
            }
            base.EnterAttribMatchStyle(context);
        }

        public override void EnterAttribValue([NotNull] XCSSParser.AttribValueContext context)
        {
            _context.Attribute.Value = context.GetText();
            base.EnterAttribValue(context);
        }

        public override void EnterClassNameValue([NotNull] XCSSParser.ClassNameValueContext context)
        {
            _context.Element.ClassNames.Add(context.GetText());
            base.EnterClassNameValue(context);
        }

        public override void EnterPseudo([NotNull] XCSSParser.PseudoContext context)
        {
            _context.Element.Conditions.Add(context.GetText());
            base.EnterPseudo(context);
        }

        public override void EnterNegation([NotNull] XCSSParser.NegationContext context)
        {
            throw new NotImplementedException();
            //base.EnterNegation(context);
        }

        public override void EnterElementIndex([NotNull] XCSSParser.ElementIndexContext context)
        {
            if (_context.Element.Index != null)
            {
                throw new ParseCanceledException("Element can not contain several indexes.");
            }
            _context.Element.Index = int.Parse(context.GetText());
            base.EnterElementIndex(context);
        }

        public override void EnterXpathCondition([NotNull] XCSSParser.XpathConditionContext context)
        {
            _context.StartXpathCondition(context.GetText());
            base.EnterXpathCondition(context);
        }

        public override void ExitXpathCondition([NotNull] XCSSParser.XpathConditionContext context)
        {
            _context.FinishXpathCondition();
            base.ExitXpathCondition(context);
        }

    }
}
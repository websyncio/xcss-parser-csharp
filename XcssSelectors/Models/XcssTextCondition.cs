namespace XcssSelectors.Models
{
    internal class XcssTextCondition
    {
        public AttributeMatchStyle MatchStyle;

        public string Value;

        public XcssTextCondition() { }

        public XcssTextCondition(string value, AttributeMatchStyle matchStyle)
        {
            Value = value;
            MatchStyle = matchStyle;
        }

    }
}

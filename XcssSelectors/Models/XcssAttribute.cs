namespace XcssSelectors.Models
{
    internal class XcssAttribute
    {
        public AttributeMatchStyle MatchStyle;

        public string Name;

        public string Value;

        public XcssAttribute() { }

        public XcssAttribute(string name, string value, AttributeMatchStyle matchStyle)
        {
            Name = name;
            Value = value;
            MatchStyle = matchStyle;
        }
    }
}

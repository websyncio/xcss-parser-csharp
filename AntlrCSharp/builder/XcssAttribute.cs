namespace AntlrCSharp.builder
{
    internal class XcssAttribute
    {
        public AttributeMatchStyle MatchStyle;

        public string Name;

        public string Value;

        public XcssAttribute() { }

        public XcssAttribute(string name, string value, AttributeMatchStyle matchStyle)
        {
            this.Name = name;
            this.Value = value;
            this.MatchStyle = matchStyle;
        }
    }
}

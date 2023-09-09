namespace AntlrCSharp.builder
{
    internal class XCSSElement
    {
        public string Combinator;
        public string Xcss;
        public bool isValidCss;
        public bool isValidXpath;
        public String Tag;
        public String Id;
        public String Condition;
        public List<string> ClassNames = new List<string>();
        public List<XcssAttribute> Attributes = new List<XcssAttribute>();
        public List<string> Conditions = new List<string>();
        public List<string> SubelementXpaths = new List<string>();
    }

    internal class XCSSSelector
    {
        public List<XCSSElement> Elements= new List<XCSSElement>();
    }
}

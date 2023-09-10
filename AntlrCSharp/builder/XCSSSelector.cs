namespace AntlrCSharp.builder
{
    internal class XcssElement
    {
        public string Combinator;
        public string Xcss;
        public bool isValidCss;
        public bool isValidXpath;
        public String Tag;
        public String Id;
        public List<string> ClassNames = new List<string>();
        public List<XcssAttribute> Attributes = new List<XcssAttribute>();
        public List<XcssTextCondition> TextConditions = new List<XcssTextCondition>();
        public List<XcssSelector> SubelementConditions = new List<XcssSelector>();
        public List<string> SubelementXPathConditions = new List<string>();
        public List<string> Conditions = new List<string>();
        public int? Index;
    }

    internal class XcssSelector
    {
        public List<XcssElement> Elements= new List<XcssElement>();
    }
}

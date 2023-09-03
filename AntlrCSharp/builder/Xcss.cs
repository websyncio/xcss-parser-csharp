namespace AntlrCSharp.builder
{
    public class Xcss
    {
        public readonly string Css;
        public readonly string Xpath;

        public Xcss(string xpath, string css)
        {
            Css = css;
            Xpath = xpath;
        }

        public string Value
        {
            get
            {
                return string.IsNullOrEmpty(this.Css) ? this.Xpath : this.Css;
            }
        }

        public static string Concat(string scssSelector1, string scssSelector2)
        {
            return XcssBuilder.Concat(scssSelector1, scssSelector2).Value;
        }

        public Xcss Concat(Xcss xcss2)
        {
            string resultXpath = XPathBuilder.Concat(this.Xpath, xcss2.Xpath);
            var resultCss = string.IsNullOrEmpty(this.Css) || string.IsNullOrEmpty(xcss2.Css)
                                ? string.Empty
                                : CssBuilder.Concat(this.Css, xcss2.Css);
            return new Xcss(resultXpath, resultCss);
        }
    }
}

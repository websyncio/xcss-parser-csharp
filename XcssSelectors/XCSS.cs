using XcssSelectors.Builders;
using XcssSelectors.Parsers;

namespace XcssSelectors
{
    public class XCSS
    {
        public readonly string Xcss;
        public readonly string Css;
        public readonly string Xpath;
        public readonly bool CombineWithRoot;

        public XCSS(string css, string xpath, bool combineWithRoot=false)
        {
            Xcss = string.IsNullOrWhiteSpace(css) ? xpath : css;
            Css = css;
            Xpath = xpath;
            CombineWithRoot = combineWithRoot;
        }

        public XCSS(string xcssSelector, string cssSelector, string xpath)
        {
            Xcss = xcssSelector;
            Css = cssSelector;
            Xpath = xpath;
        }

        public static XCSS FromXcss(string xcssSelector)
        {
            var selectors = XcssParser.Parse(xcssSelector);
            //string css = CssBuilder.BuildFromParts(selectors);
            string xpath = XPathBuilder.Build(selectors);

            return new XCSS(null, xpath);
        }

        public XCSS Concat(XCSS xcss2)
        {
            string resultXpath = XPathBuilder.Concat(Xpath, xcss2.Xpath);
            var resultCss = string.IsNullOrEmpty(Css) || string.IsNullOrEmpty(xcss2.Css)
                                ? string.Empty
                                : CssBuilder.Concat(Css, xcss2.Css);
            return new XCSS(resultXpath, resultCss);
        }

        public static void FromXPath(string xcssSelector, bool v)
        {
            throw new NotImplementedException();
        }

        public static void FromCss(string xcssSelector, bool v)
        {
            throw new NotImplementedException();
        }
    }
}

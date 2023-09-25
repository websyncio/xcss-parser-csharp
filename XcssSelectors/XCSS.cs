using XcssSelectors.Builders;
using XcssSelectors.Parsers;

namespace XcssSelectors
{
    public class XCSS
    {
        public readonly string XcssSelector;
        public readonly string CssSelector;
        public readonly string XPath;

        public XCSS(string cssSelector, string xpath)
        {
            XcssSelector = string.IsNullOrWhiteSpace(cssSelector) ? xpath : cssSelector;
            CssSelector = cssSelector;
            XPath = xpath;
        }

        public XCSS(string xcssSelector, string cssSelector, string xpath)
        {
            XcssSelector = xcssSelector;
            CssSelector = cssSelector;
            XPath = xpath;
        }

        public static XCSS ParseSelector(string xcssSelector)
        {
            var selectors = XcssParser.Parse(xcssSelector);
            //string css = CssBuilder.BuildFromParts(selectors);
            string xpath = XPathBuilder.Build(selectors);

            return new XCSS(null, xpath);
        }

        public XCSS Concat(XCSS xcss2)
        {
            string resultXpath = XPathBuilder.Concat(XPath, xcss2.XPath);
            var resultCss = string.IsNullOrEmpty(CssSelector) || string.IsNullOrEmpty(xcss2.CssSelector)
                                ? string.Empty
                                : CssBuilder.Concat(CssSelector, xcss2.CssSelector);
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

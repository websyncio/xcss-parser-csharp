using XcssSelectors.Models;

namespace XcssSelectors.Parsers
{
    internal class XcssSelectorContext
    {
        public XcssTextCondition Text = new XcssTextCondition();
        public XcssAttribute Attribute = new XcssAttribute();
        public XcssElement Element = new XcssElement();
        public XcssSelector Selector = new XcssSelector();

        private int _xpathConditionLevel = 0;

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
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class PrintInfo
    {

        public PrintInfo()
        {
            Properties.Add("PageHeaderHeight", "30");
            Properties.Add("PageFooterHeight", "30");
            Properties.Add("PageFooter", "");
            Properties.Add("OwnerDrawPageFooter", "false");
            Properties.Add("PageHeader", "");
            Properties.Add("OwnerDrawPageHeader", "false");
            Properties.Add("RepeatColumnFooters", "false");
            Properties.Add("RepeatColumnHeaders", "true");
            Properties.Add("RepeatGridHeader", "false");
            Properties.Add("RepeatSplitHeaders", "false");
            Properties.Add("VarRowHeight", "StretchToFit");
        }

        private Dictionary<String, String> properties = new Dictionary<string, string>(11);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        private Style pageHeaderStyle = new Style("PrintPageHeaderStyle");
        public Style PageHeaderStyle
        {
            get { return pageHeaderStyle; }
            set { pageHeaderStyle = value; }
        }

        private Style pageFooterStyle = new Style("PrintPageFooterStyle");
        public Style PageFooterStyle
        {
            get { return pageFooterStyle; }
            set { pageFooterStyle = value; }
        }
    }
}

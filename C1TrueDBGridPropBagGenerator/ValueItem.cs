using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGenerator
{
    public class ValueItem
    {
        private string value = "";

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        private string dispVal = "";

        public string DispVal
        {
            get { return dispVal; }
            set { dispVal = value; }
        }

        private string imgIdx;

        public string ImgIdx
        {
            get { return imgIdx; }
            set { imgIdx = value; }
        }

        private string defaultItem;

        public string DefaultItem
        {
            get { return defaultItem; }
            set { defaultItem = value; }
        }

        public XElement ToXML()
        {
            XElement valueItem = new XElement("ValueItem", new XAttribute("type", "C1.Win.C1TrueDBGrid.ValueItem"));
            valueItem.Add(new XAttribute(nameof(this.Value), this.Value));
            if (!this.DispVal.Equals(Constants.ValueItemDefaultValues.DISPVAL_DEFAULT_VALUE))
            {
                valueItem.Add(new XAttribute(nameof(this.dispVal), this.DispVal));
            }
            return valueItem;
        }

        public static ValueItem ParseXML(XElement xElemValueItem)
        {
            ValueItem valueItem = new ValueItem();
            valueItem.Value = xElemValueItem.Attribute("Value").Value;
            valueItem.DispVal = xElemValueItem.Attribute("dispVal")?.Value;
            return valueItem;
        }
    }
}

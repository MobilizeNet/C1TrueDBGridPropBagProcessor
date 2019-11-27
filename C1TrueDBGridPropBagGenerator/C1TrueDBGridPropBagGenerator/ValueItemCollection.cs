using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGenerator
{
    public class ValueItemCollection
    {

        public ValueItemCollection()
        {
            Properties.Add("Translate", "False");
            Properties.Add("Presentation", "Normal");
            Properties.Add("MaxComboItems", "5");
            Properties.Add("Validate", "False");
            Properties.Add("CycleOnClick", "False");
            Properties.Add("AnnotatePicture", "False");
            Properties.Add("DefaultItem", "-1");
        }
        private Dictionary<String, String> properties = new Dictionary<string, string>(7);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        List<ValueItem> values = new List<ValueItem>();

        public List<ValueItem> Values
        {
            get { return values; }
            set { values = value; }
        }

        public XElement ToXML()
        {
            XElement valueItems = new XElement("ValueItems");
            // Atrributes
            string[] optionalValueItemCollectionAttributes = {
                "AnnotatePicture", "CycleOnClick", "DefaultItem", "MaxComboItems",
                "Presentation", "Translate", "Validate"
            };
            foreach (string property in optionalValueItemCollectionAttributes)
            {
                if (Properties.ContainsKey(property) && !this.Properties[property].Equals(Constants.ValueItemCollectionAbsentPropertyValues[property]))
                {
                    valueItems.Add(new XAttribute(property, this.properties[property]));
                }
            }

            if (this.Values.Count > 0)
            {
                XElement internalValues = new XElement("internalValues");
                foreach (ValueItem v in this.Values)
                {
                    internalValues.Add(v.ToXML());
                }
                valueItems.Add(internalValues);
            }
            

            return valueItems;
        }

        public static ValueItemCollection ParseXML(XElement xElemValueItemCollection)
        {
            ValueItemCollection valueItemCollection = new ValueItemCollection();
            foreach(XAttribute attribute in xElemValueItemCollection.Attributes())
            {
                valueItemCollection.Properties[attribute.Name.ToString()] = attribute.Value;
            }
            IEnumerable<XElement> internalValues = xElemValueItemCollection.Element("internalValues")?.Elements();
            if(internalValues != null)
            {
                foreach (XElement valueItem in internalValues)
                {
                    valueItemCollection.Values.Add(ValueItem.ParseXML(valueItem));
                }
            }
            return valueItemCollection;
        }
    }
}

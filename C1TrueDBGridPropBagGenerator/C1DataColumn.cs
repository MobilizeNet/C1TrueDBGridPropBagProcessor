using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGenerator
{
    public class C1DataColumn
    {

        public C1DataColumn()
        {
            Properties.Add("Caption", "");
            Properties.Add("DataField", "");
            Properties.Add("DataWidth", "0");
            Properties.Add("DefaultValue", "");
            Properties.Add("EditMask", "");
            Properties.Add("EditMaskUpdate", "False");
            Properties.Add("FilterText", "");
            Properties.Add("FooterText", "");
            Properties.Add("NumberFormat", "");
            Properties.Add("FilterCancelText", "&Close");
            Properties.Add("FilterClearText", "C&lear");
        }

        private Dictionary<String, String> properties = new Dictionary<string, string>(9);

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }
      
        private ValueItemCollection valueItems = new ValueItemCollection();

        public ValueItemCollection ValueItems
        {
            get { return valueItems;  }
            set { valueItems = value; }
        }

        private GroupInfo groupInfo = new GroupInfo();

        public GroupInfo GroupInfo
        {
            get { return groupInfo; }
            set { groupInfo = value; }
        }


        public XElement ToXML()
        {
            XElement c1DataColumn = new XElement(nameof(C1DataColumn));
            
            foreach (string property in Properties.Keys)
            {
                //is XML Property
                if (Constants.DataColumnNodeProperties.Contains(property))
                {
                    if (!Constants.ColumnAbsentPropertyValues.ContainsKey(property) ||
                    !Properties[property].Equals(Constants.ColumnAbsentPropertyValues[property]))
                    {
                        c1DataColumn.Add(new XElement(property, Properties[property]));
                    }
                } // is Node Proeprty
                else if (Constants.DataColumnXmlAttributes.Contains(property))
                {
                    if ((!Constants.ColumnAbsentPropertyValues.ContainsKey(property)) ||
                    !Properties[property].Equals(Constants.ColumnAbsentPropertyValues[property]))
                    {
                        c1DataColumn.Add(new XAttribute(property, this.properties[property]));
                    }
                } else
                {
                    Console.WriteLine($"{property} not added for C1DataColumn");
                }
            }

            c1DataColumn.Add(this.ValueItems.ToXML());
            c1DataColumn.Add(this.groupInfo.ToXML());

            return c1DataColumn;
        }

        public static C1DataColumn ParseXML(XElement xElemCol)
        {
            C1DataColumn column = new C1DataColumn();
            foreach(XAttribute attribute in xElemCol.Attributes())
            {
                column.properties[attribute.Name.ToString()] = attribute.Value;
            }
            IEnumerable<XElement> childNodes = xElemCol.Elements().Where(x => x.Name.ToString() != "GroupInfo" && x.Name.ToString() != "ValueItems");
            foreach(XElement prop in childNodes)
            {
                column.Properties[prop.Name.ToString()] = prop.Value;
            }
            column.ValueItems = ValueItemCollection.ParseXML(xElemCol.Element("ValueItems"));
            column.groupInfo = GroupInfo.ParseXML(xElemCol.Element("GroupInfo"));
            return column;
        }
    }
}

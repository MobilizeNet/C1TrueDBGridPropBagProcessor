using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGenerator
{
    public class GroupInfo
    {
        public GroupInfo()
        {
            properties["AggregatesText"] = "{0}";
            properties["Position"] = "Header";
            properties["OutlineMode"] = "StartCollapsed";
            properties["HeaderText"] = "{1}: {0}";
            properties["FooterText"] = "";
            properties["Interval"] = "Default";
            properties["ColumnVisible"] = "False";
        }

        private Dictionary<String, String> properties = new Dictionary<string, string>();

        public Dictionary<String, String> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        public XElement ToXML()
        {
            XElement groupInfo = new XElement(nameof(GroupInfo));
            foreach(string property in properties.Keys)
            {
                if(!Constants.GroupInfoAbsentPropertyValues.ContainsKey(property) || properties[property] != Constants.GroupInfoAbsentPropertyValues[property])
                {
                    groupInfo.Add(new XElement(property, properties[property]));
                }
            }
            return groupInfo;
        }

        public static GroupInfo ParseXML(XElement xElemGroupInfo)
        {
            GroupInfo groupInfo = new GroupInfo();
            foreach(XElement property in xElemGroupInfo.Elements())
            {
                groupInfo.Properties[property.Name.ToString()] = property.Value;
            }
            return groupInfo;
        }
    }
}

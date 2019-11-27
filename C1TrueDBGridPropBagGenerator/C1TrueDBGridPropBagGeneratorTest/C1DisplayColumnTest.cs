using C1TrueDBGridPropBagGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class C1DisplayColumnTest
    {
        [TestMethod]
        public void WidthTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "100";
            //Act
            string actualResult = disColumn.Properties["Width"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void HeightTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "15";
            //Act
            string actualResult = disColumn.Properties["Height"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowSizingTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "True";
            //Act
            string actualResult = disColumn.Properties["AllowSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void VisibleTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "True";
            //Act
            string actualResult = disColumn.Properties["Visible"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowFocusTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "True";
            //Act
            string actualResult = disColumn.Properties["AllowFocus"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AutoCompleteTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["AutoComplete"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AutoDropDownTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["AutoDropDown"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ButtonTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["Button"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ButtonAlwaysTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["ButtonAlways"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ButtonFooterTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["ButtonFooter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ButtonHeaderTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["ButtonHeader"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ButtonTextTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["ButtonText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DropDownListTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["DropDownList"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FetchStyleTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["FetchStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FilterButtonTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["FilterButton"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LockedTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["Locked"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MergeTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "None";
            //Act
            string actualResult = disColumn.Properties["Merge"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MinWidthTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "0";
            //Act
            string actualResult = disColumn.Properties["MinWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OwnerDrawTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "False";
            //Act
            string actualResult = disColumn.Properties["OwnerDraw"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FooterDividerTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "True";
            //Act
            string actualResult = disColumn.Properties["FooterDivider"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void HeaderDividerTestDefaultValue()
        {
            //Arrange
            C1DisplayColumn disColumn = new C1DisplayColumn();
            string expectedResult = "True";
            //Act
            string actualResult = disColumn.Properties["HeaderDivider"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXmlTest_HasBaseXml()
        {
            // Arrange
            C1DisplayColumn dispColumn = new C1DisplayColumn();
            XElement displayColumnXelement = dispColumn.ToXML();
            List<string> baseElements = new List<string>();
            baseElements.Add("HeadingStyle");
            baseElements.Add("ColumnSelectorStyle");
            baseElements.Add("Style");
            baseElements.Add("FooterStyle");
            baseElements.Add("EditorStyle");
            baseElements.Add("GroupHeaderStyle");
            baseElements.Add("GroupFooterStyle");
            baseElements.Add("ColumnDivider");
            baseElements.Add("DCIdx");
            // Act
            bool actualResult = baseElements.TrueForAll(x => displayColumnXelement.Element(x) != null);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void AssignStyleNameParentTest_Parents()
        {
            // Arrange
            Split split = new Split();
            C1DisplayColumn dispCol = new C1DisplayColumn();
            split.DisplayCols.Add(dispCol);
            int count = 0;
            // Act
            split.AssignStyleNameParent(ref count);
            bool actualResult = dispCol.Styles["HeadingStyle"].Parent.Equals(split.Styles["HeadingStyle"].Name) &&
                dispCol.Styles["ColumnSelectorStyle"].Parent.Equals(split.Styles["ColumnSelectorStyle"].Name) &&
                dispCol.Styles["Style"].Parent.Equals(split.Styles["Style"].Name) &&
                dispCol.Styles["FooterStyle"].Parent.Equals(split.Styles["FooterStyle"].Name) &&
                dispCol.Styles["EditorStyle"].Parent.Equals(split.Styles["EditorStyle"].Name) &&
                dispCol.Styles["GroupHeaderStyle"].Parent.Equals(split.Styles["Style"].Name) &&
                dispCol.Styles["GroupFooterStyle"].Parent.Equals(split.Styles["Style"].Name);
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTestProperties()
        {
            // Arrange
            XElement dispCol = XElement.Parse(@"<C1DisplayColumn>" +
                    @"<HeadingStyle parent=""Style2"" me=""Style15""/>" +
                    @"<ColumnSelectorStyle parent=""Style14"" me=""Style16""/>" +
                    @"<Style parent=""Style1"" me=""Style17""/>" +
                    @"<FooterStyle parent=""Style3"" me=""Style18""/>" +
                    @"<EditorStyle parent=""Style5"" me=""Style19""/>" +
                    @"<GroupHeaderStyle parent=""Style1"" me=""Style21""/>" +
                    @"<GroupFooterStyle parent=""Style1"" me=""Style20""/>" +
                    @"<Visible>True</Visible>" +
                    @"<ColumnDivider>Green,Raised</ColumnDivider>" +
                    @"<Width>104</Width>" +
                    @"<Height>15</Height>" +
                    @"<ButtonText>True</ButtonText>" +
                    @"<DCIdx>2</DCIdx>" +
                @"</C1DisplayColumn>");
            // Act
            C1DisplayColumn displayColumn = C1DisplayColumn.ParseXML(dispCol);
            bool actualResult = displayColumn.Properties["Width"] == "104" &&
                displayColumn.Properties["Height"] == "15" &&
                displayColumn.Properties["Visible"] == "True" &&
                displayColumn.Properties["ButtonText"] == "True" &&
                displayColumn.Properties["DCIdx"] == "2" &&
                displayColumn.ColumnDivider.ToXMLTagString() == "Green,Raised";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTestStyles()
        {
            // Arrange
            XElement dispCol = XElement.Parse(@"<C1DisplayColumn>" +
                    @"<HeadingStyle parent=""Style2"" me=""Style15""/>" +
                    @"<ColumnSelectorStyle parent=""Style14"" me=""Style16""/>" +
                    @"<Style parent=""Style1"" me=""Style17""/>" +
                    @"<FooterStyle parent=""Style3"" me=""Style18""/>" +
                    @"<EditorStyle parent=""Style5"" me=""Style19""/>" +
                    @"<GroupHeaderStyle parent=""Style1"" me=""Style21""/>" +
                    @"<GroupFooterStyle parent=""Style1"" me=""Style20""/>" +
                    @"<Visible>True</Visible>" +
                    @"<ColumnDivider>Green,Raised</ColumnDivider>" +
                    @"<Width>104</Width>" +
                    @"<Height>15</Height>" +
                    @"<ButtonText>True</ButtonText>" +
                    @"<DCIdx>2</DCIdx>" +
                @"</C1DisplayColumn>");
            // Act
            C1DisplayColumn displayColumn = C1DisplayColumn.ParseXML(dispCol);
            bool actualResult = displayColumn.Styles["HeadingStyle"].Parent == "Style2" && displayColumn.Styles["HeadingStyle"].Name == "Style15" &&
                displayColumn.Styles["ColumnSelectorStyle"].Parent == "Style14" && displayColumn.Styles["ColumnSelectorStyle"].Name == "Style16" &&
                displayColumn.Styles["Style"].Parent == "Style1" && displayColumn.Styles["Style"].Name == "Style17" &&
                displayColumn.Styles["FooterStyle"].Parent == "Style3" && displayColumn.Styles["FooterStyle"].Name == "Style18" &&
                displayColumn.Styles["EditorStyle"].Parent == "Style5" && displayColumn.Styles["EditorStyle"].Name == "Style19" &&
                displayColumn.Styles["GroupHeaderStyle"].Parent == "Style1" && displayColumn.Styles["GroupHeaderStyle"].Name == "Style21" &&
                displayColumn.Styles["GroupFooterStyle"].Parent == "Style1" && displayColumn.Styles["GroupFooterStyle"].Name == "Style20";
            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}

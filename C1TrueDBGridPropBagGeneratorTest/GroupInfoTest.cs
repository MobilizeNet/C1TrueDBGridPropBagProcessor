using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class GroupInfoTest
    {
        [TestMethod]
        public void AggregatesTextTestDefaultValue()
        {
            // Arrange
            GroupInfo groupInfo = new GroupInfo();
            string expectedResult = "{0}";
            // Act
            string actualResult = groupInfo.Properties["AggregatesText"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PositionTestDefaultValue()
        {
            // Arrange
            GroupInfo groupInfo = new GroupInfo();
            string expectedResult = "Header";
            // Act
            string actualResult = groupInfo.Properties["Position"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OutlineModeTestDefaultValue()
        {
            // Arrange
            GroupInfo groupInfo = new GroupInfo();
            string expectedResult = "StartCollapsed";
            // Act
            string actualResult = groupInfo.Properties["OutlineMode"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void HeaderTextTestDefaultValue()
        {
            // Arrange
            GroupInfo groupInfo = new GroupInfo();
            string expectedResult = "{1}: {0}";
            // Act
            string actualResult = groupInfo.Properties["HeaderText"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FooterTextTestDefaultValue()
        {
            // Arrange
            GroupInfo groupInfo = new GroupInfo();
            string expectedResult = "";
            // Act
            string actualResult = groupInfo.Properties["FooterText"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IntervalTestDefaultValue()
        {
            // Arrange
            GroupInfo groupInfo = new GroupInfo();
            string expectedResult = "Default";
            // Act
            string actualResult = groupInfo.Properties["Interval"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ColumnVisibleTestDefaultValue()
        {
            // Arrange
            GroupInfo groupInfo = new GroupInfo();
            string expectedResult = "False";
            // Act
            string actualResult = groupInfo.Properties["ColumnVisible"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXMLTest_HasBaseElements()
        {
            // Arrange
            GroupInfo groupInfo = new GroupInfo();
            // Act
            bool actualResult = groupInfo.ToXML().Element("AggregatesText") != null;
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTest()
        {
            // Arrange
            XElement groupInfoXML = XElement.Parse(@"<GroupInfo>" +
                @"<AggregatesText>{0}</AggregatesText>" +
                @"<Position>HeaderAndFooter</Position>" +
                @"<OutlineMode>StartExpanded</OutlineMode>" +
                @"<HeaderText>Custom</HeaderText>" +
                @"<FooterText>abc</FooterText>" +
                @"<Interval>Date</Interval>" +
                @"<ColumnVisible>True</ColumnVisible>" +
            @" </GroupInfo>");
            // Act
            GroupInfo groupInfo = GroupInfo.ParseXML(groupInfoXML);
            bool actualResult = groupInfo.Properties["AggregatesText"] == "{0}" &&
                groupInfo.Properties["Position"] == "HeaderAndFooter" &&
                groupInfo.Properties["OutlineMode"] == "StartExpanded" &&
                groupInfo.Properties["HeaderText"] == "Custom" &&
                groupInfo.Properties["FooterText"] == "abc" &&
                groupInfo.Properties["Interval"] == "Date" &&
                groupInfo.Properties["ColumnVisible"] == "True";
            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}

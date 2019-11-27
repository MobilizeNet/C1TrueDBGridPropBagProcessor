using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for PrintInfoTest
    /// </summary>
    [TestClass]
    public class PrintInfoTest
    {
        [TestMethod]
        public void PageHeaderHeightTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "30";
            //Act
            string actualResult = printI.Properties["PageHeaderHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PageFooterHeightTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "30";
            //Act
            string actualResult = printI.Properties["PageFooterHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PageFooterTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "";
            //Act
            string actualResult = printI.Properties["PageFooter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OwnerDrawPageFooterTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "false";
            //Act
            string actualResult = printI.Properties["OwnerDrawPageFooter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PageHeaderTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "";
            //Act
            string actualResult = printI.Properties["PageHeader"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OwnerDrawPageHeaderTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "false";
            //Act
            string actualResult = printI.Properties["OwnerDrawPageHeader"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RepeatColumnFootersTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "false";
            //Act
            string actualResult = printI.Properties["RepeatColumnFooters"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RepeatColumnHeadersTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "true";
            //Act
            string actualResult = printI.Properties["RepeatColumnHeaders"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RepeatGridHeaderTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "false";
            //Act
            string actualResult = printI.Properties["RepeatGridHeader"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RepeatSplitHeadersTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "false";
            //Act
            string actualResult = printI.Properties["RepeatSplitHeaders"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void VarRowHeightTestDefaultValue()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            string expectedResult = "StretchToFit";
            //Act
            string actualResult = printI.Properties["VarRowHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PageHeaderStyleTest1()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            Style pageHeaderStyle = new Style("Style");
            pageHeaderStyle.Properties["Font"] = "MS Outlook, 9.75pt, style=Bold";
            printI.PageHeaderStyle = pageHeaderStyle;
            string expectedResult = "MS Outlook, 9.75pt, style=Bold";
            //Act
            string actualResult = printI.PageHeaderStyle.Properties["Font"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PageFooterStyleTest1()
        {
            //Arrange
            PrintInfo printI = new PrintInfo();
            Style pageFooterStyle = new Style("Style");
            pageFooterStyle.Properties["BackColor"] = "Red";
            printI.PageFooterStyle = pageFooterStyle;
            string expectedResult = "Red";
            //Act
            string actualResult = printI.PageFooterStyle.Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

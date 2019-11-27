using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for PrintInfoPropertyReaderTest
    /// </summary>
    [TestClass]
    public class PrintInfoPropertyReaderTest
    {
        [TestMethod]
        public void ProcessPrintInfoPropertyTestPageHeaderHeight()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "PageHeaderHeight", "4");
            string expectedResult = "4";
            //Act
            string actualResult = printInfo.Properties["PageHeaderHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestPageFooterHeight()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "PageFooterHeight", "4");
            string expectedResult = "4";
            //Act
            string actualResult = printInfo.Properties["PageFooterHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestPageFooter()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "PageFooter", "\"abc\"");
            string expectedResult = "abc";
            //Act
            string actualResult = printInfo.Properties["PageFooter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestOwnerDrawPageFooter()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "OwnerDrawPageFooter", "true");
            string expectedResult = "true";
            //Act
            string actualResult = printInfo.Properties["OwnerDrawPageFooter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestPageHeader()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "PageHeader", "\"abc\"");
            string expectedResult = "abc";
            //Act
            string actualResult = printInfo.Properties["PageHeader"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestOwnerDrawPageHeader()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "OwnerDrawPageHeader",  "true");
            string expectedResult = "true";
            //Act
            string actualResult = printInfo.Properties["OwnerDrawPageHeader"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestRepeatColumnFooters()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "RepeatColumnFooters", "true");
            string expectedResult = "true";
            //Act
            string actualResult = printInfo.Properties["RepeatColumnFooters"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestRepeatColumnHeaders()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "RepeatColumnHeaders", "true");
            string expectedResult = "true";
            //Act
            string actualResult = printInfo.Properties["RepeatColumnHeaders"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestRepeatGridHeader()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "RepeatGridHeader", "true");
            string expectedResult = "true";
            //Act
            string actualResult = printInfo.Properties["RepeatGridHeader"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestRepeatSplitHeaders()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "RepeatSplitHeaders", "true");
            string expectedResult = "true";
            //Act
            string actualResult = printInfo.Properties["RepeatSplitHeaders"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestVarRowHeight()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();
            
            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "VarRowHeight", "C1.Win.C1TrueDBGrid.PrintInfo.RowHeightEnum.LikeGrid");
            string expectedResult = "LikeGrid";
            //Act
            string actualResult = printInfo.Properties["VarRowHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPrintInfoPropertyTestPageHeaderStyle()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();

            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "PageHeaderStyle.HorizontalAlignment", "C1.Win.C1TrueDBGrid.AlignHorzEnum.Justify");
            string expectedResult = "Justify";
            //Act
            string actualResult = printInfo.PageHeaderStyle.Properties["AlignHorz"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ProcessPrintInfoPropertyTestPageFooterStyle()
        {
            //Arrange
            PrintInfo printInfo = new PrintInfo();

            PrintInfoPropertyReader.ProcessPrintInfoProperty(printInfo, "PageFooterStyle.Font", "new System.Drawing.Font(\"Microsoft Sans Serif\", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)");
            string expectedResult = "Microsoft Sans Serif, 9.75pt";
            //Act
            string actualResult = printInfo.PageFooterStyle.Properties["Font"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

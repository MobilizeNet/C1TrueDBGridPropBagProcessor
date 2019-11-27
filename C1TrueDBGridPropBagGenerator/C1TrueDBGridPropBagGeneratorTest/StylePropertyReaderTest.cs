using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Collections.Specialized;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for StylePropertyReaderTest
    /// </summary>
    [TestClass]
    public class StylePropertyReaderTest
    {
        [TestMethod]
        public void ProcessStylePropertyTestBackColor()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "BackColor", "System.Drawing.Color.FromArgb(255, 0, 128)");
            string expectedResult = "255, 0, 128";
            //Act
            string actualResult = style.Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessStylePropertyTestBackGroundPictureDrawMode()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "BackGroundPictureDrawMode", "C1.Win.C1TrueDBGrid.BackgroundPictureDrawModeEnum.Center");
            string expectedResult = "Center";
            //Act
            string actualResult = style.Properties["AlignImage"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessStylePropertyTestFont()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "Font", "new System.Drawing.Font(\"Arial\", 8.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 177)");
            string expectedResult = "Arial, 8.75pt";
            //Act
            string actualResult = style.Properties["Font"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ProcessStylePropertyTestForeColor()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "BackColor", "System.Drawing.Color.FromArgb(255, 0, 128)");
            string expectedResult = "255, 0, 128";
            //Act
            string actualResult = style.Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessStylePropertyTestForegroundImagePos()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "ForegroundPicturePosition", "C1.Win.C1TrueDBGrid.ForeGroundPicturePositionEnum.LeftOfText");
            string expectedResult = "LeftOfText";
            //Act
            string actualResult = style.Properties["ForegroundImagePos"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ProcessStylePropertyTestAlignHorz()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "HorizontalAlignment", "C1.Win.C1TrueDBGrid.AlignHorzEnum.Far");
            string expectedResult = "Far";
            //Act
            string actualResult = style.Properties["AlignHorz"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ProcessStylePropertyTestLocked()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "Locked", "true");
            string expectedResult = "True";
            //Act
            string actualResult = style.Properties["Locked"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessStylePropertyTestAlignVert()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "VerticalAlignment", "C1.Win.C1TrueDBGrid.AlignVertEnum.Bottom");
            string expectedResult = "Bottom";
            //Act
            string actualResult = style.Properties["AlignVert"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessStylePropertyTestWrapText()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "Wrap", "C1.Win.C1TrueDBGrid.TextWrapping.Wrap");
            string expectedResult = "Wrap";
            //Act
            string actualResult = style.Properties["WrapText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessStylePropertyTestBorders()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "Borders.BorderType", "C1.Win.C1TrueDBGrid.BorderTypeEnum.Groove");
            string expectedResult = "Groove";
            //Act
            string actualResult = style.Borders.Properties["BorderType"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessStylePropertyTestPaddingProperty()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "Padding.Right", "6");
            string expectedResult = "6";
            //Act
            string actualResult = style.Padding.Properties["Right"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessStylePropertyTestPaddingObject()
        {
            //Arrange
            Style style = new Style("Style");
            StylePropertyReader.ProcessStyleProperty(style, "Padding", "new System.Drawing.Printing.Margins(3, 2, 3, 7)");
            string expectedResult = "7";
            //Act
            string actualResult = style.Padding.Properties["Bottom"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

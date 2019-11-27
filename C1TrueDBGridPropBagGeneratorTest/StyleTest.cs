using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for StyleTest
    /// </summary>
    [TestClass]
    public class StyleTest
    {

        [TestMethod]
        public void ParentTestSetAndGet()
        {
            //Arrange
            Style style = new Style("Style");
            style.Parent = "1";
            string expectedResult = "1";
            //Act
            string actualResult = style.Parent;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NameTestSetAndGet()
        {
            //Arrange
            Style style = new Style("Style");
            style.Name = "abc";
            string expectedResult = "abc";
            //Act
            string actualResult = style.Name;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BackimgIdxTestSetAndGet()
        {
            //Arrange
            Style style = new Style("Style");
            style.BackimgIdx = 2;
            int expectedResult = 2;
            //Act
            int actualResult = style.BackimgIdx;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ForeimgIdxTestSetAndGet()
        {
            //Arrange
            Style style = new Style("Style");
            style.ForeimgIdx = 3;
            int expectedResult = 3;
            //Act
            int actualResult = style.ForeimgIdx;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TypeTestSetAndGet()
        {
            //Arrange
            Style style = new Style("Style");
            style.Type = "HeadingStyle";
            string expectedResult = "HeadingStyle";
            //Act
            string actualResult = style.Type;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_ParentNull()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["ForeColor"] = "Red";
            style.Name = "Style1";
            string expectedResult = "Style1{ForeColor:Red;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_ParentSameValue()
        {
            //Arrange
            Style style = new Style("Style");
            Style parent = new Style("Style");
            style.Properties["ForeColor"] = "Red";
            style.Name = "Style1";
            parent.Properties["ForeColor"] = "Red";
            string expectedResult = "Style1{}";
            //Act
            string actualResult = style.ToStyleString(parent);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_ParentDifferentValue()
        {
            //Arrange
            Style style = new Style("Style");
            Style parent = new Style("Style");
            style.Properties["ForeColor"] = "Red";
            style.Name = "Style1";
            parent.Properties["ForeColor"] = "Blue";
            string expectedResult = "Style1{ForeColor:Red;}";
            //Act
            string actualResult = style.ToStyleString(parent);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_WrapText()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["WrapText"] = "NoWrap";
            style.Name = "Style1";
            string expectedResult = "Style1{WrapText:NoWrap;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_ForegroundImagePos()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["ForegroundImagePos"] = "LeftOfText";
            style.Name = "Style1";
            string expectedResult = "Style1{ForegroundImagePos:LeftOfText;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_AlignImage()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["AlignImage"] = "Center";
            style.Name = "Style1";
            string expectedResult = "Style1{AlignImage:Center;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_ForeColor()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["ForeColor"] = "Green";
            style.Name = "Style1";
            string expectedResult = "Style1{ForeColor:Green;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_AlignHorz()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["AlignHorz"] = "Near";
            style.Name = "Style1";
            string expectedResult = "Style1{AlignHorz:Near;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_AlignVert()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["AlignVert"] = "Bottom";
            style.Name = "Style1";
            string expectedResult = "Style1{AlignVert:Bottom;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_Border()
        {
            //Arrange
            Style style = new Style("Style");
            style.Borders = new GridBorders();
            style.Borders.Properties["BorderType"] = "Flat";
            style.Borders.Properties["Color"] = "ControlDark";
            style.Borders.Properties["Left"] = "0";
            style.Borders.Properties["Right"] = "1";
            style.Borders.Properties["Top"] = "0";
            style.Borders.Properties["Bottom"] = "1";
            style.Name = "Style1";
            string expectedResult = "Style1{Border:Flat,ControlDark,0,1,0,1;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_Padding()
        {
            //Arrange
            Style style = new Style("Style");
            style.Padding = new Margins();
            style.Padding.Properties["Left"] = "2";
            style.Padding.Properties["Right"] = "1";
            style.Padding.Properties["Top"] = "5";
            style.Padding.Properties["Bottom"] = "7";
            style.Name = "Style1";
            string expectedResult = "Style1{Padding:2,1,5,7;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_BackImg()
        {
            //Arrange
            Style style = new Style("Style");
            style.BackimgIdx = 2;
            style.Name = "Style1";
            string expectedResult = "Style1{BackgroundImage:System.Drawing.Bitmap;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_ForeImg()
        {
            //Arrange
            Style style = new Style("Style");
            style.ForeimgIdx = 1;
            style.Name = "Style1";
            string expectedResult = "Style1{ForegroundImage:System.Drawing.Bitmap;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_BackColor()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["BackColor"] = "Yellow";
            style.Name = "Style1";
            string expectedResult = "Style1{BackColor:Yellow;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_Font()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["Font"] = "Microsoft Sans Serif, 8.25pt";
            style.Name = "Style1";
            string expectedResult = "Style1{Font:Microsoft Sans Serif, 8.25pt;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToStyleStringTest_Locked()
        {
            //Arrange
            Style style = new Style("Style");
            style.Properties["Locked"] = "False";
            style.Name = "Style1";
            string expectedResult = "Style1{Locked:False;}";
            //Act
            string actualResult = style.ToStyleString(null);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseStyleStringTest()
        {
            // Arrange
            Style style = new Style("Style");
            //Act
            style.ParseStyleString("Normal{BackColor2:AliceBlue;Border:Raised,,1, 1, 1, 1;GammaCorrection:True;AlignHorz:Near;GradientMode:BackwardDiagonal;AlignVert:Center;ForegroundImagePos:Far;Alpha:254;Trimming:EllipsisCharacter;AlignImage:Stretch;Locked:False;Font:Microsoft Sans Serif, 8.25pt;WrapText:WrapWithOverflow;ForeColor:InactiveCaption;BackColor:Yellow;}");
            bool actualResult = style.Properties["BackColor2"] == "AliceBlue" && 
                style.Properties["GammaCorrection"] == "True";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseStyleStringTestBorder()
        {
            // Arrange
            Style style = new Style("Style");
            //Act
            style.ParseStyleString("Normal{BackColor2:AliceBlue;Border:Raised,Blue,1, 1, 1, 1;GammaCorrection:True;AlignHorz:Near;GradientMode:BackwardDiagonal;AlignVert:Center;ForegroundImagePos:Far;Alpha:254;Trimming:EllipsisCharacter;AlignImage:Stretch;Locked:False;Font:Microsoft Sans Serif, 8.25pt;WrapText:WrapWithOverflow;ForeColor:InactiveCaption;BackColor:Yellow;}");
            bool actualResult = style.Borders.Properties["BorderType"] == "Raised" &&
                style.Borders.Properties["Color"] == "Blue";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseStyleStringTestPadding()
        {
            // Arrange
            Style style = new Style("Style");
            //Act
            style.ParseStyleString("Normal{BackColor2:AliceBlue;Border:Raised,Blue,1, 1, 1, 1;Padding:1, 2, 3, 4;GammaCorrection:True;AlignHorz:Near;GradientMode:BackwardDiagonal;AlignVert:Center;ForegroundImagePos:Far;Alpha:254;Trimming:EllipsisCharacter;AlignImage:Stretch;Locked:False;Font:Microsoft Sans Serif, 8.25pt;WrapText:WrapWithOverflow;ForeColor:InactiveCaption;BackColor:Yellow;}");
            bool actualResult = style.Padding.Properties["Top"] == "3" &&
                style.Padding.Properties["Bottom"] == "4";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ToXMLTest()
        {
            // Arrange
            Style style = new Style("Style");
            style.Name = "Style1";
            style.Parent = "Style2";
            //Act
            XElement xelem = style.ToXML();
            // Assert
            bool actualResult = xelem.Attribute("me").Value == "Style1" && xelem.Attribute("parent").Value == "Style2";
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTest()
        {
            // Arrange
            XElement styleXelem = XElement.Parse("<Style parent=\"Style1\" me=\"Style28\" backimgIdx=\"3\" foreimgIdx=\"2\" />");
            // Act
            Style style = Style.ParseXML(styleXelem);
            // Assert
            bool actualResult = style.Parent == "Style1" && style.Name == "Style28" && style.BackimgIdx == 3 && style.ForeimgIdx == 2;
            Assert.IsTrue(actualResult);
        }
    }
}

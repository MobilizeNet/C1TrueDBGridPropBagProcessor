using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Drawing;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for UtilitiesTest
    /// </summary>
    [TestClass]
    public class UtilitiesTest
    {
        [TestMethod]
        public void ConvertColorTestDecimal()
        {
            //Arrange
            Color expectedResult = Color.Blue;
            //Act
            Color actualResult = Utilities.ConvertColor("16711680");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ConvertColorTestHexadecimal()
        {
            //Arrange
            Color expectedResult = Color.Red;
            //Act
            Color actualResult = Utilities.ConvertColor("&HFF&");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ColorNameTest()
        {
            //Arrange
            string expectedResult = "Black";
            //Act
            string actualResult = Utilities.ColorName(Color.Black);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColorTestRgbColor()
        {
            //Arrange
            string expectedResult = "255, 0, 128";
            //Act
            string actualResult = Utilities.ProcessColorProperty("System.Drawing.Color.FromArgb(255, 0, 128)");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColorTestColor()
        {
            //Arrange
            string expectedResult = "Blue";
            //Act
            string actualResult = Utilities.ProcessColorProperty("System.Drawing.Color.Blue");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColorTestSystemColor()
        {
            //Arrange
            string expectedResult = "Info";
            //Act
            string actualResult = Utilities.ProcessColorProperty("System.Drawing.SystemColors.Info");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessFontPropertyTest1()
        {
            //Arrange
            string expectedResult = "MS Outlook, 9.75pt, style=Bold";
            //Act
            string actualResult = Utilities.ProcessFontProperty("new System.Drawing.Font(\"MS Outlook\", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessFontPropertyTest2()
        {
            //Arrange
            string expectedResult = "Arial, 8.75pt, style=Bold, Italic, Underline, Strikeout";
            //Act
            string actualResult = Utilities.ProcessFontProperty("new System.Drawing.Font(\"Arial\", 8.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Strikeout | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessFontPropertyTest3()
        {
            //Arrange
            string expectedResult = "Arial, 8.75pt, style=Bold, Italic";
            //Act
            string actualResult = Utilities.ProcessFontProperty("new System.Drawing.Font(\"Arial\", 8.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StringToBooleanTestFalse()
        {
            //Arrange
            bool expectedResult = false;
            //Act
            bool actualResult = Utilities.StringToBoolean("0");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StringToBooleanTestTrue()
        {
            //Arrange
            bool expectedResult = true;
            //Act
            bool actualResult = Utilities.StringToBoolean("-1");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanPropertyTest()
        {
            //Arrange
            string expectedResult = "-1";
            //Act
            string actualResult = Utilities.CleanProperty("   -1  'True");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanXmlPropertyTest1()
        {
            //Arrange
            string expectedResult = "abc";
            //Act
            string actualResult = Utilities.CleanXMLProperty("\"abc\"");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanXmlPropertyTest2()
        {
            //Arrange
            string expectedResult = "Double";
            //Act
            string actualResult = Utilities.CleanXMLProperty("C1.Win.C1TrueDBGrid.LineStyleEnum.Double");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanXmlPropertyTest3()
        {
            //Arrange
            string expectedResult = "True";
            //Act
            string actualResult = Utilities.CleanXMLProperty("true");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanXmlPropertyTest4()
        {
            //Arrange
            string expectedResult = "23";
            //Act
            string actualResult = Utilities.CleanXMLProperty("23");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanGridPropertyTest1()
        {
            //Arrange
            string expectedResult = "def";
            //Act
            string actualResult = Utilities.CleanGridProperty("\"def\"");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanGridPropertyTest2()
        {
            //Arrange
            string expectedResult = "Double";
            //Act
            string actualResult = Utilities.CleanGridProperty("C1.Win.C1TrueDBGrid.LineStyleEnum.Double");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanGridPropertyTest3()
        {
            //Arrange
            string expectedResult = "true";
            //Act
            string actualResult = Utilities.CleanGridProperty("true");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CleanGridPropertyTest4()
        {
            //Arrange
            string expectedResult = "23";
            //Act
            string actualResult = Utilities.CleanGridProperty("23");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsStringTest1()
        {
            // Act
            bool actualResult = Utilities.IsString("\"\"");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsStringTest2()
        {
            // Act
            bool actualResult = Utilities.IsString("\"abc\"");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsStringTest3()
        {
            // Act
            bool actualResult = Utilities.IsString("");
            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsStringTest4()
        {
            // Act
            bool actualResult = Utilities.IsString("123");
            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsBooleanTest1()
        {
            // Act
            bool actualResult = Utilities.IsBoolean("true");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsBooleanTest2()
        {
            // Act
            bool actualResult = Utilities.IsBoolean("false");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsBooleanTest3()
        {
            // Act
            bool actualResult = Utilities.IsBoolean("abc");
            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void PropertyIntValueTestPositive()
        {
            //Arrange
            int expectedResult = 0;
            //Act
            int actualResult = Utilities.PropertyIntValue("0");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyIntValueTestNegative()
        {
            //Arrange
            int expectedResult = -1;
            //Act
            int actualResult = Utilities.PropertyIntValue("-1");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveQuotesTest()
        {
            //Arrange
            string expectedResult = "abc";
            //Act
            string actualResult = Utilities.RemoveQuotes("\" abc \"");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveBeginEndQuotesTest1()
        {
            //Arrange
            string expectedResult = "abc";
            //Act
            string actualResult = Utilities.RemoveBeginEndQuotes("\"abc\"");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveBeginEndQuotesTest2()
        {
            //Arrange
            string expectedResult = "abc\"def";
            //Act
            string actualResult = Utilities.RemoveBeginEndQuotes("\"abc\"def\"");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveBeginEndQuotesTest3()
        {
            //Arrange
            string expectedResult = "abc\"def";
            //Act
            string actualResult = Utilities.RemoveBeginEndQuotes("abc\"def");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BooleanToStringTestFalse()
        {
            //Arrange
            string expectedResult = "False";
            //Act
            string actualResult = Utilities.BooleanToString("0");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BooleanToStringTestTrue()
        {
            //Arrange
            string expectedResult = "True";
            //Act
            string actualResult = Utilities.BooleanToString("-1");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FirstCharToUpperTest()
        {
            //Arrange
            string expectedResult = "True";
            //Act
            string actualResult = Utilities.FirstCharToUpper("true");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnumValueToStringTest()
        {
            //Arrange
            string expectedResult = "General";
            //Act
            string actualResult = Utilities.EnumValueToString("C1.Win.C1TrueDBGrid.AlignHorzEnum.General");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StringToIndexTest1()
        {
            //Arrange
            int expectedResult = 3;
            //Act
            int actualResult = Utilities.StringToIndex("3");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StringToIndexTest2()
        {
            //Arrange
            int expectedResult = 2;
            //Act
            int actualResult = Utilities.StringToIndex("this.TDBGrid.Columns[2]");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetCreateListElementListTest()
        {
            //Arrange
            int expectedResult = 1;
            List<C1DataColumn> list = new List<C1DataColumn>();
            //Act
            Utilities.GetCreateListElement<C1DataColumn>(list, 0);
            int actualResult = list.Count;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void XMLToFlatString()
        {
            //Arrange
            XElement xmlElement = new XElement("test", new XElement("value"));
            string expectedResult = "<test><value /></test>";
            //Act
            string actualResult = Utilities.XMLToFlatString(xmlElement);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

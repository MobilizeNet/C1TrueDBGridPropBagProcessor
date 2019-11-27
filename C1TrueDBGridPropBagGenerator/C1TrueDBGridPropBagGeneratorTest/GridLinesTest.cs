using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class GridLinesTest
    {
        [TestMethod]
        public void ColorTestDefaultValue()
        {
            //Arrange
            GridLines gridLines = new GridLines();
            string expectedResult = "System.Drawing.Color.DarkGray";
            //Act
            string actualResult = gridLines.Properties["Color"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StyleTestDefaultValue()
        {
            //Arrange
            GridLines gridLines = new GridLines();
            string expectedResult = "Single";
            //Act
            string actualResult = gridLines.Properties["Style"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXMLTagStringTest1()
        {
            //Arrange
            GridLines gridLines = new GridLines();
            string expectedResult = "DarkGray,Single";
            // Act
            string actualResult = gridLines.ToXMLTagString();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXMLTagStringTest2()
        {
            //Arrange
            GridLines gridLines = new GridLines();
            gridLines.Properties["Color"] = "Red";
            gridLines.Properties["Style"] = "Double";
            string expectedResult = "Red,Double";
            // Act
            string actualResult = gridLines.ToXMLTagString();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseXMLTest()
        {
            // Arrange
            XElement xmlGridLines = XElement.Parse(@"<ColumnDivider>Yellow,Raised</ColumnDivider>");
            // Act
            GridLines gridLines = GridLines.ParseXML(xmlGridLines);
            bool actualResult = gridLines.Properties["Color"] == "Yellow" && gridLines.Properties["Style"] == "Raised";
            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}

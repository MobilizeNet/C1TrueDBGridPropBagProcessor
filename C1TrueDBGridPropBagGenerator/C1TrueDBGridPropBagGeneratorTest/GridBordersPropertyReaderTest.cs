using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class GridBordersPropertyReaderTest
    {
        [TestMethod]
        public void ProcessBordersPropertyTestColor()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "Blue";
            // Act
            GridBordersPropertyReader.ProcessBordersProperty(borders, "Color", "System.Drawing.Color.Blue");
            string actualResult = borders.Properties["Color"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessBordersPropertyTestBorderType()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "Groove";
            // Act
            GridBordersPropertyReader.ProcessBordersProperty(borders, "BorderType", "C1.Win.C1TrueDBGrid.BorderTypeEnum.Groove");
            string actualResult = borders.Properties["BorderType"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessBordersPropertyTestTop()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "5";
            // Act
            GridBordersPropertyReader.ProcessBordersProperty(borders, "Top", "5");
            string actualResult = borders.Properties["Top"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for GridLinesPropertyReaderTest
    /// </summary>
    [TestClass]
    public class GridLinesPropertyReaderTest
    {
        [TestMethod]
        public void ProcessGridLinesPropertyTestColor()
        {
            //Arrange
            GridLines gridLines = new GridLines();
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Color", "System.Drawing.Color.Navy");
            string expectedResult = "System.Drawing.Color.Navy";
            //Act
            string actualResult = gridLines.Properties["Color"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridLinesPropertyTestStyle()
        {
            //Arrange
            GridLines gridLines = new GridLines();
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Style", "C1.Win.C1TrueDBGrid.LineStyleEnum.Double");
            string expectedResult = "Double";
            //Act
            string actualResult = gridLines.Properties["Style"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MustRemoveLineTestColor()
        {
            // Arrange
            GridLines gridLines = new GridLines();
            // Act
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Color", "System.Drawing.Color.DarkGray");
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Style", "C1.Win.C1TrueDBGrid.LineStyleEnum.Single");
            bool actualResult = GridLinesPropertyReader.MustRemoveLine(gridLines, "Color");
            // Assert
            Assert.IsTrue(actualResult);
        }


        [TestMethod]
        public void DontRemoveLineTestColor1()
        {
            // Arrange
            GridLines gridLines = new GridLines();
            // Act
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Color", "System.Drawing.Color.Blue");
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Style", "C1.Win.C1TrueDBGrid.LineStyleEnum.Single");
            bool actualResult = GridLinesPropertyReader.MustRemoveLine(gridLines, "Color");
            // Assert
            Assert.IsFalse(actualResult);
        }


        [TestMethod]
        public void DontRemoveLineTestColor2()
        {
            // Arrange
            GridLines gridLines = new GridLines();
            // Act
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Color", "System.Drawing.Color.DarkGray");
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Style", "C1.Win.C1TrueDBGrid.LineStyleEnum.Double");
            bool actualResult = GridLinesPropertyReader.MustRemoveLine(gridLines, "Color");
            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void MustRemoveRemoveLineTestStyle()
        {
            // Arrange
            GridLines gridLines = new GridLines();
            // Act
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Color", "System.Drawing.Color.DarkGray");
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Style", "C1.Win.C1TrueDBGrid.LineStyleEnum.Single");
            bool actualResult = GridLinesPropertyReader.MustRemoveLine(gridLines, "Style");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void DontRemoveLineTestStyle1()
        {
            // Arrange
            GridLines gridLines = new GridLines();
            // Act
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Color", "System.Drawing.Color.Blue");
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Style", "C1.Win.C1TrueDBGrid.LineStyleEnum.Single");
            bool actualResult = GridLinesPropertyReader.MustRemoveLine(gridLines, "Style");
            // Assert
            Assert.IsFalse(actualResult);
        }


        [TestMethod]
        public void DontRemoveLineTestStyle2()
        {
            // Arrange
            GridLines gridLines = new GridLines();
            // Act
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Color", "System.Drawing.Color.DarkGray");
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Style", "C1.Win.C1TrueDBGrid.LineStyleEnum.Double");
            bool actualResult = GridLinesPropertyReader.MustRemoveLine(gridLines, "Style");
            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void DontRemoveLineTestStyle3()
        {
            // Arrange
            GridLines gridLines = new GridLines();
            // Act
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Color", "System.Drawing.Color.Yellow");
            GridLinesPropertyReader.ProcessGridLinesProperty(gridLines, "Style", "C1.Win.C1TrueDBGrid.LineStyleEnum.Double");
            bool actualResult = GridLinesPropertyReader.MustRemoveLine(gridLines, "Style");
            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}

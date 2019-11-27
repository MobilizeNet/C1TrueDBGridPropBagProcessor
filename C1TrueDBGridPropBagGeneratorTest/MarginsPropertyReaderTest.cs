using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class MarginsPropertyReaderTest
    {
        [TestMethod]
        public void ProcessBordersPropertyTestRight()
        {
            // Arrange
            Margins margins = new Margins();
            string expectedResult = "3";
            // Act
            MarginsPropertyReader.ProcessMarginsProperty(margins, "Right", "3");
            string actualResult = margins.Properties["Right"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessBordersPropertyTestObject()
        {
            // Arrange
            Margins margins = new Margins();
            // Act
            MarginsPropertyReader.ProcessMarginsProperty(margins, "", "new System.Drawing.Printing.Margins(5, 4, 3, 2)");
            bool actualResult = margins.Properties["Left"] == "5" &&
                margins.Properties["Right"] == "4" &&
                margins.Properties["Top"] == "3" &&
                margins.Properties["Bottom"] == "2";
            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}

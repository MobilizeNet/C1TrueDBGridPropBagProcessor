using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class MarginsTest
    {
        [TestMethod]
        public void PropertyTopDefaultValue()
        {
            // Arrange
            Margins margins = new Margins();
            string expectedResult = "0";
            // Act
            string actualResult = margins.Properties["Top"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyBottomDefaultValue()
        {
            // Arrange
            Margins margins = new Margins();
            string expectedResult = "0";
            // Act
            string actualResult = margins.Properties["Bottom"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyLeftDefaultValue()
        {
            // Arrange
            Margins margins = new Margins();
            string expectedResult = "0";
            // Act
            string actualResult = margins.Properties["Left"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyRightDefaultValue()
        {
            // Arrange
            Margins margins = new Margins();
            string expectedResult = "0";
            // Act
            string actualResult = margins.Properties["Right"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValueToStyleStringTest()
        {
            // Arrange
            Margins margins = new Margins();
            margins.Properties["Left"] = "1";
            margins.Properties["Right"] = "2";
            margins.Properties["Top"] = "3";
            margins.Properties["Bottom"] = "4";
            string expectedResult = "1,2,3,4";
            // Act
            string actualResult = margins.ValueToStyleString();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseStyleMarginsValue()
        {
            // Act
            Margins margins = Margins.ParseStyleMarginsValue("2, 3, 5, 1");
            bool actualResult = margins.Properties["Left"] == "2" &&
                margins.Properties["Right"] == "3" &&
                margins.Properties["Top"] == "5" &&
                margins.Properties["Bottom"] == "1";
            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}

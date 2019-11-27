using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class GridBordersTest
    {
        [TestMethod]
        public void PropertyBorderTypeDefaultValue()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "None";
            // Act
            string actualResult = borders.Properties["BorderType"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyColorDefaultValue()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "";
            // Act
            string actualResult = borders.Properties["Color"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyTopDefaultValue()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "0";
            // Act
            string actualResult = borders.Properties["Top"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyBottomDefaultValue()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "0";
            // Act
            string actualResult = borders.Properties["Bottom"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyLeftDefaultValue()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "0";
            // Act
            string actualResult = borders.Properties["Left"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyRightDefaultValue()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "0";
            // Act
            string actualResult = borders.Properties["Right"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValueToStyleStringTest()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            string expectedResult = "Fillet,Yellow,0,2,1,4";
            borders.Properties["BorderType"] = "Fillet";
            borders.Properties["Color"] = "Yellow";
            borders.Properties["Left"] = "0";
            borders.Properties["Right"] = "2";
            borders.Properties["Top"] = "1";
            borders.Properties["Bottom"] = "4";
            // Act
            string actualResult = borders.ValueToStyleString();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseValueStringTest()
        {
            // Act
            GridBorders borders = GridBorders.ParseValueString("Inset,223,221,220, 3,2,1,0");
            bool actualResult = borders.Properties["BorderType"] == "Inset" &&
                borders.Properties["Color"] == "223,221,220" &&
                borders.Properties["Left"] == "3" &&
                borders.Properties["Right"] == "2" &&
                borders.Properties["Top"] == "1" &&
                borders.Properties["Bottom"] == "0";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UpdatePropertiesAccordingToTypeNone()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            borders.Properties["BorderType"] = "None";
            // Act
            borders.UpdatePropertiesAccordingToType();
            bool actualResult = borders.Properties["Color"] == "" &&
                borders.Properties["Left"] == "0" &&
                borders.Properties["Right"] == "0" &&
                borders.Properties["Top"] == "0" &&
                borders.Properties["Bottom"] == "0";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UpdatePropertiesAccordingToTypeFlat()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            borders.Properties["BorderType"] = "Flat";
            // Act
            borders.UpdatePropertiesAccordingToType();
            bool actualResult = borders.Properties["Color"] == "ControlDark";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UpdatePropertiesAccordingToTypeRaised()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            borders.Properties["BorderType"] = "Raised";
            // Act
            borders.UpdatePropertiesAccordingToType();
            bool actualResult = borders.Properties["Left"] == "1" &&
                borders.Properties["Right"] == "1" &&
                borders.Properties["Top"] == "1" &&
                borders.Properties["Bottom"] == "1";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UpdatePropertiesAccordingToTypeInset()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            borders.Properties["BorderType"] = "Inset";
            // Act
            borders.UpdatePropertiesAccordingToType();
            bool actualResult = borders.Properties["Left"] == "1" &&
                borders.Properties["Right"] == "1" &&
                borders.Properties["Top"] == "1" &&
                borders.Properties["Bottom"] == "1";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UpdatePropertiesAccordingToTypeGroove()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            borders.Properties["BorderType"] = "Groove";
            // Act
            borders.UpdatePropertiesAccordingToType();
            bool actualResult = borders.Properties["Left"] == "2" &&
                borders.Properties["Right"] == "2" &&
                borders.Properties["Top"] == "2" &&
                borders.Properties["Bottom"] == "2";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UpdatePropertiesAccordingToTypeFillet()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            borders.Properties["BorderType"] = "Fillet";
            // Act
            borders.UpdatePropertiesAccordingToType();
            bool actualResult = borders.Properties["Left"] == "2" &&
                borders.Properties["Right"] == "2" &&
                borders.Properties["Top"] == "2" &&
                borders.Properties["Bottom"] == "2";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void HasDefaultColorAndSizeTest1()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            // Act
            bool actualResult = borders.HasDefaultColorAndSize();
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void HasDefaultColorAndSizeTest2()
        {
            // Arrange
            GridBorders borders = new GridBorders();
            borders.Properties["Color"] = "Red";
            // Act
            bool actualResult = borders.HasDefaultColorAndSize();
            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}

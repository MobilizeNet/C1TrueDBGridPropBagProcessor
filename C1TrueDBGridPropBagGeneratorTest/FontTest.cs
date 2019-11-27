using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for FontTest
    /// </summary>
    [TestClass]
    public class FontTest
    {
        [TestMethod]
        public void FamilyNameTestSetAndGet()
        {
            //Arrange
            Font font = new Font();
            font.FamilyName = "abc";
            string expectedResult = "abc";
            //Act
            string actualResult = font.FamilyName;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SizeTestSetAndGet()
        {
            //Arrange
            Font font = new Font();
            font.Size = "10";
            string expectedResult = "10";
            //Act
            string actualResult = font.Size;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void StyleTestSetAndGet()
        {
            //Arrange
            Font font = new Font();
            font.Style = "abc";
            string expectedResult = "abc";
            //Act
            string actualResult = font.Style;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CharSetTestSetAndGet()
        {
            //Arrange
            Font font = new Font();
            font.CharSet = "abc";
            string expectedResult = "abc";
            //Act
            string actualResult = font.CharSet;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class ResourceImageTest
    {
        [TestMethod]
        public void WidthTestSetAndGet()
        {
            //Arrange
            ResourceImage image = new ResourceImage();
            image.Name = "c1TrueDBGrid1.Images2";
            string expectedResult = "c1TrueDBGrid1.Images2";
            //Act
            string actualResult = image.Name;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

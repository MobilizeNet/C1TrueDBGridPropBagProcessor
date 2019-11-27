using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class PreviewInfoTest
    {
        [TestMethod]
        public void AllowSizingTestDefultValue()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            string expectedResult = "true";
            //Act
            string actualResult = previewInfo.Properties["AllowSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CaptionTestDefultValue()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            string expectedResult = "PrintPreview Window";
            //Act
            string actualResult = previewInfo.Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NavigationPaneDockingStyleTestDefultValue()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            string expectedResult = "None";
            //Act
            string actualResult = previewInfo.Properties["NavigationPaneDockingStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToolBarsTestDefultValue()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            string expectedResult = "true";
            //Act
            string actualResult = previewInfo.Properties["ToolBars"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LocationTestDefultValue()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            string expectedResult = "new System.Drawing.Point(0, 0)";
            //Act
            string actualResult = previewInfo.Properties["Location"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SizeTestDefultValue()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            string expectedResult = "new System.Drawing.Size(0, 0)";
            //Act
            string actualResult = previewInfo.Properties["Size"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ZoomFactorTestDefultValue()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            string expectedResult = "75D";
            //Act
            string actualResult = previewInfo.Properties["ZoomFactor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class PreviewInfoPropertyReaderTest
    {
        [TestMethod]
        public void ProcessPreviewInfoPropertyTestAllowSizing()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            PreviewInfoPropertyReader.ProcessPreviewInfoProperty(previewInfo, "AllowSizing", "false");
            string expectedResult = "false";
            //Act
            string actualResult = previewInfo.Properties["AllowSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPreviewInfoPropertyTestCaption()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            PreviewInfoPropertyReader.ProcessPreviewInfoProperty(previewInfo, "Caption", "ABC");
            string expectedResult = "ABC";
            //Act
            string actualResult = previewInfo.Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPreviewInfoPropertyTestNavigationPaneDockingStyle()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            PreviewInfoPropertyReader.ProcessPreviewInfoProperty(previewInfo, "NavigationPaneDockingStyle", "Bottom");
            string expectedResult = "Bottom";
            //Act
            string actualResult = previewInfo.Properties["NavigationPaneDockingStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessPreviewInfoPropertyTestToolBars()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            PreviewInfoPropertyReader.ProcessPreviewInfoProperty(previewInfo, "ToolBars", "false");
            string expectedResult = "false";
            //Act
            string actualResult = previewInfo.Properties["ToolBars"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MustRemoveLineTestToolBars()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            previewInfo.Properties["ToolBars"] = "true";
            //Act
            bool actualResult = PreviewInfoPropertyReader.MustRemoveLine(previewInfo, "ToolBars");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void DontRemoveLineTestToolBars()
        {
            //Arrange
            PreviewInfo previewInfo = new PreviewInfo();
            previewInfo.Properties["ToolBars"] = "false";
            //Act
            bool actualResult = PreviewInfoPropertyReader.MustRemoveLine(previewInfo, "ToolBars");
            //Assert
            Assert.IsFalse(actualResult);
        }
    }
}

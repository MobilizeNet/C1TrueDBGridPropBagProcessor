using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class ReaderSettingsTest
    {

        [TestMethod]
        public void ProcessGridsOnlyIncorrectDesignerPropsTestSetAndGet()
        {
            //Arrange
            ReaderSettings.ProcessGridsOnlyIncorrectDesignerProps = true;
            bool expectedResult = true;
            //Act
            bool actualResult = ReaderSettings.ProcessGridsOnlyIncorrectDesignerProps;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridsOnlyExistingPropBagTestSetAndGet()
        {
            //Arrange
            ReaderSettings.ProcessGridsOnlyExistingPropBag = true;
            bool expectedResult = true;
            //Act
            bool actualResult = ReaderSettings.ProcessGridsOnlyIncorrectDesignerProps;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridsWithIncorrectPropsAndPropBagTestSetAndGet()
        {
            //Arrange
            ReaderSettings.ProcessGridsWithIncorrectPropsAndPropBag = true;
            bool expectedResult = true;
            //Act
            bool actualResult = ReaderSettings.ProcessGridsWithIncorrectPropsAndPropBag;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void OverwritePropBagsTagsTestSetAndGet()
        {
            //Arrange
            ReaderSettings.OverwritePropBagsTags = true;
            bool expectedResult = true;
            //Act
            bool actualResult = ReaderSettings.OverwritePropBagsTags;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ForceContinueTestSetAndGet()
        {
            //Arrange
            ReaderSettings.ForceContinue = true;
            bool expectedResult = true;
            //Act
            bool actualResult = ReaderSettings.ForceContinue;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MustParsePropBagsTagsTestSetAndGet()
        {
            //Arrange
            ReaderSettings.MustParsePropBagsTags = false;
            bool expectedResult = false;
            //Act
            bool actualResult = ReaderSettings.MustParsePropBagsTags;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}

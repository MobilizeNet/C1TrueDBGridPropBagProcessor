using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for ValueItemCollectionPropertyReaderTest
    /// </summary>
    [TestClass]
    public class ValueItemCollectionPropertyReaderTest
    {
        

        [TestMethod]
        public void ProcessValueItemCollectionPropertyTestAnnotatePicture()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, null, "AnnotatePicture", "true");
            string expectedResult = "True";
            //Act
            string actualResult = valueItems.Properties["AnnotatePicture"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemCollectionPropertyTestCycleOnClick()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, null, "CycleOnClick", "true");
            string expectedResult = "True";
            //Act
            string actualResult = valueItems.Properties["CycleOnClick"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemCollectionPropertyTestDefaultItem()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, null, "DefaultItem", "3");
            string expectedResult = "3";
            //Act
            string actualResult = valueItems.Properties["DefaultItem"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemCollectionPropertyTestMaxComboItems()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, null, "MaxComboItems", "7");
            string expectedResult = "7";
            //Act
            string actualResult = valueItems.Properties["MaxComboItems"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemCollectionPropertyTestPresentation()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, null, "Presentation", "C1.Win.C1TrueDBGrid.PresentationEnum.RadioButton");
            string expectedResult = "RadioButton";
            //Act
            string actualResult = valueItems.Properties["Presentation"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemCollectionPropertyTestTranslate()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, null, "Translate",  "true");
            string expectedResult = "True";
            //Act
            string actualResult = valueItems.Properties["Translate"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemCollectionPropertyTestValidate()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, null, "Validate",  "true");
            string expectedResult = "True";
            //Act
            string actualResult = valueItems.Properties["Validate"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemCollectionPropertyTestValues1()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, null, "Values[0].Value", "\"SomeValue\"");
            string expectedResult = "SomeValue";
            //Act
            string actualResult = valueItems.Values[0].Value;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemTestAddValueItem()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            Dictionary<string, ValueItem> valueItemsDict = new Dictionary<string, ValueItem>();
            valueItemsDict["ValueItem_0_Column_1_TDBGrid"] = new ValueItem();
            valueItemsDict["ValueItem_0_Column_1_TDBGrid"].Value = "Valor3";
            string expectedResult = "Valor3";

            //Act
            ValueItemCollectionPropertyReader.ProcessValueItemCollectionProperty(valueItems, valueItemsDict, "Values.Add(this.ValueItem_0_Column_1_TDBGrid);", "Valor3");
            string actualResult = valueItems.Values[0].Value;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

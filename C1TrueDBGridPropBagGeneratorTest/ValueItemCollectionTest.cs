using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for ValueItemCollectionTest
    /// </summary>
    [TestClass]
    public class ValueItemCollectionTest
    {
        [TestMethod]
        public void TranslateTestDefaultValue()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            string expectedResult = "False";
            //Act
            string actualResult = valueItems.Properties["Translate"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void PresentationTestDefaultValue()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            string expectedResult = "Normal";
            //Act
            string actualResult = valueItems.Properties["Presentation"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MaxComboItemsTestDefaultValue()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            string expectedResult = "5";
            //Act
            string actualResult = valueItems.Properties["MaxComboItems"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidateTestDefaultValue()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            string expectedResult = "False";
            //Act
            string actualResult = valueItems.Properties["Validate"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CycleOnClickTestDefaultValue()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            string expectedResult = "False";
            //Act
            string actualResult = valueItems.Properties["CycleOnClick"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void AnnotateTestDefaultValue()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            string expectedResult = "False";
            //Act
            string actualResult = valueItems.Properties["AnnotatePicture"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void DefaultItemTestDefaultValue()
        {
            //Arrange
            ValueItemCollection valueItems = new ValueItemCollection();
            string expectedResult = "-1";
            //Act
            string actualResult = valueItems.Properties["DefaultItem"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ParseXMLTestAttributes()
        {
            // Arrange
            XElement valueItemCollectionXML = XElement.Parse("<ValueItems Presentation=\"ComboBox\" Translate=\"True\">" +
                "<internalValues>" +
                    "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value1\" dispVal=\"value2\"/>" +
                    "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value3\" dispVal=\"value4\"/>" +
                "</internalValues >" +
            "</ValueItems>");
            // Act
            ValueItemCollection valueItemCollection = ValueItemCollection.ParseXML(valueItemCollectionXML);
            bool actualResult = valueItemCollection.Properties["Presentation"] == "ComboBox" &&
                valueItemCollection.Properties["Translate"] == "True";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTestTotalValueItems()
        {
            // Arrange
            XElement valueItemCollectionXML = XElement.Parse("<ValueItems Presentation=\"ComboBox\" Translate=\"True\">" +
                "<internalValues>" +
                    "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value1\" dispVal=\"value2\"/>" +
                    "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value3\" dispVal=\"value4\"/>" +
                "</internalValues >" +
            "</ValueItems>");
            int expectedResult = 2;
            // Act
            ValueItemCollection valueItemCollection = ValueItemCollection.ParseXML(valueItemCollectionXML);
            int actualResult = valueItemCollection.Values.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}


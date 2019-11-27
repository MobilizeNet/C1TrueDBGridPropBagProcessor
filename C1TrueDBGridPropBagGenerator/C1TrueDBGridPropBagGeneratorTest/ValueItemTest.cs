using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for ValueItemTest
    /// </summary>
    [TestClass]
    public class ValueItemTest
    {
        [TestMethod]
        public void ValueTestSetAndGet()
        {
            //Arrange
            ValueItem valueI = new ValueItem();
            valueI.Value = "abc";
            string expectedResult = "abc";
            //Act
            string actualResult = valueI.Value;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DispValTestSetAndGet()
        {
            //Arrange
            ValueItem valueI = new ValueItem();
            valueI.DispVal = "abc";
            string expectedResult = "abc";
            //Act
            string actualResult = valueI.DispVal;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ImgIdxTestSetAndGet()
        {
            //Arrange
            ValueItem valueI = new ValueItem();
            valueI.ImgIdx = "3";
            string expectedResult = "3";
            //Act
            string actualResult = valueI.ImgIdx;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DefaultItemTestSetAndGet()
        {
            //Arrange
            ValueItem valueI = new ValueItem();
            valueI.DefaultItem = "abc";
            string expectedResult = "abc";
            //Act
            string actualResult = valueI.DefaultItem;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXmlTest_HasBaseXml()
        {
            // Arrange
            ValueItem valueItem = new ValueItem();
            XElement valueItemXelement = valueItem.ToXML();
            List<string> baseAttributes = new List<string>();
            baseAttributes.Add("type");
            baseAttributes.Add("Value");
            // Act
            bool actualResult = baseAttributes.TrueForAll(x => valueItemXelement.Attribute(x) != null);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTest1()
        {
            // Arrange
            XElement valueItemXML = XElement.Parse("<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value1\" dispVal=\"value2\" />");
            // Act
            ValueItem valueItem = ValueItem.ParseXML(valueItemXML);
            bool actualResult = valueItem.Value == "value1" && valueItem.DispVal == "value2";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTest2()
        {
            // Arrange
            XElement valueItemXML = XElement.Parse("<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value3\"/>");
            // Act
            ValueItem valueItem = ValueItem.ParseXML(valueItemXML);
            bool actualResult = valueItem.Value == "value3";
            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}

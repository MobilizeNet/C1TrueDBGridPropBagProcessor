using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for ValueItemPropertyReaderTest
    /// </summary>
    [TestClass]
    public class ValueItemPropertyReaderTest
    {
        [TestMethod]
        public void ProcessValueItemPropertyTestValue()
        {
            //Arrange
            ValueItem valueItem = new ValueItem();
            ValueItemPropertyReader.ProcessValueItemProperty(valueItem, "Value", "\"abc\"");
            string expectedResult = "abc";
            //Act
            string actualResult = valueItem.Value;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemPropertyTestDispVal()
        {
            //Arrange
            ValueItem valueItem = new ValueItem();
            ValueItemPropertyReader.ProcessValueItemProperty(valueItem, "DisplayValue",  "\"abc\"");
            string expectedResult = "abc";
            //Act
            string actualResult = valueItem.DispVal;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessValueItemInstanceProperty()
        {
            // Arrange
            Dictionary<string, ValueItem> valueItems = new Dictionary<string, ValueItem>();
            valueItems.Add("ValueItem_1_Column_1_TDBGrid", new ValueItem());
            string expectedResult = "Valor11";
            // Act
            ValueItemPropertyReader.ProcessValueItemInstanceProperty(valueItems, "this.ValueItem_1_Column_1_TDBGrid.DisplayValue = \"Valor11\";");
            string actualResult = valueItems["ValueItem_1_Column_1_TDBGrid"].DispVal;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

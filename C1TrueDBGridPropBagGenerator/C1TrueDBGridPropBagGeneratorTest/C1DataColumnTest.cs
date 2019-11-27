using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Collections.Generic;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class C1DataColumnTest
    {
        [TestMethod]
        public void CaptionTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
 
            string expectedResult = "";
            //Act
            string actualResult = column.Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DataFieldTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            string expectedResult = "";
            //Act
            string actualResult = column.Properties["DataField"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void DataWidthTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            string expectedResult = "0";
            //Act
            string actualResult = column.Properties["DataWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DefaultValueTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            string expectedResult = "";
            //Act
            string actualResult = column.Properties["DefaultValue"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EditMaskTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            string expectedResult = "";
            //Act
            string actualResult = column.Properties["EditMask"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EditMaskUpdateTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            string expectedResult = "False";
            //Act
            string actualResult = column.Properties["EditMaskUpdate"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void FilterTextTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            string expectedResult = "";
            //Act
            string actualResult = column.Properties["FilterText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FooterTextTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            string expectedResult = "";
            //Act
            string actualResult = column.Properties["FooterText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NumberFormatTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            string expectedResult = "";
            //Act
            string actualResult = column.Properties["NumberFormat"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValueItemsTestCount()
        {
            //Arrange
            List<ValueItem> valueItems = new List<ValueItem>();
            
            int expectedResult = 0;
            //Act
            int actualResult = valueItems.Count;
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValueItemsTestAdd()
        {
            //Arrange
            List<ValueItem> valueItems = new List<ValueItem>();
            ValueItem valueI = new ValueItem();
            valueI.Value = "abc";
            valueItems.Add(valueI);
            string expectedResult = "abc";
            //Act
            string actualResult = valueItems[0].Value;
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXmlTest_ShouldReturnNonNullXElement()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            column.ValueItems = new ValueItemCollection();          
            //Act
            var actualResult = column.ToXML();
            //Assert  
            Assert.IsNotNull(actualResult);
        }

        [TestMethod]
        public void ToXmlTest_DefinedCaptionDataFieldPresentation_ShouldReturnXElementWithPropertiesSet()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            column.Properties["Caption"] = "abc";
            column.Properties["DataField"] = "def";
            column.ValueItems = new ValueItemCollection();
            column.ValueItems.Properties["Presentation"] = "ComboBox";
            string expectedResult = "C1DataColumn abc def ComboBox";
            //Act
            XElement c1DataColumnElement = column.ToXML();
            string actualResult = c1DataColumnElement.Name.LocalName + " " + c1DataColumnElement.Attribute("Caption").Value + " " + c1DataColumnElement.Attribute("DataField").Value + " " + c1DataColumnElement.Element("ValueItems").Attribute("Presentation").Value;
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXmlTest_HasBaseXml()
        {
            // Arrange
            C1DataColumn column = new C1DataColumn();
            XElement columnXelement = column.ToXML();
            List<string> baseAttributes = new List<string>();
            baseAttributes.Add("Caption");
            baseAttributes.Add("DataField");
            List<string> baseElements = new List<string>();
            baseElements.Add("FilterCancelText");
            baseElements.Add("FilterClearText");
            baseElements.Add("ValueItems");
            baseElements.Add("GroupInfo");
            // Act
            bool actualResult = baseAttributes.TrueForAll(x => columnXelement.Attribute(x) != null) &&
                                baseElements.TrueForAll(x => columnXelement.Element(x) != null) &&
                                columnXelement.Element("GroupInfo").Element("AggregatesText") != null;
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTestAttributes()
        {
            // Arrange
            XElement xElemColumn = XElement.Parse(
            "<C1DataColumn Relation=\"True\" Caption=\"PrimeraCol\" DataField=\"\" DataWidth=\"3\" DefaultValue=\"defecto\" FooterText=\"Footer1\" NumberFormat=\"Currency\">" +
                "<FilterCancelText>Cancelar</FilterCancelText>" +
                "<FilterClearText>Limpiar</FilterClearText>" +
                "<ValueItems Presentation=\"ComboBox\" Translate=\"True\">" +
                    "<internalValues>" +
                        "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value1\" dispVal=\"value2\" />" +
                        "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value3\" dispVal=\"value4\" />" +
                    "</internalValues>" +
                "</ValueItems>" +
                "<GroupInfo>" +
                    "<AggregatesText>SomeText</AggregatesText>" +
                "</GroupInfo>" +
            "</C1DataColumn>");
            // Act
            C1DataColumn dataColumn = C1DataColumn.ParseXML(xElemColumn);
            bool actualResult = dataColumn.Properties["Relation"] == "True" &&
                dataColumn.Properties["Caption"] == "PrimeraCol" &&
                dataColumn.Properties["DataField"] == "" &&
                dataColumn.Properties["DataWidth"] == "3" &&
                dataColumn.Properties["DefaultValue"] == "defecto" &&
                dataColumn.Properties["FooterText"] == "Footer1" &&
                dataColumn.Properties["NumberFormat"] == "Currency" &&
                dataColumn.Properties["FilterCancelText"] == "Cancelar" &&
                dataColumn.Properties["FilterClearText"] == "Limpiar";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTestGroupInfo()
        {
            // Arrange
            XElement xElemColumn = XElement.Parse(
            "<C1DataColumn Relation=\"True\" Caption=\"PrimeraCol\" DataField=\"\" DataWidth=\"3\" DefaultValue=\"defecto\" FooterText=\"Footer1\" NumberFormat=\"Currency\">" +
                "<FilterCancelText>Cancelar</FilterCancelText>" +
                "<FilterClearText>Limpiar</FilterClearText>" +
                "<ValueItems Presentation=\"ComboBox\" Translate=\"True\">" +
                    "<internalValues>" +
                        "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value1\" dispVal=\"value2\" />" +
                        "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value3\" dispVal=\"value4\" />" +
                    "</internalValues>" +
                "</ValueItems>" +
                "<GroupInfo>" +
                    "<AggregatesText>SomeText</AggregatesText>" +
                "</GroupInfo>" +
            "</C1DataColumn>");
            string expectedResult = "SomeText";
            // Act
            C1DataColumn dataColumn = C1DataColumn.ParseXML(xElemColumn);
            string actualResult = dataColumn.GroupInfo.Properties["AggregatesText"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseXMLTestValueItemCollection()
        {
            // Arrange
            XElement xElemColumn = XElement.Parse(
            "<C1DataColumn Relation=\"True\" Caption=\"PrimeraCol\" DataField=\"\" DataWidth=\"3\" DefaultValue=\"defecto\" FooterText=\"Footer1\" NumberFormat=\"Currency\">" +
                "<FilterCancelText>Cancelar</FilterCancelText>" +
                "<FilterClearText>Limpiar</FilterClearText>" +
                "<ValueItems Presentation=\"ComboBox\" Translate=\"True\">" +
                    "<internalValues>" +
                        "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value1\" dispVal=\"value2\" />" +
                        "<ValueItem type=\"C1.Win.C1TrueDBGrid.ValueItem\" Value=\"value3\" dispVal=\"value4\" />" +
                    "</internalValues>" +
                "</ValueItems>" +
                "<GroupInfo>" +
                    "<AggregatesText>SomeText</AggregatesText>" +
                "</GroupInfo>" +
            "</C1DataColumn>");
            string expectedResult = "ComboBox";
            // Act
            C1DataColumn dataColumn = C1DataColumn.ParseXML(xElemColumn);
            string actualResult = dataColumn.ValueItems.Properties["Presentation"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

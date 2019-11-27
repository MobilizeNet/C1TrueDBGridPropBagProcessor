using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for ColumnPropertyReaderTest
    /// </summary>
    [TestClass]
    public class ColumnPropertyReaderTest
    {
        [TestMethod]
        public void ProcessColumnPropertyTestCaption()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "Caption", "\"celda1\"");
            string expectedResult = "celda1";
            //Act
            string actualResult = column.Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnPropertyTestDataField()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "DataField", "\"c1\"");
            string expectedResult = "c1";
            //Act
            string actualResult = column.Properties["DataField"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnPropertyTestDataWidth()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "DataWidth",  "10");
            string expectedResult = "10";
            //Act
            string actualResult = column.Properties["DataWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnPropertyTestDefaultValue()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "DefaultValue", "\"def val\"");
            string expectedResult = "def val";
            //Act
            string actualResult = column.Properties["DefaultValue"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnPropertyTestEditMask()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "EditMask", "\"11\"");
            string expectedResult = "11";
            //Act
            string actualResult = column.Properties["EditMask"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnPropertyTestEditMaskUpdate()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "EditMaskUpdate", "true");
            string expectedResult = "True";
            //Act
            string actualResult = column.Properties["EditMaskUpdate"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnPropertyTestFilterText()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "FilterText", "\"aaa\"");
            string expectedResult = "aaa";
            //Act
            string actualResult = column.Properties["FilterText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnPropertyTestFooterText()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "FooterText", "\"bbb ccc\"");
            string expectedResult = "bbb ccc";
            //Act
            string actualResult = column.Properties["FooterText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnPropertyTestNumberFormat()
        {
            //Arrange
            C1DataColumn column = new C1DataColumn();
            ColumnPropertyReader.ProcessColumnProperty(column, null, "NumberFormat", "\"Percent\"");
            string expectedResult = "Percent";
            //Act
            string actualResult = column.Properties["NumberFormat"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnInstanceProperty()
        {
            // Arrange
            Dictionary<string, C1DataColumn> columns = new Dictionary<string, C1DataColumn>();
            columns.Add("Column03", new C1DataColumn());
            string expectedResult = "Name";
            // Act
            ColumnPropertyReader.ProcessColumnInstanceProperty(columns, null, "this.Column03.DataField = \"Name\";");
            string actualResult = columns["Column03"].Properties["DataField"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnInstancePropertyValueItemsPresentation()
        {
            // Arrange
            Dictionary<string, C1DataColumn> columns = new Dictionary<string, C1DataColumn>();
            columns.Add("Column_0_TDBGrid", new C1DataColumn());
            string expectedResult = "CheckBox";
            // Act
            ColumnPropertyReader.ProcessColumnInstanceProperty(columns, null, "this.Column_0_TDBGrid.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox;");
            string actualResult = columns["Column_0_TDBGrid"].ValueItems.Properties["Presentation"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessColumnInstancePropertyValueItemsAdd()
        {
            // Arrange
            Dictionary<string, C1DataColumn> columns = new Dictionary<string, C1DataColumn>();
            columns.Add("Column_0_TDBGrid", new C1DataColumn());
            Dictionary<string, ValueItem> valueItems = new Dictionary<string, ValueItem>();
            valueItems.Add("ValueItem_0_Column_1_TDBGrid", new ValueItem());
            valueItems["ValueItem_0_Column_1_TDBGrid"].Value = "Value1";
            string expectedResult = "Value1";
            // Act
            ColumnPropertyReader.ProcessColumnInstanceProperty(columns, valueItems, "this.Column_0_TDBGrid.ValueItems.Add(this.ValueItem_0_Column_1_TDBGrid);");
            string actualResult = columns["Column_0_TDBGrid"].ValueItems.Values[0].Value;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

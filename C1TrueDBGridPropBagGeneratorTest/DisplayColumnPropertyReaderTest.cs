using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for DisplayColumnPropertyReaderTest
    /// </summary>
    [TestClass]
    public class DisplayColumnPropertyReaderTest
    {
        [TestMethod]
        public void ProcessDisplayColumnPropertyTestAllowFocus()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "AllowFocus", "false");
            string expectedResult = "False";
            //Act
            string actualResult = displayColumn.Properties["AllowFocus"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestAllowSizing()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "AllowSizing", "false");
            string expectedResult = "False";
            //Act
            string actualResult = displayColumn.Properties["AllowSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestAutoComplete()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "AutoComplete", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["AutoComplete"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestAutoDropDown()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "AutoDropDown", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["AutoDropDown"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestButton()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "Button", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["Button"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestButtonAlways()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "ButtonAlways", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["ButtonAlways"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestButtonFooter()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "ButtonFooter", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["ButtonFooter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestButtonHeader()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "ButtonHeader", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["ButtonHeader"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestButtonText()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "ButtonText", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["ButtonText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestDropDownList()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "DropDownList", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["DropDownList"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestFetchStyle()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "FetchStyle", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["FetchStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestFilterButton()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "FilterButton", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["FilterButton"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestFooterDivider()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "FooterDivider", "false");
            string expectedResult = "False";
            //Act
            string actualResult = displayColumn.Properties["FooterDivider"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestHeaderDivider()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "HeaderDivider", "false");
            string expectedResult = "False";
            //Act
            string actualResult = displayColumn.Properties["HeaderDivider"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestMerge()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "Merge", "C1.Win.C1TrueDBGrid.ColumnMergeEnum.Free");
            string expectedResult = "Free";
            //Act
            string actualResult = displayColumn.Properties["Merge"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestMinWidth()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "MinWidth", "2");
            string expectedResult = "2";
            //Act
            string actualResult = displayColumn.Properties["MinWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestOwnerDraw()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "OwnerDraw", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Properties["OwnerDraw"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestVisible()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "Visible", "false");
            string expectedResult = "False";
            //Act
            string actualResult = displayColumn.Properties["Visible"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestWidth()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "Width", "125");
            string expectedResult = "125";
            //Act
            string actualResult = displayColumn.Properties["Width"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestEditorStyle()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "EditorStyle.Locked", "true");
            string expectedResult = "True";
            //Act
            string actualResult = displayColumn.Styles["EditorStyle"].Properties["Locked"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void ProcessDisplayColumnPropertyTestFooterStyle()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "FooterStyle.VerticalAlignment", "C1.Win.C1TrueDBGrid.AlignVertEnum.Bottom");
            string expectedResult = "Bottom";
            //Act
            string actualResult = displayColumn.Styles["FooterStyle"].Properties["AlignVert"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestHeadingStyle()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "HeadingStyle.HorizontalAlignment", "C1.Win.C1TrueDBGrid.AlignHorzEnum.Justify");
            string expectedResult = "Justify";
            //Act
            string actualResult = displayColumn.Styles["HeadingStyle"].Properties["AlignHorz"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessDisplayColumnPropertyTestStyle()
        {
            //Arrange
            C1DisplayColumn displayColumn = new C1DisplayColumn();
            DisplayColumnPropertyReader.ProcessDisplayColumnProperty(displayColumn, "Style.ForeColor", "System.Drawing.SystemColors.HighlightText");
            string expectedResult = "HighlightText";
            //Act
            string actualResult = displayColumn.Styles["Style"].Properties["ForeColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

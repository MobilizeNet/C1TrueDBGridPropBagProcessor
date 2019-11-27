using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Xml.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for SplitTest
    /// </summary>
    [TestClass]
    public class SplitTest
    {
        [TestMethod]
        public void TagNameTestSetAndGet()
        {
            //Arrange
            Split split = new Split();
            split.TagName = "InvertedView";
            string expectedResult = "InvertedView";
            //Act
            string actualResult = split.TagName;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TagNameTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "MergeView";
            //Act
            string actualResult = split.TagName;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ExtendRightColumnTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["ExtendRightColumn"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void MarqueeStyleTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "DottedCellBorder";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void AllowRowSizingTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "AllRows";
            //Act
            string actualResult = split.Properties["AllowRowSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowHorizontalSizingTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["AllowHorizontalSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowVerticalSizingTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["AllowVerticalSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowRowSizingDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "AllRows";
            //Act
            string actualResult = split.Properties["AllowRowSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RecordSelectorsTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["RecordSelectors"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void RecordSelectorWidthTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "17";
            //Act
            string actualResult = split.Properties["RecordSelectorWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void AllowColSelectTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["AllowColSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void AllowColMoveTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["AllowColMove"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void AllowFocusDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["AllowFocus"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void AllowRowSelectTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["AllowRowSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void AlternatingRowStyleTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["AlternatingRowStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BorderSideTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "0";
            //Act
            string actualResult = split.Properties["BorderSide"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CaptionTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "";
            //Act
            string actualResult = split.Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CaptionHeightTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "17";
            //Act
            string actualResult = split.Properties["CaptionHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ColumnCaptionHeightTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "17";
            //Act
            string actualResult = split.Properties["ColumnCaptionHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ColumnFooterHeightTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "17";
            //Act
            string actualResult = split.Properties["ColumnFooterHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DefRecSelWidthTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "17";
            //Act
            string actualResult = split.Properties["DefRecSelWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FetchRowStylesTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["FetchRowStyles"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void FilterBarTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["FilterBar"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void LockedTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["Locked"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void HBarStyleTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "Automatic";
            //Act
            string actualResult = split.Properties["HBarStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void VBarStyleTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "Automatic";
            //Act
            string actualResult = split.Properties["VBarStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void HorizontalScrollGroupTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "1";
            //Act
            string actualResult = split.Properties["HorizontalScrollGroup"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void VerticalScrollGroupTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "1";
            //Act
            string actualResult = split.Properties["VerticalScrollGroup"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void SplitSizeTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "1";
            //Act
            string actualResult = split.Properties["SplitSize"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SplitSizeModeTestDefaultValue()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "Scalable";
            //Act
            string actualResult = split.Properties["SplitSizeMode"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DisplayColsTestCount()
        {
            //Arrange
            List<C1DisplayColumn> displayCols = new List<C1DisplayColumn>();

            int expectedResult = 0;
            //Act
            int actualResult = displayCols.Count;
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DisplayColsTestAdd()
        {
            //Arrange
            List<C1DisplayColumn> displayCols = new List<C1DisplayColumn>();
            C1DisplayColumn dataDC = new C1DisplayColumn();
            dataDC.Properties["AllowSizing"] = "False";
            displayCols.Add(dataDC);
            string expectedResult = "False";
            //Act
            string actualResult = displayCols[0].Properties["AllowSizing"];
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXmlTest_HasBaseXml()
        {
            // Arrange
            Split split = new Split();
            split.Properties["ClientRect"] = "0, 0, 300, 200";
            XElement splitXelement = split.ToXML();
            List<string> baseAttributes = new List<string>();
            baseAttributes.Add("CaptionHeight");
            baseAttributes.Add("ColumnCaptionHeight");
            baseAttributes.Add("ColumnFooterHeight");
            baseAttributes.Add("MarqueeStyle");
            baseAttributes.Add("RecordSelectorWidth");
            baseAttributes.Add("DefRecSelWidth");
            baseAttributes.Add("VerticalScrollGroup");
            baseAttributes.Add("HorizontalScrollGroup");
            List<string> baseElements = new List<string>();
            baseElements.Add("CaptionStyle");
            baseElements.Add("EditorStyle");
            baseElements.Add("EvenRowStyle");
            baseElements.Add("FilterBarStyle");
            baseElements.Add("FilterWatermarkStyle");
            baseElements.Add("FooterStyle");
            baseElements.Add("GroupStyle");
            baseElements.Add("HeadingStyle");
            baseElements.Add("HighLightRowStyle");
            baseElements.Add("InactiveStyle");
            baseElements.Add("OddRowStyle");
            baseElements.Add("RecordSelectorStyle");
            baseElements.Add("RowSelectorStyle");
            baseElements.Add("ColumnSelectorStyle");
            baseElements.Add("SelectedStyle");
            baseElements.Add("Style");
            baseElements.Add("ClientRect");
            baseElements.Add("BorderSide");
            // Act
            bool actualResult = baseAttributes.TrueForAll(x => splitXelement.Attribute(x) != null) &&
                                baseElements.TrueForAll(x => splitXelement.Element(x) != null);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void AssignStyleNameParentTest_Parents()
        {
            // Arrange
            Split split = new Split();
            split.DisplayCols.Add(new C1DisplayColumn());
            int count = 0;
            // Act
            split.AssignStyleNameParent(ref count);
            bool actualResult = split.Styles["CaptionStyle"].Parent.Equals(split.Styles["HeadingStyle"].Name);
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void AssignDCIdxTest()
        {
            // Arrange
            Split split = new Split();
            split.DisplayCols.Add(new C1DisplayColumn());
            split.DisplayCols.Add(new C1DisplayColumn());
            split.DisplayCols.Add(new C1DisplayColumn());
            string expectedResult = "0 1 2";
            // Act
            split.AssignDCIdx();
            string actualResult = $"{split.DisplayCols[0].Properties["DCIdx"]} {split.DisplayCols[1].Properties["DCIdx"]} {split.DisplayCols[2].Properties["DCIdx"]}";
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseXMLTestProperties()
        {
            // Arrange
            XElement splitXelement = XElement.Parse(
            @"<C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" Name=""Split[0, 2]"" CaptionHeight =""19"" ColumnCaptionHeight =""18"" ColumnFooterHeight =""17"" MarqueeStyle =""FloatingEditor"" RecordSelectorWidth =""17"" DefRecSelWidth =""17"" VerticalScrollGroup =""1"" HorizontalScrollGroup =""1"">" +
            @"<CaptionStyle parent=""Style76"" me=""Style84"" />" +
            @"<EditorStyle parent=""Editor"" me=""Style79"" />" +
            @"<EvenRowStyle parent=""EvenRow"" me=""Style82"" />" +
            @"<FilterBarStyle parent=""FilterBar"" me=""Style110"" />" +
            @"<FilterWatermarkStyle parent=""FilterWatermark"" me=""Style111"" />" +
            @"<FooterStyle parent=""Footer"" me=""Style77"" />" +
            @"<GroupStyle parent=""Group"" me=""Style86"" />" +
            @"<HeadingStyle parent=""Heading"" me=""Style76"" />" +
            @"<HighLightRowStyle parent=""HighlightRow"" me=""Style81"" />" +
            @"<InactiveStyle parent=""Inactive"" me=""Style78"" />" +
            @"<OddRowStyle parent=""OddRow"" me=""Style83"" />" +
            @"<RecordSelectorStyle parent=""RecordSelector"" me=""Style85"" />" +
            @"<RowSelectorStyle parent=""RowSelector"" me=""Style87"" />" +
            @"<ColumnSelectorStyle parent=""ColumnSelector"" me=""Style88"" />" +
            @"<SelectedStyle parent=""Selected"" me=""Style80"" />" +
            @"<Style parent=""Normal"" me=""Style75"" />" +
            @"<ClientRect>643, 0, 316, 415</ClientRect>" +
            @"<BorderSide>Left</BorderSide>" +
            @"<internalCols>" +
                @"<C1DisplayColumn>" +
                    @"<HeadingStyle parent=""Style76"" me=""Style89"" />" +
                    @"<ColumnSelectorStyle parent=""Style88"" me=""Style90"" />" +
                    @"<Style parent=""Style75"" me=""Style91"" />" +
                    @"<FooterStyle parent=""Style77"" me=""Style92"" />" +
                    @"<EditorStyle parent=""Style79"" me=""Style93"" />" +
                    @"<GroupHeaderStyle parent=""Style75"" me=""Style95"" />" +
                    @"<GroupFooterStyle parent=""Style75"" me=""Style94"" />" +
                    @"<Visible>True</Visible>" +
                    @"<Height>15</Height>" +
                    @"<ColumnDivider>DarkGray,Single</ColumnDivider>" +
                    @"<DCIdx>0</DCIdx>" +
                @"</C1DisplayColumn>" +
            @"</internalCols>" +
        @"</C1.Win.C1TrueDBGrid.MergeView>");

            // Act
            Split split = Split.ParseXML(splitXelement);
            bool actualResult = split.Properties["ClientRect"] == "643, 0, 316, 415" &&
               split.Properties["BorderSide"] == "Left" &&
               split.Properties["AllowColMove"] == "False" &&
               split.Properties["Name"] == "Split[0, 2]" &&
               split.Properties["CaptionHeight"] == "19" &&
               split.Properties["ColumnCaptionHeight"] == "18" &&
               split.Properties["ColumnFooterHeight"] == "17" &&
               split.Properties["MarqueeStyle"] == "FloatingEditor" &&
               split.Properties["RecordSelectorWidth"] == "17" &&
               split.Properties["DefRecSelWidth"] == "17" &&
               split.Properties["VerticalScrollGroup"] == "1" &&
               split.Properties["HorizontalScrollGroup"] == "1";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTestStyles()
        {
            // Arrange
            XElement splitXelement = XElement.Parse(
            @"<C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" Name=""Split[0, 2]"" CaptionHeight =""19"" ColumnCaptionHeight =""18"" ColumnFooterHeight =""17"" MarqueeStyle =""FloatingEditor"" RecordSelectorWidth =""17"" DefRecSelWidth =""17"" VerticalScrollGroup =""1"" HorizontalScrollGroup =""1"">" +
            @"<CaptionStyle parent=""Style76"" me=""Style84"" />" +
            @"<EditorStyle parent=""Editor"" me=""Style79"" />" +
            @"<EvenRowStyle parent=""EvenRow"" me=""Style82"" />" +
            @"<FilterBarStyle parent=""FilterBar"" me=""Style110"" />" +
            @"<FilterWatermarkStyle parent=""FilterWatermark"" me=""Style111"" />" +
            @"<FooterStyle parent=""Footer"" me=""Style77"" />" +
            @"<GroupStyle parent=""Group"" me=""Style86"" />" +
            @"<HeadingStyle parent=""Heading"" me=""Style76"" />" +
            @"<HighLightRowStyle parent=""HighlightRow"" me=""Style81"" />" +
            @"<InactiveStyle parent=""Inactive"" me=""Style78"" />" +
            @"<OddRowStyle parent=""OddRow"" me=""Style83"" />" +
            @"<RecordSelectorStyle parent=""RecordSelector"" me=""Style85"" />" +
            @"<RowSelectorStyle parent=""RowSelector"" me=""Style87"" />" +
            @"<ColumnSelectorStyle parent=""ColumnSelector"" me=""Style88"" />" +
            @"<SelectedStyle parent=""Selected"" me=""Style80"" />" +
            @"<Style parent=""Normal"" me=""Style75"" />" +
            @"<ClientRect>643, 0, 316, 415</ClientRect>" +
            @"<BorderSide>Left</BorderSide>" +
            @"<internalCols>" +
                @"<C1DisplayColumn>" +
                    @"<HeadingStyle parent=""Style76"" me=""Style89"" />" +
                    @"<ColumnSelectorStyle parent=""Style88"" me=""Style90"" />" +
                    @"<Style parent=""Style75"" me=""Style91"" />" +
                    @"<FooterStyle parent=""Style77"" me=""Style92"" />" +
                    @"<EditorStyle parent=""Style79"" me=""Style93"" />" +
                    @"<GroupHeaderStyle parent=""Style75"" me=""Style95"" />" +
                    @"<GroupFooterStyle parent=""Style75"" me=""Style94"" />" +
                    @"<Visible>True</Visible>" +
                    @"<Height>15</Height>" +
                    @"<ColumnDivider>DarkGray,Single</ColumnDivider>" +
                    @"<DCIdx>0</DCIdx>" +
                @"</C1DisplayColumn>" +
            @"</internalCols>" +
        @"</C1.Win.C1TrueDBGrid.MergeView>");

            // Act
            Split split = Split.ParseXML(splitXelement);
            bool actualResult = split.Styles["CaptionStyle"].Parent == "Style76" && split.Styles["CaptionStyle"].Name == "Style84" &&
                split.Styles["EditorStyle"].Parent == "Editor" && split.Styles["EditorStyle"].Name == "Style79" &&
                split.Styles["EvenRowStyle"].Parent == "EvenRow" && split.Styles["EvenRowStyle"].Name == "Style82" &&
                split.Styles["FilterBarStyle"].Parent == "FilterBar" && split.Styles["FilterBarStyle"].Name == "Style110" &&
                split.Styles["FilterWatermarkStyle"].Parent == "FilterWatermark" && split.Styles["FilterWatermarkStyle"].Name == "Style111" &&
                split.Styles["FooterStyle"].Parent == "Footer" && split.Styles["FooterStyle"].Name == "Style77" &&
                split.Styles["GroupStyle"].Parent == "Group" && split.Styles["GroupStyle"].Name == "Style86"; //... if these works, the rest will work too
            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}

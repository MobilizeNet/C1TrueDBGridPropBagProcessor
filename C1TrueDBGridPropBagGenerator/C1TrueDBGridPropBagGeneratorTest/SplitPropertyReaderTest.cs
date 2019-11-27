using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for SplitPropertyReaderTest
    /// </summary>
    [TestClass]
    public class SplitPropertyReaderTest
    {
        [TestMethod]
        public void ProcessSplitPropertyTestExtendRightColumn()
        {
            //Arrange
            Split split = new Split();
            SplitPropertyReader.ProcessSplitProperty(split, "ExtendRightColumn", "true");
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["ExtendRightColumn"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestMarqueeStyle0()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "MarqueeStyle", "C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder");
            string expectedResult = "DottedCellBorder";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestMarqueeStyle1()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "MarqueeStyle", "C1.Win.C1TrueDBGrid.MarqueeEnum.SolidCellBorder");
            string expectedResult = "SolidCellBorder";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestMarqueeStyle2()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "MarqueeStyle", "C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell");
            string expectedResult = "HighlightCell";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestMarqueeStyle3()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "MarqueeStyle", "C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow");
            string expectedResult = "HighlightRow";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestMarqueeStyle4()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "MarqueeStyle", "C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell");
            string expectedResult = "HighlightRowRaiseCell";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestMarqueeStyle5()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "MarqueeStyle", "C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee");
            string expectedResult = "NoMarquee";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestMarqueeStyle6()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "MarqueeStyle", "C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor");
            string expectedResult = "FloatingEditor";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestMarqueeStyle7()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "MarqueeStyle", "C1.Win.C1TrueDBGrid.MarqueeEnum.DottedRowBorder");
            string expectedResult = "DottedRowBorder";
            //Act
            string actualResult = split.Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestAllowRowSizing()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "AllowRowSizing", "C1.Win.C1TrueDBGrid.RowSizingEnum.None");
            string expectedResult = "None";
            //Act
            string actualResult = split.Properties["AllowRowSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestAllowHorizontalSizing()
        {
            //Arrange
            Split split = new Split();

            SplitPropertyReader.ProcessSplitProperty(split, "AllowHorizontalSizing", "False");
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["AllowHorizontalSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestAllowVerticalSizing()
        {
            //Arrange
            Split split = new Split();

            SplitPropertyReader.ProcessSplitProperty(split, "AllowVerticalSizing", "False");
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["AllowVerticalSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestRecordSelectors()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "RecordSelectors", "false");
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["RecordSelectors"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestRecordSelectorWidth()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "RecordSelectorWidth", "931");
            string expectedResult = "931";
            //Act
            string actualResult = split.Properties["RecordSelectorWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestAllowColSelect()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "AllowColSelect", "false");
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["AllowColSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestAllowColMove()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "AllowColMove",  "true");
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["AllowColMove"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestAllowFocus()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "AllowFocus", "false");
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["AllowFocus"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestAllowRowSelect()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "AllowRowSelect", "false");
            string expectedResult = "False";
            //Act
            string actualResult = split.Properties["AllowRowSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestAlternatingRowStyle()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "AlternatingRows", "true");
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["AlternatingRowStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestCaption()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "Caption", "\"abc\"");
            string expectedResult = "abc";
            //Act
            string actualResult = split.Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestFetchRowStyles()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "FetchRowStyles", "true");
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["FetchRowStyles"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestFilterBar()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "FilterBar", "true");
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["FilterBar"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestLocked()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "Locked", "true");
            string expectedResult = "True";
            //Act
            string actualResult = split.Properties["Locked"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestDefineScrollBarsAutomatic()
        {
            //Arrange
            Split split = new Split();
            string expectedResult = "Automatic Automatic";
            //Act
            string actualResult = split.Properties["HBarStyle"] + " " + split.Properties["VBarStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestVerticalScrollGroup()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "VerticalScrollGroup", "5");
            string expectedResult = "5";
            //Act
            string actualResult = split.Properties["VerticalScrollGroup"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestSplitSize()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "SplitSize", "5");
            string expectedResult = "5";
            //Act
            string actualResult = split.Properties["SplitSize"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestSplitSizeModeScalable()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "SplitSizeMode", "C1.Win.C1TrueDBGrid.SizeModeEnum.Scalable");
            string expectedResult = "Scalable";
            //Act
            string actualResult = split.Properties["SplitSizeMode"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestSplitSizeModeExact()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "SplitSizeMode", "C1.Win.C1TrueDBGrid.SizeModeEnum.Exact");
            string expectedResult = "Exact";
            //Act
            string actualResult = split.Properties["SplitSizeMode"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestSplitSizeModeNumberOfColumns()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "SplitSizeMode", "C1.Win.C1TrueDBGrid.SizeModeEnum.NumberOfColumns");
            string expectedResult = "NumberOfColumns";
            //Act
            string actualResult = split.Properties["SplitSizeMode"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestDisplayColumns1()
        {
            //Arrange
            Split split = new Split();
            split.DisplayCols = new List<C1DisplayColumn>();
            SplitPropertyReader.ProcessSplitProperty(split, "DisplayColumns[0].Merge", "C1.Win.C1TrueDBGrid.ColumnMergeEnum.None");
            string expectedResult = "None";
            //Act
            string actualResult = split.DisplayCols[0].Properties["Merge"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestDisplayColumns2()
        {
            //Arrange
            Split split = new Split();
            split.DisplayCols = new List<C1DisplayColumn>();
            SplitPropertyReader.ProcessSplitProperty(split, "DisplayColumns[this.TDBGrid.Columns[0]].Width", "133");
            string expectedResult = "133";
            //Act
            string actualResult = split.DisplayCols[0].Properties["Width"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestCaptionStyle()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "CaptionStyle.BackColor", "System.Drawing.Color.Blue");
            string expectedResult = "Blue";
            //Act
            string actualResult = split.Styles["CaptionStyle"].Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestEditorStyle()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "EditorStyle.Locked", "true");
            string expectedResult = "True";
            //Act
            string actualResult = split.Styles["EditorStyle"].Properties["Locked"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestEvenRowStyle()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "EvenRowStyle.Wrap",  "C1.Win.C1TrueDBGrid.TextWrapping.NoWrap");
            string expectedResult = "NoWrap";
            //Act
            string actualResult = split.Styles["EvenRowStyle"].Properties["WrapText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestFooterStyle()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "FooterStyle.VerticalAlignment", "C1.Win.C1TrueDBGrid.AlignVertEnum.Bottom");
            string expectedResult = "Bottom";
            //Act
            string actualResult = split.Styles["FooterStyle"].Properties["AlignVert"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestHeadingStyle()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "HeadingStyle.HorizontalAlignment",  "C1.Win.C1TrueDBGrid.AlignHorzEnum.Justify");
            string expectedResult = "Justify";
            //Act
            string actualResult = split.Styles["HeadingStyle"].Properties["AlignHorz"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestHighlightRowStyle()
        {
            //Arrange
            Split split = new Split();
            
            SplitPropertyReader.ProcessSplitProperty(split, "HighLightRowStyle.ForeColor", "System.Drawing.SystemColors.ControlDark");
            string expectedResult = "ControlDark";
            //Act
            string actualResult = split.Styles["HighLightRowStyle"].Properties["ForeColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestInactiveStyle()
        {
            //Arrange
            Split split = new Split();
            SplitPropertyReader.ProcessSplitProperty(split, "InactiveStyle.ForeGroundPicturePosition", "C1.Win.C1TrueDBGrid.ForeGroundPicturePositionEnum.Near");
            string expectedResult = "Near";
            //Act
            string actualResult = split.Styles["InactiveStyle"].Properties["ForegroundImagePos"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestOddRowStyle()
        {
            //Arrange
            Split split = new Split();
            SplitPropertyReader.ProcessSplitProperty(split, "OddRowStyle.BackgroundPictureDrawMode", "C1.Win.C1TrueDBGrid.BackgroundPictureDrawModeEnum.Center");
            string expectedResult = "Center";
            //Act
            string actualResult = split.Styles["OddRowStyle"].Properties["AlignImage"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestSelectedStyle()
        {
            //Arrange
            Split split = new Split();
            SplitPropertyReader.ProcessSplitProperty(split, "SelectedStyle.BackColor", "System.Drawing.Color.Navy");
            string expectedResult = "Navy";
            //Act
            string actualResult = split.Styles["SelectedStyle"].Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessSplitPropertyTestStyle()
        {
            //Arrange
            Split split = new Split();
            SplitPropertyReader.ProcessSplitProperty(split, "Style.ForeColor", "System.Drawing.SystemColors.HighlightText");
            string expectedResult = "HighlightText";
            //Act
            string actualResult = split.Styles["Style"].Properties["ForeColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

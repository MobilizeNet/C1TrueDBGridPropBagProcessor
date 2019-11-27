using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Drawing;
using System.Text.RegularExpressions;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for GridPropertyReaderTest
    /// </summary>
    [TestClass]
    public class GridPropertyReaderTest
    {
        [TestMethod]
        public void ProcessGridPropertyTestHeight()
        {
            //Arrange

            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Height = 2892;");
            int expectedResult = 2892 / 15;
            //Act
            int actualResult = grids["TDBGrid"].Height;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestLocation()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Location = new System.Drawing.Point(360, 200);");
            string expectedResult = "new System.Drawing.Point(360, 200)";
            //Act
            string actualResult = grids["TDBGrid"].Properties["Location"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestTabIndex()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.TabIndex = 2;");
            string expectedResult = "2";
            //Act
            string actualResult = grids["TDBGrid"].Properties["TabIndex"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Width = 6492;");
            int expectedResult = 6492;
            //Act
            int actualResult = grids["TDBGrid"].Width;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAllowColSelect()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.AllowColSelect = false;");
            string expectedResult = "False";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["AllowColSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAllowColMove()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.AllowColMove = false;");
            string expectedResult = "False";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["AllowColMove"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAllowRowSizing()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.IndividualRows;");
            string expectedResult = "IndividualRows";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["AllowRowSizing"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAllowUpdate()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.AllowUpdate = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].Properties["AllowUpdate"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAlternatingRows()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.AlternatingRows = true;");
            string expectedResult = "True";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["AlternatingRowStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDefColWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.DefColWidth = 3;");
            string expectedResult = "3";
            //Act
            string actualResult = grids["TDBGrid"].Properties["DefColWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCellTipsWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.CellTipsWidth = 25;");
            string expectedResult = "25";
            //Act
            string actualResult = grids["TDBGrid"].Properties["CellTipsWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestBackColor()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);");
            string expectedResult = "System.Drawing.Color.FromArgb(128, 255, 255)";
            //Act
            string actualResult = grids["TDBGrid"].Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDirectionAfterEnterNone()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone;");
            string expectedResult = "MoveNone";
            //Act
            string actualResult = grids["TDBGrid"].Properties["DirectionAfterEnter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDirectionAfterEnterRight()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveRight;");
            string expectedResult = "MoveRight";
            //Act
            string actualResult = grids["TDBGrid"].Properties["DirectionAfterEnter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDirectionAfterEnterDown()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown;");
            string expectedResult = "MoveDown";
            //Act
            string actualResult = grids["TDBGrid"].Properties["DirectionAfterEnter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDirectionAfterEnterLeft()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveLeft;");
            string expectedResult = "MoveLeft";
            //Act
            string actualResult = grids["TDBGrid"].Properties["DirectionAfterEnter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDirectionAfterEnterUp()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveUp;");
            string expectedResult = "MoveUp";
            //Act
            string actualResult = grids["TDBGrid"].Properties["DirectionAfterEnter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void ProcessGridPropertyTestAllowAddNew()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.AllowAddNew = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["AllowAddNew"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAllowArrows()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.AllowArrows = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].Properties["AllowArrows"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAllowDelete()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.AllowDelete = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["AllowDelete"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAllowDrop()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.AllowDrop = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["AllowDrop"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestBorderStyleNone()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;");
            string expectedResult = "None";
            //Act
            string actualResult = grids["TDBGrid"].Properties["BorderStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCellTipsNone()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.NoCellTips;");
            string expectedResult = "NoCellTips";
            //Act
            string actualResult = grids["TDBGrid"].Properties["CellTips"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCellTipsAnchored()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored;");
            string expectedResult = "Anchored";
            //Act
            string actualResult = grids["TDBGrid"].Properties["CellTips"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCellTipsFloating()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Floating;");
            string expectedResult = "Floating";
            //Act
            string actualResult = grids["TDBGrid"].Properties["CellTips"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCaption()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Caption = \"Form1\";");
            string expectedResult = "Form1";
            //Act
            string actualResult = grids["TDBGrid"].Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCausesValidation()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.CausesValidation = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].Properties["CausesValidation"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCellTipsDelay()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.CellTipsDelay = 1010;");
            string expectedResult = "1010";
            //Act
            string actualResult = grids["TDBGrid"].Properties["CellTipsDelay"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestColumnFooters()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.ColumnFooters = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["ColumnFooters"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestColumnHeaders()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.ColumnHeaders = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].Properties["ColumnHeaders"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestEditDropDown()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.EditDropDown = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].Properties["EditDropDown"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestEmptyRows()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.EmptyRows = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["EmptyRows"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestEnabled()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Enabled = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].Properties["Enabled"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyExtendRightColumn()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.ExtendRightColumn = true;");
            string expectedResult = "True";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["ExtendRightColumn"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestExposeCellModeSelect()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.ExposeCellMode = C1.Win.C1TrueDBGrid.ExposeCellModeEnum.ScrollOnSelect;");
            string expectedResult = "ScrollOnSelect";
            //Act
            string actualResult = grids["TDBGrid"].Properties["ExposeCellMode"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestExposeCellModeEdit()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.ExposeCellMode = C1.Win.C1TrueDBGrid.ExposeCellModeEnum.ScrollOnEdit;");
            string expectedResult = "ScrollOnEdit";
            //Act
            string actualResult = grids["TDBGrid"].Properties["ExposeCellMode"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestExposeCellModeNever()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.ExposeCellMode = C1.Win.C1TrueDBGrid.ExposeCellModeEnum.ScrollNever;");
            string expectedResult = "ScrollNever";
            //Act
            string actualResult = grids["TDBGrid"].Properties["ExposeCellMode"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyFetchRowStyles()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.FetchRowStyles = true;");
            string expectedResult = "True";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["FetchRowStyles"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyFont()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Font = new System.Drawing.Font(\"Arial\", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 177);");
            string expectedResult = "Arial, 8.25pt";
            //Act
            string actualResult = grids["TDBGrid"].Styles["Style"].Properties["Font"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestMarqueeStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.NoMarquee;");
            string expectedResult = "NoMarquee";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["MarqueeStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestMultiSelectNone()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;");
            string expectedResult = "None";
            //Act
            string actualResult = grids["TDBGrid"].Properties["MultiSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestMultiSelectSimple()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Simple;");
            string expectedResult = "Simple";
            //Act
            string actualResult = grids["TDBGrid"].Properties["MultiSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestMultiSelectExtended()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Extended;");
            string expectedResult = "Extended";
            //Act
            string actualResult = grids["TDBGrid"].Properties["MultiSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRecordSelector()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.RecordSelectors = false;");
            string expectedResult = "False";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["RecordSelectors"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRowDividerColor()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.RowDivider.Color = System.Drawing.Color.Black;");
            string expectedResult = "System.Drawing.Color.Black";
            //Act
            string actualResult = grids["TDBGrid"].RowDivider.Properties["Color"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRowDividerStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Double;");
            string expectedResult = "Double";
            //Act
            string actualResult = grids["TDBGrid"].RowDivider.Properties["Style"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRowHeight()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.RowHeight = 24;");
            string expectedResult = "24";
            //Act
            string actualResult = grids["TDBGrid"].Properties["RowHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestScrollTips()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.ScrollTips = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["ScrollTips"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestScrollTrack()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.ScrollTrack = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["ScrollTrack"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestSize()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Size = new System.Drawing.Size(472, 350);");
            string expectedResult = "472, 350";
            //Act
            string actualResult = $"{grids["TDBGrid"].Width}, {grids["TDBGrid"].Height}";
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestTabAcrossSplits()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.TabAcrossSplits = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["TabAcrossSplits"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestTabActionControl()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ControlNavigation;");
            string expectedResult = "ControlNavigation";
            //Act
            string actualResult = grids["TDBGrid"].Properties["TabAction"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestTabActionColumn()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation;");
            string expectedResult = "ColumnNavigation";
            //Act
            string actualResult = grids["TDBGrid"].Properties["TabAction"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestTabActionGrid()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.GridNavigation;");
            string expectedResult = "GridNavigation";
            //Act
            string actualResult = grids["TDBGrid"].Properties["TabAction"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestTabStop()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.TabStop = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].Properties["TabStop"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestTag()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Tag = \"abc\";");
            string expectedResult = "abc";
            //Act
            string actualResult = grids["TDBGrid"].Properties["Tag"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestVisible()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Visible = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].Properties["Visible"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestWrapCellPointer()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.WrapCellPointer = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].Properties["WrapCellPointer"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDisplayColumns1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits = new List<Split>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Splits[1].DisplayColumns[2].AutoDropDown = false;");
            string expectedResult = "False";
            //Act
            string actualResult = grids["TDBGrid"].Splits[1].DisplayCols[2].Properties["AutoDropDown"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestSplit1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits = new List<Split>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Splits[0].AllowColSelect = true;");
            string expectedResult = "True";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["AllowColSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestColumns1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].DataCols = new List<C1DataColumn>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Columns[0].Caption = \"Name\";");
            string expectedResult = "Name";
            //Act
            string actualResult = grids["TDBGrid"].DataCols[0].Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestValueItem1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].DataCols = new List<C1DataColumn>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Columns[2].ValueItems.Values[1].Value = \"def\";");
            string expectedResult = "def";
            //Act
            string actualResult = grids["TDBGrid"].DataCols[2].ValueItems.Values[1].Value;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestValueItemCollection1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].DataCols = new List<C1DataColumn>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Columns[0].ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.RadioButton;");
            string expectedResult = "RadioButton";
            //Act
            string actualResult = grids["TDBGrid"].DataCols[0].ValueItems.Properties["Presentation"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestPrintInfo1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].DataCols = new List<C1DataColumn>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.PrintInfo.RepeatSplitHeaders = true;");
            string expectedResult = "true";
            //Act
            string actualResult = grids["TDBGrid"].PrintInfo.Properties["RepeatSplitHeaders"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestPreviewInfo()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].DataCols = new List<C1DataColumn>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.PreviewInfo.ToolBars = false;");
            string expectedResult = "false";
            //Act
            string actualResult = grids["TDBGrid"].PreviewInfo.Properties["ToolBars"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDefineScrollBarsNone()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits = new List<Split>();
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.HScrollBar.Style = C1.Win.C1TrueDBGrid.ScrollBarStyleEnum.None;");
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.VScrollBar.Style = C1.Win.C1TrueDBGrid.ScrollBarStyleEnum.None;");
            string expectedResult = "None None";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["HBarStyle"] + " " + grids["TDBGrid"].Splits[0].Properties["VBarStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDefineScrollBarsHorizontal()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits = new List<Split>();
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.HScrollBar.Style = C1.Win.C1TrueDBGrid.ScrollBarStyleEnum.Always;");
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.VScrollBar.Style = C1.Win.C1TrueDBGrid.ScrollBarStyleEnum.None;");
            string expectedResult = "Always None";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["HBarStyle"] + " " + grids["TDBGrid"].Splits[0].Properties["VBarStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDefineScrollBarsVertical()
        {
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits = new List<Split>();
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.HScrollBar.Style = C1.Win.C1TrueDBGrid.ScrollBarStyleEnum.None;");
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.VScrollBar.Style = C1.Win.C1TrueDBGrid.ScrollBarStyleEnum.Always;");
            string expectedResult = "None Always";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["HBarStyle"] + " " + grids["TDBGrid"].Splits[0].Properties["VBarStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDefineScrollBoth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.HScrollBar.Style = C1.Win.C1TrueDBGrid.ScrollBarStyleEnum.Always;");
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.VScrollBar.Style = C1.Win.C1TrueDBGrid.ScrollBarStyleEnum.Always;");
            string expectedResult = "Always Always";
            //Act
            string actualResult = grids["TDBGrid"].Splits[0].Properties["HBarStyle"] + " " + grids["TDBGrid"].Splits[0].Properties["VBarStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCaptionStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.CaptionStyle.BackColor = System.Drawing.Color.Blue;");
            string expectedResult = "Blue";
            //Act
            string actualResult = grids["TDBGrid"].Styles["CaptionStyle"].Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestEditorStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.EditorStyle.Locked = true;");
            string expectedResult = "True";
            //Act
            string actualResult = grids["TDBGrid"].Styles["EditorStyle"].Properties["Locked"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestEvenRowStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.EvenRowStyle.Wrap = C1.Win.C1TrueDBGrid.TextWrapping.NoWrap;");
            string expectedResult = "NoWrap";
            //Act
            string actualResult = grids["TDBGrid"].Styles["EvenRowStyle"].Properties["WrapText"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestFooterStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.FooterStyle.VerticalAlignment = C1.Win.C1TrueDBGrid.AlignVertEnum.Bottom;");
            string expectedResult = "Bottom";
            //Act
            string actualResult = grids["TDBGrid"].Styles["FooterStyle"].Properties["AlignVert"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestHeadingStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Justify;");
            string expectedResult = "Justify";
            //Act
            string actualResult = grids["TDBGrid"].Styles["HeadingStyle"].Properties["AlignHorz"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestHighlightRowStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.HighLightRowStyle.ForeColor = System.Drawing.SystemColors.ControlDark;");
            string expectedResult = "ControlDark";
            //Act
            string actualResult = grids["TDBGrid"].Styles["HighLightRowStyle"].Properties["ForeColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestInactiveStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.InactiveStyle.ForeGroundPicturePosition = C1.Win.C1TrueDBGrid.ForeGroundPicturePositionEnum.Near;");
            string expectedResult = "Near";
            //Act
            string actualResult = grids["TDBGrid"].Styles["InactiveStyle"].Properties["ForegroundImagePos"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestOddRowStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.OddRowStyle.BackgroundPictureDrawMode = C1.Win.C1TrueDBGrid.BackgroundPictureDrawModeEnum.Center;");
            string expectedResult = "Center";
            //Act
            string actualResult = grids["TDBGrid"].Styles["OddRowStyle"].Properties["AlignImage"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestSelectedStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.SelectedStyle.BackColor = System.Drawing.Color.Navy;");
            string expectedResult = "Navy";
            //Act
            string actualResult = grids["TDBGrid"].Styles["SelectedStyle"].Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Style.ForeColor = System.Drawing.SystemColors.HighlightText;");
            string expectedResult = "HighlightText";
            //Act
            string actualResult = grids["TDBGrid"].Styles["Style"].Properties["ForeColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestCursor()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Cursor = System.Windows.Forms.Cursors.IBeam;");
            string expectedResult = "IBeam";
            //Act
            string actualResult = grids["TDBGrid"].Properties["Cursor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestPrintPageHeaderStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.PrintPageHeaderStyle.ForeColor = System.Drawing.Color.Red;");
            string expectedResult = "Red";
            //Act
            string actualResult = grids["TDBGrid"].Styles["PrintPageHeaderStyle"].Properties["ForeColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestPrintPageFooterStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());

            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.PrintPageFooterStyle.BackColor = System.Drawing.Color.Blue;");
            string expectedResult = "Blue";
            //Act
            string actualResult = grids["TDBGrid"].Styles["PrintPageFooterStyle"].Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestAddColumnInstance()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            Dictionary<string, C1DataColumn> columns = new Dictionary<string, C1DataColumn>();
            columns.Add("Column0", new C1DataColumn());
            columns["Column0"].Properties["Caption"] = "xyz";

            GridPropertyReader.ProcessGridProperty(grids, columns, null, "this.TDBGrid.Columns.Add(this.Column0);");
            string expectedResult = "xyz";
            //Act
            string actualResult = grids["TDBGrid"].DataCols[0].Properties["Caption"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IncorrectPropertiesInDesignerTestInvalid1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].DataCols = new List<C1DataColumn>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Columns[0].Caption = \"Name\";");
            //Act
            bool actualResult = grids["TDBGrid"].IncorrectPropertiesInDesigner;
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IncorrectPropertiesInDesignerTestInvalid2()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits = new List<Split>();
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.Splits[0].AllowColSelect = true;");
            //Act
            bool actualResult = grids["TDBGrid"].IncorrectPropertiesInDesigner;
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestIgnoreMethods()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.InsertHorizontalSplit(1);");
            //Act
            bool actualResult = !grids["TDBGrid"].Properties.ContainsKey("InsertHorizontalSplit");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyDontReadEmptyProperties()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.TDBGrid.HeadingStyle = styleHeading;");
            //Act
            bool actualResult = !grids["TDBGrid"].Styles["HeadingStyle"].Properties.ContainsKey("");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestResourceImageName()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("c1TrueDBGrid1", new C1TrueDBGrid());
            GridPropertyReader.ProcessGridProperty(grids, null, null, "this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject(\"c1TrueDBGrid1.Images1\"))));");
            string expectedResult = "c1TrueDBGrid1.Images1";
            //Act
            string actualResult = grids["c1TrueDBGrid1"].Images["c1TrueDBGrid1.Images1"].Name;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}

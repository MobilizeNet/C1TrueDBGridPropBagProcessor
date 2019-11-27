using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Drawing;
using System.Text.RegularExpressions;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class GridPropertyReaderRemoveLineTest
    {
        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowAddNew()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowAddNew"] = "true";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.AllowAddNew = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowAddNew()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowAddNew"] = "false";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.AllowAddNew = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowArrows()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowArrows"] = "true";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.AllowArrows = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowArrows()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowArrows"] = "false";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.AllowArrows = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowColSelect()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["AllowColSelect"] = "True";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowColSelect = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowColSelect()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["AllowColSelect"] = "False";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowColSelect = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowDelete()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowDelete"] = "false";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.AllowDelete = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowDelete()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowDelete"] = "true";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.AllowDelete = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowDrop()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowDrop"] = "false";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.AllowDrop = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowDrop()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowDrop"] = "true";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.AllowDrop = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowUpdate()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowUpdate"] = "true";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowUpdate = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowUpdate()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["AllowUpdate"] = "false";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowUpdate = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowColMove()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["AllowColMove"] = "True";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowColMove = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowColMove()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["AllowColMove"] = "False";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowColMove = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowRowSelect()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["AllowRowSelect"] = "True";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowRowSelect = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowRowSelect()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["AllowRowSelect"] = "False";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowRowSelect = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveAllowRowSizing()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["AllowRowSizing"] = "AllRows";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveAllowRowSizing()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["AllowRowSizing"] = "IndividualRows";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.IndividualRows;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveBackColor1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            bool expectedResult = false;
            //Act
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.BackColor = System.Drawing.Color.Red;");
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.BackColor = System.Drawing.Color.Red;"); ;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveBackColor2()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            bool expectedResult = false;
            //Act
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.BackColor = System.Drawing.Color.Blue;");
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.BackColor = System.Drawing.Color.Blue;");
            GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.BackColor = System.Drawing.Color.Blue;");
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.BackColor = System.Drawing.Color.Blue;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveBackColor1()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            bool expectedResult = true;
            //Act
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.BackColor = System.Drawing.Color.Red;");
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.BackColor = System.Drawing.Color.Red;");
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.BackColor = System.Drawing.Color.Red;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveBackColor2()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            bool expectedResult = true;
            //Act
            GridPropertyReader.ProcessGridProperty(grids, null, null, "  this.TDBGrid.BackColor = System.Drawing.SystemColors.Control;");
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "  this.TDBGrid.BackColor = System.Drawing.SystemColors.Control;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveBorderStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["BorderStyle"] = "None";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveBorderStyle()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["BorderStyle"] = "FixedSingle";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveCaption()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Caption"] = "Test";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Caption = \"Test\";");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveCaption()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Caption"] = "";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Caption = \"\";");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveCausesValidation()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["CausesValidation"] = "false";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.CausesValidation = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveCausesValidation()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["CausesValidation"] = "true";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.CausesValidation = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveCellTips()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["CellTips"] = "Anchored";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveCellTips()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["CellTips"] = "NoCellTips";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.NoCellTips;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveCellTipsDelay()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["CellTipsDelay"] = "600";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.CellTipsDelay = 600;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveCellTipsDelay()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["CellTipsDelay"] = "500";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.CellTipsDelay = 500;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveCellTipsWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["CellTipsWidth"] = "10";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.CellTipsWidth = 600;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveCellTipsWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["CellTipsWidth"] = "0";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.CellTipsWidth = 0;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveColumnFooters()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["ColumnFooters"] = "true";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.ColumnFooters = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveColumnFooters()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["ColumnFooters"] = "false";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.ColumnFooters = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveColumnHeaders()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["ColumnHeaders"] = "false";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.ColumnHeaders = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveColumnHeaders()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["ColumnHeaders"] = "true";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.ColumnHeaders = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveDefColWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["DefColWidth"] = "10";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.DefColWidth = 10;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveDefColWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["DefColWidth"] = "0";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.DefColWidth = 0;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveDirectionAfterEnter()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["DirectionAfterEnter"] = Constants.DIRECTION_AFTER_ENTER_ENUM + "MoveUp";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveUp;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveDirectionAfterEnter()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["DirectionAfterEnter"] = Constants.DIRECTION_AFTER_ENTER_ENUM + "MoveRight";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveRight;");
            //Assert
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveEditDropDown()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["EditDropDown"] = "false";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.EditDropDown = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveEditDropDown()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["EditDropDown"] = "true";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.EditDropDown = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveEmptyRows()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["EmptyRows"] = "true";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.EmptyRows = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveEmptyRows()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["EmptyRows"] = "false";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.EmptyRows = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveEnabled()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Enabled"] = "false";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Enabled = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveEnabled()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Enabled"] = "true";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Enabled = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveExposeCellMode()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["ExposeCellMode"] = "ScrollOnEdit";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.ExposeCellMode = C1.Win.C1TrueDBGrid.ExposeCellModeEnum.ScrollOnEdit;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveExposeCellMode()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["ExposeCellMode"] =  "ScrollOnSelect";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.ExposeCellMode = C1.Win.C1TrueDBGrid.ExposeCellModeEnum.ScrollOnSelect;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveExtendRightColumn()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["ExtendRightColumn"] = "True";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.ExtendRightColumn = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveExtendRightColumn()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["ExtendRightColumn"] = "False";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.ExtendRightColumn = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveFetchRowStyles()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["FetchRowStyles"] = "True";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.FetchRowStyles = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveFetchRowStyles()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["FetchRowStyles"] = "False";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.FetchRowStyles = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveLocation()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Location"] = "new System.Drawing.Point(32, 16)";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Location = new System.Drawing.Point(32, 16);");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveMultiSelect()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["MultiSelect"] = Constants.MULTI_SELECT_ENUM + "Simple";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Simple;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveMultiSelect()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["MultiSelect"] = "Extended";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Extended;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveRecordSelectors()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["RecordSelectors"] = "False";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.RecordSelectors = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveRecordSelectors()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["RecordSelectors"] = "True";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.RecordSelectors = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveRecordSelectorWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["RecordSelectorWidth"] = "21";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.RecordSelectorWidth = 21;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveRecordSelectorWidth()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Splits.Add(new Split());
            grids["TDBGrid"].Splits[0].Properties["RecordSelectorWidth"] = "17";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.RecordSelectorWidth = 17;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveRowHeight()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["RowHeight"] = "20";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.RowHeight = 20;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveRowHeight()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["RowHeight"] = "15";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.RowHeight = 15;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveSize()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Size = new System.Drawing.Size(569, 257);");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveTabAcrossSplits()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["TabAcrossSplits"] = "true";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.TabAcrossSplits = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveTabAcrossSplits()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["TabAcrossSplits"] = "false";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.TabAcrossSplits = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveTabAction()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["TabAction"] = Constants.TAB_ACTION_ENUM + "ColumnNavigation";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveTabAction()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["TabAction"] = "ControlNavigation";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ControlNavigation;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveTabStop()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["TabStop"] = "false";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.TabStop = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveTabStop()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["TabStop"] = "true";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.TabStop = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveTabIndex()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["TabIndex"] = "0";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.TabIndex = 0;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveTag()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Tag"] = "";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Tag = \"\";");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveTag()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Tag"] = "ABC";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Tag = \"ABC\";");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveVisible()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Visible"] = "false";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Visible = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveVisible()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Visible"] = "true";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Visible = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveWrapCellPointer()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["WrapCellPointer"] = "true";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.WrapCellPointer = true;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveWrapCellPointer()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["WrapCellPointer"] = "false";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.WrapCellPointer = false;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveCursor()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Cursor"] = "Help";
            bool expectedResult = false;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Cursor = System.Windows.Forms.Cursors.Help;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveCursor()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            grids["TDBGrid"].Properties["Cursor"] = "Default";
            bool expectedResult = true;
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Cursor = System.Windows.Forms.Cursors.Default;");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemoveEvent()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.Click += new System.EventHandler(this.TDBGrid_Click);");
            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemovePageSettingObject()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject(\"TDBGrid.PrintInfo.PageSettings\")));");
            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestDontRemovePageSettingProperty()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.PrintInfo.PageSettings.Collate = true;");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridPropertyTestRemoveMethodCalls()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.InsertHorizontalSplit(1);");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void MustRemoveLineTestRemovePageSettingsProperty()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.PrintInfo.PageSettings.Landscape = false;");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void MustRemoveLineTestDontRemovePageSettingsLine()
        {
            //Arrange
            Dictionary<string, C1TrueDBGrid> grids = new Dictionary<string, C1TrueDBGrid>();
            grids.Add("TDBGrid", new C1TrueDBGrid());
            //Act
            bool actualResult = GridPropertyReader.MustRemoveLine(grids, "this.TDBGrid.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject(\"TablaElaborada.PrintInfo.PageSettings\")));");
            //Assert
            Assert.IsFalse(actualResult);
        }
    }
}

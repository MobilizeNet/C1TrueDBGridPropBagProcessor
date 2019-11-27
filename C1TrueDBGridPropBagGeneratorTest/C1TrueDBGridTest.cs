using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Drawing;
using System.Xml.Linq;
using System.Linq;
using System.Xml.XPath;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class C1TrueDBGridTest
    {
        [TestMethod]
        public void ParsedFromXMLTestDefaultValue()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            bool expectedResult = false;
            //Act
            bool actualResult = grid.ParsedFromXML;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParsedFromXMLTestSetAndGet()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            bool expectedResult = true;
            //Act
            grid.ParsedFromXML = true;
            bool actualResult = grid.ParsedFromXML;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyBagAlreadyExistsTestDefaultValue()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            bool expectedResult = false;
            //Act
            bool actualResult = grid.PropertyBagAlreadyExists;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropertyBagAlreadyExistsTestSetAndGet()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            bool expectedResult = true;
            //Act
            grid.PropertyBagAlreadyExists = true;
            bool actualResult = grid.PropertyBagAlreadyExists;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IncorrectPropertiesInDesignerTestDefaultValue()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            bool expectedResult = false;
            //Act
            bool actualResult = grid.IncorrectPropertiesInDesigner;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IncorrectPropertiesInDesignerTestSetAndGet()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            bool expectedResult = true;
            //Act
            grid.IncorrectPropertiesInDesigner = true;
            bool actualResult = grid.IncorrectPropertiesInDesigner;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void NameTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "";
            //Act
            string actualResult = grid.Properties["Name"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void HeightTestSetAndGet()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Height = 5;
            int expectedResult = 5;
            //Act
            int actualResult = grid.Height;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TabIndexDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "0";
            //Act
            string actualResult = grid.Properties["TabIndex"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WidthTestSetAndGet()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Width = 5;
            int expectedResult = 5;
            //Act
            int actualResult = grid.Width;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DataColsTestCount()
        {
            //Arrange
            List<C1DataColumn> dataCols = new List<C1DataColumn>();

            int expectedResult = 0;
            //Act
            int actualResult = dataCols.Count;
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DataColsTestAdd()
        {
            //Arrange
            List<C1DataColumn> dataCols = new List<C1DataColumn>();
            C1DataColumn dataC = new C1DataColumn();
            dataC.Properties["Caption"] = "abc";
            dataCols.Add(dataC);
            string expectedResult = "abc";
            //Act
            string actualResult = dataCols[0].Properties["Caption"];
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SplitsTestCount()
        {
            //Arrange
            List<Split> splitList = new List<Split>();

            int expectedResult = 0;
            //Act
            int actualResult = splitList.Count;
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SplitsTestAdd()
        {
            //Arrange
            List<Split> splitList = new List<Split>();
            Split split = new Split();
            split.Properties["Name"] = "abc";
            splitList.Add(split);
            string expectedResult = "abc";
            //Act
            string actualResult = splitList[0].Properties["Name"];
            //Assert  
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowUpdateTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["AllowUpdate"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DefColWidthTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "0";
            //Act
            string actualResult = grid.Properties["DefColWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CellTipsWidthTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "0";
            //Act
            string actualResult = grid.Properties["CellTipsWidth"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BackColorTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "System.Drawing.SystemColors.Control";
            //Act
            string actualResult = grid.Properties["BackColor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DirectionAfterEnterTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "MoveRight";
            //Act
            string actualResult = grid.Properties["DirectionAfterEnter"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowAddNewTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "false";
            //Act
            string actualResult = grid.Properties["AllowAddNew"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowArrowsTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["AllowArrows"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AllowDeleteTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "false";
            //Act
            string actualResult = grid.Properties["AllowDelete"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BorderStyleTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "FixedSingle";
            //Act
            string actualResult = grid.Properties["BorderStyle"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CausesValidationTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["CausesValidation"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void CellTipsTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "NoCellTips";
            //Act
            string actualResult = grid.Properties["CellTips"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CellTipsDelayTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "500";
            //Act
            string actualResult = grid.Properties["CellTipsDelay"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ColumnFootersTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "false";
            //Act
            string actualResult = grid.Properties["ColumnFooters"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ColumnHeadersTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["ColumnHeaders"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EditDropDownTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["EditDropDown"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EmptyRowsTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "false";
            //Act
            string actualResult = grid.Properties["EmptyRows"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnabledTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["Enabled"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExposeCellModeDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "ScrollOnSelect";
            //Act
            string actualResult = grid.Properties["ExposeCellMode"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MultiSelectDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "Extended";
            //Act
            string actualResult = grid.Properties["MultiSelect"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void RowHeightTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "17";
            //Act
            string actualResult = grid.Properties["RowHeight"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ScrollTipsTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "false";
            //Act
            string actualResult = grid.Properties["ScrollTips"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ScrollTrackTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["ScrollTrack"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TabAcrossSplitsTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "false";
            //Act
            string actualResult = grid.Properties["TabAcrossSplits"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TabActionTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "ControlNavigation";
            //Act
            string actualResult = grid.Properties["TabAction"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TabStopTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["TabStop"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TagTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "";
            //Act
            string actualResult = grid.Properties["Tag"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void VisibleTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "true";
            //Act
            string actualResult = grid.Properties["Visible"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WrapCellPointerTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "false";
            //Act
            string actualResult = grid.Properties["WrapCellPointer"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CursorTestDefaultValue()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "Default";
            //Act
            string actualResult = grid.Properties["Cursor"];
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TimesReadBackColorTestSetAndGet()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.TimesReadBackColor = 3;
            int expectedResult = 3;
            //Act
            int actualResult = grid.TimesReadBackColor;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TimesReadNameTestSetAndGet()
        {
            //Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.TimesReadName = 2;
            int expectedResult = 2;
            //Act
            int actualResult = grid.TimesReadName;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ToXmlTest_HasBaseXml()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits.Add(new Split());
            XElement gridXelement = grid.ToXML();
            List<string> baseElements = new List<string>();
            baseElements.Add("Styles");
            baseElements.Add("Splits");
            baseElements.Add("NamedStyles");
            baseElements.Add("vertSplits");
            baseElements.Add("horzSplits");
            baseElements.Add("Layout");
            baseElements.Add("DefaultRecSelWidth");
            baseElements.Add("ClientArea");
            baseElements.Add("PrintPageHeaderStyle");
            baseElements.Add("PrintPageFooterStyle");
            // Act
            bool actualResult = baseElements.TrueForAll(x => gridXelement.Element(x) != null);
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ToXmlTest_HasStyles()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits.Add(new Split());
            grid.AssignStyleNameParent();
            XElement stylesXelement = grid.ToXML().Element("NamedStyles");
            string actualResult = "";
            string expectedResult = "parent=\"\" me=\"Normal\",parent=\"Normal\" me=\"Heading\",parent=\"Heading\" me=\"Footer\"," +
                "parent=\"Heading\" me=\"Caption\",parent=\"Heading\" me=\"Inactive\",parent=\"Normal\" me=\"Selected\"," +
                "parent=\"Normal\" me=\"Editor\",parent=\"Normal\" me=\"HighlightRow\",parent=\"Normal\" me=\"EvenRow\"," +
                "parent=\"Normal\" me=\"OddRow\",parent=\"Heading\" me=\"RecordSelector\",parent=\"Normal\" me=\"FilterBar\"," +
                "parent=\"FilterBar\" me=\"FilterWatermark\",parent=\"Caption\" me=\"Group\",parent=\"RecordSelector\" me=\"RowSelector\","+
                "parent=\"Heading\" me=\"ColumnSelector\",";
            // Act
            foreach (XElement style in stylesXelement.Elements())
            {
                actualResult += $"{style.Attribute("parent")} {style.Attribute("me")},";
            }
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AssignStyleNameParentTest_XMLUniqueNames()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            Split split = new Split();
            split.DisplayCols.Add(new C1DisplayColumn());
            grid.Splits.Add(split);
            grid.DataCols.Add(new C1DataColumn());
            // Act
            grid.AssignStyleNameParent();
            IEnumerable<XElement> styles = grid.ToXML().XPathSelectElements("//*[@me and @parent]");
            // Check if elements repeat
            Dictionary<String, Int32> countNames = new Dictionary<string, int>();
            foreach(XElement style in styles)
            {
                string key = style.Attribute("me").Value;
                if (!countNames.ContainsKey(key))
                {
                    countNames[key] = 0;
                }
                countNames[key]++;
            }
            bool actualResult = countNames.Values.All(x => x == 1);
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void AssignStyleNameParentTest_ExistsParents()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            Split split = new Split();
            split.DisplayCols.Add(new C1DisplayColumn());
            grid.Splits.Add(split);
            grid.DataCols.Add(new C1DataColumn());
            // Act
            grid.AssignStyleNameParent();
            Dictionary<string, Style> styles = grid.AllStyles;
            bool actualResult = styles.Values.All(x => (styles.ContainsKey(x.Parent)) || x.Parent.Equals(""));
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void AssignStyleNameParentTest_HasAllStyles1()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits[0].DisplayCols.Add(new C1DisplayColumn());
            grid.DataCols.Add(new C1DataColumn());
            int expectedResult = 41;
            //Act
            grid.AssignStyleNameParent();
            int actualResult = grid.AllStyles.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AssignStyleNameParentTest_HasAllStyles2()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits[0].DisplayCols.Add(new C1DisplayColumn());
            grid.Splits[0].DisplayCols.Add(new C1DisplayColumn());
            grid.DataCols.Add(new C1DataColumn());
            grid.DataCols.Add(new C1DataColumn());
            int expectedResult = 48;
            //Act
            grid.AssignStyleNameParent();
            int actualResult = grid.AllStyles.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AssignStyleNameParentTest_HasAllStyles3()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            Split split2 = new Split();
            grid.Splits[0].DisplayCols.Add(new C1DisplayColumn());
            split2.DisplayCols.Add(new C1DisplayColumn());
            grid.Splits.Add(split2);
            grid.DataCols.Add(new C1DataColumn());
            int expectedResult = 64;
            //Act
            grid.AssignStyleNameParent();
            int actualResult = grid.AllStyles.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AssignStyleNameParentTest_XMLValidParents()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            Split split = new Split();
            split.DisplayCols.Add(new C1DisplayColumn());
            grid.Splits.Add(split);
            grid.DataCols.Add(new C1DataColumn());
            // Act
            grid.AssignStyleNameParent();
            Dictionary<String, Style> stylesDictionary = grid.AllStyles;
            IEnumerable<XElement> styles = grid.ToXML().XPathSelectElements("//*[@me and @parent]");
            bool actualResult = styles.All(x => stylesDictionary.ContainsKey(x.Attribute("parent").Value) || x.Attribute("parent").Value.Equals(""));
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void CalculateClientAreaAndClientRectTest_ClientArea()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits.Add(new Split());
            grid.Width = 200;
            grid.Height = 150;
            string expectedResult = "0, 0, 198, 148";
            // Act
            grid.CalculateClientAreaAndClientRect();
            string actualResult = grid.Properties["ClientArea"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateClientAreaAndClientRectTest_ClientRect1()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits.Add(new Split());
            grid.Width = 200;
            grid.Height = 150;
            string expectedResult = "0, 0, 97, 148|102, 0, 96, 148";
            // Act
            grid.CalculateClientAreaAndClientRect();
            string actualResult = $"{grid.Splits[0].Properties["ClientRect"]}|{grid.Splits[1].Properties["ClientRect"]}";
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateClientAreaAndClientRectTest_ClientRect2()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits.Add(new Split());
            grid.Width = 207;
            grid.Height = 155;
            string expectedResult = "0, 0, 100, 153|105, 0, 100, 153";
            // Act
            grid.CalculateClientAreaAndClientRect();
            string actualResult = $"{grid.Splits[0].Properties["ClientRect"]}|{grid.Splits[1].Properties["ClientRect"]}";
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateClientAreaAndClientRectTest_ClientRect3()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Width = 351;
            grid.Height = 248;
            string expectedResult = "0, 0, 349, 246";
            // Act
            grid.CalculateClientAreaAndClientRect();
            string actualResult = grid.Splits[0].Properties["ClientRect"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AssignSplitsBorderSideTest1()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            string expectedResult = "0";
            // Act
            grid.AssignSplitsBorderSide();
            string actualResult = grid.Splits[0].Properties["BorderSide"];
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AssignSplitsBorderSideTest2()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits.Add(new Split());
            string expectedResult = "Right|Left";
            // Act
            grid.AssignSplitsBorderSide();
            string actualResult = $"{grid.Splits[0].Properties["BorderSide"]}|{grid.Splits[1].Properties["BorderSide"]}";
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AssignSplitsBorderSideTest3()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits.Add(new Split());
            grid.Splits.Add(new Split());
            string expectedResult = "Right|Left, Right|Left";
            // Act
            grid.AssignSplitsBorderSide();
            string actualResult = $"{grid.Splits[0].Properties["BorderSide"]}|{grid.Splits[1].Properties["BorderSide"]}|{grid.Splits[2].Properties["BorderSide"]}";
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AssignSplitNamesTest()
        {
            // Arrange
            C1TrueDBGrid grid = new C1TrueDBGrid();
            grid.Splits.Add(new Split());
            string expectedResult = "Split[0,0]|Split[0,1]";
            // Act
            grid.AssignSplitNames();
            string actualResult = $"{grid.Splits[0].Properties["Name"]}|{grid.Splits[1].Properties["Name"]}";
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseXMLTestProperties()
        {
            //Arrange
            XElement gridXml = XElement.Parse("<?xml version=\"1.0\"?> " +
            "<Blob>" +
                "<DataCols>" +
                    "<C1DataColumn Caption=\"Column New\" DataField=\"\" DataWidth=\"3\" DefaultValue=\"hhd\">" +
                        "<FilterCancelText>&amp;Close</FilterCancelText>" +
                        "<FilterClearText>C&amp;lear</FilterClearText>" +
                        "<ValueItems />" +
                        "<GroupInfo>" +
                            "<AggregatesText>{0}</AggregatesText>" +
                        "</GroupInfo>" +
                    "</C1DataColumn>" +
                "</DataCols>" +
                "<Styles type=\"C1.Win.C1TrueDBGrid.Design.ContextWrapper\">" +
                    "<Data>HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style8{}Style19{AlignHorz:Near;}Style18{}Style7{}Style2{}EvenRow{BackColor:Aqua;}Normal{}RecordSelector{AlignImage:Center;}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}Style9{}OddRow{}Style3{}Footer{}Style14{}Heading{ForeColor:ControlText;Border:Flat,ControlDark,0, 1, 0, 1;AlignVert:Center;BackColor:Control;WrapText:WrapWithOverflow;}RowSelector{}Style5{}Editor{}Style10{}Style17{}Style16{}Selected{ForeColor:HighlightText;BackColor:Highlight;}Style15{}Style20{AlignHorz:Near;}ColumnSelector{}Style25{}Style13{}Style12{}Style11{}Style4{}Style23{}FilterWatermark{ForeColor:InfoText;BackColor:Info;}Style22{}Group{Border:None,,0, 0, 0, 0;AlignVert:Center;BackColor:ControlDark;}Style21{AlignHorz:Near;}Style1{}Style24{}Caption{AlignHorz:Center;}Style6{}FilterBar{}</Data>" +
                "</Styles>" +
                "<Splits>" +
                    "<C1.Win.C1TrueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
                        "<CaptionStyle parent=\"Style2\" me=\"Style10\" />" +
                        "<EditorStyle parent=\"Editor\" me=\"Style5\" />" +
                        "<EvenRowStyle parent=\"EvenRow\" me=\"Style8\" />" +
                        "<FilterBarStyle parent=\"FilterBar\" me=\"Style15\" />" +
                        "<FilterWatermarkStyle parent=\"FilterWatermark\" me=\"Style16\" />" +
                        "<FooterStyle parent=\"Footer\" me=\"Style3\" />" +
                        "<GroupStyle parent=\"Group\" me=\"Style12\" />" +
                        "<HeadingStyle parent=\"Heading\" me=\"Style2\" />" +
                        "<HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\" />" +
                        "<InactiveStyle parent=\"Inactive\" me=\"Style4\" />" +
                        "<OddRowStyle parent=\"OddRow\" me=\"Style9\" />" +
                        "<RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" />" +
                        "<RowSelectorStyle parent=\"RowSelector\" me=\"Style13\" />" +
                        "<ColumnSelectorStyle parent=\"ColumnSelector\" me=\"Style14\" />" +
                        "<SelectedStyle parent=\"Selected\" me=\"Style6\" />" +
                        "<Style parent=\"Normal\" me=\"Style1\" />" +
                        "<internalCols>" +
                            "<C1DisplayColumn>" +
                                "<HeadingStyle parent=\"Style2\" me=\"Style19\" />" +
                                "<ColumnSelectorStyle parent=\"Style14\" me=\"Style20\" />" +
                                "<Style parent=\"Style1\" me=\"Style21\" />" +
                                "<FooterStyle parent=\"Style3\" me=\"Style22\" />" +
                                "<EditorStyle parent=\"Style5\" me=\"Style23\" />" +
                                "<GroupHeaderStyle parent=\"Style1\" me=\"Style25\" />" +
                                "<GroupFooterStyle parent=\"Style1\" me=\"Style24\" />" +
                                "<Visible>True</Visible>" +
                                "<ColumnDivider>DarkGray,Single</ColumnDivider>" +
                                "<Height>15</Height>" +
                                "<DCIdx>0</DCIdx>" +
                            "</C1DisplayColumn>" +
                        "</internalCols>" +
                        "<ClientRect>0, 0, 478, 226</ClientRect>" +
                        "<BorderSide>0</BorderSide>" +
                    "</C1.Win.C1TrueDBGrid.MergeView>" +
                "</Splits>" +
                "<NamedStyles>" +
                    "<Style parent=\"\" me=\"Normal\" />" +
                    "<Style parent=\"Normal\" me=\"Heading\" />" +
                    "<Style parent=\"Heading\" me=\"Footer\" />" +
                    "<Style parent=\"Heading\" me=\"Caption\" />" +
                    "<Style parent=\"Heading\" me=\"Inactive\" />" +
                    "<Style parent=\"Normal\" me=\"Selected\" />" +
                    "<Style parent=\"Normal\" me=\"Editor\" />" +
                    "<Style parent=\"Normal\" me=\"HighlightRow\" />" +
                    "<Style parent=\"Normal\" me=\"EvenRow\" />" +
                    "<Style parent=\"Normal\" me=\"OddRow\" />" +
                    "<Style parent=\"Heading\" me=\"RecordSelector\" />" +
                    "<Style parent=\"Normal\" me=\"FilterBar\" />" +
                    "<Style parent=\"FilterBar\" me=\"FilterWatermark\" />" +
                    "<Style parent=\"Caption\" me=\"Group\" />" +
                    "<Style parent=\"RecordSelector\" me=\"RowSelector\" />" +
                    "<Style parent=\"Heading\" me=\"ColumnSelector\" />" +
                "</NamedStyles>" +
                "<vertSplits>1</vertSplits>" +
                "<horzSplits>1</horzSplits>" +
                "<Layout>Modified</Layout>" +
                "<DefaultRecSelWidth>17</DefaultRecSelWidth>" +
                "<ClientArea>0, 0, 478, 226</ClientArea>" +
                "<PrintPageHeaderStyle parent=\"\" me=\"Style17\" />" +
                "<PrintPageFooterStyle parent=\"\" me=\"Style18\" />" +
            "</Blob>");
            // Act
            C1TrueDBGrid grid = new C1TrueDBGrid(gridXml);
            bool actualResult = grid.Properties["vertSplits"] == "1" &&
                grid.Properties["horzSplits"] == "1" &&
                grid.Properties["Layout"] == "Modified" &&
                grid.Properties["DefaultRecSelWidth"] == "17" &&
                grid.Properties["ClientArea"] == "0, 0, 478, 226";
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ParseXMLTestStyles()
        {
            //Arrange
            XElement gridXml = XElement.Parse("<?xml version=\"1.0\"?> " +
                "<Blob>" +
                    "<Styles type=\"C1.Win.C1TrueDBGrid.Design.ContextWrapper\">" +
                        "<Data>HighlightRow{ForeColor:HighlightText;BackColor:Orange;}Style8{}Style12{}Style7{}EvenRow{BackColor:Aqua;}Normal{}RecordSelector{AlignImage:Center;}OddRow{}Style6{}Footer{}Style14{}FilterBar{}Heading{WrapText:WrapWithOverflow;AlignVert:Center;Border:Flat,ControlDark,0, 1, 0, 1;ForeColor:Yellow;BackColor:Control;}RowSelector{}Style5{}Editor{}Style10{}Style17{}Style3{}Selected{ForeColor:HighlightText;BackColor:Highlight;}Style15{}ColumnSelector{}Style18{}Style13{}Style9{}Style11{}Style4{}Style16{}FilterWatermark{ForeColor:InfoText;BackColor:Info;}Group{Border:None,,0, 0, 0, 0;AlignVert:Center;BackColor:ControlDark;}Style1{}Caption{AlignHorz:Center;}Style2{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}</Data>" +
                    "</Styles>" +
                    "<Splits>" +
                        "<C1.Win.C1TrueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
                            "<CaptionStyle parent=\"Style2\" me=\"Style10\" />" +
                            "<EditorStyle parent=\"Editor\" me=\"Style5\" />" +
                            "<EvenRowStyle parent=\"EvenRow\" me=\"Style8\" />" +
                            "<FilterBarStyle parent=\"FilterBar\" me=\"Style15\" />" +
                            "<FilterWatermarkStyle parent=\"FilterWatermark\" me=\"Style16\" />" +
                            "<FooterStyle parent=\"Footer\" me=\"Style3\" />" +
                            "<GroupStyle parent=\"Group\" me=\"Style12\" />" +
                            "<HeadingStyle parent=\"Heading\" me=\"Style2\" />" +
                            "<HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\" />" +
                            "<InactiveStyle parent=\"Inactive\" me=\"Style4\" />" +
                            "<OddRowStyle parent=\"OddRow\" me=\"Style9\" />" +
                            "<RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" />" +
                            "<RowSelectorStyle parent=\"RowSelector\" me=\"Style13\" />" +
                            "<ColumnSelectorStyle parent=\"ColumnSelector\" me=\"Style14\" />" +
                            "<SelectedStyle parent=\"Selected\" me=\"Style6\" />" +
                            "<Style parent=\"Normal\" me=\"Style1\" />" +
                            "<ClientRect>0, 0, 478, 226</ClientRect>" +
                            "<BorderSide>0</BorderSide>" +
                        "</C1.Win.C1TrueDBGrid.MergeView>" +
                    "</Splits>" +
                    "<NamedStyles>" +
                        "<Style parent=\"\" me=\"Normal\" />" +
                        "<Style parent=\"Normal\" me=\"Heading\" />" +
                        "<Style parent=\"Heading\" me=\"Footer\" />" +
                        "<Style parent=\"Heading\" me=\"Caption\" />" +
                        "<Style parent=\"Heading\" me=\"Inactive\" />" +
                        "<Style parent=\"Normal\" me=\"Selected\" />" +
                        "<Style parent=\"Normal\" me=\"Editor\" />" +
                        "<Style parent=\"Normal\" me=\"HighlightRow\" />" +
                        "<Style parent=\"Normal\" me=\"EvenRow\" />" +
                        "<Style parent=\"Normal\" me=\"OddRow\" />" +
                        "<Style parent=\"Heading\" me=\"RecordSelector\" />" +
                        "<Style parent=\"Normal\" me=\"FilterBar\" />" +
                        "<Style parent=\"FilterBar\" me=\"FilterWatermark\" />" +
                        "<Style parent=\"Caption\" me=\"Group\" />" +
                        "<Style parent=\"RecordSelector\" me=\"RowSelector\" />" +
                        "<Style parent=\"Heading\" me=\"ColumnSelector\" />" +
                    "</NamedStyles>" +
                    "<vertSplits>1</vertSplits>" +
                    "<horzSplits>1</horzSplits>" +
                    "<Layout>None</Layout>" +
                    "<DefaultRecSelWidth>17</DefaultRecSelWidth>" +
                    "<ClientArea>0, 0, 478, 226</ClientArea>" +
                    "<PrintPageHeaderStyle parent=\"\" me=\"Style17\" />" +
                    "<PrintPageFooterStyle parent=\"\" me=\"Style18\" />" +
                "</Blob>");
            // Act
            C1TrueDBGrid grid = new C1TrueDBGrid(gridXml);
            bool actualResult = grid.Styles["HighLightRowStyle"].Properties["BackColor"] == "Orange" &&
                grid.Styles["HeadingStyle"].Properties["ForeColor"] == "Yellow";
            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}

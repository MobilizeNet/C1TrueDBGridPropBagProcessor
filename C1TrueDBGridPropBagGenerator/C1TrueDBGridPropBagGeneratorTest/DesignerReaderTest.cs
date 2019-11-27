using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.Drawing;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Linq;

namespace C1TrueDBGridPropBagGeneratorTest
{
    /// <summary>
    /// Summary description for DesignerReaderTest
    /// </summary>
    [TestClass]
    public class DesignerReaderTest
    {
        [TestMethod]
        public void ResxTagsInsertedTestSetAndGet()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.ResxTagsInserted = 7;
            int expectedResult = 7;
            //Act
            int actualResult = designerReader.ResxTagsInserted;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ResxTagsInsertedTestDefaultValue()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            int expectedResult = 0;
            //Act
            int actualResult = designerReader.ResxTagsInserted;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsIncorrectPropsInDesignerTestSetAndGet()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.GridsIncorrectPropsInDesigner.Add("Grid1");
            designerReader.GridsIncorrectPropsInDesigner.Add("Grid2");
            designerReader.GridsIncorrectPropsInDesigner.Add("Grid3");
            int expectedResult = 3;
            //Act
            int actualResult = designerReader.TotalGridsIncorrectPropsInDesigner;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsIncorrectPropsInDesignerTestDefaultValue()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            int expectedResult = 0;
            //Act
            int actualResult = designerReader.TotalGridsIncorrectPropsInDesigner;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsIncorrectPropsInDesignerAndExistingPropBagTestSetAndGet()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.GridsIncorrectPropsInDesignerAndExistingPropBag.Add("Grid1");
            designerReader.GridsIncorrectPropsInDesignerAndExistingPropBag.Add("Grid2");
            int expectedResult = 2;
            //Act
            int actualResult = designerReader.TotalGridsIncorrectPropsInDesignerAndExistingPropBag;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsIncorrectPropsInDesignerAndExistingPropBagTestDefaultValue()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            int expectedResult = 0;
            //Act
            int actualResult = designerReader.TotalGridsIncorrectPropsInDesignerAndExistingPropBag;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsWithExistingPropBagsTestSetAndGet()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.GridsWithExistingPropBags.Add("Grid0");
            int expectedResult = 1;
            //Act
            int actualResult = designerReader.TotalGridsWithExistingPropBags;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsWithExistingPropBagsTestDefaultValue()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            int expectedResult = 0;
            //Act
            int actualResult = designerReader.TotalGridsWithExistingPropBags;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsTestSetAndGet()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.TotalGrids = 9;
            int expectedResult = 9;
            //Act
            int actualResult = designerReader.TotalGrids;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsTestDefaultValue()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            int expectedResult = 0;
            //Act
            int actualResult = designerReader.TotalGrids;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LineFailedTestSetAndGet()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.CurrentLineIndex = 2341;
            int expectedResult = 2341;
            //Act
            int actualResult = designerReader.CurrentLineIndex;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FilePathTestSetAndGet()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.FilePath = @"C:\Users\TSUser\Desktop\tabla elaborada_.Net - Copy\Upgraded";
            string expectedResult = @"C:\Users\TSUser\Desktop\tabla elaborada_.Net - Copy\Upgraded";
            //Act
            string actualResult = designerReader.FilePath;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GridsDictionaryTestEmptyByDefault()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            // Act
            bool actualResult = designerReader.Grids.Count == 0;
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridNameTest1()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            //Act
            designerReader.ProcessGridName("public C1.Win.C1TrueDBGrid.C1TrueDBGrid TDBGrid;");
            bool actualResult = designerReader.Grids.ContainsKey("TDBGrid");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridNameTest2()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            designerReader.Resx.Add(new XElement("root", new XElement("data", new XAttribute("name", "TDBGrid.PropBag"))));
            //Act
            designerReader.ProcessGridName("public C1.Win.C1TrueDBGrid.C1TrueDBGrid TDBGrid;");
            bool actualResult = designerReader.Grids.ContainsKey("TDBGrid");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridNameTestPrivate()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            //Act
            designerReader.ProcessGridName("private C1.Win.C1TrueDBGrid.C1TrueDBGrid _grid00;");
            bool actualResult = designerReader.Grids.ContainsKey("_grid00");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridNameTestProtected()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            //Act
            designerReader.ProcessGridName("protected C1.Win.C1TrueDBGrid.C1TrueDBGrid PrGrid;");
            bool actualResult = designerReader.Grids.ContainsKey("PrGrid");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridNameTestInternal()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            //Act
            designerReader.ProcessGridName("internal C1.Win.C1TrueDBGrid.C1TrueDBGrid IntGrid;");
            bool actualResult = designerReader.Grids.ContainsKey("IntGrid");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessColumnNameTest()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            //Act
            designerReader.ProcessColumnName("public C1.Win.C1TrueDBGrid.C1DataColumn column0;");
            bool actualResult = designerReader.Columns.ContainsKey("column0");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessValueItemNameTest()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            //Act
            designerReader.ProcessValueItemName("public C1.Win.C1TrueDBGrid.ValueItem ValueItem_0_Column_1_TDBGrid;");
            bool actualResult = designerReader.ValueItems.ContainsKey("ValueItem_0_Column_1_TDBGrid");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessGridNameTestHelper()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            //Act
            designerReader.ProcessGridName("public UpgradeHelpers.Helpers.C1TrueDBGridHelper grd2;");
            bool actualResult = designerReader.Grids.ContainsKey("grd2");
            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void MustWritePropBagLinesTest()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            bool expectedResult = true;
            //Act
            bool actualResult = designerReader.MustWritePropBagLines("this.SuspendLayout();");
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void InsertResxTagLinesTest()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["TDBGrid1"] = new C1TrueDBGrid();
            designerReader.Grids["TDBGrid2"] = new C1TrueDBGrid();
            designerReader.OutputDesignerLines.Add("   this.SuspendLayout();");
            StringWriter strWr = new StringWriter();
            // Act
            designerReader.InsertResxTagLines();
            bool actualResult = designerReader.OutputDesignerLines.Contains("\t\t\tthis.TDBGrid1.PropBag = resources.GetString(\"TDBGrid1.PropBag\");") &&
                designerReader.OutputDesignerLines.Contains("\t\t\tthis.TDBGrid2.PropBag = resources.GetString(\"TDBGrid2.PropBag\");");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessLineTest()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            StringWriter strWr = new StringWriter();
            // Act
            designerReader.ProcessLine("public C1.Win.C1TrueDBGrid.C1TrueDBGrid TestGrid;");
            bool actualResult = designerReader.OutputDesignerLines.Contains("public C1.Win.C1TrueDBGrid.C1TrueDBGrid TestGrid;");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessLineTest_ColumnNames()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            StringWriter strWr = new StringWriter();
            // Act
            designerReader.ProcessLine("public C1.Win.C1TrueDBGrid.C1DataColumn TDBGrid_Column0;");
            bool actualResult = !designerReader.OutputDesignerLines.Contains("public C1.Win.C1TrueDBGrid.C1DataColumn TDBGrid_Column0;");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessLineTest_ValueItemNames()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            StringWriter strWr = new StringWriter();
            // Act
            designerReader.ProcessLine("public C1.Win.C1TrueDBGrid.ValueItem valueItem01;");
            bool actualResult = !designerReader.OutputDesignerLines.Contains("public C1.Win.C1TrueDBGrid.ValueItem valueItem01;");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void RemoveIncorrectLinesTest_MustRemove1()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["TDBGrid1"] = new C1TrueDBGrid();
            designerReader.OutputDesignerLines.Add("this.TDBGrid1.Columns[0].EditMaskUpdate = false;");
            // Act
            designerReader.RemoveIncorrectLines();
            bool actualResult = designerReader.OutputDesignerLines.Count == 0;
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void RemoveIncorrectLinesTest_MustRemove2()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["TDBGrid1"] = new C1TrueDBGrid();
            designerReader.OutputDesignerLines.Add("this.TDBGrid1.Splits[0].FetchRowStyle = false;");
            // Act
            designerReader.RemoveIncorrectLines();
            bool actualResult = !designerReader.OutputDesignerLines.Contains("this.TDBGrid1.Splits[0].FetchRowStyle = false;");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void RemoveIncorrectLinesTest_MustNotRemove1()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["TDBGrid1"] = new C1TrueDBGrid();
            // Act
            designerReader.ProcessLine("this.TDBGrid1.CellTipsDelay = 1001;");
            bool actualResult = designerReader.OutputDesignerLines.Contains("this.TDBGrid1.CellTipsDelay = 1001;");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void InsertResxTagsTest1()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["TDBGrid1"] = new C1TrueDBGrid();
            designerReader.Grids["TDBGrid1"].Splits.Add(new Split());
            XDocument resx = new XDocument(new XElement("root"));
            designerReader.Resx = resx;
            // Act
            designerReader.InsertResxTags();
            bool actualResult = resx.XPathSelectElement("//data[@name='TDBGrid1.PropBag']") != null;
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void InsertResxTagsTest2()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["TDBGrid1"] = new C1TrueDBGrid();
            designerReader.Grids["TDBGrid1"].Splits.Add(new Split());
            designerReader.Grids["TDBGrid2"] = new C1TrueDBGrid();
            designerReader.Grids["TDBGrid2"].Splits.Add(new Split());
            XDocument resx = new XDocument(new XElement("root"));
            designerReader.Resx = resx;
            // Act
            designerReader.InsertResxTags();
            bool actualResult = designerReader.Grids.Keys.All(x => resx.XPathSelectElement($"//data[@name='{x}.PropBag']") != null);
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void GetResxFilename()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            string expectedResult = "TestForm.resX";
            // Act
            string actualResult = designerReader.GetResxFilename("TestForm.Designer.cs");
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemovePropBagTest()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            designerReader.Resx.Add(new XElement("root", new XElement("data", new XAttribute("name", "TDBGrid.PropBag"))));
            // Act
            designerReader.RemovePropertyBag("TDBGrid");
            bool actualResult = designerReader.Resx.XPathSelectElement($"//data[@name='TDBGrid.PropBag']") == null;
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void RemoveAllPropBagTest()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument();
            designerReader.Resx.Add(new XElement("root", new XElement("data", new XAttribute("name", "TDBGrid.PropBag")), new XElement("data", new XAttribute("name", "TDBGrid2.PropBag"))));
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            designerReader.Grids.Add("TDBGrid2", new C1TrueDBGrid());
            // Act
            designerReader.RemovePropertyBagsProcessedGrids();
            bool actualResult = designerReader.Resx.XPathSelectElement($"//data[@name='TDBGrid.PropBag']") == null
                && designerReader.Resx.XPathSelectElement($"//data[@name='TDBGrid2.PropBag']") == null;
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void ProcessAllLinesTest_LineFailed()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = new XDocument(new XElement("root"));
            string[] lines = {
                "public C1.Win.C1TrueDBGrid.C1TrueDBGrid grid1;",
                "private void InitializeComponent()",
                "this.grid1.CaptionStyle.Font = ggfxdfsdfdfsd;",
                "this.grid1.CaptionStyle.ForeColor = System.Drawing.SystemColors.ControlText;"
            };
            int expectedResult = 3;
            // Act
            try
            {
                designerReader.CheckGridVariables(lines);
                designerReader.ProcessAllLines(lines);
            } catch (Exception ex)
            {
                // do nothing
            }
            int actualResult = designerReader.CurrentLineIndex;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExistingGridsPropertyRegExTest1()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            string expectedResult = @"^this\.(TDBGrid)\.";
            //Act
            string actualResult = designerReader.ExistingGridsPropertyRegEx();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExistingGridsPropertyRegExTest2()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            designerReader.Grids.Add("ExtraGrid", new C1TrueDBGrid());
            string expectedResult = @"^this\.(TDBGrid|ExtraGrid)\.";
            //Act
            string actualResult = designerReader.ExistingGridsPropertyRegEx();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExistingColumnsPropertyRegExTest1()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Columns.Add("column0", new C1DataColumn());
            string expectedResult = @"^this\.(column0)\.?";
            //Act
            string actualResult = designerReader.ExistingColumnPropertyRegEx();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExistingColumnsPropertyRegExTest2()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Columns.Add("column0", new C1DataColumn());
            designerReader.Columns.Add("column1", new C1DataColumn());
            string expectedResult = @"^this\.(column0|column1)\.?";
            //Act
            string actualResult = designerReader.ExistingColumnPropertyRegEx();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExistingValueItemsPropertyRegExTest1()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.ValueItems.Add("value1", new ValueItem());
            string expectedResult = @"^this\.(value1)\.?";
            //Act
            string actualResult = designerReader.ExistingValueItemsPropertyRegEx();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExistingValueItemsRegExTest2()
        {
            //Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.ValueItems.Add("value0", new ValueItem());
            designerReader.ValueItems.Add("value1", new ValueItem());
            string expectedResult = @"^this\.(value0|value1)\.?";
            //Act
            string actualResult = designerReader.ExistingValueItemsPropertyRegEx();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ParseAllPropertyBagsTest_NumberGrids()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Resx = XDocument.Parse("<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
            "<root>" +
            "<data name=\"c1TrueDBGrid1.PropBag\" xml:space=\"preserve\">" +
                "<value>&lt;?xml version=\"1.0\"?&gt;&lt;Blob&gt;&lt;Styles type=\"C1.Win.C1TrueDBGrid.Design.ContextWrapper\"&gt;&lt;Data&gt;HighlightRow{ForeColor:HighlightText;BackColor:Orange;}Style8{}Style12{}Style7{}EvenRow{BackColor:Aqua;}Normal{}RecordSelector{AlignImage:Center;}OddRow{}Style6{}Footer{}Style14{}FilterBar{}Heading{WrapText:WrapWithOverflow;AlignVert:Center;Border:Flat,ControlDark,0, 1, 0, 1;ForeColor:Yellow;BackColor:Control;}RowSelector{}Style5{}Editor{}Style10{}Style17{}Style3{}Selected{ForeColor:HighlightText;BackColor:Highlight;}Style15{}ColumnSelector{}Style18{}Style13{}Style9{}Style11{}Style4{}Style16{}FilterWatermark{ForeColor:InfoText;BackColor:Info;}Group{Border:None,,0, 0, 0, 0;AlignVert:Center;BackColor:ControlDark;}Style1{}Caption{AlignHorz:Center;}Style2{}Inactive{ForeColor:InactiveCaptionText;BackColor:InactiveCaption;}&lt;/Data&gt;&lt;/Styles&gt;&lt;Splits&gt;&lt;C1.Win.C1TrueDBGrid.MergeView Name=\"\" CaptionHeight=\"17\" ColumnCaptionHeight=\"17\" ColumnFooterHeight=\"17\" MarqueeStyle=\"DottedCellBorder\" RecordSelectorWidth=\"17\" DefRecSelWidth=\"17\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"&gt;&lt;CaptionStyle parent=\"Style2\" me=\"Style10\" /&gt;&lt;EditorStyle parent=\"Editor\" me=\"Style5\" /&gt;&lt;EvenRowStyle parent=\"EvenRow\" me=\"Style8\" /&gt;&lt;FilterBarStyle parent=\"FilterBar\" me=\"Style15\" /&gt;&lt;FilterWatermarkStyle parent=\"FilterWatermark\" me=\"Style16\" /&gt;&lt;FooterStyle parent=\"Footer\" me=\"Style3\" /&gt;&lt;GroupStyle parent=\"Group\" me=\"Style12\" /&gt;&lt;HeadingStyle parent=\"Heading\" me=\"Style2\" /&gt;&lt;HighLightRowStyle parent=\"HighlightRow\" me=\"Style7\" /&gt;&lt;InactiveStyle parent=\"Inactive\" me=\"Style4\" /&gt;&lt;OddRowStyle parent=\"OddRow\" me=\"Style9\" /&gt;&lt;RecordSelectorStyle parent=\"RecordSelector\" me=\"Style11\" /&gt;&lt;RowSelectorStyle parent=\"RowSelector\" me=\"Style13\" /&gt;&lt;ColumnSelectorStyle parent=\"ColumnSelector\" me=\"Style14\" /&gt;&lt;SelectedStyle parent=\"Selected\" me=\"Style6\" /&gt;&lt;Style parent=\"Normal\" me=\"Style1\" /&gt;&lt;ClientRect&gt;0, 0, 478, 226&lt;/ClientRect&gt;&lt;BorderSide&gt;0&lt;/BorderSide&gt;&lt;/C1.Win.C1TrueDBGrid.MergeView&gt;&lt;/Splits&gt;&lt;NamedStyles&gt;&lt;Style parent=\"\" me=\"Normal\" /&gt;&lt;Style parent=\"Normal\" me=\"Heading\" /&gt;&lt;Style parent=\"Heading\" me=\"Footer\" /&gt;&lt;Style parent=\"Heading\" me=\"Caption\" /&gt;&lt;Style parent=\"Heading\" me=\"Inactive\" /&gt;&lt;Style parent=\"Normal\" me=\"Selected\" /&gt;&lt;Style parent=\"Normal\" me=\"Editor\" /&gt;&lt;Style parent=\"Normal\" me=\"HighlightRow\" /&gt;&lt;Style parent=\"Normal\" me=\"EvenRow\" /&gt;&lt;Style parent=\"Normal\" me=\"OddRow\" /&gt;&lt;Style parent=\"Heading\" me=\"RecordSelector\" /&gt;&lt;Style parent=\"Normal\" me=\"FilterBar\" /&gt;&lt;Style parent=\"FilterBar\" me=\"FilterWatermark\" /&gt;&lt;Style parent=\"Caption\" me=\"Group\" /&gt;&lt;Style parent=\"RecordSelector\" me=\"RowSelector\" /&gt;&lt;Style parent=\"Heading\" me=\"ColumnSelector\" /&gt;&lt;/NamedStyles&gt;&lt;vertSplits&gt;1&lt;/vertSplits&gt;&lt;horzSplits&gt;1&lt;/horzSplits&gt;&lt;Layout&gt;None&lt;/Layout&gt;&lt;DefaultRecSelWidth&gt;17&lt;/DefaultRecSelWidth&gt;&lt;ClientArea&gt;0, 0, 478, 226&lt;/ClientArea&gt;&lt;PrintPageHeaderStyle parent=\"\" me=\"Style17\" /&gt;&lt;PrintPageFooterStyle parent=\"\" me=\"Style18\" /&gt;&lt;/Blob&gt;</value>" +
              "</data>" +
            "</root>");
            designerReader.Grids["c1TrueDBGrid1"] = new C1TrueDBGrid();
            int expectedResult = 1;
            // Act
            designerReader.CheckPropertyBags();
            int actualResult = designerReader.Grids.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CountTotalCheckGridsIncorrectPropsInDesignerrTest()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["grid1"] = new C1TrueDBGrid();
            designerReader.Grids["grid1"].IncorrectPropertiesInDesigner = true;
            designerReader.Grids["grid2"] = new C1TrueDBGrid();
            designerReader.Grids["grid2"].IncorrectPropertiesInDesigner = true;
            designerReader.Grids["grid2"].PropertyBagAlreadyExists = true;
            int expectedResult = 2;
            // Act
            designerReader.CheckGridsIncorrectPropsInDesigner();
            int actualResult = designerReader.TotalGridsIncorrectPropsInDesigner;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CountTotalGridsIncorrectPropsInDesignerAndExistingPropBagTest()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["grid1"] = new C1TrueDBGrid();
            designerReader.Grids["grid1"].IncorrectPropertiesInDesigner = true;
            designerReader.Grids["grid2"] = new C1TrueDBGrid();
            designerReader.Grids["grid2"].IncorrectPropertiesInDesigner = true;
            designerReader.Grids["grid2"].PropertyBagAlreadyExists = true;
            int expectedResult = 1;
            // Act
            designerReader.CheckGridsIncorrectPropsInDesigner();
            int actualResult = designerReader.TotalGridsIncorrectPropsInDesignerAndExistingPropBag;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckRemoveLineTest()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids["TDBGrid1"] = new C1TrueDBGrid();
            // Act
            bool actualResult = designerReader.CheckRemoveLine("   this.TDBGrid1.Columns[0].EditMaskUpdate = false;");
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void RemoveIncorrectLinesTestLineFailed()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            string[] outputLines = { "   public C1.Win.C1TrueDBGrid.C1TrueDBGrid grd1;",
                "    private void InitializeComponent()",
                "    this.grid1.CaptionStyle.ForeColor = System.Drawing.SystemColors.ControlText;",
                "    this.grid1.CaptionStyle.Font = ggfxdfsdfdfsd;"
            };
            designerReader.OutputDesignerLines = outputLines.ToList();
            int expectedResult = 4;
            // Act
            try
            {
                designerReader.RemoveIncorrectLines();
            }
            catch (Exception ex)
            {
                // ignore
            }
            int actualResult = designerReader.CurrentLineIndex;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void KeepGridsOnlyIncorrectPropertiesInDesignerDictionaryTest1()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            designerReader.Grids["TDBGrid"].PropertyBagAlreadyExists = false;
            designerReader.Grids["TDBGrid"].IncorrectPropertiesInDesigner = true;
            int expectedResult = 1;
            // Act
            designerReader.KeepGridsOnlyIncorrectPropertiesInDesignerDictionary();
            int actualResult = designerReader.Grids.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void KeepGridsOnlyIncorrectPropertiesInDesignerDictionaryTest2()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            designerReader.Grids["TDBGrid"].PropertyBagAlreadyExists = true;
            designerReader.Grids["TDBGrid"].IncorrectPropertiesInDesigner = true;
            int expectedResult = 0;
            // Act
            designerReader.KeepGridsOnlyIncorrectPropertiesInDesignerDictionary();
            int actualResult = designerReader.Grids.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void KeepGridsOnlyExistingPropBagsInDictionaryTest1()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            designerReader.Grids["TDBGrid"].PropertyBagAlreadyExists = true;
            designerReader.Grids["TDBGrid"].IncorrectPropertiesInDesigner = false;
            int expectedResult = 1;
            // Act
            designerReader.KeepGridsOnlyExistingPropBagsInDictionary();
            int actualResult = designerReader.Grids.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void KeepGridsOnlyExistingPropBagsInDictionaryTest2()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            designerReader.Grids["TDBGrid"].PropertyBagAlreadyExists = true;
            designerReader.Grids["TDBGrid"].IncorrectPropertiesInDesigner = true;
            int expectedResult = 0;
            // Act
            designerReader.KeepGridsOnlyExistingPropBagsInDictionary();
            int actualResult = designerReader.Grids.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void KeepGridsWithIncorrectDesignerPropsAndPropBagInDictionaryTest1()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            designerReader.Grids["TDBGrid"].PropertyBagAlreadyExists = true;
            designerReader.Grids["TDBGrid"].IncorrectPropertiesInDesigner = true;
            int expectedResult = 1;
            // Act
            designerReader.KeepGridsWithIncorrectDesignerPropsAndPropBagInDictionary();
            int actualResult = designerReader.Grids.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void KeepGridsWithIncorrectDesignerPropsAndPropBagInDictionaryTest2()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.Grids.Add("TDBGrid", new C1TrueDBGrid());
            designerReader.Grids["TDBGrid"].PropertyBagAlreadyExists = false;
            designerReader.Grids["TDBGrid"].IncorrectPropertiesInDesigner = true;
            int expectedResult = 0;
            // Act
            designerReader.KeepGridsWithIncorrectDesignerPropsAndPropBagInDictionary();
            int actualResult = designerReader.Grids.Count;
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckExistsGridToProcess()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            bool actualResult = false;
            // Act
            try
            {
                designerReader.CheckExistsGridToProcess();
            } catch(Exceptions.MissingGridsException ex)
            {
                actualResult = true;
            }
            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void PropBagLinesIdxTest()
        {
            // Arrange
            DesignerReader designerReader = new DesignerReader();
            designerReader.OutputDesignerLines.Add("private void InitializeComponent()");
            designerReader.OutputDesignerLines.Add("    this.SuspendLayout();");
            designerReader.OutputDesignerLines.Add("    this.TDBGrid.Name = \"TDBGrid\";");
            int expectedResult = 2;
            //Act
            int actualResult = designerReader.PropBagLinesIdx();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

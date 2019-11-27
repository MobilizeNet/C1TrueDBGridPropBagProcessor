using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1TrueDBGridPropBagGenerator;
using System.IO;

namespace C1TrueDBGridPropBagGeneratorTest
{
    [TestClass]
    public class ProjectReaderTest
    {
        [TestMethod]
        public void DesignersFoundTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.DesignersFound = 2;
            int expectedResult = 2;
            //Act
            int actualResult = projectReader.DesignersFound;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DesignersFoundTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.DesignersFound;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DesignersProcessedTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.DesignersProcessed = 2;
            int expectedResult = 2;
            //Act
            int actualResult = projectReader.DesignersProcessed;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DesignersProcessedTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.DesignersProcessed;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DesignersWithGridsTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.DesignersWithGrids = 4;
            int expectedResult = 4;
            //Act
            int actualResult = projectReader.DesignersWithGrids;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DesignersWithGridsTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.DesignersWithGrids;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.TotalGrids = 6;
            int expectedResult = 6;
            //Act
            int actualResult = projectReader.TotalGrids;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TotalGridsTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.TotalGrids;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropBagTagsInsertedInsertedTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.PropBagTagsInserted = 7;
            int expectedResult = 7;
            //Act
            int actualResult = projectReader.PropBagTagsInserted;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PropBagTagsInsertedTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.PropBagTagsInserted;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ElapsedTimeTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.ElapsedTime = 120;
            long expectedResult = 120;
            //Act
            long actualResult = projectReader.ElapsedTime;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GridsIncorrectPropsInDesignerTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.GridsIncorrectPropsInDesigner = 7;
            int expectedResult = 7;
            //Act
            int actualResult = projectReader.GridsIncorrectPropsInDesigner;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GridsIncorrectPropsInDesignerTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.GridsIncorrectPropsInDesigner;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GridsIncorrectPropsInDesignerAndExistingPropBagTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.GridsIncorrectPropsInDesignerAndExistingPropBag = 8;
            int expectedResult = 8;
            //Act
            int actualResult = projectReader.GridsIncorrectPropsInDesignerAndExistingPropBag;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GridsIncorrectPropsInDesignerAndExistingPropBagTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.GridsIncorrectPropsInDesignerAndExistingPropBag;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GridsWithExistingPropBagsTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.GridsWithExistingPropBags = 11;
            int expectedResult = 11;
            //Act
            int actualResult = projectReader.GridsWithExistingPropBags;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GridsWithExistingPropBagsTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.GridsWithExistingPropBags;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DesignersWithIncorrectGridPopsTestSetAndGet()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.DesignersWithIncorrectGridPops = 15;
            int expectedResult = 15;
            //Act
            int actualResult = projectReader.DesignersWithIncorrectGridPops;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DesignersWithIncorrectGridPopsTestDefaultValue()
        {
            //Arrange
            ProjectReader projectReader = new ProjectReader();
            int expectedResult = 0;
            //Act
            int actualResult = projectReader.DesignersWithIncorrectGridPops;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WriteLogTest()
        {
            // Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.ElapsedTime = 120;
            projectReader.PropBagTagsInserted = 6;
            projectReader.TotalGrids = 7;
            projectReader.DesignersProcessed = 3;
            projectReader.DesignersFound = 4;
            projectReader.DesignersWithGrids = 2;
            projectReader.GridsIncorrectPropsInDesigner = 8;
            projectReader.GridsIncorrectPropsInDesignerAndExistingPropBag = 9;
            projectReader.GridsWithExistingPropBags = 10;
            projectReader.DesignersWithIncorrectGridPops = 11;
            StringWriter strWr = new StringWriter();
            string expectedResult = "Elapsed time: 120\r\n" +
            "Designer files found: 4\r\n" +
            "Designer files processed: 3\r\n" +
            "Designer with True DB Grids found: 2\r\n" +
            "True DB Grids found: 7\r\n" +
            "Property Bag tags inserted: 6\r\n" +
            "Grids with incorrect properties in the Designer: 8\r\n" +
            "Grids with incorrect properties in the Designer and already had a Property Bag: 9\r\n" +
            "Grids that already had a Property Bag: 10\r\n" +
            "Designer files with incorrect Grid Properties: 11\r\n";
            // Act
            projectReader.WriteLog(strWr);
            string actualResult = strWr.ToString();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WriteDetailedLogTest()
        {
            // Arrange
            ProjectReader projectReader = new ProjectReader();
            projectReader.DesignersWithGridsDictionary["form.designer.cs"] = new DesignerReader();
            projectReader.DesignersWithGridsDictionary["form.designer.cs"].GridsIncorrectPropsInDesigner.Add("Grid1");
            projectReader.DesignersWithGridsDictionary["form.designer.cs"].GridsWithExistingPropBags.Add("Grid2");            StringWriter strWr = new StringWriter();
            string expectedResult = "\r\nInformation about form.designer.cs:\r\n" +
            "Grids with incorrect properties in the designer:\r\n" +
            "- Grid1\r\n" +
            "Grids with existing property bag:\r\n" +
            "- Grid2\r\n";
            // Act
            projectReader.WriteDetailedLog(strWr);
            string actualResult = strWr.ToString();
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

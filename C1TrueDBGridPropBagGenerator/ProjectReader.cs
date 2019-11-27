using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class ProjectReader
    {

        private int designersFound = 0;

        public int DesignersFound
        {
            get { return designersFound; }
            set { designersFound = value; }
        }

        private int designersWithGrids = 0;

        public int DesignersWithGrids
        {
            get { return designersWithGrids; }
            set { designersWithGrids = value; }
        }

        private Dictionary<string, DesignerReader> designersWithGridsDictionary = new Dictionary<string, DesignerReader>();

        public Dictionary<string, DesignerReader> DesignersWithGridsDictionary
        {
            get { return designersWithGridsDictionary; }
            set { designersWithGridsDictionary = value; }
        }

        private int designersProcessed = 0;

        public int DesignersProcessed
        {
            get { return designersProcessed; }
            set { designersProcessed = value; }
        }

        private int totalGrids = 0;
        
        public int TotalGrids
        {
            get { return totalGrids;  }
            set { totalGrids = value; }
        }

        private int propBagTagsInserted = 0;

        public int PropBagTagsInserted
        {
            get { return propBagTagsInserted; }
            set { propBagTagsInserted = value; }
        }

        private long elapsedTime;

        public long ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; }
        }

        private int gridsIncorrectPropsInDesigner = 0;

        public int GridsIncorrectPropsInDesigner
        {
            get { return gridsIncorrectPropsInDesigner; }
            set { gridsIncorrectPropsInDesigner = value; }
        }

        private int gridsIncorrectPropsInDesignerAndExistingPropBag = 0;

        public int GridsIncorrectPropsInDesignerAndExistingPropBag
        {
            get { return gridsIncorrectPropsInDesignerAndExistingPropBag; }
            set { gridsIncorrectPropsInDesignerAndExistingPropBag = value; }
        }

        private int gridsWithExistingPropBags = 0;

        public int GridsWithExistingPropBags
        {
            get { return gridsWithExistingPropBags; }
            set { gridsWithExistingPropBags = value; }
        }

        private int designersWithIncorrectGridPops = 0;

        public int DesignersWithIncorrectGridPops
        {
            get { return designersWithIncorrectGridPops; }
            set { designersWithIncorrectGridPops = value; }
        }

        private bool ignoreGridWithIncorrectDesignerProps = false;

        public bool IgnoreGridWithIncorrectDesignerProps
        {
            get { return ignoreGridWithIncorrectDesignerProps; }
            set { ignoreGridWithIncorrectDesignerProps = value; }
        }

        public List<string> GetDesignerFiles(string folderPath)
        {
            List<string> files = new List<string>();
            GetDesignerFiles(files, folderPath);
            return files;
        }

        private void GetDesignerFiles(List<string> files, string dir)
        {
            try
            {
                files.AddRange(Directory.GetFiles(dir).Where(file => file.ToUpper().EndsWith(".DESIGNER.CS")));
                foreach (string d in Directory.GetDirectories(dir))
                {
                    GetDesignerFiles(files, d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        public void ProcessDesignerFiles(string folderPath)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<string> files = GetDesignerFiles(folderPath);
            DesignersFound = files.Count;
            if(DesignersFound == 0)
            {
                throw new ArgumentException("No files found to process");
            }
            foreach(string file in files)
            {
                DesignerReader dr = new DesignerReader();
                dr.FilePath = file;
                Console.WriteLine($"Processing: {file}");
                try
                {
                    dr.ProcessDesigner();
                    designersProcessed++;
                }
                catch(Exceptions.MissingResxException ex)
                {
                    Console.WriteLine($"{ex.Message}. Ignoring this designer file...");
                }
                catch(Exceptions.MissingGridsException ex)
                {
                    Console.WriteLine(ex.Message);
                    designersProcessed++;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex.GetType()} thrown at line {dr.CurrentLineIndex}: {ex.Message}");
                    if (!ReaderSettings.ForceContinue)
                    {
                        stopwatch.Stop();
                        ElapsedTime = stopwatch.ElapsedMilliseconds;
                        throw ex;
                    }
                }
                finally
                {
                    PropBagTagsInserted += dr.ResxTagsInserted;
                    totalGrids += dr.TotalGrids;
                    gridsIncorrectPropsInDesigner += dr.TotalGridsIncorrectPropsInDesigner;
                    gridsIncorrectPropsInDesignerAndExistingPropBag += dr.TotalGridsIncorrectPropsInDesignerAndExistingPropBag;
                    gridsWithExistingPropBags += dr.TotalGridsWithExistingPropBags;
                    if(dr.TotalGridsIncorrectPropsInDesigner > 0)
                    {
                        DesignersWithIncorrectGridPops++;
                    }
                    if(dr.TotalGrids > 0)
                    {
                        DesignersWithGridsDictionary.Add(file, dr);
                        designersWithGrids++;
                    }
                }
            }
            stopwatch.Stop();
            ElapsedTime = stopwatch.ElapsedMilliseconds;
        }

        public void SaveLog(string folderPath)
        {
            String timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string filePath = folderPath + @"\" + $"C1TrueDBGridPropBagGenerator_{timestamp}.log";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                WriteLog(writer);
                WriteDetailedLog(writer);
            }
        }

        public void WriteLog(TextWriter textWriter)
        {
            textWriter.WriteLine($"Elapsed time: {ElapsedTime}");
            textWriter.WriteLine($"Designer files found: {DesignersFound}");
            textWriter.WriteLine($"Designer files processed: {DesignersProcessed}");
            textWriter.WriteLine($"Designer with True DB Grids found: {DesignersWithGrids}");
            textWriter.WriteLine($"True DB Grids found: {TotalGrids}");
            textWriter.WriteLine($"Property Bag tags inserted: {PropBagTagsInserted}");
            textWriter.WriteLine($"Grids with incorrect properties in the Designer: {gridsIncorrectPropsInDesigner}");
            textWriter.WriteLine($"Grids with incorrect properties in the Designer and already had a Property Bag: {GridsIncorrectPropsInDesignerAndExistingPropBag}");
            textWriter.WriteLine($"Grids that already had a Property Bag: {GridsWithExistingPropBags}");
            textWriter.WriteLine($"Designer files with incorrect Grid Properties: {DesignersWithIncorrectGridPops}");
        }

        public void WriteDetailedLog(TextWriter textWriter)
        {
            foreach(string designer in designersWithGridsDictionary.Keys)
            {
                textWriter.WriteLine();
                textWriter.WriteLine($"Information about {designer}:");
                textWriter.WriteLine("Grids with incorrect properties in the designer:");
                List<string> gridsIncorrectProps = designersWithGridsDictionary[designer].GridsIncorrectPropsInDesigner;
                if(gridsIncorrectProps.Count > 0)
                {
                    foreach (string grid in gridsIncorrectProps)
                    {
                        textWriter.WriteLine($"- {grid}");
                    }
                }
                else
                {
                    textWriter.WriteLine("None");
                }

                textWriter.WriteLine("Grids with existing property bag:");
                List<string> gridsExistingPropsBags = designersWithGridsDictionary[designer].GridsWithExistingPropBags;
                if (gridsExistingPropsBags.Count > 0)
                {
                    foreach (string grid in gridsExistingPropsBags)
                    {
                        textWriter.WriteLine($"- {grid}");
                    }
                }
                else
                {
                    textWriter.WriteLine("None");
                }
            }
        }
    }
}

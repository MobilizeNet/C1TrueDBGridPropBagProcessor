using C1TrueDBGridPropBagGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C1TrueDBGridPropBagGeneratorUI
{
    public partial class PropBagGenerator : Form
    {
        BackgroundWorker worker;
        ControlWriter controlWriter;
        public PropBagGenerator()
        {
            InitializeComponent();
            controlWriter = new ControlWriter(consoleOutput);
            Console.SetOut(controlWriter);
            worker = new BackgroundWorker { WorkerReportsProgress = true };
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFile.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            btnFile.Enabled = false;
            txtFile.Enabled = false;
            groupBoxWhichToProcess.Enabled = false;
            groupBoxPropBagAction.Enabled = false;
            forceContinue.Enabled = false;
            btnGenerate.Enabled = false;
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProjectReader pr = new ProjectReader();
            ReaderSettings.MustParsePropBagsTags = this.radioParsePropBag.Checked;
            ReaderSettings.OverwritePropBagsTags = this.radioOvewritePropBag.Checked;
            ReaderSettings.ForceContinue = this.forceContinue.Checked;
            ReaderSettings.ProcessGridsOnlyIncorrectDesignerProps = this.radioOnlyIncorrectDesignerProps.Checked;
            ReaderSettings.ProcessGridsOnlyExistingPropBag = this.radioOnlyExistingPropBag.Checked;
            ReaderSettings.ProcessGridsWithIncorrectPropsAndPropBag = this.radioGridsWithIncorrectPropsAndPropBag.Checked;
            string folderPath = txtFile.Text;
            try
            {
                pr.ProcessDesignerFiles(folderPath);
                System.Windows.Forms.MessageBox.Show("Project files processed");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + ". Aborting operation");
                pr.DesignersProcessed = pr.DesignersProcessed - 1;
            }
            if (!folderPath.Equals(""))
            {
                pr.SaveLog(folderPath);
            }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnFile.Enabled = true;
            txtFile.Enabled = true;
            groupBoxWhichToProcess.Enabled = true;
            groupBoxPropBagAction.Enabled = RadioActionPropBagEnabled();
            forceContinue.Enabled = true;
            btnGenerate.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            consoleOutput.Clear();
        }

        public bool RadioActionPropBagEnabled()
        {
            return !radioOnlyIncorrectDesignerProps.Checked;
        }

        private void showOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (showOutput.Checked)
            {
                Console.SetOut(controlWriter);
            }
            else
            {
                Console.SetOut(TextWriter.Null);
            }
        }

        private void radioOnlyIncorrectDesignerProps_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPropBagAction.Enabled = RadioActionPropBagEnabled();
        }
    }
}

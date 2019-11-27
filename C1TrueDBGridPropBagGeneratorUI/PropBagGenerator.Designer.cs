namespace C1TrueDBGridPropBagGeneratorUI
{
    partial class PropBagGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.forceContinue = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.showOutput = new System.Windows.Forms.CheckBox();
            this.radioOvewritePropBag = new System.Windows.Forms.RadioButton();
            this.radioParsePropBag = new System.Windows.Forms.RadioButton();
            this.groupBoxPropBagAction = new System.Windows.Forms.GroupBox();
            this.groupBoxWhichToProcess = new System.Windows.Forms.GroupBox();
            this.radioProcessAny = new System.Windows.Forms.RadioButton();
            this.radioOnlyIncorrectDesignerProps = new System.Windows.Forms.RadioButton();
            this.radioOnlyExistingPropBag = new System.Windows.Forms.RadioButton();
            this.radioGridsWithIncorrectPropsAndPropBag = new System.Windows.Forms.RadioButton();
            this.groupBoxPropBagAction.SuspendLayout();
            this.groupBoxWhichToProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFile.Location = new System.Drawing.Point(112, 8);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(450, 20);
            this.txtFile.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(8, 8);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(96, 24);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "Choose Project";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(309, 149);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // consoleOutput
            // 
            this.consoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleOutput.HideSelection = false;
            this.consoleOutput.Location = new System.Drawing.Point(8, 183);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.Size = new System.Drawing.Size(554, 135);
            this.consoleOutput.TabIndex = 5;
            this.consoleOutput.Text = "";
            // 
            // forceContinue
            // 
            this.forceContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forceContinue.AutoSize = true;
            this.forceContinue.Location = new System.Drawing.Point(309, 106);
            this.forceContinue.Name = "forceContinue";
            this.forceContinue.Size = new System.Drawing.Size(173, 17);
            this.forceContinue.TabIndex = 9;
            this.forceContinue.Text = "Force continue if operation fails";
            this.forceContinue.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(416, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Console";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // showOutput
            // 
            this.showOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showOutput.AutoSize = true;
            this.showOutput.Checked = true;
            this.showOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOutput.Location = new System.Drawing.Point(309, 126);
            this.showOutput.Name = "showOutput";
            this.showOutput.Size = new System.Drawing.Size(86, 17);
            this.showOutput.TabIndex = 11;
            this.showOutput.Text = "Show output";
            this.showOutput.UseVisualStyleBackColor = true;
            this.showOutput.CheckedChanged += new System.EventHandler(this.showOutput_CheckedChanged);
            // 
            // radioOvewritePropBag
            // 
            this.radioOvewritePropBag.AutoSize = true;
            this.radioOvewritePropBag.Location = new System.Drawing.Point(6, 39);
            this.radioOvewritePropBag.Name = "radioOvewritePropBag";
            this.radioOvewritePropBag.Size = new System.Drawing.Size(197, 17);
            this.radioOvewritePropBag.TabIndex = 12;
            this.radioOvewritePropBag.Text = "Overwrite Property Bag tag if it exists";
            this.radioOvewritePropBag.UseVisualStyleBackColor = true;
            // 
            // radioParsePropBag
            // 
            this.radioParsePropBag.AutoSize = true;
            this.radioParsePropBag.Checked = true;
            this.radioParsePropBag.Location = new System.Drawing.Point(6, 19);
            this.radioParsePropBag.Name = "radioParsePropBag";
            this.radioParsePropBag.Size = new System.Drawing.Size(235, 17);
            this.radioParsePropBag.TabIndex = 13;
            this.radioParsePropBag.TabStop = true;
            this.radioParsePropBag.Text = "Parse and extend Property Bag tag if it exists";
            this.radioParsePropBag.UseVisualStyleBackColor = true;
            // 
            // groupBoxPropBagAction
            // 
            this.groupBoxPropBagAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPropBagAction.Controls.Add(this.radioParsePropBag);
            this.groupBoxPropBagAction.Controls.Add(this.radioOvewritePropBag);
            this.groupBoxPropBagAction.Location = new System.Drawing.Point(309, 38);
            this.groupBoxPropBagAction.Name = "groupBoxPropBagAction";
            this.groupBoxPropBagAction.Size = new System.Drawing.Size(253, 62);
            this.groupBoxPropBagAction.TabIndex = 15;
            this.groupBoxPropBagAction.TabStop = false;
            this.groupBoxPropBagAction.Text = "What to do with existing property bags?";
            // 
            // groupBoxWhichToProcess
            // 
            this.groupBoxWhichToProcess.Controls.Add(this.radioGridsWithIncorrectPropsAndPropBag);
            this.groupBoxWhichToProcess.Controls.Add(this.radioOnlyExistingPropBag);
            this.groupBoxWhichToProcess.Controls.Add(this.radioOnlyIncorrectDesignerProps);
            this.groupBoxWhichToProcess.Controls.Add(this.radioProcessAny);
            this.groupBoxWhichToProcess.Location = new System.Drawing.Point(8, 38);
            this.groupBoxWhichToProcess.Name = "groupBoxWhichToProcess";
            this.groupBoxWhichToProcess.Size = new System.Drawing.Size(288, 113);
            this.groupBoxWhichToProcess.TabIndex = 16;
            this.groupBoxWhichToProcess.TabStop = false;
            this.groupBoxWhichToProcess.Text = "Which grids are going to be processed?";
            // 
            // radioProcessAny
            // 
            this.radioProcessAny.AutoSize = true;
            this.radioProcessAny.Checked = true;
            this.radioProcessAny.Location = new System.Drawing.Point(7, 19);
            this.radioProcessAny.Name = "radioProcessAny";
            this.radioProcessAny.Size = new System.Drawing.Size(142, 17);
            this.radioProcessAny.TabIndex = 0;
            this.radioProcessAny.TabStop = true;
            this.radioProcessAny.Text = "Process every grid found";
            this.radioProcessAny.UseVisualStyleBackColor = true;
            // 
            // radioOnlyIncorrectDesignerProps
            // 
            this.radioOnlyIncorrectDesignerProps.AutoSize = true;
            this.radioOnlyIncorrectDesignerProps.Location = new System.Drawing.Point(7, 42);
            this.radioOnlyIncorrectDesignerProps.Name = "radioOnlyIncorrectDesignerProps";
            this.radioOnlyIncorrectDesignerProps.Size = new System.Drawing.Size(258, 17);
            this.radioOnlyIncorrectDesignerProps.TabIndex = 1;
            this.radioOnlyIncorrectDesignerProps.Text = "Grids with only incorrect properties in the designer";
            this.radioOnlyIncorrectDesignerProps.UseVisualStyleBackColor = true;
            this.radioOnlyIncorrectDesignerProps.CheckedChanged += new System.EventHandler(this.radioOnlyIncorrectDesignerProps_CheckedChanged);
            // 
            // radioOnlyExistingPropBag
            // 
            this.radioOnlyExistingPropBag.AutoSize = true;
            this.radioOnlyExistingPropBag.Location = new System.Drawing.Point(7, 65);
            this.radioOnlyExistingPropBag.Name = "radioOnlyExistingPropBag";
            this.radioOnlyExistingPropBag.Size = new System.Drawing.Size(208, 17);
            this.radioOnlyExistingPropBag.TabIndex = 2;
            this.radioOnlyExistingPropBag.Text = "Grids with only an existing property bag";
            this.radioOnlyExistingPropBag.UseVisualStyleBackColor = true;
            // 
            // radioGridsWithIncorrectPropsAndPropBag
            // 
            this.radioGridsWithIncorrectPropsAndPropBag.AutoSize = true;
            this.radioGridsWithIncorrectPropsAndPropBag.Location = new System.Drawing.Point(7, 88);
            this.radioGridsWithIncorrectPropsAndPropBag.Name = "radioGridsWithIncorrectPropsAndPropBag";
            this.radioGridsWithIncorrectPropsAndPropBag.Size = new System.Drawing.Size(275, 17);
            this.radioGridsWithIncorrectPropsAndPropBag.TabIndex = 3;
            this.radioGridsWithIncorrectPropsAndPropBag.Text = "Grids with incorrect props. in designer AND prop. bag";
            this.radioGridsWithIncorrectPropsAndPropBag.UseVisualStyleBackColor = true;
            // 
            // PropBagGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 330);
            this.Controls.Add(this.groupBoxWhichToProcess);
            this.Controls.Add(this.groupBoxPropBagAction);
            this.Controls.Add(this.showOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.forceContinue);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtFile);
            this.MinimumSize = new System.Drawing.Size(575, 280);
            this.Name = "PropBagGenerator";
            this.ShowIcon = false;
            this.Text = "PropBagGenerator";
            this.groupBoxPropBagAction.ResumeLayout(false);
            this.groupBoxPropBagAction.PerformLayout();
            this.groupBoxWhichToProcess.ResumeLayout(false);
            this.groupBoxWhichToProcess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox consoleOutput;
        private System.Windows.Forms.CheckBox forceContinue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox showOutput;
        private System.Windows.Forms.RadioButton radioOvewritePropBag;
        private System.Windows.Forms.RadioButton radioParsePropBag;
        private System.Windows.Forms.GroupBox groupBoxPropBagAction;
        private System.Windows.Forms.GroupBox groupBoxWhichToProcess;
        private System.Windows.Forms.RadioButton radioGridsWithIncorrectPropsAndPropBag;
        private System.Windows.Forms.RadioButton radioOnlyExistingPropBag;
        private System.Windows.Forms.RadioButton radioOnlyIncorrectDesignerProps;
        private System.Windows.Forms.RadioButton radioProcessAny;
    }
}


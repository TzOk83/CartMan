namespace CartMan
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSplitGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSplitBrowseFolder = new System.Windows.Forms.Button();
            this.tbSplitOutputFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSplitBrowseFile = new System.Windows.Forms.Button();
            this.tbSplitInputFile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMergeBrowseHigh = new System.Windows.Forms.Button();
            this.tbMergeHighFile = new System.Windows.Forms.TextBox();
            this.btnMergeGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMergeBrowseOutput = new System.Windows.Forms.Button();
            this.tbMergeOutputFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMergeBrowseLow = new System.Windows.Forms.Button();
            this.tbMergeLowFile = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBsGo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBsBrowseFolder = new System.Windows.Forms.Button();
            this.tbBsOutputFolder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBsBrowseFile = new System.Windows.Forms.Button();
            this.tbBsInputFile = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rbS4k = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rbS512k = new System.Windows.Forms.RadioButton();
            this.rbS256k = new System.Windows.Forms.RadioButton();
            this.rbS128k = new System.Windows.Forms.RadioButton();
            this.rbS64k = new System.Windows.Forms.RadioButton();
            this.rbS32k = new System.Windows.Forms.RadioButton();
            this.rbS16k = new System.Windows.Forms.RadioButton();
            this.rbS8k = new System.Windows.Forms.RadioButton();
            this.btnSplitRomGo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSplitRomBrowseFolder = new System.Windows.Forms.Button();
            this.tbSplitRomOutputFolder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSplitRomBrowseFile = new System.Windows.Forms.Button();
            this.tbSplitRomInputFile = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbSourceFiles = new System.Windows.Forms.ListBox();
            this.rbM4k = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rbM512k = new System.Windows.Forms.RadioButton();
            this.rbM256k = new System.Windows.Forms.RadioButton();
            this.rbM128k = new System.Windows.Forms.RadioButton();
            this.rbM64k = new System.Windows.Forms.RadioButton();
            this.rbM32k = new System.Windows.Forms.RadioButton();
            this.rbM16k = new System.Windows.Forms.RadioButton();
            this.rbM8k = new System.Windows.Forms.RadioButton();
            this.btnMergeRGo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnMergeRBrowseOutput = new System.Windows.Forms.Button();
            this.tbMergeROutputFile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMergeRBrowseInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 188);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(414, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbProgress
            // 
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(414, 188);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSplitGo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSplitBrowseFolder);
            this.tabPage1.Controls.Add(this.tbSplitOutputFolder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSplitBrowseFile);
            this.tabPage1.Controls.Add(this.tbSplitInputFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 162);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Split L/H";
            this.tabPage1.ToolTipText = "Split a 16-bit binary image into two 8-bit ones.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSplitGo
            // 
            this.btnSplitGo.Location = new System.Drawing.Point(166, 126);
            this.btnSplitGo.Name = "btnSplitGo";
            this.btnSplitGo.Size = new System.Drawing.Size(75, 23);
            this.btnSplitGo.TabIndex = 6;
            this.btnSplitGo.Text = "&GO!";
            this.btnSplitGo.UseVisualStyleBackColor = true;
            this.btnSplitGo.Click += new System.EventHandler(this.btnSplitGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Folder:";
            // 
            // btnSplitBrowseFolder
            // 
            this.btnSplitBrowseFolder.Location = new System.Drawing.Point(375, 30);
            this.btnSplitBrowseFolder.Name = "btnSplitBrowseFolder";
            this.btnSplitBrowseFolder.Size = new System.Drawing.Size(25, 23);
            this.btnSplitBrowseFolder.TabIndex = 4;
            this.btnSplitBrowseFolder.Text = "...";
            this.btnSplitBrowseFolder.UseVisualStyleBackColor = true;
            this.btnSplitBrowseFolder.Click += new System.EventHandler(this.btnSplitBrowseFolder_Click);
            // 
            // tbSplitOutputFolder
            // 
            this.tbSplitOutputFolder.Location = new System.Drawing.Point(86, 32);
            this.tbSplitOutputFolder.Name = "tbSplitOutputFolder";
            this.tbSplitOutputFolder.Size = new System.Drawing.Size(283, 20);
            this.tbSplitOutputFolder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File:";
            // 
            // btnSplitBrowseFile
            // 
            this.btnSplitBrowseFile.Location = new System.Drawing.Point(375, 4);
            this.btnSplitBrowseFile.Name = "btnSplitBrowseFile";
            this.btnSplitBrowseFile.Size = new System.Drawing.Size(25, 23);
            this.btnSplitBrowseFile.TabIndex = 1;
            this.btnSplitBrowseFile.Text = "...";
            this.btnSplitBrowseFile.UseVisualStyleBackColor = true;
            this.btnSplitBrowseFile.Click += new System.EventHandler(this.btnSplitBrowseFile_Click);
            // 
            // tbSplitInputFile
            // 
            this.tbSplitInputFile.Location = new System.Drawing.Point(65, 6);
            this.tbSplitInputFile.Name = "tbSplitInputFile";
            this.tbSplitInputFile.Size = new System.Drawing.Size(304, 20);
            this.tbSplitInputFile.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnMergeBrowseHigh);
            this.tabPage2.Controls.Add(this.tbMergeHighFile);
            this.tabPage2.Controls.Add(this.btnMergeGo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnMergeBrowseOutput);
            this.tabPage2.Controls.Add(this.tbMergeOutputFolder);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnMergeBrowseLow);
            this.tabPage2.Controls.Add(this.tbMergeLowFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(406, 162);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Merge L/H";
            this.tabPage2.ToolTipText = "Merge a two splited 8-bit images into a single 16-bit image.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "HIGH File:";
            // 
            // btnMergeBrowseHigh
            // 
            this.btnMergeBrowseHigh.Location = new System.Drawing.Point(375, 30);
            this.btnMergeBrowseHigh.Name = "btnMergeBrowseHigh";
            this.btnMergeBrowseHigh.Size = new System.Drawing.Size(25, 23);
            this.btnMergeBrowseHigh.TabIndex = 15;
            this.btnMergeBrowseHigh.Text = "...";
            this.btnMergeBrowseHigh.UseVisualStyleBackColor = true;
            this.btnMergeBrowseHigh.Click += new System.EventHandler(this.btnMergeBrowseHigh_Click);
            // 
            // tbMergeHighFile
            // 
            this.tbMergeHighFile.Location = new System.Drawing.Point(65, 32);
            this.tbMergeHighFile.Name = "tbMergeHighFile";
            this.tbMergeHighFile.Size = new System.Drawing.Size(304, 20);
            this.tbMergeHighFile.TabIndex = 14;
            // 
            // btnMergeGo
            // 
            this.btnMergeGo.Location = new System.Drawing.Point(166, 126);
            this.btnMergeGo.Name = "btnMergeGo";
            this.btnMergeGo.Size = new System.Drawing.Size(75, 23);
            this.btnMergeGo.TabIndex = 13;
            this.btnMergeGo.Text = "&GO!";
            this.btnMergeGo.UseVisualStyleBackColor = true;
            this.btnMergeGo.Click += new System.EventHandler(this.btnMergeGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Output Folder:";
            // 
            // btnMergeBrowseOutput
            // 
            this.btnMergeBrowseOutput.Location = new System.Drawing.Point(375, 56);
            this.btnMergeBrowseOutput.Name = "btnMergeBrowseOutput";
            this.btnMergeBrowseOutput.Size = new System.Drawing.Size(25, 23);
            this.btnMergeBrowseOutput.TabIndex = 11;
            this.btnMergeBrowseOutput.Text = "...";
            this.btnMergeBrowseOutput.UseVisualStyleBackColor = true;
            this.btnMergeBrowseOutput.Click += new System.EventHandler(this.btnMergeBrowseOutput_Click);
            // 
            // tbMergeOutputFolder
            // 
            this.tbMergeOutputFolder.Location = new System.Drawing.Point(86, 58);
            this.tbMergeOutputFolder.Name = "tbMergeOutputFolder";
            this.tbMergeOutputFolder.Size = new System.Drawing.Size(283, 20);
            this.tbMergeOutputFolder.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "LOW File:";
            // 
            // btnMergeBrowseLow
            // 
            this.btnMergeBrowseLow.Location = new System.Drawing.Point(375, 4);
            this.btnMergeBrowseLow.Name = "btnMergeBrowseLow";
            this.btnMergeBrowseLow.Size = new System.Drawing.Size(25, 23);
            this.btnMergeBrowseLow.TabIndex = 8;
            this.btnMergeBrowseLow.Text = "...";
            this.btnMergeBrowseLow.UseVisualStyleBackColor = true;
            this.btnMergeBrowseLow.Click += new System.EventHandler(this.btnMergeBrowseLow_Click);
            // 
            // tbMergeLowFile
            // 
            this.tbMergeLowFile.Location = new System.Drawing.Point(65, 6);
            this.tbMergeLowFile.Name = "tbMergeLowFile";
            this.tbMergeLowFile.Size = new System.Drawing.Size(304, 20);
            this.tbMergeLowFile.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBsGo);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnBsBrowseFolder);
            this.tabPage3.Controls.Add(this.tbBsOutputFolder);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnBsBrowseFile);
            this.tabPage3.Controls.Add(this.tbBsInputFile);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(406, 162);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Byteswap";
            this.tabPage3.ToolTipText = "Byteswap a 16-bit ROM image to change from little- to big-endian (or other way ar" +
    "ound).";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBsGo
            // 
            this.btnBsGo.Location = new System.Drawing.Point(166, 126);
            this.btnBsGo.Name = "btnBsGo";
            this.btnBsGo.Size = new System.Drawing.Size(75, 23);
            this.btnBsGo.TabIndex = 13;
            this.btnBsGo.Text = "&GO!";
            this.btnBsGo.UseVisualStyleBackColor = true;
            this.btnBsGo.Click += new System.EventHandler(this.btnBsGo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Output Folder:";
            // 
            // btnBsBrowseFolder
            // 
            this.btnBsBrowseFolder.Location = new System.Drawing.Point(375, 30);
            this.btnBsBrowseFolder.Name = "btnBsBrowseFolder";
            this.btnBsBrowseFolder.Size = new System.Drawing.Size(25, 23);
            this.btnBsBrowseFolder.TabIndex = 11;
            this.btnBsBrowseFolder.Text = "...";
            this.btnBsBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBsBrowseFolder.Click += new System.EventHandler(this.btnBsBrowseFolder_Click);
            // 
            // tbBsOutputFolder
            // 
            this.tbBsOutputFolder.Location = new System.Drawing.Point(86, 32);
            this.tbBsOutputFolder.Name = "tbBsOutputFolder";
            this.tbBsOutputFolder.Size = new System.Drawing.Size(283, 20);
            this.tbBsOutputFolder.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Input File:";
            // 
            // btnBsBrowseFile
            // 
            this.btnBsBrowseFile.Location = new System.Drawing.Point(375, 4);
            this.btnBsBrowseFile.Name = "btnBsBrowseFile";
            this.btnBsBrowseFile.Size = new System.Drawing.Size(25, 23);
            this.btnBsBrowseFile.TabIndex = 8;
            this.btnBsBrowseFile.Text = "...";
            this.btnBsBrowseFile.UseVisualStyleBackColor = true;
            this.btnBsBrowseFile.Click += new System.EventHandler(this.btnBsBrowseFile_Click);
            // 
            // tbBsInputFile
            // 
            this.tbBsInputFile.Location = new System.Drawing.Point(65, 6);
            this.tbBsInputFile.Name = "tbBsInputFile";
            this.tbBsInputFile.Size = new System.Drawing.Size(304, 20);
            this.tbBsInputFile.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rbS4k);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.rbS512k);
            this.tabPage4.Controls.Add(this.rbS256k);
            this.tabPage4.Controls.Add(this.rbS128k);
            this.tabPage4.Controls.Add(this.rbS64k);
            this.tabPage4.Controls.Add(this.rbS32k);
            this.tabPage4.Controls.Add(this.rbS16k);
            this.tabPage4.Controls.Add(this.rbS8k);
            this.tabPage4.Controls.Add(this.btnSplitRomGo);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btnSplitRomBrowseFolder);
            this.tabPage4.Controls.Add(this.tbSplitRomOutputFolder);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.btnSplitRomBrowseFile);
            this.tabPage4.Controls.Add(this.tbSplitRomInputFile);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(406, 162);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Split ROMs";
            this.tabPage4.ToolTipText = "Split a stacked image (multi-cart) into ROMs.";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rbS4k
            // 
            this.rbS4k.AutoSize = true;
            this.rbS4k.Checked = true;
            this.rbS4k.Location = new System.Drawing.Point(86, 58);
            this.rbS4k.Name = "rbS4k";
            this.rbS4k.Size = new System.Drawing.Size(44, 17);
            this.rbS4k.TabIndex = 22;
            this.rbS4k.TabStop = true;
            this.rbS4k.Text = "4kB";
            this.toolTip1.SetToolTip(this.rbS4k, "27C32");
            this.rbS4k.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "ROM size:";
            // 
            // rbS512k
            // 
            this.rbS512k.AutoSize = true;
            this.rbS512k.Location = new System.Drawing.Point(272, 81);
            this.rbS512k.Name = "rbS512k";
            this.rbS512k.Size = new System.Drawing.Size(56, 17);
            this.rbS512k.TabIndex = 20;
            this.rbS512k.Text = "512kB";
            this.toolTip1.SetToolTip(this.rbS512k, "27C040");
            this.rbS512k.UseVisualStyleBackColor = true;
            // 
            // rbS256k
            // 
            this.rbS256k.AutoSize = true;
            this.rbS256k.Location = new System.Drawing.Point(210, 81);
            this.rbS256k.Name = "rbS256k";
            this.rbS256k.Size = new System.Drawing.Size(56, 17);
            this.rbS256k.TabIndex = 19;
            this.rbS256k.Text = "256kB";
            this.toolTip1.SetToolTip(this.rbS256k, "27C020");
            this.rbS256k.UseVisualStyleBackColor = true;
            // 
            // rbS128k
            // 
            this.rbS128k.AutoSize = true;
            this.rbS128k.Location = new System.Drawing.Point(148, 81);
            this.rbS128k.Name = "rbS128k";
            this.rbS128k.Size = new System.Drawing.Size(56, 17);
            this.rbS128k.TabIndex = 18;
            this.rbS128k.Text = "128kB";
            this.toolTip1.SetToolTip(this.rbS128k, "27C010");
            this.rbS128k.UseVisualStyleBackColor = true;
            // 
            // rbS64k
            // 
            this.rbS64k.AutoSize = true;
            this.rbS64k.Location = new System.Drawing.Point(86, 81);
            this.rbS64k.Name = "rbS64k";
            this.rbS64k.Size = new System.Drawing.Size(50, 17);
            this.rbS64k.TabIndex = 17;
            this.rbS64k.Text = "64kB";
            this.toolTip1.SetToolTip(this.rbS64k, "27C512");
            this.rbS64k.UseVisualStyleBackColor = true;
            // 
            // rbS32k
            // 
            this.rbS32k.AutoSize = true;
            this.rbS32k.Location = new System.Drawing.Point(272, 58);
            this.rbS32k.Name = "rbS32k";
            this.rbS32k.Size = new System.Drawing.Size(50, 17);
            this.rbS32k.TabIndex = 16;
            this.rbS32k.Text = "32kB";
            this.toolTip1.SetToolTip(this.rbS32k, "27C256");
            this.rbS32k.UseVisualStyleBackColor = true;
            // 
            // rbS16k
            // 
            this.rbS16k.AutoSize = true;
            this.rbS16k.Location = new System.Drawing.Point(210, 58);
            this.rbS16k.Name = "rbS16k";
            this.rbS16k.Size = new System.Drawing.Size(50, 17);
            this.rbS16k.TabIndex = 15;
            this.rbS16k.Text = "16kB";
            this.toolTip1.SetToolTip(this.rbS16k, "27C128");
            this.rbS16k.UseVisualStyleBackColor = true;
            // 
            // rbS8k
            // 
            this.rbS8k.AutoSize = true;
            this.rbS8k.Location = new System.Drawing.Point(148, 58);
            this.rbS8k.Name = "rbS8k";
            this.rbS8k.Size = new System.Drawing.Size(44, 17);
            this.rbS8k.TabIndex = 14;
            this.rbS8k.Text = "8kB";
            this.toolTip1.SetToolTip(this.rbS8k, "27C64");
            this.rbS8k.UseVisualStyleBackColor = true;
            // 
            // btnSplitRomGo
            // 
            this.btnSplitRomGo.Location = new System.Drawing.Point(166, 126);
            this.btnSplitRomGo.Name = "btnSplitRomGo";
            this.btnSplitRomGo.Size = new System.Drawing.Size(75, 23);
            this.btnSplitRomGo.TabIndex = 13;
            this.btnSplitRomGo.Text = "&GO!";
            this.btnSplitRomGo.UseVisualStyleBackColor = true;
            this.btnSplitRomGo.Click += new System.EventHandler(this.btnSplitRomGo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Output Folder:";
            // 
            // btnSplitRomBrowseFolder
            // 
            this.btnSplitRomBrowseFolder.Location = new System.Drawing.Point(375, 30);
            this.btnSplitRomBrowseFolder.Name = "btnSplitRomBrowseFolder";
            this.btnSplitRomBrowseFolder.Size = new System.Drawing.Size(25, 23);
            this.btnSplitRomBrowseFolder.TabIndex = 11;
            this.btnSplitRomBrowseFolder.Text = "...";
            this.btnSplitRomBrowseFolder.UseVisualStyleBackColor = true;
            this.btnSplitRomBrowseFolder.Click += new System.EventHandler(this.btnSplitRomBrowseFolder_Click);
            // 
            // tbSplitRomOutputFolder
            // 
            this.tbSplitRomOutputFolder.Location = new System.Drawing.Point(86, 32);
            this.tbSplitRomOutputFolder.Name = "tbSplitRomOutputFolder";
            this.tbSplitRomOutputFolder.Size = new System.Drawing.Size(283, 20);
            this.tbSplitRomOutputFolder.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Input File:";
            // 
            // btnSplitRomBrowseFile
            // 
            this.btnSplitRomBrowseFile.Location = new System.Drawing.Point(375, 4);
            this.btnSplitRomBrowseFile.Name = "btnSplitRomBrowseFile";
            this.btnSplitRomBrowseFile.Size = new System.Drawing.Size(25, 23);
            this.btnSplitRomBrowseFile.TabIndex = 8;
            this.btnSplitRomBrowseFile.Text = "...";
            this.btnSplitRomBrowseFile.UseVisualStyleBackColor = true;
            this.btnSplitRomBrowseFile.Click += new System.EventHandler(this.btnSplitRomBrowseFile_Click);
            // 
            // tbSplitRomInputFile
            // 
            this.tbSplitRomInputFile.Location = new System.Drawing.Point(65, 6);
            this.tbSplitRomInputFile.Name = "tbSplitRomInputFile";
            this.tbSplitRomInputFile.Size = new System.Drawing.Size(304, 20);
            this.tbSplitRomInputFile.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lbSourceFiles);
            this.tabPage5.Controls.Add(this.rbM4k);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.rbM512k);
            this.tabPage5.Controls.Add(this.rbM256k);
            this.tabPage5.Controls.Add(this.rbM128k);
            this.tabPage5.Controls.Add(this.rbM64k);
            this.tabPage5.Controls.Add(this.rbM32k);
            this.tabPage5.Controls.Add(this.rbM16k);
            this.tabPage5.Controls.Add(this.rbM8k);
            this.tabPage5.Controls.Add(this.btnMergeRGo);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.btnMergeRBrowseOutput);
            this.tabPage5.Controls.Add(this.tbMergeROutputFile);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.btnMergeRBrowseInput);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(406, 162);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Merge ROMs";
            this.tabPage5.ToolTipText = "Merge ROMs into a stacked image (multi-cart).";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbSourceFiles
            // 
            this.lbSourceFiles.Location = new System.Drawing.Point(65, 4);
            this.lbSourceFiles.Name = "lbSourceFiles";
            this.lbSourceFiles.ScrollAlwaysVisible = true;
            this.lbSourceFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbSourceFiles.Size = new System.Drawing.Size(303, 30);
            this.lbSourceFiles.TabIndex = 39;
            // 
            // rbM4k
            // 
            this.rbM4k.AutoSize = true;
            this.rbM4k.Checked = true;
            this.rbM4k.Location = new System.Drawing.Point(86, 63);
            this.rbM4k.Name = "rbM4k";
            this.rbM4k.Size = new System.Drawing.Size(44, 17);
            this.rbM4k.TabIndex = 38;
            this.rbM4k.TabStop = true;
            this.rbM4k.Text = "4kB";
            this.toolTip1.SetToolTip(this.rbM4k, "27C32");
            this.rbM4k.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "ROM size:";
            // 
            // rbM512k
            // 
            this.rbM512k.AutoSize = true;
            this.rbM512k.Location = new System.Drawing.Point(272, 86);
            this.rbM512k.Name = "rbM512k";
            this.rbM512k.Size = new System.Drawing.Size(56, 17);
            this.rbM512k.TabIndex = 36;
            this.rbM512k.Text = "512kB";
            this.toolTip1.SetToolTip(this.rbM512k, "27C040");
            this.rbM512k.UseVisualStyleBackColor = true;
            // 
            // rbM256k
            // 
            this.rbM256k.AutoSize = true;
            this.rbM256k.Location = new System.Drawing.Point(210, 86);
            this.rbM256k.Name = "rbM256k";
            this.rbM256k.Size = new System.Drawing.Size(56, 17);
            this.rbM256k.TabIndex = 35;
            this.rbM256k.Text = "256kB";
            this.toolTip1.SetToolTip(this.rbM256k, "27C020");
            this.rbM256k.UseVisualStyleBackColor = true;
            // 
            // rbM128k
            // 
            this.rbM128k.AutoSize = true;
            this.rbM128k.Location = new System.Drawing.Point(148, 86);
            this.rbM128k.Name = "rbM128k";
            this.rbM128k.Size = new System.Drawing.Size(56, 17);
            this.rbM128k.TabIndex = 34;
            this.rbM128k.Text = "128kB";
            this.toolTip1.SetToolTip(this.rbM128k, "27C010");
            this.rbM128k.UseVisualStyleBackColor = true;
            // 
            // rbM64k
            // 
            this.rbM64k.AutoSize = true;
            this.rbM64k.Location = new System.Drawing.Point(86, 86);
            this.rbM64k.Name = "rbM64k";
            this.rbM64k.Size = new System.Drawing.Size(50, 17);
            this.rbM64k.TabIndex = 33;
            this.rbM64k.Text = "64kB";
            this.toolTip1.SetToolTip(this.rbM64k, "27C512");
            this.rbM64k.UseVisualStyleBackColor = true;
            // 
            // rbM32k
            // 
            this.rbM32k.AutoSize = true;
            this.rbM32k.Location = new System.Drawing.Point(272, 63);
            this.rbM32k.Name = "rbM32k";
            this.rbM32k.Size = new System.Drawing.Size(50, 17);
            this.rbM32k.TabIndex = 32;
            this.rbM32k.Text = "32kB";
            this.toolTip1.SetToolTip(this.rbM32k, "27C256");
            this.rbM32k.UseVisualStyleBackColor = true;
            // 
            // rbM16k
            // 
            this.rbM16k.AutoSize = true;
            this.rbM16k.Location = new System.Drawing.Point(210, 63);
            this.rbM16k.Name = "rbM16k";
            this.rbM16k.Size = new System.Drawing.Size(50, 17);
            this.rbM16k.TabIndex = 31;
            this.rbM16k.Text = "16kB";
            this.toolTip1.SetToolTip(this.rbM16k, "27C128");
            this.rbM16k.UseVisualStyleBackColor = true;
            // 
            // rbM8k
            // 
            this.rbM8k.AutoSize = true;
            this.rbM8k.Location = new System.Drawing.Point(148, 63);
            this.rbM8k.Name = "rbM8k";
            this.rbM8k.Size = new System.Drawing.Size(44, 17);
            this.rbM8k.TabIndex = 30;
            this.rbM8k.Text = "8kB";
            this.toolTip1.SetToolTip(this.rbM8k, "27C64");
            this.rbM8k.UseVisualStyleBackColor = true;
            // 
            // btnMergeRGo
            // 
            this.btnMergeRGo.Location = new System.Drawing.Point(166, 126);
            this.btnMergeRGo.Name = "btnMergeRGo";
            this.btnMergeRGo.Size = new System.Drawing.Size(75, 23);
            this.btnMergeRGo.TabIndex = 29;
            this.btnMergeRGo.Text = "&GO!";
            this.btnMergeRGo.UseVisualStyleBackColor = true;
            this.btnMergeRGo.Click += new System.EventHandler(this.btnMergeRGo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Output File:";
            // 
            // btnMergeRBrowseOutput
            // 
            this.btnMergeRBrowseOutput.Location = new System.Drawing.Point(375, 35);
            this.btnMergeRBrowseOutput.Name = "btnMergeRBrowseOutput";
            this.btnMergeRBrowseOutput.Size = new System.Drawing.Size(25, 23);
            this.btnMergeRBrowseOutput.TabIndex = 27;
            this.btnMergeRBrowseOutput.Text = "...";
            this.btnMergeRBrowseOutput.UseVisualStyleBackColor = true;
            this.btnMergeRBrowseOutput.Click += new System.EventHandler(this.btnMergeRBrowseOutput_Click);
            // 
            // tbMergeROutputFile
            // 
            this.tbMergeROutputFile.Location = new System.Drawing.Point(86, 37);
            this.tbMergeROutputFile.Name = "tbMergeROutputFile";
            this.tbMergeROutputFile.Size = new System.Drawing.Size(283, 20);
            this.tbMergeROutputFile.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Input Files:";
            // 
            // btnMergeRBrowseInput
            // 
            this.btnMergeRBrowseInput.Location = new System.Drawing.Point(375, 4);
            this.btnMergeRBrowseInput.Name = "btnMergeRBrowseInput";
            this.btnMergeRBrowseInput.Size = new System.Drawing.Size(25, 23);
            this.btnMergeRBrowseInput.TabIndex = 24;
            this.btnMergeRBrowseInput.Text = "...";
            this.btnMergeRBrowseInput.UseVisualStyleBackColor = true;
            this.btnMergeRBrowseInput.Click += new System.EventHandler(this.btnMergeRBrowseInput_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 210);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARTridge MANager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tbProgress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSplitBrowseFile;
        private System.Windows.Forms.TextBox tbSplitInputFile;
        private System.Windows.Forms.Button btnSplitGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSplitBrowseFolder;
        private System.Windows.Forms.TextBox tbSplitOutputFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMergeBrowseHigh;
        private System.Windows.Forms.TextBox tbMergeHighFile;
        private System.Windows.Forms.Button btnMergeGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMergeBrowseOutput;
        private System.Windows.Forms.TextBox tbMergeOutputFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMergeBrowseLow;
        private System.Windows.Forms.TextBox tbMergeLowFile;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBsGo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBsBrowseFolder;
        private System.Windows.Forms.TextBox tbBsOutputFolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBsBrowseFile;
        private System.Windows.Forms.TextBox tbBsInputFile;
        private System.Windows.Forms.RadioButton rbS4k;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbS512k;
        private System.Windows.Forms.RadioButton rbS256k;
        private System.Windows.Forms.RadioButton rbS128k;
        private System.Windows.Forms.RadioButton rbS64k;
        private System.Windows.Forms.RadioButton rbS32k;
        private System.Windows.Forms.RadioButton rbS16k;
        private System.Windows.Forms.RadioButton rbS8k;
        private System.Windows.Forms.Button btnSplitRomGo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSplitRomBrowseFolder;
        private System.Windows.Forms.TextBox tbSplitRomOutputFolder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSplitRomBrowseFile;
        private System.Windows.Forms.TextBox tbSplitRomInputFile;
        private System.Windows.Forms.ListBox lbSourceFiles;
        private System.Windows.Forms.RadioButton rbM4k;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbM512k;
        private System.Windows.Forms.RadioButton rbM256k;
        private System.Windows.Forms.RadioButton rbM128k;
        private System.Windows.Forms.RadioButton rbM64k;
        private System.Windows.Forms.RadioButton rbM32k;
        private System.Windows.Forms.RadioButton rbM16k;
        private System.Windows.Forms.RadioButton rbM8k;
        private System.Windows.Forms.Button btnMergeRGo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnMergeRBrowseOutput;
        private System.Windows.Forms.TextBox tbMergeROutputFile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMergeRBrowseInput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


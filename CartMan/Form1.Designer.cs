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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBsGo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBsBrowseFolder = new System.Windows.Forms.Button();
            this.tbBsOutputFolder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBsBrowseFile = new System.Windows.Forms.Button();
            this.tbBsInputFile = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.btnSplitGo.Text = "GO!";
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
            this.btnMergeGo.Text = "GO!";
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(406, 162);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Separate ROMs";
            this.tabPage4.ToolTipText = "Separate ROM images from a stacked image (multi-cart).";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(406, 162);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Combine ROMs";
            this.tabPage5.ToolTipText = "Combine multiple ROMs into a stacked image (multi-cart).";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
            // 
            // btnBsGo
            // 
            this.btnBsGo.Location = new System.Drawing.Point(166, 126);
            this.btnBsGo.Name = "btnBsGo";
            this.btnBsGo.Size = new System.Drawing.Size(75, 23);
            this.btnBsGo.TabIndex = 13;
            this.btnBsGo.Text = "GO!";
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
    }
}


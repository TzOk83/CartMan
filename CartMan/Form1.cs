using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSplitBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSplitInputFile.Text = openFileDialog1.FileName;
                tbSplitOutputFolder.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        private void btnSplitBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSplitOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnMergeBrowseLow_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbMergeLowFile.Text = openFileDialog1.FileName;
                tbMergeOutputFolder.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        private void btnMergeBrowseHigh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbMergeHighFile.Text = openFileDialog1.FileName;
                tbMergeOutputFolder.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        private void btnMergeBrowseOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbMergeOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSplitGo_Click(object sender, EventArgs e)
        {
            var writeOk =  true;
            var HiFile = tbSplitOutputFolder.Text + @"\" + Path.GetFileNameWithoutExtension(tbSplitInputFile.Text) + "_H" + Path.GetExtension(tbSplitInputFile.Text);
            var LoFile = tbSplitOutputFolder.Text + @"\" + Path.GetFileNameWithoutExtension(tbSplitInputFile.Text) + "_L" + Path.GetExtension(tbSplitInputFile.Text);
            List<object> arguments = new List<object>();
            arguments.Add(HiFile);
            arguments.Add(LoFile);
            if (File.Exists(LoFile) | File.Exists(HiFile))
            {
                var result = MessageBox.Show("Hi or Lo file already exists in the destination directory. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) writeOk = false;
            }
            if (writeOk)
            {
                // Disable the Start button until 
                // the asynchronous operation is done.
                this.btnSplitGo.Enabled = false;
                // Reset the variable for percentage tracking.
                tbProgress.Value = 0;
                // Start the asynchronous operation.
                bgwSplitLH.RunWorkerAsync(arguments);
            }
        }

        int SplitLH(string HiFile, string LoFile, BackgroundWorker worker, DoWorkEventArgs e)
        {
            using (FileStream inputStream = new FileStream(tbSplitInputFile.Text, FileMode.Open))
            {
                using (FileStream LoStream = new FileStream(LoFile, FileMode.Create))
                {
                    using (FileStream HiStream = new FileStream(HiFile, FileMode.Create))
                    {
                        for (long i = 0; i < (inputStream.Length + 1) / 2; i++)
                        {
                            LoStream.WriteByte((byte)inputStream.ReadByte());
                            HiStream.WriteByte((byte)inputStream.ReadByte());
                            worker.ReportProgress((int)(200 * (i + 1) / inputStream.Length));
                        }
                    }
                }
            }
            return 0;
        }

        private void btnMergeGo_Click(object sender, EventArgs e)
        {
            var writeOk = true;
            var CName = Path.GetFileNameWithoutExtension(tbMergeLowFile.Text).Remove(Path.GetFileNameWithoutExtension(tbMergeLowFile.Text).Zip(Path.GetFileNameWithoutExtension(tbMergeHighFile.Text), (x, y) => x == y).TakeWhile(b => b).Count());
            var OutputFile = tbMergeOutputFolder.Text + @"\" + CName + "MGD" + Path.GetExtension(tbMergeLowFile.Text);
            var LoFile = new FileInfo(tbMergeLowFile.Text);
            var HiFile = new FileInfo(tbMergeHighFile.Text);
            List<object> arguments = new List<object>();
            arguments.Add(OutputFile);
            arguments.Add(LoFile);
            arguments.Add(HiFile);
            if (File.Exists(OutputFile))
            {
                var result = MessageBox.Show("Output file already exists in the destination directory. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.No)
                    writeOk = false;
            }
            if (writeOk)
            {
                if (LoFile.Length == HiFile.Length)
                {
                    // Disable the Start button until 
                    // the asynchronous operation is done.
                    this.btnMergeGo.Enabled = false;
                    // Reset the variable for percentage tracking.
                    tbProgress.Value = 0;
                    // Start the asynchronous operation.
                    bgwMergeLH.RunWorkerAsync(arguments);
                }
                else
                {
                    MessageBox.Show("Low/High file sizes don't match!", "Size Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        int MergeLH(string OutputFile, FileInfo LoFile, FileInfo HiFile, BackgroundWorker worker, DoWorkEventArgs e)
        {
            using (FileStream outStream = new FileStream(OutputFile, FileMode.Create))
            {
                using (FileStream LoStream = new FileStream(LoFile.FullName, FileMode.Open))
                {
                    using (FileStream HiStream = new FileStream(HiFile.FullName, FileMode.Open))
                    {
                        for (long i = 0; i < LoStream.Length; i++)
                        {
                            outStream.WriteByte((byte)LoStream.ReadByte());
                            outStream.WriteByte((byte)HiStream.ReadByte());
                            worker.ReportProgress((int)(100 * (i + 1) / LoStream.Length));
                        }
                    }
                }
            }
            return 0;
        }

        private void btnBsBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbBsInputFile.Text = openFileDialog1.FileName;
                tbBsOutputFolder.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        private void btnBsBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbBsOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBsGo_Click(object sender, EventArgs e)
        {
            var writeOk = true;
            var BsFile = tbBsOutputFolder.Text + @"\" + Path.GetFileNameWithoutExtension(tbBsInputFile.Text) + "_BS" + Path.GetExtension(tbBsInputFile.Text);
            List<object> arguments = new List<object>();
            arguments.Add(BsFile);
            if (File.Exists(BsFile))
            {
                var result = MessageBox.Show("Byteswapped file already exists in the destination directory. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) writeOk = false;
            }
            if (writeOk)
            {
                // Disable the Start button until 
                // the asynchronous operation is done.
                this.btnBsGo.Enabled = false;
                // Reset the variable for percentage tracking.
                tbProgress.Value = 0;
                // Start the asynchronous operation.
                bgwByteswap.RunWorkerAsync(arguments);
            }
        }

        int Byteswap(string BsFile, BackgroundWorker worker, DoWorkEventArgs e)
        {
            byte LoByte, HiByte;
            using (FileStream inputStream = new FileStream(tbBsInputFile.Text, FileMode.Open))
            {
                using (FileStream BsStream = new FileStream(BsFile, FileMode.Create))
                {
                    for (long i = 0; i < (inputStream.Length + 1) / 2; i++)
                    {
                        LoByte = ((byte)inputStream.ReadByte());
                        HiByte = ((byte)inputStream.ReadByte());
                        BsStream.WriteByte(HiByte);
                        BsStream.WriteByte(LoByte);
                        worker.ReportProgress((int)(200 * (i + 1) / inputStream.Length));
                    }
                }
            }
            return 0;
        }

        private void btnSplitRomGo_Click(object sender, EventArgs e)
        {
            var writeOk = true;
            var fileExists = false;
            var inputSize = new FileInfo(tbSplitRomInputFile.Text).Length;
            var chunkSize = rbS4k.Checked ? 4096 : rbS8k.Checked ? 8192 : rbS16k.Checked ? 16384 : rbS32k.Checked ? 32768 : rbS64k.Checked ? 65536 : rbS128k.Checked ? 131072 : rbS256k.Checked ? 262144 : 524288;
            List<object> arguments = new List<object>();
            arguments.Add(chunkSize);
            var romCount = (Int32)(inputSize / chunkSize);
            arguments.Add(romCount);
            List<string> SepFile = new List<string>();
            for (Int32 chunk = 0; chunk < romCount; chunk++)
            {
                SepFile.Add(tbSplitRomOutputFolder.Text + @"\" + Path.GetFileNameWithoutExtension(tbSplitRomInputFile.Text) + "_ROM" + chunk.ToString() + Path.GetExtension(tbSplitRomInputFile.Text));
            }
            arguments.Add(SepFile);
            foreach (string chunkPath in SepFile)
            {
                if (File.Exists(chunkPath))
                {
                    fileExists = true;
                }
            }
            if (fileExists)
            {
                var result = MessageBox.Show("File already exists in the destination directory. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) writeOk = false;
            }
            if (writeOk)
            {
                // Disable the Start button until 
                // the asynchronous operation is done.
                this.btnSplitRomGo.Enabled = false;
                // Reset the variable for percentage tracking.
                tbProgress.Value = 0;
                // Start the asynchronous operation.
                bgwSplitR.RunWorkerAsync(arguments);
            }
        }

        int SplitR(int chunkSize, int romCount, List<string> SepFile, BackgroundWorker worker, DoWorkEventArgs e)
        {
            using (FileStream inputStream = new FileStream(tbSplitRomInputFile.Text, FileMode.Open))
            {
                for (Int32 chunk = 0; chunk < romCount; chunk++)
                {
                    using (FileStream chunkStream = new FileStream(SepFile[chunk], FileMode.Create))
                    {
                        for (Int32 i = 0; i < chunkSize; i++)
                        {
                            chunkStream.WriteByte((byte)inputStream.ReadByte());
                            worker.ReportProgress((int)(100 * (chunk * chunkSize + i + 1) / inputStream.Length));
                        }
                    }
                }
            }
            return 0;
        }

        private void btnSplitRomBrowseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSplitRomInputFile.Text = openFileDialog1.FileName;
                tbSplitRomOutputFolder.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        private void btnSplitRomBrowseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbSplitRomOutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnMergeRBrowseInput_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                saveFileDialog1.InitialDirectory = Path.GetDirectoryName(openFileDialog1.FileName);
                foreach (String file in openFileDialog1.FileNames)
                {
                    lbSourceFiles.Items.Add(file);
                }
            }
        }

        private void btnMergeRBrowseOutput_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbMergeROutputFile.Text = saveFileDialog1.FileName;
            }
        }

        private void btnMergeRGo_Click(object sender, EventArgs e)
        {
            var writeOk = true;
            var chunkSize = rbM4k.Checked ? 4096 : rbM8k.Checked ? 8192 : rbM16k.Checked ? 16384 : rbM32k.Checked ? 32768 : rbM64k.Checked ? 65536 : rbM128k.Checked ? 131072 : rbM256k.Checked ? 262144 : 524288;
            List<object> arguments = new List<object>();
            arguments.Add(chunkSize);
            //if (File.Exists(tbMergeROutputFile.Text))
            //{
            //    var result = MessageBox.Show("Merged ROM file already exists in the destination directory. Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (result == DialogResult.No) writeOk = false;
            //}
            if (writeOk)
            {
                // Disable the Start button until 
                // the asynchronous operation is done.
                this.btnMergeRGo.Enabled = false;
                // Reset the variable for percentage tracking.
                tbProgress.Value = 0;
                // Start the asynchronous operation.
                bgwMergeR.RunWorkerAsync(arguments);
            }
        }

        int MergeR(int chunkSize, BackgroundWorker worker, DoWorkEventArgs e)
        {
            using (FileStream mergedStream = new FileStream(tbMergeROutputFile.Text, FileMode.Create))
            {
                for (Int32 file = 0; file < lbSourceFiles.Items.Count; file++)
                //foreach (string inputFile in lbSourceFiles.Items)
                {
                    using (FileStream inputStream = new FileStream((string)lbSourceFiles.Items[file], FileMode.Open))
                    {
                        for (Int32 i = 0; i < chunkSize; i++)
                        {
                            mergedStream.WriteByte((byte)inputStream.ReadByte());
                            worker.ReportProgress((int)(100 * (file * chunkSize + i + 1) / (lbSourceFiles.Items.Count * chunkSize)));
                        }
                    }
                }
            }
            return 0;
        }

        private void bgwSplitLH_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            List<object> arglist = e.Argument as List<object>;
            var HiFile = (string)arglist[0];
            var LoFile = (string)arglist[1];
            e.Result = SplitLH(HiFile, LoFile, worker, e);
        }

        private void bgwSplitLH_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.tbProgress.Value = e.ProgressPercentage;
        }

        private void bgwSplitLH_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                MessageBox.Show("File splited successfully!", "Job Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Enable the Start button.
            this.btnSplitGo.Enabled = true;
        }

        private void bgwMergeLH_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            List<object> arglist = e.Argument as List<object>;
            var OutputFile = (string)arglist[0];
            var LoFile = (FileInfo)arglist[1];
            var HiFile = (FileInfo)arglist[2];
            MergeLH(OutputFile, LoFile, HiFile, worker, e);
        }

        private void bgwMergeLH_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.tbProgress.Value = e.ProgressPercentage;
        }

        private void bgwMergeLH_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.

            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                MessageBox.Show("Low/High files merged successfully!", "Job Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Enable the Start button.
            this.btnMergeGo.Enabled = true;
        }

        private void bgwByteswap_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            List<object> arglist = e.Argument as List<object>;
            var BsFile = (string)arglist[0];
            Byteswap(BsFile, worker, e);
        }

        private void bgwByteswap_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.tbProgress.Value = e.ProgressPercentage;
        }

        private void bgwByteswap_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.

            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                MessageBox.Show("Byteswap done successfully!", "Job Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Enable the Start button.
            this.btnBsGo.Enabled = true;
        }

        private void bgwSplitR_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            List<object> arglist = e.Argument as List<object>;
            int chunkSize = (int)arglist[0];
            int romCount = (int)arglist[1];
            List<string> SepFile = (List<string>)arglist[2];
            SplitR(chunkSize, romCount, SepFile, worker, e);
        }

        private void bgwSplitR_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.tbProgress.Value = e.ProgressPercentage;
        }

        private void bgwSplitR_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.

            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                MessageBox.Show("File splited successfully!", "Job Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Enable the Start button.
            this.btnSplitRomGo.Enabled = true;
        }

        private void bgwMergeR_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            List<object> arglist = e.Argument as List<object>;
            var chunkSize = (int)arglist[0];
            MergeR(chunkSize, worker, e);
        }

        private void bgwMergeR_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.tbProgress.Value = e.ProgressPercentage;
        }

        private void bgwMergeR_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.

            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                MessageBox.Show("Files merged successfully!", "Job Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Enable the Start button.
            this.btnMergeRGo.Enabled = true;
        }
    }
}

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
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbMergeLowFile.Text = openFileDialog1.FileName;
                tbMergeOutputFolder.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(openFileDialog1.FileName);
            }
        }

        private void btnMergeBrowseHigh_Click(object sender, EventArgs e)
        {
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
            using (FileStream inputStream = new FileStream(tbSplitInputFile.Text, FileMode.Open))
            {
                if (File.Exists(LoFile) | File.Exists(HiFile))
                {
                    var result = MessageBox.Show("File Exists", "Hi or Lo File already exists in the destination directory. Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No) writeOk = false;
                }
                if (writeOk)
                {
                    using (FileStream LoStream = new FileStream(LoFile, FileMode.Create))
                    {
                        using (FileStream HiStream = new FileStream(HiFile, FileMode.Create))
                        {
                            for (long i = 0; i < (inputStream.Length + 1) / 2; i++)
                            {
                                LoStream.WriteByte((byte)inputStream.ReadByte());
                                HiStream.WriteByte((byte)inputStream.ReadByte());
                                tbProgress.Value = (int)(200 * (i + 1) / inputStream.Length);
                            }
                        }
                    }
                }
            }
        }

        private void btnMergeGo_Click(object sender, EventArgs e)
        {
            var writeOk = true;
            var CName = Path.GetFileNameWithoutExtension(tbMergeLowFile.Text).Remove(Path.GetFileNameWithoutExtension(tbMergeLowFile.Text).Zip(Path.GetFileNameWithoutExtension(tbMergeHighFile.Text), (x, y) => x == y).TakeWhile(b => b).Count());
            var OutputFile = tbMergeOutputFolder.Text + @"\" + CName + "MGD" + Path.GetExtension(tbMergeLowFile.Text);
            if (File.Exists(OutputFile))
            {
                var result = MessageBox.Show("File Exists", "Otput file already exists in the destination directory. Overwrite?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.No)
                    writeOk = false;
            }
            if (writeOk)
            {
                var LoFile = new FileInfo(tbMergeLowFile.Text);
                var HiFile = new FileInfo(tbMergeHighFile.Text);
                if (LoFile.Length == HiFile.Length)
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
                                    tbProgress.Value = (int)(100 * (i + 1) / LoStream.Length);
                                }
                            }
                        }
                    }
                    MessageBox.Show("Low/High files merged successfully!", "Job Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbProgress.Value = 0;
                }
                else
                {
                    MessageBox.Show("Low/High file sizes don't match!", "Size Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBsBrowseFile_Click(object sender, EventArgs e)
        {
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
            var BsFile = tbBsOutputFolder.Text + @"\" + Path.GetFileNameWithoutExtension(tbBsInputFile.Text) + "_BS" + Path.GetExtension(tbBsInputFile.Text);
            byte LoByte, HiByte;
            using (FileStream inputStream = new FileStream(tbBsInputFile.Text, FileMode.Open))
            {
                using (FileStream BsStream = new FileStream(BsFile, FileMode.Create))
                {
                    for (long i = 0; i < (inputStream.Length + 1) / 2; i++)
                    {
                        LoByte=((byte)inputStream.ReadByte());
                        HiByte=((byte)inputStream.ReadByte());
                        BsStream.WriteByte(HiByte);
                        BsStream.WriteByte(LoByte);
                        tbProgress.Value = (int)(200 * (i + 1) / inputStream.Length);
                    }
                }
            }
        }
    }
}

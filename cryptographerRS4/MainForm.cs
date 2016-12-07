using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace cryptographerRS4
{
    public partial class MainForm : Form
    {
        private BitArray binaryArray;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileInputDialog.ShowDialog() == DialogResult.OK)
            {
                InputFileAdressBox.Text = openFileInputDialog.FileName;
            }
        }

        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            saveFileOutputDialog.DefaultExt = "txt";
            if (saveFileOutputDialog.ShowDialog() == DialogResult.OK)
            {
                
                OutputFileAdressBox.Text = saveFileOutputDialog.FileName;
            }
        }

        private void startEncryptionButton_Click(object sender, EventArgs e)
        {
            BinaryReader reader = new BinaryReader(File.Open(InputFileAdressBox.Text, FileMode.Open));
            BinaryWriter writer = new BinaryWriter(File.Open(OutputFileAdressBox.Text, FileMode.Create));

            for (int i = 0; i < reader.BaseStream.Length; i++)
            {
                byte buffer =reader.ReadByte();
                buffer = Convert.ToByte(buffer ^ 0xA);
                writer.Write(buffer);
            }
            reader.BaseStream.Close();
            writer.BaseStream.Close();
        }
    }
}

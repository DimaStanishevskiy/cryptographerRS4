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

        private void startEncryptionButton_Click(object sender, EventArgs e)
        {
            BinaryReader reader;
            try
            {
                reader = new BinaryReader(File.Open(InputFileAdressBox.Text, FileMode.Open));
            }
            catch
            {
                MessageBox.Show("Failed to open the file");
                return;
            }
            string oldExtension = Path.GetExtension(InputFileAdressBox.Text);
            string extension = "";
            bool flag = oldExtension == ".ef";
            if (flag)
            {
                extension = "";

                char buffer = reader.ReadChar();
                while(buffer != '.')
                    buffer = reader.ReadChar();
                while (buffer != '|')
                {
                    extension += buffer;
                    buffer = reader.ReadChar();
                }
            }
            else extension = ".ef";

            string outputFileAdress = InputFileAdressBox.Text;
            outputFileAdress = Path.ChangeExtension(InputFileAdressBox.Text, extension);

            BinaryWriter writer = new BinaryWriter(File.Open(outputFileAdress, FileMode.Create));

            if (!flag)
            {
                writer.Write(oldExtension);
                writer.Write('|');
            }
            for (long i = reader.BaseStream.Position; i < reader.BaseStream.Length; i++)
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

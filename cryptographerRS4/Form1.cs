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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileInput.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileAdress.Text = openFileInput.FileName;
                BitArray binaryArray = new BitArray(File.ReadAllBytes(openFileInput.FileName));

                /*
                byte FileContent = "";
                BinaryReader sr = new BinaryReader(File.Open(openFileInput.FileName,FileMode.Open));
                byte buffer = "";
                while ((buffer = sr.ReadByte()) != -1)
                    FileContent += sr.ReadByte();
                sr.Close();
                }
                */
            }
        }
    }
}

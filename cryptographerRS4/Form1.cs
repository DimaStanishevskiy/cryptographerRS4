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

                string FileContent = "";
                BinaryReader sr = new BinaryReader(File.Open(openFileInput.FileName,FileMode.Open));

                while (sr.PeekChar() > -1)
                    FileContent += sr.Read();

                FileContentBox.Text = FileContent;

                sr.Close();
            }
        }
    }
}

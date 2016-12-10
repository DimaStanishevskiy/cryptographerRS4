using System;
using System.Windows.Forms;
using System.IO;

namespace cryptographerRS4
{

    public partial class MainForm : Form
    {
        //глобальный масив для хранения таблицы перестановок
        byte[] transpositionTable = new byte[256];
       
        public MainForm()
        {
            InitializeComponent();

            //считывание таблицы перестановок
            StreamReader reader = new StreamReader("transpositionTable.bin");
            for (int i = 0; i < 256; i++)
                transpositionTable[i] = Convert.ToByte(reader.ReadLine());

        }
        
        //обработка нажатия кнопки выбора файла
        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileInputDialog.ShowDialog() == DialogResult.OK)
            {
                InputFileAdressBox.Text = openFileInputDialog.FileName;
            }
        }
        
        //обработка нажатия кнопки шифрования
        private void startEncryptionButton_Click(object sender, EventArgs e)
        {
            //открытие файла, для шифрования, если файл не удалось открыть, выводит сообщение об ошибке
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

            // проверяет длину ключа, если меньше 16 то сообщает об ошибке
            if(KeyBox.Text.Length != 16)
            {
                MessageBox.Show("KeyError");
                return;
            }

            // получает ключ, и модифицирует таблицей перестановок.
            byte[] key = new byte[16];
            for (int i = 0; i < 16; i++)
                key[i] = transpositionTable[Convert.ToByte(KeyBox.Text[i])];

            //проверяет расширение файла, если оно .ef, то получает настоящее расширение в начале файла
            //если другое, то записывает расширение в начало
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

            //задает максимальное и текущее значение для прогресбара
            progressBar.Maximum = Convert.ToInt32(reader.BaseStream.Length);
            progressBar.Value = Convert.ToInt32(reader.BaseStream.Position);

            //процес кодировки
            int j = 0;
            for (long i = reader.BaseStream.Position; i < reader.BaseStream.Length; i++, j++)
            {
                if (j == 16) j = 0;
                progressBar.Value++;
                byte buffer =reader.ReadByte();
                buffer = Convert.ToByte(buffer ^ key[j]);
                writer.Write(buffer);
            }
            //закрытие входного и выходного потока
            reader.BaseStream.Close();
            writer.BaseStream.Close();

            // если поставлен параметр удалить исходный файл, то удаляем)   
            if(DeleteFilecheckBox.Checked)
                File.Delete(InputFileAdressBox.Text);
            progressBar.Value = 0;
        }
    }
}

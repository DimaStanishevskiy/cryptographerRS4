﻿namespace cryptographerRS4
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileInputDialog = new System.Windows.Forms.OpenFileDialog();
            this.InputFileAdressBox = new System.Windows.Forms.TextBox();
            this.buttonSelectInputFile = new System.Windows.Forms.Button();
            this.startEncryptionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.MaskedTextBox();
            this.DeleteFilecheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openFileInputDialog
            // 
            this.openFileInputDialog.FileName = "FileInput";
            // 
            // InputFileAdressBox
            // 
            this.InputFileAdressBox.Location = new System.Drawing.Point(34, 38);
            this.InputFileAdressBox.Name = "InputFileAdressBox";
            this.InputFileAdressBox.Size = new System.Drawing.Size(221, 22);
            this.InputFileAdressBox.TabIndex = 0;
            // 
            // buttonSelectInputFile
            // 
            this.buttonSelectInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectInputFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectInputFile.Image")));
            this.buttonSelectInputFile.Location = new System.Drawing.Point(271, 34);
            this.buttonSelectInputFile.Name = "buttonSelectInputFile";
            this.buttonSelectInputFile.Size = new System.Drawing.Size(48, 31);
            this.buttonSelectInputFile.TabIndex = 1;
            this.buttonSelectInputFile.UseVisualStyleBackColor = true;
            this.buttonSelectInputFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // startEncryptionButton
            // 
            this.startEncryptionButton.Image = ((System.Drawing.Image)(resources.GetObject("startEncryptionButton.Image")));
            this.startEncryptionButton.Location = new System.Drawing.Point(271, 83);
            this.startEncryptionButton.Name = "startEncryptionButton";
            this.startEncryptionButton.Size = new System.Drawing.Size(48, 31);
            this.startEncryptionButton.TabIndex = 4;
            this.startEncryptionButton.UseVisualStyleBackColor = true;
            this.startEncryptionButton.Click += new System.EventHandler(this.startEncryptionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Key";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(34, 87);
            this.KeyBox.Mask = "&&&&&&&&";
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(74, 22);
            this.KeyBox.TabIndex = 9;
            // 
            // DeleteFilecheckBox
            // 
            this.DeleteFilecheckBox.AutoSize = true;
            this.DeleteFilecheckBox.Location = new System.Drawing.Point(127, 87);
            this.DeleteFilecheckBox.Name = "DeleteFilecheckBox";
            this.DeleteFilecheckBox.Size = new System.Drawing.Size(128, 21);
            this.DeleteFilecheckBox.TabIndex = 10;
            this.DeleteFilecheckBox.Text = "Delete input file";
            this.DeleteFilecheckBox.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(34, 132);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(285, 23);
            this.progressBar.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 181);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.DeleteFilecheckBox);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startEncryptionButton);
            this.Controls.Add(this.buttonSelectInputFile);
            this.Controls.Add(this.InputFileAdressBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileInputDialog;
        private System.Windows.Forms.TextBox InputFileAdressBox;
        private System.Windows.Forms.Button buttonSelectInputFile;
        private System.Windows.Forms.Button startEncryptionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox KeyBox;
        private System.Windows.Forms.CheckBox DeleteFilecheckBox;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}


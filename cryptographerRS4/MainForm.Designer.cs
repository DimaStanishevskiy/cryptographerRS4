namespace cryptographerRS4
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
            this.openFileInputDialog = new System.Windows.Forms.OpenFileDialog();
            this.InputFileAdressBox = new System.Windows.Forms.TextBox();
            this.buttonSelectInputFile = new System.Windows.Forms.Button();
            this.OutputFileAdressBox = new System.Windows.Forms.TextBox();
            this.startEncryptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileInputDialog
            // 
            this.openFileInputDialog.FileName = "FileInput";
            // 
            // InputFileAdressBox
            // 
            this.InputFileAdressBox.Location = new System.Drawing.Point(49, 37);
            this.InputFileAdressBox.Name = "InputFileAdressBox";
            this.InputFileAdressBox.Size = new System.Drawing.Size(343, 22);
            this.InputFileAdressBox.TabIndex = 0;
            // 
            // buttonSelectInputFile
            // 
            this.buttonSelectInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectInputFile.Location = new System.Drawing.Point(410, 37);
            this.buttonSelectInputFile.Name = "buttonSelectInputFile";
            this.buttonSelectInputFile.Size = new System.Drawing.Size(51, 22);
            this.buttonSelectInputFile.TabIndex = 1;
            this.buttonSelectInputFile.Text = "...";
            this.buttonSelectInputFile.UseVisualStyleBackColor = true;
            this.buttonSelectInputFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // OutputFileAdressBox
            // 
            this.OutputFileAdressBox.Location = new System.Drawing.Point(49, 76);
            this.OutputFileAdressBox.Name = "OutputFileAdressBox";
            this.OutputFileAdressBox.ReadOnly = true;
            this.OutputFileAdressBox.Size = new System.Drawing.Size(343, 22);
            this.OutputFileAdressBox.TabIndex = 2;
            // 
            // startEncryptionButton
            // 
            this.startEncryptionButton.Location = new System.Drawing.Point(410, 76);
            this.startEncryptionButton.Name = "startEncryptionButton";
            this.startEncryptionButton.Size = new System.Drawing.Size(51, 24);
            this.startEncryptionButton.TabIndex = 4;
            this.startEncryptionButton.Text = "Start";
            this.startEncryptionButton.UseVisualStyleBackColor = true;
            this.startEncryptionButton.Click += new System.EventHandler(this.startEncryptionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 143);
            this.Controls.Add(this.startEncryptionButton);
            this.Controls.Add(this.OutputFileAdressBox);
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
        private System.Windows.Forms.TextBox OutputFileAdressBox;
        private System.Windows.Forms.Button startEncryptionButton;
    }
}


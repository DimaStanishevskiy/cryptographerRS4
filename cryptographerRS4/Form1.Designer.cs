namespace cryptographerRS4
{
    partial class Form1
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
            this.openFileInput = new System.Windows.Forms.OpenFileDialog();
            this.fileAdress = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.FileContentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileInput
            // 
            this.openFileInput.FileName = "FileInput";
            // 
            // fileAdress
            // 
            this.fileAdress.Location = new System.Drawing.Point(49, 37);
            this.fileAdress.Name = "fileAdress";
            this.fileAdress.Size = new System.Drawing.Size(343, 22);
            this.fileAdress.TabIndex = 0;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectFile.Location = new System.Drawing.Point(410, 37);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(51, 22);
            this.buttonSelectFile.TabIndex = 1;
            this.buttonSelectFile.Text = "...";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // FileContentBox
            // 
            this.FileContentBox.Location = new System.Drawing.Point(49, 76);
            this.FileContentBox.Multiline = true;
            this.FileContentBox.Name = "FileContentBox";
            this.FileContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileContentBox.Size = new System.Drawing.Size(412, 404);
            this.FileContentBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 607);
            this.Controls.Add(this.FileContentBox);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.fileAdress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileInput;
        private System.Windows.Forms.TextBox fileAdress;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.TextBox FileContentBox;
    }
}


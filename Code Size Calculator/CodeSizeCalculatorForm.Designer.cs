namespace Code_Size_Calculator
{
    partial class CodeSizeCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UploadFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UploadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileUploadProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.Location = new System.Drawing.Point(12, 12);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(225, 45);
            this.UploadFileButton.TabIndex = 0;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseVisualStyleBackColor = true;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upload Progess:";
            // 
            // UploadFileDialog
            // 
            this.UploadFileDialog.FileName = "UploadFileDialog";
            this.UploadFileDialog.Title = "UploadFileDialog";
            // 
            // FileUploadProgress
            // 
            this.FileUploadProgress.AutoSize = true;
            this.FileUploadProgress.Location = new System.Drawing.Point(104, 69);
            this.FileUploadProgress.Name = "FileUploadProgress";
            this.FileUploadProgress.Size = new System.Drawing.Size(80, 13);
            this.FileUploadProgress.TabIndex = 3;
            this.FileUploadProgress.Text = "Waiting For File";
            // 
            // CodeSizeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 96);
            this.Controls.Add(this.FileUploadProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UploadFileButton);
            this.Name = "CodeSizeCalculatorForm";
            this.Text = "Code Size Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog UploadFileDialog;
        private System.Windows.Forms.Label FileUploadProgress;
    }
}


using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Size_Calculator
{
    public partial class CodeSizeCalculatorForm : Form
    {
        private StreamReader FileUploadStream;

        delegate void SetFileUploadStatusCallback(string status);

        public CodeSizeCalculatorForm()
        {
            InitializeComponent();
        }

        ~CodeSizeCalculatorForm()
        {
            FileUploadStream.Close();
        }

        private void SetFileUploadStatus(string status)
        {
            if (this.FileUploadProgress.InvokeRequired)
            {
                SetFileUploadStatusCallback d = new SetFileUploadStatusCallback(SetFileUploadStatus);
                this.Invoke(d, new object[] { status });
            }
            else
            {
                this.FileUploadProgress.Text = status;
            }
        }

        private async void UploadFileButton_Click(object sender, EventArgs e)
        {
            if (UploadFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileUploadStream = new StreamReader(UploadFileDialog.FileName);
                Task<string> calculateCodeSizeTask = new Task<string>(CalculateCodeSize);
                calculateCodeSizeTask.Start();

                var codeSize = await calculateCodeSizeTask;

                MessageBox.Show(codeSize);
            }
        }

        private string CalculateCodeSize()
        {
            SetFileUploadStatus("Calculating Code Size");
            var fileContents = FileUploadStream.ReadToEnd();
            SetFileUploadStatus("Done");

            return fileContents;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

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

        public CodeSizeCalculatorForm()
        {
            InitializeComponent();
        }

        ~CodeSizeCalculatorForm()
        {
            FileUploadStream.Close();
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
            var fileContents = FileUploadStream.ReadToEnd();

            return fileContents;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

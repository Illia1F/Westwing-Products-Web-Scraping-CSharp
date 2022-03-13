using System.Text;

namespace Westwing_Products_Web_Scraping_CSharp.Controls
{
    public partial class ControlMain : UserControl
    {
        private const string WestwingStartURL = "https://www.westwingnow.de/all-products/?q=";      

        private void btnChooseSourceTxtFilePath_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbSourceTxtFilePath.Text = openFileDialog.FileName;

                btnLoadContent_Click(sender, e);
            }
        }

        private async void btnLoadContent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbSourceTxtFilePath.Text))
                    throw new Exception("Txt File is not defined.");

                openFileDialog.FileName = tbSourceTxtFilePath.Text;

                Stream fileStream = openFileDialog.OpenFile();

                rtbTxtFileContent.Text = await ReadFileStreamAsync(fileStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private async Task<string> ReadFileStreamAsync(Stream fileStream)
        {
            var builder = new StringBuilder();
            using (var reader = new StreamReader(fileStream))
            {
                string? line;

                do
                {
                    line = await reader.ReadLineAsync();

                    if (string.IsNullOrWhiteSpace(line) == false)
                        builder.AppendLine(line.StartsWith("http") ? line : WestwingStartURL + line);
                }
                while (line != null);
            }

            return builder.ToString();
        }

        private void btnChooseFolderPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbDestinationFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        public ControlMain()
        {
            InitializeComponent();
        }
    }
}

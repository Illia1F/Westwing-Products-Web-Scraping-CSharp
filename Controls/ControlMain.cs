using HtmlAgilityPack;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace Westwing_Products_Web_Scraping_CSharp.Controls
{
    public partial class ControlMain : UserControl
    {
        private const string WestwingStartURL = "https://www.westwingnow.de/all-products/?q=";

        private const string ImageStartURL = "https://static.westwingnow.de/image/upload/e_trim/c_pad,w_930,h_1240,pd_218_74_218_74/simple";

        private const string HtmlClass = "ww-uikit_StyledImage_l0c9i4td-sc-1j9v08g btIwTQ";

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

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            StartLoading();

            try
            {
                if (string.IsNullOrWhiteSpace(tbSourceTxtFilePath.Text))
                {
                    throw new Exception("Txt File is not defined.");
                }
                else if (string.IsNullOrWhiteSpace(tbDestinationFolderPath.Text))
                {
                    throw new Exception("Destination Folder is not defined.");
                }
                else if (string.IsNullOrWhiteSpace(rtbTxtFileContent.Text))
                {
                    throw new Exception("Txt File is not loaded.");
                }

                IEnumerable<string> urls = rtbTxtFileContent.Text
                  .Split('\n')
                  .Where(s => string.IsNullOrWhiteSpace(s) == false);

                int ulrId = 0;
                foreach(var url in urls)
                {
                    if(url.StartsWith(WestwingStartURL))
                    {
                        if (await ScrapeAsync(url, ulrId.ToString()))
                        {
                            Log($"Downloaded from URL: { url } ✅");
                        }
                        else
                        {
                            Log($"Smth went wrong: { url } ❌");
                        }
                    }
                    else
                    {
                        OpenBrowser(url);
                    }

                    ulrId++;
                }

                MessageBox.Show("The process was completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                StopLoading();
            }
        }

        private async Task<bool> ScrapeAsync(string url, string name)
        {
            var document = await new HtmlWeb().LoadFromWebAsync(url);

            var imgLink = document.DocumentNode
                .Descendants("img")
                ?.FirstOrDefault(e =>
                {
                    var src = e.GetAttributeValue("src", null);
                    var htmlClass = e.GetAttributeValue("class", null);

                    return (htmlClass == HtmlClass || htmlClass == null)
                        && (String.IsNullOrEmpty(src) == false && src.StartsWith("http"));
                })
                ?.GetAttributeValue("src", null);

            if (imgLink == null || imgLink.Any() == false)
                return false;

            string[] imgExtentions = imgLink
                .Replace("/simple", "\n")
                .Split('\n');

            if (imgLink.Count() < 2)
                return false;

            string imgId = imgExtentions.Last();

            await DownloadImageAsync(ImageStartURL + imgExtentions.Last(), $"img_{name}");

            return true;
        }

        public async Task DownloadImageAsync(string imageUrl, string filename)
        {
            using var webClient = new HttpClient();
            using var imageStream = await webClient.GetStreamAsync(imageUrl);
            using var image = Image.FromStream(imageStream);

            image.Save($"{tbDestinationFolderPath.Text}\\" + filename + ".png", ImageFormat.Png);
        }

        private void btnOpenLinks_Click(object sender, EventArgs e)
        {
            StartLoading();

            try
            {
                if (string.IsNullOrWhiteSpace(tbSourceTxtFilePath.Text))
                    throw new Exception("Txt File is not loaded.");

                IEnumerable<string> urls = rtbTxtFileContent.Text
                    .Split('\n')
                    .Where(s => string.IsNullOrWhiteSpace(s) == false);

                foreach(var url in urls) OpenBrowser(url);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                StopLoading();
            }
        }

        private void OpenBrowser(string url)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}"));
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open", url);
            }

            Log($"Launch Browser With URL: { url }");
        }

        private void StartLoading()
        {
            rtbTxtFileContent.ReadOnly = true;
            btnChooseFolderPath.Enabled = false;
            btnDownload.Enabled = false;
            btnChooseSourceTxtFilePath.Enabled = false;
            btnLoadContent.Enabled = false;
            btnOpenLinks.Enabled = false;
            //splashScreenManager.ShowWaitForm();
        }

        private void StopLoading()
        {
            rtbTxtFileContent.ReadOnly = false;
            btnChooseFolderPath.Enabled = true;
            btnDownload.Enabled = true;
            btnChooseSourceTxtFilePath.Enabled = true;
            btnLoadContent.Enabled = true;
            btnOpenLinks.Enabled = true;
            //splashScreenManager.CloseWaitForm();
        }

        private void Log(string text)
        {
            rtbLog.Text += text + Environment.NewLine;
        }

        public ControlMain()
        {
            InitializeComponent();
        }
    }
}

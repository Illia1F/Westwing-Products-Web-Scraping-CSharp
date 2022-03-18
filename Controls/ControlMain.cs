using HtmlAgilityPack;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace Westwing_Products_Web_Scraping_CSharp.Controls
{
    public partial class ControlMain : UserControl
    {
        private void btnChooseFolderPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                tbDestinationFolderPath.Text = folderBrowserDialog.SelectedPath;
        }

        private async void btnOpenLinks_Click(object sender, EventArgs e)
        {
            StartLoading();

            try
            {
                ThrowExceptionIfFileContentNotLoaded();

                IEnumerable<string> urls = await GetUrlsOutOfContentAsync();
                foreach (var url in urls) OpenBrowser(url);
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

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            StartLoading();

            try
            {
                ThrowExceptionIfFolderPathNotDefined();

                ThrowExceptionIfFileContentNotLoaded();

                IEnumerable<string> urls = await GetUrlsOutOfContentAsync();

                SetUpProgressBar(urls.Count(), 1);

                for (int i = 0; i < urls.Count(); i++)
                {
                    progressBar.PerformStep();

                    string url = urls.ElementAt(i);

                    if (url.StartsWith(Constants.WestwingProductStartURL))
                    {
                        if (await WestwingScrapingAsync(url, i.ToString()))
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false;
                StopLoading();
            }
        }

        private void SetUpProgressBar(int max, int step)
        {
            progressBar.Minimum = progressBar.Value = 0;
            progressBar.Maximum = max;
            progressBar.Step = step;
            progressBar.Visible = true;
        }

        private void btnClearEventLog_Click(object sender, EventArgs e)
        {
            rtbLog.Text = String.Empty;
        }

        private void ThrowExceptionIfFolderPathNotDefined()
        {
            if (string.IsNullOrWhiteSpace(tbDestinationFolderPath.Text))
                throw new Exception("Destination Folder is not defined.");
        }

        private void ThrowExceptionIfFileContentNotLoaded()
        {
            if (string.IsNullOrWhiteSpace(rtbTxtFileContent.Text))
                throw new Exception("Txt File is not loaded.");
        }

        private async Task<IEnumerable<string>> GetUrlsOutOfContentAsync()
        {
            string content = rtbTxtFileContent.Text;

            var urls = new List<string>();
            var correctContentBuilder = new StringBuilder();
            var lineBuilder = new StringBuilder();

            bool buildContent(string line)
            {
                if (string.IsNullOrWhiteSpace(line) == false)
                {
                    string url = line.StartsWith(Constants.HTTP) ? line : Constants.WestwingProductStartURL + line;
                    correctContentBuilder.AppendLine(url);
                    urls.Add(url);
                    return true;
                }

                return false;
            }

            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].Equals('\n'))
                {
                    buildContent(lineBuilder.ToString());

                    lineBuilder.Clear();
                }
                else
                {
                    lineBuilder.Append(content[i]);
                }

                await Task.Yield();
            }

            if(lineBuilder.Length > 0)
                buildContent(lineBuilder.ToString());

            rtbTxtFileContent.Text = correctContentBuilder.ToString();

            correctContentBuilder.Clear();
            lineBuilder.Clear();

            return urls;
        }

        private async Task<bool> WestwingScrapingAsync(string url, string name)
        {
            var document = await new HtmlWeb().LoadFromWebAsync(url);

            var imgLink = document.DocumentNode
                .Descendants("img")
                ?.FirstOrDefault(e =>
                {
                    var src = e.GetAttributeValue("src", null);
                    var htmlClass = e.GetAttributeValue("class", null);

                    return (htmlClass == Constants.WestwingHtmlClass || htmlClass == null)
                        && (String.IsNullOrEmpty(src) == false && src.StartsWith("http"));
                })
                ?.GetAttributeValue("src", null);

            if (imgLink == null || imgLink.Any() == false) return false;

            string[] imgExtentions = imgLink
                .Replace("/simple", "\n")
                .Split('\n');

            if (imgLink.Count() < 2) return false;

            string imgId = imgExtentions.Last();

            await DownloadImageAsync(Constants.WestwingImageStartURL + imgExtentions.Last(), $"img_{name}");

            return true;
        }

        public async Task DownloadImageAsync(string imageUrl, string filename)
        {
            using var webClient = new HttpClient();
            using var imageStream = await webClient.GetStreamAsync(imageUrl);
            using var image = Image.FromStream(imageStream);

            image.Save($"{tbDestinationFolderPath.Text}\\" + filename + ".png", ImageFormat.Png);
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
            btnOpenLinks.Enabled = false;
        }

        private void StopLoading()
        {
            rtbTxtFileContent.ReadOnly = false;
            btnChooseFolderPath.Enabled = true;
            btnDownload.Enabled = true;
            btnOpenLinks.Enabled = true;
        }

        private void Log(string text)
        {
            rtbLog.Text += text + Environment.NewLine;
        }

        public ControlMain()
        {
            InitializeComponent();

            progressBar.Visible = false;
        }
    }
}

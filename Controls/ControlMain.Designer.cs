namespace Westwing_Products_Web_Scraping_CSharp.Controls
{
    partial class ControlMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseFolderPath = new System.Windows.Forms.Button();
            this.tbDestinationFolderPath = new System.Windows.Forms.TextBox();
            this.rtbTxtFileContent = new System.Windows.Forms.RichTextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnOpenLinks = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClearEventLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Folder Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Westwing Product Urls (Separator: Enter)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Event Log";
            // 
            // btnChooseFolderPath
            // 
            this.btnChooseFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFolderPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFolderPath.Location = new System.Drawing.Point(345, 24);
            this.btnChooseFolderPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseFolderPath.Name = "btnChooseFolderPath";
            this.btnChooseFolderPath.Size = new System.Drawing.Size(64, 31);
            this.btnChooseFolderPath.TabIndex = 4;
            this.btnChooseFolderPath.Text = "Choose";
            this.btnChooseFolderPath.UseVisualStyleBackColor = true;
            this.btnChooseFolderPath.Click += new System.EventHandler(this.btnChooseFolderPath_Click);
            // 
            // tbDestinationFolderPath
            // 
            this.tbDestinationFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDestinationFolderPath.Location = new System.Drawing.Point(3, 29);
            this.tbDestinationFolderPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDestinationFolderPath.Name = "tbDestinationFolderPath";
            this.tbDestinationFolderPath.ReadOnly = true;
            this.tbDestinationFolderPath.Size = new System.Drawing.Size(336, 22);
            this.tbDestinationFolderPath.TabIndex = 8;
            // 
            // rtbTxtFileContent
            // 
            this.rtbTxtFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTxtFileContent.Location = new System.Drawing.Point(3, 73);
            this.rtbTxtFileContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbTxtFileContent.Name = "rtbTxtFileContent";
            this.rtbTxtFileContent.Size = new System.Drawing.Size(406, 68);
            this.rtbTxtFileContent.TabIndex = 9;
            this.rtbTxtFileContent.Text = "";
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.SystemColors.Info;
            this.rtbLog.Location = new System.Drawing.Point(7, 189);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(406, 187);
            this.rtbLog.TabIndex = 10;
            this.rtbLog.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.Location = new System.Drawing.Point(327, 146);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(82, 29);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnOpenLinks
            // 
            this.btnOpenLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenLinks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenLinks.Location = new System.Drawing.Point(236, 146);
            this.btnOpenLinks.Name = "btnOpenLinks";
            this.btnOpenLinks.Size = new System.Drawing.Size(85, 29);
            this.btnOpenLinks.TabIndex = 12;
            this.btnOpenLinks.Text = "Open Links";
            this.btnOpenLinks.UseVisualStyleBackColor = true;
            this.btnOpenLinks.Click += new System.EventHandler(this.btnOpenLinks_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(3, 28);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(336, 23);
            this.progressBar.TabIndex = 13;
            // 
            // btnClearEventLog
            // 
            this.btnClearEventLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearEventLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearEventLog.Location = new System.Drawing.Point(334, 381);
            this.btnClearEventLog.Name = "btnClearEventLog";
            this.btnClearEventLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearEventLog.TabIndex = 14;
            this.btnClearEventLog.Text = "Clear Log";
            this.btnClearEventLog.UseVisualStyleBackColor = true;
            this.btnClearEventLog.Click += new System.EventHandler(this.btnClearEventLog_Click);
            // 
            // ControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearEventLog);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnOpenLinks);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.rtbTxtFileContent);
            this.Controls.Add(this.tbDestinationFolderPath);
            this.Controls.Add(this.btnChooseFolderPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(413, 413);
            this.Name = "ControlMain";
            this.Size = new System.Drawing.Size(413, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChooseFolderPath;
        private TextBox tbDestinationFolderPath;
        private RichTextBox rtbTxtFileContent;
        private RichTextBox rtbLog;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private Button btnDownload;
        private Button btnOpenLinks;
        private ProgressBar progressBar;
        private Button btnClearEventLog;
    }
}

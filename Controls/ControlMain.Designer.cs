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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseFolderPath = new System.Windows.Forms.Button();
            this.btnChooseSourceTxtFilePath = new System.Windows.Forms.Button();
            this.btnLoadContent = new System.Windows.Forms.Button();
            this.tbSourceTxtFilePath = new System.Windows.Forms.TextBox();
            this.tbDestinationFolderPath = new System.Windows.Forms.TextBox();
            this.rtbTxtFileContent = new System.Windows.Forms.RichTextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnOpenLinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Txt File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Folder Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Txt Content";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Log";
            // 
            // btnChooseFolderPath
            // 
            this.btnChooseFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseFolderPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFolderPath.Location = new System.Drawing.Point(676, 62);
            this.btnChooseFolderPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseFolderPath.Name = "btnChooseFolderPath";
            this.btnChooseFolderPath.Size = new System.Drawing.Size(64, 30);
            this.btnChooseFolderPath.TabIndex = 4;
            this.btnChooseFolderPath.Text = "Choose";
            this.btnChooseFolderPath.UseVisualStyleBackColor = true;
            this.btnChooseFolderPath.Click += new System.EventHandler(this.btnChooseFolderPath_Click);
            // 
            // btnChooseSourceTxtFilePath
            // 
            this.btnChooseSourceTxtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseSourceTxtFilePath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseSourceTxtFilePath.Location = new System.Drawing.Point(606, 18);
            this.btnChooseSourceTxtFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseSourceTxtFilePath.Name = "btnChooseSourceTxtFilePath";
            this.btnChooseSourceTxtFilePath.Size = new System.Drawing.Size(64, 29);
            this.btnChooseSourceTxtFilePath.TabIndex = 5;
            this.btnChooseSourceTxtFilePath.Text = "Choose";
            this.btnChooseSourceTxtFilePath.UseVisualStyleBackColor = true;
            this.btnChooseSourceTxtFilePath.Click += new System.EventHandler(this.btnChooseSourceTxtFilePath_Click);
            // 
            // btnLoadContent
            // 
            this.btnLoadContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadContent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadContent.Location = new System.Drawing.Point(676, 18);
            this.btnLoadContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadContent.Name = "btnLoadContent";
            this.btnLoadContent.Size = new System.Drawing.Size(64, 29);
            this.btnLoadContent.TabIndex = 6;
            this.btnLoadContent.Text = "Load";
            this.btnLoadContent.UseVisualStyleBackColor = true;
            this.btnLoadContent.Click += new System.EventHandler(this.btnLoadContent_Click);
            // 
            // tbSourceTxtFilePath
            // 
            this.tbSourceTxtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSourceTxtFilePath.Location = new System.Drawing.Point(3, 24);
            this.tbSourceTxtFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSourceTxtFilePath.Name = "tbSourceTxtFilePath";
            this.tbSourceTxtFilePath.ReadOnly = true;
            this.tbSourceTxtFilePath.Size = new System.Drawing.Size(597, 22);
            this.tbSourceTxtFilePath.TabIndex = 7;
            // 
            // tbDestinationFolderPath
            // 
            this.tbDestinationFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDestinationFolderPath.Location = new System.Drawing.Point(3, 69);
            this.tbDestinationFolderPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDestinationFolderPath.Name = "tbDestinationFolderPath";
            this.tbDestinationFolderPath.ReadOnly = true;
            this.tbDestinationFolderPath.Size = new System.Drawing.Size(667, 22);
            this.tbDestinationFolderPath.TabIndex = 8;
            // 
            // rtbTxtFileContent
            // 
            this.rtbTxtFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTxtFileContent.Location = new System.Drawing.Point(3, 112);
            this.rtbTxtFileContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbTxtFileContent.Name = "rtbTxtFileContent";
            this.rtbTxtFileContent.Size = new System.Drawing.Size(737, 168);
            this.rtbTxtFileContent.TabIndex = 9;
            this.rtbTxtFileContent.Text = "";
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.Location = new System.Drawing.Point(3, 335);
            this.rtbLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(737, 187);
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
            this.btnDownload.Location = new System.Drawing.Point(658, 285);
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
            this.btnOpenLinks.Location = new System.Drawing.Point(567, 285);
            this.btnOpenLinks.Name = "btnOpenLinks";
            this.btnOpenLinks.Size = new System.Drawing.Size(85, 29);
            this.btnOpenLinks.TabIndex = 12;
            this.btnOpenLinks.Text = "Open Links";
            this.btnOpenLinks.UseVisualStyleBackColor = true;
            this.btnOpenLinks.Click += new System.EventHandler(this.btnOpenLinks_Click);
            // 
            // ControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpenLinks);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.rtbTxtFileContent);
            this.Controls.Add(this.tbDestinationFolderPath);
            this.Controls.Add(this.tbSourceTxtFilePath);
            this.Controls.Add(this.btnLoadContent);
            this.Controls.Add(this.btnChooseSourceTxtFilePath);
            this.Controls.Add(this.btnChooseFolderPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ControlMain";
            this.Size = new System.Drawing.Size(744, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChooseFolderPath;
        private Button btnChooseSourceTxtFilePath;
        private Button btnLoadContent;
        private TextBox tbSourceTxtFilePath;
        private TextBox tbDestinationFolderPath;
        private RichTextBox rtbTxtFileContent;
        private RichTextBox rtbLog;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog;
        private Button btnDownload;
        private Button btnOpenLinks;
    }
}

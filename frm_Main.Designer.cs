namespace Westwing_Products_Web_Scraping_CSharp
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlMain1 = new Westwing_Products_Web_Scraping_CSharp.Controls.ControlMain();
            this.SuspendLayout();
            // 
            // controlMain1
            // 
            this.controlMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMain1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controlMain1.Location = new System.Drawing.Point(0, 0);
            this.controlMain1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlMain1.MinimumSize = new System.Drawing.Size(413, 413);
            this.controlMain1.Name = "controlMain1";
            this.controlMain1.Size = new System.Drawing.Size(751, 512);
            this.controlMain1.TabIndex = 0;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 512);
            this.Controls.Add(this.controlMain1);
            this.MinimumSize = new System.Drawing.Size(749, 500);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Westwing Products Web Scraping";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ControlMain controlMain1;
    }
}
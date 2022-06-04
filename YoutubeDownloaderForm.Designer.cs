namespace YoutubeDownloader
{
    partial class YoutubeDownloaderForm
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
            this.btnDownloadMp3 = new System.Windows.Forms.Button();
            this.txtBoxYoutubeLink = new System.Windows.Forms.TextBox();
            this.txtboxFilePath = new System.Windows.Forms.TextBox();
            this.btnChangeFilePath = new System.Windows.Forms.Button();
            this.btnDownloadMp4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDownloadMp3
            // 
            this.btnDownloadMp3.Location = new System.Drawing.Point(72, 120);
            this.btnDownloadMp3.Name = "btnDownloadMp3";
            this.btnDownloadMp3.Size = new System.Drawing.Size(114, 23);
            this.btnDownloadMp3.TabIndex = 0;
            this.btnDownloadMp3.Text = "Download Mp3";
            this.btnDownloadMp3.UseVisualStyleBackColor = true;
            this.btnDownloadMp3.Click += new System.EventHandler(this.btnDownloadMp3_Click);
            // 
            // txtBoxYoutubeLink
            // 
            this.txtBoxYoutubeLink.Location = new System.Drawing.Point(50, 48);
            this.txtBoxYoutubeLink.Name = "txtBoxYoutubeLink";
            this.txtBoxYoutubeLink.Size = new System.Drawing.Size(412, 23);
            this.txtBoxYoutubeLink.TabIndex = 1;
            // 
            // txtboxFilePath
            // 
            this.txtboxFilePath.Location = new System.Drawing.Point(669, 26);
            this.txtboxFilePath.Name = "txtboxFilePath";
            this.txtboxFilePath.Size = new System.Drawing.Size(100, 23);
            this.txtboxFilePath.TabIndex = 2;
            this.txtboxFilePath.Text = YoutubeDownloader.Properties.Settings.Default.DownloadPath;
            // 
            // btnChangeFilePath
            // 
            this.btnChangeFilePath.Location = new System.Drawing.Point(660, 62);
            this.btnChangeFilePath.Name = "btnChangeFilePath";
            this.btnChangeFilePath.Size = new System.Drawing.Size(110, 23);
            this.btnChangeFilePath.TabIndex = 3;
            this.btnChangeFilePath.Text = "Change File Path";
            this.btnChangeFilePath.UseVisualStyleBackColor = true;
            this.btnChangeFilePath.Click += new System.EventHandler(this.btnChangeFilePath_Click);
            // 
            // btnDownloadMp4
            // 
            this.btnDownloadMp4.Location = new System.Drawing.Point(282, 120);
            this.btnDownloadMp4.Name = "btnDownloadMp4";
            this.btnDownloadMp4.Size = new System.Drawing.Size(139, 23);
            this.btnDownloadMp4.TabIndex = 4;
            this.btnDownloadMp4.Text = "Download Mp4";
            this.btnDownloadMp4.UseVisualStyleBackColor = true;
            this.btnDownloadMp4.Click += new System.EventHandler(this.btnDownloadMp4_Click);
            // 
            // YoutubeDownlaoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDownloadMp4);
            this.Controls.Add(this.btnChangeFilePath);
            this.Controls.Add(this.txtboxFilePath);
            this.Controls.Add(this.txtBoxYoutubeLink);
            this.Controls.Add(this.btnDownloadMp3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.YoutubeDownloaderInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDownloadMp3;
        private TextBox txtBoxYoutubeLink;
        private TextBox txtboxFilePath;
        private Button btnChangeFilePath;
        private Button btnDownloadMp4;
    }
}
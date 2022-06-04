namespace YoutubeDownloader
{
    partial class FileDetailsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.btnFileDetailsConfirm = new System.Windows.Forms.Button();
            this.txtBoxArtist = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(25, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(29, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(25, 24);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(35, 15);
            this.lblArtist.TabIndex = 2;
            this.lblArtist.Text = "Artist";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(91, 50);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(366, 23);
            this.txtBoxTitle.TabIndex = 4;
            this.txtBoxTitle.TextChanged += new System.EventHandler(this.txtBoxTitle_TextChanged);
            // 
            // btnFileDetailsConfirm
            // 
            this.btnFileDetailsConfirm.Location = new System.Drawing.Point(196, 138);
            this.btnFileDetailsConfirm.Name = "btnFileDetailsConfirm";
            this.btnFileDetailsConfirm.Size = new System.Drawing.Size(83, 23);
            this.btnFileDetailsConfirm.TabIndex = 6;
            this.btnFileDetailsConfirm.Text = "Confirm";
            this.btnFileDetailsConfirm.UseVisualStyleBackColor = true;
            this.btnFileDetailsConfirm.Click += new System.EventHandler(this.btnFileDetailsConfirm_Click);
            // 
            // txtBoxArtist
            // 
            this.txtBoxArtist.Location = new System.Drawing.Point(91, 21);
            this.txtBoxArtist.Name = "txtBoxArtist";
            this.txtBoxArtist.Size = new System.Drawing.Size(366, 23);
            this.txtBoxArtist.TabIndex = 5;
            this.txtBoxArtist.TextChanged += new System.EventHandler(this.txtBoxArtist_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(25, 105);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(60, 15);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File Name";
            // 
            // FileDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 186);
            this.Controls.Add(this.btnFileDetailsConfirm);
            this.Controls.Add(this.txtBoxArtist);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFileName);
            this.Name = "FileDetailsForm";
            this.Text = "FileDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblTitle;
        private Label lblArtist;
        private TextBox txtBoxTitle;
        private Button btnFileDetailsConfirm;
        private TextBox txtBoxArtist;
        private Label lblFileName;
    }
}
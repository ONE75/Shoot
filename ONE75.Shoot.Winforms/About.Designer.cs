namespace ONE75.Shoot.Winforms
{
    partial class About
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
            this.components = new System.ComponentModel.Container();
            this.lblGitHub = new System.Windows.Forms.Label();
            this.llGitHub = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblBlog = new System.Windows.Forms.Label();
            this.lblTwitter = new System.Windows.Forms.Label();
            this.llTwitter = new System.Windows.Forms.LinkLabel();
            this.llBlog = new System.Windows.Forms.LinkLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Location = new System.Drawing.Point(3, 326);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(43, 13);
            this.lblGitHub.TabIndex = 13;
            this.lblGitHub.Text = "GitHub:";
            // 
            // llGitHub
            // 
            this.llGitHub.AutoSize = true;
            this.llGitHub.Location = new System.Drawing.Point(51, 326);
            this.llGitHub.Name = "llGitHub";
            this.llGitHub.Size = new System.Drawing.Size(140, 13);
            this.llGitHub.TabIndex = 12;
            this.llGitHub.TabStop = true;
            this.llGitHub.Text = "https://github.com/ONE75/";
            this.llGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblBlog
            // 
            this.lblBlog.AutoSize = true;
            this.lblBlog.Location = new System.Drawing.Point(3, 271);
            this.lblBlog.Name = "lblBlog";
            this.lblBlog.Size = new System.Drawing.Size(31, 13);
            this.lblBlog.TabIndex = 11;
            this.lblBlog.Text = "Blog:";
            // 
            // lblTwitter
            // 
            this.lblTwitter.AutoSize = true;
            this.lblTwitter.Location = new System.Drawing.Point(3, 296);
            this.lblTwitter.Name = "lblTwitter";
            this.lblTwitter.Size = new System.Drawing.Size(42, 13);
            this.lblTwitter.TabIndex = 10;
            this.lblTwitter.Text = "Twitter:";
            // 
            // llTwitter
            // 
            this.llTwitter.AutoSize = true;
            this.llTwitter.Location = new System.Drawing.Point(51, 296);
            this.llTwitter.Name = "llTwitter";
            this.llTwitter.Size = new System.Drawing.Size(129, 13);
            this.llTwitter.TabIndex = 9;
            this.llTwitter.TabStop = true;
            this.llTwitter.Text = "http://twitter.com/ONE75";
            this.llTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
            // 
            // llBlog
            // 
            this.llBlog.AutoSize = true;
            this.llBlog.Location = new System.Drawing.Point(51, 271);
            this.llBlog.Name = "llBlog";
            this.llBlog.Size = new System.Drawing.Size(106, 13);
            this.llBlog.TabIndex = 8;
            this.llBlog.TabStop = true;
            this.llBlog.Text = "http://blog.one75.be";
            this.llBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ONE75.Shoot.Winforms.Properties.Resources.logo_one75_319x236;
            this.pbLogo.Location = new System.Drawing.Point(3, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(341, 240);
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 359);
            this.Controls.Add(this.lblGitHub);
            this.Controls.Add(this.llGitHub);
            this.Controls.Add(this.lblBlog);
            this.Controls.Add(this.lblTwitter);
            this.Controls.Add(this.llTwitter);
            this.Controls.Add(this.llBlog);
            this.Controls.Add(this.pbLogo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 397);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 397);
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGitHub;
        private System.Windows.Forms.LinkLabel llGitHub;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblBlog;
        private System.Windows.Forms.Label lblTwitter;
        private System.Windows.Forms.LinkLabel llTwitter;
        private System.Windows.Forms.LinkLabel llBlog;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}
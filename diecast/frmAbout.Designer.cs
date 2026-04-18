namespace diecast
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            lblApplication = new Label();
            lblURL = new Label();
            lblVersion = new Label();
            SuspendLayout();
            // 
            // lblApplication
            // 
            lblApplication.AutoSize = true;
            lblApplication.Location = new Point(12, 9);
            lblApplication.Name = "lblApplication";
            lblApplication.Size = new Size(0, 20);
            lblApplication.TabIndex = 0;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(12, 53);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(0, 20);
            lblURL.TabIndex = 1;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(12, 31);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(0, 20);
            lblVersion.TabIndex = 2;
            // 
            // frmAbout
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(212, 80);
            Controls.Add(lblVersion);
            Controls.Add(lblURL);
            Controls.Add(lblApplication);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Dice Roller";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblVersion;
    }
}
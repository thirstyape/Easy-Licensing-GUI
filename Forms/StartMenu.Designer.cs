
namespace Easy_Licensing_GUI.Forms
{
    partial class StartMenu
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
            this.buttonGenerateLicense = new System.Windows.Forms.Button();
            this.buttonCheckLicense = new System.Windows.Forms.Button();
            this.buttonRequestLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGenerateLicense
            // 
            this.buttonGenerateLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGenerateLicense.Location = new System.Drawing.Point(0, 0);
            this.buttonGenerateLicense.Name = "buttonGenerateLicense";
            this.buttonGenerateLicense.Size = new System.Drawing.Size(384, 75);
            this.buttonGenerateLicense.TabIndex = 0;
            this.buttonGenerateLicense.Text = "&Generate License";
            this.buttonGenerateLicense.UseVisualStyleBackColor = true;
            this.buttonGenerateLicense.Click += new System.EventHandler(this.ButtonGenerateLicense_Click);
            // 
            // buttonCheckLicense
            // 
            this.buttonCheckLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheckLicense.Location = new System.Drawing.Point(0, 75);
            this.buttonCheckLicense.Name = "buttonCheckLicense";
            this.buttonCheckLicense.Size = new System.Drawing.Size(384, 75);
            this.buttonCheckLicense.TabIndex = 1;
            this.buttonCheckLicense.Text = "&Check License";
            this.buttonCheckLicense.UseVisualStyleBackColor = true;
            this.buttonCheckLicense.Click += new System.EventHandler(this.ButtonCheckLicense_Click);
            // 
            // buttonRequestLicense
            // 
            this.buttonRequestLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRequestLicense.Location = new System.Drawing.Point(0, 150);
            this.buttonRequestLicense.Name = "buttonRequestLicense";
            this.buttonRequestLicense.Size = new System.Drawing.Size(384, 75);
            this.buttonRequestLicense.TabIndex = 2;
            this.buttonRequestLicense.Text = "&Request License";
            this.buttonRequestLicense.UseVisualStyleBackColor = true;
            this.buttonRequestLicense.Click += new System.EventHandler(this.ButtonRequestLicense_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.buttonRequestLicense);
            this.Controls.Add(this.buttonCheckLicense);
            this.Controls.Add(this.buttonGenerateLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "StartMenu";
            this.Text = "Easy Licensing GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateLicense;
        private System.Windows.Forms.Button buttonCheckLicense;
        private System.Windows.Forms.Button buttonRequestLicense;
    }
}
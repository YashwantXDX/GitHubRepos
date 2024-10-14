namespace GitHubRepos
{
    partial class Form1
    {
        // Required designer variable
        private System.ComponentModel.IContainer components = null;

        // Dispose of any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Method required for Designer support
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.lstRepositories = new System.Windows.Forms.ListBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(100, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 0;

            // btnFetch
            this.btnFetch.Location = new System.Drawing.Point(320, 23);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(100, 23);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Fetch Repositories";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);

            // lstRepositories
            this.lstRepositories.FormattingEnabled = true;
            this.lstRepositories.Location = new System.Drawing.Point(20, 70);
            this.lstRepositories.Name = "lstRepositories";
            this.lstRepositories.Size = new System.Drawing.Size(400, 200);
            this.lstRepositories.TabIndex = 2;

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lstRepositories);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.Text = "GitHub Repository Fetcher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.ListBox lstRepositories;
        private System.Windows.Forms.Label lblUsername;
    }
}

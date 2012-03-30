namespace App_Domain
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.lbUser = new System.Windows.Forms.Label();
			this.lbPass = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.bLogin = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbUser
			// 
			this.lbUser.AutoSize = true;
			this.lbUser.Location = new System.Drawing.Point(12, 15);
			this.lbUser.Name = "lbUser";
			this.lbUser.Size = new System.Drawing.Size(55, 13);
			this.lbUser.TabIndex = 0;
			this.lbUser.Text = "Username";
			// 
			// lbPass
			// 
			this.lbPass.AutoSize = true;
			this.lbPass.Location = new System.Drawing.Point(12, 41);
			this.lbPass.Name = "lbPass";
			this.lbPass.Size = new System.Drawing.Size(53, 13);
			this.lbPass.TabIndex = 1;
			this.lbPass.Text = "Password";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(73, 12);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(199, 20);
			this.txtUser.TabIndex = 2;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(73, 38);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(199, 20);
			this.txtPass.TabIndex = 3;
			// 
			// bLogin
			// 
			this.bLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bLogin.Location = new System.Drawing.Point(176, 74);
			this.bLogin.Name = "bLogin";
			this.bLogin.Size = new System.Drawing.Size(98, 23);
			this.bLogin.TabIndex = 4;
			this.bLogin.Text = "Login";
			this.bLogin.UseVisualStyleBackColor = true;
			this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Forgot Password?";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.AcceptButton = this.bLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(286, 107);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bLogin);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.lbPass);
			this.Controls.Add(this.lbUser);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log in to Fastbooks";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button bLogin;
		private System.Windows.Forms.Button button1;
    }
}
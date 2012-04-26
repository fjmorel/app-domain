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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbUser
			// 
			this.lbUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lbUser.AutoSize = true;
			this.lbUser.Location = new System.Drawing.Point(105, 210);
			this.lbUser.Name = "lbUser";
			this.lbUser.Size = new System.Drawing.Size(55, 13);
			this.lbUser.TabIndex = 0;
			this.lbUser.Text = "Username";
			// 
			// lbPass
			// 
			this.lbPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lbPass.AutoSize = true;
			this.lbPass.Location = new System.Drawing.Point(381, 210);
			this.lbPass.Name = "lbPass";
			this.lbPass.Size = new System.Drawing.Size(53, 13);
			this.lbPass.TabIndex = 1;
			this.lbPass.Text = "Password";
			// 
			// txtUser
			// 
			this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtUser.Location = new System.Drawing.Point(166, 207);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(209, 20);
			this.txtUser.TabIndex = 2;
			// 
			// txtPass
			// 
			this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.txtPass.Location = new System.Drawing.Point(442, 207);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(209, 20);
			this.txtPass.TabIndex = 3;
			// 
			// bLogin
			// 
			this.bLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bLogin.Location = new System.Drawing.Point(423, 237);
			this.bLogin.Name = "bLogin";
			this.bLogin.Size = new System.Drawing.Size(98, 23);
			this.bLogin.TabIndex = 4;
			this.bLogin.Text = "Login";
			this.bLogin.UseVisualStyleBackColor = true;
			this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
			// 
			// btnPrint
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(254, 237);
			this.button1.Name = "btnPrint";
			this.button1.Size = new System.Drawing.Size(139, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Forgot Password?";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(736, 183);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AcceptButton = this.bLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 270);
			this.Controls.Add(this.pictureBox1);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
    }
}
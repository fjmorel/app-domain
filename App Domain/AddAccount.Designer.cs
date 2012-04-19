namespace App_Domain
{
    partial class AddAccount
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lbDescript = new System.Windows.Forms.Label();
			this.lbType = new System.Windows.Forms.Label();
			this.bAdd = new System.Windows.Forms.Button();
			this.bCancel = new System.Windows.Forms.Button();
			this.txtAccountnum = new System.Windows.Forms.TextBox();
			this.lblAccountnum = new System.Windows.Forms.Label();
			this.checkActive = new System.Windows.Forms.CheckBox();
			this.lblInitialBalance = new System.Windows.Forms.Label();
			this.numInitialBalance = new System.Windows.Forms.NumericUpDown();
			this.txtType = new App_Domain.AutoCompleteTextbox();
			((System.ComponentModel.ISupportInitialize)(this.numInitialBalance)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.Location = new System.Drawing.Point(15, 120);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(267, 20);
			this.txtDescription.TabIndex = 3;
			this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddAccount_KeyDown);
			// 
			// lbDescript
			// 
			this.lbDescript.AutoSize = true;
			this.lbDescript.Location = new System.Drawing.Point(15, 105);
			this.lbDescript.Name = "lbDescript";
			this.lbDescript.Size = new System.Drawing.Size(103, 13);
			this.lbDescript.TabIndex = 4;
			this.lbDescript.Text = "Account Description";
			// 
			// lbType
			// 
			this.lbType.AutoSize = true;
			this.lbType.Location = new System.Drawing.Point(15, 15);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(31, 13);
			this.lbType.TabIndex = 6;
			this.lbType.Text = "Type";
			// 
			// bAdd
			// 
			this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bAdd.Location = new System.Drawing.Point(177, 195);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(105, 30);
			this.bAdd.TabIndex = 6;
			this.bAdd.Text = "Add Account";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bCancel
			// 
			this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point(96, 195);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(75, 30);
			this.bCancel.TabIndex = 7;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// txtAccountnum
			// 
			this.txtAccountnum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAccountnum.Location = new System.Drawing.Point(15, 75);
			this.txtAccountnum.Name = "txtAccountnum";
			this.txtAccountnum.Size = new System.Drawing.Size(267, 20);
			this.txtAccountnum.TabIndex = 2;
			this.txtAccountnum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddAccount_KeyDown);
			this.txtAccountnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountnum_KeyPress);
			// 
			// lblAccountnum
			// 
			this.lblAccountnum.AutoSize = true;
			this.lblAccountnum.Location = new System.Drawing.Point(15, 60);
			this.lblAccountnum.Name = "lblAccountnum";
			this.lblAccountnum.Size = new System.Drawing.Size(87, 13);
			this.lblAccountnum.TabIndex = 11;
			this.lblAccountnum.Text = "Account Number";
			// 
			// checkActive
			// 
			this.checkActive.AutoSize = true;
			this.checkActive.Checked = true;
			this.checkActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkActive.Location = new System.Drawing.Point(15, 195);
			this.checkActive.Name = "checkActive";
			this.checkActive.Size = new System.Drawing.Size(56, 17);
			this.checkActive.TabIndex = 5;
			this.checkActive.Text = "Active";
			this.checkActive.UseVisualStyleBackColor = true;
			// 
			// lblInitialBalance
			// 
			this.lblInitialBalance.AutoSize = true;
			this.lblInitialBalance.Location = new System.Drawing.Point(15, 150);
			this.lblInitialBalance.Name = "lblInitialBalance";
			this.lblInitialBalance.Size = new System.Drawing.Size(73, 13);
			this.lblInitialBalance.TabIndex = 12;
			this.lblInitialBalance.Text = "Initial Balance";
			// 
			// numInitialBalance
			// 
			this.numInitialBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numInitialBalance.DecimalPlaces = 2;
			this.numInitialBalance.Location = new System.Drawing.Point(15, 165);
			this.numInitialBalance.Name = "numInitialBalance";
			this.numInitialBalance.Size = new System.Drawing.Size(267, 20);
			this.numInitialBalance.TabIndex = 4;
			this.numInitialBalance.ThousandsSeparator = true;
			// 
			// txtType
			// 
			this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtType.Location = new System.Drawing.Point(15, 30);
			this.txtType.Name = "txtType";
			this.txtType.selectedIndex = -1;
			this.txtType.Size = new System.Drawing.Size(267, 20);
			this.txtType.TabIndex = 1;
			// 
			// AddAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 237);
			this.Controls.Add(this.numInitialBalance);
			this.Controls.Add(this.lblInitialBalance);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.checkActive);
			this.Controls.Add(this.lblAccountnum);
			this.Controls.Add(this.txtAccountnum);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.lbDescript);
			this.Controls.Add(this.txtDescription);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddAccount";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddAccount";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddAccount_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.numInitialBalance)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lbDescript;
		private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox txtAccountnum;
        private System.Windows.Forms.Label lblAccountnum;
		private System.Windows.Forms.CheckBox checkActive;
		private AutoCompleteTextbox txtType;
		private System.Windows.Forms.Label lblInitialBalance;
		private System.Windows.Forms.NumericUpDown numInitialBalance;
    }
}
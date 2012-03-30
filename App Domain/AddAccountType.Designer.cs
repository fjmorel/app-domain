namespace App_Domain
{
    partial class AddAccountType
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountType));
			this.bAdd = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lbName = new System.Windows.Forms.Label();
			this.lbDescription = new System.Windows.Forms.Label();
			this.bCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.optDebit = new System.Windows.Forms.RadioButton();
			this.optCredit = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// bAdd
			// 
			this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bAdd.Location = new System.Drawing.Point(154, 214);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(165, 30);
			this.bAdd.TabIndex = 4;
			this.bAdd.Text = "Add Account Type";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(15, 30);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(304, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(15, 75);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(304, 75);
			this.txtDescription.TabIndex = 2;
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(15, 15);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(105, 13);
			this.lbName.TabIndex = 3;
			this.lbName.Text = "Account Type Name";
			// 
			// lbDescription
			// 
			this.lbDescription.AutoSize = true;
			this.lbDescription.Location = new System.Drawing.Point(15, 60);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(130, 13);
			this.lbDescription.TabIndex = 4;
			this.lbDescription.Text = "Account Type Description";
			// 
			// bCancel
			// 
			this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bCancel.Location = new System.Drawing.Point(64, 214);
			this.bCancel.Name = "bCancel";
			this.bCancel.Size = new System.Drawing.Size(84, 30);
			this.bCancel.TabIndex = 3;
			this.bCancel.Text = "Cancel";
			this.bCancel.UseVisualStyleBackColor = true;
			this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Positive Side";
			// 
			// optDebit
			// 
			this.optDebit.AutoSize = true;
			this.optDebit.Location = new System.Drawing.Point(15, 170);
			this.optDebit.Name = "optDebit";
			this.optDebit.Size = new System.Drawing.Size(50, 17);
			this.optDebit.TabIndex = 6;
			this.optDebit.TabStop = true;
			this.optDebit.Text = "Debit";
			this.optDebit.UseVisualStyleBackColor = true;
			// 
			// optCredit
			// 
			this.optCredit.AutoSize = true;
			this.optCredit.Location = new System.Drawing.Point(75, 170);
			this.optCredit.Name = "optCredit";
			this.optCredit.Size = new System.Drawing.Size(52, 17);
			this.optCredit.TabIndex = 7;
			this.optCredit.TabStop = true;
			this.optCredit.Text = "Credit";
			this.optCredit.UseVisualStyleBackColor = true;
			// 
			// AddAccountType
			// 
			this.AcceptButton = this.bAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bCancel;
			this.ClientSize = new System.Drawing.Size(331, 256);
			this.Controls.Add(this.optCredit);
			this.Controls.Add(this.optDebit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bCancel);
			this.Controls.Add(this.lbDescription);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.bAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddAccountType";
			this.Text = "Add an Account Type";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton optDebit;
		private System.Windows.Forms.RadioButton optCredit;
    }
}
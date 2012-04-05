namespace App_Domain
{
    partial class frmAddJournalEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddJournalEntry));
            this.dgEntries = new System.Windows.Forms.DataGridView();
            this.cbTransType = new System.Windows.Forms.ComboBox();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.bPost = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.dateTransaction = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtAccount = new App_Domain.AutoCompleteTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEntries
            // 
            this.dgEntries.AllowUserToAddRows = false;
            this.dgEntries.AllowUserToResizeColumns = false;
            this.dgEntries.AllowUserToResizeRows = false;
            this.dgEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEntries.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntries.Location = new System.Drawing.Point(12, 85);
            this.dgEntries.Name = "dgEntries";
            this.dgEntries.RowHeadersVisible = false;
            this.dgEntries.Size = new System.Drawing.Size(571, 278);
            this.dgEntries.TabIndex = 5;
            // 
            // cbTransType
            // 
            this.cbTransType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransType.FormattingEnabled = true;
            this.cbTransType.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.cbTransType.Location = new System.Drawing.Point(131, 58);
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(110, 21);
            this.cbTransType.TabIndex = 3;
            // 
            // lblAmmount
            // 
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.Location = new System.Drawing.Point(12, 34);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmmount.TabIndex = 3;
            this.lblAmmount.Text = "Amount";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(12, 9);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "Account";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 61);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(90, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Transaction Type";
            // 
            // bPost
            // 
            this.bPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPost.Enabled = false;
            this.bPost.Location = new System.Drawing.Point(508, 462);
            this.bPost.Name = "bPost";
            this.bPost.Size = new System.Drawing.Size(75, 23);
            this.bPost.TabIndex = 8;
            this.bPost.Text = "Save";
            this.bPost.UseVisualStyleBackColor = true;
            this.bPost.Click += new System.EventHandler(this.bPost_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(427, 462);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(508, 56);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // dateTransaction
            // 
            this.dateTransaction.CustomFormat = "MMMM d, yyyy\' at \'h:mm tt";
            this.dateTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTransaction.Location = new System.Drawing.Point(131, 465);
            this.dateTransaction.Name = "dateTransaction";
            this.dateTransaction.Size = new System.Drawing.Size(266, 20);
            this.dateTransaction.TabIndex = 6;
            this.dateTransaction.ValueChanged += new System.EventHandler(this.dateTransaction_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transaction Time";
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(131, 32);
            this.numAmount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(452, 20);
            this.numAmount.TabIndex = 2;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 386);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(571, 70);
            this.txtNotes.TabIndex = 10;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(12, 370);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 11;
            this.lblNotes.Text = "Notes";
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccount.Location = new System.Drawing.Point(131, 6);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.selectedIndex = -1;
            this.txtAccount.Size = new System.Drawing.Size(452, 20);
            this.txtAccount.TabIndex = 1;
            // 
            // frmAddJournalEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 497);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTransaction);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bPost);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblAmmount);
            this.Controls.Add(this.cbTransType);
            this.Controls.Add(this.dgEntries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddJournalEntry";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Journal Entry";
            ((System.ComponentModel.ISupportInitialize)(this.dgEntries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.DataGridView dgEntries;
        private System.Windows.Forms.ComboBox cbTransType;
        private System.Windows.Forms.Label lblAmmount;
        private System.Windows.Forms.Label lblAccount;
		private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button bPost;
        private System.Windows.Forms.Button bCancel;
		private System.Windows.Forms.Button bAdd;
		private AutoCompleteTextbox txtAccount;
		private System.Windows.Forms.DateTimePicker dateTransaction;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
    }
}
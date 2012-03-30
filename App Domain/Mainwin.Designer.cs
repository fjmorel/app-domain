namespace App_Domain
{
    partial class Mainwin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainwin));
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tpAccounts = new System.Windows.Forms.TabPage();
			this.txtAccountName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.cbxTypes = new System.Windows.Forms.ComboBox();
			this.lblAccountTypes = new System.Windows.Forms.Label();
			this.lblSortBy = new System.Windows.Forms.Label();
			this.cbSortBy = new System.Windows.Forms.ComboBox();
			this.dgChartAccounts = new System.Windows.Forms.DataGridView();
			this.tpAccountInfo = new System.Windows.Forms.TabPage();
			this.gbAccount = new System.Windows.Forms.GroupBox();
			this.lblBalance = new System.Windows.Forms.Label();
			this.dgvAccountLedger = new System.Windows.Forms.DataGridView();
			this.bSave = new System.Windows.Forms.Button();
			this.cbAccountActive = new System.Windows.Forms.CheckBox();
			this.tpAccoutTypes = new System.Windows.Forms.TabPage();
			this.dgAccountTypes = new System.Windows.Forms.DataGridView();
			this.tpJournal = new System.Windows.Forms.TabPage();
			this.dgJournal = new System.Windows.Forms.DataGridView();
			this.tpChanges = new System.Windows.Forms.TabPage();
			this.dgAccountChanges = new System.Windows.Forms.DataGridView();
			this.toolbarMain = new System.Windows.Forms.ToolStrip();
			this.menuAccounts = new System.Windows.Forms.ToolStripDropDownButton();
			this.miAddAccount = new System.Windows.Forms.ToolStripMenuItem();
			this.miAddAccountType = new System.Windows.Forms.ToolStripMenuItem();
			this.menuJournal = new System.Windows.Forms.ToolStripDropDownButton();
			this.addJournalEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabTrialBalance = new System.Windows.Forms.TabPage();
			this.dgTrialBalance = new System.Windows.Forms.DataGridView();
			this.tabMain.SuspendLayout();
			this.tpAccounts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgChartAccounts)).BeginInit();
			this.tpAccountInfo.SuspendLayout();
			this.gbAccount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).BeginInit();
			this.tpAccoutTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgAccountTypes)).BeginInit();
			this.tpJournal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgJournal)).BeginInit();
			this.tpChanges.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgAccountChanges)).BeginInit();
			this.toolbarMain.SuspendLayout();
			this.tabTrialBalance.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgTrialBalance)).BeginInit();
			this.SuspendLayout();
			// 
			// tabMain
			// 
			this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabMain.Controls.Add(this.tpAccounts);
			this.tabMain.Controls.Add(this.tpAccountInfo);
			this.tabMain.Controls.Add(this.tpAccoutTypes);
			this.tabMain.Controls.Add(this.tpJournal);
			this.tabMain.Controls.Add(this.tpChanges);
			this.tabMain.Controls.Add(this.tabTrialBalance);
			this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabMain.ItemSize = new System.Drawing.Size(13, 100);
			this.tabMain.Location = new System.Drawing.Point(0, 28);
			this.tabMain.Multiline = true;
			this.tabMain.Name = "tabMain";
			this.tabMain.Padding = new System.Drawing.Point(0, 0);
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(901, 458);
			this.tabMain.TabIndex = 1;
			this.tabMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMain_DrawItem);
			this.tabMain.SelectedIndexChanged += new System.EventHandler(this.Mainwin_Resize);
			// 
			// tpAccounts
			// 
			this.tpAccounts.Controls.Add(this.txtAccountName);
			this.tpAccounts.Controls.Add(this.lblName);
			this.tpAccounts.Controls.Add(this.cbxTypes);
			this.tpAccounts.Controls.Add(this.lblAccountTypes);
			this.tpAccounts.Controls.Add(this.lblSortBy);
			this.tpAccounts.Controls.Add(this.cbSortBy);
			this.tpAccounts.Controls.Add(this.dgChartAccounts);
			this.tpAccounts.Location = new System.Drawing.Point(104, 4);
			this.tpAccounts.Name = "tpAccounts";
			this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccounts.Size = new System.Drawing.Size(793, 450);
			this.tpAccounts.TabIndex = 0;
			this.tpAccounts.Text = "Accounts";
			this.tpAccounts.UseVisualStyleBackColor = true;
			// 
			// txtAccountName
			// 
			this.txtAccountName.Location = new System.Drawing.Point(92, 6);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.Size = new System.Drawing.Size(145, 20);
			this.txtAccountName.TabIndex = 6;
			this.txtAccountName.TextChanged += new System.EventHandler(this.txtAccountName_TextChanged);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(7, 7);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(78, 13);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "Account Name";
			// 
			// cbxTypes
			// 
			this.cbxTypes.FormattingEnabled = true;
			this.cbxTypes.Items.AddRange(new object[] {
            "All"});
			this.cbxTypes.Location = new System.Drawing.Point(328, 6);
			this.cbxTypes.Name = "cbxTypes";
			this.cbxTypes.Size = new System.Drawing.Size(252, 21);
			this.cbxTypes.TabIndex = 4;
			this.cbxTypes.SelectedIndexChanged += new System.EventHandler(this.cbxTypes_SelectedIndexChanged);
			// 
			// lblAccountTypes
			// 
			this.lblAccountTypes.AutoSize = true;
			this.lblAccountTypes.Location = new System.Drawing.Point(243, 7);
			this.lblAccountTypes.Name = "lblAccountTypes";
			this.lblAccountTypes.Size = new System.Drawing.Size(79, 13);
			this.lblAccountTypes.TabIndex = 3;
			this.lblAccountTypes.Text = "Account Types";
			// 
			// lblSortBy
			// 
			this.lblSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSortBy.AutoSize = true;
			this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSortBy.Location = new System.Drawing.Point(603, 7);
			this.lblSortBy.Name = "lblSortBy";
			this.lblSortBy.Size = new System.Drawing.Size(41, 15);
			this.lblSortBy.TabIndex = 2;
			this.lblSortBy.Text = "Status";
			// 
			// cbSortBy
			// 
			this.cbSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSortBy.FormattingEnabled = true;
			this.cbSortBy.Items.AddRange(new object[] {
            "Active and Inactive",
            "Active Only",
            "Inactive Only"});
			this.cbSortBy.Location = new System.Drawing.Point(650, 6);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(135, 21);
			this.cbSortBy.TabIndex = 1;
			this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
			// 
			// dgChartAccounts
			// 
			this.dgChartAccounts.AllowUserToAddRows = false;
			this.dgChartAccounts.AllowUserToDeleteRows = false;
			this.dgChartAccounts.AllowUserToResizeColumns = false;
			this.dgChartAccounts.AllowUserToResizeRows = false;
			this.dgChartAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgChartAccounts.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgChartAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgChartAccounts.Location = new System.Drawing.Point(3, 33);
			this.dgChartAccounts.MultiSelect = false;
			this.dgChartAccounts.Name = "dgChartAccounts";
			this.dgChartAccounts.ReadOnly = true;
			this.dgChartAccounts.RowHeadersVisible = false;
			this.dgChartAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgChartAccounts.Size = new System.Drawing.Size(787, 414);
			this.dgChartAccounts.TabIndex = 0;
			this.dgChartAccounts.DoubleClick += new System.EventHandler(this.dgChartAccounts_DoubleClick);
			// 
			// tpAccountInfo
			// 
			this.tpAccountInfo.Controls.Add(this.gbAccount);
			this.tpAccountInfo.Location = new System.Drawing.Point(104, 4);
			this.tpAccountInfo.Name = "tpAccountInfo";
			this.tpAccountInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccountInfo.Size = new System.Drawing.Size(793, 450);
			this.tpAccountInfo.TabIndex = 2;
			this.tpAccountInfo.Text = "Account Details";
			this.tpAccountInfo.UseVisualStyleBackColor = true;
			// 
			// gbAccount
			// 
			this.gbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbAccount.Controls.Add(this.lblBalance);
			this.gbAccount.Controls.Add(this.dgvAccountLedger);
			this.gbAccount.Controls.Add(this.bSave);
			this.gbAccount.Controls.Add(this.cbAccountActive);
			this.gbAccount.Location = new System.Drawing.Point(3, 6);
			this.gbAccount.Name = "gbAccount";
			this.gbAccount.Size = new System.Drawing.Size(787, 444);
			this.gbAccount.TabIndex = 1;
			this.gbAccount.TabStop = false;
			this.gbAccount.Text = "### - Account Name";
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.Location = new System.Drawing.Point(7, 23);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(49, 13);
			this.lblBalance.TabIndex = 6;
			this.lblBalance.Text = "Balance:";
			// 
			// dgvAccountLedger
			// 
			this.dgvAccountLedger.AllowUserToAddRows = false;
			this.dgvAccountLedger.AllowUserToDeleteRows = false;
			this.dgvAccountLedger.AllowUserToResizeColumns = false;
			this.dgvAccountLedger.AllowUserToResizeRows = false;
			this.dgvAccountLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAccountLedger.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgvAccountLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccountLedger.Location = new System.Drawing.Point(0, 46);
			this.dgvAccountLedger.Name = "dgvAccountLedger";
			this.dgvAccountLedger.ReadOnly = true;
			this.dgvAccountLedger.RowHeadersVisible = false;
			this.dgvAccountLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAccountLedger.Size = new System.Drawing.Size(787, 398);
			this.dgvAccountLedger.TabIndex = 5;
			// 
			// bSave
			// 
			this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bSave.Location = new System.Drawing.Point(706, 19);
			this.bSave.Name = "bSave";
			this.bSave.Size = new System.Drawing.Size(75, 23);
			this.bSave.TabIndex = 4;
			this.bSave.Text = "Save";
			this.bSave.UseVisualStyleBackColor = true;
			this.bSave.Click += new System.EventHandler(this.bSave_Click);
			// 
			// cbAccountActive
			// 
			this.cbAccountActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbAccountActive.AutoSize = true;
			this.cbAccountActive.Enabled = false;
			this.cbAccountActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAccountActive.Location = new System.Drawing.Point(644, 23);
			this.cbAccountActive.Name = "cbAccountActive";
			this.cbAccountActive.Size = new System.Drawing.Size(56, 17);
			this.cbAccountActive.TabIndex = 3;
			this.cbAccountActive.Text = "Active";
			this.cbAccountActive.UseVisualStyleBackColor = true;
			// 
			// tpAccoutTypes
			// 
			this.tpAccoutTypes.Controls.Add(this.dgAccountTypes);
			this.tpAccoutTypes.Location = new System.Drawing.Point(104, 4);
			this.tpAccoutTypes.Name = "tpAccoutTypes";
			this.tpAccoutTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccoutTypes.Size = new System.Drawing.Size(793, 450);
			this.tpAccoutTypes.TabIndex = 1;
			this.tpAccoutTypes.Text = "Types";
			this.tpAccoutTypes.UseVisualStyleBackColor = true;
			// 
			// dgAccountTypes
			// 
			this.dgAccountTypes.AllowUserToAddRows = false;
			this.dgAccountTypes.AllowUserToDeleteRows = false;
			this.dgAccountTypes.AllowUserToResizeColumns = false;
			this.dgAccountTypes.AllowUserToResizeRows = false;
			this.dgAccountTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgAccountTypes.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgAccountTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAccountTypes.Location = new System.Drawing.Point(3, 3);
			this.dgAccountTypes.MultiSelect = false;
			this.dgAccountTypes.Name = "dgAccountTypes";
			this.dgAccountTypes.ReadOnly = true;
			this.dgAccountTypes.RowHeadersVisible = false;
			this.dgAccountTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAccountTypes.Size = new System.Drawing.Size(787, 441);
			this.dgAccountTypes.TabIndex = 0;
			// 
			// tpJournal
			// 
			this.tpJournal.Controls.Add(this.dgJournal);
			this.tpJournal.Location = new System.Drawing.Point(104, 4);
			this.tpJournal.Name = "tpJournal";
			this.tpJournal.Padding = new System.Windows.Forms.Padding(3);
			this.tpJournal.Size = new System.Drawing.Size(793, 450);
			this.tpJournal.TabIndex = 4;
			this.tpJournal.Text = "Transactions";
			this.tpJournal.UseVisualStyleBackColor = true;
			// 
			// dgJournal
			// 
			this.dgJournal.AllowUserToAddRows = false;
			this.dgJournal.AllowUserToDeleteRows = false;
			this.dgJournal.AllowUserToResizeColumns = false;
			this.dgJournal.AllowUserToResizeRows = false;
			this.dgJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgJournal.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgJournal.EnableHeadersVisualStyles = false;
			this.dgJournal.Location = new System.Drawing.Point(3, 3);
			this.dgJournal.MultiSelect = false;
			this.dgJournal.Name = "dgJournal";
			this.dgJournal.ReadOnly = true;
			this.dgJournal.RowHeadersVisible = false;
			this.dgJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgJournal.Size = new System.Drawing.Size(787, 444);
			this.dgJournal.TabIndex = 0;
			// 
			// tpChanges
			// 
			this.tpChanges.Controls.Add(this.dgAccountChanges);
			this.tpChanges.Location = new System.Drawing.Point(104, 4);
			this.tpChanges.Name = "tpChanges";
			this.tpChanges.Padding = new System.Windows.Forms.Padding(3);
			this.tpChanges.Size = new System.Drawing.Size(793, 450);
			this.tpChanges.TabIndex = 3;
			this.tpChanges.Text = "Changes";
			this.tpChanges.UseVisualStyleBackColor = true;
			// 
			// dgAccountChanges
			// 
			this.dgAccountChanges.AllowUserToAddRows = false;
			this.dgAccountChanges.AllowUserToDeleteRows = false;
			this.dgAccountChanges.AllowUserToResizeColumns = false;
			this.dgAccountChanges.AllowUserToResizeRows = false;
			this.dgAccountChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgAccountChanges.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgAccountChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAccountChanges.Location = new System.Drawing.Point(3, 3);
			this.dgAccountChanges.MultiSelect = false;
			this.dgAccountChanges.Name = "dgAccountChanges";
			this.dgAccountChanges.ReadOnly = true;
			this.dgAccountChanges.RowHeadersVisible = false;
			this.dgAccountChanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAccountChanges.Size = new System.Drawing.Size(787, 441);
			this.dgAccountChanges.TabIndex = 1;
			// 
			// toolbarMain
			// 
			this.toolbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAccounts,
            this.menuJournal});
			this.toolbarMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolbarMain.Location = new System.Drawing.Point(0, 0);
			this.toolbarMain.Name = "toolbarMain";
			this.toolbarMain.Size = new System.Drawing.Size(901, 25);
			this.toolbarMain.TabIndex = 2;
			this.toolbarMain.Text = "Toolbar";
			// 
			// menuAccounts
			// 
			this.menuAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddAccount,
            this.miAddAccountType});
			this.menuAccounts.Image = ((System.Drawing.Image)(resources.GetObject("menuAccounts.Image")));
			this.menuAccounts.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuAccounts.Name = "menuAccounts";
			this.menuAccounts.Size = new System.Drawing.Size(86, 22);
			this.menuAccounts.Text = "&Accounts";
			// 
			// miAddAccount
			// 
			this.miAddAccount.Name = "miAddAccount";
			this.miAddAccount.Size = new System.Drawing.Size(173, 22);
			this.miAddAccount.Text = "Add &Account";
			this.miAddAccount.Click += new System.EventHandler(this.miAddAccount_Click);
			// 
			// miAddAccountType
			// 
			this.miAddAccountType.Name = "miAddAccountType";
			this.miAddAccountType.Size = new System.Drawing.Size(173, 22);
			this.miAddAccountType.Text = "Add Account &Type";
			this.miAddAccountType.Click += new System.EventHandler(this.miAddAccountType_Click);
			// 
			// menuJournal
			// 
			this.menuJournal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addJournalEntryToolStripMenuItem});
			this.menuJournal.Image = ((System.Drawing.Image)(resources.GetObject("menuJournal.Image")));
			this.menuJournal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.menuJournal.Name = "menuJournal";
			this.menuJournal.Size = new System.Drawing.Size(74, 22);
			this.menuJournal.Text = "&Journal";
			// 
			// addJournalEntryToolStripMenuItem
			// 
			this.addJournalEntryToolStripMenuItem.Name = "addJournalEntryToolStripMenuItem";
			this.addJournalEntryToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.addJournalEntryToolStripMenuItem.Text = "&Add Journal Entry";
			this.addJournalEntryToolStripMenuItem.Click += new System.EventHandler(this.addJournalEntryToolStripMenuItem_Click);
			// 
			// tabTrialBalance
			// 
			this.tabTrialBalance.Controls.Add(this.dgTrialBalance);
			this.tabTrialBalance.Location = new System.Drawing.Point(4, 22);
			this.tabTrialBalance.Name = "tabTrialBalance";
			this.tabTrialBalance.Padding = new System.Windows.Forms.Padding(3);
			this.tabTrialBalance.Size = new System.Drawing.Size(776, 432);
			this.tabTrialBalance.TabIndex = 5;
			this.tabTrialBalance.Text = "Trial Balance";
			this.tabTrialBalance.UseVisualStyleBackColor = true;
			// 
			// dgTrialBalance
			// 
			this.dgTrialBalance.AllowUserToAddRows = false;
			this.dgTrialBalance.AllowUserToDeleteRows = false;
			this.dgTrialBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgTrialBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgTrialBalance.Location = new System.Drawing.Point(0, 0);
			this.dgTrialBalance.Name = "dgTrialBalance";
			this.dgTrialBalance.ReadOnly = true;
			this.dgTrialBalance.Size = new System.Drawing.Size(776, 432);
			this.dgTrialBalance.TabIndex = 0;
			// 
			// Mainwin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(901, 486);
			this.Controls.Add(this.toolbarMain);
			this.Controls.Add(this.tabMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(700, 450);
			this.Name = "Mainwin";
			this.Text = "Fastbooks";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainwin_FormClosed);
			this.Load += new System.EventHandler(this.Mainwin_Load);
			this.Resize += new System.EventHandler(this.Mainwin_Resize);
			this.tabMain.ResumeLayout(false);
			this.tpAccounts.ResumeLayout(false);
			this.tpAccounts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgChartAccounts)).EndInit();
			this.tpAccountInfo.ResumeLayout(false);
			this.gbAccount.ResumeLayout(false);
			this.gbAccount.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).EndInit();
			this.tpAccoutTypes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgAccountTypes)).EndInit();
			this.tpJournal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgJournal)).EndInit();
			this.tpChanges.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgAccountChanges)).EndInit();
			this.toolbarMain.ResumeLayout(false);
			this.toolbarMain.PerformLayout();
			this.tabTrialBalance.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgTrialBalance)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tpAccounts;
		private System.Windows.Forms.DataGridView dgChartAccounts;
        private System.Windows.Forms.TabPage tpAccoutTypes;
		private System.Windows.Forms.DataGridView dgAccountTypes;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cbSortBy;
		private System.Windows.Forms.TabPage tpAccountInfo;
		private System.Windows.Forms.GroupBox gbAccount;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.CheckBox cbAccountActive;
        private System.Windows.Forms.ToolStrip toolbarMain;
		private System.Windows.Forms.ToolStripDropDownButton menuAccounts;
		private System.Windows.Forms.ToolStripMenuItem miAddAccount;
		private System.Windows.Forms.ToolStripMenuItem miAddAccountType;
		private System.Windows.Forms.TabPage tpChanges;
		private System.Windows.Forms.DataGridView dgAccountChanges;
        private System.Windows.Forms.TabPage tpJournal;
        private System.Windows.Forms.DataGridView dgJournal;
        private System.Windows.Forms.ToolStripDropDownButton menuJournal;
        private System.Windows.Forms.ToolStripMenuItem addJournalEntryToolStripMenuItem;
		private System.Windows.Forms.ComboBox cbxTypes;
		private System.Windows.Forms.Label lblAccountTypes;
		private System.Windows.Forms.TextBox txtAccountName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.DataGridView dgvAccountLedger;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.TabPage tabTrialBalance;
		private System.Windows.Forms.DataGridView dgTrialBalance;

	}
}


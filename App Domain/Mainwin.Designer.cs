﻿namespace App_Domain
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
            this.tpChartOfAccounts = new System.Windows.Forms.TabPage();
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
            this.dgAccountTransactions = new System.Windows.Forms.DataGridView();
            this.cbAccountActive = new System.Windows.Forms.CheckBox();
            this.tpAccountTypes = new System.Windows.Forms.TabPage();
            this.dgAccountTypes = new System.Windows.Forms.DataGridView();
            this.tpJournal = new System.Windows.Forms.TabPage();
            this.dgJournal = new System.Windows.Forms.DataGridView();
            this.tpChanges = new System.Windows.Forms.TabPage();
            this.dgChanges = new System.Windows.Forms.DataGridView();
            this.tpTrialBalance = new System.Windows.Forms.TabPage();
            this.lblTotalCredit = new System.Windows.Forms.Label();
            this.lblTotalDebit = new System.Windows.Forms.Label();
            this.dgTrialBalance = new System.Windows.Forms.DataGridView();
            this.toolbarMain = new System.Windows.Forms.ToolStrip();
            this.menuAccounts = new System.Windows.Forms.ToolStripDropDownButton();
            this.miAddAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddAccountType = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJournal = new System.Windows.Forms.ToolStripDropDownButton();
            this.addJournalEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain.SuspendLayout();
            this.tpChartOfAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChartAccounts)).BeginInit();
            this.tpAccountInfo.SuspendLayout();
            this.gbAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountTransactions)).BeginInit();
            this.tpAccountTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountTypes)).BeginInit();
            this.tpJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJournal)).BeginInit();
            this.tpChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChanges)).BeginInit();
            this.tpTrialBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrialBalance)).BeginInit();
            this.toolbarMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tpChartOfAccounts);
            this.tabMain.Controls.Add(this.tpAccountInfo);
            this.tabMain.Controls.Add(this.tpAccountTypes);
            this.tabMain.Controls.Add(this.tpJournal);
            this.tabMain.Controls.Add(this.tpChanges);
            this.tabMain.Controls.Add(this.tpTrialBalance);
            this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabMain.ItemSize = new System.Drawing.Size(30, 120);
            this.tabMain.Location = new System.Drawing.Point(0, 28);
            this.tabMain.MinimumSize = new System.Drawing.Size(887, 434);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(887, 434);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 1;
            this.tabMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMain_DrawItem);
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tpChartOfAccounts
            // 
            this.tpChartOfAccounts.Controls.Add(this.txtAccountName);
            this.tpChartOfAccounts.Controls.Add(this.lblName);
            this.tpChartOfAccounts.Controls.Add(this.cbxTypes);
            this.tpChartOfAccounts.Controls.Add(this.lblAccountTypes);
            this.tpChartOfAccounts.Controls.Add(this.lblSortBy);
            this.tpChartOfAccounts.Controls.Add(this.cbSortBy);
            this.tpChartOfAccounts.Controls.Add(this.dgChartAccounts);
            this.tpChartOfAccounts.Location = new System.Drawing.Point(124, 4);
            this.tpChartOfAccounts.Name = "tpChartOfAccounts";
            this.tpChartOfAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpChartOfAccounts.Size = new System.Drawing.Size(759, 426);
            this.tpChartOfAccounts.TabIndex = 0;
            this.tpChartOfAccounts.Text = "Accounts";
            this.tpChartOfAccounts.UseVisualStyleBackColor = true;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(92, 6);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(124, 20);
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
            this.cbxTypes.Location = new System.Drawing.Point(307, 6);
            this.cbxTypes.Name = "cbxTypes";
            this.cbxTypes.Size = new System.Drawing.Size(236, 21);
            this.cbxTypes.TabIndex = 4;
            this.cbxTypes.SelectedIndexChanged += new System.EventHandler(this.cbxTypes_SelectedIndexChanged);
            // 
            // lblAccountTypes
            // 
            this.lblAccountTypes.AutoSize = true;
            this.lblAccountTypes.Location = new System.Drawing.Point(222, 7);
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
            this.lblSortBy.Location = new System.Drawing.Point(549, 7);
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
            this.cbSortBy.Location = new System.Drawing.Point(596, 6);
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
            this.dgChartAccounts.Size = new System.Drawing.Size(756, 390);
            this.dgChartAccounts.TabIndex = 0;
            this.dgChartAccounts.DoubleClick += new System.EventHandler(this.dgChartAccounts_DoubleClick);
            // 
            // tpAccountInfo
            // 
            this.tpAccountInfo.Controls.Add(this.gbAccount);
            this.tpAccountInfo.Location = new System.Drawing.Point(124, 4);
            this.tpAccountInfo.Name = "tpAccountInfo";
            this.tpAccountInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountInfo.Size = new System.Drawing.Size(759, 426);
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
            this.gbAccount.Controls.Add(this.dgAccountTransactions);
            this.gbAccount.Controls.Add(this.cbAccountActive);
            this.gbAccount.Location = new System.Drawing.Point(3, 3);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(753, 420);
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
            // dgAccountTransactions
            // 
            this.dgAccountTransactions.AllowUserToAddRows = false;
            this.dgAccountTransactions.AllowUserToDeleteRows = false;
            this.dgAccountTransactions.AllowUserToResizeColumns = false;
            this.dgAccountTransactions.AllowUserToResizeRows = false;
            this.dgAccountTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAccountTransactions.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgAccountTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccountTransactions.Location = new System.Drawing.Point(232, 11);
            this.dgAccountTransactions.Name = "dgAccountTransactions";
            this.dgAccountTransactions.ReadOnly = true;
            this.dgAccountTransactions.RowHeadersVisible = false;
            this.dgAccountTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccountTransactions.Size = new System.Drawing.Size(515, 409);
            this.dgAccountTransactions.TabIndex = 5;
            // 
            // cbAccountActive
            // 
            this.cbAccountActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAccountActive.AutoSize = true;
            this.cbAccountActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountActive.Location = new System.Drawing.Point(-14, 55);
            this.cbAccountActive.Name = "cbAccountActive";
            this.cbAccountActive.Size = new System.Drawing.Size(56, 17);
            this.cbAccountActive.TabIndex = 3;
            this.cbAccountActive.Text = "Active";
            this.cbAccountActive.UseVisualStyleBackColor = true;
            this.cbAccountActive.CheckedChanged += new System.EventHandler(this.cbAccountActive_CheckedChanged);
            // 
            // tpAccountTypes
            // 
            this.tpAccountTypes.Controls.Add(this.dgAccountTypes);
            this.tpAccountTypes.Location = new System.Drawing.Point(124, 4);
            this.tpAccountTypes.Name = "tpAccountTypes";
            this.tpAccountTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountTypes.Size = new System.Drawing.Size(759, 426);
            this.tpAccountTypes.TabIndex = 1;
            this.tpAccountTypes.Text = "Types";
            this.tpAccountTypes.UseVisualStyleBackColor = true;
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
            this.dgAccountTypes.Size = new System.Drawing.Size(753, 420);
            this.dgAccountTypes.TabIndex = 0;
            // 
            // tpJournal
            // 
            this.tpJournal.Controls.Add(this.dgJournal);
            this.tpJournal.Location = new System.Drawing.Point(124, 4);
            this.tpJournal.Name = "tpJournal";
            this.tpJournal.Padding = new System.Windows.Forms.Padding(3);
            this.tpJournal.Size = new System.Drawing.Size(759, 426);
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
            this.dgJournal.Size = new System.Drawing.Size(753, 420);
            this.dgJournal.TabIndex = 0;
            // 
            // tpChanges
            // 
            this.tpChanges.Controls.Add(this.dgChanges);
            this.tpChanges.Location = new System.Drawing.Point(124, 4);
            this.tpChanges.Name = "tpChanges";
            this.tpChanges.Padding = new System.Windows.Forms.Padding(3);
            this.tpChanges.Size = new System.Drawing.Size(759, 426);
            this.tpChanges.TabIndex = 3;
            this.tpChanges.Text = "Changes";
            this.tpChanges.UseVisualStyleBackColor = true;
            // 
            // dgChanges
            // 
            this.dgChanges.AllowUserToAddRows = false;
            this.dgChanges.AllowUserToDeleteRows = false;
            this.dgChanges.AllowUserToResizeColumns = false;
            this.dgChanges.AllowUserToResizeRows = false;
            this.dgChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgChanges.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChanges.Location = new System.Drawing.Point(3, 3);
            this.dgChanges.MultiSelect = false;
            this.dgChanges.Name = "dgChanges";
            this.dgChanges.ReadOnly = true;
            this.dgChanges.RowHeadersVisible = false;
            this.dgChanges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChanges.Size = new System.Drawing.Size(753, 420);
            this.dgChanges.TabIndex = 1;
            // 
            // tpTrialBalance
            // 
            this.tpTrialBalance.Controls.Add(this.lblTotalCredit);
            this.tpTrialBalance.Controls.Add(this.lblTotalDebit);
            this.tpTrialBalance.Controls.Add(this.dgTrialBalance);
            this.tpTrialBalance.Location = new System.Drawing.Point(124, 4);
            this.tpTrialBalance.Name = "tpTrialBalance";
            this.tpTrialBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrialBalance.Size = new System.Drawing.Size(759, 426);
            this.tpTrialBalance.TabIndex = 5;
            this.tpTrialBalance.Text = "Trial Balance";
            this.tpTrialBalance.UseVisualStyleBackColor = true;
            // 
            // lblTotalCredit
            // 
            this.lblTotalCredit.AutoSize = true;
            this.lblTotalCredit.Location = new System.Drawing.Point(189, 7);
            this.lblTotalCredit.Name = "lblTotalCredit";
            this.lblTotalCredit.Size = new System.Drawing.Size(72, 13);
            this.lblTotalCredit.TabIndex = 2;
            this.lblTotalCredit.Text = "Total Credits: ";
            // 
            // lblTotalDebit
            // 
            this.lblTotalDebit.AutoSize = true;
            this.lblTotalDebit.Location = new System.Drawing.Point(7, 7);
            this.lblTotalDebit.Name = "lblTotalDebit";
            this.lblTotalDebit.Size = new System.Drawing.Size(70, 13);
            this.lblTotalDebit.TabIndex = 1;
            this.lblTotalDebit.Text = "Total Debits: ";
            // 
            // dgTrialBalance
            // 
            this.dgTrialBalance.AllowUserToAddRows = false;
            this.dgTrialBalance.AllowUserToDeleteRows = false;
            this.dgTrialBalance.AllowUserToResizeColumns = false;
            this.dgTrialBalance.AllowUserToResizeRows = false;
            this.dgTrialBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTrialBalance.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgTrialBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrialBalance.Location = new System.Drawing.Point(3, 34);
            this.dgTrialBalance.MultiSelect = false;
            this.dgTrialBalance.Name = "dgTrialBalance";
            this.dgTrialBalance.ReadOnly = true;
            this.dgTrialBalance.RowHeadersVisible = false;
            this.dgTrialBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTrialBalance.Size = new System.Drawing.Size(753, 392);
            this.dgTrialBalance.TabIndex = 0;
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
            this.toolbarMain.Size = new System.Drawing.Size(887, 25);
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
            // Mainwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 462);
            this.Controls.Add(this.toolbarMain);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(903, 500);
            this.Name = "Mainwin";
            this.Text = "Fastbooks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainwin_FormClosed);
            this.Load += new System.EventHandler(this.Mainwin_Load);
            this.Resize += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            this.tabMain.ResumeLayout(false);
            this.tpChartOfAccounts.ResumeLayout(false);
            this.tpChartOfAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChartAccounts)).EndInit();
            this.tpAccountInfo.ResumeLayout(false);
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountTransactions)).EndInit();
            this.tpAccountTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountTypes)).EndInit();
            this.tpJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgJournal)).EndInit();
            this.tpChanges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChanges)).EndInit();
            this.tpTrialBalance.ResumeLayout(false);
            this.tpTrialBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrialBalance)).EndInit();
            this.toolbarMain.ResumeLayout(false);
            this.toolbarMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tpChartOfAccounts;
		private System.Windows.Forms.DataGridView dgChartAccounts;
        private System.Windows.Forms.TabPage tpAccountTypes;
		private System.Windows.Forms.DataGridView dgAccountTypes;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cbSortBy;
		private System.Windows.Forms.TabPage tpAccountInfo;
		private System.Windows.Forms.GroupBox gbAccount;
		private System.Windows.Forms.CheckBox cbAccountActive;
        private System.Windows.Forms.ToolStrip toolbarMain;
		private System.Windows.Forms.ToolStripDropDownButton menuAccounts;
		private System.Windows.Forms.ToolStripMenuItem miAddAccount;
		private System.Windows.Forms.ToolStripMenuItem miAddAccountType;
		private System.Windows.Forms.TabPage tpChanges;
		private System.Windows.Forms.DataGridView dgChanges;
        private System.Windows.Forms.TabPage tpJournal;
        private System.Windows.Forms.DataGridView dgJournal;
        private System.Windows.Forms.ToolStripDropDownButton menuJournal;
        private System.Windows.Forms.ToolStripMenuItem addJournalEntryToolStripMenuItem;
		private System.Windows.Forms.ComboBox cbxTypes;
		private System.Windows.Forms.Label lblAccountTypes;
		private System.Windows.Forms.TextBox txtAccountName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.DataGridView dgAccountTransactions;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.TabPage tpTrialBalance;
		private System.Windows.Forms.DataGridView dgTrialBalance;
		private System.Windows.Forms.Label lblTotalCredit;
		private System.Windows.Forms.Label lblTotalDebit;

	}
}


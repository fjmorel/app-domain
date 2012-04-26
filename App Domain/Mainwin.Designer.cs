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
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Unposted", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Posted Entries", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Deleted Journal Entries", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainwin));
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tpAllAccounts = new System.Windows.Forms.TabPage();
			this.btnNewAccount = new System.Windows.Forms.Button();
			this.lblCAFilter = new System.Windows.Forms.Label();
			this.txtAccountName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.cbxTypes = new System.Windows.Forms.ComboBox();
			this.lblAccountTypes = new System.Windows.Forms.Label();
			this.lblSortBy = new System.Windows.Forms.Label();
			this.cbSortBy = new System.Windows.Forms.ComboBox();
			this.dgChartAccounts = new System.Windows.Forms.DataGridView();
			this.tpAccountDetails = new System.Windows.Forms.TabPage();
			this.gbAccount = new System.Windows.Forms.GroupBox();
			this.btnUpdateAccountNumber = new System.Windows.Forms.Button();
			this.numAccountNumber = new System.Windows.Forms.NumericUpDown();
			this.btnDeleteAccount = new System.Windows.Forms.Button();
			this.lblBalance = new System.Windows.Forms.Label();
			this.dgAccountTransactions = new System.Windows.Forms.DataGridView();
			this.cbAccountActive = new System.Windows.Forms.CheckBox();
			this.tpAllAccountTypes = new System.Windows.Forms.TabPage();
			this.cbAccountType = new System.Windows.Forms.ComboBox();
			this.lblType = new System.Windows.Forms.Label();
			this.btnAddAccountType = new System.Windows.Forms.Button();
			this.txtAccountTypeDescription = new System.Windows.Forms.TextBox();
			this.txtAccountTypeName = new System.Windows.Forms.TextBox();
			this.lblATDescription = new System.Windows.Forms.Label();
			this.lblATName = new System.Windows.Forms.Label();
			this.dgAccountTypes = new System.Windows.Forms.DataGridView();
			this.tpAllJournalEntries = new System.Windows.Forms.TabPage();
			this.lvJournalEntries = new System.Windows.Forms.ListView();
			this.jeReference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.jeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnPostAllJournalEntries = new System.Windows.Forms.Button();
			this.btnAddJournalEntry = new System.Windows.Forms.Button();
			this.btnDeleteJournalEntry = new System.Windows.Forms.Button();
			this.lblNotes = new System.Windows.Forms.Label();
			this.btnPostJournalEntry = new System.Windows.Forms.Button();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.lblTransactionDetails = new System.Windows.Forms.Label();
			this.dgUnpostedJournalEntryTransactions = new System.Windows.Forms.DataGridView();
			this.tpAllTransactions = new System.Windows.Forms.TabPage();
			this.dgJournal = new System.Windows.Forms.DataGridView();
			this.tpAllChanges = new System.Windows.Forms.TabPage();
			this.dgChanges = new System.Windows.Forms.DataGridView();
			this.tpTrialBalance = new System.Windows.Forms.TabPage();
			this.lblTBDate = new System.Windows.Forms.Label();
			this.lblTBTrialBalance = new System.Windows.Forms.Label();
			this.lblTBCompany = new System.Windows.Forms.Label();
			this.dgTrialBalance = new System.Windows.Forms.DataGridView();
			this.tpIncomeStatement = new System.Windows.Forms.TabPage();
			this.lblIDate = new System.Windows.Forms.Label();
			this.lblIIncomeStatement = new System.Windows.Forms.Label();
			this.lblISCompany = new System.Windows.Forms.Label();
			this.dgIncomeSummary = new System.Windows.Forms.DataGridView();
			this.tpRetainedEarnings = new System.Windows.Forms.TabPage();
			this.numDividends = new System.Windows.Forms.NumericUpDown();
			this.lblDividends = new System.Windows.Forms.Label();
			this.btnSaveRE = new System.Windows.Forms.Button();
			this.txtRE = new System.Windows.Forms.TextBox();
			this.txtIncome = new System.Windows.Forms.TextBox();
			this.lblRetainedEarnings = new System.Windows.Forms.Label();
			this.lblIncome = new System.Windows.Forms.Label();
			this.tpBalanceSheet = new System.Windows.Forms.TabPage();
			this.dgBalanceSheet = new System.Windows.Forms.DataGridView();
			this.lblBDate = new System.Windows.Forms.Label();
			this.lblBBalance = new System.Windows.Forms.Label();
			this.lblBCompany = new System.Windows.Forms.Label();
			this.tpRatios = new System.Windows.Forms.TabPage();
			this.txtQuickRatio = new System.Windows.Forms.TextBox();
			this.lblQuickBal = new System.Windows.Forms.Label();
			this.txtCurRatio = new System.Windows.Forms.TextBox();
			this.lblCurrentRatio = new System.Windows.Forms.Label();
			this.tpPrint = new System.Windows.Forms.TabPage();
			this.btnPrint = new System.Windows.Forms.Button();
			this.pdPrinterDoc = new System.Drawing.Printing.PrintDocument();
			this.ppPrinterPreview = new System.Windows.Forms.PrintPreviewDialog();
			this.pdialogPrinter = new System.Windows.Forms.PrintDialog();
			this.tabMain.SuspendLayout();
			this.tpAllAccounts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgChartAccounts)).BeginInit();
			this.tpAccountDetails.SuspendLayout();
			this.gbAccount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAccountNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgAccountTransactions)).BeginInit();
			this.tpAllAccountTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgAccountTypes)).BeginInit();
			this.tpAllJournalEntries.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgUnpostedJournalEntryTransactions)).BeginInit();
			this.tpAllTransactions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgJournal)).BeginInit();
			this.tpAllChanges.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgChanges)).BeginInit();
			this.tpTrialBalance.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgTrialBalance)).BeginInit();
			this.tpIncomeStatement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgIncomeSummary)).BeginInit();
			this.tpRetainedEarnings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDividends)).BeginInit();
			this.tpBalanceSheet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgBalanceSheet)).BeginInit();
			this.tpRatios.SuspendLayout();
			this.tpPrint.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMain
			// 
			this.tabMain.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabMain.Controls.Add(this.tpAllAccounts);
			this.tabMain.Controls.Add(this.tpAccountDetails);
			this.tabMain.Controls.Add(this.tpAllAccountTypes);
			this.tabMain.Controls.Add(this.tpAllJournalEntries);
			this.tabMain.Controls.Add(this.tpAllTransactions);
			this.tabMain.Controls.Add(this.tpAllChanges);
			this.tabMain.Controls.Add(this.tpTrialBalance);
			this.tabMain.Controls.Add(this.tpIncomeStatement);
			this.tabMain.Controls.Add(this.tpRetainedEarnings);
			this.tabMain.Controls.Add(this.tpBalanceSheet);
			this.tabMain.Controls.Add(this.tpRatios);
			this.tabMain.Controls.Add(this.tpPrint);
			this.tabMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabMain.ItemSize = new System.Drawing.Size(30, 120);
			this.tabMain.Location = new System.Drawing.Point(0, 0);
			this.tabMain.MinimumSize = new System.Drawing.Size(887, 462);
			this.tabMain.Multiline = true;
			this.tabMain.Name = "tabMain";
			this.tabMain.Padding = new System.Drawing.Point(0, 0);
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(887, 462);
			this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabMain.TabIndex = 1;
			this.tabMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabMain_DrawItem);
			this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
			// 
			// tpAllAccounts
			// 
			this.tpAllAccounts.Controls.Add(this.btnNewAccount);
			this.tpAllAccounts.Controls.Add(this.lblCAFilter);
			this.tpAllAccounts.Controls.Add(this.txtAccountName);
			this.tpAllAccounts.Controls.Add(this.lblName);
			this.tpAllAccounts.Controls.Add(this.cbxTypes);
			this.tpAllAccounts.Controls.Add(this.lblAccountTypes);
			this.tpAllAccounts.Controls.Add(this.lblSortBy);
			this.tpAllAccounts.Controls.Add(this.cbSortBy);
			this.tpAllAccounts.Controls.Add(this.dgChartAccounts);
			this.tpAllAccounts.Location = new System.Drawing.Point(124, 4);
			this.tpAllAccounts.Name = "tpAllAccounts";
			this.tpAllAccounts.Padding = new System.Windows.Forms.Padding(3);
			this.tpAllAccounts.Size = new System.Drawing.Size(759, 454);
			this.tpAllAccounts.TabIndex = 0;
			this.tpAllAccounts.Text = "Accounts";
			this.tpAllAccounts.UseVisualStyleBackColor = true;
			// 
			// btnNewAccount
			// 
			this.btnNewAccount.Location = new System.Drawing.Point(6, 4);
			this.btnNewAccount.Name = "btnNewAccount";
			this.btnNewAccount.Size = new System.Drawing.Size(67, 23);
			this.btnNewAccount.TabIndex = 8;
			this.btnNewAccount.Text = "New";
			this.btnNewAccount.UseVisualStyleBackColor = true;
			this.btnNewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
			// 
			// lblCAFilter
			// 
			this.lblCAFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCAFilter.AutoSize = true;
			this.lblCAFilter.Location = new System.Drawing.Point(79, 9);
			this.lblCAFilter.Name = "lblCAFilter";
			this.lblCAFilter.Size = new System.Drawing.Size(47, 13);
			this.lblCAFilter.TabIndex = 7;
			this.lblCAFilter.Text = "Filter By:";
			// 
			// txtAccountName
			// 
			this.txtAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAccountName.Location = new System.Drawing.Point(173, 6);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.Size = new System.Drawing.Size(129, 20);
			this.txtAccountName.TabIndex = 6;
			this.txtAccountName.TextChanged += new System.EventHandler(this.ChartOfAccounts_FilterChanged);
			// 
			// lblName
			// 
			this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(132, 9);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(35, 13);
			this.lblName.TabIndex = 5;
			this.lblName.Text = "Name";
			// 
			// cbxTypes
			// 
			this.cbxTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTypes.FormattingEnabled = true;
			this.cbxTypes.Items.AddRange(new object[] {
            "All"});
			this.cbxTypes.Location = new System.Drawing.Point(350, 6);
			this.cbxTypes.Name = "cbxTypes";
			this.cbxTypes.Size = new System.Drawing.Size(218, 21);
			this.cbxTypes.TabIndex = 4;
			this.cbxTypes.SelectedIndexChanged += new System.EventHandler(this.ChartOfAccounts_FilterChanged);
			// 
			// lblAccountTypes
			// 
			this.lblAccountTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAccountTypes.AutoSize = true;
			this.lblAccountTypes.Location = new System.Drawing.Point(308, 9);
			this.lblAccountTypes.Name = "lblAccountTypes";
			this.lblAccountTypes.Size = new System.Drawing.Size(36, 13);
			this.lblAccountTypes.TabIndex = 3;
			this.lblAccountTypes.Text = "Types";
			// 
			// lblSortBy
			// 
			this.lblSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSortBy.AutoSize = true;
			this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSortBy.Location = new System.Drawing.Point(574, 7);
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
			this.cbSortBy.Location = new System.Drawing.Point(621, 6);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(132, 21);
			this.cbSortBy.TabIndex = 1;
			this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.ChartOfAccounts_FilterChanged);
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
			this.dgChartAccounts.Size = new System.Drawing.Size(753, 418);
			this.dgChartAccounts.TabIndex = 0;
			this.dgChartAccounts.DoubleClick += new System.EventHandler(this.dgChartAccounts_DoubleClick);
			// 
			// tpAccountDetails
			// 
			this.tpAccountDetails.Controls.Add(this.gbAccount);
			this.tpAccountDetails.Location = new System.Drawing.Point(124, 4);
			this.tpAccountDetails.Name = "tpAccountDetails";
			this.tpAccountDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccountDetails.Size = new System.Drawing.Size(759, 454);
			this.tpAccountDetails.TabIndex = 2;
			this.tpAccountDetails.Text = "Account Details";
			this.tpAccountDetails.UseVisualStyleBackColor = true;
			// 
			// gbAccount
			// 
			this.gbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbAccount.Controls.Add(this.btnUpdateAccountNumber);
			this.gbAccount.Controls.Add(this.numAccountNumber);
			this.gbAccount.Controls.Add(this.btnDeleteAccount);
			this.gbAccount.Controls.Add(this.lblBalance);
			this.gbAccount.Controls.Add(this.dgAccountTransactions);
			this.gbAccount.Controls.Add(this.cbAccountActive);
			this.gbAccount.Location = new System.Drawing.Point(3, 3);
			this.gbAccount.Name = "gbAccount";
			this.gbAccount.Size = new System.Drawing.Size(753, 448);
			this.gbAccount.TabIndex = 1;
			this.gbAccount.TabStop = false;
			this.gbAccount.Text = "### - Account Name";
			// 
			// btnUpdateAccountNumber
			// 
			this.btnUpdateAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnUpdateAccountNumber.Location = new System.Drawing.Point(412, 9);
			this.btnUpdateAccountNumber.Name = "btnUpdateAccountNumber";
			this.btnUpdateAccountNumber.Size = new System.Drawing.Size(180, 23);
			this.btnUpdateAccountNumber.TabIndex = 9;
			this.btnUpdateAccountNumber.Text = "Change Account Number";
			this.btnUpdateAccountNumber.UseVisualStyleBackColor = true;
			this.btnUpdateAccountNumber.Click += new System.EventHandler(this.btnUpdateAccountNumber_Click);
			// 
			// numAccountNumber
			// 
			this.numAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numAccountNumber.Location = new System.Drawing.Point(314, 12);
			this.numAccountNumber.Name = "numAccountNumber";
			this.numAccountNumber.Size = new System.Drawing.Size(92, 20);
			this.numAccountNumber.TabIndex = 8;
			// 
			// btnDeleteAccount
			// 
			this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteAccount.Location = new System.Drawing.Point(598, 9);
			this.btnDeleteAccount.Name = "btnDeleteAccount";
			this.btnDeleteAccount.Size = new System.Drawing.Size(148, 23);
			this.btnDeleteAccount.TabIndex = 7;
			this.btnDeleteAccount.Text = "Delete Account";
			this.btnDeleteAccount.UseVisualStyleBackColor = true;
			this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.Location = new System.Drawing.Point(103, 20);
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
			this.dgAccountTransactions.Location = new System.Drawing.Point(3, 36);
			this.dgAccountTransactions.Name = "dgAccountTransactions";
			this.dgAccountTransactions.ReadOnly = true;
			this.dgAccountTransactions.RowHeadersVisible = false;
			this.dgAccountTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAccountTransactions.Size = new System.Drawing.Size(744, 412);
			this.dgAccountTransactions.TabIndex = 5;
			this.dgAccountTransactions.DoubleClick += new System.EventHandler(this.dgAccountTransactions_DoubleClick);
			// 
			// cbAccountActive
			// 
			this.cbAccountActive.AutoSize = true;
			this.cbAccountActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAccountActive.Location = new System.Drawing.Point(6, 19);
			this.cbAccountActive.Name = "cbAccountActive";
			this.cbAccountActive.Size = new System.Drawing.Size(56, 17);
			this.cbAccountActive.TabIndex = 3;
			this.cbAccountActive.Text = "Active";
			this.cbAccountActive.UseVisualStyleBackColor = true;
			this.cbAccountActive.CheckedChanged += new System.EventHandler(this.cbAccountActive_CheckedChanged);
			// 
			// tpAllAccountTypes
			// 
			this.tpAllAccountTypes.Controls.Add(this.cbAccountType);
			this.tpAllAccountTypes.Controls.Add(this.lblType);
			this.tpAllAccountTypes.Controls.Add(this.btnAddAccountType);
			this.tpAllAccountTypes.Controls.Add(this.txtAccountTypeDescription);
			this.tpAllAccountTypes.Controls.Add(this.txtAccountTypeName);
			this.tpAllAccountTypes.Controls.Add(this.lblATDescription);
			this.tpAllAccountTypes.Controls.Add(this.lblATName);
			this.tpAllAccountTypes.Controls.Add(this.dgAccountTypes);
			this.tpAllAccountTypes.Location = new System.Drawing.Point(124, 4);
			this.tpAllAccountTypes.Name = "tpAllAccountTypes";
			this.tpAllAccountTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tpAllAccountTypes.Size = new System.Drawing.Size(759, 454);
			this.tpAllAccountTypes.TabIndex = 1;
			this.tpAllAccountTypes.Text = "Types";
			this.tpAllAccountTypes.UseVisualStyleBackColor = true;
			// 
			// cbAccountType
			// 
			this.cbAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAccountType.FormattingEnabled = true;
			this.cbAccountType.Items.AddRange(new object[] {
            "Asset",
            "Liability",
            "Expense",
            "Revenue",
            "Equity"});
			this.cbAccountType.Location = new System.Drawing.Point(475, 6);
			this.cbAccountType.Name = "cbAccountType";
			this.cbAccountType.Size = new System.Drawing.Size(183, 21);
			this.cbAccountType.TabIndex = 10;
			// 
			// lblType
			// 
			this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblType.AutoSize = true;
			this.lblType.Location = new System.Drawing.Point(438, 11);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(31, 13);
			this.lblType.TabIndex = 9;
			this.lblType.Text = "Type";
			// 
			// btnAddAccountType
			// 
			this.btnAddAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddAccountType.Location = new System.Drawing.Point(664, 6);
			this.btnAddAccountType.Name = "btnAddAccountType";
			this.btnAddAccountType.Size = new System.Drawing.Size(89, 23);
			this.btnAddAccountType.TabIndex = 8;
			this.btnAddAccountType.Text = "Add";
			this.btnAddAccountType.UseVisualStyleBackColor = true;
			this.btnAddAccountType.Click += new System.EventHandler(this.btnAddAccountType_Click);
			// 
			// txtAccountTypeDescription
			// 
			this.txtAccountTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAccountTypeDescription.Location = new System.Drawing.Point(75, 35);
			this.txtAccountTypeDescription.Name = "txtAccountTypeDescription";
			this.txtAccountTypeDescription.Size = new System.Drawing.Size(678, 20);
			this.txtAccountTypeDescription.TabIndex = 4;
			// 
			// txtAccountTypeName
			// 
			this.txtAccountTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAccountTypeName.Location = new System.Drawing.Point(48, 7);
			this.txtAccountTypeName.Name = "txtAccountTypeName";
			this.txtAccountTypeName.Size = new System.Drawing.Size(384, 20);
			this.txtAccountTypeName.TabIndex = 3;
			// 
			// lblATDescription
			// 
			this.lblATDescription.AutoSize = true;
			this.lblATDescription.Location = new System.Drawing.Point(3, 38);
			this.lblATDescription.Name = "lblATDescription";
			this.lblATDescription.Size = new System.Drawing.Size(60, 13);
			this.lblATDescription.TabIndex = 2;
			this.lblATDescription.Text = "Description";
			// 
			// lblATName
			// 
			this.lblATName.AutoSize = true;
			this.lblATName.Location = new System.Drawing.Point(3, 11);
			this.lblATName.Name = "lblATName";
			this.lblATName.Size = new System.Drawing.Size(35, 13);
			this.lblATName.TabIndex = 1;
			this.lblATName.Text = "Name";
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
			this.dgAccountTypes.Location = new System.Drawing.Point(3, 61);
			this.dgAccountTypes.MultiSelect = false;
			this.dgAccountTypes.Name = "dgAccountTypes";
			this.dgAccountTypes.ReadOnly = true;
			this.dgAccountTypes.RowHeadersVisible = false;
			this.dgAccountTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAccountTypes.Size = new System.Drawing.Size(753, 390);
			this.dgAccountTypes.TabIndex = 0;
			// 
			// tpAllJournalEntries
			// 
			this.tpAllJournalEntries.Controls.Add(this.lvJournalEntries);
			this.tpAllJournalEntries.Controls.Add(this.btnPostAllJournalEntries);
			this.tpAllJournalEntries.Controls.Add(this.btnAddJournalEntry);
			this.tpAllJournalEntries.Controls.Add(this.btnDeleteJournalEntry);
			this.tpAllJournalEntries.Controls.Add(this.lblNotes);
			this.tpAllJournalEntries.Controls.Add(this.btnPostJournalEntry);
			this.tpAllJournalEntries.Controls.Add(this.txtNotes);
			this.tpAllJournalEntries.Controls.Add(this.lblTransactionDetails);
			this.tpAllJournalEntries.Controls.Add(this.dgUnpostedJournalEntryTransactions);
			this.tpAllJournalEntries.Location = new System.Drawing.Point(124, 4);
			this.tpAllJournalEntries.Name = "tpAllJournalEntries";
			this.tpAllJournalEntries.Size = new System.Drawing.Size(759, 454);
			this.tpAllJournalEntries.TabIndex = 6;
			this.tpAllJournalEntries.Text = "Journal Entries";
			this.tpAllJournalEntries.UseVisualStyleBackColor = true;
			// 
			// lvJournalEntries
			// 
			this.lvJournalEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lvJournalEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jeReference,
            this.jeDate});
			this.lvJournalEntries.FullRowSelect = true;
			listViewGroup4.Header = "Unposted";
			listViewGroup4.Name = "Unposted";
			listViewGroup5.Header = "Posted Entries";
			listViewGroup5.Name = "Posted";
			listViewGroup6.Header = "Deleted Journal Entries";
			listViewGroup6.Name = "Deleted";
			this.lvJournalEntries.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
			this.lvJournalEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvJournalEntries.HideSelection = false;
			this.lvJournalEntries.Location = new System.Drawing.Point(3, 3);
			this.lvJournalEntries.Name = "lvJournalEntries";
			this.lvJournalEntries.Size = new System.Drawing.Size(200, 414);
			this.lvJournalEntries.TabIndex = 10;
			this.lvJournalEntries.UseCompatibleStateImageBehavior = false;
			this.lvJournalEntries.View = System.Windows.Forms.View.Details;
			this.lvJournalEntries.SelectedIndexChanged += new System.EventHandler(this.lvJournalEntries_SelectedIndexChanged);
			// 
			// jeReference
			// 
			this.jeReference.Text = "Ref";
			this.jeReference.Width = 50;
			// 
			// jeDate
			// 
			this.jeDate.Text = "Date Created";
			this.jeDate.Width = 129;
			// 
			// btnPostAllJournalEntries
			// 
			this.btnPostAllJournalEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPostAllJournalEntries.Enabled = false;
			this.btnPostAllJournalEntries.Location = new System.Drawing.Point(634, 423);
			this.btnPostAllJournalEntries.Name = "btnPostAllJournalEntries";
			this.btnPostAllJournalEntries.Size = new System.Drawing.Size(117, 23);
			this.btnPostAllJournalEntries.TabIndex = 9;
			this.btnPostAllJournalEntries.Text = "Post All";
			this.btnPostAllJournalEntries.UseVisualStyleBackColor = true;
			this.btnPostAllJournalEntries.Click += new System.EventHandler(this.btnPostAllJournalEntries_Click);
			// 
			// btnAddJournalEntry
			// 
			this.btnAddJournalEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddJournalEntry.Location = new System.Drawing.Point(6, 423);
			this.btnAddJournalEntry.Name = "btnAddJournalEntry";
			this.btnAddJournalEntry.Size = new System.Drawing.Size(197, 23);
			this.btnAddJournalEntry.TabIndex = 8;
			this.btnAddJournalEntry.Text = "Add Journal Entry";
			this.btnAddJournalEntry.UseVisualStyleBackColor = true;
			this.btnAddJournalEntry.Click += new System.EventHandler(this.btnAddJournalEntry_Click);
			// 
			// btnDeleteJournalEntry
			// 
			this.btnDeleteJournalEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteJournalEntry.Enabled = false;
			this.btnDeleteJournalEntry.Location = new System.Drawing.Point(388, 423);
			this.btnDeleteJournalEntry.Name = "btnDeleteJournalEntry";
			this.btnDeleteJournalEntry.Size = new System.Drawing.Size(117, 23);
			this.btnDeleteJournalEntry.TabIndex = 7;
			this.btnDeleteJournalEntry.Text = "Delete";
			this.btnDeleteJournalEntry.UseVisualStyleBackColor = true;
			this.btnDeleteJournalEntry.Click += new System.EventHandler(this.btnDeleteJournalEntry_Click);
			// 
			// lblNotes
			// 
			this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblNotes.AutoSize = true;
			this.lblNotes.Location = new System.Drawing.Point(209, 257);
			this.lblNotes.Name = "lblNotes";
			this.lblNotes.Size = new System.Drawing.Size(30, 13);
			this.lblNotes.TabIndex = 6;
			this.lblNotes.Text = "Note";
			// 
			// btnPostJournalEntry
			// 
			this.btnPostJournalEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPostJournalEntry.Enabled = false;
			this.btnPostJournalEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPostJournalEntry.Location = new System.Drawing.Point(511, 423);
			this.btnPostJournalEntry.Name = "btnPostJournalEntry";
			this.btnPostJournalEntry.Size = new System.Drawing.Size(117, 23);
			this.btnPostJournalEntry.TabIndex = 5;
			this.btnPostJournalEntry.Text = "Post";
			this.btnPostJournalEntry.UseVisualStyleBackColor = true;
			this.btnPostJournalEntry.Click += new System.EventHandler(this.btnPostJournalEntry_Click);
			// 
			// txtNotes
			// 
			this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNotes.Enabled = false;
			this.txtNotes.Location = new System.Drawing.Point(209, 276);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(547, 141);
			this.txtNotes.TabIndex = 4;
			// 
			// lblTransactionDetails
			// 
			this.lblTransactionDetails.AutoSize = true;
			this.lblTransactionDetails.Location = new System.Drawing.Point(206, 3);
			this.lblTransactionDetails.Name = "lblTransactionDetails";
			this.lblTransactionDetails.Size = new System.Drawing.Size(68, 13);
			this.lblTransactionDetails.TabIndex = 3;
			this.lblTransactionDetails.Text = "Transactions";
			// 
			// dgUnpostedJournalEntryTransactions
			// 
			this.dgUnpostedJournalEntryTransactions.AllowUserToAddRows = false;
			this.dgUnpostedJournalEntryTransactions.AllowUserToDeleteRows = false;
			this.dgUnpostedJournalEntryTransactions.AllowUserToResizeColumns = false;
			this.dgUnpostedJournalEntryTransactions.AllowUserToResizeRows = false;
			this.dgUnpostedJournalEntryTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgUnpostedJournalEntryTransactions.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgUnpostedJournalEntryTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgUnpostedJournalEntryTransactions.Location = new System.Drawing.Point(209, 19);
			this.dgUnpostedJournalEntryTransactions.Name = "dgUnpostedJournalEntryTransactions";
			this.dgUnpostedJournalEntryTransactions.RowHeadersVisible = false;
			this.dgUnpostedJournalEntryTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgUnpostedJournalEntryTransactions.Size = new System.Drawing.Size(547, 232);
			this.dgUnpostedJournalEntryTransactions.TabIndex = 2;
			// 
			// tpAllTransactions
			// 
			this.tpAllTransactions.Controls.Add(this.dgJournal);
			this.tpAllTransactions.Location = new System.Drawing.Point(124, 4);
			this.tpAllTransactions.Name = "tpAllTransactions";
			this.tpAllTransactions.Padding = new System.Windows.Forms.Padding(3);
			this.tpAllTransactions.Size = new System.Drawing.Size(759, 454);
			this.tpAllTransactions.TabIndex = 4;
			this.tpAllTransactions.Text = "Transactions";
			this.tpAllTransactions.UseVisualStyleBackColor = true;
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
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgJournal.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgJournal.Location = new System.Drawing.Point(3, 3);
			this.dgJournal.MultiSelect = false;
			this.dgJournal.Name = "dgJournal";
			this.dgJournal.ReadOnly = true;
			this.dgJournal.RowHeadersVisible = false;
			this.dgJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgJournal.Size = new System.Drawing.Size(753, 448);
			this.dgJournal.TabIndex = 0;
			this.dgJournal.DoubleClick += new System.EventHandler(this.dgJournal_DoubleClick);
			// 
			// tpAllChanges
			// 
			this.tpAllChanges.Controls.Add(this.dgChanges);
			this.tpAllChanges.Location = new System.Drawing.Point(124, 4);
			this.tpAllChanges.Name = "tpAllChanges";
			this.tpAllChanges.Padding = new System.Windows.Forms.Padding(3);
			this.tpAllChanges.Size = new System.Drawing.Size(759, 454);
			this.tpAllChanges.TabIndex = 3;
			this.tpAllChanges.Text = "Change Log";
			this.tpAllChanges.UseVisualStyleBackColor = true;
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
			this.dgChanges.Size = new System.Drawing.Size(753, 448);
			this.dgChanges.TabIndex = 1;
			// 
			// tpTrialBalance
			// 
			this.tpTrialBalance.Controls.Add(this.lblTBDate);
			this.tpTrialBalance.Controls.Add(this.lblTBTrialBalance);
			this.tpTrialBalance.Controls.Add(this.lblTBCompany);
			this.tpTrialBalance.Controls.Add(this.dgTrialBalance);
			this.tpTrialBalance.Location = new System.Drawing.Point(124, 4);
			this.tpTrialBalance.Name = "tpTrialBalance";
			this.tpTrialBalance.Padding = new System.Windows.Forms.Padding(3);
			this.tpTrialBalance.Size = new System.Drawing.Size(759, 454);
			this.tpTrialBalance.TabIndex = 5;
			this.tpTrialBalance.Text = "Trial Balance";
			this.tpTrialBalance.UseVisualStyleBackColor = true;
			// 
			// lblTBDate
			// 
			this.lblTBDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTBDate.AutoSize = true;
			this.lblTBDate.Location = new System.Drawing.Point(340, 33);
			this.lblTBDate.Name = "lblTBDate";
			this.lblTBDate.Size = new System.Drawing.Size(72, 13);
			this.lblTBDate.TabIndex = 3;
			this.lblTBDate.Text = "April 12, 2012";
			// 
			// lblTBTrialBalance
			// 
			this.lblTBTrialBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTBTrialBalance.AutoSize = true;
			this.lblTBTrialBalance.Location = new System.Drawing.Point(340, 18);
			this.lblTBTrialBalance.Name = "lblTBTrialBalance";
			this.lblTBTrialBalance.Size = new System.Drawing.Size(69, 13);
			this.lblTBTrialBalance.TabIndex = 2;
			this.lblTBTrialBalance.Text = "Trial Balance";
			// 
			// lblTBCompany
			// 
			this.lblTBCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTBCompany.AutoSize = true;
			this.lblTBCompany.Location = new System.Drawing.Point(332, 3);
			this.lblTBCompany.Name = "lblTBCompany";
			this.lblTBCompany.Size = new System.Drawing.Size(77, 13);
			this.lblTBCompany.TabIndex = 1;
			this.lblTBCompany.Text = "Fastbooks, Inc";
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
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgTrialBalance.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgTrialBalance.Location = new System.Drawing.Point(3, 49);
			this.dgTrialBalance.MultiSelect = false;
			this.dgTrialBalance.Name = "dgTrialBalance";
			this.dgTrialBalance.ReadOnly = true;
			this.dgTrialBalance.RowHeadersVisible = false;
			this.dgTrialBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgTrialBalance.Size = new System.Drawing.Size(753, 402);
			this.dgTrialBalance.TabIndex = 0;
			// 
			// tpIncomeStatement
			// 
			this.tpIncomeStatement.Controls.Add(this.lblIDate);
			this.tpIncomeStatement.Controls.Add(this.lblIIncomeStatement);
			this.tpIncomeStatement.Controls.Add(this.lblISCompany);
			this.tpIncomeStatement.Controls.Add(this.dgIncomeSummary);
			this.tpIncomeStatement.Location = new System.Drawing.Point(124, 4);
			this.tpIncomeStatement.Name = "tpIncomeStatement";
			this.tpIncomeStatement.Size = new System.Drawing.Size(759, 454);
			this.tpIncomeStatement.TabIndex = 7;
			this.tpIncomeStatement.Text = "Income Statement";
			this.tpIncomeStatement.UseVisualStyleBackColor = true;
			// 
			// lblIDate
			// 
			this.lblIDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIDate.AutoSize = true;
			this.lblIDate.Location = new System.Drawing.Point(300, 33);
			this.lblIDate.Name = "lblIDate";
			this.lblIDate.Size = new System.Drawing.Size(196, 13);
			this.lblIDate.TabIndex = 6;
			this.lblIDate.Text = "January 12, 2012 through April 12, 2012";
			// 
			// lblIIncomeStatement
			// 
			this.lblIIncomeStatement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblIIncomeStatement.AutoSize = true;
			this.lblIIncomeStatement.Location = new System.Drawing.Point(346, 18);
			this.lblIIncomeStatement.Name = "lblIIncomeStatement";
			this.lblIIncomeStatement.Size = new System.Drawing.Size(93, 13);
			this.lblIIncomeStatement.TabIndex = 5;
			this.lblIIncomeStatement.Text = "Income Statement";
			// 
			// lblISCompany
			// 
			this.lblISCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblISCompany.AutoSize = true;
			this.lblISCompany.Location = new System.Drawing.Point(346, 3);
			this.lblISCompany.Name = "lblISCompany";
			this.lblISCompany.Size = new System.Drawing.Size(77, 13);
			this.lblISCompany.TabIndex = 4;
			this.lblISCompany.Text = "Fastbooks, Inc";
			// 
			// dgIncomeSummary
			// 
			this.dgIncomeSummary.AllowUserToAddRows = false;
			this.dgIncomeSummary.AllowUserToDeleteRows = false;
			this.dgIncomeSummary.AllowUserToResizeColumns = false;
			this.dgIncomeSummary.AllowUserToResizeRows = false;
			this.dgIncomeSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgIncomeSummary.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgIncomeSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgIncomeSummary.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgIncomeSummary.Location = new System.Drawing.Point(3, 49);
			this.dgIncomeSummary.MultiSelect = false;
			this.dgIncomeSummary.Name = "dgIncomeSummary";
			this.dgIncomeSummary.RowHeadersVisible = false;
			this.dgIncomeSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgIncomeSummary.Size = new System.Drawing.Size(753, 402);
			this.dgIncomeSummary.TabIndex = 0;
			// 
			// tpRetainedEarnings
			// 
			this.tpRetainedEarnings.Controls.Add(this.numDividends);
			this.tpRetainedEarnings.Controls.Add(this.lblDividends);
			this.tpRetainedEarnings.Controls.Add(this.btnSaveRE);
			this.tpRetainedEarnings.Controls.Add(this.txtRE);
			this.tpRetainedEarnings.Controls.Add(this.txtIncome);
			this.tpRetainedEarnings.Controls.Add(this.lblRetainedEarnings);
			this.tpRetainedEarnings.Controls.Add(this.lblIncome);
			this.tpRetainedEarnings.Location = new System.Drawing.Point(124, 4);
			this.tpRetainedEarnings.Name = "tpRetainedEarnings";
			this.tpRetainedEarnings.Size = new System.Drawing.Size(759, 454);
			this.tpRetainedEarnings.TabIndex = 8;
			this.tpRetainedEarnings.Text = "Retained Earnings";
			this.tpRetainedEarnings.UseVisualStyleBackColor = true;
			// 
			// numDividends
			// 
			this.numDividends.DecimalPlaces = 2;
			this.numDividends.Location = new System.Drawing.Point(104, 56);
			this.numDividends.Name = "numDividends";
			this.numDividends.Size = new System.Drawing.Size(144, 20);
			this.numDividends.TabIndex = 7;
			this.numDividends.ValueChanged += new System.EventHandler(this.numDividends_ValueChanged);
			this.numDividends.Leave += new System.EventHandler(this.numDividends_Leave);
			// 
			// lblDividends
			// 
			this.lblDividends.AutoSize = true;
			this.lblDividends.Location = new System.Drawing.Point(3, 58);
			this.lblDividends.Name = "lblDividends";
			this.lblDividends.Size = new System.Drawing.Size(54, 13);
			this.lblDividends.TabIndex = 6;
			this.lblDividends.Text = "Dividends";
			// 
			// btnSaveRE
			// 
			this.btnSaveRE.Location = new System.Drawing.Point(150, 82);
			this.btnSaveRE.Name = "btnSaveRE";
			this.btnSaveRE.Size = new System.Drawing.Size(98, 23);
			this.btnSaveRE.TabIndex = 4;
			this.btnSaveRE.Text = "Set Dividends";
			this.btnSaveRE.UseVisualStyleBackColor = true;
			this.btnSaveRE.Click += new System.EventHandler(this.btnSaveRE_Click);
			// 
			// txtRE
			// 
			this.txtRE.Enabled = false;
			this.txtRE.Location = new System.Drawing.Point(104, 29);
			this.txtRE.Name = "txtRE";
			this.txtRE.Size = new System.Drawing.Size(144, 20);
			this.txtRE.TabIndex = 3;
			// 
			// txtIncome
			// 
			this.txtIncome.Enabled = false;
			this.txtIncome.Location = new System.Drawing.Point(104, 4);
			this.txtIncome.Name = "txtIncome";
			this.txtIncome.Size = new System.Drawing.Size(144, 20);
			this.txtIncome.TabIndex = 2;
			// 
			// lblRetainedEarnings
			// 
			this.lblRetainedEarnings.AutoSize = true;
			this.lblRetainedEarnings.Location = new System.Drawing.Point(4, 32);
			this.lblRetainedEarnings.Name = "lblRetainedEarnings";
			this.lblRetainedEarnings.Size = new System.Drawing.Size(94, 13);
			this.lblRetainedEarnings.TabIndex = 1;
			this.lblRetainedEarnings.Text = "Retained Earnings";
			// 
			// lblIncome
			// 
			this.lblIncome.AutoSize = true;
			this.lblIncome.Location = new System.Drawing.Point(4, 7);
			this.lblIncome.Name = "lblIncome";
			this.lblIncome.Size = new System.Drawing.Size(42, 13);
			this.lblIncome.TabIndex = 0;
			this.lblIncome.Text = "Income";
			// 
			// tpBalanceSheet
			// 
			this.tpBalanceSheet.Controls.Add(this.dgBalanceSheet);
			this.tpBalanceSheet.Controls.Add(this.lblBDate);
			this.tpBalanceSheet.Controls.Add(this.lblBBalance);
			this.tpBalanceSheet.Controls.Add(this.lblBCompany);
			this.tpBalanceSheet.Location = new System.Drawing.Point(124, 4);
			this.tpBalanceSheet.Name = "tpBalanceSheet";
			this.tpBalanceSheet.Size = new System.Drawing.Size(759, 454);
			this.tpBalanceSheet.TabIndex = 9;
			this.tpBalanceSheet.Text = "Balance Sheet";
			this.tpBalanceSheet.UseVisualStyleBackColor = true;
			// 
			// dgBalanceSheet
			// 
			this.dgBalanceSheet.AllowUserToAddRows = false;
			this.dgBalanceSheet.AllowUserToDeleteRows = false;
			this.dgBalanceSheet.AllowUserToResizeColumns = false;
			this.dgBalanceSheet.AllowUserToResizeRows = false;
			this.dgBalanceSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgBalanceSheet.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dgBalanceSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgBalanceSheet.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgBalanceSheet.Location = new System.Drawing.Point(3, 49);
			this.dgBalanceSheet.MultiSelect = false;
			this.dgBalanceSheet.Name = "dgBalanceSheet";
			this.dgBalanceSheet.ReadOnly = true;
			this.dgBalanceSheet.RowHeadersVisible = false;
			this.dgBalanceSheet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgBalanceSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgBalanceSheet.Size = new System.Drawing.Size(753, 402);
			this.dgBalanceSheet.TabIndex = 7;
			// 
			// lblBDate
			// 
			this.lblBDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBDate.AutoSize = true;
			this.lblBDate.Location = new System.Drawing.Point(354, 33);
			this.lblBDate.Name = "lblBDate";
			this.lblBDate.Size = new System.Drawing.Size(72, 13);
			this.lblBDate.TabIndex = 6;
			this.lblBDate.Text = "April 12, 2012";
			// 
			// lblBBalance
			// 
			this.lblBBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBBalance.AutoSize = true;
			this.lblBBalance.Location = new System.Drawing.Point(351, 18);
			this.lblBBalance.Name = "lblBBalance";
			this.lblBBalance.Size = new System.Drawing.Size(77, 13);
			this.lblBBalance.TabIndex = 5;
			this.lblBBalance.Text = "Balance Sheet";
			// 
			// lblBCompany
			// 
			this.lblBCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBCompany.AutoSize = true;
			this.lblBCompany.Location = new System.Drawing.Point(346, 3);
			this.lblBCompany.Name = "lblBCompany";
			this.lblBCompany.Size = new System.Drawing.Size(77, 13);
			this.lblBCompany.TabIndex = 4;
			this.lblBCompany.Text = "Fastbooks, Inc";
			// 
			// tpRatios
			// 
			this.tpRatios.Controls.Add(this.txtQuickRatio);
			this.tpRatios.Controls.Add(this.lblQuickBal);
			this.tpRatios.Controls.Add(this.txtCurRatio);
			this.tpRatios.Controls.Add(this.lblCurrentRatio);
			this.tpRatios.Location = new System.Drawing.Point(124, 4);
			this.tpRatios.Name = "tpRatios";
			this.tpRatios.Size = new System.Drawing.Size(759, 454);
			this.tpRatios.TabIndex = 10;
			this.tpRatios.Text = "Ratios Report";
			this.tpRatios.UseVisualStyleBackColor = true;
			// 
			// txtQuickRatio
			// 
			this.txtQuickRatio.Location = new System.Drawing.Point(80, 31);
			this.txtQuickRatio.Name = "txtQuickRatio";
			this.txtQuickRatio.Size = new System.Drawing.Size(162, 20);
			this.txtQuickRatio.TabIndex = 3;
			// 
			// lblQuickBal
			// 
			this.lblQuickBal.AutoSize = true;
			this.lblQuickBal.Location = new System.Drawing.Point(11, 31);
			this.lblQuickBal.Name = "lblQuickBal";
			this.lblQuickBal.Size = new System.Drawing.Size(63, 13);
			this.lblQuickBal.TabIndex = 2;
			this.lblQuickBal.Text = "Quick Ratio";
			// 
			// txtCurRatio
			// 
			this.txtCurRatio.Enabled = false;
			this.txtCurRatio.Location = new System.Drawing.Point(80, 4);
			this.txtCurRatio.Name = "txtCurRatio";
			this.txtCurRatio.Size = new System.Drawing.Size(162, 20);
			this.txtCurRatio.TabIndex = 1;
			// 
			// lblCurrentRatio
			// 
			this.lblCurrentRatio.AutoSize = true;
			this.lblCurrentRatio.Location = new System.Drawing.Point(5, 7);
			this.lblCurrentRatio.Name = "lblCurrentRatio";
			this.lblCurrentRatio.Size = new System.Drawing.Size(69, 13);
			this.lblCurrentRatio.TabIndex = 0;
			this.lblCurrentRatio.Text = "Current Ratio";
			// 
			// tpPrint
			// 
			this.tpPrint.Controls.Add(this.btnPrint);
			this.tpPrint.Location = new System.Drawing.Point(124, 4);
			this.tpPrint.Name = "tpPrint";
			this.tpPrint.Size = new System.Drawing.Size(759, 454);
			this.tpPrint.TabIndex = 11;
			this.tpPrint.Text = "Printing";
			this.tpPrint.UseVisualStyleBackColor = true;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(96, 59);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 0;
			this.btnPrint.Text = "Print Account List";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// pdPrinterDoc
			// 
			this.pdPrinterDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.pdPrinterDoc_BeginPrint);
			this.pdPrinterDoc.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.pdPrinterDoc_EndPrint);
			this.pdPrinterDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPrinterDoc_PrintPage);
			// 
			// ppPrinterPreview
			// 
			this.ppPrinterPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.ppPrinterPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.ppPrinterPreview.ClientSize = new System.Drawing.Size(400, 300);
			this.ppPrinterPreview.Enabled = true;
			this.ppPrinterPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("ppPrinterPreview.Icon")));
			this.ppPrinterPreview.Name = "ppPrinterPreview";
			this.ppPrinterPreview.Visible = false;
			// 
			// pdialogPrinter
			// 
			this.pdialogPrinter.UseEXDialog = true;
			// 
			// Mainwin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 462);
			this.Controls.Add(this.tabMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(903, 500);
			this.Name = "Mainwin";
			this.Text = "Fastbooks";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainwin_FormClosed);
			this.Load += new System.EventHandler(this.Mainwin_Load);
			this.Resize += new System.EventHandler(this.Mainwin_Resize);
			this.tabMain.ResumeLayout(false);
			this.tpAllAccounts.ResumeLayout(false);
			this.tpAllAccounts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgChartAccounts)).EndInit();
			this.tpAccountDetails.ResumeLayout(false);
			this.gbAccount.ResumeLayout(false);
			this.gbAccount.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAccountNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgAccountTransactions)).EndInit();
			this.tpAllAccountTypes.ResumeLayout(false);
			this.tpAllAccountTypes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgAccountTypes)).EndInit();
			this.tpAllJournalEntries.ResumeLayout(false);
			this.tpAllJournalEntries.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgUnpostedJournalEntryTransactions)).EndInit();
			this.tpAllTransactions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgJournal)).EndInit();
			this.tpAllChanges.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgChanges)).EndInit();
			this.tpTrialBalance.ResumeLayout(false);
			this.tpTrialBalance.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgTrialBalance)).EndInit();
			this.tpIncomeStatement.ResumeLayout(false);
			this.tpIncomeStatement.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgIncomeSummary)).EndInit();
			this.tpRetainedEarnings.ResumeLayout(false);
			this.tpRetainedEarnings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDividends)).EndInit();
			this.tpBalanceSheet.ResumeLayout(false);
			this.tpBalanceSheet.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgBalanceSheet)).EndInit();
			this.tpRatios.ResumeLayout(false);
			this.tpRatios.PerformLayout();
			this.tpPrint.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tpAllAccounts;
		private System.Windows.Forms.DataGridView dgChartAccounts;
        private System.Windows.Forms.TabPage tpAllAccountTypes;
		private System.Windows.Forms.DataGridView dgAccountTypes;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cbSortBy;
		private System.Windows.Forms.TabPage tpAccountDetails;
		private System.Windows.Forms.GroupBox gbAccount;
		private System.Windows.Forms.CheckBox cbAccountActive;
		private System.Windows.Forms.TabPage tpAllChanges;
		private System.Windows.Forms.DataGridView dgChanges;
        private System.Windows.Forms.TabPage tpAllTransactions;
		private System.Windows.Forms.DataGridView dgJournal;
		private System.Windows.Forms.ComboBox cbxTypes;
		private System.Windows.Forms.Label lblAccountTypes;
		private System.Windows.Forms.TextBox txtAccountName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.DataGridView dgAccountTransactions;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.TabPage tpTrialBalance;
        private System.Windows.Forms.DataGridView dgTrialBalance;
        private System.Windows.Forms.TabPage tpAllJournalEntries;
        private System.Windows.Forms.Button btnDeleteJournalEntry;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnPostJournalEntry;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblTransactionDetails;
		private System.Windows.Forms.DataGridView dgUnpostedJournalEntryTransactions;
		private System.Windows.Forms.Button btnAddJournalEntry;
		private System.Windows.Forms.TextBox txtAccountTypeDescription;
		private System.Windows.Forms.TextBox txtAccountTypeName;
		private System.Windows.Forms.Label lblATDescription;
		private System.Windows.Forms.Label lblATName;
		private System.Windows.Forms.Button btnAddAccountType;
		private System.Windows.Forms.Label lblCAFilter;
		private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.TabPage tpIncomeStatement;
        private System.Windows.Forms.DataGridView dgIncomeSummary;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TabPage tpRetainedEarnings;
        private System.Windows.Forms.TabPage tpBalanceSheet;
        private System.Windows.Forms.Label lblDividends;
        private System.Windows.Forms.Button btnSaveRE;
        private System.Windows.Forms.TextBox txtRE;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label lblRetainedEarnings;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.NumericUpDown numDividends;
		private System.Windows.Forms.Label lblTBDate;
		private System.Windows.Forms.Label lblTBTrialBalance;
		private System.Windows.Forms.Label lblTBCompany;
		private System.Windows.Forms.Label lblIDate;
		private System.Windows.Forms.Label lblIIncomeStatement;
		private System.Windows.Forms.Label lblISCompany;
		private System.Windows.Forms.Label lblBDate;
		private System.Windows.Forms.Label lblBBalance;
		private System.Windows.Forms.Label lblBCompany;
		private System.Windows.Forms.Button btnPostAllJournalEntries;
		private System.Windows.Forms.ListView lvJournalEntries;
		private System.Windows.Forms.ColumnHeader jeReference;
		private System.Windows.Forms.ColumnHeader jeDate;
		private System.Windows.Forms.Button btnUpdateAccountNumber;
		private System.Windows.Forms.NumericUpDown numAccountNumber;
        private System.Windows.Forms.DataGridView dgBalanceSheet;
        private System.Windows.Forms.TabPage tpRatios;
        private System.Windows.Forms.TextBox txtCurRatio;
        private System.Windows.Forms.Label lblCurrentRatio;
		private System.Windows.Forms.Button btnNewAccount;
        private System.Windows.Forms.TextBox txtQuickRatio;
        private System.Windows.Forms.Label lblQuickBal;
        private System.Windows.Forms.TabPage tpPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument pdPrinterDoc;
        private System.Windows.Forms.PrintPreviewDialog ppPrinterPreview;
		private System.Windows.Forms.PrintDialog pdialogPrinter;

	}
}


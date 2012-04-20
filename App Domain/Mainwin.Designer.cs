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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Unposted", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Posted Entries", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Deleted Journal Entries", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainwin));
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tpAllAccounts = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
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
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgTrialBalance = new System.Windows.Forms.DataGridView();
			this.tpIncomeStatement = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
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
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tpRatios = new System.Windows.Forms.TabPage();
			this.txtCurRatio = new System.Windows.Forms.TextBox();
			this.lblCurrentRatio = new System.Windows.Forms.Label();
			this.toolbarMain = new System.Windows.Forms.ToolStrip();
			this.btnAddAccount = new System.Windows.Forms.ToolStripButton();
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
			this.toolbarMain.SuspendLayout();
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
			// tpAllAccounts
			// 
			this.tpAllAccounts.Controls.Add(this.label4);
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
			this.tpAllAccounts.Size = new System.Drawing.Size(759, 426);
			this.tpAllAccounts.TabIndex = 0;
			this.tpAllAccounts.Text = "Accounts";
			this.tpAllAccounts.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Filter By:";
			// 
			// txtAccountName
			// 
			this.txtAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAccountName.Location = new System.Drawing.Point(117, 6);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.Size = new System.Drawing.Size(164, 20);
			this.txtAccountName.TabIndex = 6;
			this.txtAccountName.TextChanged += new System.EventHandler(this.ChartOfAccounts_FilterChanged);
			// 
			// lblName
			// 
			this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(76, 9);
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
			this.cbxTypes.Location = new System.Drawing.Point(329, 6);
			this.cbxTypes.Name = "cbxTypes";
			this.cbxTypes.Size = new System.Drawing.Size(236, 21);
			this.cbxTypes.TabIndex = 4;
			this.cbxTypes.SelectedIndexChanged += new System.EventHandler(this.ChartOfAccounts_FilterChanged);
			// 
			// lblAccountTypes
			// 
			this.lblAccountTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAccountTypes.AutoSize = true;
			this.lblAccountTypes.Location = new System.Drawing.Point(287, 9);
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
			this.lblSortBy.Location = new System.Drawing.Point(571, 7);
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
			this.cbSortBy.Location = new System.Drawing.Point(618, 6);
			this.cbSortBy.Name = "cbSortBy";
			this.cbSortBy.Size = new System.Drawing.Size(135, 21);
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
			this.dgChartAccounts.Size = new System.Drawing.Size(753, 390);
			this.dgChartAccounts.TabIndex = 0;
			this.dgChartAccounts.DoubleClick += new System.EventHandler(this.dgChartAccounts_DoubleClick);
			// 
			// tpAccountDetails
			// 
			this.tpAccountDetails.Controls.Add(this.gbAccount);
			this.tpAccountDetails.Location = new System.Drawing.Point(124, 4);
			this.tpAccountDetails.Name = "tpAccountDetails";
			this.tpAccountDetails.Padding = new System.Windows.Forms.Padding(3);
			this.tpAccountDetails.Size = new System.Drawing.Size(759, 426);
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
			this.gbAccount.Size = new System.Drawing.Size(753, 420);
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
			this.dgAccountTransactions.Size = new System.Drawing.Size(744, 384);
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
			this.tpAllAccountTypes.Controls.Add(this.label2);
			this.tpAllAccountTypes.Controls.Add(this.label1);
			this.tpAllAccountTypes.Controls.Add(this.dgAccountTypes);
			this.tpAllAccountTypes.Location = new System.Drawing.Point(124, 4);
			this.tpAllAccountTypes.Name = "tpAllAccountTypes";
			this.tpAllAccountTypes.Padding = new System.Windows.Forms.Padding(3);
			this.tpAllAccountTypes.Size = new System.Drawing.Size(759, 426);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Description";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
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
			this.dgAccountTypes.Size = new System.Drawing.Size(753, 362);
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
			this.tpAllJournalEntries.Size = new System.Drawing.Size(759, 426);
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
			listViewGroup1.Header = "Unposted";
			listViewGroup1.Name = "Unposted";
			listViewGroup2.Header = "Posted Entries";
			listViewGroup2.Name = "Posted";
			listViewGroup3.Header = "Deleted Journal Entries";
			listViewGroup3.Name = "Deleted";
			this.lvJournalEntries.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
			this.lvJournalEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvJournalEntries.HideSelection = false;
			this.lvJournalEntries.Location = new System.Drawing.Point(3, 3);
			this.lvJournalEntries.Name = "lvJournalEntries";
			this.lvJournalEntries.Size = new System.Drawing.Size(200, 383);
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
			this.btnPostAllJournalEntries.Location = new System.Drawing.Point(634, 395);
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
			this.btnAddJournalEntry.Location = new System.Drawing.Point(6, 395);
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
			this.btnDeleteJournalEntry.Location = new System.Drawing.Point(388, 395);
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
			this.btnPostJournalEntry.Location = new System.Drawing.Point(511, 395);
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
			this.txtNotes.Size = new System.Drawing.Size(547, 110);
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
			this.tpAllTransactions.Size = new System.Drawing.Size(759, 426);
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgJournal.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgJournal.Location = new System.Drawing.Point(3, 3);
			this.dgJournal.MultiSelect = false;
			this.dgJournal.Name = "dgJournal";
			this.dgJournal.ReadOnly = true;
			this.dgJournal.RowHeadersVisible = false;
			this.dgJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgJournal.Size = new System.Drawing.Size(753, 420);
			this.dgJournal.TabIndex = 0;
			this.dgJournal.DoubleClick += new System.EventHandler(this.dgJournal_DoubleClick);
			// 
			// tpAllChanges
			// 
			this.tpAllChanges.Controls.Add(this.dgChanges);
			this.tpAllChanges.Location = new System.Drawing.Point(124, 4);
			this.tpAllChanges.Name = "tpAllChanges";
			this.tpAllChanges.Padding = new System.Windows.Forms.Padding(3);
			this.tpAllChanges.Size = new System.Drawing.Size(759, 426);
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
			this.dgChanges.Size = new System.Drawing.Size(753, 420);
			this.dgChanges.TabIndex = 1;
			// 
			// tpTrialBalance
			// 
			this.tpTrialBalance.Controls.Add(this.label6);
			this.tpTrialBalance.Controls.Add(this.label5);
			this.tpTrialBalance.Controls.Add(this.label3);
			this.tpTrialBalance.Controls.Add(this.dgTrialBalance);
			this.tpTrialBalance.Location = new System.Drawing.Point(124, 4);
			this.tpTrialBalance.Name = "tpTrialBalance";
			this.tpTrialBalance.Padding = new System.Windows.Forms.Padding(3);
			this.tpTrialBalance.Size = new System.Drawing.Size(759, 426);
			this.tpTrialBalance.TabIndex = 5;
			this.tpTrialBalance.Text = "Trial Balance";
			this.tpTrialBalance.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(340, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "April 12, 2012";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(340, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Trial Balance";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(332, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Company Name";
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
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgTrialBalance.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgTrialBalance.Location = new System.Drawing.Point(3, 64);
			this.dgTrialBalance.MultiSelect = false;
			this.dgTrialBalance.Name = "dgTrialBalance";
			this.dgTrialBalance.ReadOnly = true;
			this.dgTrialBalance.RowHeadersVisible = false;
			this.dgTrialBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgTrialBalance.Size = new System.Drawing.Size(753, 362);
			this.dgTrialBalance.TabIndex = 0;
			// 
			// tpIncomeStatement
			// 
			this.tpIncomeStatement.Controls.Add(this.label7);
			this.tpIncomeStatement.Controls.Add(this.label8);
			this.tpIncomeStatement.Controls.Add(this.label9);
			this.tpIncomeStatement.Controls.Add(this.dgIncomeSummary);
			this.tpIncomeStatement.Location = new System.Drawing.Point(124, 4);
			this.tpIncomeStatement.Name = "tpIncomeStatement";
			this.tpIncomeStatement.Size = new System.Drawing.Size(759, 426);
			this.tpIncomeStatement.TabIndex = 7;
			this.tpIncomeStatement.Text = "Income Statement";
			this.tpIncomeStatement.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(300, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(196, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "January 12, 2012 through April 12, 2012";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(343, 34);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Income Statement";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(346, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Company Name";
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
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgIncomeSummary.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgIncomeSummary.Location = new System.Drawing.Point(3, 75);
			this.dgIncomeSummary.MultiSelect = false;
			this.dgIncomeSummary.Name = "dgIncomeSummary";
			this.dgIncomeSummary.RowHeadersVisible = false;
			this.dgIncomeSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgIncomeSummary.Size = new System.Drawing.Size(753, 348);
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
			this.tpRetainedEarnings.Size = new System.Drawing.Size(759, 426);
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
			this.tpBalanceSheet.Controls.Add(this.label10);
			this.tpBalanceSheet.Controls.Add(this.label11);
			this.tpBalanceSheet.Controls.Add(this.label12);
			this.tpBalanceSheet.Location = new System.Drawing.Point(124, 4);
			this.tpBalanceSheet.Name = "tpBalanceSheet";
			this.tpBalanceSheet.Size = new System.Drawing.Size(759, 426);
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
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgBalanceSheet.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgBalanceSheet.Location = new System.Drawing.Point(3, 71);
			this.dgBalanceSheet.MultiSelect = false;
			this.dgBalanceSheet.Name = "dgBalanceSheet";
			this.dgBalanceSheet.ReadOnly = true;
			this.dgBalanceSheet.RowHeadersVisible = false;
			this.dgBalanceSheet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgBalanceSheet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgBalanceSheet.Size = new System.Drawing.Size(753, 352);
			this.dgBalanceSheet.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(354, 55);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "April 12, 2012";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(351, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(77, 13);
			this.label11.TabIndex = 5;
			this.label11.Text = "Balance Sheet";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(346, 10);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 13);
			this.label12.TabIndex = 4;
			this.label12.Text = "Company Name";
			// 
			// tpRatios
			// 
			this.tpRatios.Controls.Add(this.txtCurRatio);
			this.tpRatios.Controls.Add(this.lblCurrentRatio);
			this.tpRatios.Location = new System.Drawing.Point(124, 4);
			this.tpRatios.Name = "tpRatios";
			this.tpRatios.Size = new System.Drawing.Size(759, 426);
			this.tpRatios.TabIndex = 10;
			this.tpRatios.Text = "Ratios Report";
			this.tpRatios.UseVisualStyleBackColor = true;
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
			// toolbarMain
			// 
			this.toolbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAccount});
			this.toolbarMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolbarMain.Location = new System.Drawing.Point(0, 0);
			this.toolbarMain.Name = "toolbarMain";
			this.toolbarMain.Size = new System.Drawing.Size(887, 25);
			this.toolbarMain.TabIndex = 2;
			this.toolbarMain.Text = "Toolbar";
			// 
			// btnAddAccount
			// 
			this.btnAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAccount.Image")));
			this.btnAddAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAddAccount.Name = "btnAddAccount";
			this.btnAddAccount.Size = new System.Drawing.Size(97, 22);
			this.btnAddAccount.Text = "&Add Account";
			this.btnAddAccount.Click += new System.EventHandler(this.miAddAccount_Click);
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
			this.toolbarMain.ResumeLayout(false);
			this.toolbarMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.ToolStrip toolbarMain;
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddAccountType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripButton btnAddAccount;
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
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

	}
}


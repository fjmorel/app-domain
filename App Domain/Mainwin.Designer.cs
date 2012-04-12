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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainwin));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpChartOfAccounts = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cbxTypes = new System.Windows.Forms.ComboBox();
            this.lblAccountTypes = new System.Windows.Forms.Label();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cbSortBy = new System.Windows.Forms.ComboBox();
            this.dgChartAccounts = new System.Windows.Forms.DataGridView();
            this.tpAccountTypes = new System.Windows.Forms.TabPage();
            this.btnAddAccountType = new System.Windows.Forms.Button();
            this.cbAccountTypeDebitIsPositive = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccountTypeDescription = new System.Windows.Forms.TextBox();
            this.txtAccountTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAccountTypes = new System.Windows.Forms.DataGridView();
            this.tpJournal = new System.Windows.Forms.TabPage();
            this.dgJournal = new System.Windows.Forms.DataGridView();
            this.tpChanges = new System.Windows.Forms.TabPage();
            this.dgChanges = new System.Windows.Forms.DataGridView();
            this.tpTrialBalance = new System.Windows.Forms.TabPage();
            this.dgTrialBalance = new System.Windows.Forms.DataGridView();
            this.tabPosting = new System.Windows.Forms.TabPage();
            this.btnAddJournalEntry = new System.Windows.Forms.Button();
            this.btnRemoveTransaction = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnPostTransaction = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblTransactionDetails = new System.Windows.Forms.Label();
            this.dgUnpostedJournalEntryTransactions = new System.Windows.Forms.DataGridView();
            this.lbUnpostedList = new System.Windows.Forms.ListBox();
            this.lbltransactions = new System.Windows.Forms.Label();
            this.tpAccountInfo = new System.Windows.Forms.TabPage();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.dgAccountTransactions = new System.Windows.Forms.DataGridView();
            this.cbAccountActive = new System.Windows.Forms.CheckBox();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.dgIncomeSummary = new System.Windows.Forms.DataGridView();
            this.toolbarMain = new System.Windows.Forms.ToolStrip();
            this.btnAddAccount = new System.Windows.Forms.ToolStripButton();
            this.lblType = new System.Windows.Forms.Label();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.tabRetainedEarnings = new System.Windows.Forms.TabPage();
            this.tabBalanceSheet = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.tpChartOfAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChartAccounts)).BeginInit();
            this.tpAccountTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountTypes)).BeginInit();
            this.tpJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJournal)).BeginInit();
            this.tpChanges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChanges)).BeginInit();
            this.tpTrialBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrialBalance)).BeginInit();
            this.tabPosting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnpostedJournalEntryTransactions)).BeginInit();
            this.tpAccountInfo.SuspendLayout();
            this.gbAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountTransactions)).BeginInit();
            this.tabIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIncomeSummary)).BeginInit();
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
            this.tabMain.Controls.Add(this.tpAccountTypes);
            this.tabMain.Controls.Add(this.tpJournal);
            this.tabMain.Controls.Add(this.tpChanges);
            this.tabMain.Controls.Add(this.tpTrialBalance);
            this.tabMain.Controls.Add(this.tabPosting);
            this.tabMain.Controls.Add(this.tpAccountInfo);
            this.tabMain.Controls.Add(this.tabIncome);
            this.tabMain.Controls.Add(this.tabRetainedEarnings);
            this.tabMain.Controls.Add(this.tabBalanceSheet);
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
            this.tpChartOfAccounts.Controls.Add(this.label4);
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
            // tpAccountTypes
            // 
            this.tpAccountTypes.Controls.Add(this.cbAccountType);
            this.tpAccountTypes.Controls.Add(this.lblType);
            this.tpAccountTypes.Controls.Add(this.btnAddAccountType);
            this.tpAccountTypes.Controls.Add(this.cbAccountTypeDebitIsPositive);
            this.tpAccountTypes.Controls.Add(this.label3);
            this.tpAccountTypes.Controls.Add(this.txtAccountTypeDescription);
            this.tpAccountTypes.Controls.Add(this.txtAccountTypeName);
            this.tpAccountTypes.Controls.Add(this.label2);
            this.tpAccountTypes.Controls.Add(this.label1);
            this.tpAccountTypes.Controls.Add(this.dgAccountTypes);
            this.tpAccountTypes.Location = new System.Drawing.Point(124, 4);
            this.tpAccountTypes.Name = "tpAccountTypes";
            this.tpAccountTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccountTypes.Size = new System.Drawing.Size(759, 426);
            this.tpAccountTypes.TabIndex = 1;
            this.tpAccountTypes.Text = "Types";
            this.tpAccountTypes.UseVisualStyleBackColor = true;
            // 
            // btnAddAccountType
            // 
            this.btnAddAccountType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAccountType.Location = new System.Drawing.Point(664, 2);
            this.btnAddAccountType.Name = "btnAddAccountType";
            this.btnAddAccountType.Size = new System.Drawing.Size(89, 23);
            this.btnAddAccountType.TabIndex = 8;
            this.btnAddAccountType.Text = "Add";
            this.btnAddAccountType.UseVisualStyleBackColor = true;
            this.btnAddAccountType.Click += new System.EventHandler(this.btnAddAccountType_Click);
            // 
            // cbAccountTypeDebitIsPositive
            // 
            this.cbAccountTypeDebitIsPositive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAccountTypeDebitIsPositive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountTypeDebitIsPositive.FormattingEnabled = true;
            this.cbAccountTypeDebitIsPositive.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.cbAccountTypeDebitIsPositive.Location = new System.Drawing.Point(515, 4);
            this.cbAccountTypeDebitIsPositive.Name = "cbAccountTypeDebitIsPositive";
            this.cbAccountTypeDebitIsPositive.Size = new System.Drawing.Size(143, 21);
            this.cbAccountTypeDebitIsPositive.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Positive Side";
            // 
            // txtAccountTypeDescription
            // 
            this.txtAccountTypeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountTypeDescription.Location = new System.Drawing.Point(73, 30);
            this.txtAccountTypeDescription.Name = "txtAccountTypeDescription";
            this.txtAccountTypeDescription.Size = new System.Drawing.Size(678, 20);
            this.txtAccountTypeDescription.TabIndex = 4;
            // 
            // txtAccountTypeName
            // 
            this.txtAccountTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountTypeName.Location = new System.Drawing.Point(48, 4);
            this.txtAccountTypeName.Name = "txtAccountTypeName";
            this.txtAccountTypeName.Size = new System.Drawing.Size(159, 20);
            this.txtAccountTypeName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
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
            this.dgAccountTypes.Location = new System.Drawing.Point(3, 56);
            this.dgAccountTypes.MultiSelect = false;
            this.dgAccountTypes.Name = "dgAccountTypes";
            this.dgAccountTypes.ReadOnly = true;
            this.dgAccountTypes.RowHeadersVisible = false;
            this.dgAccountTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccountTypes.Size = new System.Drawing.Size(753, 367);
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
            this.tpTrialBalance.Controls.Add(this.dgTrialBalance);
            this.tpTrialBalance.Location = new System.Drawing.Point(124, 4);
            this.tpTrialBalance.Name = "tpTrialBalance";
            this.tpTrialBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrialBalance.Size = new System.Drawing.Size(759, 426);
            this.tpTrialBalance.TabIndex = 5;
            this.tpTrialBalance.Text = "Trial Balance";
            this.tpTrialBalance.UseVisualStyleBackColor = true;
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
            this.dgTrialBalance.Location = new System.Drawing.Point(3, 3);
            this.dgTrialBalance.MultiSelect = false;
            this.dgTrialBalance.Name = "dgTrialBalance";
            this.dgTrialBalance.ReadOnly = true;
            this.dgTrialBalance.RowHeadersVisible = false;
            this.dgTrialBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTrialBalance.Size = new System.Drawing.Size(753, 423);
            this.dgTrialBalance.TabIndex = 0;
            // 
            // tabPosting
            // 
            this.tabPosting.Controls.Add(this.btnAddJournalEntry);
            this.tabPosting.Controls.Add(this.btnRemoveTransaction);
            this.tabPosting.Controls.Add(this.lblNotes);
            this.tabPosting.Controls.Add(this.btnPostTransaction);
            this.tabPosting.Controls.Add(this.txtNotes);
            this.tabPosting.Controls.Add(this.lblTransactionDetails);
            this.tabPosting.Controls.Add(this.dgUnpostedJournalEntryTransactions);
            this.tabPosting.Controls.Add(this.lbUnpostedList);
            this.tabPosting.Controls.Add(this.lbltransactions);
            this.tabPosting.Location = new System.Drawing.Point(124, 4);
            this.tabPosting.Name = "tabPosting";
            this.tabPosting.Size = new System.Drawing.Size(759, 426);
            this.tabPosting.TabIndex = 6;
            this.tabPosting.Text = "Posting";
            this.tabPosting.UseVisualStyleBackColor = true;
            // 
            // btnAddJournalEntry
            // 
            this.btnAddJournalEntry.Location = new System.Drawing.Point(6, 395);
            this.btnAddJournalEntry.Name = "btnAddJournalEntry";
            this.btnAddJournalEntry.Size = new System.Drawing.Size(197, 23);
            this.btnAddJournalEntry.TabIndex = 8;
            this.btnAddJournalEntry.Text = "Add Journal Entry";
            this.btnAddJournalEntry.UseVisualStyleBackColor = true;
            this.btnAddJournalEntry.Click += new System.EventHandler(this.btnAddJournalEntry_Click);
            // 
            // btnRemoveTransaction
            // 
            this.btnRemoveTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTransaction.Enabled = false;
            this.btnRemoveTransaction.Location = new System.Drawing.Point(510, 395);
            this.btnRemoveTransaction.Name = "btnRemoveTransaction";
            this.btnRemoveTransaction.Size = new System.Drawing.Size(123, 23);
            this.btnRemoveTransaction.TabIndex = 7;
            this.btnRemoveTransaction.Text = "Delete";
            this.btnRemoveTransaction.UseVisualStyleBackColor = true;
            this.btnRemoveTransaction.Click += new System.EventHandler(this.btnRemoveTransaction_Click);
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
            // btnPostTransaction
            // 
            this.btnPostTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPostTransaction.Enabled = false;
            this.btnPostTransaction.Location = new System.Drawing.Point(639, 395);
            this.btnPostTransaction.Name = "btnPostTransaction";
            this.btnPostTransaction.Size = new System.Drawing.Size(117, 23);
            this.btnPostTransaction.TabIndex = 5;
            this.btnPostTransaction.Text = "Post";
            this.btnPostTransaction.UseVisualStyleBackColor = true;
            this.btnPostTransaction.Click += new System.EventHandler(this.btnPostTransaction_Click);
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
            this.lblTransactionDetails.Location = new System.Drawing.Point(206, 2);
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
            this.dgUnpostedJournalEntryTransactions.Location = new System.Drawing.Point(209, 18);
            this.dgUnpostedJournalEntryTransactions.Name = "dgUnpostedJournalEntryTransactions";
            this.dgUnpostedJournalEntryTransactions.RowHeadersVisible = false;
            this.dgUnpostedJournalEntryTransactions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgUnpostedJournalEntryTransactions.Size = new System.Drawing.Size(547, 233);
            this.dgUnpostedJournalEntryTransactions.TabIndex = 2;
            // 
            // lbUnpostedList
            // 
            this.lbUnpostedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUnpostedList.FormattingEnabled = true;
            this.lbUnpostedList.Location = new System.Drawing.Point(3, 18);
            this.lbUnpostedList.Name = "lbUnpostedList";
            this.lbUnpostedList.Size = new System.Drawing.Size(200, 368);
            this.lbUnpostedList.TabIndex = 1;
            this.lbUnpostedList.SelectedIndexChanged += new System.EventHandler(this.lbUnpostedList_SelectedIndexChanged);
            // 
            // lbltransactions
            // 
            this.lbltransactions.AutoSize = true;
            this.lbltransactions.Location = new System.Drawing.Point(3, 2);
            this.lbltransactions.Name = "lbltransactions";
            this.lbltransactions.Size = new System.Drawing.Size(125, 13);
            this.lbltransactions.TabIndex = 0;
            this.lbltransactions.Text = "Unposted Journal Entries";
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
            // btnDeleteAccount
            // 
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
            this.lblBalance.Location = new System.Drawing.Point(225, 20);
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
            // 
            // cbAccountActive
            // 
            this.cbAccountActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.dgIncomeSummary);
            this.tabIncome.Location = new System.Drawing.Point(124, 4);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Size = new System.Drawing.Size(759, 426);
            this.tabIncome.TabIndex = 7;
            this.tabIncome.Text = "Income Statement";
            this.tabIncome.UseVisualStyleBackColor = true;
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
            this.dgIncomeSummary.Location = new System.Drawing.Point(3, 3);
            this.dgIncomeSummary.MultiSelect = false;
            this.dgIncomeSummary.Name = "dgIncomeSummary";
            this.dgIncomeSummary.RowHeadersVisible = false;
            this.dgIncomeSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIncomeSummary.Size = new System.Drawing.Size(753, 420);
            this.dgIncomeSummary.TabIndex = 0;
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
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(214, 7);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
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
            this.cbAccountType.Location = new System.Drawing.Point(252, 7);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(183, 21);
            this.cbAccountType.TabIndex = 10;
            // 
            // tabRetainedEarnings
            // 
            this.tabRetainedEarnings.Location = new System.Drawing.Point(124, 4);
            this.tabRetainedEarnings.Name = "tabRetainedEarnings";
            this.tabRetainedEarnings.Size = new System.Drawing.Size(759, 426);
            this.tabRetainedEarnings.TabIndex = 8;
            this.tabRetainedEarnings.Text = "Retained Earnings";
            this.tabRetainedEarnings.UseVisualStyleBackColor = true;
            // 
            // tabBalanceSheet
            // 
            this.tabBalanceSheet.Location = new System.Drawing.Point(124, 4);
            this.tabBalanceSheet.Name = "tabBalanceSheet";
            this.tabBalanceSheet.Size = new System.Drawing.Size(759, 426);
            this.tabBalanceSheet.TabIndex = 9;
            this.tabBalanceSheet.Text = "Balance Sheet";
            this.tabBalanceSheet.UseVisualStyleBackColor = true;
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
            this.tpAccountTypes.ResumeLayout(false);
            this.tpAccountTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountTypes)).EndInit();
            this.tpJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgJournal)).EndInit();
            this.tpChanges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChanges)).EndInit();
            this.tpTrialBalance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrialBalance)).EndInit();
            this.tabPosting.ResumeLayout(false);
            this.tabPosting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUnpostedJournalEntryTransactions)).EndInit();
            this.tpAccountInfo.ResumeLayout(false);
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccountTransactions)).EndInit();
            this.tabIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgIncomeSummary)).EndInit();
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
		private System.Windows.Forms.TabPage tpChanges;
		private System.Windows.Forms.DataGridView dgChanges;
        private System.Windows.Forms.TabPage tpJournal;
		private System.Windows.Forms.DataGridView dgJournal;
		private System.Windows.Forms.ComboBox cbxTypes;
		private System.Windows.Forms.Label lblAccountTypes;
		private System.Windows.Forms.TextBox txtAccountName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.DataGridView dgAccountTransactions;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.TabPage tpTrialBalance;
        private System.Windows.Forms.DataGridView dgTrialBalance;
        private System.Windows.Forms.TabPage tabPosting;
        private System.Windows.Forms.Button btnRemoveTransaction;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnPostTransaction;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblTransactionDetails;
        private System.Windows.Forms.DataGridView dgUnpostedJournalEntryTransactions;
        private System.Windows.Forms.ListBox lbUnpostedList;
		private System.Windows.Forms.Label lbltransactions;
		private System.Windows.Forms.Button btnAddJournalEntry;
		private System.Windows.Forms.TextBox txtAccountTypeDescription;
		private System.Windows.Forms.TextBox txtAccountTypeName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddAccountType;
		private System.Windows.Forms.ComboBox cbAccountTypeDebitIsPositive;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripButton btnAddAccount;
		private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.TabPage tabIncome;
        private System.Windows.Forms.DataGridView dgIncomeSummary;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TabPage tabRetainedEarnings;
        private System.Windows.Forms.TabPage tabBalanceSheet;

	}
}


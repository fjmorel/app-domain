using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_Domain {

	/// <summary>
	/// Main window of the application
	/// </summary>
	public partial class Mainwin : Form {

		/// <summary>
		/// Used to set up columns in dgv when no transactions are loaded
		/// </summary>
		private DataTable EmptyTransactionTable;

		/// <summary>
		/// Constructor
		/// </summary>
		public Mainwin() { InitializeComponent(); }

		/// <summary>
		/// Initialize some stuff
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Mainwin_Load(object sender, EventArgs e) {
			cbSortBy.SelectedIndex = 0;
			cbAccountType.SelectedIndex = 0;
			numAccountNumber.Maximum = decimal.MaxValue;
			lvJournalEntries.MultiSelect = false;
			tabMain.TabPages.Remove(tpAccountDetails);

			//Style datagridviews
			DataGridViewCellStyle cs = new DataGridViewCellStyle();
			cs.BackColor = Color.LightCyan;
			dgChartAccounts.AlternatingRowsDefaultCellStyle = cs;
			dgAccountTransactions.AlternatingRowsDefaultCellStyle = cs;
			dgAccountTypes.AlternatingRowsDefaultCellStyle = cs;
			dgChanges.AlternatingRowsDefaultCellStyle = cs;
			dgJournal.AlternatingRowsDefaultCellStyle = cs;
			dgTrialBalance.AlternatingRowsDefaultCellStyle = cs;
			dgUnpostedJournalEntryTransactions.AlternatingRowsDefaultCellStyle = cs;
			dgIncomeSummary.AlternatingRowsDefaultCellStyle = cs;
			dgBalanceSheet.AlternatingRowsDefaultCellStyle = cs;
			//Add vertical scrollbar
			dgChartAccounts.ScrollBars = ScrollBars.Vertical;
			dgAccountTransactions.ScrollBars = ScrollBars.Vertical;
			dgAccountTypes.ScrollBars = ScrollBars.Vertical;
			dgChanges.ScrollBars = ScrollBars.Vertical;
			dgJournal.ScrollBars = ScrollBars.Vertical;
			dgTrialBalance.ScrollBars = ScrollBars.Vertical;
			dgIncomeSummary.ScrollBars = ScrollBars.Vertical;

			//setup unposted datagridview - need columns to be able to resize them
			EmptyTransactionTable = new DataTable();
			EmptyTransactionTable.Columns.Add("Account");
			EmptyTransactionTable.Columns.Add("Description");
			EmptyTransactionTable.Columns.Add("Debit");
			EmptyTransactionTable.Columns.Add("Credit");
			dgUnpostedJournalEntryTransactions.DataSource = EmptyTransactionTable;

			cbAccountType.SelectedIndex = 0;
			//Cheated to make sure accounts show up by selecting types tab first
			tabMain.SelectTab(tpAllAccountTypes);
			tabMain.SelectTab(tpAllAccounts);

		}

		/// <summary>
		/// Refill datagridview when selecting a tab
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabMain_SelectedIndexChanged(object sender, EventArgs e) {
			if (tabMain.SelectedTab == tpAllAccounts) {
				OnFillAccountCharts();
			} else if (tabMain.SelectedTab == tpAccountDetails) {
				//do nothing
			} else if (tabMain.SelectedTab == tpAllAccountTypes) {
				OnFillAccountTypes();
			} else if (tabMain.SelectedTab == tpAllTransactions) {
				OnFillTransactions();
			} else if (tabMain.SelectedTab == tpAllChanges) {
				OnFillAccountChanges();
			} else if (tabMain.SelectedTab == tpTrialBalance) {
				OnFillTrialBalance();
			} else if (tabMain.SelectedTab == tpAllJournalEntries) {
				OnFillJournalEntries();
			} else if (tabMain.SelectedTab == tpIncomeStatement) {
				OnFillIncomeSummary();
			} else if (tabMain.SelectedTab == tpBalanceSheet) {
				OnFillBalance();
			}
			resizeDataColumns();
		}

		/// <summary>
		/// Resize columns upon resizing
		/// </summary>
		private void resizeDataColumns() {
			if (tabMain.SelectedTab == tpAllAccounts) {
				dgChartAccounts.Columns[0].Width = 120;
				dgChartAccounts.Columns[2].Width = 80;
				dgChartAccounts.Columns[3].Width = 200;
				dgChartAccounts.Columns[1].Width = dgChartAccounts.Width - dgChartAccounts.Columns[0].Width - dgChartAccounts.Columns[2].Width - dgChartAccounts.Columns[3].Width - 20;
			} else if (tabMain.SelectedTab == tpAccountDetails) {
				dgAccountTransactions.Columns[0].Width = 80;
				dgAccountTransactions.Columns[2].Width = 120;
				dgAccountTransactions.Columns[3].Width = 120;
				dgAccountTransactions.Columns[1].Width = dgAccountTransactions.Width - dgAccountTransactions.Columns[3].Width - dgAccountTransactions.Columns[2].Width - dgAccountTransactions.Columns[0].Width;
			} else if (tabMain.SelectedTab == tpAllAccountTypes) {
				dgAccountTypes.Columns[0].Width = 160;
				dgAccountTypes.Columns[2].Width = 120;
				dgAccountTypes.Columns[1].Width = dgAccountTypes.Width - dgAccountTypes.Columns[0].Width - dgAccountTypes.Columns[2].Width - 20;
			} else if (tabMain.SelectedTab == tpAllTransactions) {
				dgJournal.Columns[0].Width = 80;
				dgJournal.Columns[1].Width = 80;
				dgJournal.Columns[3].Width = 120;
				dgJournal.Columns[4].Width = 120;
				dgJournal.Columns[5].Width = 150;
				dgJournal.Columns[2].Width = dgJournal.Width - dgJournal.Columns[0].Width - dgJournal.Columns[1].Width - dgJournal.Columns[3].Width - dgJournal.Columns[4].Width - dgJournal.Columns[5].Width;
			} else if (tabMain.SelectedTab == tpAllChanges) {
				dgChanges.Columns[0].Width = 120;
				dgChanges.Columns[2].Width = 120;
				dgChanges.Columns[3].Width = 150;
				dgChanges.Columns[1].Width = dgChanges.Width - dgChanges.Columns[0].Width - dgChanges.Columns[2].Width - dgChanges.Columns[3].Width;
			} else if (tabMain.SelectedTab == tpTrialBalance) {
				dgTrialBalance.Columns[0].Width = 120;
				dgTrialBalance.Columns[2].Width = 120;
				dgTrialBalance.Columns[3].Width = 120;
				dgTrialBalance.Columns[1].Width = dgTrialBalance.Width - dgTrialBalance.Columns[0].Width - dgTrialBalance.Columns[2].Width - dgTrialBalance.Columns[3].Width - 20;
			} else if (tabMain.SelectedTab == tpAllJournalEntries) {
				dgUnpostedJournalEntryTransactions.Columns[0].Width = 120;
				dgUnpostedJournalEntryTransactions.Columns[2].Width = 100;
				dgUnpostedJournalEntryTransactions.Columns[3].Width = 100;
				dgUnpostedJournalEntryTransactions.Columns[1].Width = dgUnpostedJournalEntryTransactions.Width - dgUnpostedJournalEntryTransactions.Columns[0].Width - dgUnpostedJournalEntryTransactions.Columns[2].Width - dgUnpostedJournalEntryTransactions.Columns[3].Width;
			} else if (tabMain.SelectedTab == tpIncomeStatement) {
				dgIncomeSummary.Columns[0].Width = 100;
				dgIncomeSummary.Columns[2].Width = 100;
				dgIncomeSummary.Columns[3].Width = 100;
				dgIncomeSummary.Columns[1].Width = dgIncomeSummary.Width - dgIncomeSummary.Columns[0].Width - dgIncomeSummary.Columns[2].Width - dgIncomeSummary.Columns[3].Width;
			} else if (tabMain.SelectedTab == tpBalanceSheet) {
				dgBalanceSheet.Columns[0].Width = 120;
				dgBalanceSheet.Columns[2].Width = 120;
				dgBalanceSheet.Columns[3].Width = 120;
				dgBalanceSheet.Columns[1].Width = dgBalanceSheet.Width - dgBalanceSheet.Columns[0].Width - dgBalanceSheet.Columns[2].Width - dgBalanceSheet.Columns[3].Width - 20;
			}
		}

		/// <summary>
		/// Close application
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Mainwin_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}

		/// <summary>
		/// Refresh chart of accounts based upon filters
		/// </summary>
		public void OnFillAccountCharts() {
			if (cbxTypes.SelectedIndex > -1 && cbSortBy.SelectedIndex > -1) {
				bool care = false;
				bool act = false;
				int type = cbxTypes.SelectedIndex;
				if (!(cbSortBy.SelectedIndex == 0)) {
					care = true;//Active or Inactive selected
					act = cbSortBy.SelectedIndex == 1 ? true : false;//If active selected, true, otherwise false
				}
				dgChartAccounts.DataSource = Program.sqlcon.GetFilteredChartOfAccounts(care, act, type, txtAccountName.Text);
			}

			dgChartAccounts.ClearSelection();
		}

		/// <summary>
		/// Refresh account types
		/// </summary>
		public void OnFillAccountTypes() {
			dgAccountTypes.DataSource = Program.sqlcon.GetAccountTypes();
			dgAccountTypes.ClearSelection();

			//Populate account type dropdown on chart of accounts view
			cbxTypes.Items.Clear();
			cbxTypes.Items.Add("All");
			foreach (String each in Program.sqlcon.GetAccountTypesList())
				cbxTypes.Items.Add(each);
			cbxTypes.SelectedIndex = 0;
		}

		/// <summary>
		/// Refresh trial balance
		/// </summary>
		public void OnFillTrialBalance() {
			dgTrialBalance.DataSource = Program.sqlcon.GetTrialBalance();
		}

		/// <summary>
		/// Refresh balance sheet
		/// </summary>
		public void OnFillBalance() {
			dgBalanceSheet.DataSource = Program.sqlcon.GetBalance();
		}

		/// <summary>
		/// Refresh ratio reports
		/// </summary>
		public void OnFillRatios() {
			double assests = Program.sqlcon.GetAccountTypeTotal(0);
			double liabilities = Program.sqlcon.GetAccountTypeTotal(1);
			double equity = Program.sqlcon.GetAccountTypeTotal(4);
			double revenue = Program.sqlcon.GetAccountTypeTotal(3);
			double expenses = Program.sqlcon.GetAccountTypeTotal(2);
			double ratio;

			if (liabilities != 0) {
				ratio = Math.Round(Math.Abs(assests / liabilities), 2);
				txtCurRatio.Text = ratio.ToString();
			} else {
				txtCurRatio.Text = "Zero liabilities";
			}

		}

		/// <summary>
		/// Refresh journal entries
		/// </summary>
		public void OnFillJournalEntries() {
			lvJournalEntries.Items.Clear();
			DataTable dt = Program.sqlcon.GetUnpostedJournalEntries();
			tpAllJournalEntries.Text = "Journal Entries";
			if (dt != null) {
				if (dt.Rows.Count > 0) {
					tpAllJournalEntries.Text += " (" + dt.Rows.Count + ")";//Show # of unposted entries
					btnPostAllJournalEntries.Enabled = true;
				}

				foreach (DataRow each in dt.Rows) {
					ListViewItem item = new ListViewItem(new string[] { each["id"].ToString(), each["postdate"].ToString() }, lvJournalEntries.Groups["Unposted"]);
					item.Name = each["id"].ToString();//Necessary to look up Journal Entry by key later
					lvJournalEntries.Items.Add(item);
				}
			}
			dt = null;
			dt = Program.sqlcon.GetDeletedJournalEntries();
			if (dt != null) {
				foreach (DataRow each in dt.Rows) {
					ListViewItem item = new ListViewItem(new string[] { each["id"].ToString(), each["postdate"].ToString() }, lvJournalEntries.Groups["Deleted"]);
					item.Name = each["id"].ToString();//Necessary to look up Journal Entry by key later
					lvJournalEntries.Items.Add(item);
				}
			}
			dt = null;
			dt = Program.sqlcon.GetPostedJournalEntries();
			if (dt != null) {
				foreach (DataRow each in dt.Rows) {
					ListViewItem item = new ListViewItem(new string[] { each["id"].ToString(), each["postdate"].ToString() }, lvJournalEntries.Groups["Posted"]);
					item.Name = each["id"].ToString();//Necessary to look up Journal Entry by key later
					lvJournalEntries.Items.Add(item);
				}
			}

			if (lvJournalEntries.Groups["Unposted"].Items.Count == 0)
				btnPostAllJournalEntries.Enabled = false;
			else
				btnPostAllJournalEntries.Enabled = true;
		}

		/// <summary>
		/// Refresh income statement
		/// </summary>
		public void OnFillIncomeSummary() {
			dgIncomeSummary.DataSource = Program.sqlcon.GetIncome();
		}

		/// <summary>
		/// Refresh income, dividends, and retained earnings
		/// </summary>
		public void OnFillRE() {
			double income = Program.sqlcon.GetIncomeDebits() - Program.sqlcon.GetIncomeCredits();
			numDividends.Maximum = (decimal)income;
			txtIncome.Text = income.ToString();
			numDividends_ValueChanged(this, new EventArgs());
		}

		/// <summary>
		/// Refresh account changes dgv
		/// </summary>
		public void OnFillAccountChanges() {
			dgChanges.DataSource = Program.sqlcon.GetAccountChanges();
			dgChanges.ClearSelection();
		}

		/// <summary>
		/// Refresh journal as well as changes, trial balance, and journal entries
		/// </summary>
		public void OnFillTransactions() {
			dgJournal.DataSource = Program.sqlcon.GetJournal();
			dgJournal.ClearSelection();
		}

		/// <summary>
		/// Show a specific accounts' transaction in the info tab
		/// </summary>
		/// <param name="accountnum"></param>
		private void OnFillAccountTransactions(int accountnum) {
			dgAccountTransactions.DataSource = Program.sqlcon.GetAccountLedger(accountnum);
			dgAccountTransactions.ClearSelection();
			lblBalance.Text = String.Format("Balance: {0:C}", Program.sqlcon.GetAccountBalance(accountnum));
		}

		/// <summary>
		/// Filter chart of accounts by active status
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChartOfAccounts_FilterChanged(object sender, EventArgs e) { OnFillAccountCharts(); }

		/// <summary>
		/// Select an account to view information
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgChartAccounts_DoubleClick(object sender, EventArgs e) {
			if (dgChartAccounts.SelectedRows.Count > 0) {
				DataTable dt = Program.sqlcon.GetAccountByNumber(Convert.ToInt32(dgChartAccounts.SelectedRows[0].Cells[0].Value.ToString()));

				if (dt != null && dt.Rows.Count > 0) {
					//Show name in groupbox
					gbAccount.Text = dt.Rows[0]["accountnum"] + " - " + dt.Rows[0]["descript"];
					//Show account's transactions
					OnFillAccountTransactions(Convert.ToInt32(dt.Rows[0]["accountnum"]));
					//Show active status and only allow changes if balance is 0
					int active = Convert.ToInt32(dt.Rows[0]["active"]);
					cbAccountActive.CheckedChanged -= cbAccountActive_CheckedChanged;//So loading the state is added as a change
					cbAccountActive.Checked = active == 1 ? true : false;//If active == 1, check the txtAccounts
					cbAccountActive.CheckedChanged += cbAccountActive_CheckedChanged;//So changes to it will be added as a change
					numAccountNumber.Value = Convert.ToDecimal(dt.Rows[0]["accountnum"]);
					if (Program.sqlcon.GetAccountBalance(Convert.ToInt32(dt.Rows[0]["accountnum"])) != 0)
						cbAccountActive.Enabled = false;
					else
						cbAccountActive.Enabled = true;
					DataTable isEmpty = Program.sqlcon.GetAccountLedger(Convert.ToInt32(dt.Rows[0]["accountnum"]));
					if (isEmpty != null && isEmpty.Rows.Count < 1)
						btnDeleteAccount.Visible = true;
					else
						btnDeleteAccount.Visible = false;
					//Show tab
					if (!tabMain.TabPages.Contains(tpAccountDetails)) {
						tabMain.TabPages.Insert(1, tpAccountDetails);
					}
					tabMain.SelectedTab = tpAccountDetails;
				}
				dgChartAccounts.ClearSelection();
			}
		}

		/// <summary>
		/// Draw tabs
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabMain_DrawItem(object sender, DrawItemEventArgs e) {
			Graphics g = e.Graphics;
			Brush _textBrush;

			// Get the item from the collection.
			TabPage _tabPage = tabMain.TabPages[e.Index];

			// Get the real bounds for the tab rectangle.
			Rectangle _tabBounds = tabMain.GetTabRect(e.Index);

			// Get font
			Font _tabFont = _tabPage.Font;


			if (e.State == DrawItemState.Selected) {
				// Draw a different background color, and don't paint a focus rectangle.
				_textBrush = new SolidBrush(Color.White);
				g.FillRectangle(Brushes.Gray, e.Bounds);
			} else {
				_textBrush = new System.Drawing.SolidBrush(e.ForeColor);
				e.DrawBackground();
			}

			// Draw string. Center the text.
			StringFormat _stringFlags = new StringFormat();
			_stringFlags.Alignment = StringAlignment.Center;
			_stringFlags.LineAlignment = StringAlignment.Center;
			g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
		}

		/// <summary>
		/// Change active status of an account
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbAccountActive_CheckedChanged(object sender, EventArgs e) {
			int i = Convert.ToInt32(gbAccount.Text.IndexOf(" "));
			Program.sqlcon.ChangeAccountStatusByNumber(Convert.ToInt32(gbAccount.Text.Substring(0, i)), cbAccountActive.Checked);
			OnFillAccountCharts();
		}

		/// <summary>
		/// Enable delete/post buttons as needed when different journal entries are selected. Load JE data into tab
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lvJournalEntries_SelectedIndexChanged(object sender, EventArgs e) {
			//Make sure something selected
			if (lvJournalEntries.SelectedItems.Count > 0) {
				//Pull info about journal entry into datagridview and textbox
				int refnum = Convert.ToInt32(lvJournalEntries.SelectedItems[0].Text);
				dgUnpostedJournalEntryTransactions.DataSource = Program.sqlcon.GetJournalEntryTransactions(refnum);
				txtNotes.Text = Program.sqlcon.GetJournalEntryNote(refnum);
				//enable buttons as needed
				dgUnpostedJournalEntryTransactions.Sort(dgUnpostedJournalEntryTransactions.Columns[2], System.ComponentModel.ListSortDirection.Descending);
				if (lvJournalEntries.SelectedItems[0].Group == lvJournalEntries.Groups["Unposted"]) {
					btnPostJournalEntry.Enabled = true;
					btnDeleteJournalEntry.Enabled = true;
				} else if (lvJournalEntries.SelectedItems[0].Group == lvJournalEntries.Groups["Posted"]) {
					btnPostJournalEntry.Enabled = false;
					btnDeleteJournalEntry.Enabled = false;
				} else if (lvJournalEntries.SelectedItems[0].Group == lvJournalEntries.Groups["Deleted"]) {
					btnPostJournalEntry.Enabled = true;
					btnDeleteJournalEntry.Enabled = false;
				}
			}
		}

		/// <summary>
		/// Post selected journal entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPostJournalEntry_Click(object sender, EventArgs e) {
			//make sure something is selected still
			if (lvJournalEntries.SelectedItems.Count > 0) {
				int refnum = Convert.ToInt32(lvJournalEntries.SelectedItems[0].Text);
				Program.sqlcon.PostJournalEntry(refnum);
				btnPostJournalEntry.Enabled = false;
				btnDeleteJournalEntry.Enabled = false;
				//Refresh
				OnFillJournalEntries();
				dgUnpostedJournalEntryTransactions.DataSource = EmptyTransactionTable;
			}
		}

		/// <summary>
		/// Delete selected journal entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeleteJournalEntry_Click(object sender, EventArgs e) {
			//make sure something is selected still
			if (lvJournalEntries.SelectedItems.Count > 0) {
				int refnum = Convert.ToInt32(lvJournalEntries.SelectedItems[0].Text);
				Program.sqlcon.DeleteJournalEntry(refnum);
				btnPostJournalEntry.Enabled = false;
				btnDeleteJournalEntry.Enabled = false;
				//Refresh
				OnFillJournalEntries();
				dgUnpostedJournalEntryTransactions.DataSource = EmptyTransactionTable;
			}
		}

		/// <summary>
		/// Post all unposted journal entries that are not deleted
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnPostAllJournalEntries_Click(object sender, EventArgs e) {
			foreach (ListViewItem each in lvJournalEntries.Groups["Unposted"].Items) {
				Program.sqlcon.PostJournalEntry(Convert.ToInt32(each.Text));
			}
			btnPostAllJournalEntries.Enabled = false;
			btnDeleteAccount.Enabled = false;
			btnPostJournalEntry.Enabled = false;
			//Refresh
			OnFillJournalEntries();
			dgUnpostedJournalEntryTransactions.DataSource = EmptyTransactionTable;
		}

		/// <summary>
		/// Add journal entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAddJournalEntry_Click(object sender, EventArgs e) {
			new frmAddJournalEntry().ShowDialog();
			tabMain.SelectTab(tabMain.SelectedTab);
			OnFillJournalEntries();
		}

		/// <summary>
		/// Create a new account type
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAddAccountType_Click(object sender, EventArgs e) {
			if (txtAccountTypeName.Text != "" && txtAccountTypeDescription.Text != "") {
				DataTable dt = Program.sqlcon.GetAccountTypeByName(txtAccountTypeName.Text);
				if (dt != null && dt.Rows.Count < 1) {//Check for existing type of that name
					//Account type type now dictates whether debit is positive or not
					bool debitIsPositive = cbAccountType.SelectedItem.ToString().Equals("Asset") || cbAccountType.SelectedItem.ToString().Equals("Expense") ? true : false;
					Program.sqlcon.AddAccountType(txtAccountTypeName.Text, txtAccountTypeDescription.Text, debitIsPositive, cbAccountType.SelectedIndex);
					OnFillAccountTypes();
				} else {
					MessageBox.Show("This account type already exists. Please enter something else.");
				}
			} else
				MessageBox.Show("Please enter a name and description for this new account type.");
		}

		/// <summary>
		/// Delete an account (only available when account has no transactions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeleteAccount_Click(object sender, EventArgs e) {
			//Delete Account
			int i = Convert.ToInt32(gbAccount.Text.IndexOf(" "));
			Program.sqlcon.DeleteAccount(Convert.ToInt32(gbAccount.Text.Substring(0, i)));
			OnFillAccountCharts();
			//Go back to main and hide tab
			tabMain.SelectTab(tpAllAccounts);
			tabMain.TabPages.Remove(tpAccountDetails);
		}

		/// <summary>
		/// Update displayed numbers for dividends and retained earnings
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void numDividends_ValueChanged(object sender, EventArgs e) {
			double income = Convert.ToDouble(txtIncome.Text);
			double dividends = (double)numDividends.Value;
			txtRE.Text = (income - dividends).ToString();
		}

		/// <summary>
		/// Update displayed numbers for dividends and retained earnings
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void numDividends_Leave(object sender, EventArgs e) {
			numDividends_ValueChanged(this, new EventArgs());
		}

		/// <summary>
		/// Save dividends
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSaveRE_Click(object sender, EventArgs e) {
			Program.sqlcon.SetRE(Convert.ToDouble(txtRE.Text));
			Program.sqlcon.SetDividends((double)numDividends.Value);
		}

		/// <summary>
		/// Double-clicking a transaction pulls up the relevant journal entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgAccountTransactions_DoubleClick(object sender, EventArgs e) {
			if (dgAccountTransactions.SelectedRows.Count > 0) {
				string refnum = dgAccountTransactions.SelectedRows[0].Cells[0].Value.ToString();
				tabMain.SelectTab(tpAllJournalEntries);
				if (lvJournalEntries.Items[refnum] != null) {
					lvJournalEntries.Items[refnum].Selected = true;
					lvJournalEntries.Items[refnum].EnsureVisible();
				}
				lvJournalEntries.Select();
			}
		}

		/// <summary>
		/// Double-clicking a transaction pulls up the relevant journal entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgJournal_DoubleClick(object sender, EventArgs e) {
			if (dgJournal.SelectedRows.Count > 0) {
				string refnum = dgJournal.SelectedRows[0].Cells[0].Value.ToString();
				tabMain.SelectTab(tpAllJournalEntries);
				if (lvJournalEntries.Items[refnum] != null) {
					lvJournalEntries.Items[refnum].Selected = true;
					lvJournalEntries.Items[refnum].EnsureVisible();
				}
				lvJournalEntries.Select();
			}
		}

		/// <summary>
		/// Try to update the number of an account
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdateAccountNumber_Click(object sender, EventArgs e) {
			//Check the number's not taken
			if (Program.sqlcon.GetAccountByNumber(Convert.ToInt32(numAccountNumber.Value)).Rows.Count < 1) {
				int i = Convert.ToInt32(gbAccount.Text.IndexOf(" "));
				Program.sqlcon.ChangeAccountNumberByNumber(Convert.ToInt32(gbAccount.Text.Substring(0, i)), Convert.ToInt32(numAccountNumber.Value));
				gbAccount.Text = numAccountNumber.Value.ToString() + gbAccount.Text.Substring(i);
			} else {
				MessageBox.Show("This number is already taken. Please try another.");
			}
		}

		/// <summary>
		/// Resize colummns when window changes size
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Mainwin_Resize(object sender, EventArgs e) {
			resizeDataColumns();
		}

		private void btnNewAccount_Click(object sender, EventArgs e) {
			new AddAccount().ShowDialog();
			tabMain.SelectTab(tabMain.SelectedTab);
		}

	}//end Mainwin class
}//end namespace

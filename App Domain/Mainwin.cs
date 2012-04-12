using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_Domain {
	public partial class Mainwin : Form {

		private DataTable UnpostedEntriesDT;

		public Mainwin() { InitializeComponent(); }

		private void Mainwin_Load(object sender, EventArgs e) {
			cbSortBy.SelectedIndex = 0;
			cbAccountType.SelectedIndex = 0;
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
			//Add vertical scrollbar
			dgChartAccounts.ScrollBars = ScrollBars.Vertical;
			dgAccountTransactions.ScrollBars = ScrollBars.Vertical;
			dgAccountTypes.ScrollBars = ScrollBars.Vertical;
			dgChanges.ScrollBars = ScrollBars.Vertical;
			dgJournal.ScrollBars = ScrollBars.Vertical;
			dgTrialBalance.ScrollBars = ScrollBars.Vertical;
            dgIncomeSummary.ScrollBars = ScrollBars.Vertical;

			//Populate datagridviews
			OnFillAccountCharts();
			OnFillAccountTypes();
			OnFillTransactions();//will refresh changes and trial balance
			OnFillUnpostedJournalEntries();
            OnFillIncomeSummary();
            OnFillRE();

			//Resize columns of main window
			tabMain_SelectedIndexChanged(this, new EventArgs());

			//setup unposted datagridview - need columns to be able to resize them
			UnpostedEntriesDT = new DataTable();
			UnpostedEntriesDT.Columns.Add("Account");
			UnpostedEntriesDT.Columns.Add("Description");
			UnpostedEntriesDT.Columns.Add("Debit");
			UnpostedEntriesDT.Columns.Add("Credit");
			dgUnpostedJournalEntryTransactions.DataSource = UnpostedEntriesDT;

            cbAccountType.SelectedIndex = 0;

		}

		/// <summary>
		/// Clear Account Search tab when tabbing away
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabMain_SelectedIndexChanged(object sender, EventArgs e) {
			if (tabMain.SelectedTab == tpAllAccounts) {
				dgChartAccounts.Columns[0].Width = 120;
				dgChartAccounts.Columns[2].Width = 80;
				dgChartAccounts.Columns[3].Width = 200;
				dgChartAccounts.Columns[1].Width = dgChartAccounts.Width - dgChartAccounts.Columns[0].Width - dgChartAccounts.Columns[2].Width - dgChartAccounts.Columns[3].Width - 20;
			} else if (tabMain.SelectedTab == tpAccountDetails) {
				dgAccountTransactions.Columns[1].Width = 120;
				dgAccountTransactions.Columns[2].Width = 120;
				dgAccountTransactions.Columns[0].Width = dgAccountTransactions.Width - dgAccountTransactions.Columns[2].Width - dgAccountTransactions.Columns[1].Width;
			} else if (tabMain.SelectedTab == tpAllAccountTypes) {
				dgAccountTypes.Columns[0].Width = 120;
				dgAccountTypes.Columns[2].Width = 120;
				dgAccountTypes.Columns[1].Width = dgAccountTypes.Width - dgAccountTypes.Columns[0].Width - dgAccountTypes.Columns[2].Width - 20;
			} else if (tabMain.SelectedTab == tpAllTransactions) {
				dgJournal.Columns[0].Width = 120;
				dgJournal.Columns[2].Width = 120;
				dgJournal.Columns[3].Width = 120;
				dgJournal.Columns[4].Width = 150;
				dgJournal.Columns[1].Width = dgJournal.Width - dgJournal.Columns[0].Width - dgJournal.Columns[2].Width - dgJournal.Columns[3].Width - dgJournal.Columns[4].Width;
			} else if (tabMain.SelectedTab == tpAllChanges) {
				dgChanges.Columns[0].Width = 120;
				dgChanges.Columns[2].Width = 120;
				dgChanges.Columns[3].Width = 150;
				dgChanges.Columns[1].Width = dgChanges.Width - dgChanges.Columns[0].Width - dgChanges.Columns[2].Width - dgChanges.Columns[3].Width;
			} else if (tabMain.SelectedTab == tpTrialBalance) {
				dgTrialBalance.Columns[0].Width = 120;
				dgTrialBalance.Columns[2].Width = 120;
				dgTrialBalance.Columns[3].Width = 120;
				dgTrialBalance.Columns[1].Width = dgTrialBalance.Width - dgTrialBalance.Columns[0].Width - dgTrialBalance.Columns[2].Width - dgTrialBalance.Columns[3].Width;
			} else if (tabMain.SelectedTab == tpAllJournalEntries) {
				dgUnpostedJournalEntryTransactions.Columns[0].Width = 120;
				dgUnpostedJournalEntryTransactions.Columns[2].Width = 100;
				dgUnpostedJournalEntryTransactions.Columns[3].Width = 100;
				dgUnpostedJournalEntryTransactions.Columns[1].Width = dgUnpostedJournalEntryTransactions.Width - dgUnpostedJournalEntryTransactions.Columns[0].Width - dgUnpostedJournalEntryTransactions.Columns[2].Width - dgUnpostedJournalEntryTransactions.Columns[3].Width;
            }
            else if (tabMain.SelectedTab == tpIncomeStatement)
            {
                dgIncomeSummary.Columns[0].Width = 100;
                dgIncomeSummary.Columns[2].Width = 100;
                dgIncomeSummary.Columns[3].Width = 100;
                dgIncomeSummary.Columns[1].Width = dgIncomeSummary.Width - dgIncomeSummary.Columns[0].Width - dgIncomeSummary.Columns[2].Width - dgIncomeSummary.Columns[3].Width;
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

		public void OnFillTrialBalance() {
			dgTrialBalance.DataSource = Program.sqlcon.GetTrialBalance();
		}

		public void OnFillUnpostedJournalEntries() {
			List<string> items = Program.sqlcon.GetListOfUnpostedJournalEntries();
			lbUnpostedList.Items.Clear();
			foreach (string item in items) {
				lbUnpostedList.Items.Add(item);
			}
		}

        public void OnFillIncomeSummary()
        {
            dgIncomeSummary.DataSource = Program.sqlcon.GetIncome();
        }

        public void OnFillRE()
        {
            double income = Program.sqlcon.GetIncomeDebits() - Program.sqlcon.GetIncomeCredits();
            numDividends.Maximum = (decimal)income;
            txtIncome.Text = income.ToString();
            numDividends_ValueChanged(this, new EventArgs());
        }

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
			OnFillAccountChanges();
			OnFillTrialBalance();
			OnFillUnpostedJournalEntries();
            OnFillIncomeSummary();
		}

		/// <summary>
		/// Show a specific accounts' transaction in the info tab
		/// </summary>
		/// <param name="accountnum"></param>
		private void OnFillAccountTransactions(int accountnum) {
			//TODO: Ref number for journal entry
			dgAccountTransactions.DataSource = Program.sqlcon.GetAccountLedger(accountnum);
			dgAccountTransactions.ClearSelection();
			double balance;
			if (Program.sqlcon.IsDebitThePositiveSide(accountnum) == 1)
				balance = Program.sqlcon.GetAccountDebitTotal(accountnum) - Program.sqlcon.GetAccountCreditTotal(accountnum);
			else
				balance = Program.sqlcon.GetAccountCreditTotal(accountnum) - Program.sqlcon.GetAccountDebitTotal(accountnum);

			lblBalance.Text = String.Format("Balance: {0:C}", balance);
		}

		/// <summary>
		/// Filter chart of accounts by active status
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChartOfAccounts_FilterChanged(object sender, EventArgs e) { OnFillAccountCharts(); }

		/// <summary>
		/// Add account
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void miAddAccount_Click(object sender, EventArgs e) {
			new AddAccount(this.OnFillAccountCharts, this.OnFillAccountChanges).ShowDialog();
		}

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

		private void cbAccountActive_CheckedChanged(object sender, EventArgs e) {
			int i = Convert.ToInt32(gbAccount.Text.IndexOf(" "));
			Program.sqlcon.ChangeAccountStatusByNumber(Convert.ToInt32(gbAccount.Text.Substring(0, i)), cbAccountActive.Checked);
			OnFillAccountCharts();
		}

		private void lbUnpostedList_SelectedIndexChanged(object sender, EventArgs e) {
			string item = (string)lbUnpostedList.SelectedItem;
			int refnum;
			if (item != null) {
				string[] split = item.Split(' ');
				refnum = Convert.ToInt32(split[split.Length - 1]);
				dgUnpostedJournalEntryTransactions.DataSource = Program.sqlcon.GetUnpostedJournalEntryTransactions(refnum);
				txtNotes.Text = Program.sqlcon.GetJournalEntryNote(refnum);
				tabMain_SelectedIndexChanged(this, new EventArgs());
				btnPostTransaction.Enabled = true;
				btnRemoveTransaction.Enabled = true;
			}
		}

		private void btnPostTransaction_Click(object sender, EventArgs e) {
			string item = (string)lbUnpostedList.SelectedItem;
			if (item != null) {
				string[] split = item.Split(' ');
				int refnum = Convert.ToInt32(split[split.Length - 1]);
				Program.sqlcon.PostJournalEntry(refnum);
				btnPostTransaction.Enabled = false;
				btnRemoveTransaction.Enabled = false;
				OnFillTransactions();
				dgUnpostedJournalEntryTransactions.DataSource = UnpostedEntriesDT;
				tabMain_SelectedIndexChanged(this, new EventArgs());
			}
		}

		private void btnRemoveTransaction_Click(object sender, EventArgs e) {
			string item = (string)lbUnpostedList.SelectedItem;
			int refnum;
			if (item != null) {
				string[] split = item.Split(' ');
				refnum = Convert.ToInt32(split[split.Length - 1]);
				Program.sqlcon.DeleteJournalEntry(refnum);
				btnPostTransaction.Enabled = false;
				btnRemoveTransaction.Enabled = false;
				OnFillTransactions();
				dgUnpostedJournalEntryTransactions.DataSource = UnpostedEntriesDT;
				tabMain_SelectedIndexChanged(this, new EventArgs());
			}
		}

		/// <summary>
		/// Add journal entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAddJournalEntry_Click(object sender, EventArgs e) {
			new frmAddJournalEntry(this.OnFillTransactions).ShowDialog();
		}

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

		private void btnDeleteAccount_Click(object sender, EventArgs e) {
			//Delete Account
			int i = Convert.ToInt32(gbAccount.Text.IndexOf(" "));
			Program.sqlcon.DeleteAccount(Convert.ToInt32(gbAccount.Text.Substring(0, i)));
			OnFillAccountCharts();
			//Go back to main and hide tab
			tabMain.SelectTab(tpAllAccounts);
			tabMain.TabPages.Remove(tpAccountDetails);
		}

        private void numDividends_ValueChanged(object sender, EventArgs e)
        {
            double income = Convert.ToDouble(txtIncome.Text);
            double dividends = (double)numDividends.Value;
            txtRE.Text = (income - dividends).ToString();
        }

        private void numDividends_Leave(object sender, EventArgs e)
        {
            numDividends_ValueChanged(this, new EventArgs());
        }

        private void btnSaveRE_Click(object sender, EventArgs e)
        {
            Program.sqlcon.SetRE(Convert.ToDouble(txtRE.Text));
            Program.sqlcon.SetDividends((double)numDividends.Value);
        }

	}//end Mainwin class
}//end namespace

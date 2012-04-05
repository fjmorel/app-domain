using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_Domain {
	public partial class Mainwin : Form {

		public Mainwin() { InitializeComponent(); }

		private void Mainwin_Load(object sender, EventArgs e) {
			cbSortBy.SelectedIndex = 0;
			tabMain.TabPages.Remove(tpAccountInfo);

			//Create SQL connection
			//Program.sqlcon = new SQL();

			//Style datagridviews
			DataGridViewCellStyle cs = new DataGridViewCellStyle();
			cs.BackColor = Color.LightBlue;
			dgChartAccounts.AlternatingRowsDefaultCellStyle = cs;
			dgAccountTransactions.AlternatingRowsDefaultCellStyle = cs;
			dgAccountTypes.AlternatingRowsDefaultCellStyle = cs;
			dgChanges.AlternatingRowsDefaultCellStyle = cs;
			dgJournal.AlternatingRowsDefaultCellStyle = cs;
			dgTrialBalance.AlternatingRowsDefaultCellStyle = cs;
			//Add vertical scrollbar
			dgChartAccounts.ScrollBars = ScrollBars.Vertical;
			dgAccountTransactions.ScrollBars = ScrollBars.Vertical;
			dgAccountTypes.ScrollBars = ScrollBars.Vertical;
			dgChanges.ScrollBars = ScrollBars.Vertical;
			dgJournal.ScrollBars = ScrollBars.Vertical;
			dgTrialBalance.ScrollBars = ScrollBars.Vertical;

			//Populate datagridviews
			OnFillAccountCharts();
			OnFillAccountTypes();
			OnFillJournal();//will refresh changes and trial balance

			//Resize columns of main window
			tabMain_SelectedIndexChanged(this, new EventArgs());
			
		}

		/// <summary>
		/// Clear Account Search tab when tabbing away
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabMain_SelectedIndexChanged(object sender, EventArgs e) {
			if (tabMain.SelectedTab == tpChartOfAccounts) {
				dgChartAccounts.Columns[0].Width = 120;
				dgChartAccounts.Columns[2].Width = 80;
				dgChartAccounts.Columns[3].Width = 200;
				dgChartAccounts.Columns[1].Width = dgChartAccounts.Width - dgChartAccounts.Columns[0].Width - dgChartAccounts.Columns[2].Width - dgChartAccounts.Columns[3].Width;
			} else if (tabMain.SelectedTab == tpAccountInfo) {
				dgAccountTransactions.Columns[1].Width = 120;
				dgAccountTransactions.Columns[2].Width = 120;
				dgAccountTransactions.Columns[0].Width = dgAccountTransactions.Width - dgAccountTransactions.Columns[2].Width - dgAccountTransactions.Columns[1].Width;
			} else if (tabMain.SelectedTab == tpAccountTypes) {
				dgAccountTypes.Columns[0].Width = 120;
				dgAccountTypes.Columns[2].Width = 120;
				dgAccountTypes.Columns[1].Width = dgAccountTypes.Width - dgAccountTypes.Columns[0].Width - dgAccountTypes.Columns[2].Width;
			} else if (tabMain.SelectedTab == tpJournal) {
				dgJournal.Columns[0].Width = 120;
				dgJournal.Columns[2].Width = 120;
				dgJournal.Columns[3].Width = 120;
				dgJournal.Columns[4].Width = 150;
				dgJournal.Columns[1].Width = dgJournal.Width - dgJournal.Columns[0].Width - dgJournal.Columns[2].Width - dgJournal.Columns[3].Width - dgJournal.Columns[4].Width;
			} else if (tabMain.SelectedTab == tpChanges) {
				dgChanges.Columns[0].Width = 120;
				dgChanges.Columns[2].Width = 120;
				dgChanges.Columns[3].Width = 150;
				dgChanges.Columns[1].Width = dgChanges.Width - dgChanges.Columns[0].Width - dgChanges.Columns[2].Width - dgChanges.Columns[3].Width;
			} else if (tabMain.SelectedTab == tpTrialBalance) {
				dgTrialBalance.Columns[0].Width = 120;
				dgTrialBalance.Columns[2].Width = 120;
				dgTrialBalance.Columns[3].Width = 120;
				dgTrialBalance.Columns[1].Width = dgTrialBalance.Width - dgTrialBalance.Columns[0].Width - dgTrialBalance.Columns[2].Width - dgChanges.Columns[3].Width;
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
				OnFillAccountChanges();//Needed for some reason. I think it's when we add or edit an account. It was the only way I could of to call this.
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
			foreach(String each in Program.sqlcon.GetAccountTypesList())
				cbxTypes.Items.Add(each);
			cbxTypes.SelectedIndex = 0;
		}

		public void OnFillTrialBalance() {
			dgTrialBalance.DataSource = Program.sqlcon.GetTrialBalance();
			lblTotalCredit.Text = "Total Credits: " + String.Format("{0:C}",Program.sqlcon.getTotalCredit());
			lblTotalDebit.Text = "Total Debits: " + String.Format("{0:C}",Program.sqlcon.getTotalDebit());
		}

		public void OnFillAccountChanges() {
			dgChanges.DataSource = Program.sqlcon.GetAccountChanges();
			dgChanges.ClearSelection();
		}

		/// <summary>
		/// Refresh journal as well as changes and trial balance
		/// </summary>
		public void OnFillJournal() {
			dgJournal.DataSource = Program.sqlcon.GetJournal();
			dgJournal.ClearSelection();
			OnFillAccountChanges();
			OnFillTrialBalance();
		}

		private void OnFillAccountTransactions(int accountnum) {
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
		private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e) { OnFillAccountCharts(); }
		/// <summary>
		/// Filter chart of accounts by account type
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbxTypes_SelectedIndexChanged(object sender, EventArgs e) { OnFillAccountCharts(); }
		/// <summary>
		/// Filter chart of accounts by account name
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtAccountName_TextChanged(object sender, EventArgs e) { OnFillAccountCharts(); }

		/// <summary>
		/// Add account
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void miAddAccount_Click(object sender, EventArgs e) {
			new AddAccount(this.OnFillAccountCharts).ShowDialog();
		}

		/// <summary>
		/// Add account type
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void miAddAccountType_Click(object sender, EventArgs e) {
			new AddAccountType(this.OnFillAccountTypes).ShowDialog();
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
					//Show tab
					if (!tabMain.TabPages.Contains(tpAccountInfo)) {
						tabMain.TabPages.Insert(1, tpAccountInfo);
					}
					tabMain.SelectedTab = tpAccountInfo;
				}
				dgChartAccounts.ClearSelection();
			}
		}

		/// <summary>
		/// Add journal entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addJournalEntryToolStripMenuItem_Click(object sender, EventArgs e) {
			new frmAddJournalEntry(this.OnFillJournal).ShowDialog();
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

	}//end Mainwin class
}//end namespace

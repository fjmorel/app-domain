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

			//Create SQL connection
			Program.sqlcon = new SQL();
			
			//Populate datagridviews
			OnFillAccountTypes();
			OnFillAccountCharts();
			OnFillAccountChanges();
			OnFillJournal();
			OnFillTrialBalance();

			DataGridViewCellStyle cs = new DataGridViewCellStyle();
			cs.BackColor = Color.LightBlue;
			dgAccountTypes.AlternatingRowsDefaultCellStyle = cs;
			dgChartAccounts.AlternatingRowsDefaultCellStyle = cs;
			dgAccountChanges.AlternatingRowsDefaultCellStyle = cs;
			dgJournal.AlternatingRowsDefaultCellStyle = cs;
			dgvAccountLedger.AlternatingRowsDefaultCellStyle = cs;
			dgAccountTypes.ScrollBars = ScrollBars.Vertical;
			dgChartAccounts.ScrollBars = ScrollBars.Vertical;
			dgAccountChanges.ScrollBars = ScrollBars.Vertical;
			dgJournal.ScrollBars = ScrollBars.Vertical;
			dgvAccountLedger.ScrollBars = ScrollBars.Vertical;

			Mainwin_Resize(this, new EventArgs());
			tabMain.SelectedIndexChanged += new EventHandler(tabMain_SelectedIndexChanged);
			tabMain.TabPages.Remove(tpAccountInfo);
		}

		/// <summary>
		/// Clear Account Search tab when tabbing away
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tabMain_SelectedIndexChanged(object sender, EventArgs e) {
			//if (tabMain.SelectedTab != tpAccountInfo) {
				//tabMain.TabPages.Remove(tpAccountInfo);
			//}
			if (tabMain.SelectedTab == tabTrialBalance) {
				
			}
		}


		private void Mainwin_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}

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

		public void OnFillAccountTypes() {
			dgAccountTypes.DataSource = Program.sqlcon.GetAccountTypes();
			dgAccountTypes.ClearSelection();

			//Populate account type dropdown
			cbxTypes.Items.Clear();
			cbxTypes.Items.Add("All");
			List<AccountType> at = Program.sqlcon.GetAccountTypesList();
			foreach (AccountType each in at)
				cbxTypes.Items.Add(each.ToString());
			cbxTypes.SelectedIndex = 0;
		}

		public void OnFillTrialBalance() {
			dgTrialBalance.DataSource = Program.sqlcon.GetTrialBalance();
		}

		public void OnFillAccountChanges() {
			dgAccountChanges.DataSource = Program.sqlcon.GetAccountChanges();
			dgAccountChanges.ClearSelection();
		}

		public void OnFillJournal() {
			dgJournal.DataSource = Program.sqlcon.GetJournal();
			dgJournal.ClearSelection();
			OnFillAccountChanges();
		}

		private void FillLedger(int accountnum) {
			dgvAccountLedger.DataSource = Program.sqlcon.GetAccountLedger(accountnum);
			dgvAccountLedger.ClearSelection();
			int balance = Program.sqlcon.GetAccountDebitTotal(accountnum) - Program.sqlcon.GetAccountCreditTotal(accountnum);
			lblBalance.Text = "Balance: ";
			if(balance > 0){lblBalance.Text+= balance.ToString() + " on the debit side";}
			else if (balance < 0) { lblBalance.Text += (balance*-1).ToString() + " on the credit side"; }
			else if (balance == 0) { lblBalance.Text += "0"; }
		}

		private void Mainwin_Resize(object sender, EventArgs e) {
			int temp;

			dgChartAccounts.Columns[0].Width = 120;
			dgChartAccounts.Columns[2].Width = 100;
			dgChartAccounts.Columns[3].Width = 100;
			dgChartAccounts.Columns[4].Width = 120;
			temp = dgChartAccounts.Width - dgChartAccounts.Columns[0].Width - dgChartAccounts.Columns[2].Width - dgChartAccounts.Columns[3].Width - dgChartAccounts.Columns[4].Width;
			dgChartAccounts.Columns[1].Width = temp < 100 ? 100 : temp;//100+ only

			dgAccountTypes.Columns[0].Width = 120;
			dgAccountTypes.Columns[2].Width = 120;
			temp = dgAccountTypes.Width - dgAccountTypes.Columns[0].Width - dgAccountTypes.Columns[2].Width;
			dgAccountTypes.Columns[1].Width = temp < 120 ? 120 : temp;

			dgAccountChanges.Columns[0].Width = 120;
			dgAccountChanges.Columns[2].Width = 120;
			dgAccountChanges.Columns[3].Width = 150;
			temp = dgAccountChanges.Width - dgAccountChanges.Columns[0].Width - dgAccountChanges.Columns[2].Width - dgAccountChanges.Columns[3].Width;
			dgAccountChanges.Columns[1].Width = temp < 120 ? 120 : temp;

			dgJournal.Columns[0].Width = 120;
			dgJournal.Columns[2].Width = 120;
			dgJournal.Columns[3].Width = 120;
			dgJournal.Columns[4].Width = 150;
			temp = dgJournal.Width - dgJournal.Columns[0].Width - dgJournal.Columns[2].Width - dgJournal.Columns[3].Width - dgJournal.Columns[4].Width;
			dgJournal.Columns[1].Width = temp < 120 ? 120 : temp;

			if (this.Width < 550) {
				dgChartAccounts.ScrollBars = ScrollBars.Both;
				dgAccountTypes.ScrollBars = ScrollBars.Both;
				dgAccountChanges.ScrollBars = ScrollBars.Both;
				dgJournal.ScrollBars = ScrollBars.Both;
				dgvAccountLedger.ScrollBars = ScrollBars.Both;

			} else {
				dgChartAccounts.ScrollBars = ScrollBars.Vertical;
				dgAccountTypes.ScrollBars = ScrollBars.Vertical;
				dgAccountChanges.ScrollBars = ScrollBars.Vertical;
				dgJournal.ScrollBars = ScrollBars.Vertical;
				dgvAccountLedger.ScrollBars = ScrollBars.Vertical;
			}
		}

		private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e) {
			OnFillAccountCharts();
		}

		private void bSave_Click(object sender, EventArgs e) {
			int i = Convert.ToInt32(gbAccount.Text.IndexOf(" "));
			Program.sqlcon.ChangeAccountStatusByNumber(Convert.ToInt32(gbAccount.Text.Substring(0, i)), cbAccountActive.Checked);
			OnFillAccountCharts();
		}

		private void miAddAccount_Click(object sender, EventArgs e) {
			new AddAccount(this.OnFillAccountCharts).ShowDialog();
		}

		private void miAddAccountType_Click(object sender, EventArgs e) {
			new AddAccountType(this.OnFillAccountTypes).ShowDialog();
		}

		private void dgChartAccounts_DoubleClick(object sender, EventArgs e) {
			if (dgChartAccounts.SelectedRows.Count > 0) {
				DataTable dt = Program.sqlcon.GetAccountByNumber(Convert.ToInt32(dgChartAccounts.SelectedRows[0].Cells[0].Value.ToString()));

				if (dt != null || dt.Rows.Count > 0) {
					int active = Convert.ToInt32(dt.Rows[0]["active"]);
					cbAccountActive.Enabled = true;
					cbAccountActive.Checked = active == 1 ? true : false;//If active == 1, check the txtAccounts
					gbAccount.Text = dt.Rows[0]["accountnum"].ToString() + " - " + dt.Rows[0]["descript"].ToString();
					FillLedger(Convert.ToInt32(dt.Rows[0]["accountnum"]));
					if (!tabMain.TabPages.Contains(tpAccountInfo)) {
						tabMain.TabPages.Insert(1, tpAccountInfo);
					}
					tabMain.SelectedTab = tpAccountInfo;
					int temp = 0;
					dgvAccountLedger.Columns[0].Width = 120;
					dgvAccountLedger.Columns[2].Width = 120;
					dgvAccountLedger.Columns[3].Width = 120;
					dgvAccountLedger.Columns[4].Width = 150;
					temp = dgvAccountLedger.Width - dgvAccountLedger.Columns[0].Width - dgvAccountLedger.Columns[2].Width - dgvAccountLedger.Columns[3].Width - dgvAccountLedger.Columns[4].Width;
					dgvAccountLedger.Columns[1].Width = temp < 120 ? 120 : temp;
				}
				dgChartAccounts.ClearSelection();
			}
		}

		private void addJournalEntryToolStripMenuItem_Click(object sender, EventArgs e) {
			new frmAddJournalEntry(this.OnFillJournal,this.OnFillTrialBalance).ShowDialog();
		}

		private void cbxTypes_SelectedIndexChanged(object sender, EventArgs e) {
			OnFillAccountCharts();
		}

		private void txtAccountName_TextChanged(object sender, EventArgs e) {
			OnFillAccountCharts();
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

	}//end Mainwin class
}//end namespace

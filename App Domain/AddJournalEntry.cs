using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Domain {
	public partial class frmAddJournalEntry : Form {
		private event FillJournalHandler FillJournal;
		private event FillTrialBalanceHandler FillTB;
		private JournalEntry je = new JournalEntry();
		private DataTable entries = new DataTable();

		public frmAddJournalEntry(FillJournalHandler callback, FillTrialBalanceHandler callback2) {
			InitializeComponent();
			this.FillJournal += callback;
			this.FillTB += callback2;
			

			List<Account> accounts = Program.sqlcon.GetFilteredAccountList(true, true, 0);//Active accounts of all types
			List<string> activeAccounts = new List<string>();
			foreach (Account each in accounts)
				activeAccounts.Add(each.ToString());
			txtAccount.entireList = activeAccounts;

			entries.Columns.Add("Account Number", typeof(int));
			entries.Columns.Add("Description", typeof(string));
			entries.Columns.Add("Debit", typeof(double));
			entries.Columns.Add("Credit", typeof(double));
			dgEntries.DataSource = entries;

			cbTransType.SelectedIndex = 0;
		}

		private void bCancel_Click(object sender, EventArgs e) {
			FillJournal();
			this.Close();
		}

		private void bAdd_Click(object sender, EventArgs e) {
			try {
				int i = Convert.ToInt32(txtAccount.Text.IndexOf(" "));
				Account temp = new Account(Convert.ToInt32(txtAccount.Text.Substring(0, i)), txtAccount.Text.Substring(i + 3, txtAccount.Text.Length - i - 3));
				bool isDebitNotCredit = cbTransType.SelectedIndex == 0 ? true : false;
				je.AddEntry(temp.AccountNumber, temp.AccountDescription, Convert.ToDouble(txtAmmount.Text), isDebitNotCredit);
				updateEntries();
			} catch {
				MessageBox.Show("I couldn't add the transaction. Make sure you've picked an account and typed an amount.");
			}
		}

		private void updateEntries() {
			entries.Clear();

			foreach (Entry ent in je.Transactions) {
				entries.Rows.Add(ent.AccountNumber, ent.Description, (ent.IsDebitNotCredit) ? ent.Amount : 0, (!ent.IsDebitNotCredit) ? ent.Amount : 0);
			}
		}

		private void bPost_Click(object sender, EventArgs e) {
			double debits = 0;
			double credits = 0;
			je.time = dateTimePicker1.Value;

			foreach (Entry ent in je.Transactions) {
				debits += (ent.IsDebitNotCredit) ? ent.Amount : 0;
				credits += (!ent.IsDebitNotCredit) ? ent.Amount : 0;
			}

			if (debits > credits) {
				MessageBox.Show("Debits are higher than credits by $" + (debits - credits).ToString());
			} else if (debits < credits) {
				MessageBox.Show("Credits are higher than debits by $" + (debits - credits).ToString());
			} else if (debits == 0 && credits == 0){
				MessageBox.Show("No money is being debited or credited. Please enter transactions before posting.");
			} else {
				Program.sqlcon.PostJournalEntry(je);
				FillJournal();
				FillTB();
				this.Close();
			}
		}
	}
}

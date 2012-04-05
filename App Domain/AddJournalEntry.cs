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
		private JournalEntry je = new JournalEntry();
		private DataTable entries;
		private double debits = 0;
		private double credits = 0;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="callback"></param>
		/// <param name="callback2"></param>
		public frmAddJournalEntry(FillJournalHandler callback) {
			InitializeComponent();
			this.FillJournal += callback;
			this.KeyDown += new KeyEventHandler(frmAddJournalEntry_KeyDown);

			//Add all active accounts as strings to the autocomplete textbox
			foreach (Account each in Program.sqlcon.GetFilteredAccountList(true, true, 0))
				txtAccount.entireList.Add(each.ToString());

			//Style datagridview
			DataGridViewCellStyle cs = new DataGridViewCellStyle();
			cs.BackColor = Color.LightBlue;
			dgEntries.AlternatingRowsDefaultCellStyle = cs;
			dgEntries.ScrollBars = ScrollBars.Vertical;
			//Set up columns for datagridview			
			entries = new DataTable();
			entries.Columns.Add("Account", typeof(int));
			entries.Columns.Add("Description", typeof(string));
			entries.Columns.Add("Debit", typeof(string));
			entries.Columns.Add("Credit", typeof(string));
			dgEntries.DataSource = entries;
			dgEntries.Columns[0].Width = 100;
			dgEntries.Columns[2].Width = 100;
			dgEntries.Columns[3].Width = 100;
			dgEntries.Columns[1].Width = dgEntries.Width - dgEntries.Columns[0].Width - dgEntries.Columns[2].Width - dgEntries.Columns[3].Width;

			dateTransaction.Value = DateTime.Now;
			numAmount.Maximum = Decimal.MaxValue;
			cbTransType.SelectedIndex = 0;
		}

		/// <summary>
		/// Process Enter and Escape keys properly
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void frmAddJournalEntry_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				if (this.Focused || dgEntries.Focused) {//Form or datagrid is focused, post Journal Entry
					bPost.PerformClick();
				} else if (cbTransType.Focused || numAmount.Focused) {//Fields are focused, add transaction to Journal Entry
					bAdd.PerformClick();
				}
			} else if (e.KeyCode == Keys.Escape) {
				if (this.Focused || dgEntries.Focused) {//Pressing cancel when fields don't have focus
					bCancel.PerformClick();
				}
			}
		}

		/// <summary>
		/// Cancel adding journal entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bCancel_Click(object sender, EventArgs e) { this.Close(); }

		/// <summary>
		/// Add transaction to Journal Entry
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bAdd_Click(object sender, EventArgs e) {
			try {
				int i = Convert.ToInt32(txtAccount.Text.IndexOf(" "));
				Account temp = new Account(Convert.ToInt32(txtAccount.Text.Substring(0, i)), txtAccount.Text.Substring(i + 3, txtAccount.Text.Length - i - 3));
				double amount = (double)numAmount.Value;
				bool transIsDebit = cbTransType.SelectedIndex == 0 ? true : false;
				bool accountIsDebit = Program.sqlcon.IsDebitThePositiveSide(temp.AccountNumber) == 1 ? true : false;
				bool fine = false;
				if (accountIsDebit == transIsDebit)
					fine = true;
				else if (accountIsDebit && !transIsDebit)
					fine = Program.sqlcon.GetAccountBalance(temp.AccountNumber) - amount > 0 ? true : false;
				else if (!accountIsDebit && transIsDebit)
					fine = Program.sqlcon.GetAccountBalance(temp.AccountNumber) + amount < 0 ? true : false;

				if (!fine) {//Confirm the user wants to continue if the transaction brings balance below 0.
					DialogResult result = MessageBox.Show("This transaction would bring the account below 0. Continue anyway?", "cap", MessageBoxButtons.YesNo);
					if(result.Equals(DialogResult.Yes))
						fine = true;
				}

				if (fine) {//Add transaction if everything's fine
					je.AddEntry(temp.AccountNumber, temp.AccountDescription, amount, transIsDebit);
					Entry ent = je.Transactions[je.Transactions.Count - 1];
					if (transIsDebit)
						debits += amount;
					else
						credits += amount;
					entries.Rows.Add(ent.AccountNumber, ent.Description, (ent.IsDebitNotCredit) ? String.Format("{0:C}", ent.Amount) : "", (!ent.IsDebitNotCredit) ? String.Format("{0:C}", ent.Amount) : "");
					txtAccount.Clear();
					bPost.Enabled = true;
					dgEntries.Focus();
				}
			} catch {
				MessageBox.Show("I couldn't add the transaction. Make sure you've picked an account and typed an amount.");
			}
		}

		/// <summary>
		/// Save Journal Entry and update tables in main window
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bPost_Click(object sender, EventArgs e) {

			if (debits > credits) {
				MessageBox.Show("Debits are higher than credits by $" + (debits - credits));
			} else if (debits < credits) {
				MessageBox.Show("Credits are higher than debits by $" + (credits - debits));
			} else if (debits == 0 && credits == 0) {
				MessageBox.Show("No money is being debited or credited. Please enter transactions before posting.");
			} else {
				Program.sqlcon.PostJournalEntry(je);
				FillJournal();
				this.Close();
			}
		}

		private void dateTransaction_ValueChanged(object sender, EventArgs e) {
			je.time = dateTransaction.Value;
		}
	}
}

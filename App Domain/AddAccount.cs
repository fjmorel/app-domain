using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Domain {
	public partial class AddAccount : Form {

		private event FillChartOfAccountsHandler FillAccount;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="callback"></param>
		public AddAccount(FillChartOfAccountsHandler callback) {
			InitializeComponent();

			List<AccountType> list = Program.sqlcon.GetAccountTypesList();
			List<string> strings = new List<string>();
			foreach (AccountType each in list)
				strings.Add(each.Name);
			txtType.entireList = strings;

			this.FillAccount += callback;
			this.KeyDown += new KeyEventHandler(AddAccount_KeyDown);
		}

		void AddAccount_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
					bAdd.PerformClick();
			}
		}

		/// <summary>
		/// Initialize account types dropdown
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddAccount_Load(object sender, EventArgs e) {
			//cbType.Items.AddRange(Program.sqlcon.GetAccountTypesList().ToArray());
			//cbType.SelectedIndex = 0;
		}

		/// <summary>
		/// Add account to database
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bAdd_Click(object sender, EventArgs e) {
			//if the fields are not empty
			if (txtAccountnum.Text != "" && txtDescription.Text != "" && txtType.Text != "") {
				//if this isn't a duplicate
				DataTable dt = Program.sqlcon.GetAccountByNumber(Convert.ToInt32(txtAccountnum.Text));
				if (dt != null && dt.Rows.Count < 1) {
					//if it has a valid account type
					DataTable dt2 = Program.sqlcon.GetAccountTypeByName(txtType.Text);
					if (dt2 != null && dt2.Rows.Count == 1) {
						int active = checkActive.Checked ? 1 : 0;//1 for active, 0 for inactive
						Program.sqlcon.AddAccount(txtDescription.Text, active, Convert.ToInt32(dt2.Rows[0]["id"]), txtOwner.Text, Convert.ToInt32(txtAccountnum.Text));
						FillAccount();
						this.Close();
					} else {
						MessageBox.Show("Please enter a valid account type.");
					}
				} else {
					MessageBox.Show("An account with this number already exists. Please enter a different number.");
				}
			} else {
				MessageBox.Show("Please enter a number, name, and type for this account.");
			}
		}

		/// <summary>
		/// Close form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bCancel_Click(object sender, EventArgs e) { this.Close(); }

		/// <summary>
		/// Prevent letters/symbols from account number
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtAccountnum_KeyPress(object sender, KeyPressEventArgs e) {
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}

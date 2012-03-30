using System;
using System.Data;
using System.Windows.Forms;

namespace App_Domain {
	public partial class AddAccountType : Form {
		private event FillAccountTypesHandler FillAccountTypes;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="callback"></param>
		public AddAccountType(FillAccountTypesHandler callback) {
			InitializeComponent();
			this.FillAccountTypes += callback;
		}

		/// <summary>
		/// Close form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		/// <summary>
		/// Add account type
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bAdd_Click(object sender, EventArgs e) {
			DataTable dt = Program.sqlcon.GetAccountTypeByName(txtName.Text);
			if (dt != null && dt.Rows.Count < 1) {//Check for existing type of that name
				Program.sqlcon.AddAccountType(txtName.Text, txtDescription.Text,optDebit.Checked);
				this.Close();
				FillAccountTypes();
			} else {
				MessageBox.Show("This account type already exists. Please enter something else.");
			}
		}
	}
}

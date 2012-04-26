using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App_Domain {
	public partial class Login : Form {

		/// <summary>
		/// Constructor
		/// </summary>
		public Login() {
			InitializeComponent();
		}

		/// <summary>
		/// Try to login using username and password
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bLogin_Click(object sender, EventArgs e) {
			if (txtUser.Text == "admin" && txtPass.Text == "admin") {
				new Mainwin().Show();
				Hide();
			} else {
				MessageBox.Show("Incorrect Login. Please try again.");
			}
		}

		/// <summary>
		/// Load only valid login ahead of time
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Login_Load(object sender, EventArgs e) {
			txtPass.Text = "admin";
			txtUser.Text = "admin";
		}

		/// <summary>
		/// Forgot password
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e) {
			MessageBox.Show("Right now, it's 'admin'");
		}

	}
}

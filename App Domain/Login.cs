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

		public Login() {
			InitializeComponent();
		}

		private void bLogin_Click(object sender, EventArgs e) {
			if (txtUser.Text == "admin" && txtPass.Text == "admin") {
				new Mainwin().Show();
				Hide();
			} else {
				MessageBox.Show("Incorrect Login. Please try again.");
			}
		}

		private void Login_Load(object sender, EventArgs e) {
			txtPass.Text = "admin";
			txtUser.Text = "admin";
		}

		private void button1_Click(object sender, EventArgs e) {
			MessageBox.Show("Right now, it's 'admin'");
		}

	}
}

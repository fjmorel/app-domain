using System;
using System.Windows.Forms;

namespace App_Domain {

	static class Program {

		/// <summary>
		/// SQL connection for the entire program
		/// </summary>
		public static SQL sqlcon = new SQL("appdomain.sdf", "admin");

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}

		
	}
}

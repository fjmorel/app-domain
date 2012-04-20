using System;
using System.Windows.Forms;

namespace App_Domain {

	static class Program {

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

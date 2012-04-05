using System;
using System.Windows.Forms;

namespace App_Domain {
	public delegate void FillChartOfAccountsHandler();
	public delegate void FillAccountTypesHandler();
    public delegate void FillJournalHandler();
	public delegate void FillChangesHandler();

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

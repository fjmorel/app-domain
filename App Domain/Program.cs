using System;
using System.Windows.Forms;

namespace App_Domain {
	public delegate void FillChartOfAccountsHandler();
	public delegate void FillAccountTypesHandler();
    public delegate void FillJournalHandler();
	public delegate void FillChangesHandler();
	public delegate void FillLedgerHandler();
	public delegate void FillTrialBalanceHandler();

	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}

		public static SQL sqlcon = null;
		public static string databaseName = "App_Domain";
	}
}

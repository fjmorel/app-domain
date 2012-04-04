using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;

namespace App_Domain {

	class SQL {

		private SqlCeConnection con;

		/// <summary>
		/// Constructor with default values (appdomain.sdf in current folder with password "admin")
		/// </summary>
		/// <param name="c">SqlConnection</param>
		public SQL() {
			ConnectToDatabase("appdomain.sdf", "admin");
		}

		/// <summary>
		/// Constructor with custom values for connection
		/// </summary>
		/// <param name="filepath"></param>
		/// <param name="password"></param>
		public SQL(string filepath, string password) {
			ConnectToDatabase(filepath, password);
		}

		/// <summary>
		/// Returns true if successful.
		/// </summary>
		/// <param name="filepath"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		private void ConnectToDatabase(string filepath, string password){
			con = null;
			try {
				con = new SqlCeConnection("Data Source=" + filepath + "; password=" + password);
				Open();
			} catch (Exception ex) {
				MessageBox.Show("Could not connect.");
				Console.WriteLine(ex.Message);
			}
		}


		public int GetAccountBalance(int accountnum) {
			return GetAccountDebitTotal(accountnum) - GetAccountCreditTotal(accountnum);
		}

		public DataTable GetTrialBalance() {
			DataTable accounts;
			DataTable dt = new DataTable();
			dt.Columns.Add("Account Number", typeof(string));
			dt.Columns.Add("Account Description", typeof(string));
			dt.Columns.Add("Debits", typeof(string));
			dt.Columns.Add("Credits", typeof(string));

			string query = "SELECT accountnum, descript FROM Chart_of_Accounts WHERE active = 1";
			accounts = ExecuteQuery(query);

			foreach (DataRow row in accounts.Rows) {
				int accountnum = Convert.ToInt32(row[0].ToString());
				string account = row[1].ToString();
				int ammount = GetAccountBalance(accountnum);
				if (ammount != 0) {
					string debit = ammount > 0 ? Math.Abs(ammount).ToString() : "";
					string credit = ammount < 0 ? Math.Abs(ammount).ToString() : "";
					dt.Rows.Add(accountnum.ToString(), account, debit, credit);
				}
			}

			return dt;
		}


		/// <summary>
		/// Retrieves a subset of all activeAccounts.
		/// </summary>
		/// <param name="careAboutActive">False means get both active and inactive activeAccounts, ignoring bool active</param>
		/// <param name="active">Active = true, Inactive = false</param>
		/// <param name="type">ID of the type of account to get</param>
		/// <param name="name">String wanted in name of activeAccounts</param>
		/// <returns></returns>
		public DataTable GetFilteredChartOfAccounts(bool careAboutActive, bool active, int type, string name) {
			string query = "SELECT ca.accountnum AS [Account Number], ca.descript AS [Description],CASE ca.active WHEN 1 THEN 'Yes' WHEN 0 THEN 'No' END AS [Active], at.name AS [Type] FROM Chart_of_Accounts AS ca " +
				"JOIN Account_Types AS at ON (ca.typeid = at.id)";
			//To get date of account
			//CAST(DATEPART(month, ca.datecreated) AS NVARCHAR(2)) + '-' + CAST(DATEPART(day, ca.datecreated) AS NVARCHAR(2)) + '-' + CAST(DATEPART(year, ca.datecreated) AS NVARCHAR(4)) AS [Created]
			string whereParam = "";
			if (careAboutActive) {//Filter active status only if we care about it
				whereParam += " WHERE ";
				if (active)
					whereParam += "ca.active = 1";
				else
					whereParam += "ca.active = 0";
			}
			if (type > 0) {//filter by id only if index is possible value
				if (whereParam != "")
					whereParam += " AND ";
				else
					whereParam += "WHERE ";
				whereParam += "ca.typeid = " + type.ToString();
			}
			if (!name.Equals("")) {
				if (whereParam != "")
					whereParam += " AND ";
				else
					whereParam += "WHERE ";
				whereParam += "ca.descript LIKE '%" + name + "%' ";
			}

			query += whereParam;

			return ExecuteQuery(query);
		}

		/// <summary>
		/// Gets a list of account types and stores their name in a List<string>
		/// </summary>
		/// <returns> list of AccountTypes</returns>
		public List<String> GetAccountTypesList() {
			List<String> types = new List<String>();
			DataTable accounts = ExecuteQuery("SELECT name FROM Account_Types");
			if (accounts != null) {
				foreach (DataRow row in accounts.Rows) {
					types.Add(row["name"].ToString());
				}
			}
			return types;
		}

		/// <summary>
		/// Gets a list of a subset of activeAccounts
		/// </summary>
		/// <param name="careAboutActive">Whether the second bool is relevant</param>
		/// <param name="active">true = active activeAccounts, false = inactive activeAccounts</param>
		/// <param name="type">ID of the type of activeAccounts to get</param>
		/// <returns>Accounts that match criteria in a list</returns>
		public List<Account> GetFilteredAccountList(bool careAboutActive, bool active, int type) {
			List<Account> accounts = new List<Account>();
			DataTable dt = GetFilteredChartOfAccounts(careAboutActive, active, type,"");

			foreach (DataRow row in dt.Rows) {
				accounts.Add(new Account(Convert.ToInt32(row["Account Number"]), Convert.ToString(row["Description"])));
			}

			return accounts;
		}

		/// <summary>
		/// Gets a DataTable representing account types.
		/// </summary>
		/// <returns></returns>
		public DataTable GetAccountTypes() {
			return ExecuteQuery("SELECT name AS [Name], descript AS [Description], CASE debitispositive WHEN 1 THEN 'Debit' WHEN 0 THEN 'Credit' END AS [Positive Side] FROM Account_Types");
		}

		/// <summary>
		/// Gets changes to activeAccounts from database
		/// </summary>
		/// <returns>DataTable with account changes</returns>
		public DataTable GetAccountChanges() {
			return ExecuteQuery("SELECT ac.accountnumber AS [Account Number], ac.action AS [Action], ac.dateofchange AS [Time of Change], us.name AS [User] FROM Account_Changes AS ac " +
				"JOIN Users AS us ON (ac.userid = us.id)");
		}

		/// <summary>
		/// get a transaction ledger for a specific account
		/// </summary>
		/// <param name="accountnum"></param>
		/// <returns></returns>
		public DataTable GetAccountLedger(int accountnum) {
			return ExecuteQuery("SELECT j.postdate AS [Date], j.dammount AS [Debit Amount], j.cammount AS [Credit Amount] FROM Journal j JOIN Chart_of_Accounts c ON (j.accountnum = c.accountnum) WHERE c.accountnum = " + accountnum);
		}

		/// <summary>
		/// Gets the accountIsDebit total for a specific account
		/// </summary>
		/// <param name="accountnum"></param>
		/// <returns></returns>
		public int GetAccountDebitTotal(int accountnum) {
			string an = Convert.ToString(accountnum);
			DataTable dt = ExecuteQuery("SELECT SUM(j.dammount) FROM Journal j WHERE j.accountnum = " + an);
			if (!dt.Rows[0][0].ToString().Equals(""))//Make sure there's a value
				return Convert.ToInt32(dt.Rows[0][0].ToString());
			else return 0;
		}

		/// <summary>
		/// gets the credit total for a specific account
		/// </summary>
		/// <param name="accountnum"></param>
		/// <returns></returns>
		public int GetAccountCreditTotal(int accountnum) {
			string an = Convert.ToString(accountnum);
			DataTable dt = ExecuteQuery("SELECT SUM(j.cammount) FROM Journal j WHERE j.accountnum = " + an);
			if (!dt.Rows[0][0].ToString().Equals(""))//Make sure there's a value
				return Convert.ToInt32(dt.Rows[0][0].ToString());
			else return 0;
		}

		/// <summary>
		/// Gets a datatable with all journal entries
		/// </summary>
		/// <returns></returns>
		public DataTable GetJournal() {
			return ExecuteQuery("SELECT j.accountnum AS [Account Number], ca.descript AS [Account Description], j.dammount AS [Debit], j.cammount AS [Credit], j.postdate AS [Date Added] FROM Journal as j JOIN Chart_of_Accounts AS ca on (j.accountnum = ca.accountnum)");
		}

		/// <summary>
		/// Get account information from a specific account number
		/// </summary>
		/// <param name="accountnum">account number</param>
		/// <returns>DataTable with a single row or no row if the account does no exists</returns>
		public DataTable GetAccountByNumber(int accountnum) {
			return ExecuteQuery(String.Format("SELECT id, accountnum, active, descript FROM Chart_of_Accounts WHERE accountnum = {0}", accountnum));
		}

		public int getTotalCredit() {
			DataTable dt = ExecuteQuery("SELECT accountnum FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON ca.typeid = at.id WHERE at.debitispositive = 0");
			if (dt == null) { MessageBox.Show("dt is null"); }
			//DataTable dt = ExecuteQuery("SELECT ca.accountnum FROM Chart_of_Accounts");
			int total = 0;
			if (dt != null) {
				foreach (DataRow each in dt.Rows) {
					int a = Convert.ToInt32(each["accountnum"]);
					total += GetAccountCreditTotal(a) - GetAccountDebitTotal(a);
				}
			}
			return total;
		}

		public int getTotalDebit() {
			DataTable dt = ExecuteQuery("SELECT accountnum FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON ca.typeid = at.id WHERE at.debitispositive = 1");
			if (dt == null) { MessageBox.Show("dt is null"); }
			int total = 0;
			if (dt != null) {
				foreach (DataRow each in dt.Rows) {
					int a = Convert.ToInt32(each["accountnum"]);
					total += GetAccountDebitTotal(a) - GetAccountCreditTotal(a);
				}
			}
			return total;
		}

		public int IsDebitThePositiveSide(int accountnum) {
			DataTable dt = ExecuteQuery("SELECT at.debitispositive FROM Account_Types AS at JOIN Chart_of_Accounts AS ca ON ca.typeid = at.id WHERE ca.accountnum = "+accountnum);
			if (dt != null)
				return Convert.ToInt32(dt.Rows[0]["debitispositive"]) == 1 ? 1 : 0;
			return -1;
		}

		/// <summary>
		/// Return DataTable with one row if the name is already in the table
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public DataTable GetAccountTypeByName(string name) {
			return ExecuteQuery("SELECT id, name, descript, debitispositive FROM Account_Types WHERE name LIKE '" + name + "'");
		}

		/// <summary>
		/// Add an account type to the database
		/// </summary>
		/// <param name="name">Account type name</param>
		/// <param name="description">Account type description</param>
		public void AddAccountType(string name, string description, bool debitIsPositive) {
			int debitispositive = debitIsPositive ? 1 : 0;
			ExecuteNonQuery("INSERT INTO Account_Types (name, descript, debitispositive) VALUES('" + name + "','" + description + "', "+ debitispositive +")");
		}

		/// <summary>
		/// Adds an account to the database.
		/// </summary>
		/// <param name="description"></param>
		/// <param name="active"></param>
		/// <param name="typeid"></param>
		/// <param name="owner"></param>
		public void AddAccount(string description, int active, int typeid, string owner, int accountnum) {
			ExecuteNonQuery("INSERT INTO Chart_of_Accounts (descript, active, typeid, datecreated, accountnum) VALUES('" + description + "', '" + active + "', '" + typeid + "', GETDATE(), " + accountnum + ")");
			AddAccountChange(accountnum, "Created account");
		}

		/// <summary>
		/// Add account changes to database (new transaction, status changes, etc)
		/// </summary>
		/// <param name="accountnum"></param>
		/// <param name="action"></param>
		public void AddAccountChange(int accountnum, string action) {
			//TODO: Actual userid, not just 1 for admin
			ExecuteNonQuery("INSERT INTO Account_Changes (accountnumber, action, dateofchange, userid) VALUES('" + accountnum + "', '" + action + "', GETDATE(), '1')");
		}

		/// <summary>
		/// Enters a balanced set of journal entries
		/// </summary>
		/// <param name="j"></param>
		public void PostJournalEntry(JournalEntry journal) {
			foreach (Entry e in journal.Transactions) {
				if (e.IsDebitNotCredit) {
					ExecuteNonQuery(String.Format("INSERT INTO Journal (accountnum, dammount) VALUES({0}, {1})", e.AccountNumber, e.Amount));
					AddAccountChange(e.AccountNumber, "Debited account by " + e.Amount.ToString());
				} else {
					ExecuteNonQuery(String.Format("INSERT INTO Journal (accountnum, cammount) VALUES({0}, {1})", e.AccountNumber, e.Amount));
					AddAccountChange(e.AccountNumber, "Credited account by " + e.Amount.ToString());
				}
			}
		}

		/// <summary>
		/// update an account to change the active or incactive flag
		/// </summary>
		/// <param name="accountnum">account id</param>
		/// <param name="active">set true for active false for inactive</param>
		public void ChangeAccountStatusByNumber(int accountnum, bool active) {
			string act = active ? "1" : "0";//1 if active, 0 if inactive
			ExecuteNonQuery("UPDATE Chart_of_Accounts SET active = " + act + " WHERE accountnum = " + accountnum);
			string DeRe = active ? "R" : "D";
			AddAccountChange(accountnum, DeRe + "eactivated account");

		}


		#region Generic methods for other methods

		/// <summary>
		/// Run a SQL command and return an aciated DataTable.
		/// </summary>
		/// <param name="cmd">Sql Command</param>
		/// <returns>DataTable</returns>
		private DataTable ExecuteQuery(string cmd) {
			try {
				DataTable dt = new DataTable();
				new SqlCeDataAdapter(cmd, con).Fill(dt);
				return dt;
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				return null;
			}
		}

		/// <summary>
		/// Execute a Non-Query SQL command
		/// </summary>
		/// <param name="cmd"></param>
		private void ExecuteNonQuery(string cmd) {
			try {
				new SqlCeCommand(cmd, con).ExecuteNonQuery();
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}

		/// <summary>
		/// Close the SqlConnection. You must not use an instance of this class after you call Close()
		/// </summary>
		public void Close() {
			try {
				con.Close();
			} catch {
				Console.WriteLine("Error closing connection.");
			}
		}

		/// <summary>
		/// Open the SqlConnection
		/// </summary>
		public void Open() {
			try {
				con.Open();
			} catch {
				Console.WriteLine("Error opening connection.");
			}
		}

		/// <summary>
		/// Deconstructor
		/// </summary>
		~SQL() { Close(); }

		#endregion


	}//end SQL class
}//end namespace

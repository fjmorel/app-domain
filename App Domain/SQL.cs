using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlServerCe;

namespace App_Domain {

	class SQL {

		private SqlCeConnection con = null;

		/// <summary>
		/// Constructor with custom values for connection
		/// </summary>
		/// <param name="filepath"></param>
		/// <param name="password"></param>
		public SQL(string filepath, string password) {
			try {
				con = new SqlCeConnection("Data Source=" + filepath + "; password=" + password);
				Open();
			} catch (Exception ex) {
				MessageBox.Show("Could not connect. Make sure appdomain.sdf is in the same folder as this program.");
				Console.WriteLine(ex.Message);
			}
		}

		//TODO: Make this always positive by reading which side is increase/decrease. Or just Math.Abs?
		public double GetAccountBalance(int accountnum) {
			return GetAccountDebitTotal(accountnum) - GetAccountCreditTotal(accountnum);
		}

		public DataTable GetTrialBalance() {
			DataTable accounts = ExecuteQuery("SELECT accountnum, descript FROM Chart_of_Accounts WHERE active = 1");
			DataTable dt = new DataTable();
			dt.Columns.Add("Account", typeof(string));
			dt.Columns.Add("Description", typeof(string));
			dt.Columns.Add("Debits", typeof(string));
			dt.Columns.Add("Credits", typeof(string));

			foreach (DataRow row in accounts.Rows) {
				int accountnum = Convert.ToInt32(row[0].ToString());
				string account = row[1].ToString();
				double amount = GetAccountBalance(accountnum);
				if (amount != 0) {
					string debit = amount > 0 ? String.Format("{0:C}", Math.Abs(amount)) : "";
					string credit = amount < 0 ? String.Format("{0:C}", Math.Abs(amount)) : "";
					dt.Rows.Add(accountnum.ToString(), account, debit, credit);
				}
			}

			return dt;
		}


		/// <summary>
		/// Retrieves a subset of all Accounts.
		/// </summary>
		/// <param name="careAboutActive">False means get both active and inactive activeAccounts, ignoring bool active</param>
		/// <param name="active">Active = true, Inactive = false</param>
		/// <param name="type">ID of the type of account to get</param>
		/// <param name="name">String wanted in name of activeAccounts</param>
		/// <returns></returns>
		public DataTable GetFilteredChartOfAccounts(bool careAboutActive, bool active, int type, string name) {
			string query = "SELECT ca.accountnum AS [Account], ca.descript AS [Description],CASE ca.active WHEN 1 THEN 'Yes' WHEN 0 THEN 'No' END AS [Active], at.name AS [Type] FROM Chart_of_Accounts AS ca " +
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
			DataTable dt = GetFilteredChartOfAccounts(careAboutActive, active, type, "");
			if (dt != null) {
				foreach (DataRow row in dt.Rows) {
					accounts.Add(new Account(Convert.ToInt32(row["Account"]), Convert.ToString(row["Description"])));
				}
			}
			return accounts;
		}

		/// <summary>
		/// Get a list of all unposted transactions by date and ref number
		/// </summary>
		/// <returns></returns>
		public List<string> GetListOfUnpostedJournalEntries() {
			List<string> transactions = new List<string>();
			DataTable dt = ExecuteQuery("SELECT id, datecreated FROM Journal_Transactions WHERE posted = 0");
			if (dt != null) {
				foreach (DataRow row in dt.Rows) {
					transactions.Add(Convert.ToString(Convert.ToString(row["datecreated"]) + " ref " + Convert.ToString(row["id"])));
				}
			}
			return transactions;
		}

		/// <summary>
		/// Get journal entries by ref number
		/// </summary>
		/// <param name="refnum"></param>
		/// <returns></returns>
		public DataTable GetUnpostedJournalEntryTransactions(int refnum) {
			return ExecuteQuery("SELECT j.accountnum AS [Account], ca.descript AS [Description], j.dammount AS [Debit], j.cammount AS [Credit] FROM journal_Transactions jt JOIN Journal j ON (jt.id = j.ref) JOIN Chart_of_Accounts ca ON (j.accountnum = ca.accountnum) WHERE jt.id = " + refnum.ToString());
		}

		/// <summary>
		/// Get a Journal note by ref number
		/// </summary>
		/// <param name="refnum"></param>
		/// <returns></returns>
		public string GetJournalEntryNote(int refnum) {
			return Convert.ToString(ExecuteQuery("SELECT notes FROM Journal_Transactions WHERE id = " + refnum.ToString()).Rows[0][0]);
		}

		/// <summary>
		/// Gets a DataTable representing account types.
		/// </summary>
		/// <returns></returns>
		public DataTable GetAccountTypes() {
			return ExecuteQuery("SELECT name AS [Name], descript AS [Description], CASE debitispositive WHEN 1 THEN 'Debit' WHEN 0 THEN 'Credit' END AS [Positive Side] FROM Account_Types");
		}

		/// <summary>
		/// Gets changes to Accounts from database
		/// </summary>
		/// <returns>DataTable with account changes</returns>
		public DataTable GetAccountChanges() {
			return ExecuteQuery("SELECT ac.accountnumber AS [Account Number], ac.action AS [Action], ac.dateofchange AS [Time of Change], us.name AS [User] FROM Account_Changes AS ac JOIN Users AS us ON (ac.userid = us.id)");
		}

		/// <summary>
		/// get a transaction ledger for a specific account
		/// </summary>
		/// <param name="accountnum"></param>
		/// <returns></returns>
		public DataTable GetAccountLedger(int accountnum) {
			return ExecuteQuery("SELECT jt.postdate AS [Date], j.dammount AS [Debit Amount], j.cammount AS [Credit Amount] FROM Journal j JOIN Chart_of_Accounts c ON (j.accountnum = c.accountnum) JOIN Journal_Transactions jt ON (j.ref = jt.id) WHERE jt.posted = 1 AND c.accountnum = " + accountnum);
		}

		/// <summary>
		/// Gets the debit total for a specific account
		/// </summary>
		/// <param name="accountnum"></param>
		/// <returns></returns>
		public double GetAccountDebitTotal(int accountnum) {
			DataTable dt = ExecuteQuery("SELECT SUM(j.dammount) FROM Journal j WHERE j.accountnum = " + accountnum);
			if (!dt.Rows[0][0].ToString().Equals(""))//Make sure there's a value
				return Convert.ToDouble(dt.Rows[0][0].ToString());
			else return 0;
		}

		/// <summary>
		/// gets the credit total for a specific account
		/// </summary>
		/// <param name="accountnum"></param>
		/// <returns></returns>
		public double GetAccountCreditTotal(int accountnum) {
			DataTable dt = ExecuteQuery("SELECT SUM(j.cammount) FROM Journal j WHERE j.accountnum = " + accountnum);
			if (!dt.Rows[0][0].ToString().Equals(""))//Make sure there's a value
				return Convert.ToDouble(dt.Rows[0][0].ToString());
			else return 0;
		}

		/// <summary>
		/// Gets a datatable with all journal entries
		/// </summary>
		/// <returns></returns>
		public DataTable GetJournal() {
			return ExecuteQuery("SELECT j.accountnum AS [Account], ca.descript AS [Description], j.dammount AS [Debit], j.cammount AS [Credit], jt.postdate AS [Transaction Date] FROM Journal as j JOIN Chart_of_Accounts AS ca ON (j.accountnum = ca.accountnum) JOIN Journal_Transactions AS jt ON (j.ref = jt.id) WHERE jt.posted = 1");
		}

		/// <summary>
		/// Get account information from a specific account number
		/// </summary>
		/// <param name="accountnum">account number</param>
		/// <returns>DataTable with a single row or no row if the account does no exists</returns>
		public DataTable GetAccountByNumber(int accountnum) {
			return ExecuteQuery(String.Format("SELECT id, accountnum, active, descript FROM Chart_of_Accounts WHERE accountnum = {0}", accountnum));
		}

		/// <summary>
		/// Get total credit amount (from accounts where credit is positive)
		/// </summary>
		/// <returns></returns>
		public double getTotalCredit() {
			DataTable dt = ExecuteQuery("SELECT accountnum FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON ca.typeid = at.id WHERE at.debitispositive = 0");
			double total = 0;
			if (dt != null) {
				foreach (DataRow each in dt.Rows) {
					int a = Convert.ToInt32(each["accountnum"]);
					total += GetAccountCreditTotal(a) - GetAccountDebitTotal(a);
				}
			}
			return total;
		}

		/// <summary>
		/// Get total debit amount (from accounts where debit is positive)
		/// </summary>
		/// <returns></returns>
		public double getTotalDebit() {
			DataTable dt = ExecuteQuery("SELECT accountnum FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON ca.typeid = at.id WHERE at.debitispositive = 1");
			double total = 0;
			if (dt != null) {
				foreach (DataRow each in dt.Rows) {
					int a = Convert.ToInt32(each["accountnum"]);
					total += GetAccountDebitTotal(a) - GetAccountCreditTotal(a);
				}
			}
			return total;
		}

		/// <summary>
		/// Finds whether an account increases on debit or credit side
		/// </summary>
		/// <param name="accountnum"></param>
		/// <returns></returns>
		public int IsDebitThePositiveSide(int accountnum) {
			DataTable dt = ExecuteQuery("SELECT at.debitispositive FROM Account_Types AS at JOIN Chart_of_Accounts AS ca ON ca.typeid = at.id WHERE ca.accountnum = " + accountnum);
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
			ExecuteNonQuery("INSERT INTO Account_Types (name, descript, debitispositive) VALUES('" + name + "','" + description + "', " + debitispositive + ")");
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
			AddAccountChange(accountnum, "Created new account: " + description);
		}

		/// <summary>
		/// Add account changes to database (new transaction, status changes, etc)
		/// </summary>
		/// <param name="accountnum"></param>
		/// <param name="action"></param>
		public void AddAccountChange(int accountnum, string action) {
			//TODO: Actual userid, not just 1 for admin
			ExecuteNonQuery("INSERT INTO Account_Changes (accountnumber, action, userid) VALUES('" + accountnum + "', '" + action + "', '1')");
		}

		/// <summary>
		/// Enters a balanced set of journal entries
		/// updated this function to take care of adding a ref id and notes
		/// </summary>
		/// <param name="j"></param>
		public void AddJournalEntry(JournalEntry journal) {
			//get ref id
			int refnum = Convert.ToInt32(ExecuteQuery("SELECT next_ref_id FROM Settings").Rows[0][0]);
			ExecuteNonQuery("UPDATE Settings SET next_ref_id = " + (refnum + 1).ToString());
			//insert journal transaction notes and ref
			ExecuteNonQuery("INSERT INTO Journal_Transactions (id, notes) VALUES(" + refnum.ToString() + ",'" + journal.notes + "')");
			foreach (Entry e in journal.Transactions) {
				string[] DorC = new string[] { "c", "Credi" };
				if (e.IsDebitNotCredit)//Use debit instead of credit
					DorC = new string[] { "d", "Debi" };
				SqlCeCommand cmd = new SqlCeCommand("INSERT INTO Journal (accountnum," + DorC[0] + "ammount, ref) VALUES (" + e.AccountNumber + "," + e.Amount + ", " + refnum.ToString() + ")", con);
				//cmd.Parameters.AddWithValue("@datePost", journal.time);
				cmd.ExecuteNonQuery();
				//Transactions show in their own table, only journal entries will show up in changelog
				//AddAccountChange(e.AccountNumber, String.Format(DorC[1] + "ted account by {0:C} on " + journal.time.ToString("M/d/yyyy"), e.Amount));
			}
		}

		/// <summary>
		/// post a journal entry by ref number
		/// </summary>
		/// <param name="refnum"></param>
		public void PostJournalEntry(int refnum) {
			ExecuteNonQuery("UPDATE Journal_Transactions SET posted = 1 WHERE id = " + refnum.ToString());
			ExecuteNonQuery("UPDATE Journal_Transactions SET postdate = GETDATE() WHERE id = " + refnum.ToString());
			AddAccountChange(refnum, "Posted journal entry");
		}

		/// <summary>
		/// remove an unposted journal transaction
		/// </summary>
		/// <param name="refnum"></param>
		public void DeleteJournalEntry(int refnum) {
			ExecuteNonQuery("DELETE FROM Journal WHERE ref = " + refnum);
			ExecuteNonQuery("DELETE FROM Journal_Transactions WHERE id = " + refnum);
			AddAccountChange(refnum, "Deleted unposted journal entry");
		}

		/// <summary>
		/// Delete an account
		/// </summary>
		/// <param name="accountNum"></param>
		public void DeleteAccount(int accountNum) {
			ExecuteNonQuery("DELETE FROM Chart_Of_Accounts WHERE accountnum = " + accountNum);
		}

		/// <summary>
		/// update an account to change the active or incactive flag
		/// </summary>
		/// <param name="accountnum">account id</param>
		/// <param name="active">set true for active false for inactive</param>
		public void ChangeAccountStatusByNumber(int accountnum, bool active) {
			string act = active ? "1" : "0";//1 if active, 0 if inactive
			ExecuteNonQuery("UPDATE Chart_of_Accounts SET active = " + act + " WHERE accountnum = " + accountnum);
			if (active)
				AddAccountChange(accountnum, "Reopened account");
			else
				AddAccountChange(accountnum, "Closed account");
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
				MessageBox.Show(ex.Message);
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
				MessageBox.Show(ex.Message);
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlServerCe;

/*Account Types
0 = asset
1 = liability
2 = expense
3 = revenue
4 = equity
*/
namespace App_Domain {

	/// <summary>
	/// Takes care of all things related to the database
	/// </summary>
	class SQL {

		/// <summary>
		/// Connection being used for all the methods
		/// </summary>
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
				Application.Exit();
			}
		}

		/// <summary>
		/// Returns balance of an accounts (takes care of figuring out positive side of account)
		/// </summary>
		/// <param name="accountnum">Account to get balance for</param>
		/// <returns></returns>
		public double GetAccountBalance(int accountnum) {
			return Convert.ToDouble(ExecuteQuery("SELECT balance FROM Chart_of_Accounts WHERE accountnum = " + accountnum).Rows[0]["balance"]);
		}

		/// <summary>
		/// Return accounts with balances
		/// </summary>
		/// <returns></returns>
		public DataTable GetTrialBalance() {
			DataTable assets = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts AS ca JOIN account_types AS at ON (ca.typeid = at.id) WHERE active = 1 AND at.account_type = 0");
			DataTable liabilities = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts AS ca JOIN account_types AS at ON (ca.typeid = at.id) WHERE active = 1 AND at.account_type = 1");
			DataTable expenses = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts AS ca JOIN account_types AS at ON (ca.typeid = at.id) WHERE active = 1 AND at.account_type = 2");
			DataTable revenues = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts AS ca JOIN account_types AS at ON (ca.typeid = at.id) WHERE active = 1 AND at.account_type = 3");
			DataTable equity = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts AS ca JOIN account_types AS at ON (ca.typeid = at.id) WHERE active = 1 AND at.account_type = 4");
			
			DataTable dt = new DataTable();
			dt.Columns.Add("Account", typeof(string));
			dt.Columns.Add("Description", typeof(string));
			dt.Columns.Add("Debits", typeof(string));
			dt.Columns.Add("Credits", typeof(string));
			double debit = 0.0, credit = 0.0;

			foreach (DataRow row in assets.Rows) {
				double amount = Convert.ToDouble(row[2]);
				if (amount != 0) {
					dt.Rows.Add(row[0].ToString(), row[1].ToString(), String.Format("{0:C}", amount), "");
					debit += amount;
				}
			}

			foreach (DataRow row in liabilities.Rows) {
				double amount = Convert.ToDouble(row[2]);
				if (amount != 0) {
					dt.Rows.Add(row[0].ToString(), row[1].ToString(), "", String.Format("{0:C}", amount));
					credit += amount;
				}
			}

			foreach (DataRow row in revenues.Rows) {
				double amount = Convert.ToDouble(row[2]);
				if (amount != 0) {
					dt.Rows.Add(row[0].ToString(), row[1].ToString(), "", String.Format("{0:C}", amount));
					credit += amount;
				}
			}

			foreach (DataRow row in equity.Rows) {
				double amount = Convert.ToDouble(row[2]);
				if (amount != 0) {
					dt.Rows.Add(row[0].ToString(), row[1].ToString(), "", String.Format("{0:C}", amount));
					credit += amount;
				}
			}

			foreach (DataRow row in expenses.Rows) {
				double amount = Convert.ToDouble(row[2]);
				if (amount != 0) {
					dt.Rows.Add(row[0].ToString(), row[1].ToString(), String.Format("{0:C}", amount), "");
					debit += amount;
				}
			}

			dt.Rows.Add("", "", "");
			dt.Rows.Add("", "Totals", String.Format("{0:C}", debit), String.Format("{0:C}", credit));

			return dt;
		}

		/// <summary>
		/// Get the balance of quick assets
		/// </summary>
		/// <returns></returns>
		public double GetQuickAssetBalance() {
			return GetAccountBalance(101) + GetAccountBalance(102) + GetAccountBalance(103);
		}

		/// <summary>
		/// Get table of data for printout. Returns accounts and their balance
		/// </summary>
		/// <returns></returns>
		public DataTable GetPrintTable() {
			return ExecuteQuery("SELECT ca.accountnum AS [Account], ca.descript AS [Description], ca.balance AS [Balance], at.name AS [Type] FROM Chart_of_Accounts AS ca " +
				"JOIN Account_Types AS at ON (ca.typeid = at.id) WHERE ca.active = 1");
		}

		/// <summary>
		/// Return balances of only assets, liabilities, and equity
		/// </summary>
		/// <returns></returns>
		public DataTable GetBalanceSheet() {
			DataTable assets = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts as ca JOIN Account_Types AS at ON (ca.typeid = at.id) WHERE ca.active = 1 AND at.account_type = 0");
			DataTable liabilities = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts as ca JOIN Account_Types AS at ON (ca.typeid = at.id) WHERE ca.active = 1 AND at.account_type = 1");
			DataTable equity = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts as ca JOIN Account_Types AS at ON (ca.typeid = at.id) WHERE ca.active = 1 AND at.account_type = 4");

			DataTable dt = new DataTable();
			dt.Columns.Add("Account", typeof(string));
			dt.Columns.Add("Description", typeof(string));
			dt.Columns.Add("Balance", typeof(string));

			double totalAssets = 0;
			foreach (DataRow row in assets.Rows) {
				double amount = Convert.ToDouble(row[2].ToString());
				if (amount != 0) {
					totalAssets += amount;
					dt.Rows.Add(row[0], row[1], String.Format("{0:C}", amount));
				}
			}
			dt.Rows.Add("", "Total Assets", String.Format("{0:C}", totalAssets));
			dt.Rows.Add("", "", "");

			double totalLiabilities = 0;
			foreach (DataRow row in liabilities.Rows) {
				double amount = Convert.ToDouble(row[2].ToString());
				if (amount != 0) {
					totalLiabilities += amount;
					dt.Rows.Add(row[0], row[1], String.Format("{0:C}", amount));
				}
			}
			if (totalLiabilities != 0) {
				dt.Rows.Add("", "Total Liabilities", String.Format("{0:C}", totalLiabilities));
				dt.Rows.Add("", "", "");
			}

			double totalEquity = 0;
			foreach (DataRow row in equity.Rows) {
				double amount = Convert.ToDouble(row[2].ToString());
				if (amount != 0) {
					totalEquity += amount;
					dt.Rows.Add(row[0], row[1], String.Format("{0:C}", amount));
				}
			}
			double retainedEarnings = GetRetainedEarnings();
			if (retainedEarnings != 0) {
				dt.Rows.Add("", "Retained Earnings", String.Format("{0:C}", retainedEarnings));
				
				totalEquity += retainedEarnings;
			}
			double dividends = GetDividends();
			if (retainedEarnings != 0) {
				dt.Rows.Add("", "Dividends", String.Format("{0:C}", dividends));
				totalEquity += dividends;
			}

			if (totalEquity != 0) {
				dt.Rows.Add("", "Total Equity", String.Format("{0:C}", totalEquity));
				dt.Rows.Add("", "", "");
			}
			

			dt.Rows.Add("", "Total Liabilities + Equity", String.Format("{0:C}", totalLiabilities + totalEquity));

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
		/// 
		/// 
		/// 
		/// <returns>Accounts that match criteria in a list</returns>
		public List<Account> GetActiveAccountList() {
			List<Account> accounts = new List<Account>();
			DataTable dt = GetFilteredChartOfAccounts(true, true, 0, "");
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
		public DataTable GetUnpostedJournalEntries() {
			return ExecuteQuery("SELECT id, postdate FROM Journal_Entries WHERE posted = 0 AND deleted = 0");
		}

		/// <summary>
		/// Get a list of all posted transactions by date and ref number
		/// </summary>
		/// <returns></returns>
		public DataTable GetPostedJournalEntries() {
			return ExecuteQuery("SELECT id, postdate FROM Journal_Entries WHERE posted = 1 AND deleted = 0");
		}

		/// <summary>
		/// Get a list of all deleted transactions by date and ref number
		/// </summary>
		/// <returns></returns>
		public DataTable GetDeletedJournalEntries() {
			return ExecuteQuery("SELECT id, postdate FROM Journal_Entries WHERE posted = 0 AND deleted = 1");
		}

		/// <summary>
		/// Get journal entries by ref number
		/// </summary>
		/// <param name="refnum"></param>
		/// <returns></returns>
		public DataTable GetJournalEntryTransactions(int refnum) {
			return ExecuteQuery("SELECT j.accountnum AS [Account], ca.descript AS [Description], j.dammount AS [Debit], j.cammount AS [Credit] FROM Journal_Entries jt JOIN Transactions j ON (jt.id = j.ref) JOIN Chart_of_Accounts ca ON (j.accountnum = ca.accountnum) WHERE jt.id = " + refnum.ToString());
		}

		/// <summary>
		/// Get a Journal note by ref number
		/// </summary>
		/// <param name="refnum"></param>
		/// <returns></returns>
		public string GetJournalEntryNote(int refnum) {
			return ExecuteQuery("SELECT notes FROM Journal_Entries WHERE id = " + refnum).Rows[0][0].ToString();
		}

		/// <summary>
		/// Gets a DataTable representing account types.
		/// </summary>
		/// <returns></returns>
		public DataTable GetAccountTypes() {
			return ExecuteQuery("SELECT name AS [Name], descript AS [Description], CASE account_type WHEN 0 THEN 'Assets' WHEN 1 THEN 'Liabilities' WHEN 2 THEN 'Expenses' WHEN 3 THEN 'Revenues' WHEN 4 THEN 'Equity' END AS [Type] FROM Account_Types");
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
			return ExecuteQuery("SELECT jt.id AS [Ref], jt.postdate AS [Date], j.dammount AS [Debit Amount], j.cammount AS [Credit Amount] FROM Transactions j JOIN Chart_of_Accounts c ON (j.accountnum = c.accountnum) JOIN Journal_Entries jt ON (j.ref = jt.id) WHERE jt.posted = 1 AND c.accountnum = " + accountnum);
		}

		/// <summary>
		/// Gets a datatable with all journal entries
		/// </summary>
		/// <returns></returns>
		public DataTable GetJournal() {
			return ExecuteQuery("SELECT jt.id AS [Ref], j.accountnum AS [Account], ca.descript AS [Description],'$' + CONVERT(NVARCHAR(16), j.dammount) AS [Debit],'$' + CONVERT(NVARCHAR(12), j.cammount) AS [Credit], jt.postdate AS [Transaction Date] FROM Transactions as j JOIN Chart_of_Accounts AS ca ON (j.accountnum = ca.accountnum) JOIN Journal_Entries AS jt ON (j.ref = jt.id) WHERE jt.posted = 1");
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
			return Convert.ToDouble(ExecuteQuery("SELECT SUM(ca.balance) FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON ca.typeid = at.id WHERE at.debitispositive = 0").Rows[0][0]);
		}

		/// <summary>
		/// Get total debit amount (from accounts where debit is positive)
		/// </summary>
		/// <returns></returns>
		public double getTotalDebit() {
			return Convert.ToDouble(ExecuteQuery("SELECT (ca.balance) FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON ca.typeid = at.id WHERE at.debitispositive = 1").Rows[0][0]);
		}

		/// <summary>
		/// Gets the balance of the sum of accounts with type
		/// </summary>
		/// <param name="accounttype"></param>
		/// <returns></returns>
		public double GetAccountTypeTotal(int accounttype) {
			return Convert.ToDouble(ExecuteQuery("SELECT SUM(ca.balance) FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON ca.typeid = at.id WHERE at.account_type = " + accounttype.ToString()).Rows[0][0]);
		}

		/// <summary>
		/// Get the total of all revenues
		/// </summary>
		/// <returns></returns>
		public double GetRevenues() {
			return GetAccountTypeTotal(3);
		}

		/// <summary>
		/// Get the total of all expenses
		/// </summary>
		/// <returns></returns>
		public double GetExpenses() {
			return GetAccountTypeTotal(2);
		}

		/// <summary>
		/// get income statement
		/// </summary>
		/// <returns></returns>
		public DataTable GetIncomeStatement() {
			DataTable expenses = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON (ca.typeid = at.id) WHERE ca.active = 1 AND at.account_type = 2");
			DataTable revenues = ExecuteQuery("SELECT ca.accountnum, ca.descript, ca.balance FROM Chart_of_Accounts AS ca JOIN Account_Types AS at ON (ca.typeid = at.id) WHERE ca.active = 1 AND at.account_type = 3");

			DataTable dt = new DataTable();
			dt.Columns.Add("Account", typeof(string));
			dt.Columns.Add("Description", typeof(string));
			dt.Columns.Add("Amount", typeof(string));

			double totalExpenses = 0.0;
			foreach (DataRow row in expenses.Rows) {
				double amount = Convert.ToDouble(row[2]);
				if (amount != 0) {
					dt.Rows.Add(row[0].ToString(), row[1].ToString(), String.Format("{0:C}", amount));
					totalExpenses += amount;
				}
			}
			dt.Rows.Add("", "Total Revenues", String.Format("{0:C}", totalExpenses));
			dt.Rows.Add("", "", "");

			double totalRevenues = 0.0;
			foreach (DataRow row in revenues.Rows) {
				double amount = Convert.ToDouble(row[2]);
				if (amount != 0) {
					dt.Rows.Add(row[0].ToString(), row[1].ToString(), String.Format("{0:C}", amount));
					totalRevenues += amount;
				}
			}
			dt.Rows.Add("", "Total Revenues", String.Format("{0:C}", totalRevenues));
			dt.Rows.Add("", "", "");

			if (totalRevenues > totalExpenses)
				dt.Rows.Add("", "Net Income", String.Format("{0:C}", totalRevenues - totalExpenses));
			else
				dt.Rows.Add("", "Net Loss", String.Format("{0:C}", totalExpenses - totalRevenues));

			return dt;
		}

		/// <summary>
		/// set retained earnings
		/// </summary>
		/// <param name="re"></param>
		public void SetRE(double re) {
			ExecuteNonQuery("UPDATE Settings SET retained_earnings = " + re.ToString());
			AddAccountChange(0, "Updated retained earnings");
		}

		/// <summary>
		/// Current Retained earnings = Revenues - expenses - dividends
		/// </summary>
		/// <returns></returns>
		public double GetRetainedEarnings() {
			return GetRevenues() - GetExpenses() - GetDividends();
		}

		/// <summary>
		/// set dividends
		/// </summary>
		/// <param name="div"></param>
		public void SetDividends(double div) {
			ExecuteNonQuery("UPDATE Settings SET dividens = " + div.ToString());
			AddAccountChange(0, "Updated dividends");
		}

		/// <summary>
		/// Get the set dividends
		/// </summary>
		/// <returns></returns>
		public double GetDividends() {
			DataTable dt = ExecuteQuery("SELECT dividens FROM Settings");
			return Convert.ToDouble(dt.Rows[0][0]);

		}

		/// <summary>
		/// Finds whether an account increases on debit or credit side. Assets and expenses increase on the debit side
		/// </summary>
		/// <param name="accountnum"></param>
		/// <returns></returns>
		public int IsDebitThePositiveSide(int accountnum) {
			DataTable dt = ExecuteQuery("SELECT at.account_type AS [Type] FROM Account_Types AS at JOIN Chart_of_Accounts AS ca ON ca.typeid = at.id WHERE ca.accountnum = " + accountnum);
			if (dt != null)
				return Convert.ToInt32(dt.Rows[0]["Type"]) == 0 || Convert.ToInt32(dt.Rows[0]["Type"]) == 2 ? 1 : 0;
			return -1;
		}

		/// <summary>
		/// Return DataTable with one row if the name is already in the table
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public DataTable GetAccountTypeByName(string name) {
			return ExecuteQuery("SELECT id, name FROM Account_Types WHERE name = '" + name + "'");
		}

		/// <summary>
		/// Add an account type to the database
		/// </summary>
		/// <param name="name">Account type name</param>
		/// <param name="description">Account type description</param>
		public void AddAccountType(string name, string description, bool debitIsPositive, int accounttype) {
			int debitispositive = debitIsPositive ? 1 : 0;
			ExecuteNonQuery("INSERT INTO Account_Types (name, descript, debitispositive, account_type) VALUES('" + name + "','" + description + "', " + debitispositive + ", " + accounttype.ToString() + ")");
		}

		/// <summary>
		/// Adds an account to the database.
		/// </summary>
		/// <param name="description"></param>
		/// <param name="active"></param>
		/// <param name="typeid"></param>
		/// <param name="owner"></param>
		public void AddAccount(string description, int active, int typeid, int accountnum) {
			ExecuteNonQuery("INSERT INTO Chart_of_Accounts (descript, active, typeid, accountnum) VALUES('" + description + "', '" + active + "', '" + typeid + "', " + accountnum + ")");
			AddAccountChange(accountnum, "Created new account: " + description);
		}

		/// <summary>
		/// Add account changes to database (new transaction, status changes, etc)
		/// </summary>
		/// <param name="accountnum"></param>
		/// <param name="action"></param>
		public void AddAccountChange(int accountnum, string action) {
			ExecuteNonQuery("INSERT INTO Account_Changes (accountnumber, action, userid) VALUES('" + accountnum + "', '" + action + "', '1')");
		}

		/// <summary>
		/// Enters a balanced set of journal entries
		/// updated this function to take care of adding a ref id and notes
		/// </summary>
		/// <param name="j"></param>
		public void AddJournalEntry(JournalEntry journal) {
			ExecuteNonQuery("INSERT INTO Journal_Entries (notes) VALUES('" + journal.notes + "')");
			int refnum = ExecuteQuery("SELECT * FROM Journal_Entries").Rows.Count;
			//Has to be done this way to do a proper datetime for some reason
			SqlCeCommand cmd = new SqlCeCommand("UPDATE Journal_Entries SET postdate = @PostDate WHERE id = " + refnum.ToString(), con);
			cmd.Parameters.Add(new SqlCeParameter("PostDate", SqlDateTime.Parse(journal.time.ToString("yyyy-MM-dd HH:mm:ss"))));
			cmd.ExecuteNonQuery();

			string[] DorC = new string[] { "c", "Credi" };
			foreach (Entry e in journal.Transactions) {
				if (e.IsDebitNotCredit)//Use debit instead of credit
					DorC = new string[] { "d", "Debi" };
				ExecuteNonQuery("INSERT INTO Transactions (accountnum," + DorC[0] + "ammount, ref) VALUES (" + e.AccountNumber + "," + e.Amount + ", " + refnum.ToString() + ")");
				DorC = new string[] { "c", "Credi" };//reset for next loop
			}
		}

		/// <summary>
		/// post a journal entry by ref number
		/// </summary>
		/// <param name="refnum"></param>
		public void PostJournalEntry(int refnum) {
			ExecuteNonQuery("UPDATE Journal_Entries SET posted = 1, deleted = 0 WHERE id = " + refnum);

			//Update account balances
			DataTable dt = ExecuteQuery("SELECT accountnum, dammount, cammount, ref FROM Transactions WHERE ref = " + refnum);
			if (dt != null && dt.Rows.Count > 0) {
				foreach (DataRow each in dt.Rows) {
					int accountnum = Convert.ToInt32(each["accountnum"]);
					double dammount = Convert.ToDouble(each["dammount"]);
					double cammount = Convert.ToDouble(each["cammount"]);
					if (IsDebitThePositiveSide(accountnum) == 1) {
						if (dammount > 0)
							ChangeAccountBalance(accountnum, dammount, true);
						else if (cammount > 0)
							ChangeAccountBalance(accountnum, cammount, false);
					} else {
						if (dammount > 0)
							ChangeAccountBalance(accountnum, dammount, false);
						else if (cammount > 0)
							ChangeAccountBalance(accountnum, cammount, true);
					}
				}
			}


			AddAccountChange(refnum, "Posted journal entry");
		}

		/// <summary>
		/// Add or subtract from the account balance
		/// </summary>
		/// <param name="accountnum"></param>
		/// <param name="ammount"></param>
		/// <param name="addNotSubtract"></param>
		public void ChangeAccountBalance(int accountnum, double ammount, Boolean addNotSubtract) {
			if (addNotSubtract)
				ExecuteNonQuery("UPDATE Chart_of_Accounts SET balance = " + (GetAccountBalance(accountnum) + ammount) + " WHERE accountnum = " + accountnum);
			else
				ExecuteNonQuery("UPDATE Chart_of_Accounts SET balance = " + (GetAccountBalance(accountnum) - ammount) + " WHERE accountnum = " + accountnum);
		}

		/// <summary>
		/// remove an unposted journal transaction
		/// </summary>
		/// <param name="refnum"></param>
		public void DeleteJournalEntry(int refnum) {
			ExecuteNonQuery("UPDATE Journal_Entries SET deleted = 1 WHERE id = " + refnum);
			AddAccountChange(refnum, "Deleted unposted journal entry");
		}

		/// <summary>
		/// Delete an account
		/// </summary>
		/// <param name="accountNum"></param>
		public void DeleteAccount(int accountNum) {
			ExecuteNonQuery("DELETE FROM Chart_Of_Accounts WHERE accountnum = " + accountNum);
			AddAccountChange(accountNum, "Deleted account");
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

		/// <summary>
		/// Change the number of an account
		/// </summary>
		/// <param name="oldNum"></param>
		/// <param name="newNum"></param>
		public void ChangeAccountNumberByNumber(int oldNum, int newNum) {
			ExecuteNonQuery("UPDATE Chart_of_Accounts SET accountnum = " + newNum + " WHERE accountnum = " + oldNum);
			ExecuteNonQuery("UPDATE Transactions SET accountnum = " + newNum + " WHERE accountnum = " + oldNum);
			AddAccountChange(oldNum, "Change account number to " + newNum);
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

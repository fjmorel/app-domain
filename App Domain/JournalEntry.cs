using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Domain {

	/// <summary>
	/// A struct representing a single line in a journal entry.
	/// </summary>
	struct Entry {
		/// <summary>
		/// Account
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Account number
		/// </summary>
		public int AccountNumber { get; set; }
		/// <summary>
		/// Amount of transaction
		/// </summary>
		public double Amount { get; set; }
		/// <summary>
		/// Debit or credit
		/// </summary>
		public bool IsDebitNotCredit { get; set;}
	}

	/// <summary>
	/// A collection of Entrys representing a single journal entry
	/// </summary>
	class JournalEntry {

		/// <summary>
		/// Holds transactions for Journal Entry
		/// </summary>
		private List<Entry> _transactions = new List<Entry>();
		public List<Entry> Transactions {
			get { return _transactions; }
		}

		/// <summary>
		/// Post date
		/// </summary>
		public DateTime time;

		/// <summary>
		/// Note for journal entry
		/// </summary>
        public string notes;

		/// <summary>
		/// Constructor
		/// </summary>
		public JournalEntry() { }

		/// <summary>
		/// Add new Entry to JournalEntry
		/// </summary>
		/// <param name="AccountNum"></param>
		/// <param name="descript"></param>
		/// <param name="Amount"></param>
		/// <param name="transIsDebit"></param>
		public void AddEntry(int AccountNum, string descript, double Amount, bool isDebitNotCredit) {
			Entry en = new Entry();
			en.AccountNumber = AccountNum;
			en.Amount = Amount;
			en.IsDebitNotCredit = isDebitNotCredit;
			en.Description = descript;
			_transactions.Add(en);
		}

	}
}

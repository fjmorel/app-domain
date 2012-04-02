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
		public string Description { get; set; }
		public int AccountNumber { get; set; }
		public double Amount { get; set; }
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

		public DateTime time;

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

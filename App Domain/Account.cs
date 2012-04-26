using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Domain {
	/// <summary>
	/// Information about an account
	/// </summary>
	class Account {

		/// <summary>
		/// Number of account
		/// </summary>
		private int _AccountNumber;
		public int AccountNumber {
			get { return _AccountNumber; }
		}

		/// <summary>
		/// Name of account
		/// </summary>
		private string _AccountDescription;
		public string AccountDescription {
			get { return _AccountDescription; }
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="num"></param>
		/// <param name="descript"></param>
		public Account(int num, string descript) {
			_AccountDescription = descript;
			_AccountNumber = num;
		}

		/// <summary>
		/// Override string format
		/// </summary>
		/// <returns></returns>
		public override string ToString() {
			return String.Format("{0} - {1}", Convert.ToString(_AccountNumber), _AccountDescription);
		}
	}
}

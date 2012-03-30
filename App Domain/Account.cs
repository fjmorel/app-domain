using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App_Domain {
	class Account {
		private int _AccountNumber;
		private string _AccountDescription;

		public int AccountNumber {
			get { return _AccountNumber; }
		}

		public string AccountDescription {
			get { return _AccountDescription; }
		}

		public Account(int num, string descript) {
			_AccountDescription = descript;
			_AccountNumber = num;
		}

		public override string ToString() {
			return String.Format("{0} - {1}", Convert.ToString(_AccountNumber), _AccountDescription);
		}
	}
}

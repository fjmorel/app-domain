
namespace App_Domain {
	/// <summary>
	/// Account type data structure
	/// </summary>
	class AccountType {
		private int _id;
		private string _name;
		private bool _debitIsPositive;

		public int id {
			get {return _id;}
		}

		public string Name {
			get {return _name;}
		}

		public bool DebitIsPositiveSide{
			get {return _debitIsPositive;}
		}

		public AccountType(int id, string name, bool debitispositive) {
			_id = id;
			_name = name;
			_debitIsPositive = debitispositive;
		}

		
		
		public override string ToString() {return _name;}
	}
}

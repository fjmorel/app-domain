
namespace App_Domain {
	/// <summary>
	/// Account type data structure
	/// </summary>
	class AccountType {

		/// <summary>
		/// Type of account type
		/// </summary>
		private int _id;
		public int id {
			get {return _id;}
		}

		/// <summary>
		/// Name
		/// </summary>
		private string _name;
		public string Name {
			get {return _name;}
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		public AccountType(int id, string name) {
			_id = id;
			_name = name;
		}

		/// <summary>
		/// Override string form
		/// </summary>
		/// <returns></returns>
		public override string ToString() {return _name;}
	}
}

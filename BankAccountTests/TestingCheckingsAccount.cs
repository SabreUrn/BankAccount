using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace BankAccountTests {
	public class TestingCheckingsAccount : IAccount {
		private int _regNumber;
		private long _accNumber;
		public TestingCheckingsAccount(int regNumber, long accNumber) {
			_regNumber = regNumber;
			_accNumber = accNumber;
		}

		public int GetRegNumber() { return _regNumber; }
		public long GetAccNumber() { return _accNumber; }
	}
}

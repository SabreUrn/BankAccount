using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace BankAccountTests {
	public class TestingAccountHandler : IAccountHandler {
		public IAccount CreateSavingsAccount(int regNumber, long accNumber) {
			return new TestingSavingsAccount(regNumber, accNumber);
		}

		public IAccount CreateCheckingsAccount(int regNumber, long accNumber) {
			return new TestingCheckingsAccount(regNumber, accNumber);
		}
	}
}

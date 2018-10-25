using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
	public class Customer {
		public IAccountHandler AccountHandler;
		public List<IAccount> SavingsAccounts { get; set; }
		public List<IAccount> CheckingsAccounts { get; set; }

		public Customer(IAccountHandler accountHandler) {
			SavingsAccounts = new List<IAccount>();
			CheckingsAccounts = new List<IAccount>();
			AccountHandler = accountHandler;
		}
		public void CreateSavingsAccount(int regNumber, long accNumber) {
			IAccount account = AccountHandler.CreateSavingsAccount(regNumber, accNumber);
			SavingsAccounts.Add(account);
		}

		public void CreateCheckingsAccount(int regNumber, long accNumber) {
			IAccount account = AccountHandler.CreateCheckingsAccount(regNumber, accNumber);
			CheckingsAccounts.Add(account);
		}
	}
}

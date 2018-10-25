using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount {
	public interface IAccountHandler {
		IAccount CreateSavingsAccount(int regNumber, long accNumber);
		IAccount CreateCheckingsAccount(int regNumber, long accNumber);
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;

namespace BankAccountTests {
	[TestClass]
	public class CustomerTests {
		[TestMethod]
		public void Customer_Initialise_AccountHandlerInHealthyState() {
			IAccountHandler accountHandler = new TestingAccountHandler();
			Customer customer = new Customer(accountHandler);
			Assert.AreEqual(accountHandler, customer.AccountHandler); //reference equality
		}

		[TestMethod]
		public void Customer_CreateSavingsAccount() {
			IAccountHandler accountHandler = new TestingAccountHandler();
			Customer customer = new Customer(accountHandler);
			int expectedReg = 1234;
			long expectedAcc = 1234567890;

			customer.CreateSavingsAccount(1234, 1234567890);
			int actualReg = customer.SavingsAccounts[0].GetRegNumber();
			long actualAcc = customer.SavingsAccounts[0].GetAccNumber();

			Assert.AreEqual(expectedReg, actualReg);
			Assert.AreEqual(expectedAcc, actualAcc);
		}

		[TestMethod]
		public void Customer_CreateCheckingsAccount() {
			IAccountHandler accountHandler = new TestingAccountHandler();
			Customer customer = new Customer(accountHandler);
			int expectedReg = 1234;
			long expectedAcc = 1234567890;

			customer.CreateCheckingsAccount(1234, 1234567890);
			int actualReg = customer.CheckingsAccounts[0].GetRegNumber();
			long actualAcc = customer.CheckingsAccounts[0].GetAccNumber();

			Assert.AreEqual(expectedReg, actualReg);
			Assert.AreEqual(expectedAcc, actualAcc);
		}
	}
}

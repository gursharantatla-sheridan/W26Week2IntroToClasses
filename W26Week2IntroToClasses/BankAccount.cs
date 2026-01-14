using System;
using System.Collections.Generic;
using System.Text;

namespace W26Week2IntroToClasses
{
    public class BankAccount
    {
		private double _balance;

		public double Balance
		{
			get { return _balance; }
			private set { _balance = value; }
		}

		public BankAccount(double initialAmount)
		{
			Balance = initialAmount;
		}

		public void Deposit(double amount)
		{
			Balance += amount;
		}

		public void Withdraw(double amount)
		{
			Balance -= amount;
		}
    }
}

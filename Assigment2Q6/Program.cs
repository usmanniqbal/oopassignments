using System;

namespace Assigment2Q6
{
	class Program
	{
		static void Main(string[] args)
		{
			BankAccount bankAccount1 = new BankAccount();

			Console.WriteLine("Account 1");
			bankAccount1.EnterAccountData();
			bankAccount1.ComputerInterest(3);

			Console.WriteLine("Account 2");
			BankAccount bankAccount2 = new BankAccount();
			bankAccount2.EnterAccountData();
			bankAccount2.DisplayAccount();

			Console.ReadLine();
		}
	}

	public class BankAccount
	{
		private const int _annualInterest = 3;
		private int _accountNumber;
		private decimal _balance;

		public void EnterAccountData()
		{
			while (true)
			{
				try
				{
					Console.WriteLine("Enter Account Number.");
					var accountNumber = Convert.ToInt32(Console.ReadLine());

					if(accountNumber < 1000)
					{
						throw new FormatException("Account number can not be less than 1000.");
					}
					_accountNumber = accountNumber;
					break;
				}
				catch (InvalidCastException ex)
				{
					Console.WriteLine(ex.Message);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}

			while (true)
			{
				try
				{
					Console.WriteLine("Enter Balance.");
					var balance = Convert.ToDecimal(Console.ReadLine());

					if (balance < 0)
					{
						throw new FormatException("Balance can not be negative.");
					}
					_balance = balance;
					break;
				}
				catch (InvalidCastException ex)
				{
					Console.WriteLine(ex.Message);
				}
				catch (FormatException ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}

		public void ComputerInterest(int interestYears)
		{
			var amount = _balance;
			for (int i = 0; i < interestYears; i++)
			{
				amount = amount + (amount * _annualInterest / 100);
				Console.WriteLine("Year {0} Balance: {1}", i+ 1, amount);
			}
		}

		public void DisplayAccount()
		{
			Console.WriteLine("Account #: {0}", _accountNumber);
			Console.WriteLine("Balance: {0}", _balance);
		}
	}
}

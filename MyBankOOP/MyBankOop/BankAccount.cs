using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankOop
{
	public class BankAccount
	{
		public string Number { get; }

		public string Owner { get; set; }

		public decimal Balance {
			get
			{
				decimal balance = 0;
				foreach (var item in allTransactions)
				{
					balance = balance + item.Amount;
					
				}
				return balance;
			
			}
		}

		private static int accountNumberSeed = 1234567890;

		private List<Transactions> allTransactions = new List<Transactions>();

		public BankAccount(string name,decimal initialBalance) 
		{
			this.Owner = name;

			MakeDeposit(initialBalance, DateTime.Now, "initial balance");
			
			this.Number = accountNumberSeed.ToString();
			accountNumberSeed++;
			
		}

		public void MakeDeposit(decimal amount, DateTime date, string note)
		{
			if (amount <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
				
			}
			var deposit = new Transactions(amount, date, note);
			allTransactions.Add(deposit);
		}

		public void MakeWithdrawl(decimal amount, DateTime date, string note)
		{
			if (amount <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(amount), "amount of withdrawls must be positive");
			}
			if (Balance - amount < 0)
			{
				throw new InvalidOperationException("not sufficient funds for this withdrawl");
			}
			var withdrawl = new Transactions(-amount, date, note);
			allTransactions.Add(withdrawl);
		}

		public string GetAccountHistory()
		{	
			var report = new StringBuilder();


			//header
			report.AppendLine("Date\tAmount\tNote");
			foreach (var item in allTransactions)
			{
				//ROWS
				report.AppendLine($"{item.Date.ToShortDateString()}\t {item.Amount}\t{item.Notes}");
			}
			return report.ToString();
		}


	}
}

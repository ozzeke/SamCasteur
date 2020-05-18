using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankOop
{
	class Program
	{
		static void Main(string[] args)
		{

			var account = new BankAccount("Sam", 2000);
			Console.WriteLine($"Account {account.Number} is aangemaakt voor {account.Owner} met {account.Balance}");
			
			account.MakeWithdrawl(89, DateTime.Now, "PC case");
			/*
			Console.WriteLine(account.Balance);
			*/

			account.MakeWithdrawl(50, DateTime.Now, "game");
			/*
			Console.WriteLine(account.Balance);
			*/
			

			Console.WriteLine(account.GetAccountHistory());

			 

			/*

			//negative balance

			try
			{
				account.MakeWithdrawl(4000, DateTime.Now, "attempt to overdraw");
			}
			catch (InvalidOperationException e)
			{

				Console.WriteLine("exeption caught trying to overdraw");
				Console.WriteLine(e.ToString());
			}



			//positive balance
			try
			{
				var invalidAccount = new BankAccount("invalid", -55);
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine("exeption caught creating with negative balance");
				Console.WriteLine(e.ToString());

			}
			*/
		}
	}
}

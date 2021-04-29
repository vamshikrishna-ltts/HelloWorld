using System;

namespace SuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("vamshi", 10000);
            Console.WriteLine("Hi {0} your bank balance is {1} and account number {2}", 
                account.OwnerName, account.Balance, account.Number);

            account.MakeWithdrawl(100, DateTime.Now, "withdrawl");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.getTransactions());
            Console.WriteLine(account.Balance);
        }
    }
}

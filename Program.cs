using System;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Jenifer", 100);
            Console.WriteLine($"Owner {account.Owner} has {account.Balance} euro(s) in account Nr. {account.Number} created on {account.DateCreated.ToString("dd/MM/yyyy")}.");
            account.DateCreated = new DateTime(2020, 03, 01);
            Console.WriteLine($"Owner {account.Owner} has {account.Balance} euro(s) in account Nr. {account.Number} created on {account.DateCreated.ToString("dd/MM/yyyy")}.");
        }
    }
}

using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Nick", 696900);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with balance {account.Balance}");
        }
    }
}

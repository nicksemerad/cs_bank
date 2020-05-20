using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Nick", 6969);
            Console.WriteLine($"Account {account} was created for {account.Owner} with balance {account.Balance}");
        }
    }
}

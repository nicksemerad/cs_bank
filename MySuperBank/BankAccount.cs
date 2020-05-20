﻿using System;
using System.Transactions;
using System.Collections.Generic;

namespace MySuperBank
{
    public class BankAccount
    { 
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }

    }
}

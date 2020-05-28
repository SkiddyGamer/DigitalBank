using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBank
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        public DateTime DateCreated { get; set; }

        private List<Transaction> transactions = new list<Transaction>();

        public BankAccount(string ownerName, decimal initialBalance)
        {
            this.DateCreated = DateTime.Now;
            this.Number = "123";
            this.Owner = ownerName;
            this.Balance = initialBalance;
        }

        public void DepositMoney(decimal amount, DateTime date, string notes)
        {

        }
            
        public void WithdrawMoney(decimal amount, DateTime date, string notes)
        {

        }

    }
}

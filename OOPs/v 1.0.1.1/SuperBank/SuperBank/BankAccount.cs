using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBank
{
     public class BankAccount
    {
        public string number { get; set; }
        public string owner { get; set; }
        public decimal balance { get; set; }

        public BankAccount(string owner, decimal balance) {
            this.owner = owner;
            this.balance = balance;
        }
        public void deposit(string number, string owner, decimal balance)
        {
            this.number = number;
            this.owner = owner; 
            this.balance= balance;
            
        }

        public void withdraw(string number, string owner, decimal balance)
        {
            this.number = number;
            this.owner = owner;
            this.balance = balance;

        }


        public void show()
        {
            Console.WriteLine(owner+ " " + balance);
        }



    }
}

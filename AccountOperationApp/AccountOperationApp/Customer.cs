using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Customer
    {
        public string accountNumber;
        public string customerName;
        public int balance;
        public int sumBalance;

        public void DoDeposit(int amount)
        {
            balance += amount;
        }

        public void DoWithdraw(int amount)
        {
            balance -= amount;
        }

    }
}

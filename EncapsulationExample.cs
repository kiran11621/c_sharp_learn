using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class EncapsulationExample
    {
        public void example()
        {
            Bank b = new Bank();
            //b.balance; 


        }
    }

    public class Bank 
    {
        private int balance;

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value > 0) {
                    balance += value;
                }
            }
        }

        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAcccount
    {
        private double _balance = 0;

        public void Deposit(double moneyAdded)
        {
            _balance += moneyAdded;
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}

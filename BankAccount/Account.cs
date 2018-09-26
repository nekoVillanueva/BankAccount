using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   public class Account
    {
        //field
        private double acctBal;
        private double deposit;
        private double withdraw;
        private string acctType;
        

        //property
        public double AcctBal
        {
            get;set;
        }
        public double Deposit
        {
            get;set;
        }
        public double Withdraw
        {
            get;set;
        }
        public string AcctType
        {
            get;set;
        }
        //constructor
        public Account()
        {
            //default
        }
        //methods
        public double GetWithdraw(double input)
        {
            input = AcctBal - input;
            return input;
        }
        public double GetDeposit(double input)
        {
            input = AcctBal + input;
            return input;
        }
   }
}

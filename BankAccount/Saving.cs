using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Saving:Account
    {
        //field
        private double minBal;

        //property
       public double MinBal
        {
            get;set;
        }


       public Saving()
        {

        }
    }
}

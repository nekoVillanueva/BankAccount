using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Client clientIce = new Client("Ice", "Man", "01110");
            Checking checkingIce = new Checking();
            Saving savingIce = new Saving();
            Console.WriteLine(" 1.View Client Information\n 2.View Client Balance\n 3.Deposit Funds\n 4.Withdraw Funds\n 5.Exit");
            string option = Console.ReadLine();
            switch (option)
            {

            }
        }
    }
}

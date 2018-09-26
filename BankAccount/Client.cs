using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Client
    {
        //field
        private string lName;
        public string fName;
        public string accountNum;

        //property
        public string LName
        {
            get { return this.lName; }
            set { this.lName = value; }
        }
        public string FName
        {
            get { return this.fName; }
            set { this.fName = value; }
        }
        public string AccountNum { get; set; }

        //constructor
        public Client()
        {
            //Default
        }
        public Client(string firstName, string lastName, string accountNumber)
        {
            this.FName = firstName;
            this.LName = lastName;
            this.AccountNum = accountNum;
        }

        //methods
        public string Welcome(string firstName, string lastName, string accountNumber)
        {
            return $"Welcome {firstName} {lastName}. Your account number is {accountNumber}";
        } 




    }
}

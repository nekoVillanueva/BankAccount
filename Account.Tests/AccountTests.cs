using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace AccountTests

{
    [TestFixture]
    class AccountTests

    { 
        //arrange
        Client client = new Client();
        Account account = new Account();

        [Test]
        public void Test_LName_Prop()
        {
            //action
            client.LName = "LName";
            string response = client.LName;
            
            //assert
            Assert.That(response, Is.EqualTo("LName"));
        }
        [Test]
        public void Test_FName_Prop()
        {
            //action
            client.FName = "FName";
            string response = client.FName;

            //assert
            Assert.That(response, Is.EqualTo("FName"));
        }
        [Test]
        public void Test_AccountNum_Prop()
        {
            //action
            client.AccountNum = "AccountNum";
            string response = client.AccountNum;

            //assert
            Assert.That(response, Is.EqualTo("AccountNum"));

        }
        [Test]
        public void Test_Client_Menu_CTR()
        {
            //action

            string response = client.Welcome("FName","LName","0101010");

            //assert
            Assert.That(response, Is.EqualTo("Welcome FName LName. Your account number is 0101010"));

        }
        [Test]
        public void Test_Account_CTR()
        {
            //action
            account.AcctBal = 0;
            double response = account.AcctBal;

            //assert
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_Account_CTR_1_Para()
        {
            //void makes no sense 

        }
        [Test]
        public void Test_Deposit_Prop()
        {
            //action
            account.Deposit = 0;
            double response = account.Deposit;
            //assert
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_Withdraw_Prop()
        {
            //action
            account.Withdraw = 0;
            double response = account.Withdraw;
            //assert
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_Withdraw_Method()
        {
            //action
            double response = account.GetWithdraw(0);
            //assert
            Assert.That(response, Is.EqualTo(0));

        }
        [Test]
        public void Test_Deposit_Method()
        {

            //action
            account.AcctBal = 0;
            double response = account.GetDeposit(0);
            //assert
            Assert.That(response, Is.EqualTo(0));

        }
        [Test]
        public void Test_Account_Type_Prop()
        {

            //action
            account.AcctType = "";

            string response = account.AcctType;
            
            //assert
            Assert.That(response, Is.EqualTo(""));

        } 
        [Test]
        public void Test_Checking_Accoungt_CTR()
        {
            //action
            account.AcctBal = 110;
            double response = account.AcctBal;

            //assert
            Assert.That(response, Is.EqualTo(110));
        }
        [Test]
        public void Test_Checking_Deposit_Method()
      
      
        {
            //action
            account.AcctBal = 5;
            double response = account.GetDeposit(110);
            //assert
            Assert.That(response, Is.EqualTo(115));

        }
        [Test]
        public void Test_Checking_Withdraw_Method()
        {
            //action
            account.AcctBal = 200;
            double response = account.GetWithdraw(100);
            //assert
            Assert.That(response, Is.EqualTo(100));
        }
        [Test]
        public void Test_Saving_Min_Balance_Prop()
        {
            Saving saving = new Saving();
            //action
            saving.MinBal = 150;
            double response = saving.MinBal;
            //assert
            Assert.That(response, Is.EqualTo(150));
        }



    }

    

    
    
}

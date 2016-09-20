using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyBankAccounts
{
    abstract class Account
    {
        public readonly long accno;
        public string uname;
        public int balance;

        public abstract void OpenAccount();
        public abstract void CloseAccount();
        public abstract void EditAccount();
        public abstract void Deposit(int amt);
        public abstract void Withdraw(int amt);
        public abstract int Check_Balance();


        Account(long accno)
        {
            Random rnd = new Random();
            accno = rnd.Next(100000000, 1000000000);
        }

        


       






    }    
}

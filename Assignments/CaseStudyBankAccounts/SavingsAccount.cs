using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyBankAccounts
{
    class MaxAmountException : ApplicationException {
        public override string Message {
            get {
                return @"Transaction Failed: Maximum amount that can be transferred per day has been exceeded";
            }
        }
    }


    class MinBalanceRequired : ApplicationException
    {
        public override string Message
        {
            get
            {
                return @"Transaction Failed: Should maintain minimum amount in account";
            }
        }
    }

    class SavingsAccount : Account, IROI, ITransaction
        {

        public int MinBalanceRequired = 1000;
        public int MaxAmountPerDay = 40000;

            public void GetAccountDetails() { }

            Hashtable ht1 = new Hashtable();
            Hashtable ht2 = new Hashtable();

            public override void OpenAccount()
            {                         
                
                Console.WriteLine("Your new account number is: {0}" +accno );

                Console.WriteLine("Enter Username");
                uname = Console.ReadLine();

                ht1.Add(accno, uname);



                Console.WriteLine("Enter Minimum Balance of 1000 Rs");
                try
                {                    
                    if (balance < MinBalanceRequired)
                    {
                        throw new MinBalanceRequired();
                    }
                    else {
                        balance = int.Parse(Console.ReadLine());
                        Console.WriteLine("Congratulations!! New A/c created!");
                    }
                }
                catch (MinBalanceRequired ex) {
                    Console.WriteLine(ex.Message);               
                }


                ht2.Add(accno, balance);


            }

            public override void CloseAccount()
            {

                
                Console.WriteLine("Enter A/C no");
                long accno1 = long.Parse(Console.ReadLine());

                if()
                if (ht1.ContainsKey(accno1))
                {
                    ht1.Remove(accno1);
                   // ht1.Remove(uname);
                    ht2.Remove(accno1); //doubt

                }
                else
                    Console.WriteLine("Enter a valid A/C no");
  
            }

            public override void EditAccount()
            {
                Console.WriteLine("enter acc no:");
                long accno2 = long.Parse(Console.ReadLine());
                if (ht1.ContainsKey(long(accno2)))
                {
                    ht1.Remove(uname);
                    Console.WriteLine("Enter new username");
                    uname = Console.ReadLine();

                    ht1.Add(accno, uname);
                }
                else
                    Console.WriteLine("Enter a valid A/C no");  
               
            }

            public override void Deposit(int amt)
            {
                try
                {
                    if (amt < MaxAmountPerDay)
                    {

                        balance += amt;
                        Console.WriteLine( "Money Deposited! \nUpdated Balance:" +balance);
                    }
                    else
                    {
                        throw new MaxAmountException();
                    }

                }
                catch (MaxAmountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            

            public override void Withdraw(int amt)
            {
                try
                {
                    if (amt < MaxAmountPerDay)
                    {

                        balance -= amt;
                        Console.WriteLine("Remaining Balance=  " + balance);
                        if (balance < MinBalanceRequired ) { //doubt 
                        
                        }
                    }
                    else
                    {
                        throw new MaxAmountException();
                    }

                }
                catch (MaxAmountException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }





            public override int Check_Balance()
            {
                throw new NotImplementedException();
            }
        }
    
}

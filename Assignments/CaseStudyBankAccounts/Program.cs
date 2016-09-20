using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyBankAccounts
{    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Open A/c 2. Close A/c 3. Edit A/c 4. Perform Transactions");
                Console.WriteLine("Enter choice");
                int ch = int.Parse(Console.ReadLine());

                if (ch == 1)
                {

                    SavingsAccount sa = new SavingsAccount();
                    sa.OpenAccount();

                    CurrentAccount ca = new CurrentAccount();
                    ca.OpenAccount();

                }

                if (ch == 2)
                {

                    SavingsAccount sa = new SavingsAccount();
                    sa.CloseAccount();

                    CurrentAccount ca = new CurrentAccount();
                    ca.CloseAccount();
                }

                if (ch == 3)
                {
                    SavingsAccount sa = new SavingsAccount();
                    sa.EditAccount();

                    CurrentAccount ca = new CurrentAccount();
                    ca.EditAccount();

                }

                if (ch == 4)
                {
                    Console.WriteLine("1. Withdrawal 2. Deposit");
                    //
                    if (ch == 1)
                    {
                        Console.WriteLine("1. Savings A/c 2. Current A/c");

                        if (ch == 1)
                        {

                            Console.WriteLine("Enter Amount for Withdrawal from Savings a/c");
                            SavingsAccount sa = new SavingsAccount();
                            int amt = int.Parse(Console.ReadLine());
                            sa.Withdraw(amt);


                        }

                        if (ch == 2)
                        {
                            Console.WriteLine("Enter Amount for Withdrawal from Current a/c");
                            CurrentAccount ca = new CurrentAccount();
                            int amt = int.Parse(Console.ReadLine());
                            ca.Withdraw(amt);


                        }

                    }
                    //
                    if (ch == 2)
                    {
                        Console.WriteLine("1. Savings A/c 2. Current A/c");

                        if (ch == 1)
                        {

                            Console.WriteLine("Enter Amount for Deposit into Savings A/c");
                            SavingsAccount sa = new SavingsAccount();
                            int amt = int.Parse(Console.ReadLine());
                            sa.Deposit(amt);


                        }

                        if (ch == 2)
                        {
                            Console.WriteLine("Enter Amount for Deposit into Current A/c");
                            CurrentAccount ca = new CurrentAccount();
                            int amt = int.Parse(Console.ReadLine());
                            ca.Deposit(amt);


                        }


                    }

                }

            }//while ends
        }
    }
}

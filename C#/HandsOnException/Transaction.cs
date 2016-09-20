using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnException
{
    class BankException:ApplicationException {
        public override string Message
        {
            get
            {
                return @"Transaction Failed
Reason: Maintain minimum balance of 500 Rs";
            }
        }
    }

    class Transaction
    {
        private double camt;

        public Transaction(double camt) {
            this.camt = camt;
        }

        public void Withdraw(double amt) {
            try
            {
                if ((camt - amt) < 500)
                {
                    throw new BankException();
                }
                else
                    Console.WriteLine("Transaction Success");
            }
            catch (BankException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }

    class Test
    {
        static void Main() {
            Transaction obj = new Transaction(10000);
            Console.WriteLine("Enter Amount");
            double amt = double.Parse(Console.ReadLine());
            obj.Withdraw(amt);
        }
    }
}

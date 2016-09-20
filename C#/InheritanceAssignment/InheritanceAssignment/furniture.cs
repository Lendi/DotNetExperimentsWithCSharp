using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    class furniture
    {
        public int orderId;
        public DateTime oDate;
        public string fType;
        public string purpose;
        public int qty;
        public int totalAmt;
        public string payMode;
      

    }

    class chair:furniture{

        public string ctype;
        public string purpose;

        public void getDetails(){
            Console.WriteLine("Enter Order ID");
            orderId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Date");
            oDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Purpose: Home/ Office");
            purpose = Console.ReadLine();
            Console.WriteLine("Enter quantity of the item");
            qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total Bill");
            totalAmt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mode of payment Credit/ Debit card");
            payMode = Console.ReadLine();

        }

        public void showDetails() {
            Console.WriteLine("Order ID : " +orderId);
            Console.WriteLine("Order Date : " +oDate);
            Console.WriteLine("Purpose : " +purpose);
            Console.WriteLine("Quantity of item : " +qty);
            Console.WriteLine("Total Bill : " +totalAmt);
            Console.WriteLine("Mode of payment : " +payMode);      
        
        }



    }

    class cot:furniture{
        public string ctype;
        public string capacity;
//        public int rate;


        public void getDetails()
        {
            Console.WriteLine("Enter Order ID");
            orderId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Date");
            oDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Purpose: Home/ Office");
            purpose = Console.ReadLine();
            Console.WriteLine("Enter quantity of the item");
            qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total Bill");
            totalAmt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mode of payment Credit/ Debit card");
            payMode = Console.ReadLine();
            Console.WriteLine("Enter Capacity");
            capacity = Console.ReadLine();
        }

        public void showDetails()
        {
            Console.WriteLine("Order ID : " + orderId);
            Console.WriteLine("Order Date : " + oDate);
            Console.WriteLine("Purpose : " + purpose);
            Console.WriteLine("Quantity of item : " + qty);
            Console.WriteLine("Total Bill : " + totalAmt);
            Console.WriteLine("Mode of payment : " + payMode);

        }
    }



    class assign
    {
        static void Main(string[] args)
        {

            furniture fur = new furniture();
            chair cobj = new chair();
            cot cot = new cot();

            int ch=0;
            Console.WriteLine("1. Chair 2. Cot");
            ch=int.Parse(Console.ReadLine());

            if(ch == 1){
            fur.fType="Chair";      
            
            cobj.getDetails();   
            }
            else
                if(ch == 2){
                fur.fType = "Cot";
                cot.getDetails();
                }           


            switch (ch)
            {
                case 1:                   

                    Console.WriteLine("1. Wood 2. Steel 3. Plastic");
                    ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("1. Teak Wood 2. Rose Wood");
                            ch = int.Parse(Console.ReadLine());
                            switch (ch)
                            {
                                case 1:
                                    cobj.ctype = "Teak wood Chair";
                                    cobj.showDetails();
                                    break;

                                case 2:
                                    cobj.ctype = ("Rose wood chair");
                                    cobj.showDetails();
                                    break;
                            }
                            break;
                            
                        case 2:
                            Console.WriteLine("1. Gray 2. Green 3. Brown");
                            ch = int.Parse(Console.ReadLine());
                            switch (ch)
                            {
                                case 1:
                                    cobj.ctype = ("Gray steel chair");
                                    cobj.showDetails();
                                    break;
                                case 2:
                                    cobj.ctype = ("Green steel chair");
                                    cobj.showDetails();
                                    break;
                                case 3:
                                    cobj.ctype = ("Brown steel chair");
                                    cobj.showDetails();
                                    break;
                            }
                            break;
                        case 3:
                            cobj.ctype = ("Plastic chair");
                            cobj.showDetails();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("1. Wood 2. Steel");
                    ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            cot.ctype = ("Wooden cot");
                            cot.showDetails();
                            break;
                        case 2:
                            cot.ctype = ("Steel cot");
                            cot.showDetails();
                            break;
                    }
                    break;


            }

            
                   

       
            


        }
    }


}
 
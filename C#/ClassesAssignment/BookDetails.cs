using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAssignment
{
    class BookDetails
    {
        string isbn;
        string booktitle;
        string bookauthor;
        int quantity_of_books;
        int bookprice;

        public BookDetails(string isbno,  string bt,string ba, int nbooks, int price){
            isbn = isbno ;        
            booktitle = bt;
            bookauthor = ba;
            quantity_of_books = nbooks;
            bookprice = price;

        }

        public void Display() {
            Console.WriteLine("ISBN {0}, Btitle{1}, Author{2}, No.of.books{3}, Price{4}",  isbn, booktitle,bookauthor, quantity_of_books, bookprice) ;
            Console.WriteLine("Total Bill = " + quantity_of_books * bookprice);
        }

       

        static void Main(string[] args)
        {
            BookDetails bd1 = new BookDetails("1242536", "kill me", "lendi", 10, 250);
            BookDetails bd2 = new BookDetails("1648536", "kill me 2", "lendi", 10, 350);
            BookDetails bd3 = new BookDetails("8672536", "kill me 3", "lendi", 10, 450);
            BookDetails[] bd = new BookDetails[] { bd1, bd2, bd3};

            foreach(BookDetails k in bd){
                k.Display();
            }

            
        }
    }
}

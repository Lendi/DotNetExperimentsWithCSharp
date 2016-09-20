using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnReadOnly
{
    class Student
    {
        public const string School_name = "SJS";
        public readonly int sid;
        public readonly string sname;


        public Student(int id, string name) {
            sid = id;
            sname = name;
        }

        public void Details() {
            Console.WriteLine("ID" +sid);
            Console.WriteLine("Name" +sname);
            Console.WriteLine("School name" + School_name);
        }

        static void Main() {
            Student s1 = new Student(100, "Rohan");
            s1.Details();
            Student s2 = new Student(102, "Karan");
            s2.Details();
        }


    }
}

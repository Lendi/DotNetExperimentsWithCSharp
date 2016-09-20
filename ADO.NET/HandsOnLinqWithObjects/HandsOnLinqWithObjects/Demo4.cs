using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinqWithObjects
{
    class Student {
        public int Sid { get; set; }
        public string Sname { get; set; }
    }

    class Enroll {
        public int Sid { get; set; }
        public string Cname { get; set; }
    }

    class Demo4
    {
        static void Main() {
            Student s1 = new Student() { Sid = 1, Sname = "Rohan" };
            Student s2 = new Student() { Sid = 2, Sname = "Karan" };
            Student s3 = new Student() { Sid = 3, Sname = "Jason" };
            Enroll e1 = new Enroll() { Sid = 1, Cname = "C#"};
            Enroll e2 = new Enroll() { Sid = 2, Cname = "C#" };
            Enroll e3 = new Enroll() { Sid = 3, Cname = "C#" };
            Enroll e4 = new Enroll() { Sid = 1, Cname = "Asp.net" };
            Enroll e5 = new Enroll() { Sid = 2, Cname = "Asp.net" };

            List<Student> list1 = new List<Student>() {s1, s2, s3 };
            List<Enroll> list2 = new List<Enroll>() { e1, e2, e3, e4, e5};

            var res = from l1 in list1
                      join
                      l2 in list2
                      on l1.Sid equals l2.Sid
                      select new { l1.Sid, l1.Sname, l2.Cname };
            foreach (var v in res)
                Console.WriteLine("{0} {1} {2}", v.Sid, v.Sname, v.Cname);


        }
    }
}

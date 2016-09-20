using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructor
{
    class Student
    {
        string name;
        int age;
        public Student(string n, int a) {
            name = n;
            age = a;
        }
        public void Details() {
            Console.WriteLine("Name: {0} , Age: {1} ", name, age);
        }

        static void Main() {
            Student s1 = new Student("Len", 22);
            Student s2 = new Student("Batman", 22);
            Student s3 = new Student("Ironman", 21);
            Student s4 = new Student("Catwoman", 22);
            Student s5 = new Student("Wonderwoman", 22);
            Student[] s = new Student[] {s1, s2, s3, s4, s5 };

            foreach (Student k in s) {
                k.Details();
            }
        }
    }
}

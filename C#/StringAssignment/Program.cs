using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        
        

        //a
        public void charAtIndexTwelve(string s)
        {
            Console.WriteLine(s[12]);
            
        }



        //b
        public void presenceOfIs(string s) {

            if (s.Contains("Is"))
            {
                Console.WriteLine("Sentence Contains \"Is\" ");
            }
            else {
                Console.WriteLine("Sentence doesnt contain \"Is\" ");
            }


        }


        //c
        public void addUp(string s) {
            Console.WriteLine("Enter an extension to your sentence");
            string childString = Console.ReadLine();
            s = string.Concat(s,childString );
            Console.WriteLine(s);
        }



        //d

        public void endWithDogs(string s) {
/*
            string[] breakStrings = s.Split(' ');
            int lastIndex = (s.Length-1);

            if (s.Contains(breakStrings[lastIndex]))
            {
                Console.WriteLine("Sentence ends with Dogs ");
            }
            else
            {
                Console.WriteLine("Sentence doesnt end with Dogs\"Is\" ");
            }
 * */
            if (s.EndsWith("dogs"))
            {
                Console.WriteLine("Sentence ends with dogs");
            }
            else {
                Console.WriteLine("Sentence doesnt end with dogs");
            }
        }



        //e
        public void compareWithStringE(string s)
        {
            string otherString = "The quick brown Fox jumps over the lazy Dog";
            if (s.Equals(otherString))
            {
                Console.WriteLine("Matches");
            }
            else
            {
                Console.WriteLine("Not a match");
            }
        }

        //f
        public void compareWithStringF(string s)
        {
            string otherString = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";          
            if (s.Equals(otherString))
            {
                Console.WriteLine("Matches");
            }
            else
            {
                Console.WriteLine("Not a match");
            }
        }

        //g
        public void lengthOfString(string s)
        {
            Console.WriteLine(s.Length);
            
        }


        //h
        public void compareWithStringH(string s)
        {
            string otherString = "The quick brown Fox jumps over the lazy Dog";
            if (s.Equals(otherString))
            {
                Console.WriteLine("Matches");
            }
            else
            {
                Console.WriteLine("Not a match");
            }
        }

        //i
        public void replaceWithA(string s)
        {
            Console.WriteLine(s.Replace("The", "A"));
            
        }

        //j

        //k




        //l
        public void Lower(string s)
        {
            Console.WriteLine(s.ToLower());

        }



        //m
        public void Upper(string s)
        {
            Console.WriteLine(s.ToUpper());

        }

        //n
        public void positionOfA(string s)
        {
            int i = s.IndexOf('a');
            Console.WriteLine(i);

        }
        //o
        public void lastPositionOfE(string s)
        {
            int i = s.LastIndexOf('e');
            Console.WriteLine(i);

        }


        
        static void Main(string[] args)
        {
            string sentence1 = "The quick brown fox jumps over the lazy dog ";

            Program pr = new Program();

            //a
//            pr.charAtIndexTwelve(sentence1);

            //b 
//            pr.presenceOfIs(sentence1);

            //c
//            pr.addUp(sentence1);

            //d
//            pr.endWithDogs(sentence1);

            //e
//            pr.compareWithStringE(sentence1);


            //f
//            pr.compareWithStringF(sentence1);


            //g
//            pr.lengthOfString(sentence1);

            //h
//            pr.compareWithStringH(sentence1);
            //i
//            pr.replaceWithA(sentence1);

            //j
            //k


            //l
//            pr.Lower(sentence1);
            //m
//            pr.Upper(sentence1);
            //n
            pr.positionOfA(sentence1);
            //o
            pr.lastPositionOfE(sentence1);
            



            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// c# supports only hierarchial or multilevel inheritance 
// c# doesnt support multiple inheritance using classes
//// c# supports multiple inheritance using interface just like JAVA

namespace HandsOnInheritance_3
{
    class Employee { }

    //restrict inheritance using sealed ; salesmanager can no longer derive from manager class
    class Manager:Employee { }

    class SalesManager:Manager { }

    class Demo3
    {
    }
}

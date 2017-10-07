using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataTypes_ConsoleApplication
{
    class Program
    {
        static string s = "Hello";  // ohne static ist die Variable nur mit einem Object verfügbar
        static void Main(string[] args)
        {
            Console.WriteLine(s);
        }
    }
}

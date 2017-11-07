using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAnyOneConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Super super = new Super();
            Unter_1 u1 = new Unter_1();
            Unter_2 u2 = new Unter_2();

            // u1+u1;
           Unter_1 u1u1 = u1 + u1;
            // u1+u2;
             Object u1u2 = u1 + u2;
            // u2+u2;
           Unter_2 u2u2 = u2 + u2;
            // u2+u1; 
             Object u2u1 = u2 + u1;   

            Console.ReadLine();

           
           


        }
    }
}

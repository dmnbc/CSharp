using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernarerOperatorConsoleApplication
{
    class Program
    {
        static public string sagGerade()
        {
            return "gerade";
        }

        static public int sagZwei()
        {
            
            return 2;
        }

        static void Main(string[] args)
        {
            int i = 2;
            if(i%2 == 0)
            {
                Console.WriteLine(" i ist gerade");
            }
            else
            {
                Console.WriteLine(" i ist ungerade");
            }
            Console.ReadLine();

            Console.WriteLine("i ist {0} ", (i % 2 == 0) ? sagZwei() : "ungerade");


            Console.ReadLine();
        }
    }
}

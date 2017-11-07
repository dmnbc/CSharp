using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAnyOneConsoleApplication
{
    class Super : Object
    {
         public static Object operator + (Super x, Super y )
        {
            Console.WriteLine("Hier werden zwei Super Objekte addiert");
            Console.WriteLine("der erste Parameter wurde als {0} erkannt ", x.GetType());
             if(x.GetType().ToString() == "OverloadingAnyOneConsoleApplication.Unter_1")
            {
                Console.WriteLine("Rückgabe als Unter_1 object");
                return new Unter_1();
            }

        
         if(x.GetType().ToString() == "OverloadingAnyOneConsoleApplication.Unter_2")
            {
                Console.WriteLine("Rückgabe als Unter_2 object");
                return new Unter_2();
            }
            Console.WriteLine("Rückgabe als Super object");
            return new Super();
}
    }

    class Unter_1 :Super
    {
         public static  Unter_1 operator +(Unter_1 x, Unter_1 y)
        {
            Console.WriteLine("Hier werden zwei Unter_1 Objekte addiert");
            return new Unter_1();
        } 
    }

    class Unter_2 :Super
    {
        public static Unter_2 operator +(Unter_2 x, Unter_2 y)
        {
            Console.WriteLine("Hier werden zwei Unter_2 Objekte addiert");
            return new Unter_2();
        } 

    }
}

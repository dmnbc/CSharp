using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachInterfaceConsoleApplication
{
    class Program
    {
        class A : System.Collections.IEnumerable
        {
            public int[] zahlen = new int[10];
            public A()
            {
                Console.WriteLine("Ich bin ein A ");
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Im Array zahlen wird {0} eingefügt", i);
                    zahlen[i] = i;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException(); // hier muss noch Enumerble codiert werden
            }
        }
        static void Main(string[] args)
        {
            List<A> meineAs = new List<A>();
            for(int i =0; i < 10; i++)
            {
                meineAs.Add(new A());
            }

            Console.WriteLine("Es sind {0} Elemente in meineAs", meineAs.Count);

            Console.ReadLine();

            foreach(var element in meineAs)
            {
                Console.WriteLine("Wieder ein A element");
            }
            Console.ReadLine();

            foreach(var element in meineAs)
            {
                foreach( var zahl in element)
                {
                    Console.WriteLine(zahl);
                }
            }
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCAnalyseConsoleApplication
{
    class Program
    {
        static public List<char> nennungen = new List<char>(){ 'a', 'b', 'C', 'Z', 'j', 'b', 'C', 'Z',
       'a', 'b', 'C', 'Z', 'b', 'C', 'Z', 'b', 'C', 'Z', 'b', 'C', 'Z', 'b', 'C', 'Z', 'b', 'C', 'Z','b' };



        static void Main(string[] args)
        {


            Console.WriteLine("Anzahl der Nennungen: {0} ", nennungen.Count);

            var query = (from anzahl in nennungen

                         group anzahl by anzahl into anzahl1

                         orderby (anzahl1.Count()) descending

                         select new { treffer = anzahl1.Count(), wer = anzahl1.First() }).Take(1)
                         ;


            foreach( var item in query )
            { Console.WriteLine("{0}: {1}",item.treffer,item.wer); }

            Console.ReadLine();

        }
    }
}

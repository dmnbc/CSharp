using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchConsoleApplication
{
    class Program
    {   public  static void testen(Kalender k)

        {
            int i;
            Console.Write("Bitte geben Sie einen Monat ein :");
            if (int.TryParse(Console.ReadLine(), out i))
            {
                try
                {

                    Console.WriteLine(k.monat[i]);  // keine meldung vom Compiler
                }
                catch (Exception e)
                {
                    Console.WriteLine("Es ist etwas schief gegangen");
                    //     Console.WriteLine(e.ToString());
                    //     Console.WriteLine(e.Data);
                    Console.WriteLine(e.GetType());
                    //     Console.WriteLine(e.GetType().BaseType);
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Der maximal Index darf {0} nicht übersteigen ", k.monat.Count() - 1);
                    Console.WriteLine(e.Source);
                    Console.WriteLine(e.TargetSite);

                }

            }
            else
            {
                Console.WriteLine("leider habe Sie keine Zahl eingegeben");
                //  ....
            }
        }

        public class Kalender
        {
            
            public int[] monat = new int[13];
            public Kalender()
            {
              monat[0] = -1;
                for(int i =1; i <= 12; i++)
                    {
                    monat[i] = i;
                }
            }
        }
        static void Main(string[] args)
        {
            Kalender meineTermine = new Kalender();
          


            

            testen(meineTermine);
            Console.ReadLine();
        }
    }
}

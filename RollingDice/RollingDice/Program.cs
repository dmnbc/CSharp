using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollingDice
{
    class Program  // hier wegen Montagsfaul, an allen anderen Tagen bitte in eigene Datei auslagern
    {
        class Dice
        {
           private int[] verteilung = new int[6];
           private List<int> wuerfe = new List<int>();


           public Dice(uint anzahl)
            {
                Console.WriteLine("Es wird {0} mal gewürfelt",anzahl);
                Random rnd = new Random();
                for(int i = 0; i < anzahl; i++)
                {
                    // würfeln
                    int erg = rnd.Next(1, 7);  //  Console.WriteLine("Wurf {0}\tErgebnis {1}",i,erg);
                    wuerfe.Add(erg);
                    // ergebnis abgelegt
                    verteilung[erg - 1]++;
                }
            }
            

           public void analyse()
            {
                for(int i = 0; i < 6;i++)
                {
                 Console.WriteLine("{0}\t{1} mal, das entspricht {2,4:F2} %",
                     i+1, verteilung[i], (double)verteilung[i] /wuerfe.Count() * 100);
                }
                
            }

        }



        static void Main(string[] args)
        {
            Dice wuerfel = new Dice(100);
            wuerfel.analyse();      // soll die Verteilung der Würfe anzeigen


            Console.ReadLine();
        }
    }
}

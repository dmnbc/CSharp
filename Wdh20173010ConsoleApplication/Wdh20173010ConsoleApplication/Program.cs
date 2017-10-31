using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Wdh20173010ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
       //     Personal irgendwer = new Personal();
            Console.WriteLine(" --- Konstruktor endet ------------------\n");
       //     Angestellter a = new Angestellter();
            Console.WriteLine(" --- Konstruktor endet ------------------\n");
            TarifgebundenerAngestellter ta = new TarifgebundenerAngestellter();
            Console.WriteLine(" --- Konstruktor endet ------------------\n");
            LeitenderAngestellter l = new LeitenderAngestellter();
            Console.WriteLine(" --- Konstruktor endet ------------------\n");
            Zeitarbeiter z = new Zeitarbeiter();
            Console.WriteLine(" --- Konstruktor endet ------------------\n");

            TarifgebundenerAngestellter[] t = new TarifgebundenerAngestellter[30];
            for(int i=0; i <30;i++)
            {
                t[i] = new TarifgebundenerAngestellter();
                Console.WriteLine(" --- Konstruktor endet ------------------\n");
            }

            LeitenderAngestellter abteilungsleiterVersand = new LeitenderAngestellter();
            abteilungsleiterVersand.inAbteilungEinstellen(5);
            abteilungsleiterVersand.inAbteilungEinstellen(11);
            abteilungsleiterVersand.inAbteilungEinstellen(19);
            abteilungsleiterVersand.inAbteilungEinstellen(7);

           Console.WriteLine("Die Abteilung hat {0} Mitarbeiter", abteilungsleiterVersand.wievieleMaHabIchDenn());
            abteilungsleiterVersand.zeigeMeineMitarbeiter();



            Console.WriteLine("Es wurden insgesamt {0} Objekte erschaffen ",     Personal.gesamtAnzahlObjekte);
            Console.WriteLine("davon waren {0} Objekte vom Typ Angestellter",Angestellter.gesamtAnzahlObjekte );
            Console.WriteLine("das sind {0,4:F2} Prozent", 100 *(double)Angestellter.gesamtAnzahlObjekte / (double)Personal.gesamtAnzahlObjekte);

            Console.WriteLine(" Der Tarifgebundene t[0] hat die id : {0}",t[0].id_lesen);
            t[11].ausbezahlen();
            z.ausbezahlen();

            ta.ausbezahlen();
            l.ausbezahlen();


            Abteilung versand = new Abteilung(abteilungsleiterVersand);
            Console.WriteLine(" Im Versand arbeiten ");
            versand.chef.zeigeMeineMitarbeiter();


            Console.ReadLine();
        }
    }
}

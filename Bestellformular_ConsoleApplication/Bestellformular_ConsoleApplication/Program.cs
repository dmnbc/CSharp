using System;
using static System.Console;
using static System.ConsoleColor;
using System.Collections.Generic;

namespace Bestellformular_ConsoleApplication
{
    class Program
    {
      
        struct Bestellzeile
        {
            public string bezeichnung;
            public double einzelpreis;
            public int bestellmenge;
            public double zeilenpreis;
        }
        static string hinweis = "Alle Preise netto, zzgl. USt.";
        // zugriff rückgabetyp name (parameter)
        static void Main(string[] args)
        {
            Dictionary<string, double> uStListe = new Dictionary<string, double>();
            uStListe.Add("DE", 19);
            uStListe.Add("GB", 15);
            uStListe.Add("NL", 21);
            uStListe.Add("RU", 30);
            Bestellzeile[] bestellung = new Bestellzeile[]
                { new Bestellzeile {bezeichnung ="Laptop" ,einzelpreis=782.99,bestellmenge=0,zeilenpreis=0.0 },
                  new Bestellzeile {bezeichnung ="Tablet" ,einzelpreis=186.49,bestellmenge=0,zeilenpreis=0.0 },
                  new Bestellzeile {bezeichnung ="Phone " ,einzelpreis= 87.99,bestellmenge=0,zeilenpreis=0.0 },
                  new Bestellzeile {bezeichnung ="Printer",einzelpreis=236.39,bestellmenge=0,zeilenpreis=0.0 },
                  new Bestellzeile {bezeichnung ="Desktop",einzelpreis=986.99,bestellmenge=0,zeilenpreis=0.0 }
                };
           double uStSatz  = landesauswahl(uStListe);
            int oldCursorTop = 9;
            ConsoleKeyInfo cki;
            do
            {
                int startLeft = 4; int startTop = 8;
                int breiteBez = 7; int breiteEp = 7;
                SetCursorPosition(startLeft, startTop);
            Write("Bezeichnung\tE.Preis\tBestellmenge\tPreis");
            ForegroundColor = Yellow;
                double gesamtpreis = 0;
            foreach (Bestellzeile zeile in bestellung)
            { SetCursorPosition(4, ++CursorTop); ;
              Write("{0,-7}\t{1,7:F2}\t{2,6:D}\t{3,13:F2}",zeile.bezeichnung,zeile.einzelpreis,zeile.bestellmenge,zeile.zeilenpreis);
              gesamtpreis += zeile.zeilenpreis;
            }
            // 
        

           hinweiseAusgeben(22,22,Blue);
           
            CursorSize = 10;
                SetCursorPosition(startLeft, 18);
                Write("Gesamtpreis: {0,12:F2}", gesamtpreis);
                hinweiseAusgeben(ustBerechnen(gesamtpreis, uStSatz));
                SetCursorPosition(breiteBez + 8 + breiteEp + 8, oldCursorTop);        
                cki = Console.ReadKey(true);
                if (!Char.IsNumber(cki.KeyChar))
                {
                    switch (cki.Key.ToString())
                    {
                        case "UpArrow":   SetCursorPosition(CursorLeft, (CursorTop > startTop+1) ?       --CursorTop : CursorTop); break;
                        case "DownArrow": SetCursorPosition(CursorLeft, (CursorTop < (startTop + 5)) ? ++CursorTop : CursorTop); break;
                        case "RightArrow": bestellung[CursorTop - 9].bestellmenge++;
                                           bestellung[CursorTop - 9].zeilenpreis += bestellung[CursorTop - 9].einzelpreis; break;
                        case "LeftArrow":
                            if (bestellung[CursorTop - 9].bestellmenge>0)
                            { bestellung[CursorTop - 9].bestellmenge--;
                                bestellung[CursorTop - 9].zeilenpreis -= bestellung[CursorTop - 9].einzelpreis;
                            }
                            break;
                        default: break;
                    }
                    oldCursorTop = CursorTop;
                }
                else
                {
                    int num = int.Parse(cki.KeyChar.ToString());
                    bestellung[CursorTop-9].bestellmenge = num;
                    bestellung[CursorTop-9].zeilenpreis =  num* bestellung[CursorTop-9].einzelpreis;
                    Write(num);
                }
            } while (cki.Key != ConsoleKey.Escape);            
            ReadLine();
        }   // end of main
        static void hinweiseAusgeben()
        {
            Write("\nHinweis: ");
        }
        static void hinweiseAusgeben(double d)
        {
            Write("\n\tHinweis: USt. {0,5:F2} ",d);
        }
        static void hinweiseAusgeben(int left, int top)
        { // Überladung 
            SetCursorPosition(left, top );
            Write("Hinweis: ");
        }
        static void hinweiseAusgeben(int left, int top, ConsoleColor farbe)
        { // Überladung  für Farbe
            ConsoleColor hilf = ForegroundColor ;
            ForegroundColor = farbe;
            SetCursorPosition(left, top);           
            Write("Hinweis: {0} ",hinweis);
            ForegroundColor = hilf; 
        }
       static double ustBerechnen(double netto)
        {
            return ustBerechnen(netto, 19.0);
        }
        static double ustBerechnen(double netto,double ustSatz)
        {
            Write("\t {0} % werden berechnet",ustSatz);
            return  netto * (ustSatz/100);
        }

        static double landesauswahl(Dictionary<string,double> u )
        {
            double value;
            foreach (KeyValuePair<string, double> satz in u)
            {
                Console.Write("\n\t{0} hat einen Umsatzsteuersatz von  {1}",
                 satz.Key, satz.Value);
            }
            Write("\n\tBitte wählen Sie ihr Zielland aus : ");
            string country = ReadLine();
            if (u.TryGetValue(country, out value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Land nicht gefunden, es werden 19% berechnet");
            }
            return 19;
        }



    } // end of Class Program
}

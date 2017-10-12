﻿using System;
using static System.Console;
using static System.ConsoleColor;

namespace Bestellformular_ConsoleApplication
{
    class Program
    {   struct Bestellzeile
        {
            public string bezeichnung;
            public double einzelpreis;
            public int bestellmenge;
            public double zeilenpreis;
        };

        static void Main(string[] args)
        {
            Bestellzeile[] bestellung = new Bestellzeile[]
                { new Bestellzeile {bezeichnung ="Laptop" ,einzelpreis=782.99,bestellmenge=0,zeilenpreis=0.0 },
                  new Bestellzeile {bezeichnung ="Tablet" ,einzelpreis=186.49,bestellmenge=0,zeilenpreis=0.0 },
                  new Bestellzeile {bezeichnung ="Phone " ,einzelpreis= 87.99,bestellmenge=0,zeilenpreis=0.0 },
                  new Bestellzeile {bezeichnung ="Printer",einzelpreis=236.39,bestellmenge=0,zeilenpreis=0.0 },
                  new Bestellzeile {bezeichnung ="Desktop",einzelpreis=986.99,bestellmenge=0,zeilenpreis=0.0 }
                };
            int oldCursorTop = 9;
            ConsoleKeyInfo cki;
            do
            {
                int startLeft = 4; int startTop = 8;
                int breiteBez = 7; int breiteEp = 7;
                SetCursorPosition(startLeft, startTop);
            Write("Bezeichnung\tE.Preis\tBestellmenge\tPreis");
            ForegroundColor = Green;
                double gesamtpreis = 0;
                foreach (Bestellzeile zeile in bestellung)
            { SetCursorPosition(4, ++CursorTop); ;
              Write("{0,-7}\t{1,7:F2}\t{2,6:D}\t{3,13:F2}",zeile.bezeichnung,zeile.einzelpreis,zeile.bestellmenge,zeile.zeilenpreis);
              gesamtpreis += zeile.zeilenpreis;
            }
            CursorSize = 10;
                SetCursorPosition(startLeft, 18);
                Write("Gesamtpreis: {0:F2}", gesamtpreis);
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
        private static void myFunc() { ;}
    }
}

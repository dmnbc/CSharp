using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discounter_ConsoleApplication 
{
    internal class Lagerist:Personal
    {
        // Attribute

        //Methoden
        public Lagerist()
        {
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Lagerist() aufgerufen");
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
        }

        public void umlagern(WasWieOft_Liste al, 
               ref Lager l,
               ref Verkauf v)
        {
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Lagerist.umlagern( Auftragsliste ) startet");
                Console.WriteLine("Es liegen Anforderungen für {0} Artikel vor", al.liste.Count);
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }

            WasWieOft_Liste rollwagen = new WasWieOft_Liste("Rollwagen");
            double lastenangefordert = 0;
            double lastenumgefuellt = 0;

            for (int i = 0; i < al.liste.Count; i++)
            {
                lastenangefordert += al.liste[i].anzahl * Warenkatalog.warenkatalog[al.liste[i].artikel].art_volumen ;  // 
                                                                                                             // aus dem Lagerregal entnehmen / genug, sonst was da ist
                if (l.regale[al.liste[i].artikel].aktuellerInhalt >= al.liste[i].anzahl)
                {                                                        // genug im Regal
                    if (Program.TESTMODE)
                    {
                        ConsoleColor tmp = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Im Lager war genug von Artikel {0} da", al.liste[i].artikel);
                        if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                        Console.ForegroundColor = tmp;
                    }
                    l.regale[al.liste[i].artikel].aktuellerInhalt -= al.liste[i].anzahl;                    // einkaufswagen.liste.Add = // wunsch
                    // erhaltene Menge in den Rollwagen                                                                                                                // Wunschmenge rausnehmen
                    rollwagen.liste.Add(al.liste[i]);     // und in den Rollwagen legen
                }
     
                else
                { // zu wenig im Lageregal, alles was noch da ist in den Rollwagen legen, Regal ist dann leer
                    if (Program.TESTMODE)
                    {
                        ConsoleColor tmp = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("zu wenig da, Regal {0} wird leer gemacht", al.liste[i].artikel);
                        Console.ForegroundColor = tmp;
                    }
                    
                    rollwagen.liste.Add(new WasWieOft_Liste.zeile(i, l.regale[al.liste[i].artikel].aktuellerInhalt));
                    l.regale[al.liste[i].artikel].aktuellerInhalt = 0;
                }
            }
            for ( int i = 0; i < rollwagen.liste.Count; i++ )
            {
                lastenumgefuellt += rollwagen.liste[i].anzahl * Warenkatalog.warenkatalog[rollwagen.liste[i].artikel].art_volumen;
                l.regale[rollwagen.liste[i].artikel].aktuellerInhalt -= rollwagen.liste[i].anzahl;
                v.regale[rollwagen.liste[i].artikel].aktuellerInhalt += rollwagen.liste[i].anzahl;
            }
        
            if (Program.TESTMODE)
            {
                ConsoleColor tmp = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Ich habe {0} cbm von geforderten {1} umgeladen", lastenumgefuellt, lastenangefordert);
                if (Program.STEPWISE) { Console.WriteLine("Weiter mit ┘"); Console.ReadLine(); }
                Console.ForegroundColor = tmp;
            }
        }

    }
}
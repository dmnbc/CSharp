using System;
using static System.Console;


namespace array_ConsoleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            // type der im array enthaltenen elemente, 
                   // name des array
                                // object anlegt
                                           // reserviert 5 Plätze im Speicher
            string[] warenkorb = new string[5];
            warenkorb[0] = "200 gr. Tüte Gummibären";
            warenkorb[1] = "1 Pfund Butter";
            warenkorb[2] = "1 Paprika";

   //         WriteLine("Wir wollen kaufen : {0}\n{2}\n{1}", warenkorb);
            // Mit klassischer Schleife 
            for( int index = 0; index < warenkorb.Length; index++)
            {
               //  WriteLine("I{0}I",warenkorb[index]);
            }


            object[] universal = new object[3];
            universal[0] = "200 gr. Tüte Gummibären";
            universal[1] = 555;
            universal[2] = 'a';
            for (int index = 0; index < universal.Length; index++)
            {
                WriteLine("I {0} I", universal[index].GetType());
                WriteLine("I {0} I", universal[index]);
                
            }


            ReadLine();
        }
    }
}

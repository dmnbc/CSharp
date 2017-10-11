using System;
using System.Globalization;
using System.Text;
using static System.Console;
using static System.ConsoleColor;

namespace Formatausdruck_ConsoleApplication
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int  maxWidth = LargestWindowWidth;
            int  maxHeight = LargestWindowHeight;
            int topLine = 0;
            double gesamtPreis = 0.0;
            SetWindowSize(maxWidth / 2, maxHeight / 2);
            BackgroundColor = Black;
            Clear();
            string dateString = $"Heute: {DateTime.Now.ToLongDateString()}";
            string timeString = $"Jetzt: {DateTime.Now.ToString("HH:mm:ss")}";
            int lengthDateTimeNow = dateString.Length;
            int lengthTimeNow     = timeString.Length;


            SetCursorPosition(maxWidth/2 - lengthDateTimeNow, topLine);
            ForegroundColor = Red;
            WriteLine(dateString);
            SetCursorPosition(maxWidth / 2 - lengthDateTimeNow, ++topLine);
            ForegroundColor = Green;
            WriteLine(timeString);

            SetCursorPosition(2, 9);
            WriteLine("Bezeichnung\tEinzelpreis\tAnzahl\tPostionspreis");

            for (int zeile = 10; zeile < 16; zeile++)
            {
                SetCursorPosition(2, zeile);
                ForegroundColor = (ConsoleColor)(zeile%16);
                double ep =  (zeile * 10.0 + (zeile % 4) / 100.0);
                Write($"Artikel {zeile - 9}\t{ep.ToString("0.00")}\t\t");
                int az = Convert.ToInt32(ReadLine());
                double pos = ep*az;
                SetCursorPosition(40, zeile);
                Write("{0,8:C}",pos); // auf zwei Stellen hinter dem Komma erweitern
                gesamtPreis += pos;
                WriteLine();
                SetCursorPosition(40, CursorTop + 2);
                Write("{0,10:C}", gesamtPreis);
            }

            
            ReadLine();
        }
    }
}

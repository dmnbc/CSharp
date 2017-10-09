using System;
using System.Globalization;
using static System.Console;
using static System.ConsoleColor;

namespace Formatausdruck_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int  maxWidth = LargestWindowWidth;
            int  maxHeight = LargestWindowHeight;
            int topLine = 0;
            string dateString = $"Heute: {DateTime.Now.ToLongDateString()}";
            int lengthDateTimeNow = dateString.Length;
            SetWindowSize(maxWidth/2, maxHeight/2);
            BackgroundColor = Black;
            Clear();
            SetCursorPosition(maxWidth/2 - lengthDateTimeNow-1, topLine);
            ForegroundColor = Red;
            WriteLine(dateString);




            ReadLine();
        }
    }
}

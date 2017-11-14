using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickOnButtonConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Button meinKnopf = new Button("btn_1");
            Button nochnKnopf = new Button("btn_2");
            meinKnopf.OnClick += new Button.Clickhandler(() => { Console.ForegroundColor = ConsoleColor.Blue; });
            meinKnopf.click(meinKnopf);
          
            nochnKnopf.OnClick += new Button.Clickhandler(() => { Console.ForegroundColor = ConsoleColor.Yellow; });
            nochnKnopf.click(nochnKnopf);
            Console.WriteLine("Das hier ist Gelb");
            Console.ReadLine(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickOnButtonConsoleApplication
{
    class Button
    {
        public delegate void Clickhandler();
        private delegate void temp();
        public event Clickhandler OnClick;  // event ist abgeleitet von delegate 
        public string name;
        public Button(string n)
        {
            name = n;
            OnClick += clicked_received;
            OnClick += changeColorAfterClick;
            Delegate[] aufrufliste = OnClick.GetInvocationList();
            OnClick = new Clickhandler(() => { });
            OnClick += (Clickhandler)aufrufliste[1];
            OnClick += (Clickhandler)aufrufliste[0];



            Console.WriteLine("Knopf erstellt");
        }

        public void click(Button sender)
        {
            Console.WriteLine("der Knopf {0} ", sender.name);
            OnClick();
        }


        public void clicked_received()
        {
            Console.WriteLine("Click wurde erkannt "); 
        }
        public void changeColorAfterClick()
        {
            Console.WriteLine("Der Button wird kurz eingedrückt dargestellt ");
        }
    }
}

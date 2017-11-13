using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFactoryConsoleApplication
{   class Auto
    {
        public delegate void InvalidListEventHandler();
        public event         InvalidListEventHandler ListeZuLang;
        public static void   auto_ListeZuLang()
        {
            Console.WriteLine("Dafür haben wir nicht genug Personal");
        }


        private List<DelArbeitsschritte> einzelJobs = new List<DelArbeitsschritte>()
                {StepsToBuild.rohKarrosse_bereitstellen,
                 StepsToBuild.motor_bereitstellen,
                 StepsToBuild.achsen_montieren,
                 StepsToBuild.motor_einsetzen,
                 StepsToBuild.Achsen_Getriebe_verbinden};

        public delegate void DelArbeitsschritte(string auftrag);
        public Auto(string s, int stationen)
        {
            ListeZuLang += new InvalidListEventHandler( auto_ListeZuLang);
            DelArbeitsschritte Auto_bauen = new DelArbeitsschritte((string a) => { });
            foreach (var step in einzelJobs)
            {
                Auto_bauen += step;
            }
            if (einzelJobs.Count() > stationen)
            {
                ListeZuLang();
            }
            else
            { Auto_bauen(s); }
        }
       

    }
    class Program
    {
        
        static void Main(string[] args)
        {
           
            Auto vwGolf = new Auto("VW Golf 1.6", 3);
                  
           
           
            
            
            Console.ReadLine();
        }
    }
}

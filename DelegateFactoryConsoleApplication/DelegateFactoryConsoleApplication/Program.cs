using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFactoryConsoleApplication
{
    class Program
    {
        public delegate void DelArbeitsschritte(string auftrag);
        static void Main(string[] args)
        {
            DelArbeitsschritte Auto_bauen = new DelArbeitsschritte( (string a) => { });

            List<DelArbeitsschritte> einzelJobs = new List<DelArbeitsschritte>()
                {StepsToBuild.rohKarrosse_bereitstellen,
                 StepsToBuild.motor_bereitstellen,
                 StepsToBuild.achsen_montieren,
                 StepsToBuild.motor_einsetzen,
                 StepsToBuild.Achsen_Getriebe_verbinden};      
           
            foreach(var step in einzelJobs)
            {
                Auto_bauen += step;
            }
            Auto_bauen("VW Golf ");



            Console.ReadLine();
        }
    }
}

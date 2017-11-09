using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractConsoleApplication
{
    class SubClass : ClassMaster
    {
        public SubClass()
        {
            Console.WriteLine("Ich bin ein Sub ");
        }

        public  override void melden()
        { Console.WriteLine("Ich der sub, melde mich "); }
    }
}

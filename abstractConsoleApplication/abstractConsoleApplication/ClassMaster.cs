using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractConsoleApplication
{
    abstract class ClassMaster
    {
        public int i;
        public void hallo()
        { Console.WriteLine("hello world"); }

        public abstract void melden();
      //  {;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassMaster masterObject = new ClassMaster();
            masterObject.hallo();
            SubClass subObject = new SubClass();
            subObject.melden();
            Console.ReadLine();
        }
    }
}

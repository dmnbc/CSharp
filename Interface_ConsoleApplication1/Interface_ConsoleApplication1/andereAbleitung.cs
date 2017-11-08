using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_ConsoleApplication1
{
    public class AndereAbleitung : IAnzeige
    {
        public void Entladen()
        {
            throw new NotImplementedException();
        }

        void IAnzeige.Anzeige(string s)
        {
            Console.WriteLine("Ich könnte den string zeigen, will aber nicht ");
        }
    }
}
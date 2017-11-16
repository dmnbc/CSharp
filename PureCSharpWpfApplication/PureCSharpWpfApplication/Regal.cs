using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCSharpWpfApplication
{
    internal class Raum
    {
        public List<int> regale = new List<int>();
        public Raum()
        { for (int i = 0; i < 80; i++)
            {
                regale.Add(i + 3);
            }
        }
    }
}

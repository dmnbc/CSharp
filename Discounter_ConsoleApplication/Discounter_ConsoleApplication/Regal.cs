using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discounter_ConsoleApplication
{
    internal class Regal
    {
        private string _regal_id;
        private float _regal_volumen;
        private Artikel _artikel_im_Regal;

        public Regal()
        {
            Console.WriteLine("Regalkonstruktor()");
            
        }

        internal Artikel artikel_im_Regal
        {
            get
            {
                return _artikel_im_Regal;
            }

            set
            {
                _artikel_im_Regal = value;
                Console.WriteLine("Regal mit neuem Artikel befüllt");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometricsConsoleApplication
{
    public class Figur : IVerschiebbar, IAnzeige
    {
        protected KeyValuePair<int, int> mittelpunkt;
        protected double umfang;
        protected double flaeche;

        public Figur(int x, int y)
        {
           // Console.WriteLine("Figur wird bei {0},{1} erzeugt ",x,y);
            mittelpunkt = new KeyValuePair<int, int>(x,y);
        }

        public KeyValuePair<int, int> Mittelpunkt
        {
            get
            {
                return mittelpunkt;
            }

            set
            {
                mittelpunkt = value;
            }
        }

        public double Umfang
        {
            get
            {
                return umfang;
            }

            set
            {
                umfang = value;
            }
        }

       public double Flaeche
        {
            get
            {
                return flaeche;
            }

            set
            {
                flaeche = value;
            }
        }

        public KeyValuePair<int,int> Verschieben(int x_delta, int y_delta)
        {
            Console.SetCursorPosition(this.Mittelpunkt.Key, this.Mittelpunkt.Value);
            Console.WriteLine("                                                  ");
            return new KeyValuePair<int, int>(this.Mittelpunkt.Key + x_delta, this.Mittelpunkt.Value + y_delta);  

            
        }

        public bool AnzeigeFlaechenÜberwachung(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Anzeige()
        {
            Console.SetCursorPosition(this.Mittelpunkt.Key, this.Mittelpunkt.Value);
            Console.Write("({0}) wird dargestellt",  this.GetType().ToString().Split('.')[1]);
        }
    }
}
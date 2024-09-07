using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_Figuras
{
    public class Cuadrado : Figura
    {
        double ladoC;

        public Cuadrado() { }

        public double LadoC
        {
            get { return ladoC; }
            set { ladoC = value; }
        }

        public override double Area()
        {
            return LadoC * LadoC;
        }
        public override double Perimetro()
        {
            return LadoC * 4;
        }
    }
}

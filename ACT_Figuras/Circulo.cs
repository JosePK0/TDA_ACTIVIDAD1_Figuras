using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_Figuras
{
    public class Circulo : Figura
    {
        double radio;

        public Circulo() { }
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}

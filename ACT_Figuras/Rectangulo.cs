using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_Figuras
{

    public class Rectangulo : Figura
    {
        double basesR;
        double altulaR;
        public Rectangulo() { }
        public double BasesR
        {
            get { return basesR; }
            set { basesR = value; }
        }
        public double AlturaR
        {
            get { return altulaR; }
            set { altulaR = value; }
        }

        public override double Area()
        {
            return BasesR * AlturaR;

        }

        public override double Perimetro()
        {
            return (BasesR * 2 + AlturaR * 2);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_Figuras
{
    public class Triangulo : Figura
    {

        double bases;
        double altura;
        double ladoT_2;
        double ladoT_3;

        public Triangulo() { }

        public double Bases
        {
            get { return bases; }
            set { bases = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double LadoT2
        {
            get { return ladoT_2; }
            set { ladoT_2 = value; }
        }
        public double LadoT3
        {
            get { return ladoT_3; }
            set { ladoT_3 = value; }
        }

        public override double Area()
        {
            return (bases * altura) / 2;
        }
        public override double Perimetro()
        {
            return Bases + LadoT2 + LadoT3;
        }

    }
}

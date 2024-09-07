using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_Figuras
{
    public partial class DatosTriangulo : Form
    {
        Triangulo CalcuTrian = new Triangulo();
        public DatosTriangulo()
        {
            InitializeComponent();
        }

        private void btnPerimetroTri_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(LadoTri1.Text, out double LadoT1) && double.TryParse(LadoTri2.Text, out double LadoT2) && double.TryParse(LadoTri1.Text, out double LadoT3)))
            {
                errorProvider1.SetError(DatPerimetroT, "Dato no valido");
            }
            else
            {
                CalcuTrian.Bases = LadoT1;
                CalcuTrian.LadoT2 = LadoT2;
                CalcuTrian.LadoT3 = LadoT3;

                double PerimetroTriangulo = CalcuTrian.Perimetro();
                errorProvider1.SetError(DatAreaT, "");
                PerimetroTriangulo = Math.Round(PerimetroTriangulo, 2);


                MessageBox.Show($"El perimetro del Cuadrado es: {PerimetroTriangulo}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAreaTri_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(AlturaTri.Text, out double AlturasTri) && double.TryParse(BaseTri.Text, out double BasesTri)))
            {
                errorProvider1.SetError(DatPerimetroT, "Dato no valido");
            }
            else
            {
                CalcuTrian.Bases = BasesTri;
                CalcuTrian.Altura = AlturasTri;

                double AreaTriangulo = CalcuTrian.Area();
                errorProvider1.SetError(DatAreaT, "");
                AreaTriangulo = Math.Round(AreaTriangulo, 2);


                MessageBox.Show($"El perimetro del Cuadrado es: {AreaTriangulo}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}

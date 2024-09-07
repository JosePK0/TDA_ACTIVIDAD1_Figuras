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
    public partial class DatosCuadrado : Form
    {
        Cuadrado CalcularCua = new Cuadrado();
        public DatosCuadrado()
        {
            InitializeComponent();
        }

        private void btnAreaCua_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(Lado1Cua.Text, out double Lado1C))
            {
                errorProvider1.SetError(DatCuadrado, "Dato no valido");
            }
            else
            {
                errorProvider1.SetError(DatCuadrado, "");

                CalcularCua.LadoC = Lado1C;

                double AreaCuadrado = CalcularCua.Area();
                AreaCuadrado = Math.Round(AreaCuadrado, 2);

                MessageBox.Show($"El area del Cuadrado es: {AreaCuadrado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(Lado1Cua.Text, out double Lado1C))
            {
                errorProvider1.SetError(DatCuadrado, "Dato no valido");
            }
            else
            {
                errorProvider1.SetError(DatCuadrado, "");

                CalcularCua.LadoC = Lado1C;

                double PerimetroCuadrado = CalcularCua.Perimetro();
                PerimetroCuadrado = Math.Round(PerimetroCuadrado, 2);

                MessageBox.Show($"El perimetro del Cuadrado es: {PerimetroCuadrado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

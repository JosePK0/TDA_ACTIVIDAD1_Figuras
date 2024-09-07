using Microsoft.VisualBasic.Devices;
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
    public partial class DatosCirculo : Form
    {
        Circulo calculoCirculo = new Circulo();
        public DatosCirculo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAreaCir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(RadioCir.Text, out double radio))
            {
                errorProvider1.SetError(DatCir, "Dato no valido");
            }
            else
            {
                
                errorProvider1.SetError(RadioCir, "");

                calculoCirculo.Radio = radio;

                double areaCirculo = calculoCirculo.Area();
                areaCirculo = Math.Round(areaCirculo, 2);


                MessageBox.Show($"El área del círculo es: {areaCirculo}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPerimetroCir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(RadioCir.Text, out double radio))
            {
                errorProvider1.SetError(DatCir, "Dato no valido");
            }
            else
            {

                errorProvider1.SetError(RadioCir, "");
                
                calculoCirculo.Radio = radio;

                double PerimetroCirculo = calculoCirculo.Perimetro();
                PerimetroCirculo = Math.Round(PerimetroCirculo, 2);


                MessageBox.Show($"El perimetro del Circulo es: {PerimetroCirculo}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

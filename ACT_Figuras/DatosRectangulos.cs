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
    public partial class DatosRectangulos : Form
    {
        Rectangulo CalcuRec = new Rectangulo();
        public DatosRectangulos()
        {
            InitializeComponent();
        }

        private void btnAreaRec_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(AlturaRect.Text, out double AlturasR) && double.TryParse(BaseRect.Text, out double BaseR)))
            {
                errorProvider1.SetError(DatRect, "Dato no valido");
            }
            else
            {
                errorProvider1.SetError(BaseRec, "");

                CalcuRec.BasesR = BaseR;
                CalcuRec.AlturaR = AlturasR;

                double AreaRectangulo = CalcuRec.Area();
                AreaRectangulo = Math.Round(AreaRectangulo, 2);

                MessageBox.Show($"El perimetro del Cuadrado es: {AreaRectangulo}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnPerimetroRec_Click(object sender, EventArgs e)
        {
            if (!(double.TryParse(AlturaRect.Text, out double AlturasR) && double.TryParse(BaseRect.Text, out double BaseR)))
            {
                errorProvider1.SetError(DatRect, "Dato no valido");
            }
            else
            {
                errorProvider1.SetError(BaseRec, "");

                CalcuRec.BasesR = BaseR;
                CalcuRec.AlturaR = AlturasR;

                double PerimetroRectangulo = CalcuRec.Perimetro();
                PerimetroRectangulo = Math.Round(PerimetroRectangulo, 2);

                MessageBox.Show($"El perimetro del Cuadrado es: {PerimetroRectangulo}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

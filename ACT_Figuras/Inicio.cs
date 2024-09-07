namespace ACT_Figuras
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            using (DatosCirculo ventanadatosCirculos = new DatosCirculo())
                ventanadatosCirculos.ShowDialog();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)

        {
            using (DatosTriangulo ventanaTriangulo = new DatosTriangulo ())
                ventanaTriangulo.ShowDialog();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            using (DatosRectangulos ventanaRectangulo = new DatosRectangulos())
                ventanaRectangulo.ShowDialog();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            using (DatosCuadrado ventanaCuadrado = new DatosCuadrado())
                ventanaCuadrado.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

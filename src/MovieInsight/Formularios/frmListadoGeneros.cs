
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmListadoGeneros : Form
    {
        public frmListadoGeneros()
        {
            InitializeComponent();

            // Conecto el botón con el procedimiento de listado.
            cmdListar.Click += cmdListar_Click;
        }

        // Muestro todos los géneros cargados en el vector.
        private void cmdListar_Click(object sender, EventArgs e)
        {
            // Limpio la grilla para evitar datos repetidos.
            dgvGeneros.Rows.Clear();

            // Recorro solamente las posiciones ocupadas.
            for (int i = 0; i < DatosGlobales.IND; i++)
            {
                dgvGeneros.Rows.Add(
                    DatosGlobales.Generos[i].Codigo,
                    DatosGlobales.Generos[i].Nombre,
                    DatosGlobales.Generos[i].Descripcion
                );
            }

            // Muestro la cantidad de géneros registrados.
            lblContador.Text = "Géneros cargados: " + DatosGlobales.IND;

            // Aviso cuando todavía no hay géneros.
            if (DatosGlobales.IND == 0)
            {
                MessageBox.Show(
                    "Todavía no hay géneros cargados.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}

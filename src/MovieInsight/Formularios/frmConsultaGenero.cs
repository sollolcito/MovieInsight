
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmConsultaGenero : Form
    {
        public frmConsultaGenero()
        {
            InitializeComponent();

            // Conecto los eventos del formulario y del botón.
            this.Load += frmConsultaGenero_Load;
            cmdConsultar.Click += cmdConsultar_Click;
        }

        // Al abrir el formulario, cargo los géneros en el ComboBox.
        private void frmConsultaGenero_Load(object sender, EventArgs e)
        {
            // Limpio el ComboBox antes de cargar los nombres.
            cmbGenero.Items.Clear();

            // Recorro solamente los géneros cargados.
            for (int i = 0; i < DatosGlobales.IND; i++)
            {
                cmbGenero.Items.Add(DatosGlobales.Generos[i].Nombre);
            }

            // Inicialmente no hay ningún género seleccionado.
            cmbGenero.SelectedIndex = -1;

            // Limpio los resultados de consultas anteriores.
            lblCodigo.Text = "Código: -";
            lblDescripcion.Text = "Descripción: -";
        }

        // Muestro los datos del género seleccionado.
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            // Compruebo que se haya seleccionado un género.
            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Primero debe seleccionar un género.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbGenero.Focus();
                return;
            }

            // Obtengo la posición seleccionada en el ComboBox.
            int posicion = cmbGenero.SelectedIndex;

            // Muestro el código correspondiente.
            lblCodigo.Text = "Código: " +
                DatosGlobales.Generos[posicion].Codigo;

            // Muestro la descripción completa.
            lblDescripcion.Text = "Descripción:\n\n" +
                DatosGlobales.Generos[posicion].Descripcion;
        }
    }
}

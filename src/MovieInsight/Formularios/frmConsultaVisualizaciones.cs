
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmConsultaVisualizaciones : Form
    {
        public frmConsultaVisualizaciones()
        {
            InitializeComponent();

            // Conecto los eventos del formulario.
            this.Load += frmConsultaVisualizaciones_Load;
            cmdConsultar.Click += cmdConsultar_Click;

            // Controlo las selecciones de los ComboBox.
            cmbGenero.SelectedIndexChanged += ControlarCampos;
            cmbMes.SelectedIndexChanged += ControlarCampos;

            // El botón comienza deshabilitado.
            cmdConsultar.Enabled = false;
        }

        // Cargo los géneros y los meses al abrir el formulario.
        private void frmConsultaVisualizaciones_Load(object sender, EventArgs e)
        {
            // Limpio los ComboBox antes de cargar los datos.
            cmbGenero.Items.Clear();
            cmbMes.Items.Clear();

            // Recorro los géneros que están cargados.
            for (int i = 0; i < DatosGlobales.IND; i++)
            {
                cmbGenero.Items.Add(DatosGlobales.Generos[i].Nombre);
            }

            // Recorro los 12 meses del año.
            for (int i = 0; i < DatosGlobales.Meses.Length; i++)
            {
                cmbMes.Items.Add(DatosGlobales.Meses[i]);
            }

            // Dejo los ComboBox sin selección.
            cmbGenero.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;

            // Limpio el resultado.
            lblCantidad.Text = "Visualizaciones: -";

            ControlarCampos(null, EventArgs.Empty);
        }

        // Habilito el botón cuando se seleccionan ambos datos.
        private void ControlarCampos(object sender, EventArgs e)
        {
            cmdConsultar.Enabled =
                cmbGenero.SelectedIndex != -1 &&
                cmbMes.SelectedIndex != -1;

            // Limpio el resultado si cambia alguna selección.
            lblCantidad.Text = "Visualizaciones: -";
        }

        // Consulto la cantidad guardada en la matriz.
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            // Obtengo las posiciones seleccionadas.
            int fila = cmbGenero.SelectedIndex;
            int columna = cmbMes.SelectedIndex;

            // Compruebo que ambas selecciones sean válidas.
            if (fila < 0 || columna < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un género y un mes.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Obtengo la cantidad almacenada en la matriz.
            int cantidad =
                DatosGlobales.Visualizaciones[fila, columna];

            // Muestro el resultado en la etiqueta.
            lblCantidad.Text =
                "Visualizaciones de " +
                cmbGenero.Text + " en " +
                cmbMes.Text + ": " +
                cantidad;
        }
    }
}

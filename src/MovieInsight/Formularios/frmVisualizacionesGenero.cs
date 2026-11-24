
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmVisualizacionesGenero : Form
    {
        public frmVisualizacionesGenero()
        {
            InitializeComponent();

            // Conecto los eventos sin modificar el Designer.
            this.Load += frmVisualizacionesGenero_Load;
            cmdListar.Click += cmdListar_Click;
            cmbGenero.SelectedIndexChanged += cmbGenero_SelectedIndexChanged;

            // El botón comienza deshabilitado.
            cmdListar.Enabled = false;
        }

        // Cargo los géneros cuando se abre el formulario.
        private void frmVisualizacionesGenero_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();

            // Recorro solamente los géneros cargados.
            for (int i = 0; i < DatosGlobales.IND; i++)
            {
                cmbGenero.Items.Add(DatosGlobales.Generos[i].Nombre);
            }

            // Dejo el ComboBox sin selección.
            cmbGenero.SelectedIndex = -1;

            LimpiarResultados();
        }

        // Cuando cambia el género, limpio los datos anteriores.
        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdListar.Enabled = cmbGenero.SelectedIndex != -1;

            LimpiarResultados();
        }

        // Limpio la grilla y las etiquetas.
        private void LimpiarResultados()
        {
            dgvVisualizaciones.Rows.Clear();

            lblTotal.Text = "Total: -";
            lblPromedio.Text = "Promedio: -";
            lblMaximo.Text = "Máximo: -";
            lblMinimo.Text = "Mínimo: -";
        }

        // Muestro las visualizaciones del género seleccionado.
        private void cmdListar_Click(object sender, EventArgs e)
        {
            // Verifico que se haya seleccionado un género.
            if (cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un género.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Obtengo la fila correspondiente al género.
            int fila = cmbGenero.SelectedIndex;

            // Variables para los cálculos.
            long total = 0;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;

            // Limpio la grilla para evitar filas repetidas.
            dgvVisualizaciones.Rows.Clear();

            // Recorro los 12 meses del año.
            for (int columna = 0; columna < DatosGlobales.Meses.Length; columna++)
            {
                // Obtengo las visualizaciones del género en cada mes.
                int cantidad =
                    DatosGlobales.Visualizaciones[fila, columna];

                // Agrego el mes y la cantidad a la grilla.
                dgvVisualizaciones.Rows.Add(
                    DatosGlobales.Meses[columna],
                    cantidad
                );

                // Acumulo las visualizaciones.
                total += cantidad;

                // Busco la cantidad máxima.
                if (cantidad > maximo)
                {
                    maximo = cantidad;
                }

                // Busco la cantidad mínima.
                if (cantidad < minimo)
                {
                    minimo = cantidad;
                }
            }

            // Calculo el promedio de los 12 meses.
            double promedio =
                (double)total / DatosGlobales.Meses.Length;

            // Muestro los resultados.
            lblTotal.Text = "Total: " + total;
            lblPromedio.Text = "Promedio: " +
                promedio.ToString("N2");
            lblMaximo.Text = "Máximo: " + maximo;
            lblMinimo.Text = "Mínimo: " + minimo;
        }
    }
}

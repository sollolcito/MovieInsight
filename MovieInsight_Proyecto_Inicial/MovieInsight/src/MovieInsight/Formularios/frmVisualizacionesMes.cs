
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmVisualizacionesMes : Form
    {
        public frmVisualizacionesMes()
        {
            InitializeComponent();

            // Conecto los eventos.
            this.Load += frmVisualizacionesMes_Load;
            cmdListar.Click += cmdListar_Click;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;

            // El botón comienza deshabilitado.
            cmdListar.Enabled = false;
        }

        // Carga de  los meses al abrir el formulario.
        private void frmVisualizacionesMes_Load(object sender, EventArgs e)
        {
            cmbMes.Items.Clear();

            // Recorro el vector que contiene los meses.
            for (int i = 0; i < DatosGlobales.Meses.Length; i++)
            {
                cmbMes.Items.Add(DatosGlobales.Meses[i]);
            }

            cmbMes.SelectedIndex = -1;

            // Limpio los resultados.
            LimpiarResultados();
        }

        // Se Habilita el botón cuando el usuario elige un mes.
        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdListar.Enabled = cmbMes.SelectedIndex != -1;

            // Evito mostrar resultados de un mes anterior.
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

        // Muestro las visualizaciones del mes seleccionado.
        private void cmdListar_Click(object sender, EventArgs e)
        {
            // Verifico que se haya seleccionado un mes.
            if (cmbMes.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un mes.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Verifico que existan géneros cargados.
            if (DatosGlobales.IND == 0)
            {
                MessageBox.Show(
                    "Todavía no hay géneros cargados.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LimpiarResultados();
                return;
            }

            // Obtengo la columna correspondiente al mes.
            int columna = cmbMes.SelectedIndex;

            // Variables para realizar los cálculos.
            long total = 0;
            int maximo = 0;
            int minimo = int.MaxValue;

            // Limpio la grilla antes de mostrar los datos.
            dgvVisualizaciones.Rows.Clear();

            // Recorro todos los géneros cargados.
            for (int fila = 0; fila < DatosGlobales.IND; fila++)
            {
                // Obtengo las visualizaciones del género en ese mes.
                int cantidad =
                    DatosGlobales.Visualizaciones[fila, columna];

                // Agrego los datos a la grilla.
                dgvVisualizaciones.Rows.Add(
                    DatosGlobales.Generos[fila].Nombre,
                    cantidad
                );

                // Acumulo el total de visualizaciones.
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

            // Calculo el promedio entre los géneros cargados.
            double promedio = (double)total / DatosGlobales.IND;

            // Muestro los resultados en las etiquetas.
            lblTotal.Text = "Total: " + total;
            lblPromedio.Text = "Promedio: " +
                promedio.ToString("N2");
            lblMaximo.Text = "Máximo: " + maximo;
            lblMinimo.Text = "Mínimo: " + minimo;
        }
    }
}

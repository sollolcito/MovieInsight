
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmRegistrarVisualizacion : Form
    {
        public frmRegistrarVisualizacion()
        {
            InitializeComponent();

            // Conecto los eventos del formulario y del botón.
            this.Load += frmRegistrarVisualizacion_Load;
            cmdCargar.Click += cmdCargar_Click;

            // El botón comienza deshabilitado.
            cmdCargar.Enabled = false;

            // Controlo los campos cuando cambian.
            cmbGenero.SelectedIndexChanged += ControlarCampos;
            cmbMes.SelectedIndexChanged += ControlarCampos;
            txtCantidad.TextChanged += ControlarCampos;
        }

        // Cargo los géneros y los meses cuando abre el formulario.
        private void frmRegistrarVisualizacion_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Clear();
            cmbMes.Items.Clear();

            // Cargo solamente los géneros registrados.
            for (int i = 0; i < DatosGlobales.IND; i++)
            {
                cmbGenero.Items.Add(DatosGlobales.Generos[i].Nombre);
            }

            // Cargo los 12 meses del año.
            for (int i = 0; i < DatosGlobales.Meses.Length; i++)
            {
                cmbMes.Items.Add(DatosGlobales.Meses[i]);
            }

            // Dejo ambos ComboBox sin selección.
            cmbGenero.SelectedIndex = -1;
            cmbMes.SelectedIndex = -1;

            ControlarCampos(null, EventArgs.Empty);
        }

        // Verifico que todos los campos estén completos.
        private void ControlarCampos(object sender, EventArgs e)
        {
            if (cmbGenero.SelectedIndex != -1 &&
                cmbMes.SelectedIndex != -1 &&
                txtCantidad.Text.Trim() != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }

        // Registro las visualizaciones en la matriz.
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            // Compruebo que la cantidad sea un número entero.
            int cantidad;

            if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad))
            {
                MessageBox.Show(
                    "La cantidad debe ser un número entero válido.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidad.Focus();
                return;
            }

            // No permito cantidades negativas.
            if (cantidad < 0)
            {
                MessageBox.Show(
                    "La cantidad no puede ser negativa.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCantidad.Focus();
                return;
            }

            // Obtengo las posiciones del género y del mes.
            int fila = cmbGenero.SelectedIndex;
            int columna = cmbMes.SelectedIndex;

            // Compruebo que la suma no supere el máximo de int.
            if (cantidad > int.MaxValue -
                DatosGlobales.Visualizaciones[fila, columna])
            {
                MessageBox.Show(
                    "La cantidad ingresada supera el límite permitido.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Sumo las nuevas visualizaciones a las existentes.
            DatosGlobales.Visualizaciones[fila, columna] += cantidad;

            // Muestro el nuevo total.
            MessageBox.Show(
                "Visualizaciones registradas correctamente.\n\n" +
                "Género: " + cmbGenero.Text +
                "\nMes: " + cmbMes.Text +
                "\nCantidad agregada: " + cantidad +
                "\nTotal acumulado: " +
                DatosGlobales.Visualizaciones[fila, columna],
                "MovieInsight",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpio solamente la cantidad.
            // Mantengo el género y el mes por si quiero seguir cargando.
            txtCantidad.Clear();
            txtCantidad.Focus();
        }
    }
}

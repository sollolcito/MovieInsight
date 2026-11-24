
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmAgregarGenero : Form
    {
        public frmAgregarGenero()
        {
            InitializeComponent();

            // Conecto los eventos de las cajas de texto.
            txtCodigo.TextChanged += ControlarCajasDeTexto;
            txtNombre.TextChanged += ControlarCajasDeTexto;
            txtDescripcion.TextChanged += ControlarCajasDeTexto;

            // Conecto el evento del botón Cargar.
            cmdCargar.Click += cmdCargar_Click;

            // Al iniciar, controlo si se puede cargar.
            ControlarCajasDeTexto(null, EventArgs.Empty);
        }

        // Controlo que las tres cajas tengan datos.
        private void ControlarCajasDeTexto(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() != "" &&
                txtNombre.Text.Trim() != "" &&
                txtDescripcion.Text.Trim() != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }

        // Procedimiento para cargar un género.
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            // Primero compruebo si tengo espacio en el vector.
            if (DatosGlobales.IND >= DatosGlobales.Generos.Length)
            {
                MessageBox.Show(
                    "No se pueden agregar más géneros.\n" +
                    "El vector ya tiene 10 géneros cargados.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Compruebo que el código sea un número entero.
            int codigo;

            if (!int.TryParse(txtCodigo.Text.Trim(), out codigo))
            {
                MessageBox.Show(
                    "El código debe ser un número entero válido.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCodigo.Focus();
                return;
            }

            // Busco si ya existe el código ingresado.
            int i = 0;
            bool encontrado = false;

            while (i < DatosGlobales.IND && encontrado == false)
            {
                if (DatosGlobales.Generos[i].Codigo == codigo)
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }

            // Si el código ya existe, no permito cargarlo.
            if (encontrado == true)
            {
                MessageBox.Show(
                    "Ya existe un género con ese código.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCodigo.Focus();
                return;
            }

            // Guardo los datos en la posición disponible.
            DatosGlobales.Generos[DatosGlobales.IND].Codigo = codigo;
            DatosGlobales.Generos[DatosGlobales.IND].Nombre =
                txtNombre.Text.Trim();
            DatosGlobales.Generos[DatosGlobales.IND].Descripcion =
                txtDescripcion.Text.Trim();

            // Aumento el índice porque cargué un género.
            DatosGlobales.IND++;

            MessageBox.Show(
                "Género cargado correctamente.\n\n" +
                "Total de géneros: " + DatosGlobales.IND,
                "MovieInsight",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpio las cajas para una nueva carga.
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();

            txtCodigo.Focus();
        }
    }
}

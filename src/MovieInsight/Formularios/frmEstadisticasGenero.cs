
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmEstadisticasGenero : Form
    {
        public frmEstadisticasGenero()
        {
            InitializeComponent();

            // Conecto el boton listar.
            cmdListar.Click += cmdListar_Click;
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            // Limpio la grilla antes de listar.
            dgvEstadisticas.Rows.Clear();

            // Compruebo si hay generos cargados.
            if (DatosGlobales.IND == 0)
            {
                MessageBox.Show(
                    "No hay generos cargados.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Recorro los generos que tengo cargados.
            for (int fila = 0; fila < DatosGlobales.IND; fila++)
            {
                long total = 0;

                // Tomo el primer mes para comparar.
                int maximo = DatosGlobales.Visualizaciones[fila, 0];
                int minimo = DatosGlobales.Visualizaciones[fila, 0];

                int posicionMaximo = 0;
                int posicionMinimo = 0;

                // Recorro los 12 meses de cada genero.
                for (int columna = 0;
                     columna < DatosGlobales.Meses.Length;
                     columna++)
                {
                    int cantidad =
                        DatosGlobales.Visualizaciones[fila, columna];

                    // Voy sumando las visualizaciones.
                    total += cantidad;

                    // Busco el valor mayor.
                    if (cantidad > maximo)
                    {
                        maximo = cantidad;
                        posicionMaximo = columna;
                    }

                    // Busco el valor menor.
                    if (cantidad < minimo)
                    {
                        minimo = cantidad;
                        posicionMinimo = columna;
                    }
                }

                // Saco el promedio de los 12 meses.
                double promedio =
                    (double)total / DatosGlobales.Meses.Length;

                // Busco los nombres de los meses.
                string mesMaximo =
                    DatosGlobales.Meses[posicionMaximo];

                string mesMinimo =
                    DatosGlobales.Meses[posicionMinimo];

                // Muestro los resultados en la grilla.
                dgvEstadisticas.Rows.Add(
                    DatosGlobales.Generos[fila].Nombre,
                    total,
                    promedio.ToString("N2"),
                    mesMaximo,
                    mesMinimo
                );
            }
        }
    }
}

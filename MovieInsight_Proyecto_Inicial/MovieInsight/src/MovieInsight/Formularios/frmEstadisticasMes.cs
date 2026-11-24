
using System;
using System.Windows.Forms;

namespace MovieInsight.Formularios
{
    public partial class frmEstadisticasMes : Form
    {
        public frmEstadisticasMes()
        {
            InitializeComponent();

            // Conecto el botón con el procedimiento de listado.
            cmdListar.Click += cmdListar_Click;
        }

        // Calculo las estadísticas de todos los meses.
        private void cmdListar_Click(object sender, EventArgs e)
        {
            // Limpio la grilla para evitar filas duplicadas.
            dgvEstadisticas.Rows.Clear();

            // Compruebo que existan géneros cargados.
            if (DatosGlobales.IND == 0)
            {
                MessageBox.Show(
                    "Todavía no hay géneros cargados.",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Recorro los doce meses del año.
            for (int columna = 0; columna < DatosGlobales.Meses.Length; columna++)
            {
                // Variables para los cálculos de cada mes.
                long total = 0;

                // Tomo el primer género como valor inicial.
                int maximo = DatosGlobales.Visualizaciones[0, columna];
                int minimo = DatosGlobales.Visualizaciones[0, columna];

                // Guardo las posiciones del mayor y menor.
                int posicionMaximo = 0;
                int posicionMinimo = 0;

                // Recorro los géneros cargados.
                for (int fila = 0; fila < DatosGlobales.IND; fila++)
                {
                    // Obtengo las visualizaciones del género.
                    int cantidad =
                        DatosGlobales.Visualizaciones[fila, columna];

                    // Acumulo las visualizaciones del mes.
                    total += cantidad;

                    // Busco el género más visto.
                    if (cantidad > maximo)
                    {
                        maximo = cantidad;
                        posicionMaximo = fila;
                    }

                    // Busco el género menos visto.
                    if (cantidad < minimo)
                    {
                        minimo = cantidad;
                        posicionMinimo = fila;
                    }
                }

                // Calculo el promedio entre los géneros cargados.
                double promedio =
                    (double)total / DatosGlobales.IND;

                // Obtengo los nombres de los géneros.
                string generoMaximo =
                    DatosGlobales.Generos[posicionMaximo].Nombre;

                string generoMinimo =
                    DatosGlobales.Generos[posicionMinimo].Nombre;

                // Agrego los resultados a la grilla.
                dgvEstadisticas.Rows.Add(
                    DatosGlobales.Meses[columna],
                    total,
                    promedio.ToString("N2"),
                    generoMaximo,
                    generoMinimo
                );
            }
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace MovieInsight
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            string imagen = Path.Combine(Application.StartupPath, "assets", "principal", "banner_movieinsight.png");
            if (File.Exists(imagen))
            {
                // Copiar el archivo a memoria evita dejar bloqueada la imagen en disco.
                using (var temporal = Image.FromFile(imagen))
                    picBanner.Image = new Bitmap(temporal);
            }
        }
        private void mnuSistemaOpcion0_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmAcercaDe()) ventana.ShowDialog(this);
        }
        private void mnuSistemaOpcion1_Click(object sender, EventArgs e)
        {
            // cargar los 10 géneros y la matriz con valores aleatorios entre 0 y 100.
            DialogResult respuesta = MessageBox.Show(
        "¿Desea realizar la carga automática de datos?\n\n" +
        "Se cargarán los 10 géneros y se generarán las visualizaciones.\n" +
        "Los datos existentes serán reemplazados.",
        "MovieInsight - Carga automática",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                CargarDatosAutomaticamente();

                MessageBox.Show(
                    "Carga automática realizada correctamente.\n\n" +
                    "Géneros cargados: " + DatosGlobales.IND +
                    "\nVisualizaciones generadas: 120",
                    "MovieInsight",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    
        private void mnuSistemaOpcion2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuGenerosOpcion0_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmAgregarGenero()) ventana.ShowDialog(this);
        }
        private void mnuGenerosOpcion1_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmListadoGeneros()) ventana.ShowDialog(this);
        }
        private void mnuGenerosOpcion2_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmConsultaGenero()) ventana.ShowDialog(this);
        }
        private void mnuVisualizacionesOpcion0_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmRegistrarVisualizacion()) ventana.ShowDialog(this);
        }
        private void mnuVisualizacionesOpcion1_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmConsultaVisualizaciones()) ventana.ShowDialog(this);
        }
        private void mnuVisualizacionesOpcion2_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmVisualizacionesMes()) ventana.ShowDialog(this);
        }
        private void mnuVisualizacionesOpcion3_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmVisualizacionesGenero()) ventana.ShowDialog(this);
        }
        private void mnuVisualizacionesOpcion4_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmEstadisticasMes()) ventana.ShowDialog(this);
        }
        private void mnuVisualizacionesOpcion5_Click(object sender, EventArgs e)
        {
            using (var ventana = new Formularios.frmEstadisticasGenero()) ventana.ShowDialog(this);
        }

        private void CargarDatosAutomaticamente()
        {
            // Cargo los 10 géneros con sus códigos, nombres y descripciones.
            DatosGlobales.Generos[0] = new RegistroGenero
            {
                Codigo = 1,
                Nombre = "Acción",
                Descripcion = "Películas llenas de emocionantes escenas de persecuciones, combates y situaciones de riesgo."
            };

            DatosGlobales.Generos[1] = new RegistroGenero
            {
                Codigo = 2,
                Nombre = "Comedia",
                Descripcion = "Películas diseñadas para hacer reír al público con situaciones cómicas y humor."
            };

            DatosGlobales.Generos[2] = new RegistroGenero
            {
                Codigo = 3,
                Nombre = "Drama",
                Descripcion = "Historias centradas en el desarrollo emocional de los personajes, a menudo explorando situaciones intensas."
            };

            DatosGlobales.Generos[3] = new RegistroGenero
            {
                Codigo = 4,
                Nombre = "Ciencia Ficción",
                Descripcion = "Películas que presentan elementos de ciencia avanzada, tecnología futurista y conceptos imaginativos."
            };

            DatosGlobales.Generos[4] = new RegistroGenero
            {
                Codigo = 5,
                Nombre = "Romántica",
                Descripcion = "Historias centradas en relaciones amorosas y emociones románticas."
            };

            DatosGlobales.Generos[5] = new RegistroGenero
            {
                Codigo = 6,
                Nombre = "Terror",
                Descripcion = "Películas destinadas a asustar o provocar miedo en la audiencia."
            };

            DatosGlobales.Generos[6] = new RegistroGenero
            {
                Codigo = 7,
                Nombre = "Fantasía",
                Descripcion = "Historias que incluyen elementos mágicos, criaturas extraordinarias y mundos imaginarios."
            };

            DatosGlobales.Generos[7] = new RegistroGenero
            {
                Codigo = 8,
                Nombre = "Misterio",
                Descripcion = "Películas que involucran la resolución de un enigma o crimen."
            };

            DatosGlobales.Generos[8] = new RegistroGenero
            {
                Codigo = 9,
                Nombre = "Aventura",
                Descripcion = "Narrativas emocionantes que siguen a los personajes en viajes y desafíos."
            };

            DatosGlobales.Generos[9] = new RegistroGenero
            {
                Codigo = 10,
                Nombre = "Animación",
                Descripcion = "Películas que utilizan técnicas de animación para contar historias, generalmente dirigidas a un público más joven."
            };

            // Actualizo el índice global.
            DatosGlobales.IND = 10;

            // Creo el generador de números aleatorios.
            Random aleatorio = new Random();

            // Recorro las 10 filas de géneros.
            for (int fila = 0; fila < 10; fila++)
            {
                // Recorro las 12 columnas correspondientes a los meses.
                for (int columna = 0; columna < 12; columna++)
                {
                    DatosGlobales.Visualizaciones[fila, columna] =
                        aleatorio.Next(0, 101);
                }
            }
        }

    }
}

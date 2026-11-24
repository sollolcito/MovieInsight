namespace MovieInsight
{
    public struct RegistroGenero
    {
        public int Codigo;
        public string Nombre;
        public string Descripcion;
    }

    public static class DatosGlobales
    {
        public static RegistroGenero[] Generos = new RegistroGenero[10];
        public static int IND = 0;
        public static string[] Meses = new string[12]
        {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        };
        public static int[,] Visualizaciones = new int[10, 12];
    }
}

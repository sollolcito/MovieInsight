# MovieInsight 🎬
**Trabajo Integrador / Examen Final — Laboratorio de Programación 1, IES Siglo 21**  
Tutora: Erica Bongiovanni. Proyecto de estudio en **C# + Windows Forms + .NET Framework 4.7.2**, compatible con Visual Studio 2017.

## Estado actual
**Etapa 1: estructura y diseño, sin lógica de procesamiento.** Se incluyen 11 formularios editables en el Diseñador, MenuStrip con las opciones exigidas, RegistroGenero, los vectores, la matriz y el banner original. Los botones de cálculos y las validaciones todavía están pendientes; no es la entrega final terminada.

## Abrir en Visual Studio
1. Descomprimir el archivo en una carpeta local, sin separar `assets` de `src`.
2. Abrir `MovieInsight.sln` en Visual Studio 2017 o posterior.
3. Verificar que esté disponible el **Developer/Targeting Pack de .NET Framework 4.7.2**.
4. En el Explorador de soluciones abrir cualquier formulario en **Ver diseñador**. Para código utilizar F7.
5. Ejecutar con F5. El `.exe` compilado estará en `src\MovieInsight\bin\Debug\MovieInsight.exe`.

## Formularios
- frmPrincipal: ventana principal maximizada y menús Sistema, Géneros y Visualizaciones.
- frmAcercaDe: información de examen, pendiente completar nombre y DNI del alumno.
- frmAgregarGenero: TextBox para Código, Nombre, Descripción y cmdCargar.
- frmListadoGeneros: grilla de 3 columnas, contador y cmdListar.
- frmConsultaGenero: ComboBox, labels de código y descripción y cmdConsultar.
- frmRegistrarVisualizacion: ComboBox de género y mes, cantidad y cmdCargar.
- frmConsultaVisualizaciones: selección de género y mes, resultado y cmdConsultar.
- frmVisualizacionesMes / frmVisualizacionesGenero: grillas y etiquetas Total, Promedio, Máximo y Mínimo.
- frmEstadisticasMes / frmEstadisticasGenero: grillas de 5 columnas y cmdListar.

## DatosGlobales
`RegistroGenero` con Código Int32, Nombre String y Descripción String. `Generos[10]`, `IND`, `Meses[12]` inicializados y `Visualizaciones[10,12]` de tipo Int32.

## Pendiente de programar
Carga automática aleatoria 0–100, altas y validación, listados, consultas, acumulación de visualizaciones, cálculo de promedios y extremos, control de límites, pruebas y revisión de títulos. La opción de carga automática será un procedimiento del menú, no una ventana extra.

**Advertencia:** la solución está generada para revisión en Visual Studio; no se pudo compilar en este entorno Linux con Visual Studio 2017. Validar apertura del diseñador y compilación en Windows antes de usarla para evaluación.

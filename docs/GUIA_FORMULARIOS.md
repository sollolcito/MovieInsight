# MovieInsight - Guía de formularios

Proyecto integrador / Examen final de Laboratorio de Programación 1 - IES Siglo 21.

## Formulario principal
- `frmPrincipal`: maximizado, MenuStrip con Sistema, Géneros y Visualizaciones. Diseño oscuro cinematográfico, paneles, logo y recursos opcionales.

## Formularios secundarios
| Formulario sugerido | Menú |
| --- | --- |
| `frmAcercaDe` | Sistema > Acerca de… |
| `frmAgregarGenero` | Géneros > Agregar nuevo género… |
| `frmListadoGeneros` | Géneros > Listado general de géneros… |
| `frmConsultaGenero` | Géneros > Consulta de datos de un género… |
| `frmRegistrarVisualizacion` | Visualizaciones > Registrar visualización… |
| `frmConsultaVisualizaciones` | Visualizaciones > Consulta de visualizaciones… |
| `frmVisualizacionesMes` | Visualizaciones > Visualizaciones de un mes… |
| `frmVisualizacionesGenero` | Visualizaciones > Visualizaciones de un género… |
| `frmEstadisticasMes` | Visualizaciones > Estadística de visualizaciones por mes… |
| `frmEstadisticasGenero` | Visualizaciones > Estadística de visualizaciones por género… |

**Carga automática de datos**: la consigna pide una opción del menú que cargue registros y matriz; no exige abrir un formulario. Es preferible programarla como acción del menú con confirmación de resultado.

## Controles obligatorios
- Agregar género: 3 TextBox y `cmdCargar` deshabilitado si alguno está vacío.
- Listado general: DataGridView (Código, Nombre, Descripción), contador y `cmdListar`.
- Consulta de género: ComboBox cargado en Load, Label código y descripción multilínea, `cmdConsultar`.
- Registrar visualización: ComboBox género y mes, TextBox cantidad, `cmdCargar` suma a la matriz.
- Consulta de visualizaciones: ComboBox género y mes, Label cantidad, `cmdConsultar`.
- Visualizaciones por mes: ComboBox meses, DataGridView (Género, Cantidad), `cmdListar`, Label total, promedio, máximo y mínimo.
- Visualizaciones por género: ComboBox géneros, DataGridView (Mes, Cantidad), `cmdListar`, Label total, promedio, máximo y mínimo.
- Estadísticas por mes: DataGridView (Mes, Cantidad, Promedio, Máximo, Mínimo), `cmdListar`; máximo y mínimo deben expresar nombre del género.
- Estadísticas por género: DataGridView (Género, Cantidad, Promedio, Máximo, Mínimo), `cmdListar`; máximo y mínimo deben expresar nombre del mes.

## Diseño
- Principal maximizada.
- Secundarios centrados y con el título exacto de la opción que los abre.
- Colores propuestos: fondo #081827, paneles #102B45, acento #F4C65D, verde #45B98A.
- Los gráficos y tarjetas son complementos visuales; los datos y funciones deben mantenerse en controles WinForms reales.
- Código pensado para Visual Studio 2017 y Windows Forms sobre .NET Framework.

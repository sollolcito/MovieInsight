# Recursos gráficos de MovieInsight

MovieInsight utiliza una identidad visual de temática cinematográfica, con una combinación de **azul oscuro y dorado** para los encabezados, controles y elementos destacados.

## Organización

Los recursos visuales del proyecto pueden incluir:

- **`principal/`**: banner e imágenes relacionadas con la ventana principal.
- **`formularios/`**: recursos visuales para ventanas secundarias, cuando corresponda.
- **`generos/`**: imágenes o íconos temáticos, cuando corresponda.

La presencia de estas carpetas no implica que todos los formularios necesiten imágenes. Los controles de Windows Forms son los responsables de la funcionalidad del sistema.

## Uso en Visual Studio

Para utilizar los recursos en una instalación distinta, es importante mantener la estructura de carpetas y comprobar que las rutas de las imágenes sean válidas.

El banner de la ventana principal se carga desde la carpeta de recursos correspondiente. Si se modifica la ubicación de los archivos o se distribuye la aplicación compilada, también deben copiarse los recursos utilizados en tiempo de ejecución.

## Diseño

El objetivo del diseño es mantener una presentación consistente y facilitar la lectura de los datos, sin alterar los requisitos funcionales del examen.

[Volver al README principal](../README.md)

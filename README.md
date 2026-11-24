# MovieInsight 🎬

**Sistema de gestión de géneros cinematográficos y análisis de visualizaciones**

Proyecto integrador desarrollado para el **Examen Final de Laboratorio de Programación 1** del **IES Siglo 21**.

## Descripción

MovieInsight es una aplicación de escritorio que permite registrar géneros cinematográficos, cargar y consultar cantidades de visualizaciones mensuales y generar estadísticas a partir de esos datos.

El sistema fue desarrollado como parte de mi formación en programación, aplicando registros, vectores, matrices, estructuras de control y programación orientada a eventos.

## Tecnologías utilizadas

- **Lenguaje:** C#
- **Interfaz:** Windows Forms (WinForms)
- **Entorno de desarrollo:** Visual Studio 2017
- **Plataforma:** .NET Framework 4.7.2
- **Tipo de aplicación:** Escritorio para Windows

## Funcionalidades

### Sistema
- Presentación de la información del proyecto en **Acerca de…**.
- Carga automática de los diez géneros cinematográficos y valores aleatorios de visualizaciones entre 0 y 100.
- Opción para salir de la aplicación.

### Géneros
- Agregar géneros, con validación de los datos ingresados.
- Listar los géneros registrados.
- Consultar el código y la descripción de un género.

### Visualizaciones
- Registrar visualizaciones de un género en un mes determinado. La cantidad ingresada se **suma** al valor existente.
- Consultar la cantidad de visualizaciones de un género y mes.
- Listar visualizaciones de todos los géneros en un mes, con total, promedio, máximo y mínimo.
- Listar las visualizaciones de un género durante los doce meses, con sus respectivos cálculos.
- Generar estadísticas generales **por mes** y **por género**.

## Estructuras de datos

Se utilizan estructuras en memoria para organizar la información:

- `RegistroGenero`: registro con código, nombre y descripción.
- `Generos[10]`: vector con capacidad para diez géneros.
- `IND`: indicador de la cantidad de géneros cargados.
- `Meses[12]`: vector con los nombres de los meses del año.
- `Visualizaciones[10,12]`: matriz que relaciona cada género con sus cantidades mensuales.

El programa utiliza ciclos, condiciones y procedimientos de evento para procesar y presentar la información.

> **Nota:** los datos se almacenan en memoria mientras la aplicación está abierta. No se implementó una base de datos ni persistencia al cerrar el programa.

## Cómo ejecutar el proyecto

1. Descargar o clonar este repositorio.
2. Buscar el archivo de solución **`.sln`** dentro de la carpeta del proyecto de Visual Studio.
3. Abrirlo con **Visual Studio 2017** o una versión compatible con proyectos Windows Forms de .NET Framework.
4. Comprobar que esté disponible **.NET Framework 4.7.2**.
5. Compilar la solución y ejecutar con **F5**.

Para utilizar la carga de ejemplo, ingresar a **Sistema → Carga automática de datos**. También es posible registrar un género manualmente antes de completar el vector.

## Organización del repositorio

- `MovieInsight.sln`: solución principal de Visual Studio.
- `src/MovieInsight/`: proyecto, formularios, registros y lógica de la aplicación.
- `assets/principal/`: banner y recursos gráficos de la ventana principal.
- `docs/`: documentación del trabajo.
- `.gitignore`: exclusión de archivos temporales del entorno de desarrollo.

## Alcance académico

El objetivo de MovieInsight es demostrar los conocimientos adquiridos durante el cursado de **Laboratorio de Programación 1**, especialmente el manejo de datos estructurados, matrices y formularios con eventos.

**Proyecto académico | IES Siglo 21 | 2026**

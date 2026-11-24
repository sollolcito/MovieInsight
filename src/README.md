# Código fuente de MovieInsight

Esta sección reúne información técnica sobre la implementación del sistema desarrollado en **C# y Windows Forms** para el examen final de Laboratorio de Programación 1.

## Dónde está el proyecto

La solución **`MovieInsight.sln`** está en la raíz del repositorio. El proyecto y los formularios están organizados en **`src/MovieInsight/`**.

Para trabajar con el código, abrí la solución desde Visual Studio. No es necesario crear un proyecto nuevo.

## Componentes principales

- **`DatosGlobales.cs`**: contiene el registro de géneros, los vectores, la matriz de visualizaciones y el indicador `IND`.
- **`frmPrincipal`**: presenta el menú general, permite navegar entre formularios y ejecutar la carga automática.
- **Formularios de géneros**: permiten agregar, listar y consultar los géneros cargados.
- **Formularios de visualizaciones**: registran, consultan y listan datos mensuales y anuales.
- **Formularios de estadísticas**: calculan totales, promedios, máximos y mínimos según el mes o el género seleccionado.
- **`frmAcercaDe`**: muestra la información académica del trabajo.

## Criterios de implementación

La aplicación trabaja con datos en memoria y utiliza eventos de Windows Forms para responder a las acciones del usuario.

Para los cálculos se recorren los vectores y la matriz mediante estructuras repetitivas. Los formularios consultan y actualizan los mismos datos compartidos, por lo que los resultados reflejan las visualizaciones registradas durante la ejecución.

## Ejecución

1. Abrir el archivo `.sln` en Visual Studio.
2. Restaurar o instalar los componentes de **.NET Framework 4.7.2** si fueran necesarios.
3. Compilar la solución.
4. Ejecutar con **F5**.

Se recomienda excluir del control de versiones las carpetas generadas automáticamente: `.vs/`, `bin/` y `obj/`.

[Volver al README principal](../README.md)

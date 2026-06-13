# Entornos de Desarrollo para .NET en GNU/Linux

Este documento describe las alternativas nativas y de alto rendimiento para el desarrollo con el CLI de .NET y C# en entornos GNU/Linux (como Debian), evitando el uso de entornos privativos pesados y garantizando la compatibilidad con el flujo de trabajo basado en archivos de soluciones (.sln) y proyectos (.csproj).

---

## 1. [VSCodium](https://vscodium.com/#intro) (La Alternativa 100% Software Libre)

VSCodium es un binario limpio construido directamente desde el código fuente del proyecto de código abierto `vscode` de Microsoft. Su principal ventaja es la eliminación completa de la telemetría, el rastreo de datos y las licencias restrictivas del instalador comercial.

### Configuración del Entorno para .NET y C#

Debido a que VSCodium utiliza la tienda comunitaria Open VSX en lugar de la Marketplace de Microsoft, no se puede utilizar el "C# Dev Kit" oficial por restricciones de licencia. Para obtener una interfaz gráfica funcional de administración, se debe instalar el siguiente conjunto de extensiones comunitarias:

* **C# (basado en OmniSharp):** Proporciona el servidor de lenguaje para autocompletado, resaltado de sintaxis, detección de errores en tiempo real y navegación entre definiciones de código.
* **Avalonia for VSCode:** Añade soporte de formato, snippets y herramientas de diseño para las vistas de interfaz basadas en archivos `.axaml`.
* **vscode-solution-explorer:** Extensión comunitaria que genera un panel visual en la barra lateral idéntico al Explorador de Soluciones de Visual Studio. Permite administrar proyectos, agregar carpetas, referencias y dependencias sin necesidad de editar manualmente los archivos XML `.csproj`.

### Ventajas principales

* Consumo mínimo de memoria RAM y almacenamiento en disco.
* Filosofía alineada al software libre (FOSS).
* Ejecución limpia en segundo plano sin demonios de telemetría.

---

## 2. [JetBrains Rider](https://www.jetbrains.com/) (El IDE Profesional Multiplataforma)

Rider es un entorno de desarrollo integrado (IDE) completo y dedicado exclusivamente al ecosistema de .NET. Está construido sobre la plataforma IntelliJ (Java) y el backend de ReSharper, lo que le permite ejecutarse con la misma interfaz y rendimiento en Linux, Windows y macOS.

### Características Clave

* **Soporte Nativo de Soluciones:** Lee, escribe y gestiona archivos `.sln` y `.csproj` de forma directa sin alterar su estructura ni requerir conversiones.
* **Integración con Avalonia UI:** Cuenta con soporte avanzado para XAML/AXAML, refactorización de bindings en tiempo real y herramientas de depuración profunda para la interfaz gráfica.
* **Herramientas de Base de Datos Integradas:** Incluye un gestor visual de bases de datos que permite conectarse al archivo `langtags.sqlite`, ejecutar queries de prueba en tiempo real y verificar los esquemas directamente desde el entorno.

### Ventajas principales

* Máximo rendimiento en herramientas de refactorización y análisis estático de código C#.
* No depende de ningún componente de Windows para la compilación o depuración.
* Cuenta con licenciamiento gratuito para estudiantes, profesores y desarrolladores de proyectos open source acreditados.

---

## 3. Resumen de Flujo de Trabajo en Terminal

Independientemente del entorno gráfico seleccionado (VSCodium o Rider), el ciclo de vida del proyecto mantiene su independencia gracias al uso del CLI de .NET. El desarrollador puede utilizar cualquiera de estas herramientas únicamente para la edición de texto y apoyarse en la terminal para el control del programa:

```bash
# Restauración de paquetes SQLite y Avalonia
dotnet restore

# Compilación del proyecto desde Debian
dotnet build

# Ejecución de la interfaz gráfica
dotnet run

```

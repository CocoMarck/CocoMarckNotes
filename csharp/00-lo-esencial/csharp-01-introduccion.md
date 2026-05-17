# Introducción
A lo largo de estas lecciones veremos los fundamentos esenciales e C# y su aplicación practica en desarrollo de software.

**CONTENIDO PROGRAMÁTICO**

1. Variables y tipos de datos
2. Estructuras de control de flujo
3. Arreglos y colecicones.
4. Funciones y métodos.
5. Programación orientada a objetos.
6. Manejo de expepciones
7. Acceso de datos (base de datos)
8. Desarrollo básico de aplicaciones con GTK#


Primero tenemos que instalar `.NET framework`. Esta disponible para windows/mac/linux.
Despues instalar un editor de texto, `Visual Studio Code`. Esta disponible para `windows/mac/linux`.

Para verificar que ya tenemos instalado `.net` framework, simplemente ponemos `.dotnet --version` en consola y si nos devuelve su vercion, esta instalado.

Para iniciar un nuevo proyecto, ponemos el comando en terminal `dotnet new console --framework net8.0` en el directorio donde queremos poner el proyecto. `--framework net8.0` especifica la vercion que se utilizara, y seria a ocho (la version que e instalado).

Este comando utiliza las plantillas de net core para crear nuestro proyecto de consola.


Una vez hecho esto, abrimos el archivo llamado `Program.cs` El cual tiene un hola mundo.

Contenido de `Program.cs`:
```csharp
// Fijense en el comando 'Console.WriteLine( "Hola mundo" );'
// Este seria el tipico mensaje, hola mundo en un lenguaje de programación. Este comando seria para mostrar algo en pantalla, las sintaxis es muy simple, hacemos uso del objeto "Console" su porpiedad/funcion 'WriteLine' segido de unos parentecis que tienen adentro el mensaje mediante el uso de comillas "". Este es un comando de salida.
// Para ejecutar este comando, abrimos la terminal y secribimos "dotnet run /ruta/Program.cs"
// Cuando se esta programando es una buena practica crear una estructura que sirva para todos nuestros proyectos, y como C# es un lenguaje orientado en objetos, nosotros vamos a crear una estructura de la cual estaremos hablando mas adelante, y esa estructura la vamos a ver mas adelante.
// Las notas se ecriben con "//" Estas no implican cambios en el funcionamiento del codigo
Console.WriteLine("Hello, World!");
```
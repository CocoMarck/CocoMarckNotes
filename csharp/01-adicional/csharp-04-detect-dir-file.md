[Tutorial](https://stackoverflow.com/questions/1395205/better-way-to-check-if-a-path-is-a-file-or-a-directory#1395226)

# Detectar directorios y archivos
Se vera como detectar carpetas y archivos

```csharp
using System;
using System.IO;

public static class Program {
    static void Main() {
        // Obtener los atributos del archivo o directorio
        FileAttributes attr = File.GetAttributes(@"./");

        // Detectar si es un directorio o un archivo
        if ( (attr & FileAttributes.Directory) == FileAttributes.Directory){
            Console.WriteLine("Directorio");
        } 
        else if ( (attr & FileAttributes.Archive) == FileAttributes.Archive){
            Console.WriteLine("Archivo");
        }
    }
}
```
using System;
using System.IO;

namespace Ejemplos {
    public class CSharpDetectDirFile {
        static public void action() {
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
}

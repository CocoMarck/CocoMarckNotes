using System.Threading;
using System.Globalization;
using System;

namespace Ejemplos {
    public class CSharpStartsWith {
        static public void action() {
            Console.WriteLine("\n# CSharpStartsWith");

            string s = "GeeksforGeeks";

            // Verificar que empieze en Geeks. Sera true
            Console.WriteLine(s.StartsWith("Geeks"));

            // Verificar que empieze en geeks. Sera false
            Console.WriteLine(s.StartsWith("geek"));




            // La cadena o carácter de entrada
            string example_text = "Ejemplo de texto chidote";

            // Diferente cadena de caracteres y posibles coincidencias en cadena.
            string[] example_array = new string[] {
                "Ejemplo", "Ejemplo de", "Ejemplo de texto"
            };

            // Usando foreach para detectar coincidencia.
            Console.WriteLine( $"Textito a analizar: {example_text}" );
            foreach (string text in example_array) {
                if ( example_text.StartsWith(text) ) {
                    Console.WriteLine( $"Este textito comienza con: {text}" );
                }
            }


            // Removiendo tags tipo html code.
            string[] list_of_text = {
                "<p>Texto</p>",
                "<h1>Titulo</h1>"
            };

            foreach (var str in list_of_text) {
                Console.WriteLine(RemoveHtmlTags(str));
            }




            // Input de entrada
            s = "Geeks";

            // Implementación de `startswith()` function

            // Prueba en la cadena original
            bool r1 = s.StartsWith("Geeks", false, CultureInfo.InvariantCulture);

            // prueba de la cadena en minusculas
            bool r2 = s.StartsWith("geeks", false, CultureInfo.InvariantCulture);

            // prueba de la cadena en mayusculas
            bool r3 = s.StartsWith("GEEKS", false, CultureInfo.InvariantCulture);

            // pureba sin parametro de cadena
            bool r4 = s.StartsWith(" ", false, CultureInfo.InvariantCulture);

            // Mensajes
            Console.WriteLine("Este string inicia con Geeks: " + r1);
            Console.WriteLine("Este string inicia con geeks: " + r2);
            Console.WriteLine("Este string inicia con GEEKS: " + r3);
            Console.WriteLine("Este string inicia con string vacio: " + r4);


            // Textos CurrentCulture
            string s1 = "GeeksForGeeks";
            string s2 = "Aprende CSharp";

            // Implementación de la función `startswith`
            r1 = s1.StartsWith("Geeks", StringComparison.CurrentCulture);

            r2 = s1.StartsWith("geek", StringComparison.CurrentCulture);

            r3 = s2.StartsWith("CSharp", StringComparison.CurrentCulture);

            r4 = s2.StartsWith("Aprende", StringComparison.CurrentCulture);

            // Mostrar boleanos chidos
            Console.WriteLine( $"{s1}. Inicia; Geeks. {r1}" );
            Console.WriteLine( $"{s1}. Inicia; geeks. {r2}" );
            Console.WriteLine( $"{s2}. Inicia; CSharp. {r3}" );
            Console.WriteLine( $"{s2}. Inicia; Aprende. {r4}" );

        }

        private static string RemoveHtmlTags(string str) {
            while ( str.Trim().StartsWith("<") ) {
                int end = str.IndexOf(">");
                if ( end >= 0 ) {
                    str = str.Substring(end + 1);
                } else {
                    break;
                }
            }
            return str;
        }

    }
}

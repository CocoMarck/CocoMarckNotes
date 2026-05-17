using System;
using System.Collections.Generic;

class ObjetoCustom { }
class Chidote : ObjetoCustom { }

namespace Ejemplos {
    public static class CSharpTiposDeDatos {
        public static void action() {
            // Algunos tipos de datos
            string text = "hello";
            bool bulubulu = true;
            int superNumber = 1;
            double flotatingin = 33.1;

            if (text is string) {
                Console.WriteLine($"{text} Es un string");
            }
            if (bulubulu.GetType() == typeof(bool)) {
                Console.WriteLine($"{bulubulu} Es un boleano");
            }

            Console.WriteLine( bulubulu.GetType() );
            Console.WriteLine( superNumber.GetType() );
            Console.WriteLine( flotatingin.GetType() );
            Console.WriteLine( typeof(float) );

            // Objetos
            Chidote objChido = new Chidote();
            Console.WriteLine(
                $"{objChido.GetType()}\n" +
                $"{objChido is ObjetoCustom}\n" +
                $"{objChido is Chidote}\n" +
                $"{objChido.GetType() == typeof(Chidote)}\n" +
                $"{objChido.GetType() == typeof(ObjetoCustom)}"
            );
        }
    }
}

using System;


namespace Ejemplos {
    public class CSharpReadWriteText {
        static public void action() {
            string path = "texto.txt";
            string textoChido = "Este es un texto chido" + Environment.NewLine;
            File.WriteAllText(path, textoChido);

            string lectura = File.ReadAllText(path);
            Console.WriteLine(lectura);
        }
    }
}

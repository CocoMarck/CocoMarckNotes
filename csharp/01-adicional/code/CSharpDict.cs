using System;
using System.Collections.Generic;

namespace Ejemplos {
    public static class CSharpDict {
        public static void action() {
            // Creando diccionario
            Dictionary<int, string> sub = new Dictionary<int, string>();
            
            // Agregar elementos
            sub.Add(1, "C#");
            sub.Add(2, "Javascript");
            sub.Add(3, "Dart");

            // Mostrar diccionario
            foreach (var ele in sub) {
                Console.WriteLine( $"Key: {ele.Key}, Value: {ele.Value}" );
            }
            
            
            // Usando metodo add
            Dictionary<int, string> dict_with_add = new Dictionary<int, string>();
            dict_with_add.Add(1, "Uno");

            // Uso de inicializador de colección
            Dictionary<int, string> dict_with_init = new Dictionary<int, string>{
                {1, "Uno"}, {2, "Dos"}
            };

            // Uso de indexadores
            Dictionary<int, string> dict_with_index = new Dictionary<int, string>();
            dict_with_index[1] = "Uno";
            dict_with_index[2] = "Dos";
            
            foreach (var ele in dict_with_index)
                Console.WriteLine( $"Key: {ele.Key}, Value: {ele.Value}" );
            
            
            // Recorrer diccionario metodo dos
            for ( int x = 0; x < dict_with_index.Count; x++) {
                Console.WriteLine( 
                 "Clave: {0} y Valor: {1}", 
                 dict_with_index.Keys.ElementAt(x), dict_with_index[ dict_with_index.Keys.ElementAt(x) ] 
                );
            }
            
            
            
            // Remover valor
            Console.WriteLine( "Remover valor a diccionario" );
            dict_with_index.Remove(1);
            foreach (var ele in dict_with_index)
                Console.WriteLine( $"Key: {ele.Key}, Value: {ele.Value}" );


            //  Detectar key, detectar value
            if ( dict_with_index.ContainsKey(2)) 
                Console.WriteLine( "Clave encontrada" );
            else
                Console.WriteLine( "La clave no existe" );

            if (dict_with_index.ContainsValue("Dos"))
                Console.WriteLine( "Valor encontrado" );
            else
                Console.WriteLine( "Valor no encontrado" );
        }

    }
}
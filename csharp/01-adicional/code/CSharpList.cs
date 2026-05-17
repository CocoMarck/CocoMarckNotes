using System.Collections.Generic;

namespace Ejemplos {
    public class CSharpList {

        public static void action() {

        // Parte uno
        string[] happy_array = { "Perro", "Gato", "Elefante" };
        List<string> list_animals = new List<string>(happy_array);


        Console.WriteLine( "Un array que se usara para una List" );
        foreach (string i in happy_array) {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n\n");

        Console.WriteLine( "Lista usando un array" );
        foreach (string i in list_animals) {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n\n");




        // Parte dos
        List<int> list_number = new List<int>();
        list_number.Add(1);
        list_number.Add(2);
        list_number.Add(3);

        List<string> list_string = new List<string>(); 
        list_string.Add("Uno");
        list_string.Add("Dos");
        list_string.Add("Tres");


        // Mostrar contenido de lista.
        Console.WriteLine("Lista de entero. Datos agregados con metodo Add");
        foreach (int x in list_number) 
            Console.WriteLine( x );
        Console.WriteLine("\n\n");

        Console.WriteLine("Lista de string. Datos agregados con metodo Add");
        foreach (string x in list_string) 
            Console.WriteLine( x );
        Console.WriteLine("\n\n");




        // Using Foreach for List, or Arrays
        Console.WriteLine( "Obtener valores de lista con ciclo `foreach`" );
        List<string> good_list = new List<string>(["Hello", "Dance", "Perros"]);

        foreach (string a in good_list)
            Console.WriteLine(a);

        Console.WriteLine(); Console.WriteLine();
            
            
            

        // Insertar datos
        Console.WriteLine( "# Insertar en lista" );
        good_list.Insert( 2, "Coca cola espuma" );
        foreach (string a in good_list)
            Console.WriteLine(a);
        Console.WriteLine(); Console.WriteLine();


        Console.WriteLine( "# Insertar con insert range" );
        string[] animales_locos = {"Canalla loco uno", "Cacahuete loco dos", "Pez loco"};
        good_list.InsertRange(1, animales_locos);
        foreach (string a in good_list)
            Console.WriteLine(a);
        Console.WriteLine("\n\n");
            
            
        Console.WriteLine( "# Eliminar de una lista" );
        good_list.Remove( "Pez loco" ); // Primera Coincidencia. "Pez loco"
        good_list.RemoveAt( 0 ); // Indice
        good_list.RemoveRange( 0,2 ); // Rango
        foreach (string a in good_list)
            Console.WriteLine(a);
        Console.WriteLine("\n\n");




        good_list.Clear();
        Console.WriteLine( "# IndexOf" );
        good_list.AddRange( new List<string> {"texto", "ejemplo", "cocos", "perros", "ejemplo", "item", "ejemplo"} );
        int idx = good_list.IndexOf("item");
        if (idx > 0) 
            Console.WriteLine( $"Si existe '{good_list[idx]}', es: {idx}" );
        else
            Console.WriteLine("No existe ese item");

        Console.WriteLine( good_list.IndexOf( "ejemplo", 2) );
        Console.WriteLine( good_list.LastIndexOf("ejemplo") );
        Console.WriteLine( "\n\n" );


        Console.WriteLine( "# Ordenar lista con `Sort`" );
        good_list.Sort();
        foreach (string item in good_list)
            Console.Write( $"'{item}', " );
        Console.WriteLine( "\n\n" );


        Console.WriteLine( "# Invertir lista `Reverse`" );
        good_list.Reverse();
        foreach (string item in good_list)
            Console.Write( $"'{item}', " );
        Console.WriteLine( "\n\n" );




        Console.WriteLine( "# Buscar indice en una cadana de texto" );
        good_list.Clear();
        good_list.AddRange( new List<string> {"texto", "ejemplo", "cocos", "perros", "item"} );
        foreach (string item in good_list)
            Console.Write( $"'{item}', " );
        Console.WriteLine();

        int search_index = good_list.BinarySearch("ejemplo");
        Console.WriteLine( $"Indice encontrado: {search_index}" );
        Console.WriteLine( "\n\n" );



        Console.WriteLine( "# Agergar lista a lista" );
        good_list.AddRange( list_string );
        foreach (string item in good_list)
            Console.Write( $"'{item}', " );
        Console.WriteLine();
        
        }
        
    }
}
[Enlace de tutorial](https://www.c-sharpcorner.com/article/c-sharp-list/)

# Listas

Yo personalmente tenia un problema con las listas, pensaba que un `type[] var = {};` era una lista. Pero no lo es, esto seria un `array`.

Un array es mas limitado que una lista, un array tiene metodos pero son limitados.

Un lista es como un array mejorado, estos casi no tienen limite de uso, y tiene metodos realmente utiles

## ¿Qué es una lista en C#?
La clase `List<T>` en C# representa una lista de objetos fuertemente tipada. La clase `List` de c# permite crear, añadir, buscar, ordenar y actualizar elementos de una lista de objetos.

# Crear una list en C#
`List`, es una clase genérica y se define en el epsacio de nombres `System.Collection.Generic`. Debe importar este espacio de nombres en su proyecto.

```csharp
using System.Collections.Generic;
```

El constructor de la clase `List<T>` se utiliza para crear un objeto `List` de tipo `T`. Puede estar vacío o tomar un valor entero como argumento que define el tamaño inicial de la lista, también conocido como capacidad. Si no se pasa ningún entero en el constructor, el tamaño de la lista es dinámico y crece cada vez que se añade un elemento al array. También se puede proporcionar una colección inicial de elementos al inicializar un objeto.

```csharp
// Lista con capacidad default
List<Int16> list_number = new List<int16>();

// Lista de string, con capacidad de 5.
List<string> list_string = new List<string>(4); 

// Agregar array a lista.
string[] happy_array = { "Perro", "Gato", "Elefante" }; // Colección de datos
List<string> list_animals = new List<string>(happy_array);
```

Como puede ver en el `list_string` que solo tiene una capacidad inicial establecida en `4`. Sin embargo, cuando se agregan más de cinco elementos a la lista, esta se expande automáticamente.




# Agregar un elemento a una lista de C#
El método `Add` añada un elemento a una lista de C#. Se vera en el ejemplo como se le agrega a una `List<int>` y a una  `List<string>` datos.
```csharp
List<int> list_number = new List<int>();
list_number.Add(1);
list_number.Add(2);
list_number.Add(3);

List<string> list_string = new List<string>(); 
list_string.Add("Uno");
list_string.Add("Dos");
list_string.Add("Tres");


// Mostrar contenido de lista.
Console.WriteLine("Lista de entero");
foreach (int x in list_number) 
    Console.WriteLine( x );
Console.WriteLine("\n\n");

Console.WriteLine("Lista de string");
foreach (string x in list_string) 
    Console.WriteLine( x );
Console.WriteLine("\n\n");
```

Observa que el `list_number`, es tipo `List<int>`, pero tambien jalaria con `List<Int16>`. Solo recuerda que tambien deberas indicar el tipo de valor en el `foreach`. Así: `Int16 x in list_number`




# Loop para obtener cada uno de los items

Con un `foreach` se puede hacer.
```csharp
List<string> good_list = new List<string>(["Hello", "Dance", "Perros"]);

foreach (string a in list)
    Console.WriteLine(a);
```




# Insertar item
El método `Insert` de la clase `List` inserta un objeto en una posición determinada. El primer parámetro del método es el índice de la lista (basada en el valor 0).

El método `InsertRange` puede insertar una colección en la posición dada.

El fragmento de código del Listado seis inserta una cadena en la segunda posición, y una matriz en la primera posición de la `List<T>`.

Se devolvera un listado final de ocho items.

```csharp
List<string> good_list = new List<string>(["Hello", "Dance", "Perros"]);

good_list.Insert(2, "Perros que danzan");

string[] animales_locos = {"Canalla loco uno", "Cacahuete loco dos", "Pez loco"};
// Insertar array en la posicion 2
godd_list.InsertRange(1, animales_locos);
```


# Remover item
List proporciona los metodos `Remove`, y `RemoveAt`. Se usan para eliminar un elemento o un rango de elementos.

El método `Remove` elimina la primera aparición del elemento dado en la lista. Por ejemplo, el siguiente ejemplo elimina la aparición "testing"
```csharp
List<string> good_list = new List<string>(["Hello", "Dance", "Perros", "testing"]);

good_list.Remove("testing");
```

El método `RemoveAt` elimina un elemento en la posición indicada. Por ejemplo, el siguiente fragmento de código elimina el elemenot en la tercera posición.
```csharp
good_list.RemoveAt(3);
```

El método `RemoveRange` elimina una lista de elementos desde el índice hasta el número de elementos. Por ejemplo, el siguiente fragmento de código elimina dos elementos a partir de la tercera posición.
```csharp
good_list.RemoveRange(3,2);
```

El método `Clear` elimina todos los elementos de una lista.
```csharp
good_list.Clear();
```




# Comprobar si un elemento exitste en una lista de C#
El método `IndexOf` encuentra un elemento en una lista. Devuelve `-1` si no hay elementos en la lista.

El siguiente fragmento de código encuentra una cadena y devuelve la posición coinciente del elemento.
```csharp
int idx = exemple_list.IndexOf("texto");
if (idx > 0) 
    Console.WriteLine( idx );
else
    Console.WriteLine("No existe ese item");
```

También poddemos especificar la posición en una lista desde la cual el método `IndexOf` puede comenzar a buscar.

Por ejemplo, el siguiente fragmento de código encuentra una cadena que comienza en la tercera posición en una cadena.
```csharp
Console.WriteLine( good_list.IndexOf("texto", 2) );
```


El método `LastIndexOf` encuentra un elemento del final de la lista.
El siguiente fragmento de código busca una cadena en dirección hacia atrás y devuelve el índice del elemento si lo encuentra.
```csharp
Console.WriteLine( good_list.LastIndexOf("texto") );
```





# Ordenar una lista de C#
El método Sort de `List<T>` ordena todos los elementos de la lista utilizando el algoritmo `QuickSort` el siquiente ejemplo de código en el, se odena una lista:
```csharp
string_list.Sort();
```
Con eso ya se puede ordenar alfabeticamente una lista de strings.




# Invertir una lista en C#
El método `Reverse`, invierte el orden de todos los elementos de la lista.

```csharp
number_list.Reverse();
```
![imagen](images/ListReverse.png)




# Buscar un elemento en una lista de C#
El método `BinarySearch` de la Lista `<T>` busca en una lista ordenada y devuelve el índice de base cero del elemento encontrado. La lista `<T>` debe estar ordenada antes de poder usar este método.

El siguiente fragmento de código devuelve un índice de una cadena en una lista.
```csharp
int index = text_list.BinarySearch("Text");
```



# Convertir una lista de C# en una matriz
Puede utilizar el método `ToArray()` de la clase `List` de C# para convertir una lista en una matriz.
```csharp
int[] array = list_integers.ToArray()
```



# Unir dos listas de C#
Pueddes usar el método `AddRange` para fusionar una lista de C# con otra existente. Aquí tienes un artículo ddetallada sobre [cómo fusionar dds listas de c#](https://www.c-sharpcorner.com/blogs/how-do-i-merge-two-c-sharp-lists)
```csharp
List1.AddRange(List2);
```

Resumen:
Este artículo mostró cómo usar la clase `List<T>` para trabajar con una colección de objetos. También mostró cómo agregar, buscar, ordenar e invertir elementos en una lista.
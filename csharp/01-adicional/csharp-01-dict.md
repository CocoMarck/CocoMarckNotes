[Enlace de tutorial](https://www.geeksforgeeks.org/c-sharp/c-sharp-dictionary-with-examples/)

# C# Dictionary

Un diccionario en C#, es una colección genérica que almacena poares key-value. Su funcionamiento es bastante similar al de una [tabla hash no genérica](https://www.geeksforgeeks.org/c-sharp/c-sharp-hashtable-with-examples/). La ventaja de un diccionario es que es tipo genérico. Un diccionario se define en el espacio de nombres `System.Collections.Generic`. Su naturaleza dinámica significa que su tamaño aumenta según las necesidades.

- Por `key-value`: el valor se almacena en el par `key-value`.
- Búsqueda eficiente: proporciona búsquedas rápidas de valores basadas en claves.
- Claves únicas: las claves se almacenan de forma única y agregar claves duplicadas genera una excepsión en tíempo de ejecución.


### Ejemplo 1: creación y visualización de un diccionario
```csharp
using System;
using System.Collections.Generic;

class Geeks
{
    public static void Main()
    {
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
    }
}
```

Salida:
~~~
Key: 1, Value: C#
Key: 2, Value: Javascript
Key: 3, Value: Dart
~~~




# Pasos para crear un diccionario
El diccionario se puede crear de diferentes maneras usando la clase Dictionary. En este caso, usamos el constructor `Dictionary<TKey, TValue>()` para crear una instancia de la clase `Dictionary<TKey, TValue>`. La capacidad inicial predeterminada está vacía y se utiliza la comparación de igualdad predeterminada para el tipo de clave.

### Paso 1: Incluye espacio de nombres `System.Collections.Generic`
```csharp
using System.Collections.Generic;
```

### Paso 2: Crea el diccionario usando `Dictionary<TKey, TValue>` class.
```csharp
Dictionary dictionary_name = new Dictionary();
```

# Realizar diferentes operaciones en el diccionario
1. Agregando elementos
    - `Add()`: Este método sirve para agregar pares clave/valor en su diccionario.
    - `Collection-Initializer`: También podemos utilizar un inicializador de colección para agregar elementos al diccionario.
    - `Using indexes`: Podemos agregar directamente los elementos mediente índices.

```csharp
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
```


# 2. Acceso a elementos
Se accede al par clave-valor del diccionario mediante tres formas diferentes:
**Usando el bucle for**: Podemos usar a para acceder a los pares clave-valor del diccionario.
```csharp
for ( int x=0; x < dict.Count; x++) {
    Console.WriteLine( "{0} y {1}", dict.Keys.ElementAt(x), dict[ dict.Keys.ElementAt(x) ] );
}
```
**Usando el índice**: Podemos acceder a pares clave-valor individuales del diccionario usando su valor de índice. Podemos especificar la clave en el índice para obtener el valor del diccionario dado, sin necesidad de especificar el índice. El indexador siempre toma la clave como parámetro.
```csharp
Console.WriteLine("El valor es: {0}", dict[1]);
Console.WriteLine("El valor es: {0}", dict[2]);
```

> Nota: Si la clave no está disponible en el diccionario, se genera `KeyNotFoundException`

**Usando el bucle `foreach`**:
```csharp
foreach(var pair in dict)
    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
```

**Ejemplo**: Creación y visualización de un diccionario con `Add()`
```csharp
Dictionary<int, string> dict_with_add = new Dictionary<int, string>();
dict_with_add.Add(1, "Uno");

foreach (KeyValuePair<int, string> element in dict_with_add)
    Console.WriteLine("key: {0} and value: {1}", element.Key, element.Value);
```
Resultado: `key: 1 and value: Uno`




# 3. Eliminación de elementos
En el diccionario, podemos eliminar elementos. La clase `Dictionary<TKey, TValue>` proporciona dos métodos diferentes para eliminar elementos:
- `Clear`: Este método elimina todas las claves y valores del `Dictionary<TKey, TValue>`.
- `Remove`: Este método elimina el valor con la clave especificada del `Dictionary<TKey, TValue>`.

Ejemplo:
```csharp
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(99, "Noventa y nueve");
dict.Add(193, "Ciento noventa y tres");


dict.Remove(1);

foreach (KeyValuePair<int, string> element in dict)
    Console.Writeline("key: {0} value: {1}", element.Key, element.Value);
```

Resultado:
```
key: 193 value: Ciento noventa y tres
```




# 4. Elemento de comprobación
En diccionario, podemos comprobar si la clave o el valor dados están presentes en el diccionario especificado. La clase `Dictionary<TKey, TValue>` proporciona dos métodos diferentes:
- `ContainsKey`: Este método se utiliza para comprobar si `Dictionary<TKey, TValue>` contiene la clave especificado.
- `ContainsValue`: Este método se utiliza para comprobar si `Dictionary<TKey, TValue>` contiene un valor epsecificado.

Ejemplo
```csharp
Dictionary<int, string> dict = new Dictionary<int, string>();

dict.Add(1, "Bienvenido");
dict.Add(2, "a");
dict.Add(1, "GreeksforGeeks");

if ( dict.ContainsKey(1)) 
    Console.WriteLine( "Clave encontrada" );
else
    Console.WriteLine( "La clave no existe" );

if (dict.ContainsValue("a"))
    Console.WriteLine( "Valor encontrado" );
else
    Console.WriteLine( "Valor no encontrado" );
```


### Puntos importantes
- La clase Dicionario implementa las interfaces:
    - `IDictionary<TKey, TValue>`
    - `IReadOnlyCollection<KeyValuePair<TKey, TValue>>`
    - `IReadOnlyDictionary<TKey, TValue and IDictionary`
- En el diccionario, la clave no puede ser nula, pero el valor sí.
- No se permiten claves duplicadas. Si añadimos una clave duplicada, el compilador generará una excepción.
- En el diccionario sólo podemos almacenar los mismos tipos de elementos.
- La capacidad de un diccionario es el número de elementos que un diccionario puede contener.

Eso es todo chaval.
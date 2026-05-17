[Enlace de tutorial](https://www.geeksforgeeks.org/c-sharp/c-sharp-string-startswith-method/)

# Método `StartsWith()` de cadena de C#

En C#, `StartsWith()` es un método de la clase String. Este método se utiliza para comprabar si el inicio de la instancia de cadena actual coincide con una cadena especificada. Si coincide, devuelve `true`; de lo contrario, devuelve `false`. Mediante el [bucle "foreach"](https://www.geeksforgeeks.org/c-sharp/c-sharp-foreach-loop/), podemos comprobar varias cadenas. Este método admite la sobrecarga al pasar diferentes tipos y números de argumentos.

**Ejemplo:** uso básico del método `StartsWith()`.

```csharp
using System;

public class Geeks {
    static public void Main() {
        String s = "GeeksforGeeks";

        // Verificar que empieze en Geeks. Sera true
        Console.WriteLine(s.StartsWith("Geeks"));

        // Verificar que empieze en geeks. Sera false
        Console.WriteLine(s.StartsWith("geek"));
    }
}
```

Salida:
```
True
False
```

# `String.StartsWith(String)`

Este método se utiliza para comprobar si el inicio del objeto de cadena coincide con una cadena especifica. Si coincide devuevle la cadena; de lo contrario, devuelve falso.

Systaxis:
```csharp
public bool StartsWith(string input_string)
```

- Parametro: Es una cadena requerida como `input_string` que se va a comparar y el tipo de este parámetro es `System.String`.
- Tipo de retorno: Esta función devuelve el valor booleano. Es `true` si se encuentra una coincidencia; de lo contrario, devolverá "false". El tipo de retorno es `System.Boolean`.
- Excepción: Si la cadena de entrada es nula, este método generará `ArgumentNullExcpentio.`.

**Ejemplo 1: Este programa demuestra el uso del `String.StartsWith(String)` método para encontrar la cadena de inicio espcificada.**
```csharp
using System;

public class Geeks {
    static pulic void Main() {
        // La cadena o carácter de entrada
        string example_text = "Ejemplo de texto chidote";

        // Diferente cadena de caracteres y posibles coincidencias en cadena.
        string[] example_array = new string[] {
            "Ejemplo", "Ejemplo de", "Ejemplo de texto"
        };

        // Usando foreach para detectar coincidencia.
        Console.WriteLine( $"Textito a analizar: {example_test}" );
        foreach (string text in example_array) {
            if ( example_text.StartsWith(text) ) {
                Console.WriteLine( $"Este textito comienza con: {text}" );
            }
        }
    }
}
```

Salida:
```
Textito a analizar: Ejemplo de texto chidote
Este textito comienza con: Ejemplo
Este textito comienza con: Ejemplo de
Este textito comienza con: Ejemplo de texto
```

**Explicación:** En el ejemplo anterior, utilizamos el método `StartsWith()` para buscar si `SearchLink` se inicia con los enlaces presentes en la matriz de cadenas `allLinks`.

**Ejemplo 2:** Otro ejemplo demustra el uso del método `StartsWith()` de la clase string.
```csharp
using System;
class Geeks {
    public static void Main() {
        string[] list_of_text = {
            "<p>Texto</p>",
            "<h1>Titulo</h1>"
        };

        foreach (var str in list_of_text) {
            Console.WriteLine(RemoveHtmlTags(str));
        }
    }

    private static string RemoveHtmlTags(string str) {
        while (str.Trim().StartsWith("<")) {
            int end = str.IndexOf(">");
            if (end >= 0) {
                str = str.Substring(end + 1);
            } else {
                break;
            }
        }
        return str;
    }
}
```

Salida:
```
Texto</p>
Titulo</h1>
```

**Explicación:** En este ejemplo, usamos el método `StartsWith()` para verificar si la cadena comienza con la etiqueta HTML y si devuelve verdadero, eliminamos esta etiqueta HTML.




# `String.StartsWith(String, Bool, CultureInfo)`
Este método se utiliza para comprobar si el inicio de la instancia de cadena actual coincide con la cadena especificada al compararla con la referencia cultural especificada. Si se encuentra una coincidencia, se devuelva la cadena; de lo contrario, se devuelve falso.

**Sintaxis:**
```csharp
public bool StartsWith(string str, bool case, CultureInfo cul);
```

- **Parámetros**: Toma tres parámetros que son:
    - `str`: Es la cadena que se va a comparar y el tipo de este parámetro es `System.String`.
    - `case`: Se establecerá en verdadero para ignorar mayúsculas y minúsculas durante la comparación, de lo contrario, será falso y el tipo de este parámetro será `System.Boolean`.
    - `cul`: Información cultural que verifica cómo se comparan la cadena actual y la cadena. Si culture es nulo, se utiliza la cultura actual y el tipo de este parámetro es `System.Globalization.CultureInfo`.

- **Valores de retorno**: esta función devuelve el valor del tipo `System.Boolean` que se evalúa como verdadero si la cadena coincide con el comienzo de la cadena actual; de lo contrario, es falso.

- **Excepción**: Si el valor de str es nulo, este método generará `ArgumentNullException`.

**Ejemplo**:
```csharp
using System.Threading;
using System.Globalization;
using System;

class Geeks {
    public static void Main(string[] args) {
        // Input de entrada
        string s = "Geeks";

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
    }
}
```



# `String.StartsWith(String, StringComparison)`
Este método se utiliza para comprobar si el inicio de la instancia de cadena actual coincide con la cadena especificada al compararla con la opción de comparación especificada. Si se encuentra una coincidencia, devuelve la cadena; de la contrario, devuelve `false`.

**Syntaxis**
```csharp
bool StartsWith(String str, StringComparison cType);
```

Toma dos parámetros que son:
- `str`: Es la cadena requerida que se va a comparar y el tipo de este parámetro es `System.String`.
- `cType`: Es uno de los valores de enumeración que determinan cómo se comportan la cadena actual y la cadena `str`. El tipo de esta parámetro es `System.StringComparison`.
- **Valor de retorno**: Esta función devuelve el booleano valor (`true` si encuentra una coincidencia; de lo contrario, `false`). El tipo de retorno es `System.Boolean`.

**Exepciones**

- Si el valor de `str` es nulo, este método dará *`ArgumentNullException`*.
- Si el valror de `cType` no es un valor `StringComparison`, este método generará *`ArgumentException`*.


**Ejemplo:**
```csharp
using System;

class Geek {
    public static void Main(string[] args) {
        // Textos
        string s1 = "GeeksForGeeks";
        string s2 = "Aprende CSharp";

        // Implementación de la función `StartsWith` 
        bool r1 = s1.StartsWith("Geeks", StringComparison.CurrentCulture);

        bool r2 = s1.StartsWith("geek", StringComparison.CurrentCulture);

        bool r3 = s2.StartsWith("CSharp", StringComparison.CurrentCulture);
        
        bool r4 = s2.StartsWith("Aprende", StringComparison.CurrentCulture);

        // Mostrar boleanos chidos
        Console.WriteLine( $"{s1}. Inicia; Geeks. {r1}" );
        Console.WriteLine( $"{s1}. Inicia; geeks. {r2}" );
        Console.WriteLine( $"{s2}. Inicia; CSharp. {r3}" );
        Console.WriteLine( $"{s2}. Inicia; Aprende. {r4}" );
    }
}
```

Salida:
```
GeeksForGeeks. Inicia; Geeks. True
GeeksForGeeks. Inicia; geeks. False
Aprende CSharp. Inicia; CSharp. False
Aprende CSharp. Inicia; Aprende. True
```

Eso es todo chavalines.
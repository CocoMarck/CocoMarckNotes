[Tipos de datos](https://stackoverflow.com/questions/60199843/how-to-check-if-the-variable-is-a-string#60199854)

[GetType](https://stackoverflow.com/questions/983030/type-checking-typeof-gettype-or-is)

# C# Tipos de datos

Se utiliza el metodo `GetType()`, este nos devuelve el tipo de dato.
```csharp
variable.GetType();
```

Puedes obtener los tipos de datos con la función `typeof(tipo_de_dato)`.
```csharp
typeof(float);
typeof(int);
typeof(ObjetoCustom);
```

En un `if` se puede usar el operador `is`
```csharp
if (text is string) {
    // ...
}

if (objCustom is Custom) {
    // ...
}
```

# Ejemplo de uso
```csharp
using System;
using System.Collections.Generic;

class ObjetoCustom { }
class Chidote : ObjetoCustom { }

public static class Program {
    static void Main() {
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
```

Salida
```
hello Es un string
True Es un boleano
System.Boolean
System.Int32
System.Double
System.Single
Chidote
True
True
True
False
```
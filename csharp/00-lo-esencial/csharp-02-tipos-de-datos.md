# Variables y tipos de datos.

## ¿Que es una variable?
Como todo lenguaje de programación una variable es un espacio en la memoria que reservamos para guardar información. Mirala como una caja etiquetada en la que guardamos datos. Las variables sirven para guardar información de manera dinamica, almacenan valores temporales. Las variables son herramientas fundamentales.

En C#, las variables tienen varios tipos de valores, tiene dos grupos de datos, primitivos y los complejos:

## Primitivos:
- `bool`; valor boleano True o False, valor logico
- `char`; almacena caracteres

- `int`; valor numerico entero
- `byte`; bits 
- `short`; valor entero
- `long`; valor entero

- `float`; valor numerico flotante
- `double`; valor numerico real
- `decimal`; valor numerico decimal




# Complejos:
- `string`; cadena de texto.
- `Array`; Arreglos/vectores/matrises
- `enum`; Enumeración
- `struct`; Estructuras
- `class`; Clases/Objetos

Cada variable tiene un tipo de dato especifico, y eso no cambio durante la ejecución del programa, por lo tanto una vez asignamos el tipo de dato a una variable, no podemos asignar valores que no pertenecen a este tipo de dato, esto daria un error en el programa.


La sintaxis para la declaración de una variable es la siguiente:
```csharp
tipo_dato nombre_variable;
```

Ejemplo:
```csharp
int variable;
```

Recuerda que todas las sentencias finalizan con punto y coma, salvo los bloques de codigo que usan las llaves para iniciar y finalizar el bloque.


Veamos algunos ejemplos de declaración de variables:

Dentro de la función principal "Main" vamos a hacer la declaración de las variables, vamos a estabelcer una variable te tipo valor entoro que almacene la edad de una persona:
```csharp
int edad;
```



Ahora una variable que almacene la estatura de una persona, sera un numero real. C# maneja tres tipos de numeros reales que son el "float" el "double" y el "decimal". Basicamente la diferencia de cada uno de ellos se basa en la precición, float por ejemplo es un numero real de 16 bits, double es de 32 bits, y decimal es de 64 bits. Decimal es el que tiene mas precición, como no necesitamos mucha precición vamos a usar float.
```csharp
float estatura;
```


Ahora un string, el cual almacenara una cadena de caracteres. Sera el nombre:
```csharp
string nombre;
```


**Recomendaciones para los nombres de las variables:**

1. Siempre debe comenzar con una letra, y con letra minuscula.
2. No esta permitido el uso de caracteres especiales en el nombre de las variables. Solo esta permitido el guion bajo.
3. No se puede comenzar en un numero. Se pueden usar numero, pero no puede ser el primer caracter del nombre de la variable




Ahora vamos a asignarle valores a estas variables, para ello usaremos el operador igual, el cual esta hecho para darle valor a las variables, de hecho se lo conoce como el operador de asignación:
```csharp
edad = 10;
estatura = 1.50f;
nombre = "Jonas Mini";
```

Primero se pone el nombre de la variable, seguido de la equivalencia que le queramos dar a la varaible a almacenar. Recuerden que las variables son espacios en la memoria, por eso se dice que se almacena una variable. Miren que al final se cierrar con punto y coma, y que el valor Float tiene un subfijo "f" al final del valor para que jale.

Subfijo 'f/F' para valores flotante, subfijo 'm/M' para valores decimal y sin subfijo para valores double:

```csharp
float valor_flotante;
decimal valor_decimal;
double valor_doble;

valor_flotante = 0.1f;
valor_decimal = 0.1m;
valor_doble = 0.1;
```

Observe que los caracteres almacenan texto entre comillas dobles "".
```csharp
string texto;
texto = "texto";
```



Ahora vamos a mostrar estos datos en pantalla:
```csharp
edad = 10;
estatura = 1.5f;
nombre = "Jonas Mini";

Console.WriteLine("Nombre: {0}, Edad: {1}, Estatura: {2}", nombre, edad, estatura);
```

Utilizamos el `objeto` `Console` y su atributo `WriteLine`, ponemos el texto que queremos poner, y le indicamos las varaibles con llaves `{}`, llaves que necesitan un indice, el cual se lo ponemos en base a la variables que establescamos como tal, en este caso serian las variables `nombre, edad, estatura`, el indice cero seria `nombre`, el uno seria `edad` y el dos seria "`statura`
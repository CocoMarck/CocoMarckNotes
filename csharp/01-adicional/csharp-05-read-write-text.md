# C# Leer y escribir texto
Se vera una forma sencilla de leer archivitos de textito

Así se escribe el texto
```csharp
string path = "texto.txt";
string textoChido = "Este es un texto chido" + Environment.NewLine;
File.WriteAllText(path, textoChido);
```

Así se lee el texto
```csharp
string lectura = File.ReadAllText(path);
Console.WriteLine.(lectura);
```

## Ejemplo completo
```csharp
using System;

public static class Program {
    static void Main(){
        string path = "texto.txt";
        string textoChido = "Este es un texto chido" + Environment.NewLine;
        File.WriteAllText(path, textoChido);

        string lectura = File.ReadAllText(path);
        Console.WriteLine(lectura);
    }
}
```
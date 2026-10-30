# Bucle `GOTO`
`GOTO` es un comando que dice "ve allá".

Una etiqueta/label se usa en su script como una ubicación, y puede enviar el script para leer esa ubicación. `GOTO` es solo un ¡ve allí!.

El ciclo ocurre debido a esto a continuación (esto es un pseudocodigo):
```
cuenta_de_inicio:
EJECUTA EL JUEGO Y ESPERA
MOSTRAR NÚMEROS DEL UNO AL CINCO
IR A cuenta_de_inicio
```

Tenga en cuenta que después de mostrar la cuenta en la pantalla, volverá al principio, por lo que se mostrara una y otra vez. Nunca se detendrá, sera infinito.

---

### Ejemplo 1

A continuación vera como hacer un script que muestre después de dos segundos de que inicia el juego, los números del Uno al Cinco, con intervalos de un segundo cada uno. Esto se repetirá infinitamente. Esto es un ciclo sin fin. Un bucle infinito
```
SCRIPT_START
{
NOP

main_loop:
WAIT 2000
PRINT_STRING_NOW "Uno" 1000
WAIT 1000
PRINT_STRING_NOW "Dos" 1000
WAIT 1000
PRINT_STRING_NOW "Tres" 1000
WAIT 1000
PRINT_STRING_NOW "Cuatro" 1000
WAIT 1000
PRINT_STRING_NOW "Cinco" 1000

GOTO main_loop
}
SCRIPT_END
```
> Recuerda que `main_loop`, ¡es un nombre inventado!! ¡Tu eres el que nombra las etiquetas/labels!. Elige el nombre que quieras, pero evita siempre los caracteres especiales, acentos, espacios, etc.

---

### Ejemplo 2
Ejemplo mensaje infinito:
```
SCRIPT_START
{
NOP

bucle_repetitivo_jejej:
WAIT 0
PRINT_STRING_NOW "Bienvenido al bucle repetitivo jejej" 1000

GOTO bucle_repetitivo_jejej
}
SCRIPT_END
```

---

### Ejemplo 3
Otro ejemplo super simple de usar GOTO para controlar su código es el siguiente;

Se mostrara un mensaje de texto, se espera un segundo se va a otra etiqueta donde mostrara otro mensaje de texto, esperare otro segundo y regresara al principio, devolviendo el bucle:
```
SCRIPT_START
{
NOP

bulce_infinito:
WAIT 0
PRINT_STRING_NOW "Me Quedare en tu pantalla para siempre! O no" 1000
WAIT 1000

mostrar_otra_cosa:
PRINT_STRING_NOW "Otra mensaje de texto" 1000
WAIT 1000
GOTO bulce_infinito
}
SCRIPT_END
```

---

### Ejemplo 4
Ahora se mostrara como hacer un bucle, entre dos mensajes de texto, y se ignorara una linea de código (un mensaje), con el comando GOTO
```
SCRIPT_START
{
NOP

bucle_infinito:
WAIT 0
PRINT_STRING_NOW "Me quedare en tu pantalla para siempre! O no" 1000
WAIT 1000
GOTO mostrar_otro_mensaje

PRINT_STRING_NOW "Este mensaje nunca se mostrara" 1000

mostrar_otro_mensaje:
PRINT_STRING_NOW "Otro mensaje de texto jejej" 1000
WAIT 1000
GOTO bucle_infinito
}
SCRIPT_END
```
---

### Ejemplo 5
Finalmente aprende de este código bien hermoso:
```
SCRIPT_START
{
NOP

mensaje_1:
PRINT_STRING_NOW "Un mensaje" 1000
WAIT 1000
GOTO mensaje_2

mensaje_3:
PRINT_STRING_NOW "Tres mensajes" 1000
WAIT 1000
GOTO mensaje_1

mensaje_2:
PRINT_STRING_NOW "Dos mensajes" 1000
WAIT 1000
GOTO mensaje_3
}
SCRIPT_END
```
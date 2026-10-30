# GTA3Script condiciones
Al completar esta parte usted: Sabrá responder cueles son y como usar las condiciones `IF` y el bucle `WHILE`; En general, sabrá controlar un script para dirigirlo donde y cuando quieras.

Ya hemos aprendido a dirigir el código hacia donde queramos. Pero, ¿y cuando queremos?.

---

## `IF`
`IF` es "si esta". Con `IF` compruebas si algo es cierto.

Pero veamos mejor que significa un "IF" en una programación:
```
SCRIPT_START
{
NOP

main_loop:
WAIT 0
IF IS_KEY_PRESSED VK_KEY_H
    PRINT_STRING_NOW "Presiono la tecla H" 1
ENDIF

GOTO main_loop
}
SCRIPT_END
```
- El `IS_KEY_PRESSED` es comando que pide parámetro, "si la tecla es presionada".
- `VK_KEY_H` es la tecla que el `IF` pregunta si es presionada. Es el parámetro de `IS_KEY_PRESSED`.


**Recuerda**: Los comandos que puedes usar con `IF` son comandos que comienzan con `IS_`, `HAS_` o `DOES_` (Ademas de algunos otros comandos, que aprenderá con el tiempo, a menudo llamados `IF` y `SET`)

Si IF comprueba que es TRUE/Verdad, todo lo de adentro se hará:
```
IF IS_KEY_PRESSED VK_KEY_H
    // Comando
    // Otro comando
    // ...
ENDIF
```

Hasta el `ENDIF`. El `ENDIF` es solo un marcador que dice "se acabo!".

---

### Ejemplo 1
```
SCRIPT_START
{
NOP

WAIT 0

IF IS_PC_VERSION
    PRINT_STRING_NOW "Tu GTA es la versión de PC" 4000
ENDIF

IF IS_AUSTRALIAN_GAME
    PRINT_STRING_NOW "Tu GTA es la versión australiana (raro)." 4000
ENDIF

}
SCRIPT_END
```
> Muestra en pantalla dos mensajes, si es de PC lo menciona, después si detecta si es la version de Australia, también lo menciona.

---

### Ejemplo 2
Presionar la tecla h, y mostrar un conteo en segundos del 1 al 5.
```
SCRIPT_START
{
NOP

main_loop:
WAIT 0 
IF IS_KEY_PRESSED VK_KEY_H
    PRINT_STRING_NOW "1" 1000
    WAIT 1000
    PRINT_STRING_NOW "2" 1000
    WAIT 1000
    PRINT_STRING_NOW "3" 1000
    WAIT 1000
    PRINT_STRING_NOW "4" 1000
    WAIT 1000
    PRINT_STRING_NOW "5" 1000
ENDIF

GOTO main_loop
}
SCRIPT_END
```
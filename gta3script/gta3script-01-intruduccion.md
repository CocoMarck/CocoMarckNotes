# GTA3Script
GTA3Script, es el lenguaje de programación interno y propietario por Rockstar Games para crear la lógica del juego en Grand Theft Auto 3D Games. Solo los de la era 3D, los HD no.

---

## Lo necesario para usarlo
- Para compilarlo necesitamos de [gta3sc](https://github.com/thelink2012/gta3sc), que es un compilador/decompilador de scripts nativos. Puedes usar el release, que es un exe, o compilarlo, según se menciona la doc.

- Recomiendo instalar para `visual studio code` la exención [vscode-gta3script](https://github.com/thelink2012/vscode-gta3script).

---

## Hello Word
Como pollos, vamos al grano, mira este es un `Hello Word`:
```gta3script
SCRIPT_START
{
NOP

main_loop:
WAIT 0
PRINT_STRING_NOW "¡Hola Mundo!" 1000
GOTO main_loop
}
SCRIPT_END
```

1. Abrimos corchetes, para escribir script.
2. `NOP` es un comando de **no operación** que sirve para llenar la parte superior vacía.
3. El `main_loop` es una método/función.
    - Tiene un `WAIT 0`, que es para esperar cero milisegundos de que inicia el juego, y empezar el script.
    - `PRINT_STRING_NOW` Es para mostrar un string en pantalla por `x` milisegundos, en esta caso un segundo, es decir `1000` milisegundos.
4. `GOTO` este ordena un loop bien estricto al `main_loop` para toda la vida.
5. `SCRIPT_START, SCRIPT_END` este es para indicar al compilador, cuando inicia, y cuando acaba el script.
---

## Comentarios
Los comentarios de una sola linea se escriben con `//`

Y los de multiple linea
```
/*
Asi
*/
```

> Como en los lenguajes `C`. Bueno no esta de mas decir, que solo comentes lo importante, mas no todo. Eso si, si vas empezando, si es posible que te sea importante todo, porque estas aprendiendo y es normal.
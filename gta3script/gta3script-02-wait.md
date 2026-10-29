# Explicación de comando `WAIT`
Este comando es muy pero muy importante. Es el comando mas importante en los scripts.

Como su nombre lo indica (ESPERAR en español), le dice a tu script que espere, es decir: Si tenemos un `WAIT 2000`, significa que esperes 2 segundos, o mas especifico, `2000` milisegundos.

- Pensaras: Por lo tanto, 2 segundos después de que comience el juego, se mostrara el texto "1" en pantalla. Y después de 1 segundo el numero 2, y asi sucesivamente hasta llegar 5. Donde terminara con un `TERMINATE_THIS_CUSTOM_SCRIPT` lo que hace que nuestro script "cierre", y es decir, se detenga para siempre, termine.

¿Pero es tan simple como eso? ¡NO!. `WAIT` ¡No es solo esperar, es procesar!

El comando `WAIT` le dice al juego "Esta bien, he hecho mi trabajo, puedes procesarlo alli". Y después de procesar esperara. Si se usa `WAIT 0` (que es extremadamente común de usar en los códigos) le estas diciendo al juego "procesa el juego y no esperes nada, procesa el script de una"

#### ¿Que es  "el juego que se esta procesando"?
Es asi:
- Su script se esta ejecutando, haciendo todo lo necesario;
- Llegamos a un `WAIT`;
- Su script para;
- Se llamara al próximo script de tu juego (Probablemente algún otro mod de cleo que tengas)
- Llego a algunos `WAIT` en este otro script;
- Ese script también se detendra ahora;
- El próximo se llamara se llamara...;
- Después de que esto suceda con todos los scripts de tu juego (todos sus sub-procesos) el juego finalmente se procesara;
- El juego ahora se renderizara. Hara todo lo que un juego necesita hacer para que funcione `--commands` del jugador, funcionamiento de la inteligencia artificial, física, etc. Y asi se mostrara en tu monitor un fps mas (un cuadro mas)
- Una vez que se procesa el juego, se vuelven a llamar los scripts y hacemos todo esto de nuevo.

Todo sucede cada fps (cada imagen que se ve en el videojuego). Es decir si tenemos 30 fps, veremos 30 imágenes del juego entre cada segundo que pase.

Y si; todo este proceso sucede muy rápido.


#### ¿Que pasa si no usas WAIT?
El juego no sera procesado. Es decir, el juego se detendrá por completo, sin mensaje de error, "congelado" (freeze).

A continuación vera como hacer un script que muestre después de dos segundos de que inicia el juego, los números del 1 al 5, con intervalos de un segundo cada uno.

Ejemplo:
```gta3script
SCRIPT_START
{
NOP

WAIT 2000

PRINT_STRING_NOW "1" 1000

WAIT 1000

PRINT_STRING_NOW "2" 1000

WAIT 1000

PRINT_STRING_NOW "3" 1000

WAIT 1000

PRINT_STRING_NOW "4" 1000

WAIT 1000

PRINT_STRING_NOW "5" 1000

TERMINATE_THIS_CUSTOM_SCRIPT
}
SCRIPT_END
```
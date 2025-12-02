[Referencia](https://computernewage.com/2015/06/14/el-arbol-de-directorios-de-linux-al-detalle-que-contiene-cada-carpeta/)




## `usr`
El directorio `/usr` viene de `<<User System Resources>>` y actualmente sirve para almacenar todos los archivos de solo lectura y reletivos a las utilidades de usuario, incluyendo todo el software instalado a través de los gestores de paquetes de cada distribución.

Contiene puros programas, y dependencias necesarias para que jalen.




## `lib`
En este directorio se almacenan todas las librerias necesarias para que funcionen los programas necesarios para que jale el OS. Hasta tiene lo necesario para jale el Kernel.

En los sistemas operativos de 64 bits, tambien existe el directorio lib64. Este tiene la misma función que lib, pero solo tiene puras librerias de 64 bits.




## Conclusión.
`usr` Tiene los programas instalados por el usuario. No son necesarios para que funcione el OS. `lib` Tiene todos los programas necesarios para que jale el OS y el Kernel. `lib64` Lo mismo que lib. Pero puro programa de 64 bits.
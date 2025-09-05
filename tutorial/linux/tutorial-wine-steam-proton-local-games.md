# Usar Proton de Stream en juegos locales, y en sistemas de archivos exFat o perecidos

Proton necesita que el sistema de archivos aguante enlaces simbolicos (entro otras cosas), es por eso que debes asegurarte de que proton este instalado en un sistema de archivos que soporte esto.

**Como:**
- ext4
- btrfs
etc...

**Las que no aguantan proton**
- exfat
- ntfs
- fat32
etc...


# Instalar el puro proton
Para no batallar, ve a la columna de biblotecas, en donde dice juegos, marca que tambien quieres ver las herramientas. Busca proton (preferiblemente en la barra de busqueda, donde esta la lupa).

Elije la ultima versión del proton estable. Básicamente es el numero mas alto, la experimental no, esa es experimental, la versión que tenga el numero mas alto, indica que es la ultima versión estable.

En mi caso `2025`, es Proton 9.

Asegurate que se instale en una unidad que soporte enlaces simbolicos.

Listo, ahora cuando quieras jugar un game, forza la compatibilidad eligiendo la versión de proton que instalaste. Si seleccionas una que no instalaste, te la va a instalar el canijo de steam.


# Conclusión
Usa proton en una sistema de archivos que soporte enlaces simbolicos.
# Wine, rendimento máxico con OpenGL

Nomas jala con GPU's viejonas y loquitas.

Creación de un nuevo dir wine, indicando que es pal nine moment.
```bash
export WINEPREFIX=$HOME/.wine-nine
export MESA_GLTHREAD=true
export MESA_LOADER_DRIVER_OVERRIDE=crocus

rm -rf WINEPREFIX/*; winecfg; winetricks galliumnine; wine ninewinecfg.exe
```
> Necesitas winetricks
> Asegurate de que nine Wine CFG tenga todo en palomita de checkbox.

Se lanza el juego asi:

```bash
#!/bin/bash
export WINEPREFIX=~/.wine-nine 
export MESA_GLTHREAD=true
export MESA_LOADER_DRIVER_OVERRIDE=crocus

wine juego.exe
```
Recomendable hacer esto un archivo `script.sh`, en ruta de tu game.


Configuración de nine:
```bash
export WINEPREFIX=$HOME/.wine-nine
export MESA_LOADER_DRIVER_OVERRIDE=crocus 
winecfg; wine ninewinecfg.exe
```

# Inicializar wine

Hacer todo, sin sudo. No hace falta usar sudo.

> Haz de cuenta que este es el wineprefix por defecto, pero realmente no hay uno, solo que wine asume que no se establece uno, se guardara todo aca: `export WINEPREFIX="$HOME/.wine"`. Lo mas correcto seria en vez de home un `~`, pero es lo mismo, yo estoy acostumbprado a usar `$HOME`.


Instalar wine en default dir, y con dxvk
```bash
winecfg && winetricks dxvk2000 corefonts allfonts
```


Reiniciar wine default
```bash
rm -rf "$HOME/.wine"; winecfg
```


# Reinicio completo, personalizado. Para uso generalista.
```bash
rm -rf "$HOME/.wine"; winecfg; winetricks settings win10; winetricks dxvk2000 corefonts allfonts
```


# Un wineprefix para gta sa
```bash
export WINEPREFIX="$HOME/.wine_gta_sa"; 
rm -rf "$WINEPREFIX"; winecfg;
winetricks settings win7; winetricks dxvk2000 corefonts allfonts
```

# Script, o comando para lanzar el `gta_sa`, con su prefix hecho. `wine_run_gta-sa.sh`
```bash
#!/bin/bash
export WINEPREFIX="$HOME/.wine_gta_sa"
mangohud --dlsym wine "/media/public/1TB_PowerGM/OS_Windows/gta_sa/gta_sa.exe"
```


# Si fallas en la teclada y borras algo imporante, como `$HOME`:
Usar `testdisk` para sistema de archvios Ext4.
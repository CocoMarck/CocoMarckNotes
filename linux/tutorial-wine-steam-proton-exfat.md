# GNU/Linux: Steam Proton Games en exFAT

# Concepto clave
- Proton y muchos juegos linux esperan enlaces simbólicos válidos. Permisos Unix y atributos que exFat no soporta.
- Por eso no puedes instalar directamente los games exFAT y esperar que todo jale.
0 Solución: Instalar los jugos exFAT pero redirigir solo los archivos problemáticos a ext4 usando bind mounts o symlinks parciales.

# Usar `Steam Librery Folders` + `steamapps/common` en exFat
Steam permite bibliotecas en distintos discos:
1. Abre steam `Configuración`, `Almacenamiento`.
2. Añade tu disco exFAT como nueva librería.
3. Cuando instales el juego, selecciona disco exFAT.

**Pero los archivos que proton necesita como enlaces simbolicos, `.steam`, `pfx` (Wine prefix), y runtimes, deben estar en FilesSystem compatible, como lo es `ext4`.**

# Crear un prefix sparado en ext4
- Proton crea un prefix tipo Wine en: `~/.steam/steam/steamapps/compactdata/<APPID>/`
- Este directorio contiene todos los symlinks y archivos Unix necesarios.

**Idea**: el prefix sigue en ext4 y solo los datos pesados (common) van en exFAT.

**Ejemplo práctico**. Supongamos que tenemos el disco exFAT por aca: `/mnt/exfat_games/`, y el ext4 con steam aca `$HOME/.steam`.

Mantén el prefix en ext4: `$HOME/.steam/steam/steamapps/compatdata/`.

Sino existe crea un prefix ext4. `mkdir $HOME/.steam/compatdata_exfat`

Simeplemente el prefix de: `/mnt/exfat_games/steam/steamapps/compactdata` lo redirigimos al de ext4, con `bind`

De esta manera:
```bash
sudo mount --bind $HOME/.steam/steam/steamapps/compatdata/ /mnt/exfat_games/steam/steamapps/compatdat
```

Para que percista despues de reiniciar, creamos una nueva linea en `sudo nano /etc/fstab`
```
/home/tu_usuario/.steam/steam/steamapps/compatdata/ /mnt/exfat_games/steam/steamapps/compatdat none  bind  0  0
```
> Aca si tenemos que porner la ruta completa, nada de `~`, ni `$HOME`, no variables de entorno.






# Ejemplo

```bash
sudo mount --bind /home/jean_abraham/.steam/steam/steamapps/compatdata/ /media/public/1TB_PowerGM/OS_GNU-Linux/Steam/steamapps/compatdata/

sudo nano /etc/fstab
```

Nueva linea
```
# Steam Proton ext4 and exFAT
/home/jean_abraham/.steam/steam/steamapps/compatdata/ /media/public/1TB_PowerGM/OS_GNU-Linux/Steam/steamapps/compatdata/ none bind 0 0
```
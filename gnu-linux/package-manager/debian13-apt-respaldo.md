# Respaldar paquetes APT

# Crear archivo de respaldo

Usaremos un `archivo.txt`, con un contenido asi:
```bash
# Desarrollo python3
python3-screeninfo
python3-pyqt6
python3-pyqt-distutils
python3-reportlab
python3-pyqt5
pyqt6-dev-tools
git

# Desarrollo apps
qttools5-dev-tools
sqlitebrowser
```

Agrega las aplicaciones que te gusten. Usa `apt search` para buscar apps.





# Utilizar archivo de respaldo, con `grep`, `pipes` y `xargs`.

El grep lo usaremos para quitar comentarios locos `#` `$`, el xargs para que le pase bien los nombres a `apt install`.

## Primero que nada veamos que paquetes intalaremos:
```bash
grep -vE '^#|^$' /ruta/debian13-app-backup.txt | cat
```
Ta bien, si estan chidos las paquetes, pos procedemos a intalar.


## Finalmente instalamos
```bash
grep -vE '^#|^$' /ruta/debian13-app-backup.txt | xargs sudo apt install -y
```

El `-y` es para que decir que si a todo. Lo puedes quitar si quieres hacer tu los `y`.





# Otra manera de respaldar absolutamente todo
Esta manera no la recomiendo, pero puede ser util.

Con: `apt-mark showmanual > lista.txt`, guarda el los nombres en un texto, en este caso `list.txt`, pero son todos los programas, y pos puede no ser la mejor opción, mejor escribirlos uno por uno.





# Conclusión

Hacer esto te ahorrara tiempo. Los nombres de los paquetes pueden variar entre verción de distro, por lo que es bueno poner `debian13`, especificar en el nombre del texto la ver del debian.

Y así como puedes hacer una lista de apps que te gutan, puedes hacer una de apps que no te gutan nadota, y siempre asegurarte de tenerlas desintaladas.

Por ejemplo:
## `debian13-apt-remove-apps.txt`
```bash
# Desintalar con: `grep -vE '^#|^$' debian13-apt-remove-apps.txt | xargs sudo apt purge -y`

# KDE Plasma | Email
kmail
kaddressbook

# KDE PLasma | Navegador web; file manager
konqueror

# Dict
goldendict-ng
kasumi

# KDE Plasma | Video
dragonplayer

# KDE Plasma | Limpiador
sweeper
```

Haz tu lista blanca tu lista negra de apps. Haz un backup de apps.

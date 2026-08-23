[sddm repo](https://github.com/sddm/sddm)

# Pantalla de inicio de sesión SDDM personalizada

Simeplemente se vera como, establecer el fondo de la pantalla inicio de sesión.

## Donde estan los temas de pantalla de incio de sesión
Estan en `/usr/share/sddm/themes/`

Esta ruta contiene carpetas, que contienen los archivos necesarios para configurar la pantalla de inicio de sesión, por ejempo `breeze`, contiene:
```
Background.qml    faces               Login.qml  metadata.desktop  SessionButton.qml
default-logo.svg  KeyboardButton.qml  Main.qml   preview.png       theme.conf
```

# Archivo de configuración
Es un `theme.conf`, que contendra algo así:
```conf
[General]
showlogo=shown
showClock=true
logo=/usr/share/desktop-base/debian-logos/logo-text.svg
type=image
color=#1d99f3
fontSize=10
background=/usr/share/desktop-base/active-theme/login/background-nologo.svg
```

Puedes consultar:
```bash
cat /usr/share/sddm/themes/debian-theme/theme.conf
```


## Cambiar fondo de un tema para user logging sddm
Para empezar, vamos a usar un `base theme sddm`. Si existe `/usr/share/sddm/themes/breeze`, lo copiaremos de esta manera:

```bash
sudo cp /usr/share/sddm/themes/breeze /usr/share/sddm/themes/custom-breeze
```

Editamos el `theme.conf`:
```bash
sudo nano /usr/share/sddm/themes/custom-breeze/theme.conf
```

Buscamos la linea: `background=...`

Y en su equivalencia ponemos la ruta de nuestro fondo favorito.
Por ejemplo: `/usr/share/images/background-user/ai-chease3.png`

Al final el archivo quedara algo así:
```conf
[General]
showlogo=hidden
showClock=true
logo=/usr/share/sddm/themes/custom-breeze/default-logo.svg
type=image
color=#1d99f3
fontSize=10
background=/usr/share/images/background-user/ai-chease3.png
needsFullUserModel=false
```


# Conclusión
Bueno así es como se configura un sddm. Ahora ya sabes como hacer, y como "instlar" nuevos temas para tu sddm. Aca nomas enseñamos cambiar el fondo y poco mas, pero se puede configurar todo.

Si quieres configurar todo, aca bien chidote, like web disenger, puede usar templanes de github, como este [Modify-SDDM-theme](https://github.com/Ishan0121/Modify-SDDM-theme). Busca en internet `github sddm theme`, hay muchos temas para usar y modificar.
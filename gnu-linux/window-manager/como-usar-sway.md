# Como usar Sway

Sway es un i3-compaible con el compositor Wayland.

# Instalación
En debian, se instala de la siguiente manera:
```bash
sudo apt install sway --no-install-recomends
```

## Aplcaciones recomendadas.
Te recomiendo instalar estas aplicaciones
- Launcher de apps
- Terminal
- Editor de texto
- Gestor de pantalla para wayland
- Gestor de teclado
- Gestor de mouse


# Archivos de configuración
Estos son los que estan en root.
1.  `/etc/sway/config`

Estos son los locales, los tendras que crear.
1.  `~/.config/sway/config`

## Creación de archivos
Se crearan carpetas y archivos basados en las rutas anteriormente mencionadas. Se daran permisos de lectura y escritura.
```bash
mkdir -p ~/.config/sway/config

sudo cp /etc/sway/config ~/.config/sway/config

sudo +rwx ~/.config/sway/*
```

# Editar archivo

## sway config
Editando el archivo de configuración `sway`, podremos establecer atajos de teclado.
```bash
nano ~/.config/sway/config
```

### Variables
Veremos una sección que contendra `### Variables`, aca podemos agregar algunas variables, pueden ser teclas o programas. Recomiendo poner programas, con su `code-name`, se establecen con `set`, segido del uno `$` y el nombre da la variable, y su valor.

Recomiendo no cambiar las teclas por defecto. Capas nomas las aplicaciones como `$term`, incluso recomiendo crear variables adicionales, solo crealas si vas usarlas mas de una vez.

```bash
set $term konsole
set $power_launcher fuzzel
set $file_manager dolphin
set $text_editor kate
```

---
### Uniones de teclas
Llamados en ingles `Key bindings`, aca estableceremos los atajos de teclas, lo mejor es usar las variables que establecimos.

**Ejemplo**
```bash
bondsym $Ctrl+Alt+t exec $term
bindsym $mod+Ctrl+k exec $power_launcher
bindsym $mod+Alt+e exec $file_manager
bindsym $mod+Ctrl+t exec $text_editor
```

---
### Mover alrededor
Aca se mencionaran las teclas por defecto. Estas combinaciones de teclas se ven en `# Move your focus around`.

Por defecto las variables `left, right, up, down`, son equivalentes a estas teclas:
`h, l, k, j`.

Tambien se puede con las flechas direccionales correspondientas a la dirección mencionada.

Cambiar enfoque de ventana:
- Enfocar ventana izquierda: `Win + h`
- Enfocar ventana inferior: `Win + j`
- Enfocar ventana superior: `Win + k`
- Enfocar ventana derecha: `Win + l`

Mover la ventana enfocada:
- Mover a la izquierda: `Win + Shift + k`
- Mover abajo: `Win + Shift + j`
- Mover arriba: `Win + Shift + k`
- Mover a la derecha: `Win + Shift + l`

---
### Espacios de trabajo
Por defecto se utilizan los numeros del cero al nueve, para moverse por los espacios de trabajo.

Todo esto se establece en la sección `# Workspaces:`
- `Win + 1` al `Win + 9`. Te mueves del espacio de trabajo uno al nueve.
- `Win + 0`. Te mueves al espacio de trabajo diez.

Mover el contenedor enfocado al espacio de trabajo
- `Win + Shift + 1` al `Win + Shift + 9`. Mover contenedor al workspace del uno al nueve.
- `Win + Shift + 0`. Mover contenedor al workspace diez.

---

### Cosas de diseño
Dividir objeto: `Win + b` o `Win + v`.

Cambia el estilo de diseño del contenedor actual
- `Win + s` apilar diseño
- `Win + w` tabular diseño
- `Win + e` alternar diseño

Poner foco actual en pantalla completa: `Win + f`

Alterna el enfoque actual entre el modo de mosaico y el modo flotante:
`Win + Shift + space`

Intercambiar el foco entre el área de mosaico y el área flotante: `Win + space`

Mueve el foco al contenedor principal: `Win + a`

---

### Bloc de notas
Sway tine un `scraptchpad` que sirve como eppacio para almacenar ventanas. Puedes enviar ventanas allí y recuperarlas más tarde. 

Mueve la ventana acttiva al bloc de notas: `Win + Shift + menos`

Muestra la siguiente ventana del bloc de notas u oculta la ventana activa. Si hay varias ventanas en el bloc de notas, este comando las alterna: `Win + menos`


---
### Redimensionar contenedores
Con `Win + r` entramos al modo redimensionar ventana.

Usar teclas: `h`, `j`, `k`, `l`. O las teclas direccionales.

Con esto redimencionaremos todo.


---
### Utilidades

Teclas especiales para ajustar pulse audio, ajustar brillo, y captura de pantalla.
- Captura de pantalla: `Print`
- Mute: `XF86AudioMute`
- Menos volumen: `XF86AudioLowerVolume`
- Mas volumen: `XF86AudioRaiseVolume`
- Mote de microfono: `XF86AudioMicMute`
- Menos brillo: `XF86MonBrightnessDown`
- Mas brillo: `XF86MonBrightnessUp`

Estas son las instrucciones:
```
# Volumen
pactl set-sink-mute \@DEFAULT_SINK@ toggle
pactl set-sink-volume \@DEFAULT_SINK@ -5%
pactl set-sink-volume \@DEFAULT_SINK@ +5%
pactl set-source-mute \@DEFAULT_SOURCE@ toggle

# Brillo
brightnessctl set 5%-
brightnessctl set 5%+

# Captura de pantalla
grim
```


---
### Barra de estado
Se puede obtener mas detos con `man 5 sway-bar`. Basicamente puedes cambiar su posición y su apariencia. Solo se puede arriba o abjo, no de forma vetical, solo horizontal.

Bueno esas son toda la configuración relacionada con `sway/config`. Con esto ya podremos configurar lo básico de sway.

Recomiendo agregar un atajo de tecla, que nos sirva para recordar todo todito, alo asi como:
```bash
bindsym $mod+Ctrl+/ konsole -e "bash -c 'cat ~/.config/sway/config; read'"
```

En mi caso yo uso la terminal konsole, esto abre la terminal y lee y muestra el archivo `~/.config/sway/config`, que es el que indica la config de sway.
# Fake Console OS
Un sistema operativo minimalista basado en Devuan, cuyo único propósito es ejecutar un emulador de retro gaming en pantalla completa. Enciende, carga ROMs y juega. Si necesitas hacer algo técnico, tienes un DE completo disponible.

**Foco actual**: mupen64plus (Nintendo 64). Pero la arquitectura está diseñada para ser genérica: GUI configurable, backend de emulador swappable, y soporte para múltiples formatos de ROM en el futuro. Por ahora solo se trabaja con un emulador.

---

## Stack tecnológico
- **Base OS**: Devuan Stable (sin systemd)
- **Init system**: runit (viene por defecto en Devuan)
- **DE**: XFCE4 (ligero, GTK, coherente con la GUI principal)
- **Lenguaje principal**: Python 3
- **GUI principal**: PyGObject + GTK4 (pantalla completa, estilo consola, genérica y configurable)
- **Servicios**: Bash script + Python, administrados por runit
- **Emulador actual**: mupen64plus (Nintendo 64)
- **Repositorios con dependencias non free**

---

## Arquitectura del sistema

### Boot
- GRUB → runit → servicio `display` → XFCE4 + Python GUI (pantalla completa, auto-login)

### Modos de operación
1. **Modo consola** (por defecto): La GUI Python ocupa pantalla completa. El usuario interactúa solo con ROMs y el emulador.
2. **Modo escritorio**: Con `Ctrl+Alt+D`, se minimiza la GUI y se accede al DE completo (terminal, file manager, configuración).

### Servicios (runit)
1. **display**: Lanza XFCE4 + Python GUI en pantalla completa
2. **rom-watcher**: Monitorea puertos USB/medios montados, detecta ROMs válidas
3. **session-data**: Maneja datos temporales de la sesión actual. Centraliza todo lo encontrado del rom watcher, y lo mete en una ruta de trabajo temporal.

### GUI principal (Python + GTK4)
- Pantalla completa, estilo terminal/consola visual
- Genérica: el backend de emulador es configurable (por ahora solo mupen64plus)
- Lista de ROMs detectadas (formatos dependen del emulador activo)
- Selección → lanzamiento del emulador activo con la ROM
- `Ctrl+Alt+Esc` para salir del emulador y volver a la GUI
- `Ctrl+Alt+D` para minimizar la GUI y acceder al DE
- La GUI se restaura al cerrar el DE o con la misma tecla

### Backend de emulador (configurable)
- Un módulo Python por emulador (ej. `backends/mupen64.py`)
- Cada backend define: formatos de ROM soportados, comando de lanzamiento, configuración
- La GUI carga el backend activo desde un archivo de configuración
- Por ahora solo existe el backend de mupen64plus, pero la estructura permite agregar más

### mupen64plus (backend actual)
- Se ejecuta como subproceso desde Python
- Se lanza con video plugin predeterminado (mupen64plus-video-rice o glide64mk2)
- Configuración mínima predefinida en `~/.config/mupen64plus/`
- Al cerrarse, la GUI recupera el foco automáticamente
- Formatos soportados: .z64, .n64, .v64

### XFCE4 (modo escritorio)
- Incluye file manager (Thunar), terminal, editor de texto
- Se accede con `Ctrl+Alt+D` desde la GUI principal
- Útil para: revisar logs, configurar mupen64plus, instalar paquetes, etc.

---

## Reglas técnicas
- **Devuan base**: Paquetes del sistema + mupen64plus + XFCE4
- **Init independiente**: runit, sin dependencia de systemd
- **Servicios independientes**: Cada servicio es un script en `/etc/sv/`, configurable por archivo
- **Sin persistencia de datos**: Las ROMs copiadas se eliminan al apagar
- **Un solo emulador por ahora**: Solo mupen64plus. La infraestructura es genérica pero se usa un emulador a la vez
- **Formato ROM por defecto**: `.z64` (formato nativo N64). Futuros emuladores agregarán sus formatos
- **Salida de emergencia**: `Ctrl+Alt+Esc` mata el emulador activo y vuelve a la GUI
- **Acceso al DE**: `Ctrl+Alt+D` minimiza la GUI y muestra el escritorio
- **Compatibilidad X11/Wayland**: GTK4 funciona nativamente, XFCE4 soporta X11 (Wayland experimental)
- **Regla de HW**: El PC debe ser lo necesario para emular N64, no más, no menos

---

## Construcción del OS
- **Desarrollo**: Docker/Podman con base Devuan. Iteración rápida, pruebas de servicios y GUI sinBootTestear en ISO completa.
- **ISO final**: live-build de Debian/Devuan. Genera la imagen booteable con todo configurado.
- **Workflow**: Container para desarrollo → live-build para ISO → USB/VM para testing final.

---

## Fases de desarrollo
1. **Fase 1**: ISO base con Devuan + runit + XFCE4 + auto-login
2. **Fase 2**: GUI GTK4 genérica en Python (pantalla completa, backend configurable)
3. **Fase 3**: Backend mupen64plus (formatos .z64, .n64, .v64)
4. **Fase 4**: Servicio rom-watcher (udev + Python, monitoreo de USB)
5. **Fase 5**: Generación de ISO con live-build de Devuan

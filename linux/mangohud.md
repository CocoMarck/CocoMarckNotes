#    Como usar MangoHUD    #
- [Sitio web de Mangohud](https://github.com/flightlessmango/MangoHud) 

Mangohud, es una aplicación que nos permite monitoriar estadisticas del pc, dentro del game en tiempo real, bueno para realizar analisis de rendimiento.

## Como instalar:
```bash
sudo apt install mangohud
```


## Compatibilidad con apps x86:
Con este paquete podremos ejecutar mangohud en apps de 32 bits vato. Necesario vato.
```bash
sudo apt install mangohud:i386
```




# Archivo de configuración
Ok chaval, necesitas un archivo de configuración llamado `MangoHud.conf`

Este archivo es necesario para establecer lo que se mostrara en el game, las stats del pc.

Podemos guardar este archivo en la ruta del game, para una custom configuration. `/ruta/game/MangoHud.conf`

Para una configuración global, necesitamos que el archivo este aca:
```bash
mkdir ~/.config/MangoHud

nano ~./.config/MangoHud.conf
```

Solo recuerda que `~`, seria `$HOME` = `/home/tu-nombre-de-usuario/`, y pos seria algo así:
`/home/user/.config/MangoHud/MangoHud.conf`


## ¿Que carambolas contendra el archivo de configuracion?
Visita el sitio web de mangohud, y ve que opciones existen, por lo pronto mira esta config:
```
position=top-left
fps=1
cpu_stats=1
ram=1
gpu_stats=1
```




# Ejecutar aplicacion 
Generalmente funciona, en juegos viejos puede que no:  

### Metodo 1
```bash
mangohud ./ruta/del/app
```

**Lo mismo, pero mas "directo":**  
```bash
MANGOHUD=1 ./ruta/del/app
```

### Metodo 2 (Para algunas apss que necesitan de dlsym)
```bash
mangohud --dlsym ./ruta/del/app
```




# MANGOHUD para apps flatpak
Para apps flatpak, instalar mangohud para flatpak

### Ejemplo de ejecucion:
```bash
flatpak run --env=MANGOHUD=1 org.app.etc
```

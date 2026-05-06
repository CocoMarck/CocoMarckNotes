<https://adbshell.com/commands/adb-shell-screencap>

# adb shell screencap  
El comando screencap es una utilidad de shell para tomar una captura de pantalla de la pantalla de un dispositivo.  
```bash
adb shell screencap /mnt/sdcard/Download/test.png
```

Notas: si no se proporciona NOMBRE DE ARCHIVO, los resultados imprimirán en la salida estándar.  
Para copiar captura de pantalla desde el dispositivo Andriod.  
```bash
adb pull /mnt/sdcard/Download/test.png test.png
```
[Enlace de tutorial](https://adbshell.com/commands/adb-shell-screenrecord)

# adb shell screenrecord  
Grabador de pantalla de Android v1.2. Graba la pantalla del dispositivo en un archivo .mp4  
```bash  
adb shell screenrecord /mnt/sdcard/Download/test.mp4
```



La grabación continúa hasta que se presiona Ctrl+C o se alcanza el límite de tiempo.  
Establesca el tamaño del vídeo, "1280x720". El valor predeterminado es la resolución de la pantalla principal del dispositivo (si es compatible), 1280x720 si no lo es. Para obtener mejores resultados, utilice un tamaño compatible con el codificador AVC.
```bash
adb shell screenrecord --size 1280x720 /mnt/sdcard/Download/test.mp4
```



Establesca la velocidad de bits de video, en bits por segundo. El valor puede especificarse en bits o megabits; por ejemplo "4000000" equivale a "4 Mb". El valor predeterminado es 20 Mbps.  
```bash
adb shell screenrecord --bit-rate 4000000 /mnt/sdcard/Download/test.mp4
```


Gira la salida 90 grados. Esta función es experimental.  
```bash
adb shell screenrecord --rotate /mnt/sdcard/Download/text.mp4
```


Agrege información adicional, como una superposición de marca de tiempo, que sea útil en los videos capturados para ilustrar errores.
```bash
adb shell screenrecord --bugreport /mnt/sdcard/Download/test.mp4
```

Agregue información adicional, como un superposición de marca de tiempo, que sea útil en los videos capturados para ilustrar errores.  
```bash
adb shell screenrecord --time-limit=120 /mnt/sdcard/Download/text.mp4
```

Establezca el tiempo máximo de grabación en segundos. El valor predeterminado/máximo es 180
```bash
adb shell screenrecord --verbose /mnt/sdcard/Download/test.mp4
```

Mostrar información interesante en stdout  
```bash
adb shell screenrecord --verbose /mnt/sdcard/Download/test.mp4
```

El audio no se graba con el archivo de video. No se permite girar la pantalla durante la grabación. Si la pantalla gira durante la grabación, parte de la imagen se corta.
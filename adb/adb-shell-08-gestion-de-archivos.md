- https://adbshell.com/commands/adb-pull
- https://adbshell.com/commands/adb-push
- https://adbshell.com/commands/adb-shell-ls
- https://adbshell.com/commands/adb-shell-cd
- https://adbshell.com/commands/adb-shell-rm
- https://adbshell.com/commands/adb-shell-mkdir
- https://adbshell.com/commands/adb-shell-touch
- https://adbshell.com/commands/adb-shell-cat
- https://adbshell.com/commands/adb-shell-pwd
- https://adbshell.com/commands/adb-shell-cp
- https://adbshell.com/commands/adb-shell-mv




# Gestión de archivos
Aca veremos las principales utilierias para gestionar los archivos.

# adb pull
Copiar archivos/dirs del dispositivo
Para copiar un archivo o directorio y sus subdirectorios del dispositivo Andriod.
```bash
adb pull /mnt/sdcard/Download/text.apk pc.apk
```

Conservar la marca de tiempo y el modo del archivo.
```bash
adb pull -a /mnt/sdcard/Download/test.apk pc.apk
```




# adb push
Copiar archivos/directorios locales el dispositivo Andriod
```bash
adb push pc.apk /mnt/sdcard/Download/test.apk
```

Solo envíe archnivos que sean más nuevos en el host que el dispositivo Android
```bash
adb push --sync pc.apk /mnt/sdcard/Download/test.apk
```

# adb shell ls
Listar archivos y directorios
```bash
adb shell ls /system/bin
```

Todos los archivos, incluido.hidden
```bash
adb shell ls -a
```

Directorio, no contenidos
```bash
adb shell ls -d
```

Lista recursiva en subdirectorios
```bash
adb shell ls -R /mnt/sdcard/Download
```


adb shell cd. Cambiar directorio
```bash
adb shell cd /mnt/sdcard/Download
```




adb shell rm
rm es una utilidad de línea de comandos para eliminar archivos, directorios y enlaces simbólicos
```bash
adb shell rm /mnt/sdcard/Download/test.apk
```
> Forzar: Eliminar sin conformación, sin error si no existe.

```bash
adb shell rm -f /mnt/sdcard/Download/test.apk
```

Interactivo: solicitud de confirmación
```bash
adb shell rm -i /mnt/sdcard/Download/test.apk
```

Recursivo: Eliminar el contenido del directorio
```bash
adb shell rm -R /mnt/sdcard/Download
```

Verboso
```bash
adb shell rm -v /mnt/sdcard/Download/test.apk
```




# adb shell mkdir
Crear directorios
```bash
mkdir [options] <directory name>

mkdir /sdcard/tmp/
```

Modo establecer permiso
```bash
mkdir -m 777 /sdcard/tmp 
```

Cree directorios principales según sea necesario
```bash
mkdir -p /sdcard/tmp/sub1/sub2
```




# adb shell touch
El comando touch es un comando estándar utilizado en el sistema operativo UNIX/Linux que se utiliza para crear, cambiar y modificar las nuevas marcas de tiempo de un archivo. Para crear un archivo de texto.
```bash
adb shell touch /mnt/sdcard/Download/test.txt
```




# adb shell cat
Combine varios archivos y muestre su contenido en la salida.
```bash
cat [-etuv] [ARCHIVO...]
```

El nombre de archivo "-" es un sinómino de stdin
-e Marca cada nueva linea con $
-t Mostrar pestañas como ^I
-u Copiar en byte a la vez (lento)
-y Mostrar caracteres no imprimibles como secuencias de escape M-x para caracteres ASCII altos (>127)

Ejemplos:
- `cat file.txt`
- `cat /etc/hosts`




# adb shell pwd
Imprimir el directorio de trabajo actual
```bash
adb shell pwd
```

# adb shell cp
Copiar archivos y directorios
```bash
cp [opciones] <fuente> <dest>
```

PASO 1:
```bash
adb shell
```

PASO 2:
```bash
cp /sdcard/test.txt /sdcard/demo.txt
```



# adb shell mv
Mueve archivos o directorios de un lugar a otro.
```bash
adb shell mv /ruta/archivo.txt /otra-ruta/archivo.txt
```

Forzar copia eliminando el archivo de destino.
```bash
adb shell mv -f /ruta1/archivo.txt /ruta2/archivo2.txt
```

Interactivo, aviso antes de sobrescribir el DEST existente.
```bash
adb shell mv -i /ruta1/archivo.txt /ruta2/archivo2.txt
```

Sin clover (no sobrescribir DEST)
```bash
adb shell mv -n /ruta1/archivo.txt /ruta2/archivo2.txt
```

Esta es la forma general de como gestionar los archivos en adb.
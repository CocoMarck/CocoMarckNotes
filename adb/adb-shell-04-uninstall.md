[Referencia](https://adbshell.com/commands/adb-uninstall)

# adb uninstall

Eliminar este paquiete de aplicaciones del dispositivo
```bash
adb uninstall test.apk
```

Mantenga los directorios de datos y caché alrededor después de la eliminación del paquete
```bash
adb uninstall -k test.apk
```
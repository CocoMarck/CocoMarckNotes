[Enlace](https://adbshell.com/commands/adb-shell-getprop)

# adb shell getprop
Obtiene una propiedad del sistema Android o las enumera todas.
```bash
adb shell getprop
```

Mostrar tipos de propiedades en lugar de valores
```bash
adb shell getprop -T
```

Obtener operador SIM
```bash
adb shell getprop gsm.sim.operator.alpha
```

Obtener IEMI del dispositivo
```bash
adb shell getprop ro.ril.oem.imei
```
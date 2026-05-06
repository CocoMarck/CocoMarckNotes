Fuente: <https://adbshell.com/>

# Comandos principales de adb.

ADB Debug | Depurado:
```bash
adb devices
adb kill-server
adb forward
```

ADB Wireless | Conecciones:
```bash
adb connect
adb usb
adb tcpip
adb pair
```

Package manager | Gestor de paquetes
```bash
adb install
adb uninstall
adb shell pm list packages
adb shell pm path
adb shell pm clear
```

File Manager | Gestor de archivos
```bash
adb pull
adb push
adb shell ls
adb shell cd
adb shell rm
adb shell mkdir
adb shell touch
adb shell cat
adb shell pwd
adb shell cp
adb shell mv
```

Red
```bash
adb shell netstat
adb shell ping
adb shell netcfg
adb shell ip
```

Logcat | Registros locos
```bash
adb logcat
adb shell dumpsys
adb shell dumpstate
```

Screanshot | Captura de pantalla
```bash
adb shell screencap
adb shell screenrecord
```

System | Sistema Root
```bash
adb root
adb sideload
adb shell ps
adb shell top
adb shell getprop
adb shell setprop
```
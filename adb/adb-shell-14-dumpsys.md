<https://adbshell.com/commands/adb-shell-dumpsys>

# adb shell dumpsys
Para descartar todos los servicios  
```bash
adb shell dumpsys
```

Solo enumera servicio, no los descartes:  
```bash
adb shell dumpsys -l
```

Obtener información sobre la bateria del dispositivo Andriod:  
```bash
adb shell dumpsys battery
```
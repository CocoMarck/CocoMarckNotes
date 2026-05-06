[Enlace de tutorial](https://adbshell.com/commands/adb-shell-ps)

# adb shell ps
Lista de procesos. Qué procesos mostrar (las selecciones pueden ser listas separadoas por comas).
```bash
adb shell ps
```

Todos los procesos
```bash
adb shell ps -A
```

Filtrar PIDs (--pid)
```bash
adb shell ps -p 1256
```

Mostrar hilos
```bash
adb shell ps -t
```
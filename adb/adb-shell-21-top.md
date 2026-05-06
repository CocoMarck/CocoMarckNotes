[Enlace](https://adbshell.com/commands/adb-shell-top)

# adb shell top

Mostrar la actividad del proceso en tiempo real
```bash
adb shell top
```

Cursor izquierda/derecha para cambiar el orden, arriba/abajo para mover la lista, espacio para forzar la actualización, R para invertir el orden, Q para salir.
Mostrar hilos.
```bash
adb shell top -H
```

Mostrar campos (`def PID, USER, PR, NI, VIRT, RES, SHR, S, %CPU, %MEM, TIME+, CMDLINE`)
```bash
adb shell top -o %CPU, %MEM, TIME+
```

Número máximo de tareas a mostrar
```bash
adb shell top -m 50
```
<https://adbshell.com/commands/adb-shell-netstat>




# adb shell netstat
Muestra información de la red.
El valor por defecto de netstat es `-tuwx`

Tabla de enrutamiento
```bash
adb shell netstat -r
```

Todos los enchufes (no sólo los conectados)
```bash
adb shell netstat -a
```
Escuchando sockets de servidor
```bash
adb shell netstat -l
```

# Sockets TCP
```bash
adb shell netstat -t
```

Sockets UDP
```bash
adb shell netstat -u
```

Sockets sin procesar
```bash
adb shell netstat -w
```

Sockets de Unix
```bash
adb shell netstat -x
```

Información ampleada
```bash
adb shell netstat -e
```

No resuelvas nombres
```bash
adb shell netstat -n
```

Pantalla ancha
```bash
adb shell netstat -w
```

Mostrar el nombre del programa/PID de los sockets
```bash
adb shell netstat -p
```
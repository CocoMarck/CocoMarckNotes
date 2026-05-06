<https://adbshell.com/commands/adb-shell-ping>

# adb shell ping

ping (Packet Internet Groper) es una utilidad de administración de red que se utiliza para probar y diagnosticar problemas de conectividad de red.
```bash
adb shell ping
```

> Notas: Precione Ctrl+C para detener el ping

Especifica el número de mensajes de solicitud de eco enviados.
```bash
adb shell ping -c 4
```

Especifica la cantidad de tiempo, en milisegundos, que se debe esperar para recibir el mensaje de respuesta de eco correspondiente a un mensaje de solicitud de eco determinado.
El tiempo de espera predeterminado es 4000 (4 segundos)
```bash
adb shell ping -W 200 127.0.0.1
```

Intervalo en segundos
De forma predeterminada, el intervao es de 1 segundo.
```bash
adb shell ping -i 2 127.0.0.1
```

Ejemplo usando todo:
```bash
ping -W 200 -i 2 -c 4 127.0.0.1
```
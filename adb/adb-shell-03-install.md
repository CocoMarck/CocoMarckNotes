[Referencia](https://adbshell.com/commands/adb-install)

Instalación de la aplicación: envía un solo paquete al dispositivo y lo instala.
```bash
adb install test.apk
```

Instalación de la aplicación: envía varios APK al dispositivo para un solo paquete e instálalos:
```bash
adb install-multiple test.apk test2.apk
```

Instalación de la aplicación: envía uno o más paquetes al dispositivo y los instala de forma automática.
```bash
adb install-multi-package test.apk demo.apk
```

Reemplazar la aplicación existente
Reinstalar una aplicación existente, conservando sus datos.
```bash
adb install -r test.apk
```

Activar paquetes de prueba
```bash
adb install -t test.apk
```

Permite la rebaja de la versiöón de código.
Solo jala en Pequetes debuggables solamente:
```bash
adb install -ded test.apk
```

Otorgar todos los permisos de tiempo de ejcución
Concede todos los permisos listados en el manifiesto de la aplicación
```bash
adb install -g test.apk
```

Hacer que la aplicación se instale como una aplicación de instalación efímera
```bash
add install --instant test.apk
```

Utilizar el despliegue rápido
```bash
adb install --fastdeploy test.apk
```

Siempre empujar APK al dispositivo e invocar el Administrador de paquetes como pasos separados
```bash
adb install --no-streaming test.apk
```
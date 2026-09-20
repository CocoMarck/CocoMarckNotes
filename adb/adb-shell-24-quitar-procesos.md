# Ejecución en segundo plano de package.

#### Con esto se evita que una app ejecute procesos o servicios al estar cerrada:
```bash
adb shell cmd appops set NOMBRE_DEL_PAQUETE RUN_IN_BACKGROUND ignore
adb shell cmd appops set NOMBRE_DEL_PAQUETE RUN_ANY_IN_BACKGROUND ignore
```

#### Con esto se revoca el acceso a ubicación en segundo plano:
```bash
adb shell pm revoke NOMBRE_DEL_PAQUETE android.permission.ACCESS_BACKGROUND_LOCATION
```
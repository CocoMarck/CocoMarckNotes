# Configuraciones globales

# Settings
```bash
# Ayuda general.
adb shell settings help

# Para configuraciones globales.
adb shell settings list global

# Para configuraciones del sistema, posiblemente necesiten root.
adb shell settings list system

# Para seguridad, posiblemente necesiten root.
adb shell settings list secure
```

## Ejemplos
#### Desactivar la búsqueda constante de Wi-Fi y Bluetooth para ubicación: 
```bash
adb shell settings put global wifi_scan_always_enabled 0
adb shell settings put global ble_scan_always_enabled 0
```

#### Activar la limitación de escaneo Wi-Fi (ahorra batería):
```bash
adb shell settings put global wifi_scan_throttle_enabled 1
```

#### Desactivar "Datos móviles siempre activos" estando en Wi-Fi:
```bash
adb shell settings put global mobile_data_always_on 0
```

Como se puede ver, no se usan booleanos, se usa directamente binario, cero o uno. Se indica a `settings`, que `put` la instrucción a `global`, de $x$ configuración.
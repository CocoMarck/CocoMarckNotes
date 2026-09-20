#!/bin/bash
# -----------------------------------------------------------------------------
# Descripción: Script generalista de optimización de rendimiento, batería y
#              privacidad para dispositivos Android con Google Apps (GApps).
# Requisitos:  ADB habilitado, depuración USB activa.
# -----------------------------------------------------------------------------
set -euo pipefail
echo "==> Aplicando optimizaciones de sistema y GApps..."

# Desactivar la búsqueda constante de Wi-Fi y Bluetooth para ubicación
adb shell settings put global wifi_scan_always_enabled 0
adb shell settings put global ble_scan_always_enabled 0

# Activar la limitación de escaneo Wi-Fi (ahorra batería)
adb shell settings put global wifi_scan_throttle_enabled 1

# Desactivar "Datos móviles siempre activos" estando en Wi-Fi
adb shell settings put global mobile_data_always_on 0

# Desactivar envío de errores y métricas de uso a Google
adb shell settings put secure send_action_app_error 0

# No modificar configuración del sistema
adb shell cmd appops set com.google.android.gms WRITE_SETTINGS ignore
adb shell cmd appops set com.android.vending WRITE_SETTINGS ignore

# Ajustar animaciones a 0.0x de 1.0x
adb shell settings put global window_animation_scale 0.0
adb shell settings put global transition_animation_scale 0.0
adb shell settings put global animator_duration_scale 0.5


# --------------------------------------------------

# Verificar configuración de wifi, y telemetria loquita.
echo -n "Wifi scan always: "; adb shell settings get global wifi_scan_always_enabled

echo -n "Bluetooth scan always: "; adb shell settings get global ble_scan_always_enabled

echo -n "Wifi scan throttle: "; adb shell settings get global wifi_scan_throttle_enabled

echo -n "Mobile data always on: "; adb shell settings get global mobile_data_always_on

echo -n "Send action app error: "; adb shell settings get secure send_action_app_error

echo -n "Verificar escaneo continuo de Wi-Fi: "; adb shell settings get global wifi_scan_always_enabled

# Verificar si esta ignorado o no
echo -n "Google play services: "; adb shell cmd appops get com.google.android.gms WRITE_SETTINGS

echo -n "Play Store: "; adb shell cmd appops get com.android.vending  WRITE_SETTINGS

# Verificar que las animaciones cambiaron correctamente
echo -n "Escala de animación de ventanita: "; adb shell settings get global window_animation_scale

echo -n "Escala de animación de transición: "; adb shell settings get global transition_animation_scale

echo -n "Escala de animación de widgets: "; adb shell settings get global animator_duration_scale
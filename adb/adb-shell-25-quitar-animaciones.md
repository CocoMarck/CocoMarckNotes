# Quitar animaciones

#### Ajustar animaciones (De 0.0x a 1.0x):
```bash
adb shell settings put global window_animation_scale 0.0
adb shell settings put global transition_animation_scale 0.0
adb shell settings put global animator_duration_scale 1.0
```

#### Verificar que las animaciones cambiaron correctamente: 
```bash
adb shell settings get global window_animation_scale
adb shell settings get global transition_animation_scale
adb shell settings get global animator_duration_scale
```

> **Nota sobre animaciones (`scale 0`):** No se desactivan por consumo de GPU, sino para eliminar el *delay* artificial impuesto por el WindowManager. La GPU pasa directamente a dibujar el frame final, logrando una respuesta al toque instantánea.
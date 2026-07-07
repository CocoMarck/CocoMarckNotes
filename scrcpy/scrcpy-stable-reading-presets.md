# scrcpy stable reading presets

Notas para usar `scrcpy` con buena calidad de lectura de documentos y menos carga en el celular.

## Preset recomendado

Resolucion nativa, pero con FPS limitado:

```bash
scrcpy --max-size=0 --max-fps=10
```

## max-size 0

En `scrcpy`, `--max-size=0` significa sin limite de size.

Esto no escala hacia arriba. Solo evita limitar la resolucion capturada:

- si el celular tiene menos de `1920`, no lo infla;
- si se usa `--max-size=1920`, limita el lado largo a `1920`;
- si se usa `--max-size=0`, deja pasar la resolucion disponible del display.

## FPS fijo

Para lectura, `10 fps` suele ser suficiente:

```bash
scrcpy --max-size=1920 --max-fps=10
```

Limitar FPS ayuda a reducir:

- carga del encoder;
- calentamiento;
- consumo de bateria;
- picos raros de streaming.

## FPS nativos del celular

Los FPS nativos normalmente corresponden a los Hz del display: `60 Hz`, `90 Hz`, `120 Hz`, etc.

Para ver los refresh rates reportados por Android:

```bash
adb shell dumpsys display | grep -i "refresh"
```

En PowerShell:

```bash
adb shell dumpsys display | Select-String -Pattern "refresh"
```

Para usar FPS nativos/unlimited en `scrcpy`, lo mas limpio es no pasar `--max-fps`:

```bash
scrcpy --max-size=0
```

No asumir que `--max-fps=0` o `--max-fps=-1` significan FPS nativos.

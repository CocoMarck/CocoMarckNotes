# Grand Thef Auto Render Ware Audios

## Adios compatibles
- Formato: WAV (PCM de `16` bits).
- Canales: Mono (Es vital para el sonido 3D del juego; si es estéreo, no se posicionará bien respecto a CJ).
- Frecuencia: `22050` Hz o `32000` Hz (`44100` Hz a veces causa ruidos estáticos en hardware viejo).

## FFMPEG PREFIX
```bash
ffmpeg -i input_audio.mp3 -ar 22050 -ac 1 -sample_fmt s16 output_gtasa.wav
```

> Puede ser cualquier input, mp3, wav, ogg, incluso video. FFMPEG hara la chamba.

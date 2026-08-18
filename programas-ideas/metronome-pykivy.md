# Metronomo

Sera una aplicacion pykivy. Pero despues se hara una app escrita en csharp avalonia. Tendra funciones adicionales, obtener barras a segundos, segundos a barras. Claro, usando los ajustes actuales del metronomo para hacer las conversiones.

Opcionalmente ver si Kotlin lang permite hacer esto con baja latencia y de forma mas sencilla.

### Las ramas:
- `main` sería la versión Python para PC, funcional y limpia.

- `android` sería la adaptación Android: padding, touch layout, permisos, `buildozer.spec`, rutas Android, storage, backend de audio Android, icono, splash y detalles de empaquetado.

> La rama Android no debería convertirse en otra app. Debe ser la misma lógica core, pero con ajustes de plataforma.

El `MetronomeClock` es la verdad del tiempo musical. Puede encargarse de BPM, beats por barra, tiempo actual, beat actual, barra actual, señales de cambio de beat/barra, y `update(dt)`.

Usar un `MetronomeClock` pelón para señales/update, y un módulo aparte tipo `MusicTime` para conversiones. Conversiones como obtener segundos a barras, barras a segundos, etc.

El uso de `dt` está bien porque tu app no procesa audio sample por sample. Python/Kivy solo controla estados y manda señales: play, stop, record, stop record, conteo de barras, cambios de track, etc. El audio real lo manejan `SoundPool` en Android o `ffplay` en PC.

Limitar la app a algo como 40-100 FPS configurable tiene sentido. No necesitas hacks extremos de game loop porque no estás haciendo física ni DSP low-level. Tu capa Python es más scheduler/control layer.

Para audio, en PC puedes seguir con `ffplay`. En Android, `SoundPool` está bien para loops/clips si ya te funciona con baja latencia. Si luego quieres algo más serio, C# puede ser una buena siguiente etapa, y para baja latencia real en Android lo fuerte sería Oboe/AAudio con backend nativo.

El uso de interfaces es clave. En vez de que los tracks dependan directamente de `ffplay` o `SoundPool`, puedes tener algo tipo `ISoundManager`, o `ISound`. O manager o sound, no los dos. El manager ya tiene para obtener objetos de sonido, y este mismo los maneja.

La idea buena es que un track pueda decir “dame mi audio” y hacer play/stop sin saber qué hay debajo.

Conceptualmente:
- `SoundManager` es registro/fábrica/cache de sonidos.
- `Audio` es el objeto controlable que puede reproducirse, detenerse, cambiar volumen, etc.

Lo más importante: no mezclar lógica musical, backend de audio, UI, rutas, permisos y plataforma. Mientras mantengas esas fronteras, portar de PC a Android o luego de Python a C# será mucho más fácil.

Filosofía general:
- Python/Kivy sirve para descubrir y limpiar la arquitectura.
- C# serviría para construir una versión más sólida a largo plazo.
- Oboe/AAudio sería para exprimir baja latencia real si algún día lo necesitas. (C# puede integrarlo mediante bindings/JNI o una capa nativa pequeña.)

> Por ahora no conviene sobre-ingenierizar. Haz la versión Python limpia, modular y funcional. Luego Android como adaptación de plataforma, no como reescritura caótica.
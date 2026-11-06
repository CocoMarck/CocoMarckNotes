# Simple Free Hands Assist Open Code
Simplemente escucha lo que dices, obtiene la primer palabra dicha (nombre del asistente), y si es correcta, pasa a la orden.

Ejemplo: `Asistente, abre el navegador web.`

**Foco actual**: el programa no piensa. Solo hace tres cosas: escuchar con Vosk, mandar el texto a Open Code, y leer en voz alta la respuesta con espeak-ng. Toda la inteligencia y todas las decisiones (abrir apps, ejecutar cosas, responder) son de Open Code, con el agente que ya tengo configurado. Sin modelo de lenguaje propio, sin API, sin claves, sin internet.

---

## Stack tecnológico
- **STT**: [vosk](https://alphacephei.com/vosk/) con `vosk-model-small-es-0.42` (40 MB, CPU)
- **LLM**: `opencode run` local. No hay modelo propio ni servicio de pago
- **TTS**: [espeak](https://espeak.sourceforge.net/) (`espeak-ng`, por apt)
- **Lenguaje principal**: Python 3, solo libreria estandar mas `vosk`
- **Audio**: `parec` (PipeWire) para grabar, `pw-play` para reproducir
- **Control**: socket unix en `$XDG_RUNTIME_DIR/simple-assist/voice.sock`
- **Servicio**: systemd de usuario
- **Paquetes python**: `uv package manager`, y `apt` para lo del sistema

---

## Arquitectura

```
microfono (parec, 16 kHz mono)
     |
     v
vosk con gramatica de una sola palabra  ->  oyes "asistente"?
     | si
     v
vosk en espanol  ->  texto de la orden
     |
     v
opencode run --session <id>  (local, sin API)
     |
     v
normalizar  ->  espeak-ng  ->  pw-play
```

### Deteccion de la palabra clave
Vosk acepta una gramatica restringida. Se le pasa `["asistente", "[unk]"]`, de forma que solo busca esa palabra y el resto lo descarta. Es la parte mas barata: un solo modelo, en reposo, sin transcribir nada.

Al oirla, el mismo modelo ya cargado pasa a reconocer en espanol libre, y la orden acaba cuando hay 1,2 s de silencio.

### Sesion de Open Code
La orden se manda a `~/.local/share/simple-assist/sesion`, un directorio propio, con `--dir`. Ahi se guarda el `sessionID` que viene en los eventos JSON, y las siguientes ordenes se mandan con `--session <id>`. Por eso la conversacion tiene memoria:

> `asistente, abre firefox` -> `asistente, y ahora el editor`

Ese directorio separado es a proposito: las voces nunca se mezclan con las sesiones de Open Code de la terminal.

Si la sesion guardada ya no existe, se reintenta con `--continue` y se olvida la guardada.

### Lectura de la respuesta
`opencode run --format json` devuelve eventos JSON. Se concatenan los `type: "text"` y se ignoran `step_start` y `step_finish`.

---

## STT (normalizar texto para el TTS)
Normalizar texto para el TTS. Solo permitir caracteres abc, y números, para que no ande diciendo el espeak cosas como "comilla invertida, comilla invertida".

En este orden:
1. Fuera bloques de codigo ```` ``` ````, codigo en linea y enlaces `[texto](url)`
2. Las URL pasan a la palabra `enlace`
3. Fuera rutas de fichero (`~/notas/idea.md`, `/usr/share/...`)
4. Fuera las marcas de lista (`-`, `*`, `#`, `1.`)
5. Simbolos con voz propia: `%` por ciento, `&` y, `+` mas, `@` arroba
6. Solo se quedan letras, digitos, espacios y `. , ! ? ¿ ¡`
7. Si se pasa de `tts.maximo_caracteres`, se corta en la ultima palabra

Las letras acentuadas y la `ñ` se conservan: el espanol las necesita y espeak-ng las pronuncia bien.

---

## Reglas técnicas
- **Sin API**: nada de claves, ni de servicios de pago, ni de internet. Ni STT ni LLM
- **Sin modelo propio**: el programa no tiene LLM. Si se quiere inteligencia, se configura en el agente de Open Code
- **Sin root**: no instala nada en `/usr`, ni servicios de sistema, ni archivos en `/etc`
- **Aislado**: todo en un directorio; se borra con `systemctl --user disable` y un `rm -rf`
- **No toca Open Code**: corre su propia sesion en su propio directorio, y no modifica su configuracion
- **Solo escucha**: el microfono se abre al detectar la palabra clave y se cierra al terminar la orden
- **Tolerante a fallos**: si falta vosk, espeak-ng u opencode, avisa en el log y sigue sirviendo el socket
- **Sin permisos de ejecucion**: el servicio no ejecuta comandos por su cuenta; eso es de Open Code

---

## Estado

Ya implementado en `~/Proyectos/Programacion/python/gitclones/simple-assist`:

| Fichero | Que es |
|---|---|
| `voice-assistant.py` | el servicio completo |
| `voice` | la CLI que habla con el socket |
| `config.json` | palabra clave, silencios, comando de opencode, voz |
| `simple-assist.service` | unit de systemd de usuario |
| `pyproject.toml` | dependencia `vosk` |
| `README.md` | puesta en marcha y desinstalacion |

Comprobado: la deteccion de palabra clave, el parseo de los eventos JSON, la normalizacion, la entrega a `opencode run` y la memoria entre ordenes con `--session`.

Pendiente de probar en la maquina: el audio de verdad (falta instalar `espeak-ng`, el modelo de vosk y el microfono), y el atajo de teclado en KDE.

---

## Fases
1. **Fase 1**: salir de la peticion: palabra clave, orden, `opencode run`, voz. Es lo que hay
2. **Fase 2**: atajo global en KDE (Configuracion del sistema -> Atajos -> Atajos personalizados) para `voice once` y `voice stop`
3. **Fase 3**: permisos del agente en `sesion/opencode.json` para que `abre el navegador` de verdad abra Firefox
4. **Fase 4**: bajar la latencia con un `opencode serve` fijo y `--attach`
5. **Fase 5**: wake word de verdad, sin tocar nada, con openWakeWord

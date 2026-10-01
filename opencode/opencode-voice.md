# OpenCode Voice
> No me gusto el proyecto, depende de GPU, de lo contrario consume mucha CPU, es lento, y no es practico de usar.

- [OpenCode Voice Github](https://github.com/renjfk/opencode-voice)
- Tutorial del `2026-09-27`

## Instalar dependencias en debian

#### Para poder compilar las dependencias.
```bash
sudo apt install sox libsox-fmt-pulse pulseaudio-utils build-essential cmake
```

#### Probar micrófono
```bash
sox -d /tmp/mic-check.wav trim 0 3   # speak for 3 seconds
play /tmp/mic-check.wav              # you should hear yourself
rm /tmp/mic-check.wav                # delete after verification
```
> Ejecuta los comando, ponte a hacer ruido, se debe reproducir solo el sonido.

### Whisper

#### Compilar `whisper-cli`, usando CPU
```bash
git clone https://github.com/ggml-org/whisper.cpp ~/opt/whisper.cpp
cmake -B ~/opt/whisper.cpp/build -S ~/opt/whisper.cpp \
  -DCMAKE_BUILD_TYPE=Release -DWHISPER_BUILD_TESTS=OFF
cmake --build ~/opt/whisper.cpp/build -j --target whisper-cli
sudo ln -sf ~/opt/whisper.cpp/build/bin/whisper-cli /usr/local/bin/whisper-cli
```

#### Descargar modelo y smoke test
Descarga y instalación
```bash
mkdir -p ~/.local/share/whisper-cpp
curl -L -o ~/.local/share/whisper-cpp/ggml-large-v3-turbo-q5_0.bin \
  https://huggingface.co/ggerganov/whisper.cpp/resolve/main/ggml-large-v3-turbo-q5_0.bin
```

Prueba transcribiendo una breve grabación:
```bash
sox -d /tmp/smoke.wav trim 0 4   # say something for 4 seconds
whisper-cli -m ~/.local/share/whisper-cpp/ggml-large-v3-turbo-q5_0.bin \
  -f /tmp/smoke.wav -l auto -nt
rm /tmp/smoke.wav
```
> Habla en tu idioma, menciona algo simple por cuatro segundos. Debe salir de output el texto que mencionaste.

### TTS Conversión de texto a voz 
#### Instalamos UV (Recomendado para Debian 13)
```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

#### Instalar piper:
```bash
uv tool install piper-tts # Con uv
#pip install piper-tts # Con pip No recomendado para Debian 13.
```

#### Descargar un modelo de voz para `~/.local/share/piper-voices/`:
```bash
mkdir -p ~/.local/share/piper-voices
# Voces en ingles. Necesarias para default working.
curl -L -o ~/.local/share/piper-voices/en_US-ryan-high.onnx \
  https://huggingface.co/rhasspy/piper-voices/resolve/main/en/en_US/ryan/high/en_US-ryan-high.onnx
curl -L -o ~/.local/share/piper-voices/en_US-ryan-high.onnx.json \
  https://huggingface.co/rhasspy/piper-voices/resolve/main/en/en_US/ryan/high/en_US-ryan-high.onnx.json

# Voces en español porque es lo que hablo.
curl -L -o ~/.local/share/piper-voices/es_ES-davefx-medium.onnx \
  https://huggingface.co/rhasspy/piper-voices/resolve/main/es/es_ES/davefx/medium/es_ES-davefx-medium.onnx
curl -L -o ~/.local/share/piper-voices/es_ES-davefx-medium.onnx.json \
  https://huggingface.co/rhasspy/piper-voices/resolve/main/es/es_ES/davefx/medium/es_ES-davefx-medium.onnx.json
```


---

## Establecer complemento
Ponemos esto en el archivo de  configuración de open code: `~/.config/opencode/tui.json`. Si no existe, crearlo.
```json
{
  "$schema": "https://opencode.ai/tui.json",
  "keybinds": {
    "session_rename": "none"
  },
  "plugin": [
    [
      "@renjfk/opencode-voice",
      {
        "endpoint": "https://api.anthropic.com/v1",
        "model": "claude-haiku-4-5",
        "apiKeyEnv": "ANTHROPIC_API_KEY"
      }
    ]
  ]
}
```

Si tienes una versión anterior de opencode voice, borrar paquetes viejos.
```bash
rm -rf ~/.cache/opencode/packages/@renjfk/
```

---

## End point LLM
Se requiere un punto final LLM compatible con OpenAI para la normalización de texto. Para de voz a texto limpia la salida de susurros (puntuación, palabras de relleno, software homófonos de ingeniería). Para la conversión de texto a voz, convierte Markdown en texto natural. texto hablado.

Configure su punto final en `tui.json` a través de las opciones del complemento. Cualquier compatible con OpenAI El punto final funciona (Anthropic, OpenAI, Ollama, vLLM, LM Studio, etc.). `apiKeyEnv` Esta opción es opcional; omítala para puntos finales no autenticados como Ollama. 

```json
{
  "plugin": [
    [
      "@renjfk/opencode-voice",
      {
        "endpoint": "https://api.anthropic.com/v1",
        "model": "claude-haiku-4-5",
        "apiKeyEnv": "ANTHROPIC_API_KEY"
      }
    ]
  ]
}
```

Para puntos finales locales no autenticados (por ejemplo, Ollama): 
```json
{
  "plugin": [
    [
      "@renjfk/opencode-voice",
      {
        "endpoint": "http://localhost:11434/v1",
        "model": "llama3.2"
      }
    ]
  ]
}
```

---

## Desinstalación

Ejecuta en orden inverso a la instalación. Libera aproximadamente **1 GB**.

> Dos pasos piden `sudo`: el symlink de `whisper-cli` y los paquetes de `apt`.
> **Cuidado con `build-essential` y `cmake`**: son genéricos y los usa cualquier proyecto que compiles. Bórralos solo si los instalaste únicamente para compilar whisper.cpp.
> Lo mismo con `sox`, `libsox-fmt-pulse` y `pulseaudio-utils`: son utilidades de audio de uso general, no exclusivas de este plugin.

### 1. Quitar el complemento de opencode

Borra el archivo de configuración del TUI, que en una instalación limpia solo contiene lo de este plugin:
```bash
rm -f ~/.config/opencode/tui.json
```

Borra también la caché del paquete descargado:
```bash
rm -rf ~/.cache/opencode/packages/@renjfk/
```

> Si prefieres conservar `tui.json` para otros ajustes, en lugar de borrarlo elimina solo el bloque `"plugin"` y el bloque `"keybinds"`. El atajo `session_rename: "none"` existe únicamente para liberar `ctrl+r` para el plugin; sin él, `ctrl+r` vuelve a ser renombrar sesión.
> **Reinicia opencode**: la configuración no se recarga en caliente.

### 2. Desinstalar TTS (piper y las voces)

```bash
uv tool uninstall piper-tts
rm -rf ~/.local/share/piper-voices
```

> `uv tool uninstall` ya elimina el ejecutable `piper` de `~/.local/bin`.

### 3. Quitar uv

Solo si no lo usas para nada más. Se instaló exclusivamente para este tutorial:
```bash
rm -f ~/.local/bin/uv ~/.local/bin/uvx
rm -rf ~/.local/share/uv ~/.cache/uv ~/.config/uv
```

> El instalador de `uv` no modifica tu `.bashrc` si `~/.local/bin` ya estaba en el `PATH`, así que no hay nada más que limpiar en tu shell.

### 4. Quitar whisper

Quita **el symlink antes que el clon**, o el symlink se queda roto apuntando a un destino inexistente:
```bash
sudo rm -f /usr/local/bin/whisper-cli
rm -rf ~/opt/whisper.cpp
rm -rf ~/.local/share/whisper-cpp
```

> `~/.local/share/whisper-cpp` contiene el modelo de 548 MB: es la mayor parte de lo que ocupa.

### 5. Quitar los paquetes del sistema

```bash
sudo apt remove --purge sox libsox-fmt-pulse pulseaudio-utils
sudo apt autoremove --purge
```

### 6. Verificar

No debería quedar nada:
```bash
ls -d ~/opt/whisper.cpp ~/.local/share/whisper-cpp ~/.local/share/piper-voices \
      ~/.local/bin/piper ~/.local/bin/uv ~/.config/opencode/tui.json 2>/dev/null
ls -la /usr/local/bin/whisper-cli 2>/dev/null
```

Si el primer comando no imprime nada y el segundo tampoco, la desinstalación está completa.

### Variante con clon local

Solo aplica si en lugar del paquete de npm usaste un clon para modificar el código (el tutorial no lo cubre, pero es la opción para trabajar sin publicar cambios):
```bash
rm -rf ~/opt/opencode-voice
```
# Instalar Firefox (repo oficial de Mozilla) en Debian 13 (trixie)

Guía para configurar el repositorio APT oficial de Mozilla e instalar Firefox como paquete `.deb` en Debian 13.

## Requisitos

- Debian 13 (trixie) amd64
- Acceso `sudo`
- Conexión a Internet

## 1. Crear el directorio para las llaves APT

```bash
sudo install -d -m 0755 /etc/apt/keyrings
```

## 2. Importar la llave de firma del repositorio

```bash
wget -q https://packages.mozilla.org/apt/repo-signing-key.gpg -O- \
  | sudo tee /etc/apt/keyrings/packages.mozilla.org.asc > /dev/null
```

Si `wget` no está instalado:

```bash
sudo apt install wget
```

(Opcional) Verificar la huella de la llave:

```bash
gpg -n -q --import --import-options import-show /etc/apt/keyrings/packages.mozilla.org.asc \
  | awk '/pub/{getline; gsub(/^ +| +$/,""); print "\n"$0"\n"}'
```

## 3. Añadir el repositorio de Mozilla

Usa el formato deb822 (recomendado en Debian 13). Crea `/etc/apt/sources.list.d/mozilla.sources` con este contenido exacto:

```bash
sudo tee /etc/apt/sources.list.d/mozilla.sources > /dev/null <<'EOF'
Types: deb
URIs: https://packages.mozilla.org/apt
Suites: mozilla
Components: main
Architectures: amd64
Signed-By: /etc/apt/keyrings/packages.mozilla.org.asc
EOF
```

> `Architectures: amd64` evita el aviso sobre `i386` si tu sistema tiene esa arquitectura habilitada; no afecta a otros repositorios.

**Importante:** evita tener el mismo repositorio definido dos veces (por ejemplo, en `mozilla.sources` y en `mozilla.list`) para no generar conflictos. Si existe `/etc/apt/sources.list.d/mozilla.list` con la misma entrada, elimínalo o respáldalo:

```bash
sudo mv /etc/apt/sources.list.d/mozilla.list /etc/apt/sources.list.d/mozilla.list.bak 2>/dev/null || true
```

## 4. Dar prioridad al repositorio de Mozilla

Esto asegura que APT prefiera los paquetes de Mozilla frente a otros orígenes:

```bash
sudo tee /etc/apt/preferences.d/mozilla > /dev/null <<'EOF'
Package: *
Pin: origin packages.mozilla.org
Pin-Priority: 1000
EOF
```

## 5. Actualizar e instalar

```bash
sudo apt update
sudo apt install firefox
```

### Otras variantes e idiomas

- **Firefox Developer Edition:** `sudo apt install firefox-devedition`
- **Paquetes de idioma (ejemplos):**
  - Español (España): `sudo apt install firefox-l10n-es-es`
  - Español (México): `sudo apt install firefox-l10n-es-mx`
  - Español (Argentina): `sudo apt install firefox-l10n-es-ar`
  - Español (Chile): `sudo apt install firefox-l10n-es-cl`
- Para ver idiomas disponibles: `apt-cache search firefox-l10n | grep -- "-es-"`

## Solución de problemas

### Error: "No se pudo analizar el archivo ... mozilla.sources"

Suele deberse a contenido inválido en el archivo deb822 (por ejemplo, líneas extra como `EOF` o `>>` pegadas al final).

1. Revisa el archivo:
   ```bash
   cat /etc/apt/sources.list.d/mozilla.sources
   ```
2. Corrígelo dejando solo las estrofas válidas (ver paso 3). Si hay un `.list` y un `.sources` duplicando el mismo repo, conserva uno solo y bien formado.
3. Vuelve a ejecutar `sudo apt update`.

### Aviso: "Omitiendo ... no admite la arquitectura «i386»"

Es esperado: el repositorio de Mozilla no publica paquetes `i386`. APT solo omite `i386` para ese repo; tus demás repositorios y paquetes `i386` del sistema no se ven afectados. Para silenciar el aviso, añade `Architectures: amd64` al archivo `.sources` (como en el paso 3).

## Notas

- El repo oficial permite recibir actualizaciones de Firefox directamente desde Mozilla.
- Si tenías la versión Snap de Firefox (común en Ubuntu), en Debian 13 normalmente no aplica; si existiera, se puede convivir o desinstalar según prefieras.
- Referencia: [Instalar Firefox en Linux (Mozilla Support)](https://support.mozilla.org/es/kb/Instalar-firefox-linux)

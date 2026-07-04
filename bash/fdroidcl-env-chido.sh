#!/bin/bash

# Detectar binario fdroidcl_* en la carpeta del script
SCRIPT_DIR="$(dirname "$(realpath "$0")")"
FDROID_BIN="$(ls "$SCRIPT_DIR" | grep -E '^fdroidcl_' | head -n 1)"

if [ -z "$FDROID_BIN" ]; then
    echo "No se encontró binario fdroidcl_* en $SCRIPT_DIR"
    exit 1
fi

FDROID_PATH="$SCRIPT_DIR/$FDROID_BIN"

# Exportar PATH temporal
export PATH="$SCRIPT_DIR:$PATH"

echo "Usando binario: $FDROID_PATH"
echo "Entrando a shell temporal con fdroidcl disponible..."
echo "Tip: prueba 'fdroidcl update' o 'fdroidcl search <app>'"

# Abrir subshell interactivo con el entorno listo
bash --rcfile <(echo "alias fdroidcl='$FDROID_PATH'")

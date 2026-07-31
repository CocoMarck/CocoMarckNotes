#!/usr/bin/env bash

set -o errexit
set -o pipefail

script_name="$(basename "$0")"

binary="$(find . -maxdepth 1 -type f -perm -u+x ! -name "$script_name" | sort | head -n 1)"

if [[ -z "$binary" ]]; then
    echo "No se encontro ningun binario ejecutable en el directorio actual." >&2
    exit 1
fi

echo "Ejecutando: $binary"
exec "$binary" "$@"

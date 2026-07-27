#!/bin/bash
SCRIPT_DIR="$(dirname "$(realpath "$0")")"

# Import
read_requirements_script="$SCRIPT_DIR/read_requirements.sh"


# Ejecutar instrucción
prefix="$1"
apps=()
for file in "$@"; do
    apps+=($("$read_requirements_script" "$file"))
done

for app in "${apps[@]}"; do
    echo $prefix $app
    $prefix $app
    echo
done
#!/bin/bash

# Uso ./flatpak_prepare_debian13_2026.sh ../prepare_dispositive.sh
# Donde esta el script que obtiene names de un txt. Ordenados; nombre de package por cada linea.
SCRIPT_DIR="$(dirname "$0")"

# Establecer directorio de trabajo
PREPARE_DISPOSITIVE_SCRIPT=$1

# Import source
source "$PREPARE_DISPOSITIVE_SCRIPT"

# Variables
install_prefix="sudo flatpak install -y "

install_apps_paths=(
    # Esenciales
    "$SCRIPT_DIR/flatpak-essentials.txt"
    "$SCRIPT_DIR/flatpak-multimedia-work.txt"

    # Juegitos
    "$SCRIPT_DIR/flatpak-game-emulators.txt"
    "$SCRIPT_DIR/flatpak-native-games.txt"

    # Entretenimiento multimedia
    "$SCRIPT_DIR/flatpak-recrational-multimedia.txt"
)

# Debug
echo $SCRIPT_DIR

# Ejecutar
work

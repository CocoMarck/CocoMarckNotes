#!/bin/bash

# Uso ./flatpak_prepare_debian13_2026.sh ../../script/bash/instruction-get-apps.sh
# Donde esta el script que obtiene names de un txt. Ordenados; nombre de package por cada linea.

# Constantes necesarias
SCRIPT_DIR=$(dirname "$0")

# Variables
instruction_get_apps=$1

# Esenciales
$instruction_get_apps "sudo flatpak install -y " "$SCRIPT_DIR/flatpak-essentials.txt"
$instruction_get_apps "sudo flatpak install -y " "$SCRIPT_DIR/flatpak-multimedia-work.txt"

# Juegitos
$instruction_get_apps "sudo flatpak install -y " "$SCRIPT_DIR/flatpak-game-emulators.txt"
$instruction_get_apps "sudo flatpak install -y " "$SCRIPT_DIR/flatpak-native-games.txt"

# Entretenimiento multimedia
$instruction_get_apps "sudo flatpak install -y " "$SCRIPT_DIR/flatpak-recrational-multimedia.txt"

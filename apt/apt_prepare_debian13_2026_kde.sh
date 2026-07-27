#!/bin/bash

# Preparar apps para KDE desktop. 2026.
# Uso ./apt_prepare_debian13_2026_kde.sh ../prepare_dispositive.sh
# Donde esta el script que obtiene names de un txt. Ordenados; nombre de package por cada linea.

# Constants
SCRIPT_DIR="$(dirname "$(realpath "$0")")"

# Establecer directorio de trabajo
PREPARE_DISPOSITIVE_SCRIPT=$1

# Variables
install_prefix="sudo apt install -y "
uninstall_prefix="sudo apt purge -y "


install_apps_paths=( 
    # Esenciales
    "$SCRIPT_DIR/apt-debian13-essential-general.txt"
    "$SCRIPT_DIR/apt-debian13-chromium.txt"
    "$SCRIPT_DIR/apt-debian13-mesa-and-vulkan.txt"
    "$SCRIPT_DIR/apt-debian13-libreoffice.txt"
    "$SCRIPT_DIR/apt-debian13-essential-kde.txt"

    # Code dev
    "$SCRIPT_DIR/apt-debian13-sql-php-apache.txt"
    "$SCRIPT_DIR/apt-debian13-dev-python.txt"
    "$SCRIPT_DIR/apt-debian13-dev-java.txt"
    
    # Multimedia dev
    "$SCRIPT_DIR/apt-debian13-dev-midi.txt"
    "$SCRIPT_DIR/apt-debian13-dev-multimedia.txt"

    # Games
    "$SCRIPT_DIR/apt-debian13-games.txt"
)

uninstall_apps_paths=(
    "$SCRIPT_DIR/apt-debian13-remove-apps.txt"
)


# Import source
source "$PREPARE_DISPOSITIVE_SCRIPT"

# Debug
echo $PREPARE_DISPOSITIVE_SCRIPT

# Execute
sudo dpkg --add-architecture i386
sudo apt update
work
sudo apt autoremove -y; sudo apt clean;










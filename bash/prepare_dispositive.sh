#!/bin/bash

# Preparar apps para algun dispositivo. Usando su gestor de paquetes. Tiene que ser en script importable, y parameterizable.
# Donde esta el script que obtiene names de un txt. Ordenados; nombre de package por cada linea. 

# DEPENDENCIES |
#              V
# Variables Strings: 
#   install_prefix
#   uninstall_prefix
#
# Variables Tuple of strings
#   install_apps_paths
#   uninstall_apps_paths

# Funciones a importar.
read_requirements() {
    file=$1
    if [ -f "$file" ]; then
        grep -vE '^#|^$' "$file"
    fi
}

using_requirements() {
    # Ejecutar instrucción
    local prefix="$1"
    local apps=()
    for file in "$@"; do
        apps+=($(read_requirements "$file"))
    done

    for app in "${apps[@]}"; do
        echo $prefix $app
        $prefix $app
        echo
    done
}

# Funcion final
work(){
    for path in ${install_apps_paths[@]}; do
        using_requirements "$install_prefix" "$path"
    done

    for path in ${uninstall_apps_paths[@]}; do
        using_requirements "$uninstall_prefix" "$path"
    done
}
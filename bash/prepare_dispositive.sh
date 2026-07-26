#!/bin/bash

# Preparar apps para algun dispositivo. Usando su gestor de paquetes. Tiene que ser en script importable, y parameterizable.
# Uso ./template_prepare_dispositive.sh ./instruction-get-apps.sh
# Donde esta el script que obtiene names de un txt. Ordenados; nombre de package por cada linea.

# DEPENDENCIES |
#              V
# Variables Strings: 
#   instruction_get_apps
#   install_prefix
#   uninstall_prefix
#
# Variables Tuple of strings
#   install_apps_paths
#   uninstall_apps_paths

# Funciones
work() {
    for path in $install_apps_paths; do
        $instruction_get_apps "$install_prefix" "$path"
    done

    for path in $uninstall_apps_paths; do
        $instruction_get_apps "$uninstall_prefix" "$path"
    done
}
#!/bin/bash

# Archivos
#directory_home_prefix=$HOME"/Documentos/AutoHotkey"
directory="$(dirname "$(realpath "$0")")"
pdf="w10-11-shortcuts-chido.pdf"
full_path=$directory/$pdf

# Comando a ejecutar
command="okular '$full_path'"

# Debug y ejecución
echo $command
ls -l '$full_path'
eval $command

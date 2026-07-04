#!/bin/bash

instruction="$1"
shift

# Aplicaciones seleccionadas
apps=()

for file in "$@"; do
    apps+=($(./get-apps.sh "$file"))
done


for app in "${apps[@]}"; do
    $instruction $app
done


# USO: ./instruction-get-apps.sh "adb shell pm uninstall -k --user 0 " ../../package-manager-backup/android/android-remove-apps-lenovo.txt

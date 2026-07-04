#!/bin/bash

instruction="$1"
shift

# Directorio real del script
SCRIPT_DIR="$(dirname "$(realpath "$0")")"

# Aplicaciones seleccionadas
apps=()

for file in "$@"; do
    apps+=($("$SCRIPT_DIR/get-apps.sh" "$file"))
done


for app in "${apps[@]}"; do
    echo $instruction $app
    $instruction $app
    echo
done


# USOS:
# ./instruction-get-apps.sh "adb shell pm uninstall -k --user 0 " ../../package-manager-backup/android/android-remove-apps-motorola.txt
# ./instruction-get-apps.sh "adb shell pm uninstall -k --user 0 " ../../package-manager-backup/android/android-google-trash.txt
# ./instruction-get-apps.sh "adb shell pm uninstall -k --user 0 " ../../package-manager-backup/android/android-google-internet-apps.txt
# ./instruction-get-apps.sh "adb shell cmd package install-existing" ../../package-manager-backup/android/android-play-store-dependencies.txt
# ./instruction-get-apps.sh "adb shell cmd package install-existing" ../../package-manager-backup/android/android-google-internet-apps.txt


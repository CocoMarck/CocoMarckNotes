# !/bin/bash

# Ejemplo: ./prepare-motorola-apps.sh ../../script/bash/instruction-get-apps.sh
instruction_get_apps=$1

# Borrar feos
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-remove-apps-motorola.txt
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-google-trash.txt
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-google-internet-apps.txt

# Asegurar chidos
$instruction_get_apps "adb shell cmd package install-existing" ./android-play-store-dependencies.txt
$instruction_get_apps "adb shell cmd package install-existing" ./android-google-internet-apps.txt

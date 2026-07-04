#!/bin/bash

# Ejemplo: ./prepare-motorola-apps.sh ../../script/bash/instruction-get-apps.sh
instruction_get_apps=$1

# Borrar feos
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-remove-apps-motorola.txt
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-google-trash.txt

# Instalar chidos
"$HOME/Programas/fdroidcl/fdroidcl_v0.8.1_linux_amd64" update
$instruction_get_apps "$HOME/Programas/fdroidcl/fdroidcl_v0.8.1_linux_amd64 install" ./android-fdroid-very-good-apps.txt

# Asegurar chidos
$instruction_get_apps "adb shell cmd package install-existing" ./android-dependencies.txt
$instruction_get_apps "adb shell cmd package install-existing" ./android-play-store-dependencies.txt
$instruction_get_apps "adb shell cmd package install-existing" ./android-google-internet-apps.txt

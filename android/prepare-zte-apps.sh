#!/bin/bash

# Ejemplo: ./prepare-zte-apps.sh ../../script/bash/instruction-get-apps.sh
# Se preparara para jalar sin google.
instruction_get_apps=$1
fdroidcl="$HOME/Programas/fdroidcl/fdroidcl_v0.8.1_linux_amd64"

# Borrar feos zte
$instruction_get_apps "adb shell pm disable-user" ./android-remove-apps-zte.txt
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-remove-apps-zte.txt

# Borrar foes google
$instruction_get_apps "adb shell pm disable-user" ./android-google-trash.txt
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-google-trash.txt

$instruction_get_apps "adb shell pm disable-user" ./android-play-store-dependencies.txt
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-play-store-dependencies.txt

$instruction_get_apps "adb shell pm disable-user" ./android-google-internet-apps.txt
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-google-internet-apps.txt

# Borrar feos facebook
$instruction_get_apps "adb shell pm disable-user" ./android-facebook-dependencies.txt
$instruction_get_apps "adb shell pm uninstall -k --user 0" ./android-facebook-dependencies.txt

# Asegurar chidos y dependencias
$instruction_get_apps "adb shell cmd package install-existing" "./android-dependencies.txt"

# Instalar con fdroid apps chidas
$fdroidcl update
$instruction_get_apps "$fdroidcl install" "./fdroid-essentials.txt"
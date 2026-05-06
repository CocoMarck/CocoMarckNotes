[Referencia](https://adbshell.com/commands/adb-shell-pm-list-packages)




# adb shell pm list packages

Imprime todos los paquetes
```
adb shell pm list packages
```

Ver su archivo APK asociado
```
adb shell pm list packages -f
```

Todos los paquetes conocidos, pero excluyendo APEXes (Android Pony EXpress)
```
adb shell pm list packages -a
```

Solo mostrar paquetes APEX
```
adb shell pm list packages --apex-only
```

Filtro para mostrar solo paquetes deshabilidato
```
adb shell pm list packages -d
```

Filtro para mostrar sólo paquetes habilitados
```
adb shell pm list packages -e
```

Filtro para mostrar los paquetes de sistema
```
adb shell pm list -s
```

Filtro para mostrar sólo paquetes de terceros
```
adb shell pm list packages -3
```

Ver el instalador para los paquetes
```
adb shell pm list packages -i
```

Ignorados (Utilizados para la compatibilidad con versiones más antiguas)
```
adb shell pm list packages -l
```

También mostrar los paquetes UID
```
adb shell pm list packages -U
```

Incluir también paquetes desinstalados
```
adb shell pm list packages -u
```

Mostrar también el código de versión
```
adb shell pm list packages --show-versioncode
```

Filtrar para mostrar solo los paquetes con UID indicado
```
adb shell pm list packages --uid UID
```

Soló enumerar los paquetes que pertenecen al usuario indicado.
```
adb shell pm list packages --user USER_ID
```
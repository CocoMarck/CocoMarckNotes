<https://adbshell.com/commands/adb-logcat>


# Log cat

**Imprime datos de registro en la pantalla**
```
adb logcat
```


*Notes: preciona Ctrl-C para parar el monitor.*


**Pioridad baja, filtrar para mostrar solo el nivel detallado.**
```
adb logcat *:V
```

**Filtar para mostrar solo el nivel de depuración**
```
adb logcat *:D
```

**Filtrar para mostrar solo el nivel de información**
```
adb logcat *:I
```

**Filtrar para mostrar solo el nivel de advertencia**
```
adb logcat *:W
```

**Filtrar para mostrar solo el nivel de error**
```
adb logcat *:E
```

**Filtrar para mostrar solo el nivel fatal**
```
adb logcat *:F
```

**Silencioso, máxima pioridad, en el que nunca se imprime nada**
```
adb logcat *:S
```



---
## ```adb logcat -b <Buffer>```

**Ver el búfer que contiene mansajes relacionados con radio/telefonia**
```
adb logcat -b radio
```

**Ver el bufer que contiene mensajes relacionados con eventos**
```
adb logcat -b event
```




---

**Por defecto**
```
adb logcat -b main
```

**Borra todo el registro y sale**
```
adb logcat -c
```

**Dumps/Vuelca el registro en la pantalla y sale**
```
adb logcat -d
```

**Escribre la salida del mensaje de registro en "test.logs"**
```
adb logcat -f tests.logs
```

**Imprime el tamaño del búfer de registro especificado y sale**
```
adb logcat -g
```

**Establece el número máximo de registros rotados en <count>**
```
adb logcat -n <count>
```

**Rota el archivo de registro cada <kbytes> de salida.**
*Nota: El valor predeterminado es 4, requiere la opción -r*
```
adb logcat -r <kbytes>
```

**Establece la especificación de filtro predeterminada en silencioso**
```
adb logcat -s
```



---
## adb logcat -v <format>

**Muestra la pioridad/etiqueta y PID del proceso que emite el mensaje (formato predeterminado)**
```
adb logcat -v brief
```

**Mostrar solo PID**
```
adb logcat -v process
```

**Mostrar solo la pioridad/etiqueta**
```
adb logcat -v tag
```

**Muestra el mensaje de registro sin procesar, sin otros campos de metadados**
```
adb logcat -v raw
```

**Muestra la fecha, la hora de invocación, la pioridad/etiqueta y el PID del proceso que emite el mensaje**
```
adb logcat -v time
```

**Muestra la fecha, la hora de invocación, la pioridad, la etiqueta y el PID y TID de lhilo que emite el mensaje**
```
adb logcat -v threadtime
```

**Muestra todos los campos de metadatos y separa los mensajes con líneas en blanco**
```
adb logctat -v long
```
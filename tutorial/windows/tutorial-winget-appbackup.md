# Usar `Winget` en 2025
Bueno, actualmente, winget se usa para gestionar paquetes, libs, apps. Te permite instalar, desinstalar, y reinstalar.
La manera de establecer los paquetes/apps a instalar es escribiendo su ID (seria mejor por tags, pero actualmente no tiene este sistema de instalacion por tags).

[Tutorial oficial](https://learn.microsoft.com/es-es/windows/package-manager/winget/)

---

# Saber si jala `winget`
Simplemente, si nos jala este comando: `winget --version`, es porque nos jala winget.

# Ayuda de como usar `winget`
En este tutorial se vera como usar winget de manera sencilla, pero es bueno ver la ayuda original, que aunque no muy descriptiva, es buena para recordar cosas:
```powershell
winget --help
```

# Buscar aplicaciones
Primero que nada tenemos que saber lo que podemos instalar en winget, para eso usamos el parametro `search`, este nos permitira buscar cosas en especifico. 

**Sintaxis**:
```batch
winget search texto
```

**Ejemplo**:
```batch
winget search tux
```
Esto nos devolvera los paquetes que coincidan de alguna manera con el texto `tux`.

**Resultado de ejemplo**:
```
Nombre           Id                              Versión Coincidencia Origen
----------------------------------------------------------------------------
Extreme TuxRacer ExtremeTuxRacer.ExtremeTuxRacer 0.8.4.0 Tag: tux     winget
Pingus           IngoRuhnke.Pingus               0.7.6   Tag: tux     winget
SuperTux         SuperTux.SuperTux               0.6.3   Tag: tux     winget
Tux Paint        NewBreedSoftware.TuxPaint       0.9.35               winget
SuperTuxKart     SuperTuxKart.SuperTuxKart       1.4                  winget
TuxGuitar        TuxGuitar.TuxGuitar             1.6.6                winget
```


# Aplicaciones | Instalar/Desinstalar/Reparar
Una vez tenemos identificado el `id` del programa que quermos instalar, pos simplemente lo instalamos, desintalamos o reparamos asi:
```batch
winget install ProgramaId
winget repair ProgramaId
winget uninstall ProgramaId
```
Para que sirve reparar?: Basicamente sirve para corregir una instalacion mala del paquete.

**Ejemplo**:
```batch
winget install SuperTux.SuperTux 
winget repair SuperTux.SuperTux 
winget uninstall SuperTux.SuperTux 
```


# Listar aplicaciones instaladas
Para mostrar lo instalado con winget (o los paquetes identificados con winget), ponemos lo siguiente:
```batch
winget list
```


# Hacer backup de aplicaciones
Dicho backup que haremos, no es un respaldo de las apps en si, sino un respaldo de todos los ID de los programas que identifique winget, ID's guardados en un `archivo.json`.

Simplemente usamos `export`, seguido de la ruta donde guardaremos el archivo de texto.
```batch
winget export "ruta\archivo.json"
```

**Ejemplo:**
```powershell
winget export "$Env:userprofile\Documents\winget-appbackup.json"
```

# Usar backup de aplicaciones
Ya para instalar las apps que respaldamos, en el `archivo.json`, pos nomas:
```powershell
winget import "ruta\archivo.json"
```

**Ejemplo**:
```powershell
winget import "$Env:userprofile\Documents\winget-appbackup.json"
```

---

Esta es la forma basica de usar winget, es realmente sencillo y chido. Tu backup de apps quedara chido, y listo para usarse en una nueva instalacion de windows.



# Actualizar aplicaciones
Por id:
```batch
winget upgrade --id ProgramaID
```

Actualizar todo:
```batch
winget upgrade --all
```
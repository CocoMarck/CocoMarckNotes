#    Estructura de carpetas para guardar programas personales    #
Utilizar kebab-case para nombrado de carpetas. Intentar respetar nombre de packages y asociados.

Solo binarios, nada de source code.

```
application-packages/
    0.configs-backups/
        # Configuraciones, backups.
        windows/
        gnu-linux/
        android/
    0.keys-and-firmware/ # <--- AQUÍ: Claves de acceso, licencias y BIOS de consola
    1.my-proyects/
        # Solo aplicaciones hechas por mi. Compilados, no code.
    2.without-order/
        # Packages/conf, sin ordenar.
    
    tools/
        0.plugins/ # Plugins para aplicaciones.
    
        cross-platform/ # Para multiples OS
    
        windows/ gnu-linux/ android/ # OS
            network/
                # Navegador, descargador
            multimedia/
                # Dibujo, 3d, Música
            developer/
                # Only code things
            system/
                # USB Boot tools, Hardware info, etc.
    
    games/ # Binarios para OS en especifico
        0.mods/ # Mods para videojuegos
    
        cross-platform/ # Para multiples OS
        
        windows/ gnu-linux/ android/ # OS
            emulators/
        
    roms/ # Programas para emuladores, o algo asi
        flash-player/ nintendo-64/
```

> `cross-plataform`, es un package listo pa jalar, para minimo dos os.

# Subdirectorios comunes, de dirs en tools.
Para mantener full coherencia.
- network: `browsers, email, chat`
- system: `statistics, interface`
- multimedia: `2d, 3d, music`

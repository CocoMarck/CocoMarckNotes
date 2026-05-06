[Información](https://adbshell.com/)

# ADB Shell
Shell del sistema operativo android.
```
ENTRAR:
    ( Las dos maneras son validas )
    adb_shell
    adb shell COMANDO_OPCIONAL

APPS/PAQUETES:

    INSTALAR:
        pm install --user 0 PAQUETE
        
        Packetes existentes:
        cmd package install-existing PAQUETE
    
    LISTAS:
      pm list packages

    FILTRAR:
      pm list packages | grep PAQUETE

    DESINSTALAR:
      pm uninstall -k --user 0 PAQUETE

    DESACTIVAR:
      pm disable-user PAQUETE
```
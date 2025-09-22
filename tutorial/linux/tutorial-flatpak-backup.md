[enlace](https://www.reddit.com/r/linux/comments/u3wcm7/easy_flatpak_apps_backupinstallation/)

# Flatpak backup
Se vera como hacer un backup de las apps instaladas en flatpak.

# Obtener las apps y ponerlas en un textiño.
```bash
flatpak list --columns=application --app > flatpak-app-backup.txt
```

## Ejemplo de lo que contendra `flatpak-app-backup.txt`
```
com.geeks3d.furmark
com.github.Xenoveritas.abuse
com.visualstudio.code
io.mrarm.mcpelauncher
net.supertuxkart.SuperTuxKart
org.luanti.luanti
org.telegram.desktop
rs.ruffle.Ruffle
```


# Instalar apps del textiño.
Primero checa las apps bonitas, con un echo.
```bash
xargs echo < flatpak-app-backup.txt
```

Instalalas así:
```bash
xargs flatpak install -y < flatpak-app-backup.txt
```
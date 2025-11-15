# Tutorial para instalar Waydroid en Debian 13

Primero que nada tenemos que tener claro que `waydroid` depende completamente de wayland, pero lo bueno es que aun puede jalar en `x11`, lo necesitaras es instalar `weston`, el cual ejecuta wayland, y pos adentro de weston puedes hacer jalar `waydroid` en `x11`.

Este tutorial jala para Debian 13. `2025-09-05`. Pero si usas un OS mes nuevete, pos la forma de instlar waydroid cambiara, visita el sitio web de waydroid. 

Visita [Documentos Waydroid](https://docs.waydro.id)


# Instlación 
En **debian 13** y derivados, tendremos que obtener certificados de uso:
```bash
sudo apt install curl ca-certificates -y
```

**Despues agregamos los repos, para waydroid:**
```bash
curl -s https://repo.waydro.id | sudo bash
```

**Ahora si podemos instalarlo:**
```bash
sudo apt install waydroid -y
```

# Iniciar servicios locos Waydroid

Si tenemos systemd, usamos:
```bash
sudo systemctl enable --now waydroid-container
```

Si no tenemos, usamos:
```bash
sudo waydroid container start
```

Y despues, en una nueva terminal. Sin sudo; usamos:
```bash
waydroid session start
```

Este comandete, deberia mostrar: `Android with user 0 is ready`, si te muestra eso, busca la app en el menu de apps, e iniciala.


# Servicios gugul
Por defecto `waydroid` ta sin servicios gugul. Para añadirlos tenemos que re-iniciarlo.

## De esta manera:

Paramos waydroid:
```bash
waydroid session stop
```

Barramos files locos:
```bash
sudo rm -rf /var/lib/waydroid /home/.waydroid ~/waydroid ~/.share/waydroid ~/.local/share/applications/*aydroid* ~/.local/share/waydroid
```

Intalamos con gapps
```bash
sudo waydroid init -s GAPPS
```

Iniciamos:
```bash
waydroid session start
```

----

Si lo quieres sin gugul apps, pos es lo mismo, pero el init seria así:
```bash
sudo waydroid init -s GAPPS
```


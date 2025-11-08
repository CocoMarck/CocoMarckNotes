# Cambiar fondo de GRUB
Esto deberia funcionar en todas las distros, pero este tutorial se hizo usando Debian 12.

# Preaparar fondo para GRUB
La imagen tiene que ser de un formato aceptable: `png, jpg`.

Primero necesimatos la imagen en la siguiente ruta `/usr/share/backgrounds/`. Alli mismo te recomiendo crear una subcarpeta algo asi: `/usr/share/backgrounds/mis-fondos-chidos`

Nos aseguramos de mover nuestras imagenes alli.

Algo asi:
```bash
sudo mkdir /usr/share/backgrounds/mis-fondos-chidos
sudo cp /ruta/fondo.png /usr/share/backgrounds/mis-fondos-chidos
```

Vemos los permisos de los archivos y que existan los archivos:
```bash
ls -la /usr/share/backgrounds/mis-fondos-chidos
```


# Editar configuración de GRUB
Tenemos que editar el archivo `/etc/default/grub`.

Vemos su texto:
```bash
cat /etc/default/grub
```

Editamos con cualquier editor de texto, pero como sudo.
```bash
sudo nano /etc/default/grub
```

Dentro del textillo, ponemos al final la siguiente linea `GRUB_BACKGROUND=/ruta/root/fondo`.
De esta menera:
```bash
# Fondo chido
GRUB_BACKGROUND="/usr/share/backgrounds/background-user/ai-chease3.png"
```

Alli le puse yo un comentario, recomiendo dejarlo para mas chides. Guardamos y listo, hemos configurado.




# Establecer cambios y verificar cambios
Con el siguiente comando actualizamos el grub, entre sus updates, esta el analisis al archivo de configuración que editamos:

```bash
sudo update-grub
```

Vemos el archivito, y nos aseguramos de que la liena que pusimos sigue existiendo:
```bash
cat /etc/default/grub
```

Si existe, esta todo clean.

Finalmente reinciamos y comprobamos que la imagen se ve chida.
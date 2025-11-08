# Samba y Debian 13

Se vera como utilizar samba de forma sencilla. Se dara acceso a una carpeta, la cual solo tendra permiso de lectura.

# Instalación
Primero tenemos que instalarlo, en debian es asi:
```bash
sudo apt install samba -y
```

# Obtener ip
Con el siguiente comando:
```bash
ip addr
```

Este nos devolvera la ip, en la linea `inet`, algo así:
``` 
...
    ...

    inet 0.0.0.0/....
```


# Creación de carpeta
Es importante tener la carpeta Public, bien aislada de nuestro `home`, así se obtiene mejor seguridad, la meteremos en `/srv/samba/public`. `/srv/samba/` es un buen estandar. 

```bash
sudo mkdir -p /srv/samba/public
```

Al estar en root `/`, necesitaremos permisos root.

## Dar permisos de necesarios `nobody:nogroup`
```bash
sudo chown -R nobody:nogroup /srv/samba/public
sudo chmod -R 755 /srv/samba/public
```

# Configurar samba
```bash
sudo nano /etc/samba/smb.conf
```

Añadimos estas lineas al final del archivo
```conf
[Public]
   comment = Carpeta pública de solo lectura
   path = /srv/samba/public
   browseable = yes
   guest ok = yes
   public = yes
   read only = yes
   writable = no
   force user = nobody
```

> El indentado, son cuatro espacios

Esto nos asegura acceso sin login. Solo lectura, y compatibilidad con Windows y Linux.


# Como acceder
Primero que nada necesitamos un gestor de archivos compatible con samba. El de win ya jala, pero el de Linux aveces no.

Accedemos a esta, en linux ponemos en la barra de direcciones esto:
```
smb://los-numeros-de-tu-ip/Public
```

Y en windows con un `Win + R`, y ejecutar esto:
```
//los-numeros-de-tu-ip/Public
```
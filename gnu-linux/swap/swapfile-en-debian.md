#    Swapfile en debian    #
[Tutorial](https://www.youtube.com/watch?v=YEgjz34U098)

Cuando te acabas la ram, el swap salva el pc de un bloqueo.


## Creación del archivo
(Todo lo que veremos se hara como super usuario, tomalo en cuenta)
Primero nos logeamos como root:

```bash
sudo su
```

Reservamos un espacio y especificamos los gigas del swap. Le ponemos un nombre y de preferencia uno estandar como "/swapfile".
```bash
fallocate -l 16GB /swapfile
```

Vemos que jalo fallocate
```
du -sh /swapfile
```




---
## Permisos al archivo
Vemos los permisos del swapfile
```bash
ls -l /swapfile
```



Ahora damos lectura y escritura para root al swapfile
```bash
chmod 600 /swapfile
```

Vemos que le haya dado los permisos `-rw------`
```bash
ls -l /swapfile
```

---
## Poner a jalar el swapfile
Exchelente, ahora hay que ese archivo sea el swap.

Establecemos el swap con:
```bash
mkswap /swapfile
```

Montamos el swap. Activamos el swap
```bash
swapon
```

Ahora vemos que jale con el `htop`, o el gestor de recursos que uses.


---
## Punto de montaje automatico
Necesitamos que se active solo, y para hacerlo, tenemos que

```bash
nano /etc/fstab
```

Creamos una nueva linea (sin remplazar alguna, o borrar una, ponla como la linea final si no quieras batallar. Esto tendra la linea:
```
/swapfile swap swap defaults 0 0
```

Guardamos cambios y listo. Reiniciamos pc, y verifiquemos que tenemos el swap.





---
## Cambiar/Remplazar swapfile existente
Desactivamos el swap:
```bash
sudo swapoff /swapfile
```

Establecemos nueva cantidad de gb
```bash
sudo fallocate -l 16G /swapfile
```

Los permisos:
```bash
sudo chmod 600 /swapfile
```

Formateamos como swap
```
sudo mkswap /swapfile
```

Activamos swap
```
sudo swapon /swapfile
```

Verificamos con:
```
free -h
```

No deberia hacer falta, pero nos aseguramos de que 
`cat /etc/fstab` tenga la linea: `/swapfile swap swap defaults 0 0`
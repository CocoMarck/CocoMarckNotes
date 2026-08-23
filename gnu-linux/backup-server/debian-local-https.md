# Local server http
Con esto podemos compartir archivos, podemos usar el navegador.



# Creamos una carpeta para dar acceso
Puede ser una carpeta ya personal tuya, pero de preferencia crea una para lo public.

```bash
mkdir -p ~/Público
chmod -R 755 ~/Público
```
> El sistema de archivos ext4 ta potente y aguanta caracteres locos.

# Levantar servidor en solo lectura
```bash
cd  ~/Público
python3 -m http.server 8080
```

Abrimos el navegador, y escribimos en la barra de busqueda:
```
http://IP_DE_TU_PC:8080
```

**Obtener ip** con el siguiente comando:
```bash
ip addr
```
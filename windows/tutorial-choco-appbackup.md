`Tutorial, funcional en 2025`

# Como hacer backup de programas instalados en choco.

```batch
choco list
```
Con esto obtenemos los paquetes instalados.

### Ejemplo de lista
~~~
chocolatey 2.4.3
chocolatey-compatibility.extension 1.0.0
chocolatey-core.extension 1.4.0
chocolatey-windowsupdate.extension 1.0.5
dotnet 9.0.6
dotnet-9.0-runtime 9.0.6
dotnet-runtime 9.0.6
KB2919355 1.0.20160915
KB2919442 1.0.20160915
KB2999226 1.0.20181019
KB3033929 1.0.5
KB3035131 1.0.3
lively 2.1.0.8
scrcpy 3.3.1
vcredist140 14.44.35208
winpaletter 1.0.93
~~~




# Guardar lista de paquetes instalados en un archivo de texto.
Con esto guardamos la lista en un archivo de texto bonito.
```batch
choco export packages.config
```
> Es muy importatne, establecer que el archivo sea un `.config`


# Instalar paquetes en base a un texto formateado con `choco list`.
Y finalmente con esto otro, obtenemos los paquetes formateados en el texto.
```batch
choco install packages.config
```
La lista que se guarda el textillo, es mas robotica. Contiene id, nombres, etc. Eso permite a install interpretar todo mas facil


> Si no le ponemos nombre al export, por defecto se llamara el archivito `packages.config` y se guardara desde la ruta donde se ejecuto el comando.





# Actualizar programas
Para actualizar un paquete en especifico:
```batch
choco upgrade nombre-de-paquete
```
Ejemplo:
```batch
choco upgrade supertux
```

Para actualizar todo:
```batch
choco upgrade all
```
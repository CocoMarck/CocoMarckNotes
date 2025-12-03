- [Referencia 1](https://es.linux-terminal.com/?p=3105)
- [Referencia 2](https://laboratoriolinux.es/index.php/-noticias-mundo-linux-/software/17509-que-significa-main-contrib-y-non-free-en-los-repositorios-de-debian.html)
- [Referencia 3](https://www.debian.org/mirror/list.es.html)
- [Referencia 4](https://www.debian.org/doc/debian-policy/ch-archive.html#s-dfsg)



# APT

El programa APT: Debian tiene sus servidores de paquetes. Y se les llaman repositorios para APT.

APT es una abraviación, y su nombre completo es: Advanced Packaging Tool.
Este es un programa que gestiona el uso del servidor de paquetes, los repos apt.

## Repositorios APT
Estos repositiorios no son más que directorios que contienen dos tipos de archivos:
- `Packages.gz` Esto contiene puros binarios instalables. Son los programas
- `Sources.gz`: Esto es el puro codigo sin compilar. Sirve para ver como jala el programa, pero necesita ser compilado para su uso normal.


## Secciones de repositorios APT en Debian:
- `main`: Contiene solamente los paquetes que cumplan los requisitos de la licencia del OS. Tiene la intención de almacenar programas para servir para el uso general del OS. Aca todas las dependencias para el funcionamiento de los programas estan cubiertas. Esta seccion de "main" no es dependiente de ninguna otra.

- `contrib`: Aca se almacenan paquetes suplementarios pensados para funcionar en Debian, requieren software fuera de la distribución (fuera de main) para compilar y/o funcionar. Estos programas deben de ser de uso libre, deben ser programas libres. Para eso deberan de cumplir con DFSG.

- `non free`: Contienen programas para funcionar en Debian, pero no son libres, no cumplen con DFSG. Programas como "fuentes de texto de microsoft", "winrrar", "drivers de nvidea", ese tipo de programas. Los linuxeros los usamos para instalar drivers. Los drivers son necesarios para que jale chido el pc.

- `sources`: Puro codigo sin compilar. Sirve para aprender, para cacharrear.

**DFSG**: The Debian Free Software Guidelines. Normas para que un paquete sea libre; Normas hechas Debian.


**Dependencia de programas:**

Los programas muchas veces necesitan del funcionamiento de otros programas. A eso se le llama dependencia de programa. Estos programas tienen funciones generales que se pueden usar otros programas. Los programas que funcionen con otros programas, son dependientes.

Ejemplo: Un `programaX`, depende para funcionar el `programaY` y el `programaZ`.
`programaY` y `programaZ`: son las dependencias del `programaX`.

> **Nota**: Por defecto, debian tiene como repos, a main, contrib, y sources.
Pero no tiene por defecto a "non-free". Ya que esta sección no es de uso libre, pero es bueno saber que existe. Nos serve para instalar programas y drivers que necesitemos.

**Conclusión**: Los repositorios de programas, almacenan programas. Los repositorios apt, almacenan programas. Los repositorios apt nos sirven para instalar programas de manera sencilla.
[Referencia](https://terminaldelinux.com/terminal/administracion/apt-sources/)


# Donde se configuran los repos apt
Se configura desde un archivo de configuración, el cual es un archivo de texto.

El archivo de configuración de los repositorios apt esta en la siguiente ruta: `/etc/apt/`

El archivo se llama: `sources.list`

Y la ruta completa, incluyendo el nombre del archivo seria: `/etc/apt/sources.list`


## ¿Para que me sirve configurar los repos apt?
Te sirve para agregar mas repos, incluso repos que no son de debian, pero igual jalan con apt.

Podrias agregar los repos non-free, para poder obtener drivers necesarios para el funcionamiento del pc. 

Eso es lo que generalmente se hace.
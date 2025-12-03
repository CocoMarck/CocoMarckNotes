[referencia](https://es.wikipedia.org/wiki/Init)



# ¿Que es un Init System?
Init (abreviatura de initialization) es el primer proceso en ejecución tras la carga del núcleo y el que a su vez genera todos los demás procesos.


**Init System Estilo BSD**: El init de BSD ejecuta el script de inicialización en /etc/rc, de forma parecida a como se hacía en el Unix original de Bell Labs. No hay niveles de ejecución (runlevels), el archivo /etc/rc determina qué programas se ejecutan por init. La ventaja de este sistema es que es simple y fácil de editar manualmente, aunque sujeto a errores. pues un simple error en ese script podría inutilizar el procedimiento de arranque del sistema. 


**Init System Estilo System V:** En GNU/Linux es el fichero encargado de establecer los runlevels disponibles, para que pueda ser leído por init. A continuación se muestra un ejemplo del inicio de este fichero, en el cual se establece el runlevel 5.

El **Init System**. Se encarga de cargar todos los servicios, cargar todos los procesos. Administrar todos los servicios del sistema operativo.
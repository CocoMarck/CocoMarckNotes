[Referencias](https://computernewage.com/2015/06/14/el-arbol-de-directorios-de-linux-al-detalle-que-contiene-cada-carpeta/)



# El Árbol de Directorios de Linux. 

**Conoce las Principales Carpetas**. La estructura de los directorios de Linux, así como su contenido y funciones, viene definida en el denominado Filesystem Hierarchy Standard o FHS por sus siglas en inglés, que en otras palabras viene a ser el estándar de jerarquía para los sistemas de archivos en sistemas Linux y otros derivados de UNIX.

Es decir que esta es una estructura que se una mucho en diferentes sistemas operativos. Es un estandar de como ordenas los archivos.


Todos los arboles tienen una raiz, y este arbol de directorios tiene uno, y es "/". Si una diagonal loca. 

*(Todos los textos que veas aqui, son los nombres de las carpetas). (Todo el texto de a la derecha del gato "#", representan comentarios)*

| Directorio | Función |
|--|--|
| `/` | Root/Raiz. Aca se guarda absolutamente todo. Todas las carpetas que se mencionan aca, estan adentro de esta |
| `bin` | Binarios de usuario |
| `boot` | Ejecutables y archivos requiridos para el aranque |
| `dev` | Archivos de información de todos los volúmenes |
| `etc` | Archivos de configuración del sistema y de aplicaciones |
| `home` | Directirio personal con las carpetas del usuario |
| `lib` | Biblotecas necesarias para la ejecución de binarios |
| `media` | Directorio de montaje de volúmenes extraibles |
| `opt` | Ficheros de aplicaciones externas que no se integran en `/usr` |
| `proc` | Ficheros de información e procesos |
| `root` | Directorio personal de superusuario |
| `sbin` | Binarios del sistema |
| `srv` | Archivos relativos en servidores web, FTP, etc. |
| `tmp` | Ficheros temporales |
| `usr` | Archivos de programas y aplicaciones instaladas |
| `var` | Archivos de variables, logs, emails de los usuarios del sistema, etc. |




Bueno, estas son todas las carpetas, todo el arbol de directorios en Linux. Debian usa este estandar.

Todos estos directorios son super necesarios. Pero nosotros como usuarios estaremos haciendo todas nuestras actividades en `/home`. 

Y pos tambien `/usr`, que es donde tenemos instaladas las apps. Ya las apps que usemos se encargaran de usar las carpetas que necesiten. 

Por ejemplo cualquier app que usemos, estara en `/usr`, y esta app usara la carpeta `/lib` para usar lo que necesite.
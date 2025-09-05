# Windows mejorado `2025`

Antes de hacer cualquier cambio, es recomendable hacer una copia de seguridad. Windows ta medio inestable y tiene problemas con cualquier cambiesillo.


# [WinScript](https://github.com/flick9000/winscript)
Esta es una aplicación de alto rendimiento, que permite configurar al cien el sistema operativo.

> WinScript es una herramienta de código abierto diseñada para ayudarte a crear scripts personalizados para Windows. Incluye funciones de desbloat, privacidad, rendimiento y más, además de la posibilidad de instalar todas tus aplicaciones favoritas con un solo clic. 

### Incluso se puede instalar con winget:
```batch
winget install --id=flick9000.WinScript -e
```




# [Winget](https://github.com/microsoft/winget-cli)
Este fue antes mencionado, sirve para instalar/desinstalar/actualizar programas de manera sencilla con winget. Todos los programas que se puedan instalar con winget, tambien se pueden desinstalar y actualizar. Muy verzatil y chido.

Winget viene preinstalado en windows. Por lo que es solo de usarlo en terminal, ejemplo de uso:
```batch
winget --help
```

El comando anterior, sirve para ver como funciona `winget`, ver que paremetros se le puede poner. Generalmente, lo que mas se usara sera `search`, `install`, y `uninstall`.

[Sitio web para buscar paquetes disponibles](https://winget.ragerworks.com/)

Recomendado usar winget para instalar todo, y lo que no puedas instalar en `winget`, checarlo en `chocolatey`.




# [PowerToys](https://github.com/microsoft/PowerToys)
Microsoft PowerToys es un conjunto de utilidades que permiten hacer tareas de manera mas rapida.  
Toys como: Launcher de apps, indicador de atajos de teclas, estractor de texto de imagenes, etc...

```batch
winget install --id=Microsoft.PowerToys -e
```




# [Cairo Desktop](https://cairoshell.com/)
Escritorio cambiado y modernizado. Mas rapido y eficiente.

> Cairo es un entorno de escritorio para Windows. Nuestro objetivo es desarrollar una experiencia de escritorio que aumente la productividad y mejore los estándares tecnológicos actuales.

### Instalación con winget
```batch
winget install Cairo.Cairo
```



# [AutoHotKey](https://www.autohotkey.com/)
Para crear atajos te tecla.

> AutoHotkey es una utilidad gratuita y de código abierto para la creación y automatización de macros que permite a los usuarios automatizar tareas repetitivas.

```batch
winget install AutoHotkey.AutoHotkey
```



# Chocolatey
Parecido a winget, pero mas estable y seguro, porque choco almacena los programas en un repo, winget es solo las instrucciónes para instalar un ejecutable que se baja del server oficial.

> Chocolatey es el gestor de paquetes para Windows. Fue diseñado como un marco descentralizado para instalar rápidamente las aplicaciones y herramientas que necesitas.

### Instalación:
```batch
winget install --id=Chocolatey.Chocolatey -e
```

[Sitio web para buscar paquetes disponibles](https://community.chocolatey.org/packages)



# Aplicaciones a destacar
### [Wu10Man](https://github.com/WereDev/Wu10Man)
Para desabilitar el windows update, esta aplicacion esta actualmente sin soporte. Pero es posible que en futuro siga su desarrollo bajo otro programador. Ya que el original, menciona que ya no quiere seguir con su desarrollo.

> Oficialmente dejaré de trabajar en él. La verdad es que no lo he mantenido durante más de un año, pero como a veces recibo alguna notificación al respecto, pensé en anunciarlo aquí. En resumen, la razón es un par de cosas. La respuesta sencilla es que he estado usando Linux cada vez más durante el último año y ahora lo uso prácticamente solo.

La mejor alternativa actual, seria el anteriormente mencionado `WinScript`.
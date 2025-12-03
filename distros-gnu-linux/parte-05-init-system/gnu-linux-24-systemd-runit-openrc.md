- [referencia 1](https://es.wikipedia.org/wiki/Runit_(init))
- [referencia 2](https://wiki.gentoo.org/wiki/OpenRC/es)
- [referencia 3](https://systemd.io/)


# Systemd, Runit, y OpenRC

En las distribuciones GNU/Linux, existen varios **init system**. Algunos de los mas famosos son: **Systemd, Runit, y OpenRC**.

## Runit
runit es un esquema de init y gestión de servicios para sistemas operativos tipo Unix que inicializa, supervisa y finaliza procesos en todo el sistema operativo.

## OpenRC
OpenRC es un sistema init basado en dependencias para sistemas Unix-like que mantiene la compatibilidad con el init system ya provisto por el sistema, que normalmente se encuentra en /sbin/init.

## Systemd
SystemD es el administrador de servicios y sistemas en Linux, y la estandarización de la mayoría de distribuciones de Debian y Red Hat. SystemD fue desarrollado con el objetivo de encargarse de arrancar todo lo que está por debajo del Kernel.

Systemd es un conjunto de bloques básicos de construcción para un sistema Linux. Proporciona un sistema y gestor de servicios que funciona como PID 1 y comienza el resto del sistema.

Otra de las funciones de systemd linux, es el de apoyar la restauración del sistema e implementar un sistema de gestión de dependencias fundamentado en un control lógico de los servicios.

**Systemd**, no solo es un init system, hace mas cosas. Y algunos programas dependen de este para funcionar. Es el que mas se usa, es el Init System que usa Debian. 

---
En Debian base, cuando esta iniciando el OS se ve un monton de texto, ese texto es enviado por el Init System, indica todos los procesas que se cargan. Tambien muestra su estado y esas cosas.
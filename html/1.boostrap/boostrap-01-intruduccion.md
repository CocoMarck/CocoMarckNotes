# Boostrap
> `2026-10-27`

#### ¿Que es boostrap?
Boostrap es un framework CSS de código abierto (con soporte a JavaScript) para crear sitios y apps web responsivas más rápidos y con un diseño consistente. Se basa en componentes predefinidos (como botones, menús y tarjetas) que se aplican usando clases HTML y se adaptan según el tamaño de la pantalla.

- Documentación de [boostrap](https://getbootstrap.com/docs/5.0/getting-started/introduction/).

Hacer pruebas rápidas con [OneCompiler boostrap](https://onecompiler.com/bootstrap). Te lo recomiendo bastante.

En conclusión, los creadores de boostrap son unos capos.

## Integración
#### CSS
Ponemos el `stylesheet <link>` en el `<head>`
```html
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
```
> Este es un ejemplo, depende la versión de boostrap puede cambiar el enlace.

#### JS
Muchos de los componentes requieren el uso de JavaScript para funcionar. Así que es buena idea agregar estos `<script>`, justo antes del cierre del `</body>:
```html
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
```

#### Plantilla
Asegúrate de que tus páginas estén configuradas con los estándares de diseño y desarrollo más recientes. Esto significa usar un `doctype HTML5` e incluir una etiqueta meta viewport para un comportamiento responsivo adecuado. En resumen, tus páginas deberían verse así:
```html
<!doctype html>
<html lang="en">
  <head>
    <!-- Meta tags requeridos -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <title>Hello, world!</title>
  </head>
  <body>
    <h1>Hello, world!</h1>

    <!-- Opcional JavaScript; ¡Elije uno de los dos! -->

    <!-- Opcional 1: Bootstrap Bundle con Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

    <!-- Opcional 2: Separados Popper y Bootstrap JS -->
    <!--
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
    -->
  </body>
</html>
```

Esto es todo lo que necesitas para los requisitos generales de la página.
# Donde poner el JavaScript

> [Tutorial](https://www.w3schools.com/js/js_whereto.asp)

La etiqueta `<script>`. En HTML, el código JavaScript se inserta entre `<script>` y `</script>`.

Ejemplo:
```html
<script>
    document.getElementById("demo").innerHTML = "Mi primer JavaScript";
</script>
```

#### Funciones y eventos de JavaScript
Un JavaScript `function` es un bloque de código JavaScript que se puede ejecutar cuando se "llama". Por ejemplo, se puede llamar a una función cuando ocurre un evento, como cuando el usuario hace clic en un botón.

#### JavaScript en `<head>` o `<body>`
Puedes colocar cualquier número de scripts en un documento HTML. Los scripts se pueden colocar en el body o en el head, o ambas.

#### JavaScript en `<head>`
En este ejemplo, una `function` `JavaScript` se coloca en el `<head>` sección de una página HTML.

```html
<!DOCTYPE html>
<html>
<head>
<script>
function myFunction() {
    document.getElementById("demo").innerHTML = "Párrafo cambiado";
}
</script>
</head>
<body>

<h2>Demo JavaScript es Head</h2>

<p id="demo">Un párrafo</p>
<button type="button" onclick="myFunction()">Inténtalo</button>

</body>
</html>
```
[Ver página](https://codeshack.io/html-viewer/#share=TZCxTgMxDIb3PIXJ1C49qWtzGaBFLSqiEmVgTJO0RFyc6OpDOiEehpHn6IvhcFcJL7al3__3J-pm-XS3f92t4I1io4W6Nm8ct7NtQyYtjh1aCgkh9vfjOJnCpwAul2wXPdLs5GnV-DLe9hs3kc7HJKezgOjb9f5xCzXI3eW7bc0xgTXxEIxLciG-hKquIFWN5ENyvRYcZK6X7AMP5sM8_4nAn2HNIpbOiyJDcPUA0y8IeSSoKhebjohjU599LYdFQkLbBPtey_-vkXqDdPlBMg3fDtJiXw1JmFZ-5hc)


#### JavaScript en `<body>`
En este ejemplo, una `function` JavaScript se coloca en el `<body>`. La función invoca (llama) cuando se hace clic en un botón:

Ejemplo:
```html
<!DOCTYPE html>
<html>
<body>

<h2>Demo JavaScript es Head</h2>

<p id="demo">Un párrafo</p>
<button type="button" onclick="myFunction()">Inténtalo</button>

<script>
function myFunction() {
    document.getElementById("demo").innerHTML = "Párrafo cambiado";
}
</script>

</body>
</html>
```
[Ver página](https://codeshack.io/html-viewer/#share=TVDBbsIwDL3nK7ycyoVKu5LmsNGpRZuGNHbYMSSBRWucqLiTKsTH7Mh38GOka5Hwxbb8_J6fxcPy_XnztS7hm3wjmZjSNphestQ-yqX1AVbqV33o1kUCe4DKKiPyNEuICM4U3CQQl58I8fLXtmoXRB4Hmo4oIFAfbcHHhkNA3Tj9U3Dfv3SoyQXMZlzWSJczkmrS7ggd6A__opLtJiTcL8GRQQoTdOct0nxvqWzsUD71tcnGq2Zzh2jbavP2CgXw9XQgaOW3TpnAF-zERH4TSuVoPhkcfnEF)

#### JavaScript externo
Los scripts también se pueden colocar en archivos externos:

Archivo externo `myScript.js`
```javascript
function myFunction() {
    document.getElementById("demo").innerHTML = "Párrafo cambiado";
}
```

Los scripts externos resultan prácticos cuando se utiliza el mismo código en muchas páginas web diferentes. Los archivos JavaScript tienen la extension de `archivo.js`.

Para usar un script externo, coloque el nombre del archivo de script en el atributo `src` (fuente) de la etiqueta `<script>`.

Ejemplo:
```html
<script src="myScript.js"></script>
```
> Los `scripts_externos.js` no pueden contener la etiqueta `script`.

---

## Ventajas de JavaScript externo
- Separa HTML y código.
- Hace que HTML y JavaScript sean más fáciles de leer y mantener.
- Los archivos JavaScript almacenados en caché pueden acelerar carga de las páginas.

Para agregar varios scripts en una página, utilice varias etiquetas de script:
```html
<script src="myScript1.js"></script>
<script src="myScript2.js"></script>
```

#### Referencias externas
Se puede hacer referencia a un script externo de tres maneras diferentes.
1. Con una URL completa (una dirección web completa).
2. Con una ruta de `archivo.js`.
3. Sin ningún camino.

Ejemplos:
```html
<!-- Dirección URL -->
<script src="https://www.w3.schools.com/js/myScript.js"></script>
<!-- Ruta de script -->
<script src="/js/myScript.js"></script>
<!-- Sin ningún camino -->
<script src="myScript.js"></script>
```

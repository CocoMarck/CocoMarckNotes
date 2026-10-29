# JavaScript Introducción
> Traducción de [w3schools](https://www.w3schools.com/js/js_intro.asp)

¿Que es `javascript`?: Es un lenguaje de programación interpretado y ligero que se usa principalmente para hacer páginas web interactivas. Se ejecuta en el navegador del usuario a partir del código que recibe y normalmente se integra en el `HTML` con la etiqueta `<script>` para modificar el contenido mediante `DOM`.

Te recomiendo probar los scripts en algún [html viewer web tool](https://codeshack.io/html-viewer/)

### JavaScript puede modificar el contenido HTML
Uno de los muchos métodos `HTML` de JavaScript es `getLementId()`.

El siguiente ejemplo "encuentra" un elemento HTML (con `id="demo"`), y cambia el contenido del elemenot (`innerHTML`) a `"Hola JavaScript"`.

Ejemplo:
```javascript
document.getElementId("demo").innerHTML = "Hola JavaScript";
```
> JavaScript acepta tanto comillas dobles como simples.


#### JavaScript puede cambiar los valores de los atributos HTML
En este ejemplo, JavaScript cambia el valor de la `innerHTML` atributo (texto) de un tag `<p>`:

```html
<!DOCTYPE html>
<html>
<body>
<h2>¿Que puede hacer JavaScript?</h2>

<p>JavaScript puede cambiar atributos de HTML</p>

<p> En este caso JavaScript cambia el valor de src (fuente) atributo de imagen.</p>

<button onclick="document.getElementById('foco').innerHTML='foco encendido'">Enciende el foco</button>

<p id="foco">foco apagado</p>

<button onclick="document.getElementById('foco').innerHTML='foco apagado'">Apaga el foco</button>

</body>
</html>
```
> Puedes probar esto en el navegador.

#### JavaScript puede modificar los estilos HTML (CSS)
Cambiar el estilo de un elemento HTML es una variante de cambiar un atributo HTML:
```javascript
document.getElementById("demo").style.fontSize = "35px";
```

#### JavaScript puede ocultar elementos HTML
Ocultar elementos HTML se puede hacer cambiando el `display` estilo:

Ejemplo:
```javascript
document.getElementById("demo").style.display = "none";
```

#### JavaScript puede mostrar elementos HTML
Mostrar elementos HTML ocultos también se puede hacer cambiando el `display` estilo:

Ejemplo:
```javascript
document.getElementById("demo").style.display = "block";
```
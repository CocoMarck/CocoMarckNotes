[tutorial](https://www.w3schools.com/html/html_basic.asp)




# Ejemplos basicos HTML
En ese capítulo mostraremos algunos ejemplos básicos de HTML
No te preocupes si usamos etiquetas que aún no conoces, despues las veremos.




# Documentos HTML
Todos los documentos HTML empiezan con: `<!DOCTYPE html>`

El documento HTML en sí comienza con `<html>` y termina con `</html>`

La parte visible del documento HTML está entre `<body>` y `</body>`

```html
<!DOCTYPE html>
<html>
<body>

<h1>Mi primer cabezera</h1>
<p>Mi primer parrafo</p>

</body>
</html>
```




# La declaración `<!DOCTYPE>`
Representa el tipo de documento y ayuda a los navegadores a mostrar las páginas web correctamente.

Sólo debe aparecer una vez, en la parte superior de la página (antes de caulquier etiqueta HTML).

No distingue entre mayúsculas y minúsculas.
La declaración para HTML5 es: `<!DOCTYPE html>`




# Encabezados HTML
Los encabezados HTML se definen con el `<h1>` a `<h6>` etiquetas.
`<h1>`define el encabezado más importante. `<h6>` define lo menos importante:

```html
<h1>Este es el heading 1</h1>
<h2>Este es el heading 2</h2>
<h3>Este es el heading 3</h3>
```




# Parrafos HTML
Los párrafos HTML se definen con la etqueta `<p>`
Ejemplo:
```html
<p>Este es un parrafo.</p>
<p>Este es otro parrafo.</p>
```




# Enlaces HTML
Los enlaces HTML se definen con la `<a>` etiqueta;
```html
<a href="https://sitio-web.com">Este es un link</a>
```

El destino de enlace se especifica en el href atributo.

Los atributos se utilizan para proporcionar información adicional sobre los elementos HTML.

Aprenderá más sobre los atributos en un capítulo posterior.




# Imágenes HTML
Las imágenes HTML se definen con el `<img>` etiqueta.

El archivo fuente (src), texto alternativo (alt), width, height se proporcionan como atributos:
```html
<img src="image" alt="imagen loca" width="104" height="142">
```




# Cómo ver el código fuente HTML
¿Alguna vez has visto una página web y te has preguntado: "Oye, ¿cómo hicieron eso?"

**Ver código fuente HTML:**

Presione `CTRL + U` en una página HTML o haga clic derecho en la página y seleccione "Ver código fuente". Se abrirá una nueva pestaña con el código fuente HTML de la página.

## Inspeccionar un elemento HTML:
Haz clic derecho en un elemento (o en un área vacía) y selecciona "Inspeccionar" para ver de qué están compuestos (verás tanto el HTML como el CSS). También puedes editar el HTML o el CSS sobre la marcha en el panel Elementos o Estilos que se abre.
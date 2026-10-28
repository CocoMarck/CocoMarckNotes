[Enlace](https://www.w3schools.com/html/html_comments.asp)

# HTML Comentarios
Los comentarios HTML no se muestran en el navegador, pero pueden ayudar a documentar el código fuente HTML.

# HTML comentarios etiquetas
Puede agergar comentarios a su fuente HTML, utilizando la siguiente sintaxis:
```html
<!-- Escribe los comentarios aca -->
```
Tenga en cuenta que hay un signo de exclamación (!) en la etiqueta de inicio, pero no en la etiqueta final.

**Nota:** Los comentarios no los muestra el navegador, pero pueden ayudar a documentar el código fuuente HTML.




# Añadir comentarios
Con los comentarios puedes colocar notificaciones y recordatorios en tu código HTML:

Ejemplo:
```html
<!--- Comentario -->
<p>Esto es un parrafo</p>
<!-- Escribe información aca -->
```

# Ocultar contenido
Los comentarios se pueden utilizar para ocultar contenido. Esto puedo ser útil si ocultas contenido temporalmente:

Ejemplo:
```html
<p>Esto es un parrafo</p>
<!-- <p>Parrafa cancelado</p> -->
```

También puedes ocultar más de una linea. Todo lo que está entre `<!--` y el `-->` se ocultará de la pantalla.

Ejemplo, ocultar una sección de código HTML:
```html
<p>Este es un parrafo</p>

<!-- 
<p>Este es otro parrafo</p>
<img border="0" src="mostrar.jpg" alt="hola">
-->

<p>Mas texto</p>
```

Los comentarios también son excelentes para depurar HTML, porque puedes Comete líneas de código HTML, una a la vez, para buscar errores.




# Ocultar contenido en línea
Los comentarios se pueden usar para ocultar partes en medio de código HTML.

Ejemplo:
```html
<p>Este es <!-- Buen texto -->un parrafo</p>
```
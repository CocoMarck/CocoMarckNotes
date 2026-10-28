[Enlace](https://www.w3schools.com/html/html_intro.asp)

# HTML Introducción

HTML es el lenguaje de mercado estándar para craer páginas web.

**¿Qué es HTML?**

- HTML significa: Hyper Text Markup Language.
- HTML es el lenguaje de mercado estándar para crear páginas web.
- HTML describe la estructura de una página web
- HTML consta de una seria de elementos
- Los elementos HTML le dicen el navegador cómo mostrar el contenido.
- Los elementos HTML etiquetan fragmentos de contenido como "este es un encabezado", "este es un párrafo", "este es un enlace", etc.



**Un documento HTML simple**
```html
<!DOCTYPE html>
<html>
<head>
<title>Titulo de pagina</title>
</head>
<body>

<h1>Mi primer cavezera/heading jejej</h1>
<p>Mi primer paradigma/paragraph</p>

</body>
</html>
```




**Ejemplo explicado:**
- `<!DOCTYPE html>`: La declaración define que este documento es un documento HTML5
- `<html>`: Es el elemento raíz de un HTML página.
- `<head>`: El elemento contiene metainformación sobre la página HTML
- `<title>`: El elemento especifica un título para la página HTML. Se muetra en la barra de título del navegador.
- `<body>`: Define el cuerpo del documento y es un contenedor para todos los contenidos visibles, como encavezados, parrafos, imágenes, hipervinculos, tablas, listas, etc.
- `<h1>`: El elemento define un encavezado grande.
- `<p>`: Elemento que define un parrafo




# ¿Qué es un elemento HTML?
Un elemento HTML se define mediante una etiqueta de inicio, algún contenido y una etiqueta de finalización:
`<etiqueta>El contenido</etiqueta>`

HTML el elemetno es todo, desde la etiqueta de incio hasta la etiqueta final:
```html
<h1>Mi Primer encabezaco</h1>
<p>Mi primer párrafo</p>
```

> Nota: Algunos elementos HTML no tienen contenido (como el `<br>`). Estos elementos se llaman elementos vacíos. ¡Los elementos vacíos no tienen etiqueta de cierre.




# Navegadores web
El propósito de un navegador web (Chrome, Edge, Firefox, Safari) es leer documentos HTML y mostrarlos correctamente.

Un navegador no muestra las etiquetas HTML, sino que las utiliza para determinar cómo mostrar el documento.



# Estructura de la página HTML
```html
<html>
    <head>
        <title>Título de la pagina</title>
    </head>
    <body>
        <h1>Este es un encabezado</h1>
        <p>Este es un párrafo</p>
        <p>Éste es otro párrafo</p>
    </body>
</html>
```

> Nota: El contenido dentro de la sección `<body>` se mostrará en un navegador. El contenido dentro del elemento `<title>` se mostrara en la barra de titulo del navegador o en la pestaña de la página.




# Historial de HTML
Desde los primeros días de la World Wide Web, han existido muchas versiones de HTML:
```
1989 	Tim Berners-Lee invented www
1991 	Tim Berners-Lee invented HTML
1993 	Dave Raggett drafted HTML+
1995 	HTML Working Group defined HTML 2.0
1997 	W3C Recommendation: HTML 3.2
1999 	W3C Recommendation: HTML 4.01
2000 	W3C Recommendation: XHTML 1.0
2008 	WHATWG HTML5 First Public Draft
2012 	WHATWG HTML5 Living Standard
2014 	HTML5
2016 	HTML 5.1
2017 	HTML5.1 2nd Edition
2017 	HTML5.2
```

Este tutorial sigue el último estandar del 2025, HTML5.
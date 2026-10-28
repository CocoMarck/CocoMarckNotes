[enlace](https://www.w3schools.com/html/html_elements.asp)

# HTML Elements
Un elemento HTML se define mediante una etiqueta de inicio, algún contenido y una etiqueta final

El elemento HTML es todo, desde la etiqueta de inicio hasta la etiqueta final:

```html
<etiqueta>El contenivo va aqui</etiqueta>
```

Algunos ejemplos de elementos de HTML:
```html
<h1>Mi primer cabezera</h1>
<p>Mi primer parrafo</p>
```


> Nota: Algunos elementos HTML no tienen contenido (como el elemento `<br>`). Estos elementos se denominan elementos vacíos. ¡Los elemenots vacíos no tienen etiqueta de cierre!




# Elementos HTML anidados
Los elementos HTML se pueden anidar (esto significa que los elementos pueden contener otros elementos).

Todos los documentos HTML constan de elementos HTML anidados.

El siguiente ejemplo contiene cuatro elementos HTML (`<html>, <body> <h1> y <p>`):

```html
<html>
    <body>
        <h1>Mi primer cabezera</h1>
        <p>Mi primer parrafo</p>
    </body>
</html>
```


# Ejemplo explicado:
El elemento `<html>` es el elemento raíz y define todo el documento HTML.

Tiene una etiqueta de inicio `<html>` y una etiqueta de finalización `</html>`.

Luego, dentro del elemento `<html>` hay un elemento `<body>`.

El elemento `<body>` define el cuerpo del documento.

Tiene una etiqueta de incio `<body>` y una etiqueta de finalización `</body>`.
Luego, dentro del elemento `<body>` hay otros dos elementos: `<h1>` y `<p>`:

```html
<h1>Mi primer cabezera</h1>
<p>Mi primer parrafo</p>
```


El `<h1>` elemento define un encabezado.
Tiene una etiqueta de inicio `<h1>` y una etiqueta final `</h1>`:
```html
<h1>Mi primer heading</h1>
```


El `<p>` elemento define un párrafo.
Tiene una etiqueta de inicio `<p>` y una etiqueta final `</p>`:
```html
<p>Mi primer parrafo</p>
```




# Nunca te saltes la etiqueta final
Algunos elementos HTML se mostrarán correctamente, incluso si olvida la etiqueta final:
```html
<html>
<body>

<p>This is a paragraph
<p>This is a paragraph

</body>
</html>
```

Sin embargo, ¡Nunca confies en esto! Si olvidas la etiqueta final, podrían producier resultados inesperados y errores.




# Elementos HTML vacíos
Los elementos HTML sin contenido se denominan elementos vacíos.
El `<br>` la etiqueta definie un salto de linea y es un elemento vacío sin etqiueta de cierre:
`<p>` Este es un `<br>` parrafo con un una linea de ruptura. `</p>`



# HTML no distingue entre mayúsculas y minúsculas
Las etiquetas HTML no distingen entre mayúsculas y minúsculas: `<P>` significa lo mismo que `<p>`.

El estándar HTML no requiere etiquetas en minúsculas, pero W3C recomienda minúsculas en HTML y exisge minúsculas para tipos de documentos más estrictos como XHTML.
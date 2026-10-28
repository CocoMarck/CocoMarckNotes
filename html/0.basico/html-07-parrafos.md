<https://www.w3schools.com/html/html_paragraphs.asp>

# HTML Parrafos  
Un párrafo siempre comienza en una nueva línea y, generalmente, es un bloque de texto.

## El elemento HTML `<p>` define un párrafo  
Un párrafo siempre comienza en una nueva línea y los navegadores agregan automáticamente un espacio en blanco (un margen) antes y después de un párrafo.  

**Ejemplo:**  
```html
<p>Este es un parrafo.</p>
<p>Este es otro parrafo.</p>
```




## Visualización HTML  
No puedes estar seguro de cómo se mostrará el HTML.  

Las pantallas grandes o pequeñas y las ventanas redimensionadas crearán resultados diferentes.  

Con HTML, no es posible caminar la visualización agregando espacios o líneas adicionales en el código HTML.  

El navegador eliminará automáticamente cualquier espacio y linea adicional cuando la página esté desplegado:

Ejemplo:  
```html
<p>
Este es una parrafo
contiene muchas lineas
en el codigo fuente,
pero el navegador
lo ignora.
</p>

<p>
Este es un parrafo con       espacios
que contiene   muchas    lineas
en el codigo   fuente,   tambien 
muchos espacios   locos, pero     el
navegador lo    ignora.
</p>
```




## Reglas horizontales HTML  
El `<hr>` la etiqueta define un salto temático en una página HTML, y suele usarse se muestra como una regla horizontal.

El `<hr>` el elemento se utiliza para separar el contenido (o definir un cambio) en un HTML página:  
```html
<h1>Este es un heading 1</h1>
<p>Esto es un poco de texto</p>
<hr>
<h2>Este es un heading 2</h2>
<p>Esto es algo de mas texto</p>
<hr>
```

El `<hr>` etiqueta es una etiqueta vacía, lo que significa que no tiene etiqueta final.




# Saltos de línea HTML
El HTML `<br>` elemento define un salto de línea. Usar `<br>` si desea un salto de línea (una nueva línea) sin comenzar un nuevo párrafo:  
```html
<p>Texto<br>Mas texto, ahora otro salto de linea<br>Listo.</p>
```
`<br>` Es una etiqueta vacía, lo que significa que no tiene etiqueta final.




# El problema del poema
Este poema se mostrará en una sola línea:  
**Ejemplo:**  
```html
<p>
    Las rosas son rojas.
    El aguacate es verde.
    Los pelos son muchos.
    La ventana esta cerrada.
</p>
```

## Solución: El elemento HTML `<pre>`
El texto dentro de `<pre>` se muestra en una fuente de ancho fijo (normalmente Courier), y conserva tanto los espacios como los saltos de línea:  

**Ejemplo:**
```html
<pre>
    Las rosas son rojas.
    El aguacate es verde.
    Los pelos son muchos.
    La ventana esta cerrada.
</pre>
```




# HTML tag referencia  
La referencia de etiqueta de W3Schools contiene ifnormación adicional sobre los elementos HTML y sus atributos.

| Tag | Description |
|--|--|
| `<p>` | Defines un pararrafo |
| `<hr>` | Defines un cambio en el contenido  |
| `<br>` | Insertar un solo salto de linea |
| `<pre>` | Definir texto preformateado (multiples lineas) |

*Para obtener una lista completa de todas las etiquetas HTML disponibles, visite nuestra [referencia de etiqueta](https://www.w3schools.com/tags/default.asp)*
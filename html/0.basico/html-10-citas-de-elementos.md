[Enlace de tutorial](https://www.w3schools.com/html/html_quotation_elements.asp)

En este capítulo repasaremos los elementos HTML `<blockquote>`, `<q>`, `<abbr>`, `<cite>` y `<bdo>`.

A continuación una cida del sitio web de WWF:
> Durante 60 años, WWF ha trabajado para ayudar a la personas y a la naturaleza a prosperear. Como organización líder mundual en conserbación, WWF trabaja en casi 100 paíeses.

# HTML `<blockquote>` para citas
El HTML `<blockquote>` elemento define una sección que se cita de otra fuente.
Los navegadores suelen tabular elementos `<blockquote>`
```html
<p>Texto</p>
<blockquote>
Texto tabulado
</blockquote>
```



# HTML `<q>` para citas cortas
El HTML `<q>` la etiqueta define una cita corta. Los navegadores normalmente insertan comillas alrededor de las citas.

Ejemplo:
```html
<p>Texto citado: <q>Citacion</q></p>
```




# HTML `<abbr>` para abreviaturas
El HTML `<abbr>` la etiqueta define una abreviatura o un acrónimo, como "HTML", "CSS", "Sr.", "Doctor", "Lo antes posible", "Cajero automático".

Marcar abreviaturas puede proporcionar información útil a los navegadores y traductores. Sistemas y motores de búsqueda.

**Consejo:** utilice el atributo de título global para mostrar la descripcción de la abraviatura/acrónimo al pasar el ratón sobre el elemento.

Ejemplo:
```html
<p>El <abbr title="Mundo realista potente">MRP</abbr> nunca existio</p>
```

Resultado:
<p>El <abbr title="Mundo realista potente">MRP</abbr> nunca existio</p>




# HTML `<address>` para información de contacto
El HTML `<address>` la etiqueta define la información de contacto del autor/propietario de un documento o un artículo.

La información de contacto puede ser dirección de correo electrónico, URL, dirección física, teléfono, número, cuenta de redes sociales, etc.

El texto en el `<address>` generalmente se muestra en cursiva. Y los navegadores lo harán siempre agregando un salto de línea antes y despues del `<address>`.

Ejemplo:
```html
<address>
Escrito por alguien.<br>
Visita el sitio web.<br>
Hasta la proxima.<br>
Paíes realista.
</address>
```


# HTML `<cite>` para el título de la obra
El HTML `<cite>` la etiqueta define el título de una obra creativa (por ejemplo, un libro, un poema, una canción, una película, una pintura, una estructura, etc).

**Nota**: El nombre de una persona no es el tíulo de una obra.

El texto en el `<cite>` el elemento normalmente se representa una cursiva.

# Ejemplo:
```html
<p><cite>El grito</cite> de Endvard Munch. Pintado en 1893.</p>
```



# HTML `<bdo>` para anulación bidireccional
BDO significa Anulación Bidireccional. El HTML `<bdo>` la etiqueta se utiliza para anular la dirección del texto actual:

Ejemplo:
```html
<bdo dir="rtl">Este es un texto escritor de derecha a izquierda.</bdo>
```



# Elementos de Quatotion y Citation HTML
| Tag | Descripcción |
|--|--|
| `<abbr>` | Define una abreviatura o acrónimo |
| `<address>` | Define la información de contacto del autor/propietario de un documento |
| `<bdo>` | Define la dirección del texto |
| `<blockquote>` | Define una sección que se cita de otra fuente. |
| `<cite>` | Define el título de una otra |
| `<q>` | Define una cita corta en línea |
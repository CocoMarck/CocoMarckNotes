<https://www.w3schools.com/html/html_attributes.asp>

# HTML Atributos
Los atributos HTML proporcionan información adicional sobre los elementos HTML.

**Atributos HTML**

- Todos los elementos HTML pueden tener atributos.
- Atributos proporcionan información adicional sobre los elementos.
- Los atributos siempre se especifican en la etiqueta de inicio.
- Los atributos suelen venir en partes de nombre/valor como: nombre="valor".




## El href atributo
El `<a>` la etiqueta defina un hipervínculo. El href atributo especifica la URL de la página el enlace va a:
`<a href="https://www.w3schools.com">Visitar W3School</a>`

Usted aprenderá más sobre los encales en nuestros enlaces HTML capítulo.




## El atributo src
El `<img>` tag se utiliza para incrustar una imagen en una página HTML. El src atributo especifica la ruta a la imagen a mostrar: `<img src="img_pc.jpg">`


**Hay dos maneras de especificar la URL en el src atributo:**

1. URL absoluta - Enlaces a una imagen externa que se aloja en otro sitio web. Ejemplo: `src="https://www.w3schools.com/images/img.jpg"`.  
*Notas: Las imágines externas podrías estar bajo copyright. Si lo haces no obtener permiso para usarlo, puede estar en violación de las leyes de derechos de autor. En adición, no puede controlar imágenes externas; de repente se puede quietir o ha cambiado.*


2. URL relativa - Enlaces a una imagen que se aloje dentro el sitio web. Aquí, la URL no incluye el nombre dominio. Si la URL comienza sin una barra, será relativo a la página actual. Ejemplo: `src="img.jpg"`. Si la URL comienza con una barra, será relativa al dominio. Ejemplo: `src="/images/img.jpg"`.  
*Consejo: Casi siempre es mejor usar URLs relativas. Ellos no se romperá si cambia el dominio.*




## La anchura y alura de atributos
El `<img>` la etiqueta también debe contener width y height atributos, que especifican el ancho y altura de la imagen (en píxeles):

**Ejemplo:**  
```html
<img src="img.jpg" width="500" height="600">
```




## El alt Atribute
Los necesarios atributo alt para el `<img>` tag especifica un texto alternativo para una imagen, si la imagen por alguna razón no se puede mostrar. Esto puede deberse a una conexión lenta, o un error en el src atributo, o si el usuario utiliza una pantalla Lector.

**Ejemplo:**  
```html
<img scr="img.jpg" alt="Una imagen">
```




## El atributo de estilo
El atributo Style se utiliza para agregar estilos a un elemento, como color, fuente, tamaño y más.
```html
<p style="color:red;">Este es un parrafo rojo.</p>
```

**Aprenderá más sobre los estilos en nuestro capítulo Estilos HTML.**




## El atributo lang
Siempre debes incluir el lang atribut dentro de la <html etiqueta, para declarar la idioma de la página web. Eso se tiene como objetiv facilitgar la navegación en buscadores y navegadores.

El siguiente ejemplo especifica el Español como idioma:
```html
<html lang="es">
<body>
    ...
</body>
</html>
```


Los códigos de país tambien se pueden agregar a lcódigo de idioma en el lang atributo. Por lo tanto, los dos primeros caracteres definen el idioma de la página HTML, y los dos últimos caracteres definene el país.
El siguiente ejemplo especifica inglés como español como idioma y México como el país.
```html
<html lang="es-MX">
<body>
...
</body>
</html>
```




## El título atributo
El title el atributo define algunos extras información sobre un elemento. El valor del atriuto de título se mostrará como información sobre herramientas cuando pases el ratón sobre el elemento:

**Ejemplo:**
```html
<p title="Información adicional">Este es un parrafo</p>
```


**Segerimos: Utilice siempre atributos en minúsculas**  
*El estándar HTML no requiere nombres de atributos en minúsculas.*  
*El atributo títle (y todos los demás atributos) se pueden escribir con mayúsculas y minúsculas. Como titulo o TITLE.*

*Sin embargo, el W3C recomienda atributos en minúscula en HTML y exige atributos en minúscula para tipos de documentos más estrictos como XHTML*

**Suegerimos: Siempre los valores de los atributos**  
*El estándar HTML no requiere comillas alrededor de los valores de los atributos.*  
*Sin embargo, el W3C recomienda usar comillas en HTML y exige comillas para tipos de documentos más estrictuos com XHTML.*

**Bien**:  
```html
<a href="https://www.example.com/">Vista un sitio web</a>
```

**Mal**:  
```html
<a href=https://www.example.com/>Vista un sitio web</a>
```

A veces es necesario usar comillas. Este ejemplo no mostrará correctamente el atributo de titulo porque continue un espacio:  
```html
<p title=Descripcción mal puesta>
```



## ¿Comillas simples o dobles?
Las comillas dobles alrededor de los valores de los atributos son las más comunes en HTML, pero las comillas simples... También se puden utilizar comillas.

En algunas situaciones, como el valor del atributo en sí contiene comillas dobles, es necesario utilizar comillas simples:
```html
<p title='Pero que te pasa "inserte nombre de personaje", ¿estas bien?'>
```

O viceversa:
```html
<p title="Pero que te pasa 'inserte nombre de personaje', ¿estas bien?">
```




## Resumen del capitulo
- Todos los elementos HTML pueden tener atributos
- El `href` atributo `<a>` especifica la URL de la página a la que va el enlace.
- El src atributo de `<img>` especifica la ruta a la imagen que se mostrará.
- El `width` y `height` atributos de `<img>` proporcionan información sobre el tamaño de las imágenes.
- El `alt` atributo de `<img>` proporciona un texto alternativo para una image.
- El `style` el atributo del `<html>` la etiqueta declara el idioma de la página web.
- El `lang` atributo del `<html>` la etiqueta declara el idioma de la página web.
- El `title` el atributo define algunos extras información sobre un elemento.
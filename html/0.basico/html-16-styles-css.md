[Enlace de tutorial](https://www.w3schools.com/html/html_css.asp)

# HTML Styles - CSS

CSS significa hojas de estilo en cascada. CSS ahora mucho tiempo. Permite controlar diseño de múltiples páginas web todas a la vez.


# ¿Qué es CSS?
Los hojas de estilo de cascada (CSS) se utilizan para dar formato al diseño de una página web.

Con CSS, puedes controlar el color, la fuente, el tamaño del texto y el espaciado. Entre elementos, como se posicionan y disponen los elementos, qué fondo se deben utilizar imágnes o colores de fondo, pantallas diferentes para dispositivos diferentes ¡y tamaños de pantalla, y mucho más!

> **Consejo**: La palabra en **cascada** significa que un estilo aplicado a un elemento padre también se aplicará a todos los elementos secundarios dentro del mismo padre. Por lo tanto, si configura el color del cuerpo del texto en "azul", todos los encabezados, los párrafos y otros elementos de texto dentro del cuerpo también el mismo color (a menos que usted especifique otra cosa).



# Usando CSS
Se pueden añadir CSS a documento HTML de tres maneras:
- En la línea: Mediante el uso de la `style` atributo dentro de elementos HTML.
- Interno: Mediante el uso de un `<style>` elemento en el `<head>` sección.
- Exerno: Mediante el uso de un `<link>` elemento para vincular a un archivo CSS externo.

La forma más común de agragar CSS es mantener los estilos en CSS externo. Archivos. Sin embargo, en este tutorial usaremos estilos internos y en línea, porque es más fácil de demuéstrelo y será más fácil para usted probarlo usted mismo.




# CSS en línea
Se utilizara un CSS en línea para aplicar unn estilo único a un solo elemento HTML.

Un CSS en línea utiliza el atributo de estilo de un elemento HTML.

El siguiente ejemplo establece el color del texto del elemento `<h1>` en azul y el color del texto del elemento `<p>` en rojo:
```html
<h1 style="color:blue;">Un encabezado azul</h1>

<p style="color:red;">Un párrafo rojo</p>
```




# CSS interno
Se utiliza un CSS interno para definir un estilo para una sola página HTML. 

Un CSS interno se define en el `<head>` sección de una página HTML, dentro de un `<style>` elemento.

El siguiente ejemplo establece el color del texto de TODOS los `<h1>` elementos (en esta página) al azul, y el color del texto de todos los `<p>` elementos a Rojo. Además, la página se mostrará con un fondo azul pálido color:
```html
<!DOCTYPE html>
<html>
 <head>
  <style>
   body {background-color: powderblue;}
   h1   {color: blue;}
   p    {color: red;}
  </style> 
 </head>
 
 <body>
  <h1>Este es una cabezera</h1>
  <p>Esto es un parrafo.</p>
 </body>

</html>
```




# CSS externo
Se utiliza una hoja de estilo externa para definir el estilo de muchas páginas HTML:

Ejemplo:
```html
<!DOCTYPE html>
<html>
 <head>
  <link rel="stylesheet" href="styles.css">
 </head>
 <body>

  <h1>Esto es un heading</h1>
  <p>Esto es un parrafo</p>

 </body>

</html>
```

La hoja de estilo externa se puede escribir en cualquier editor de texto. El archivo no debe contener código HTML y debe guardarse con la extensión css.

Así es como se ve el archivo `styles.css`:
```css
body {
    background-color: powderblue;
} 
h1 {
    color: blue;
}
p {
    color: red;
}
```

> **Consejo:** Con una hoja de estilo extenra, puedes cambiar el aspecto de un sitio web completo, ¡modificando un archivo!




# Colores, fuentes y tamaños CSS
Aquí, demostraremos algunas propiedades CSS de uso común, aprenderá más sobre ellos más adelante.

El CSS `color` la propiedad define el color del texto que se utilizara.

EL CSS `font-family` define la fuente que se utilizará.

El CSS `font-size` define el tamaño de la fuente que se usara.

**Ejemplo**. Uso de las propiedades CSS de color, `font-family` y `font-size`:
```html
<!DOCTYPE html>
<html>
 <head>
  <style>
   h1 {
    color: blue;
    font-family: verdana;
    font-size: 300%;
   }
   p {
    color: red;
    font-family: courier;
    font-size: 160%;
   }
  </style>
 </head>
 
 <body>
  <h1>Esto es un titulo</h1>
  <p>Esto es un parrafo</p>
 </body>

</html>
```



# Borde CSS
El CSS `border` la propiedaad define un borde alrededor de un elemento HTML.

**Consejo:** puedes definir un borde para casi todos los elementos HTML.
```css
p {
    border: 2px solid powderblue;
}
```



# CSS Relleno
El CSS `padding` la propiedad define un relleno (espacio) entre el texto y el borde.

**Ejemplo:**
```css
p {
    border: 2px solid powderblue;
    padding: 30px;
}
```

# CSS Margin

La propiedad de `margin` CSS define un margen (espacio) fuera del borde.

**Ejemplo**
```css
p {
    border: 2px solid powderblue;
    margin: 50px
}
```


# Enlace a CSS externo
Se puede hacer referencia a las hojas de estilo externas con una URL completa con una ruta relativa a la página web actual.

**Ejemplo**. Este ejemplo utiliza una URL completa para vincular a una hoja de estilo:
```html
<link rel="stylesheet" href="https://www.w3schools.com/html/styles.css">
```

**Ejemplo**. Este ejemplo enlaz a una hoja de estilo ubicada en la carpeta html en el sitio web actual:
```html
<link rel="stylesheet" href="/html/styles.css">
```

**Ejemplo**. Este ejemplo enlaza a una hoja de estilo ubicada en la misma carpeta que la página actual:
```html
<link rel="stylesheet" href="styles.css">
```

> Puede leer más sobre las rutas de archivo en el capítulo [HTML rutas de archivo](https://www.w3schools.com/html/html_filepaths.asp)


# Resumen del capítulo
- Utilizar el atributo HTML `style` para el estilo en línea.
- Utilizar el elemento HTML `<style` para definir CSS interno.
- Utilizar el elemento HTML `<link>` para hacer referencia en un archivo CSS externo.
- Utilizar la propiedad CSS `color` para colores de texto.
- Utilizar la propiedad CSS `font-family` para fuentes de texto.
- Utilizar la propiedad CSS `font-size` para tamaños de texto.
- Utilizar la propiedad CSS `border` para fronteras.
- Utilizar la propiedad CSS `padding` para el espacio dentro de la frontera.
- Utilizar la propiedad CSS `margin` para espacio fuera de la frontera.

> **Consejo**: puedes aprender mucho más sobre CSS en nuestro [Tutorial de CSS][tuto-css]

[tuto-css]: https://www.w3schools.com/css/default.asp


# Etiquetas de estilo HTML
| Tag | Description |
|--|--|
| `<style>` | Define información de estilo para un documento HTML |
| `<link>` | Define un vinculo entre un documento y un recurso externo |

Para obtener una lista completa de todas las etiquetas HTML disponibles, visita nuestra [Referencia de etiquetas HTML][tags-ref-html]

[tags-ref-html]: https://www.w3schools.com/tags/default.asp
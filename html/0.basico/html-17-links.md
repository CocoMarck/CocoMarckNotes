[Tutorial](https://www.w3schools.com/html/html_links.asp)

# HTML Links

Los enlaces se encuentran en casi todas las páginas web. Los enlaces permiten a los usuarios navegar de una página a otra haciendo clic en ellos.

# Enlaces HTML - Hipervínculos
Los enlaces HTML son hipervínculos. Puedes hacer clic en un enlace y saltar a otro documento. Al moverl el ratón sobre un enlace, la flecha de ratón se convertira en una pequeña mano.

**Nota:** Un enlace no tiene por qué ser texto. Un enlace puede ser una imagen. ¡o cualquier otro elemento HTML!

# Enlaces HTML - SIntaxios

El HTML `<a>` etiqueta define un hiper vínculo. tiene la siguiente sintaxis:
```html
<a href="url">enlace</a>
```

El atributo más importante de `<a>` es el atributo `href., que indica el destino del enlace.

El texto del enlace es la parte que será visible para el lector.

Al hacer clic en el texto del enlace, el lector será redirigido a la dirección URL especificada.

## Ejemplo
Este ejemplo muestra cómo crear un enlace a W3Schools.com:
```html
<a href="https://www.w3schools.com/">¡Visita W3Schools.com!</a>
```

# URL absolutas frente a URL relativas
Ambos ejemplos anteriores utilizan una URL absoluta (una dirección web completa). En el `href` atributo.

Un enlace local (un enlace a una página dentro del mismo sitio web) se especifica un URL relativa (sin la parte `https://www`).

**Ejemplo**
```html
<h2>URL Absulutas</h2>
<p><a href="https://www.w3.org/">W3C</a></p>

<h2>URL relativas</h2>
<p><a href="/css/default.asp">CSS Tutorial</a></p>
```

# Enlaces HTML: usar una imagen como enlace
Para usar una imagen como enlace, simplemente coloque el `<img>` dentro de `<a>`.

Ejemplo:
```html
<a href="default.asp">
 <img src="smiley.gif" alt="HTML tutorial" style="width:42px;height:42px;">
</a>
```

# Enlace a una dirección de correo electrónico
Usar `mailto:` dentro del atributo `href` para crear un enlace que abra el programa de correo electrónico del usuario (a que envíen un nuevo correo electrónico):
```html
<a href="mailto:someone@example.com">Enviar email</a>
```

# Botón como enlace
Para utilizar un botón HTML como enlace, debes agregar algo de código JavaScript. Permite especificar qué sucede en determinados eventos, como por ejemplo al hacer clic en un botón:

```html
<button onclick="document.location='default.asp'">HTML tutorial</button>
```

> Consejo: Aprendde más sobre JavaScript en nuestro tutorial de JavaScript.




# Titulos de enlaces
El `title` el atributo especifica información adicional sobre un elemento. La información se muestra con mayor frecuencia como un texto emergente cuando el ratón se mueve sobre el elemento.

Ejemplo
```html
<a href="https://www.w3schools.com/html/" title="Vamos a W3Schools">Visita nuestro sitio web</a>
```




# Más información sobre URL absolutas y URL relativas
Utilice una URL completa para vincuular a una página web:
```html
<a href="https://www.w3schools.com/html.default.asp">HTML tutorial</a>
```

Enlace a una página ubicada en la carpeta html del sitio web actual:
```html
<a href="/html/default.asp">HTML tutorial</a>
```

Enlace a una página ubicada en la misma carpeta que la página actual:
```html
<a href="default.asp">HTML tutorial</a>
```



# Resumen de capítulo
# Boostrap navbar cards carousel
Aprenderemos de manera básica, dos componente de boostrap que se usan mucho. Este framework viene con un montón, pero este ejemplo te servirá para no tenerle miedo a la documentación, y usar cosas nuevas.

Si por alguna razón la documentación de boostrap dice: *te recomendamos ya no usar cards, usa ahora `x`*, hazles caso; algo sabrán los creadores de boostrap sobre boostrap.

## Ejemplo de sitio web boostrap
Bueno, ya tu sabe, primero usamos la plantilla de html oficial de boostrap.

### Navbar
Buscamos en la documentación de boostrap navbar, y copiamos y pegamos el ejemplo que nos guste, ejemplo:
```html
<nav class="navbar navbar-expand-md navbar-light bg-light">
    <a class="navbar-brand" href="#">Barra</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>
    
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav mr-auto">
        
        <li class="nav-item active">
            <a class="nav-link" href="#">Casa <span class="sr-only">(current)</span></a>
        </li>
        
        <li class="nav-item">
            <a class="nav-link" href="#">Link a algo</a>
        </li>
        
        <li class="nav-item dropdown">
            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            Desplegar
            </a>
            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
            <a class="dropdown-item" href="#">Accion </a>
            <a class="dropdown-item" href="#">Otra accion</a>
            <div class="dropdown-divider"></div>
            <a class="dropdown-item" href="#">Algo mas aca</a>
            </div>
        </li>
        
        <li class="nav-item">
            <a class="nav-link disabled" href="#">Desabilitado</a>
        </li>
        </ul>
        
        <form class="form-inline my-2 my-lg-0">
        <input class="form-control mr-sm-2" type="search" placeholder="Buscar" aria-label="Search">
        <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Buscar</button>
        </form>
    </div>
</nav>
```

> Así es como mucha gente trabaja, copy paste de ejemplos, y trabajar con ello. No tengas pena de hacerlo. Es legit.
- Su menu realmente es lo que esta en la etiqueta `<ul>` que es una lista.
- Lo de las etiquetas `<nav>`, `<button>`, es para que funcione la barra.

> Para utilizar todas las funciones de la barra y otros elementos de boostrap, es necesario agregar las funcionalidades `javascript` de boostrap. (vienen en la plantilla, así que no debería haber pedo).

Esta barra asi como esta puesta, solo va a mostrar todo lo de la barra en pantallas grandes. Y puede que queramos que muestre todas las opciones en pantallas mas pequeñas, como en tabletas.

Para eso tenemos que poner en el `<nav>` en vez de `navbar-expand-lg`, poner `navbar-expand-md`.

Esta barra por defecto muestra los datos con un margen especifico, pero puede que nosotros queramos mostrarlos con otro margen, pues simplemente en donde esta la lista `<ul>`, cambiamos al item de lista. `<li>` con clase `"nav-item"` le ponemos el margen, como por ejemplo un margen de 5 en la izquierda
```html
<ul>
  <li class='nav-item active ml-5'>
</ul>
```

Ponerlo en vez de `5` a `auto`, lo pondrá a la izquierda.\

---

### Carousel
Después seguido de la barra se hará un carrusel/carousel, que seria unas imágenes que se cambian cada x tiempo.

Vamos a hacer un carrusel, para esto buscamos en la documentación un ejemplo de `carousel` con control (sin control las imágenes se deslizan automáticamente, no por el usuario) y lo pegamos en nuestro código. Por defecto no tiene imágenes establecidas, por lo que nosotros las añadiremos.

Algo asi seria:
```html
<div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img class="d-block w-100" src=".../800x400?auto=yes&bg=777&fg=555&text=First slide" alt="First slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src=".../800x400?auto=yes&bg=666&fg=444&text=Second slide" alt="Second slide">
    </div>
    <div class="carousel-item">
      <img class="d-block w-100" src=".../800x400?auto=yes&bg=555&fg=333&text=Third slide" alt="Third slide">
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
```

Asi como esta esto se mostrara de una forma poco eficiente, ya que ocupara toda la pantalla. Para cambiar esto tendremos que utilizar una hoja de estilos `CSS`.

Vemos que todas las imágenes están contenidas en un `<div>` de clase `carousel-item`, esto permitirá cambiar algunos atributos del funcionamiento de estas clases mediante el uso de CSS.

Pero por probar solo pondremos el style en las clases `carousel-item`, de esta manera:
```html
<div class='carousel-item active' style="max-height: 512px;">
```

Esto hará que la imagen ocupe un espacio máximo de altura de 512 pixeles.

---

### Containers para cards
Ahora lo que sige del slider, normalmente le siguen unas tarjetas de contenido.

Es muy sencillo. Primero ponemos un `div` con la clase `container fluid` con color de fondo `light` (mira colors en la documentación de boostrap) con un `padding` vertical de cinco. Adentro de esta clase pondremos una fila, con columnas, donde las columnas serian las tarjetas de contenido, y para centrar todo a la clase `container-fluid` le ponemos un `text-center`.
```html
<div class="container-fluid bg-light py-5 text-center">
  <div class="row">
    <div class="col">1</div>
    <div class="col">2</div>
    <div class="col">3</div>
    <div class="col">4</div>
    <div class="col">5</div>
    <div class="col">6</div>
 </div>
</div>
```

Aquí tenemos números en lugar de imágenes, pero es solo cambiar los números por imágenes. También es bueno hacer hacerlo responsivo, es decir; que dependiendo la pantalla se vera de una o otra manera el `padding`. Cabe resaltar que **solo se pueden poner 12 columnas**.

Ahora vamos a acomodar de una u otra manera estas columnas, dependiendo del tamaño de la pantalla.

Para esto utilizaremos los anteriormente vistos `breakpoints`, haremos que para pantallas peques se vean dos columnas, para pantallas medianas se vean cuatro y para pantallas grandes se vean tres. De esta manera:
```html
<div class="container-fluid bg-light py-5 text-center">
    <div class="row">
        <div class="col-sm-6 col-md-4 col-lg-2">1</div>
        <div class="col-sm-6 col-md-4 col-lg-2">2</div>
        <div class="col-sm-6 col-md-4 col-lg-2">3</div>
        <div class="col-sm-6 col-md-4 col-lg-2">4</div>
        <div class="col-sm-6 col-md-4 col-lg-2">5</div>
        <div class="col-sm-6 col-md-4 col-lg-2">6</div>
    </div>
</div>
```
> Esto puede parecer confuso, pero con el tiempo de uso sera fácil de comprender.

Ejemplo de un about/acerca de:
```html
<div class='container'>
    <h2 class='text-center'>ACERCA DE</h2>
    <div class='row'>
        <div class='col-6'>Mañana es un dia mas, hoy sera el ayer. Todos los dias sucede algo nuevo, aunque sea sutil y poco perceptible</div>
        <div class='col-6'>Mañana es un dia mas, hoy sera el ayer. Todos los dias sucede algo nuevo, aunque sea sutil y poco perceptible</div>
    </div>
</div>
```
> Si quieres poner botones, entrada de datos o lo que sea, ve a la documentación `boostrap` y busca lo que necesites implementar.

---

### Cards
Ahora siguen las tarjetas. Se hacen de la siguiente manera, buscamos en la documentación de `boostrap` `card`. Buscamos un ejemplo de una tarjeta con imagen y texto. Pondríamos esto en una columna dentro de una fila del container:
```html
<div class="card" style="width: 18rem;">
  <img class="card-img-top" src="./resources/icons/cuadradoFeliz.png" alt="Imagen para tarjeta">
  <div class="card-body">
    <p class="card-text">Texto que describe de forma rapida la tarjeta.</p>
  </div>
</div>
```

Si especificamos en `boostrap` un tamaño especifico a la columna, podemos cambiar el tamaño de los widgets, de esta manera.
```html
<div class='col-sm-2 col-md-2'></div>
```

También podemos ocultar un contenedor de esta manera, solo se mostrara en pantallas medianas o mas grandes:
```html
<div class='container d-none d-md-block'></div>
```

#### También tenemos tarjetas horizontales:
Estas tienen la diferencia de tener el texto en un lado, y no abajo o arriba.
```html
<div class="card mb-3" style="max-width: 540px;">
    <div class="row no-gutters">
    <div class="col-md-4">
        <img class="card-img" src="./ruta/imagen.png" alt="Imagen para tarjeta">
    </div>
    <div class="col-md-8">
        <div class="card-body">
        <h5 class="card-title">Titulo de tarjeta</h5>
        <p class="card-text">Texto de tarjeta</p>
        <p class="card-text"><small class="text-muted">Texto secundario, info.</small></p>
        </div>
    </div>
    </div>
</div>
```

En la tarjeta horizontal si queremos poner la imagen en el lado derecho del texto, simplemente establece primero el texto y después la imagen:
```html
<div class="card mb-3" style="max-width: 540px;">
    <div class="row no-gutters">
    <div class="col-md-8">
        <div class="card-body">
        <h5 class="card-title">Titulo de tarjeta</h5>
        <p class="card-text">Texto de tarjeta</p>
        <p class="card-text"><small class="text-muted">Texto secundario, info.</small></p>
        </div>
    </div>

    <div class="col-md-4">
        <img class="card-img" src="./ruta/imagen.png" alt="Imagen para tarjeta">
    </div>
    
    </div>
</div>
```

---

### Buttons
Como hacer un botón; con una etiquta `<a>` con la clase `btn`, de esta manera:
```html
<a href='#', class='btn'>Boton</a>
```

Para centrar este botón en pantalla, lo tenemos que meter en un `<div>` con la clase `text-center`, de esta manera:
```html
<div class='text-center'>
  <a href='#', class='btn'>Boton</a>
</div>
```

---

### Footer
Ahora el footer. Haremos un ejemplo muy sencillo, para que lo podemos personalizar después. Esta es la parte final de la pagina, y normalmente son puros enlaces.
> Un contenedor fluido con fondo negro y `padding`/relleno de cinco, con el texto centrado
```html
<footer>
  <div class='container-fluid bg-dark p-5 text-center'>
    <div class='row'>
      <div class='col'><a href='#'>Link</a></div>
    </div>
  </div>
</footer>
```

Podemos ponerle un `text decotration`, busca en la documentación de boostrap:
```html
<footer>
  <div class='container-fluid bg-dark p-5 text-center'>
    <div class='row'>
      <div class='col'><a href='#' class='text-success'>Link</a></div>
    </div>
  </div>
</footer>
```

### Iconos bonitos
Tambien podemos agregarle iconos al texto de forma sencilla. Busca en la pagina ofical de boostrap la sección de `icono`/`install` y selecciona los que quieras e implementalos en el texto de la siguinte manera:

Ejemplo de icono, que se carga y se llama su clase "bi bi-box-arrow-up-left"
Metemos esto en el head (serian los iconos):
```html
<head>
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
```

Y esto en el body:
```html
<body>
 <i class='bi bi-box-arrow-up-left'></i>Texto
```
> Seria un icono, junto a un texto

Asi es como se usa boostrap, es rocomendable mejorar el uso de los `breakpoints`, faltaron muchas cosas de boostrap, pero son componentes que se utilizan de forma similar y intutiva.

Eso es todo, ¡a programar!.
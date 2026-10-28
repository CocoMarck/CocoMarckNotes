# Boostrap margin y padding
Vamos a utilizar los `margenes` y `paddings`/rellenos en todo momento. Por lo que necesario saber manejarlos.

Mira el siguiente código (debe estar en el body), tenemos dos columnas:
```html
<div class="container">
    <div class="row">
        <div class="col-6 bg-danger">Texto de prueba</div>
        <div class="col-6 bg-primary">Texto de prueba</div>
    </div>
</div>
```

Queremos separar estas columnas de la parte superior de la página, para hacerlo utilizaremos margenes. Añadimos un `margin` a la clase `container`, con `m`, seguido de la dirección del margen, hay varias direcciones.

#### Direcciones de `margin` o `padding`
- `t`: top/arriba
- `b`: bottom/abajo
- `l`: left/izquierda
- `r`: right/derecha

Podemos usar algo para esto CSS/boostrap. `margin-top, margin-bottom, margin-left, margin-right`.

También podemos indicar el margen en coordenadas `x-y`, de esta manera:
- `my-top, my-bottom`.
- `mx-left, mx-right`.

#### Padding
Ya hemos aprendido a utilizar margenes. Ahora ¿que pasa si quiero que un widget en específico tenga mas margen que otro?. Entonces a ese widget en específico le damos un margen. Pero si hacemos esto puede que no quede como queramos, y lo que realmente necesitamos para acomodar esto de manera adecuada, es un `padding`.

Para usar un `padding` simplemente remplaza la `m` por `p`: 
```html
<div class="col-6 bg-danger pl-5>"
```

- ¿Queremos un `margin` o `padding` en dos lados? Simplemente india los lados: 
```html
<div class='col-6 bg-danger pl-5 pr-2'>
```

¿Queremos `margin` o `padding` en todas las direcciones? Solo pon `m` o `p`: 
```html
<div class='col-6 bg-danger p-5'>
```

Esta es la forma de utilizar padding y la forma de utilizar margenes. Es muy interezante, y que no se te olvide, si queremos `margin`/`padding` solo arriba y abajo, podemos usar `y` seguido del espacio. De esta manera:
```html
<div class='col-6 bg-danger py-5'>
```

Y si queremos `padding`/`margin` solo en los lados izquierda y derecha, usamos "x" seguido del espacio:
```html
<div class='col-6 bg-danger px-5'>
```
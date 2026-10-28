# Boostrap columnas
Para utilizar estas columnas necesitas poner boostrap en el `head`, como anteriormente vimos.

El `container` va a contener las famosas filas y columnas. Una fila como máximo 12 columnas.

En boostrap simplemente abre un container com `<div class='container x'>`. Adentro del container digo que me abra una fila, con `<div class='row'>`. Adentro de esa fila ponemos las columnas, con `<div class='col-tamaño bg-tipo-de-columna>`.

De esta manera quedaría:
```html
<div class="container mt-5">
    <div class="row">
        <div class="col-1 bg-danger">   1</div>
        <div class="col-2 bg-primary">  2</div>
        <div class="col-3 bg-warning">  3</div>
        <div class="col-4 bg-info">     4</div>
        <div class="col-5 bg-success">  5</div>
        <div class="col-6 bg-secondary">6</div>
        <div class="col-7 bg-danger">   7</div>
        <div class="col-8 bg-primary">  8</div>
        <div class="col-9 bg-warning">  9</div>
        <div class="col-10 bg-info">     10</div>
        <div class="col-11 bg-success">  11</div>
        <div class="col-12 bg-secondary">12</div>
    </div>
</div>
```

Y si existen 12 tamaños para las clases col, este es un valor `min col-1`, y `max col-12`.
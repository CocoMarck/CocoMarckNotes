# Boostrap breakpoint
Puntos de ruptura, breakpoints.

Supongamos que tenemos cuatro columnas que valen `3`, de espacio `col-3`, ellas se van a aplicar de una manera muy fea porque tiene mucho texto.

Quiero que para pantallas de celular ocupen espacio de `col-12` y para otras pantallas otro espacio, como `col-2`.

#### Tamaños de break point
Para hacer esto necesitamos de un breakpoint, y lo podemos ver en la documentación de boostrap, tamaños:
- Extra small: `None` (celular)
- Small: `sm` (celular grande)
- Medium: `md` (tablet o monitor pequeño)
- Large: `lg` (PC)
- Extra large: `x1` (PC)
- Extra extra large: `xx1` (PC)

#### Ejemplo de uso de break points.
Estos son los break points, indicar como se comportaran los widgets/elementos dependiendo del tamaño de la pantalla.

Ejemplo de uso (Aca solo le ponemos tres break points, None, small y large):
```html
<div class="row">
    <div class="col-12 col-md-6 col-lg-3 bg-primary">
        Esto es mucho texto, es demasiado texto para una columna, la verdad no es una buena idea poner tanto texto, pero es con el fin de probar las funciones de boostrap, si que si. Texto innecesario, pero necesario; Las rozas son rojas, los perros ladran, los gatos maúllan, y yo hablo. Se dice que los changos son cochinos, y yo concuerdo.
    </div>
</div>
```

Los **breakpoints** no solo funcionan para columnas, sino que también funcionan para todos los widgets de boostrap, por lo que es bueno recordarlos.

Si aprendes a manejar contenedores, columnas y breakpoints. Básicamente usted ya sabe usar boostrap.
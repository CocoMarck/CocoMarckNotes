# Boostrap container
Un container sirve para meter widgets, y otros container. De todo.

En el body ponemos unas secciones `<div>`, con clase tipo contenedor boostrap, en este caso ponemos las clases:
- `container bg-success`: Para contener widgets/datos en el centro horizontal de la pagina.
- `container-fluid bg-primary`: Para contener widgets/datos en la izquierda a derecha de la pagina.

Siendo sinceros, casi todos los container que vamos a utilizar son estos dos. Si necesitamos de otro tipo de contenedor, podemos ir a la pagina de boostrap, mencionada en la introducción, y buscar los container disponibles, allí encontraras que parámetros permiten.

Ejemplo:
```html
<body>
    Estoy fuera de todo.<br><br>
    <div class="container bg-success">¡Estoy en un contenedor!</div><br>
    <div class="container-fluid bg-primary">¡Estoy de lado a lado!</div><br>
</body>
```
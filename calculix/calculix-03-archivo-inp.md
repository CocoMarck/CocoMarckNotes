# Archivo `inp`
- [Video tutorial](https://www.youtube.com/watch?v=RskKZY1lXx8)

Tiene secciando todo. En nodos, element, solid section, surfaces, etc.

### Nodos
Los nodos: `id`, y coordenadas `xyz`.

### Element
La segunda seccion del inp, es `element`. Esta dice.
- `id`, numeros de `id` de `nodos`. Unos 10.
> En realidad no se si son solo 10, pero en los inp que vi, cada elemento contiene de data 10 nodos.

Esto dice como se construyo la malla.

### Solid section
Una solid section, se compone de x cantidad de nodos. 
- `id` de solid section, seguido de `id` de nodos.

Aqui se listan los nodos que tendran un a presión indicada.

### Surfaces
Estan ligados a solid saction.


### Material
Este recive un nombre, y tiene atributos. Como elasticidad; coeficiente de poison.

## Step
Menciona lo que se hara, y en que orden. Los pasos a seguir.

## Boundary conditions
Menciona que tipo de soporte sera. En que secciones estara restrigido. Los tres numeros finales, hacen referencia al restruccion de grado de libertad, en los ejes `xyz`.

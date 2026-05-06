# PrePoMax Eliptical Bar
- [Tutorial 2](https://www.youtube.com/watch?v=2upPxL45OZg&list=PL5dFBY-h1xHet7xBY1yCeIBzPSfbQEK6W&index=2)
- [Modelo elliptical bar](https://drive.google.com/file/d/18yyUYymXtFd8nh7A0bxJmhNpBCGNPXL3/view)
- Unidades de medidas: `mm, tons, s, ºC`

Primero importamos la geometria. Seleccionamos la geometria, y despues agregamos la malla.

En parametros de malla, establecemos estos parametros:
- Max element size: 15
- Min element size: 1
- Elements per edge: 2
- Elements per curvature: 26

Activamos la previsualización, y ok.

Click derecho en geometria, y creamos malla.

---

## Pestaña FE Model
### Creamos puntos de referencia
Esto lo hacemos en la pestaña FE Model

En eje Z, le ponemos el valor 1000.

### Creamos contraint
Como Rigid Body, y punto de referencia, el que creamos. Y la cara mas carcana al punto de referencia.

### Creamos elastic material
Materials -> Create material -> Elastic -> Parametros

- Young's modulus: `210000 MPa`
- Possion's ratio: `0.3`
- Nombre: Metal

### Creamos la sección
Sections -> Create Section -> Solid Section -> Parametros

- Material: Nombre del material que creamos.
- Region type: Selection 

> Seleccionamos lo necesario. Los bordes base.

### Creamos el Step
#### Steps -> Create step -> Static Step -> Parametros

Todos los parametros en por defecto.

#### BCs -> Create boundary condition -> Fixed -> Seleccionamos la cara contraria a la del punto de referencia.

#### Load -> Create load -> Moment -> Parametros
- Region type: Reference point name
- M1, M2, M3: 0, 0, 1000000

#### History Output -> Create History Output -> Node Output -> Parameters
- Region type: Reference point name

## Results
En FE Model tab, vamos a Analyses -> proyect-name -> Click derecho/Run

Y vemos los resultados en la pestaña Results.
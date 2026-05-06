# PrePoMax Análisis modal de una viga
Primeramente importamos el modelo, y seleccionamos el sistema de unidades, otra vez el de milimetros.

- Max element size: 10 mm
- Min element size: 0.8 mm

## FE Model
Materials -> Create material -> Elastic -> Parametros -> Density -> Parametros

**Elastic**:
- Young's modulus: `210000 MPa`
- Possion's ratio: `0.3`
- Nombre: Metal

**Density**:
- Density: 7.85E-09

### Seccion
Aplicamos una sección solida a la viga, seleccionandolo.

### Step
Creamos un step, pero esta vez sera un Frequency Step, con frecuencia de pasos, de 12.

Establecemos BCs, a los bordes (solo dos vertices, y una linea), del largo, el de arriba y el de abajo.

A un borde le indicamos. M1, M2, M3: Fixed, Fixed, Fixed, y a la otra: M1, M2, M3: Fixed, Fixed, 0.


## Results
Ejecutamos y listo.
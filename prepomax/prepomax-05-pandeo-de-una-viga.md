# PrePoMax Pandeo de una viga
[Video](https://www.youtube.com/watch?v=cAe3zpkCVRc&list=PL5dFBY-h1xHet7xBY1yCeIBzPSfbQEK6W&index=4)

Sistima de unidad, milimetros. Importamos la geometria.

Creamos una malla para la geometria, especificamos su tamaño maximo, a 10 milimetros. Y su tamaño minimo a un milimetro.

## Punto de referencia
Usamos un query, para poner un punto de referencia. Vemos las coordenadas de nuestro punto hecho con query, y las establecemos en el punto de referencia.  Este punto de referencia estara situado en la cara mal puesta/partida de la geometria.

## Crear Rigid Body
Entramos en Contraints -> Rigid Body -> Y seleccionamos la cara mal puesta.

## Creamos el step
Creamos un backle step, con numero de factores uno, y Acuaracy a `0.01`.

Creamos una Boundary Condition, Fixed, a la cara posterior, a la que esta del borde contrario al de la cara mal puesta.

Ahora un Load, sera una fuerza concentrada, sera en el punto de referencia. A `F2: -1N`

## Run
Ejecutamos todo, y vemos que jale.


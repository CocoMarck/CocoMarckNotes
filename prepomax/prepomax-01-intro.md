# PrepoMax | Introducción
Aplicacion, que permite importar la geometria desde diversos formatos CAD intercambiables y `archivos.stl`. 

Analiza geometria, y la optimiza para que la forma sea recistente, añadiendo, o quitando lo necesario para que la forma sea resistente.

Es una herramiento Open Source, para el uso de software y hardware privativo.

Trata de simplificar el uso del motor `CalculiX`, a pura GUI.

- [PrepoMax](https://prepomax.fs.um.si/)
- [CalculiX](https://www.calculix.de/)

> `CalculiX` es un paquete diseñado para resolver problemas de campo. El metodo utilizado es el metodo de elementos finitos.
> Se pueden construir, calcular y postprocesar modelos de elementos finitos.

PrepoMax GUI, CalculiX motor y CLI.

PrePoMax simula física mecánica. Es como un laboratorio virtual donde sometes a tus modelos 3D a torturas digitales para ver cómo reaccionan.

Aunque puede hacer cosas complejas, se especializa principalmente en estas categorías:
- Resistencia
- Vibraciones
- Análisis térmico
- Análisis de pandeo
- Conactos entre piezas

---

## Contexto necesario
Entender la lógica de los datos. 

Evitar GIGO (Garbage In, Garbage Out): si le metes basura al simulador, te va a dar resultados basura muy bonitos y coloridos.

1. Las condiciones de frontera (Boundary Conditions)
	- Contraints (Sujetores): Tienes que decirle al script qué nodos del modelo están "anclados" (no se mueven). Si se te olvida. El motor de cálculo dirá que la pieza salió volando al inifito y te dará error.
	
	- Loads (Cargas): No es solo "poner peso". Tienes que definir si es una fuerza puntual, una presión distribuida o gravedad.

2. Las propiedades del material
Aqui no basta con poner `material = "plastico"`. El motor `CalculiX` necesita números reales (constantes físicas). Para que tu script funcione, vas a necesitar un diccionario o un JSON con datos como:
	- Módulo de young ($E$): Qué tan elástico es el material.
	- Coeficiente de Poisson ($v$): Cuánto se deforma hacia los lados cuando lo aplastas.

3. El concepto de "Mesh" (la malla)
	- Tu `archivo.step` es un objeto continuo.El simulador lo convierte en una red de Nodos (puntos con coordenadas $x, y, z$) y Elementos (las conexiones entre esos puntos).

	- El reto: Si la malla es muy "gruesa", el cálculo es rápido pero impreciso. Si es muy "fina", tu PC va a agonizar y el script tardará horas. Optimizar la densidad de la malla mediante código es el verdadero arte aquí.
	

Nivel de matematicas necesario: Aritmetica, Algebra, Funciones, Funciones partidas a trozos, Limites, Derivadas. Nivel prepa pues, pero entre mas mejor.


---

## Modelos
Para trabajar con PrepoMax, se necesitan modelos we. Así que los haces, o los obtienes. 

Por ejemplo por este sitio web [GrabCad Librery](https://grabcad.com/library/tag/library). Deben ser `modelos.step`.

Para hacer modelos. [FreeCad](https://www.freecad.org/index.php?lang=es_ES)

```bash
choco install freecad
```


---
## CODE Camino python
Si vas a programar en `python`, y quieres hacer usar directamente al Motor `CalculiX` sirve.

```bash
pip install pycalculix
```

Instalar lo necesario.
```bash
gsudo choco install calculix
```
> Puede que no tengas instalado `gsudo` pero este se refiere ejecutar un comando de terminal como administrador.

[Ejemplos de pycalculix](https://github.com/spacether/pycalculix/tree/master/examples)
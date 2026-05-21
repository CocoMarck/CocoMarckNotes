# Archivo `inp`
Se escribio viendo un video tutorial.

## Secciones mas importantes
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
- La sección `Solid Section` relaciona un conjunto de elementos (`ELSET`) con un material.
- Esto indica que los elementos del conjunto `EALL` utilizarán el material `Steel`.

Aqui se listan los nodos que tendran un a presión indicada.

### Surfaces
Las surfaces definen caras o regiones del modelo FEM.
Estas pueden utilizarse para:
- contacto
- presión
- tie constraints
- cargas
- interacción entre piezas

### Material
Este recive un nombre, y tiene atributos. Como elasticidad; coeficiente de poison.

### Step
Menciona lo que se hara, y en que orden. Los pasos a seguir.

### Boundary conditions
Menciona que tipo de soporte sera. En que secciones estara restrigido. Los tres numeros finales, hacen referencia al restricción de grado de libertad, en los ejes `xyz`.
- depende keyword
- depende tipo elemento
- depende DOFs

### Loads
Las cargas. Mencionan que tipo de carga sera, por ejemplo fija, dinamica. Su nombre. Y despues menciona las caras en las que estara la carga.

### Results
Al final esta la sección que menciona los resultados. Que son $U$, campo de desplazamiento. Y para cada uno de los nodos, los $S$, los esfuerzos de boundary conditions, y etc.

Y así termina el archivo del input file de CalculiX.

----

Si tenemos el input file. No necesitamos a PrePoMax, a la GUI, para poder ejecutarlo con CalculiX.

Con por ejemplo:
```bash
ccx_dynamic.exe "ruta-de-archivo-inp"
```
> No hay que ponerle el INP. Nomas le pasas la ruta con comillas, y ENTER.

Cuando lo ejecuta, genera los siguientes archivos: `Archivo.dat, Archivo.sta, Archivo.cvg, Archivo.12d, Archivo.frd`.

El punto es que, PrePoMax ya tiene un a interfaz grafica, lista para poder ver los resultados del CalculiX. El `archivo.frd`. Contiene todos los resultados, es legible. Pero casi no existen programas que lo lean, porque trae una estructura compleja, tema renderizado, colores, y etc. Pero existen varias personas que se tomaron el tiempo de hacer un convertidor de `archivo.frd` a algo mas estandar.

### ¿Que pasaria si no quiero usar PrePoMax?
Pues uno de los softwares mas potentes, para actualizar cosas relacionadas con elemento finito, se llama [ParaView](https://www.paraview.org/).

> ParaView, es de la compañia kitware. 

**¿Que hizo PrePoMax?**: Si nos vamos a su carpeta `lib`, veremos `dlls` de `Kitware`. Ellos compraron PrePoMax, implementaron su procesamiento de view, de ParaView, adentro de PrePoMax. El PrePoMax, de alguna manerga convierte el `frd`, a algo legible para el ParaView dlls que tiene el PrePoMax.

PrePoMax utiliza librerías de Kitware, especialmente VTK, para el renderizado y visualización de resultados FEM.

Entonces para no depender de PrePoMax, tenemos que convertir el `archivo.frd` a archivo legible para ParaView. Y de hecho ParaView, soporta gran variedad de tipos de archivos.

Convertir `archivo.frd`, a `archivo.vtu`.

Esto se puede hacer con `ccx2paraview`, o con `frd2vtu`. Ambos jalan con python.
```powershell
gsudo pip install vtk numpy
gsudo pip install frd2vtu
gsudo pip install ccx2paraview==3.0.0
```
> Tienen dependencias: vtk, numpy.

- Websites: [frd2vtu](https://github.com/wr1/frd2vtu), [ccx2paraview](https://github.com/calculix/ccx2paraview).

#### Uso de `ccx2paraview`
Por terminal:
```powershell
ccx2paraview file.frd vtu
```

En python:
```python
from ccx2paraview import Converter

c = Converter( "file.frd", ["vtu"] )
c.run()
```

#### Uso de `frd2vtu`
Por terminal:
```powershell
frd2vtu file.frd
```

En python:
```python
from frd2vtu import frd2vtu

convert = frd2vtu("file.frd", "./output_dir")
if convert:
    print("Convertido we")
```

El flujo de trabajo sera, meter el `inp` al CalculiX, convertir el `frd` a `vtu`. Y visualizar todo con ParaView.

---

## ParaView
ParaView, es un visualizador altamente capacitado. Porque puede dar mucha mas información, que por ejemplo el PrePoMax. Se puede ver el estado anterior del modelo en "x" step. Con transparencias, etc. Muchas cosas.

Así se instala con winget.
```powershell
gsudo winget install --id Kitware.ParaView --source winget
```
> Pesa como medio giga, y cada vez mas, pero es normal, es un programa muy cargado de features locas.

Si tienes pc viejo, necesitas ParaView viejo. La ver `5.6` debe jalar de una. No pide tanto OpenGL new funcs. A una `AMD Radeon HD 5700 Series (1010.82 MiB) [Discrete]`, (GPU del 2010) le debe jalar.

Dependencias si quieres usar la versión `MPI`:
```powershell
winget install -e --id Microsoft.msmpi
```
**En realidad la ver `MPI`, es para supercomputadoras, no pc's normales. Ni si quiera pc gamer, sino pc que maneje cientos de cpu, ram, vram, etc.**

--- 

## Notas sobre el source code de CalculuX
El source code de CalculiX, es puro codigo escrito en `C`, y  `Fortrain`. En el source code de CalculiX, existen parches creados por la comunidad, que aun no han sido vistos o implementados de manera oficial, pero estan listos para producción. Estos estan en el dir `patches`. Podemos implementarlos al código, y compila, para tener la ver de CalculiX, con mas correcciones.
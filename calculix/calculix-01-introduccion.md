# CalculiX Intruducción
Primeramente `CalculiX`, no es render. Es un `Solver numérico FEM`. Obtiene datos(problemas a resolver), y manda de output la solución.

---
## Recive principalmente de input `archivos.inp.`
Tipo Abaquis. Ahí recibe: Nodos, elementos, materiales, boudary conditions, cargas, contactos, steps, amplitudes, initial conditions, y etc.

Ejemplo simplifiado by ChatGPT:
```
*NODE
1,0,0,0

*ELEMENT,TYPE=C3D8
1,1,2,3,4,5,6,7,8

*MATERIAL
*ELASTIC

*STEP
*STATIC
```
Esto definie, geometría, física, simulación.

Internamente calcula $Ku = f$. Donde $K$, es matriz de rigidez, $u$ desplazamientos, y $f$ fuerzas.

Y muchas cosas mas. (estudiar física para entender moment). Plisticidad, contacto, temperatura, defoermaciones, y etc.

## Qué entrega CalculiX
Resultados numéricos, como: `archivo.frd`. Principal output visualizable. 

Contiene: nodos, desplazamientos, stresses, strains, temperatura, y etc.

Este lo leen: PrePoMax, ParaView, `CGX`.

> `CGX`. Proyecto para CalculiX, para renderizar resultados.

- `Archivo.dat`: Texto plano, muy usado para: integration points, debugging, extracción custom.
- `Archivo.sta`: Status del solver. Increments, convergencia, tiempo.
- `Archivo.cvg`: Convergence info.
- `Archivo.12d, Archivo.inp`, etc: Outputs auxiliares.

> El render lo hacen otros programas.

### Entonces el pipeline debe ser.
De Generar `archivo.inp`, mandarlo a `CalculiX`, ontener data en `archivo.frd` o `archivo.dat`. Luego a `VTU conversion`, ParaView (Pero por motivos practicos, mejor en el mismo PrePoMax). 
- `.frd`: Orientado principalmente a visualización y postproceso.
- `.dat`: Más útil para extracción técnica, debugging e integration points.

---

## CalculiX no entiende geometría visual
A CalculiX no le importa si el modelo es:
- una viga
- una placa
- una soldadura
- un cilindro

Internamente solo trabaja con:
- nodos
- elementos
- conectividades
- matrices
- propiedades físicas

Todo termina convertido en datos numéricos.

---

## Source Code y compilados
Por motivos Windowseros, aca esta el compilado de [CalculiX puro para windows](https://github.com/calculix/CalculiX-Windows).

- [Documento de uso de Calculix](https://www.dhondt.de/cgx_2.23.pdf): Es bastante tecnico, pero da toda la información necesaria para entenderlo.
- [Source code](https://github.com/Dhondtguido/CalculiX).
- [WebSite](https://www.calculix.de/).
- [Ejemplos de `inp` listos](https://github.com/calculix/CalculiX-Examples/tree/master)
    - [Therminal Distortion](https://github.com/calculix/CalculiX-Examples/tree/master/Thermal/Thermal%20distortion): Sirve para entender que ponerle al inp, para deformacion por soldadura. `Shrinkage Model for Welding Distortion`.

---
## Conclusión
El CalculiX, necesita un `inp` de input para trabajar. Programas como PrePoMax se encargan de ello. Pero por motivos debug, el `inp` puede ser editado, y se le pueden agreagar datos para que trabaje. Así podre simplemente obtener coordenadas, xyz de lo que quiero, y trabajar con esos datos en el `inp`. Obtener output, y usar el legacy `cgx`. Que sirve para ver lo que paso.
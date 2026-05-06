# 🛠️ Flujo básico en PrepoMax (by Copilot)
[Video tutorial, básico](https://www.youtube.com/watch?v=XMNVtqrb3is&list=PL5dFBY-h1xHet7xBY1yCeIBzPSfbQEK6W)

1. **Importar geometría**
   - `File → Import → STEP/STL`
   - Empieza con algo simple: una placa, un cubo o un cilindro.

2. **Definir material**
   - En el árbol del modelo: `Features → Materials → New`
   - Ejemplo:  
     - Acero: \(E = 210 \, GPa\), \(\nu = 0.3\), \(\rho = 7850 \, kg/m^3\).

3. **Asignar material a la pieza**
   - Selecciona el sólido → botón derecho → `Assign Material`.

4. **Condiciones de frontera**
   - `Features → Boundary Conditions → New`
   - Fija un borde o una cara (para que no “salga volando”).
   - Ejemplo: fijar el lado izquierdo en X, Y y Z.

5. **Aplicar carga**
   - `Features → Loads → New`
   - Elige presión o fuerza.
   - Ejemplo: presión uniforme en la cara superior.

6. **Generar malla**
   - `Mesh → Generate Mesh`
   - Ajusta el tamaño de los elementos (empieza con algo medio, luego prueba más fino).

7. **Crear análisis**
   - `Analysis → New Step → Static`
   - Selecciona las condiciones y cargas que definiste.

8. **Ejecutar solver**
   - `Analysis → Run`
   - Se genera el archivo `.inp` y CalculiX hace el cálculo.

9. **Ver resultados**
   - `Results → Open`
   - Explora desplazamientos, tensiones (Von Mises, Tresca), modos de vibración, etc.
   - Ajusta el “Deformation scale factor” para visualizar mejor.
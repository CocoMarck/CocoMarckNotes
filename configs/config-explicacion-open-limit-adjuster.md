### 1. PtrNode (Single/Double) y EntryInfoNode = `unlimited`

* **¿Qué son?:** Son las listas que el juego usa para saber qué objetos hay en cada zona del mapa.
* **¿Por qué en SAMP?:** Los servidores de SAMP suelen inyectar miles de objetos (mapeos) que no existen en el juego original. Si dejas el límite original, cuando entres a una zona con muchos objetos puestos por el admin, el juego se cerrará con un error de "punteros". Ponerlo en `unlimited` evita que el juego se confunda al contar objetos nuevos.

### 2. Peds y PedIntelligence = `512`

* **¿Qué son?:** El límite de personas vivas y su "cerebro".
* **¿Por qué en SAMP?:** En el modo historia, esto ayuda a **Urbanize**. En SAMP, evita que el juego crashee en eventos masivos. Si hay 100 jugadores cerca y 400 NPCs, el juego tiene espacio para procesar a todos. **Deben ser iguales** porque cada cuerpo (Ped) necesita un cerebro (Intelligence); si no, el cuerpo se queda congelado y el juego cae.

### 3. Vehicles = `512`

* **¿Qué es?:** La cantidad de autos que el juego puede "recordar" a tu alrededor.
* **¿Por qué en SAMP?:** Los servidores pesados de Roleplay o Carreras tienen cientos de autos estacionados. El límite original (110) hace que los autos de otros jugadores parpadeen o desaparezcan. Con 512, verás el tráfico de los demás jugadores de forma fluida.

### 4. Task y Event = `unlimited`

* **¿Qué son?:** Las acciones (correr, disparar) y sucesos (explosiones).
* **¿Por qué en SAMP?:** SAMP usa "Tasks" personalizados para que veas a otros jugadores caminar o usar animaciones. Si hay 50 jugadores cerca haciendo cosas diferentes, el límite original se llena en un segundo. Al estar en `unlimited`, te aseguras de que ninguna animación de otro jugador cause que se te cierre el GTA.

### 5. StreamingObjectInstancesList = `100000`

* **¿Qué es?:** Cuántas "copias" de objetos (árboles, postes, señales de **Project Props**) puede mostrar el juego a la vez.
* **¿Por qué en SAMP?:** Es el arreglo definitivo para que el mapa no parpadee. Los mapeos de los servidores de SAMP consumen estas "instancias". Si el número es bajo, verás que el suelo desaparece cuando el servidor carga un edificio nuevo.

### 6. MemoryAvailable = `2048`

* **¿Qué es?:** La "mochila" de RAM que el juego tiene para cargar texturas y modelos.
* **¿Por qué en SAMP?:** Como usas el parche de 4GB, 2048MB (2GB) es el máximo real que el motor puede usar sin volverse inestable. Esto permite que los autos de **VehFuncs**, los peatones de **PedFuncs** y los objetos de **Project Props** queden guardados en la RAM y no tengan que cargarse cada vez que giras la cámara.

---

### Sobre el FrameLimit = `30`

Si bien dijiste que lo pondrás en 30, ten en cuenta esto:

* **Lo bueno:** La física del juego será 100% estable (nadarás bien, los autos frenarán normal).
* **Lo malo:** Con tantos mods de IA como **Urbanize**, a 30 FPS podrías notar que los NPCs tardan un poco más en reaccionar.

> **Tip:** Como tienes **FramerateVigilante.SA.asi**, este mod ya arregla los bugs de las físicas. Podrías probar ponerlo en **60** y verás que el juego se siente increíblemente suave sin los errores de antes.

¡Qué onda bro! Armar un gabinete de madera tipo *open-air* (abierto) o semiabierto es de los proyectos más fáciles, baratos y frescos que puedes hacer, porque literalmente no hay paredes que encierren el calor.

Además, **tengo una muy buena noticia sobre la electricidad:** la madera seca es un aislante eléctrico natural (no conduce electricidad), así que no te va a dar toques ni va a hacer corto con los componentes por sí sola. El verdadero peligro con la madera es la **estática** (que se acumula por fricción y puede freír un componente) o que algún tornillo/pin toque donde no debe.

Aquí tienes la guía sencilla paso a paso para armarlo y protegerlo:

---

### Parte 1: El Diseño Sencillo (Estilo "Banco de Pruebas" o Marco Abierto)

Para no complicarte con cortes difíciles ni ensambles de carpintería complejos, hazlo tipo **caja abierta por los lados** o tipo **estructura de dos pisos** (fuente abajo, placa madre arriba).

#### Medidas base para ATX:

Una placa ATX mide **30.5 cm x 24.4 cm**. Para que todo quepa cómodo con cables y fuente de poder, usa estas medidas:

* **Base y Tapa (2 tablas):** 40 cm de largo x 25 cm de ancho.
* **Postes / Columnas (4 listones de madera):** 38 cm de alto (de 2x2 cm o 3x3 cm de grosor).
* **Tabla trasera / Bandeja de la Motherboard (1 tabla):** 35 cm de alto x 30 cm de ancho.
* *Material recomendado:* Triplay (contrachapado) de pino o MDF de **12 mm a 15 mm** de grosor. El pino es más ligero y aguanta mejor los tornillos que el MDF.

#### Armado paso a paso:

1. **El esqueleto:** Atornilla los 4 postes a las esquinas de la tabla base, y luego pon la tabla superior encima para hacer un cubo abierto. (Usa pegamento blanco de carpintero + pijas/tornillos para madera).
2. **La bandeja de la placa madre:** Fija la tabla trasera (la de 35x30 cm) a dos de los postes traseros, dejando un espacio abajo de unos **10 cm** para que ahí quepa la fuente de poder (PSU).
3. **Los separadores (¡Súper importante!):** **Nunca** atornilles la placa madre directo a la madera. Compra un paquetito de separadores de bronce (*motherboard standoffs* M3, cuestan como $50 pesos en Mercado Libre o tiendas de electrónica). Haz los agujeros guía en la madera según tu placa ATX, mete los separadores (puedes ponerles una gota de pegamento epóxico o cola loca para que no se giren) y ahí atornillas la tarjeta madre.
4. **Soporte para la GPU:** Como el panel trasero es de madera y no tienes las ranuras metálicas de un gabinete normal, pon un pequeño listón de madera o una escuadra metálica en "L" alineada con la altura de la GPU para atornillar su bracket y que no cuelgue ni doble el puerto PCIe.
5. **Flujo de aire (Frescura máxima):** Al estar abierto por los lados, el aire caliente sube y sale solo. Si quieres flujo forzado, pon **2 ventiladores de 120 mm al frente** metiendo aire directo hacia la tarjeta madre y la GPU. Puedes hacer los círculos con una broca sierra o simplemente hacer un corte cuadrado.

---

### Parte 2: ¿Cómo pintar y tratar la madera por el tema eléctrico?

Como te decía, la madera no conduce corriente, pero sí puede guardar estática o absorber humedad. Para evitar cualquier susto ("electro powers"), haz esto:

1. **Sella la madera primero:** Dale una mano de **sellador para madera** o primer acrílico. Esto tapa los poros para que la madera no absorba humedad del ambiente (la humedad sí conduce electricidad). Lija suavemente cuando seque.
2. **Pintura normal (No metálica):** Usa **pintura acrílica en aerosol** o esmalte base agua/aceite (negro mate, blanco, el color que quieras).
* ⚠️ **OJO:** Evita pinturas que digan "efecto metálico", "cromo" o que tengan partículas de aluminio/zinc, porque esas sí pueden conducir electricidad si tocan una pista de la placa.


3. **El truco antiestática:** Una vez pintado y bien seco, dale una capa final de **barniz transparente mate o brillante** (poliuretano o acrílico en spray). El barniz crea una capa plástica completamente aislante y liza que evita la acumulación de estática.

---

### ⚠️ Tip Extra de Seguridad (La Tierra Física)

En un gabinete de metal, todos los componentes comparten "tierra" a través del chasis y el cable de la fuente de poder. En uno de madera, **la fuente de poder (PSU) sigue haciendo tierra a través de los cables negros (GND) que van a la placa madre y a la GPU**, así que funciona sin problemas.

Solo asegúrate de:

* Que tu enchufe de pared tenga tierra física o usar un buen regulador/supresor de picos.
* Que el botón de encendido (un switch de 2 pines que compras por $20 pesos) esté bien aislado en sus patitas con cinta aislante o termofit.

Si quieres, dime qué herramientas tienes a la mano (caladora, taladro, puro desarmador, etc.) y adaptamos los cortes para que no batalles nada.

----

# Tapa de plástico
El cristal templado es una trampa mortal: lo apoyas tantito mal en el piso o le das un golpe seco en la esquina y explota en mil pedazos. Para un proyecto casero, el plástico es mil veces más práctico, barato y aguantador.

Para lograr eso tienes dos opciones súper accesibles en México (las consigues en Home Depot, tiendas de plásticos o Mercado Libre):

### 1. ¿Qué plástico comprar?

* **Acrílico transparente (PMMA) de 3 mm o 4 mm:** Es el estándar para gabinetes. Es cristalino, rígido, no se pone amarillo rápido y se ve muy pro.
* **Policarbonato sólido (Makrolon / Lexan) de 3 mm:** Si buscas **resistencia extrema** (es el material de los escudos antidisturbios), este es irrompible. Aguanta martillazos sin quebrarse, aunque es un poquito más caro que el acrílico y se raya un poco más fácil.

### 2. ¿Cómo cortarlo sin que se estrelle? (Si lo compras en lámina)

Si vas a una tienda de plásticos/rótulos (en Monterrey/Escobedo hay varias por el centro o sobre Av. Universidad/Barragán), **pídeles que te lo corten a la medida exacta (38 x 40 cm)**; te cobran una nada y te ahorras el trabajo.

Si lo cortas tú en casa:

* **NO uses sierra de dientes grandes** porque lo astillas.
* Usa un **cúter normal**: marca una línea con una regla metálica y pasa el cúter unas 10 o 15 veces haciendo presión firme hasta hacer un surco profundo. Luego pon la línea justo en el borde de una mesa y haz presión hacia abajo; se parte limpio y recto.

### 3. ¿Cómo fijar la tapa al gabinete (y que siga siendo fresco)?

Como el objetivo es que el gabinete sea **muy fresco**, no pegues el plástico sellando la caja por completo. Hazlo tipo **"panel flotante"**:

1. **Perfora las 4 esquinas del plástico:** Usa una broca normal para metal/madera, pero **perfora despacio y sin hacer mucha fuerza** (pon un pedazo de madera abajo para que no se doble al salir la broca). Haz los agujeros un poquito más anchos que el tornillo para que el plástico no quede bajo tensión.
2. **Deja un espacio de ventilación (El truco maestro):** En lugar de atornillar el plástico pegado a los postes de madera, mete unos **separadores o rondanas de goma/plástico de 1.5 cm a 2 cm** entre la madera y la tapa transparente.
* *¿Qué ganas con esto?* Te queda una tapa transparente que protege tus componentes de golpes o de que caiga algo encima, pero alrededor tiene una rendija de 2 cm por donde el aire entra y sale libremente.


3. **Usa tornillos de mariposa o moleteados:** Así puedes quitar la tapa con la mano en 10 segundos cuando quieras limpiar el polvo o mover algo adentro, sin andar buscando desarmador.

### ⚠️ Único cuidado con el plástico y la electricidad:

El plástico nuevo trae una película protectora (como un hule azul o café). **Déjasela puesta mientras trabajas** para no rayarlo.
Cuando se la quites al final, se va a generar algo de estática por el jalón. Antes de ponerla cerca de la PC, pásale un trapito de microfibra ligeramente húmedo con agua (o con un chorrito de limpiavidrios sin amoniaco) para neutralizar la estática y dejarlo impecable.
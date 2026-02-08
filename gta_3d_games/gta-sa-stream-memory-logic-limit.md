## 🧠 Límite lógico del engine GTA SA (streaming)
Esto aplica para los gta de la era 3d.

* **≈ 1024 MB**
  Ese es el **límite lógico estable** del motor para:
* texturas (TXD)
* modelos (DFF)
* colisiones

Aunque tengas 4 GB o más disponibles.

---

## 🚫 ¿Por qué evitar valores mayores (ej. 2048)?

* El streaming **no escala**
* Buffers y colas internas se saturan
* Más:

  * crashes aleatorios
  * texturas invisibles
  * cuelgues al viajar
* Funciona “al inicio”, falla con tiempo de juego

---

## ⚠️ ¿Problemas por poner MENOS (ej. 256–512)?

* Recargas constantes
* Pop-in agresivo
* Texturas tardías o borrosas
* Micro-stutter al moverte rápido

---

## 🧱 Modelos y texturas pesadas (HD)

* Consumen el pool muy rápido
* Forzan descargas y recargas
* Aumentan:

  * fragmentación
  * presión de streaming
* Con valores altos → crash
* Con valores bajos → pop-in

---

## ✅ Regla práctica

* **512–1024 MB** = equilibrio perfecto
* Más de **1024** = inestable
* Menos de **512** = pobre visual

Ese es el techo real del motor original.
Todo lo demás es pelear contra RenderWare 
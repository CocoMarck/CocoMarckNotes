Va, aquí tienes un **artículo sencillón**, sin humo técnico, para que quede claro **qué carambolas es el CBR** y por qué **2200 kbps** tiene sentido en tu caso.

---

# 📦 ¿Qué es CBR y para qué sirve?

**CBR (Constant Bitrate)** significa que el video se graba usando **la misma cantidad de datos todo el tiempo**.

En lugar de decir:

> “usa más bits cuando la escena es difícil”

CBR dice:

> “usa **SIEMPRE** X kbps, pase lo que pase”.

Ejemplo:

* CBR 2200 kbps
  → cada segundo del video pesa casi lo mismo

---

## 🧠 ¿Por qué existe CBR?

CBR se usa cuando:

* Quieres **flujo estable**
* No quieres picos de escritura en disco
* Necesitas **compatibilidad total**
* Estás grabando o transmitiendo en tiempo real

Es muy común en:

* Streaming
* Grabaciones largas
* Hardware limitado
* Sistemas donde la estabilidad importa más que la eficiencia

---

## 🎥 CBR vs VBR vs CRF (en corto)

### 🔹 CBR

* Bitrate fijo
* Tamaño predecible
* Menor eficiencia
* Muy estable

### 🔹 VBR

* Bitrate variable
* Más eficiente que CBR
* Tamaño menos predecible

### 🔹 CRF (calidad constante)

* Calidad visual constante
* Tamaño variable
* Ideal para grabar y luego comprimir

---

## 🎯 ¿Qué pasa en escenas simples y complejas?

Imagina esto:

* Pantalla casi estática (código, escritorio):

  * CBR **desperdicia bits**
* Escena con mucho movimiento:

  * CBR **se queda corto**
  * aparecen bloques si el bitrate es bajo

Por eso:

* CBR necesita **más bitrate** que CRF para verse igual

---

## 🧩 Entonces, ¿por qué usar CBR?

Usa CBR si:

* No quieres picos de CPU / disco
* Estás grabando mientras juegas
* Quieres estabilidad primero
* El bitrate disponible está limitado

No es el mejor visualmente,
pero es **el más predecible**.

---

## 🔧 CBR en tu caso (540p / 20 FPS)

Con tu configuración:

* Resolución: `960×540`
* FPS: `20`
* Encoder: `x264`
* Preset: `faster`

👉 **2200 kbps** es una buena elección:

* UI clara
* Texto estable
* Poco artefacto
* CPU relajado

Si notas:

* movimiento feo → sube a 2400
* demasiado peso → baja a 2000

---

## 🧠 Analogía callejera

CBR es como:

* Darle **el mismo dinero** a alguien cada día
  aunque un día no lo necesite
  y otro día le falte.

CRF es:

* Darle **lo que necesita cada día**.

CBR es bruto,
pero confiable.

---

## ✅ Conclusión rápida

* CBR = estabilidad
* No es el más eficiente
* Necesita más bitrate
* Funciona muy bien si eliges bien el preset

Para ti, por ahora:

> **CBR + 2200 kbps = elección sana**

Cuando quieras, te explico:

* por qué el buffer importa
* cómo migrar de CBR a CRF sin perder calidad
* o cómo imitar exactamente un stream profesional

Aquí seguimos 🔧😎

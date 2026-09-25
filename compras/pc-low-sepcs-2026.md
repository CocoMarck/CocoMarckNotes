# Guía de Ensamble: PC Low-Specs Equilibrada (1080p / Dev / Gaming)

## 1. Visión General del Proyecto

Esta especificación busca maximizar la relación costo-beneficio para desarrollo de software, emulación retro/moderna, y videojuegos a resolución **1080p nativa**. La arquitectura toma como referencia el rendimiento y la eficiencia de las consolas de generación actual (PS5 / Xbox Series), priorizando bajo consumo energético y plena compatibilidad con **GNU/Linux (Mesa/Vulkan/Wayland)** y Windows.

---

## 2. Ensamble Base: Opción Intel (Intel + AMD GPU)

| Componente | Especificación Recomendada | Precio Aprox. (USD) | Precio Aprox. (MXN) |
| --- | --- | --- | --- |
| **CPU** | Intel Core i3-14100F (4C/8T) | $105 USD | $1,900 MXN |
| **GPU** | AMD Radeon RX 6600 (8 GB GDDR6) | $190 USD *(Nuevo)* / $130 USD *(Usado)* | $3,500 MXN / $2,400 MXN |
| **RAM** | 16 GB (2x8 GB) DDR4 @ 3200 MHz | $35 USD | $650 MXN |
| **Tarjeta Madre** | Chipset H610M (Socket LGA1700) | $65 USD | $1,200 MXN |
| **Almacenamiento** | SSD NVMe M.2 512 GB / 1 TB PCIe 3.0/4.0 | $40 USD | $750 MXN |
| **Fuente de Poder** | 500W / 550W 80 Plus Bronze | $40 USD | $750 MXN |
| **Gabinete + Vent.** | Gabinete Micro-ATX flujo de aire básico | $30 USD | $550 MXN |
| **TOTAL** | **Combo completo** | **~$430 - $505 USD** | **~$7,700 - $9,400 MXN** |

---

## 3. Ensamble Equivalente: Opción AMD (Full AMD)

Para mantener la paridad exacta en rendimiento y precio usando un ecosistema 100% AMD:

| Componente | Especificación Equivalente | Notas de Rendimiento |
| --- | --- | --- |
| **CPU** | **AMD Ryzen 5 5500** *(o Ryzen 5 3600)* | 6 núcleos / 12 hilos. Rendimiento mononúcleo similar, mejor desempeño en multitarea pesada o compilación masiva. |
| **Tarjeta Madre** | Chipset **AM4 B450M / A520M** | Plataforma AM4 económica, altamente probada y madura en Linux. |
| **GPU** | **AMD Radeon RX 6600 (8 GB)** | Misma GPU de la opción Intel para mantener la equivalencia gráfica. |
| **RAM / SSD** | 16 GB DDR4 (2x8 GB) @ 3200 MHz + SSD 512 GB | Misma especificación que el ensamble Intel. |

---

## 4. Alternativas de GPU Modernas (8 GB VRAM)

Si prefieres explorar opciones fuera de AMD para el apartado gráfico, estas son las mejores alternativas de 8 GB en el mercado moderno:

### Alternativa NVIDIA: **NVIDIA GeForce RTX 3050 (8 GB GDDR6)**

* **Precio Aprox:** ~$180 - $200 USD (~$3,300 - $3,700 MXN).
* **Ventajas:** Soporte superior para DLSS, mejor rendimiento en Ray Tracing básico y codificación de video por hardware (NVENC).
* **Desventajas:** Desempeño gráfico rasterizado ligeramente inferior a la RX 6600 en juegos 1080p puros.
* **Linux:** Requiere el driver propietario de NVIDIA (`nvidia-driver`).

### Alternativa Intel: **Intel Arc A580 (8 GB GDDR6)** *(o Intel Arc A750)*

* **Precio Aprox:** ~$160 - $180 USD (~$2,900 - $3,300 MXN).
* **Ventajas:** Excelente relación precio-rendimiento en juegos modernos con DirectX 12/Vulkan, arquitectura Xe-SS moderna y codificador AV1 nativo por hardware.
* **Requisito Crítico:** Requiere soporte de **Resizable BAR (ReBAR)** activado en la tarjeta madre para rendir al 100%.
* **Linux:** Soporte nativo de código abierto integrado directamente en la pila gráfica de **Mesa**.

---

## 5. Estimación de Rendimiento y Consumo Energético

* **Consumo Eléctrico Promedio:** ~150W - 170W en carga máxima de juego (extremadamente eficiente).
* **Gaming 1080p:** 60+ FPS en títulos eSports y juegos AAA (Cyberpunk 2077 en gráficos medios/altos con FSR/XeSS).
* **Compatibilidad de SO:** Optimizado para arquitecturas Linux ligeras (Debian, Devuan, Arch, Mint) bajo Wayland o X11.
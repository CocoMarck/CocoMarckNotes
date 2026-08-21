#    Plan upgrade PC gaming (meta 2027)    #

Actualización: `2026-08-20`

Meta: ahorrar 1 año con sueldo, sin deber nada, y armar el upgrade para jugar lo moderno a 1080p/1440p mejor que consola. Base actual: Debian 13, Ryzen 5 3500X, RX 6400 LP, 16GB RAM.

---

## Reglas de compra (no negociables)

- Techo GPU nueva: **$280 USD / $5,600 MXN**, 16GB VRAM mínimo.
- Crédito solo con dinero YA reservado (para subir buró): pagando el total antes de que genere intereses, jamás el mínimo. Si la tarjeta cobra anualidad, no.
- No pagar precios inflados por fiebre de IA ("RAMpocalypse": el GDDR6 de 16GB pasó de costar ~$130 a ~$270 USD por tarjeta).
- Si el precio nunca llega → no se compra. Esa también es la regla.
- Mientras espero el año: monitorear precios mensualmente. Si aparece buen precio ANTES de terminar el ahorro, se compra y ya (el resto del HW puede esperarse).

---

## Regla de oro: bajo consumo > potencia bruta

Como hay un año de espera, toca rebuscar lo MÁS MODERNO del momento al momento de comprar. Y si existe una GPU **low profile, moderna, 16GB VRAM, bajo consumo y precio chido** → esa se elige. Las potentes tan chidas, pero las de bajo costo energético son mejores aún:

- Menos ruido (los fans casi ni trabajan)
- Menos gasto de luz
- Menos calor = menos estrés = probablemente duran más
- Entran en cases chiquitos como el que ya tengo

---

## GPU objetivo

### 1ra opción: Radeon RX 9060 XT LP 16GB (la elegida si sigue vigente)

Existe desde diciembre 2025, variante oficial **Low Power / Low Profile** de AMD:

| Spec | Valor |
|---|---|
| VRAM | 16GB GDDR6, 128-bit, 320 GB/s (idéntica a la normal) |
| Consumo | **140W** (vs 160W de la estándar) |
| Boost | 3050 MHz (vs 3130 MHz, -2.5% = nada) |
| Formato | Half-height dual-slot: 172 × 69 × 39 mm |
| Energía | 1x conector PCIe 8-pin, PSU recomendada 450W |
| Precio | Lanzó ~$329–349 USD; en Japón llegó a bajar del MSRP (~$332) |
| Linux | Mesa/RADV nativo (RDNA4), cero driver propietario |

Notas al comprar:
- **Verificar que la caja diga 16GB** (hay trims OEM de 12GB).
- Modelos: referencia AMD LP, Vastarmor triple-fan (CES 2026, pero vende en China). Buscar equivalentes LP de Sapphire/PowerColor/Gigabyte cuando toque comprar.
- Con esta tarjeta: Cyberpunk 1080p alto nativo ~100 fps. El objetivo de medio @ 100 fps queda sobrado.

### Plan B: RX 9060 XT 16GB normal (full height)
Misma VRAM, 160W, interfaz PCIe x16 completa (clave: mi placa A520 es PCIe 3.0 y las NVIDIA nuevas usan x8 → ahí pierden la mitad de ancho de banda).

### Descartada: RTX 5060 Ti 16GB
~$550 USD (22% sobre MSRP), x8 lanes, driver propietario en Linux. Mal negocio.

### Plan C (usado): RX 6800 16GB o RX 7800 XT 16GB
En Linux las AMD usadas son riesgo cero: Mesa nativo, sin cuentas ni suscripciones de driver. Aparecen cerca de $280 USD.

---

## CPU: la pieza clave

**Objetivo: Ryzen 7 5700X3D** (drop-in AM4, no cambio de placa):

- 8 núcleos / 16 hilos + 96MB de caché 3D V-Cache
- Donde el 3500X (6c/6t) da 70–90 fps promedio con caídas a los 50s en zonas densas de Night City, el 5700X3D sostiene 100+ fps estable
- Es el último gran CPU de socket AM4 → **se están dejando de fabricar**: si aparece a buen precio (nuevo o usado) durante el año de ahorro, no esperarlo

Alternativa económica: **Ryzen 5 5600** (~$110–130 USD nuevo), +20–25% sobre el 3500X.

⚠️ **Antes de cambiar el CPU**: actualizar BIOS de la A520M K V2 (vía Q-Flash) a la versión que soporta Ryzen 5000 X3D. Hacerlo CON el CPU viejo puesto.

---

## HW acompañante del CPU

| Pieza | Qué comprar | Por qué |
|---|---|---|
| Disipador | Thermalright Peerless Assassin 120 SE o Assassin X 120 R SE (~$20–35 USD) | El 5700X3D viene sin cooler decente; estos son silenciosos y sobran para sus 105W |
| RAM | 32GB (2×16) DDR4-3200 CL16 dual channel | Los 16GB van justos con Proton + KDE. OJO: DDR4 inflada por la IA → esperar oferta o usado. Verificar antes que los actuales sean 2 módulos (`sudo dmidecode -t memory`) |
| PSU | 550–650W 80+ Bronze **con conector PCIe 8-pin** | Requisito para CUALQUIER GPU de la lista; la actual seguro no tiene el conector |
| (Opcional) NVMe | 1TB NVMe si el SSD de 256 se queda corto | La placa tiene slot M.2 |

Orden de instalación cuando llegue todo: BIOS update → CPU + cooler → RAM → PSU → GPU.

---

## Mientras ahorro (2026–2027)

- El sistema actual se queda tal cual (Mesa 25.0.7 va perfecto con la RX 6400).
- Cerrar Steam cuando no se juega (~2GB de RAM gratis).
- Firefox: pestañas inactivas se descargan solas (`browser.tabs.unloadOnLowMemory`).
- Si compro la GPU antes de migrar de distro: kernel ≥6.14 requerido para RDNA4 (trixie-backports ya habilitado). Si migro primero a Debian 14 (¿o Devuan? jaja): viene con kernel/Mesa nuevos, cero pasos extra.

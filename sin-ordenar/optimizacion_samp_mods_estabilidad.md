# Mods de optimización para SA-MP (enfocados en estabilidad)

Este documento lista **solo mods orientados a prevenir crashes y corrupción de memoria en SA-MP**.
No incluye mods puramente gráficos ni cosméticos.

---

## 🎯 Objetivo

- Reducir crashes aleatorios
- Evitar desbordes de memoria (overflows)
- Aumentar estabilidad general

> Regla de oro: Menos plugins = más estabilidad.

---

# 🛡 Mods esenciales (imprescindibles)

## SilentPatchSA.asi
- Corrige bugs internos del exe
- Arregla memory leaks
- Previene crashes comunes del motor

**Estado:** Obligatorio

---

## III.VC.SA.LimitAdjuster.asi (Fastman92 Limit Adjuster)
- Aumenta pools internos
- Evita desbordes de arrays
- Previene crashes por límites alcanzados

**Estado:** Obligatorio

---

# 🧩 Mods complementarios seguros

## GTASA.WidescreenFix.asi
- Arregla resolución y escalado
- No toca streaming profundo

**Estado:** Seguro

---

## fix.black_roads.asi
- Corrige bug de carreteras negras
- No interfiere con SA-MP

**Estado:** Seguro

---

## rundll32exefix.asi
- Evita errores clásicos de inicio

**Estado:** Seguro

---

## mousensxy.cs
- Ajuste de sensibilidad

**Estado:** Seguro

---

# 🚫 Mods NO recomendados para SA-MP (aunque sean populares)

Estos mods pueden funcionar en singleplayer, pero aumentan el riesgo de crash en SA-MP:

- ImprovedStreaming.SA.asi
- MixSets.asi
- FramerateVigilante.SA.asi
- RepairGTA.SA.asi
- Plugins que toquen física, streaming o entidades

Motivo: SA-MP ya maneja su propio sistema de streaming y sincronización.

---

# ⚙ Configuración recomendada (perfil base SA-MP)

```
SilentPatchSA.asi
III.VC.SA.LimitAdjuster.asi
GTASA.WidescreenFix.asi
fix.black_roads.asi
rundll32exefix.asi
mousensxy.cs
```

---

# 🧠 Filosofía de estabilidad

- Primero estabilidad, luego estética
- Evitar plugins que modifiquen streaming
- Evitar duplicar fixes
- Probar cambios de uno en uno

---

# ✅ Conclusión

Para SA-MP, **SilentPatch + LimitAdjuster** proporcionan la mayor parte de la estabilidad posible.
Todo lo demás es opcional y debe evaluarse con cuidado.

---

Autor: Jean Abraham


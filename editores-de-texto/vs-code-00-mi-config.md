# Configurar Visual Studio Code sin autocierre y activar Word Wrap
> Generado por AI. ChatGPT

## Objetivo

Este documento explica cómo configurar Visual Studio Code para:

* Desactivar el autocierre de:

  * paréntesis `()`
  * corchetes `[]`
  * llaves `{}`
  * comillas `""`
  * comillas simples `''`
* Evitar comportamientos automáticos molestos relacionados.
* Activar `Word Wrap` para que las líneas largas se ajusten automáticamente.

---

# 1. Abrir configuración de VS Code

Puedes abrir la configuración de varias formas.

## Método rápido

Presiona:

```text
Ctrl + ,
```

---

# 2. Desactivar autocierre de símbolos

En la barra de búsqueda de Settings escribe:

```text
auto closing
```

Te aparecerán varias opciones.

---

## Configuración recomendada

### Auto Closing Brackets

Cambiar:

```text
Editor: Auto Closing Brackets
```

A:

```text
never
```

Esto desactiva:

* `()`
* `[]`
* `{}`

---

### Auto Closing Quotes

Cambiar:

```text
Editor: Auto Closing Quotes
```

A:

```text
never
```

Esto evita que VS Code escriba automáticamente:

```text
""
''
```

---

# 3. Opciones opcionales recomendadas

Estas opciones ayudan a evitar comportamientos automáticos adicionales.

Buscar:

```text
auto closing delete
```

Cambiar:

```text
Editor: Auto Closing Delete
```

A:

```text
never
```

---

Buscar:

```text
auto closing overtype
```

Cambiar:

```text
Editor: Auto Closing Overtype
```

A:

```text
never
```

---

# 4. Activar Word Wrap

El Word Wrap hace que las líneas largas se partan visualmente dentro del editor sin crear saltos de línea reales.

---

## Método visual

Buscar:

```text
word wrap
```

Cambiar:

```text
Editor: Word Wrap
```

A:

```text
on
```

---

## Método rápido por teclado

Presiona:

```text
Alt + Z
```

Esto activa o desactiva Word Wrap instantáneamente.

---

# 5. Configuración directa en settings.json

También puedes editar el archivo `settings.json` directamente.

---

## Abrir settings.json

Presiona:

```text
Ctrl + Shift + P
```

Luego escribe:

```text
Preferences: Open User Settings (JSON)
```

---

## Configuración completa recomendada

Pega esto:

```json
{
    "editor.autoClosingBrackets": "never",
    "editor.autoClosingQuotes": "never",
    "editor.autoClosingDelete": "never",
    "editor.autoClosingOvertype": "never",
    "editor.wordWrap": "on"
}
```

---

# 6. Resultado final

Con esta configuración:

* VS Code ya no insertará automáticamente:

  * `()`
  * `[]`
  * `{}`
  * `""`
  * `''`
* El editor dejará de mover el cursor automáticamente entre símbolos.
* Las líneas largas se ajustarán automáticamente gracias a Word Wrap.

---

# 7. Nota importante

Algunos lenguajes o extensiones pueden volver a activar ciertos comportamientos automáticos.

Si eso ocurre:

* revisa las extensiones instaladas
* desactiva extensiones de autocomplete agresivas
* prueba abrir VS Code sin extensiones

Comando:

```text
code --disable-extensions
```

---

# 8. Recomendación

Muchos programadores dejan activado el autocierre porque acelera escritura en:

* C#
* JavaScript
* TypeScript
* Python
* C++

Pero desactivarlo puede sentirse más cómodo si:

* escribes rápido
* editas mucho código viejo
* haces copy/paste frecuente
* te molesta el cursor automático
* vienes de editores minimalistas

# Matemáticas con MathJax
[Video de 100 derivadas resueltas](https://www.youtube.com/watch?v=B5oxL1AQpLo)

<img
    style="display: block; margin-left: auto; margin-right: auto; width: 30%;"
    src="./cat-delta.svg"
    alt="image">
</img>

### Ejercicio 80
> Tiempo en video `4:14:11`

```math
y = x \cdot {
    \sqrt{4 -x^{2}}
} 
+ 4 \text{arcsen} ( \frac{x}{2} )
```

"x" por la raíz de cuatro menos "x" al cuadrado, esto mas cuatro
arcoseno de "x" sobre dos

```math
y' = 
\sqrt{4 -x^2} + { 
    \frac{x \cdot -2x}{2 \cdot \sqrt{4 -x^2}} 
} + 4 \cdot 
{
    \frac{
        \frac{1}{2} 
    } { 
        \sqrt{ 1 -{\frac{x}{2}}^2 } 
    }
} 
``` 

```math
\text{=}
\sqrt{4 -x^2} + 
{ 
    \frac
    {x \cdot {\frac{-2x}{2}} }
    { \sqrt{4 -x^2} } 
} + 2
\cdot 
{
    \frac
    { 2 \cdot {\frac{1}{2}} }
    {  {\frac{1}{2}} \cdot \sqrt{ {4 -x^2} } } 
}
```

```math
\text{=}
\sqrt{4 -x^2} + { \frac{-x^2}{\sqrt{4 -x^2}}  }
+ { 
    \frac{ 
        2 \cdot ( \frac{2}{2} )
    }{ 
        \frac{1}{2} \cdot \sqrt{ {4 -x^2} } 
    } 
}
```

```math
\text{=}
\sqrt{4 -x^2} + { \frac{-x^2}{\sqrt{4 -x^2}}  }
+ { 
    \frac{2}{ 
        \frac{1}{2} \cdot \sqrt{ {4 -x^2} } 
    } 
}
```

```math
\text{=}
\sqrt{4 -x^2} - { \frac{x^2}{\sqrt{4 -x^2}}  }
+ { \frac{4}{ \sqrt{ {4 -x^2} } } }
```
```math
\text{=}
[ \sqrt{ 4 -x^2 } \cdot { \frac{\sqrt{ 4 -x^2 }}{\sqrt{ 4 -x^2 }}} ]
-{ \frac{x^2}{\sqrt{4 -x^2}}  }
+ { \frac{4}{ \sqrt{ {4 -x^2} } } }
```
```math
\text{= }
\frac{\sqrt{4-x^2}}{1} \cdot
\frac{
    \sqrt{4-x^2} -x^2 + 4
}{
    \sqrt{4-x^2}
}
```
```math
\text{= }
\frac{
    4 -x^2 -x^2 + 4
}{
    \sqrt{4-x^2}
}
=
\frac{
    4 + 4 -2x^2 
}{
    \sqrt{4-x^2}
}
=
\frac{
    (4 \cdot 2) (-1 \cdot 2 \cdot x^2 )
}{
    \sqrt{4-x^2}
}
```

```math
\text{Sacamos factor común al dos:}
```
```math
\text{= }
\frac{
    2 \cdot (4 -x^2 )
}{
    \sqrt{4-x^2}
}
=
\frac{
    2 \cdot (4 -x^2 )
}{
    \sqrt{4-x^2}
} \cdot
\frac{\sqrt{4-x^2}}{\sqrt{4-x^2}}
=
\frac{
    2 \cdot (4 -x^2 ) \cdot \sqrt{4-x^2}
}{
    \sqrt{4-x^2} \cdot \sqrt{4-x^2}
}
```
```math
\text{Resultado: }
```
```math
\text{= }
\frac{
    2 \cdot (4 -x^2 ) \cdot \sqrt{4-x^2}
}{
    4-x^2
}
=
2 \cdot \sqrt{4-x^2}
```


#### Contexto de soluciones
Resolución para:
```math
\sqrt{ 1 -\frac{x^2}{2^2}}
=
\sqrt{ \frac{4}{4} -\frac{x^2}{4}}
=
\sqrt{ \frac{4 -x^2}{4} }
=
{ \frac{ \sqrt{4 -x^2} }{ \sqrt{4} } }
=
{ \frac{ \sqrt{4 -x^2} }{2} }
=
\frac{1}{2} \cdot \sqrt{ {4 -x^2} }
```

Resolución para:
```math
{ 
    \frac{
        x \cdot { \frac{2 \cdot -1 \cdot x}{2}} 
    }{
        \sqrt{4 -x^2} 
    } 
}
= 
{ 
    \frac{
        x \cdot -1 \cdot x
    }{
        \sqrt{4 -x^2} 
    } 
}
=
{ \frac{-x^2}{\sqrt{4 -x^2}}  }
```

Resolución para:
```math
{ 
    \frac{ 
        2
    }{ 
        \frac{1}{2} \cdot \sqrt{ {4 -x^2} } 
    } 
}
=
{ 
    \frac{ 
        1 \cdot 2
    }{ 
        \frac{1}{2} \cdot \sqrt{ {4 -x^2} } 
    } 
}
=
{ 
    \frac{ 
        (1 \cdot 2) \cdot 2
    }{ 
        {( \frac{1}{2} \cdot 2)} \cdot \sqrt{ {4 -x^2} } 
    } 
}
=
{ \frac{  2 \cdot 2 }{ 1 \cdot \sqrt{ {4 -x^2} } } }
=
{ \frac{4}{ \sqrt{ {4 -x^2} } } }
```

Resolución para:
```math
\sqrt { 4 -x^2 }
= \sqrt{ 4 -x^2 } \cdot { \frac{\sqrt{ 4 -x^2 }}{\sqrt{ 4 -x^2 }} }
```

#### Reglas aplicadas
Primeramente la regla de derivación del producto. Para: 
```math
\sqrt{ 
    1 -{ 
        \frac{x^{2}}{2^{2}}
    }
}
```

- **Regla del producto**: $x \cdot y = x \cdot y' + y \cdot x'$

- **Propiedad de la raíz de una división**: $\sqrt{\frac{A}{B}} = \frac{\sqrt{A}}{\sqrt{B}}$

- **Esto es verdadero**: $\sqrt{x} = \sqrt{x} \cdot \frac{\sqrt{x}}{\sqrt{x}}$. Cualquier numero multiplicado por uno, es lo mismo.

---

### Ejercicio 81
> Momento: `4:17:36`

```math
y = sen^3(2x -3)
```
<p style="text-align: center;">Seno al cubo de dos "x" menos tres.</p>

```math
y' = 3 \cdot sen^{3-1}(2x -3) \cdot sen(2x -3)'
```
```math
\text{= }
3 \cdot sen^{2}(2x -3) \cdot [ cos(2x -3) \cdot (2x-3)' ]
```
```math
\text{= }
3 \cdot sen^{2}(2x -3) \cdot [ cos(2x -3) \cdot 2 ]
```
```math
\text{= }
6 \cdot sen^{2}(2x -3) \cdot cos(2x -3) 
```
<p style="text-align: center;">Podríamos dejarlo asi, pero vamos a seguir simplificando un poco mas.</p>

```math
\text{= }
6 \cdot sen(2x -3) \cdot [ sen(2x -3) \cdot cos(2x-3) ]
```
```math
\text{= }
6 \cdot sen(2x -3) \cdot \frac{sen[2 \cdot (2x-3)]}{2}
=
6 \cdot sen(2x -3) \cdot \frac{sen(4x-6)}{2}
```
```math
\text{= }
\frac{ [6 \cdot sen(2x -3)] \cdot sen(4x-6)}{2}
=
\frac{6}{2} \cdot sen(2x -3) \cdot sen(4x-6)
```
```math
\text{= }
3 sen(2x -3) \cdot sen(4x -6)
```
<p style="text-align: center;">¡Resultado!</p>

#### Reglas aplicadas
- **Regla de la potencia**: 
    $y = ax^b \text{; } y' = a \cdot bx^{b-1}$
- **Como derivar seno**: 
    $(sen{x})' = cos{x}$
- **Regla de la cadena**:
    $y = f(g(x)) {\text{; }} y' = f'[g(x)] \cdot g'(x)$
- **La derivada de una constante siempre es cero**.
- **Identidad**: $sen(a) \cdot cos(a) = \frac{sen(2a)}{2}$
- $\frac{x \cdot y}{2} = \frac{x}{2} \cdot y = x \cdot \frac{y}{2}$

---

### Ejercicio 82
```math
y = \frac{1}{2} tg(x) \cdot sen(2x)
```
Derivar: Unos sobre dos tangente de "x", por seno de "x".

Mirad. Seguramente si escribimos, esta excreción en función simplemente de "x". Evitar la "x". Podríamos simplificar las cosas.

```math
y = \frac{1}{2} \cdot \frac{sen(x)}{cos(x)} \cdot 2 \cdot \frac{sen(2x)}{2}
```
```math
\text{= }
\frac{1}{2} \cdot \frac{sen(x)}{cos(x)} \cdot 2 \cdot sen(x) \cdot cos(x)
```
```math
\text{= }
\frac{1}{2} \cdot \frac{2}{1} \cdot 
\frac{sen(x)}{cos(x)} \cdot \frac{cos(x)}{1} \cdot sen(x) 
=
\frac{2}{2} \cdot \frac{sen(x) \cdot cos(x)}{cos(x)} \cdot sen(x) 
```
```math
\text{= }
sen(x) \cdot sen(x)
=
sen(x)^2
```
Quedo algo bien simple. 

**Ahora si derivemos:**
```math
y' = 2 \cdot sen(x)^{2- 1} \cdot cos(x)
=
2 \cdot sen(x) \cdot cos(x)
=
\frac{2}{1} \cdot \frac{sen(2x)}{2}
=
\frac{2 \cdot sen(2x)}{2}
```

```math
\text{= }
sen(2x)
```

La deriva de "y" es seno de dos "x". Que bonito ejercicio.

### Contexto de soluciones
```math
sen(2x) = 
\frac{sen(2x)}{1} \cdot 1 =
\frac{sen(2x)}{1} \cdot \frac{2}{2} =
\frac{sen(2x) \cdot 2}{1 \cdot 2} =
\frac{sen(2x)}{2} \cdot \frac{2}{1}
```


### Reglas aplicadas
- $sen(a) \cdot cos(a) = \frac{sen(2a)}{2}$
- $tg(x) = \frac{sen(x)}{cos(x)}$
- **Regla de la potencia**: $y = ax^b \text{; } y' = a \cdot bx^{b-1}$
- **Como derivar seno**: $(sen{x})' = cos{x}$
- **Regla de la cadena**: $y = f(g(x)) {\text{; }} y' = f'[g(x)] \cdot g'(x)$

---

### Ejercicio 83
> Momento: `4:23:53`
```math
y = (\frac{x}{1+x})^5
```
Derivar "x" sobre uno mas "x", elevado a la quinta potencia.

```math
y' = 5 \cdot (\frac{x}{1+x})^{5-1} \cdot \frac{x' \cdot (1+x) -x \cdot (1+x)'}{(1+x)^2} 
=
\frac{5}{1} \cdot \frac{x^4}{(1+x)^4} \cdot 
\frac{1 \cdot (1+x) -x \cdot 1}{(1+x)\cdot(1+x)}
```
```math
\text{= }
\frac{5x^4}{(1+x)^4} \cdot
\frac{1 + x -x}{(1+x)\cdot(1+x)}
=
\frac{5x^4}{(1+x)^4} \cdot 
\frac{1}{(1+x)^2}
```
```math
\text{Resultado: } \frac{5x^4}{(1+x)^6}
```

Cinco "x" a la cuarta potencia, sobre uno mas "x", elevado a la sexta potencia.

### Reglas/Propiedades aplicadas
- **Regla la derivada de un cociente**: La derivada de un cociente tipo $f(x) : g(x)$, es; La “derivada del numerador” por el “denominador”, menos el “numerador”, por el “denominador derivado”. Esto dividido entre; el “denominador al cuadrado”.
```math
\frac{d}{dx} [\frac{f(x)}{g(x)}] = 
\frac{ 
    f'(x) \cdot g(x) -f(x) \cdot g'(x) 
}{ [g(x)]^2 }
```

- **Regla de la potencia**: $y = ax^b \text{; } y' = a \cdot bx^{b-1}$

- **Regla de la cadena**: $y = f(g(x)) {\text{; }} y' = f'[g(x)] \cdot g'(x)$

- **Dos potencias de la misma base que se están multiplicando, los exponentes, se suman:** $y^z \cdot y^x = y^{z + x}$

- **Cualquier valor multiplicado por uno, es igual ese valor.**

---

### Ejercicio 84
> Momento: `4:26:58`
```math
y = sen(\sqrt{x} \cdot ln(x))
```
Seno de raíz de "x" por logaritmo neperiano de "x".
```math
y' = cos(\sqrt{x} \cdot ln(x)) \cdot (
    [
        \frac{1}{2} \cdot x^{(\frac{1}{2} -{1})}
    ] \cdot ln(x) + 
    \frac{1}{x} \cdot \sqrt{x}
)
```
```math
\text{= } 
cos(\sqrt{x} \cdot ln(x)) \cdot (
    [\frac{1}{2} \cdot \frac{x^{(\frac{1}{2} -\frac{2}{2})}}{1}] \cdot
    ln(x) + \frac{1}{x} \cdot {\sqrt{x}}
)
=
cos(\sqrt{x} \cdot ln(x)) \cdot (
    [\frac{1}{2} \cdot \frac{x^{(-\frac{1}{2})}}{1}] \cdot 
    ln(x) + \frac{1}{x} \cdot \sqrt{x}
)
```
```math
\text{= }
cos(\sqrt{x} \cdot ln(x)) \cdot (
    [\frac{1}{2} \cdot \frac{1}{x^{(\frac{1}{2})}}] \cdot 
    ln(x) + \frac{1}{x} \cdot \sqrt{x}
)
=
cos(\sqrt{x} \cdot ln(x)) \cdot (
    \frac{1}{2 \cdot x^{(\frac{1}{2})}} \cdot 
    ln(x) + \frac{1}{x} \cdot \sqrt{x}
)
```
```math
\text{= }
cos(\sqrt{x} \cdot ln(x)) \cdot (
    [\frac{1}{2 \cdot x^{(\frac{1}{2})}} \cdot ln(x) ] +
    [\frac{1}{x} \cdot \sqrt{x}]
)
```
```math
cos(\sqrt{x} \cdot ln(x)) \cdot (
    [\frac{ln(x)}{2 \cdot \sqrt{x}} ] +
    [\frac{\sqrt{x}}{x}]
)
=
cos(\sqrt{x} \cdot ln(x)) \cdot (
    \frac{
        [ln(x) \cdot x] + [\sqrt{x} \cdot ({2} \cdot \sqrt{x})]
    }{
        2 \cdot \sqrt{x} \cdot {x}
    }
)
```
```math
\text{= }
cos(\sqrt{x} \cdot ln(x)) \cdot (
    \frac{
        [x \cdot ln(x)] + [2 \cdot x]
    }{
        2 \cdot x \cdot \sqrt{x}
    }
)
=
cos(\sqrt{x} \cdot ln(x)) \cdot (
    \frac{
        x \cdot [ln(x) + 2]
    }{
        2 \cdot x \cdot \sqrt{x}
    }
)
```
```math
\text{Resultado: }
cos(\sqrt{x} \cdot ln(x)) \cdot (
    \frac{ln(x) + 2}{ 2 \cdot \sqrt{x} }
)
```

#### Contexto de soluciones
**Regla del producto**:
```math
[\sqrt{x} \cdot \ln(x)]' = \frac{1}{2\sqrt{x}} \cdot \ln(x) + \sqrt{x} \cdot \frac{1}{x}
```
**Simplificación**:
```math
x^{-\frac{1}{2}} = \frac{1}{x^{\frac{1}{2}}} = \frac{1}{\sqrt{x}}
```

#### Reglas/Propiedades aplicadas

- **Regla de la cadena**: $y = f(g(x)) {\text{; }} y' = f'[g(x)] \cdot g'(x)$

- **Regla de la potencia**: $y = ax^b \text{; } y' = a \cdot bx^{b-1}$

- **Regla del producto**: $x \cdot y = x \cdot y' + y \cdot x'$

- **Como derivar logaritmo neperiano**: $ln'(x) = \frac{1}{x}$

- **Como derivar seno**: $sen'(x) = cos(x)$

- **Raíz cuadrada es exponente decimal `> 0; < 1`**: 
    $\sqrt{x} = x^{\frac{1}{2}}; \sqrt[y]{x} = x^{\frac{1}{y}}$

- **Logaritmo neperiano de "x", es lo mismo que logaritmo base "euler" de "x"**:
    $ln(x) = log_e{x}$

- **Regla del exponente negativo**: $\dfrac{x^{-y}}{1} = \dfrac{1}{x^{y}}$. Eso si, preferiblemente se usa bajo: `x != 0; y != 0`

- **Operar fracciones de forma cruzada:**
    $\dfrac{x}{y} + \dfrac{z}{w} = \dfrac{xw + zy}{yw}$

- **Dos raíces de "x" que se multiplican es igual a "x":** 
```math
\sqrt{x} \cdot \sqrt{x} = 
{x}^{\frac{1}{2}} \cdot {x}^{\frac{1}{2}} = 
x^{ (\frac{1}{2} + \frac{1}{2} )} =
x
```

- **Factor común**: $f(x) \times g(x) + f(x) \times h(x) = f(x) \times ( g(x) + h(x) )$

---

### Ejercicio 85
> Momento: `4:28:25`
```math
y = arctg(2x + 3)
```
$$\text{Derivar arco tangente de dos "x" mas tres.}$$

Esto es una derivada inmediata chaval.
```math
y' = \frac{2}{1 + (2x+3)^2} =
\frac{2}{1 + (4x^2 + 12x + 9)} =
\frac{2}{4x^2 + 12x + 10}
```

$$\text{Sacamos factor común, a un dos. Y cancelamos el dos.}$$
```math
= 
\frac{2}{ (2 \cdot 2 \cdot x^2) + (6 \cdot 2 \cdot x) + (2 \cdot 5)} =
\frac{2 \cdot 1}{ 2 \cdot (2x^2 + 6x + 5)}
```
$$\text{Resultado: } \frac{1}{ 2x^2 + 6x + 5}$$

#### Contexto de soluciones
Derivada:
$$(2x + 3)' = 2 \cdot 1 \cdot x^{1-1} + 0 = 2 \cdot x^{0} = 2$$

Simplificar:
$$(2x + 3)^2 = (2x + 3) \cdot (2x + 3)$$
$$= [ (2x \cdot 2x) + (2x \cdot 3) ] + [(3 \cdot 2x) + (3 \cdot 3)]$$
$$= [4x^2 + 6x] + [6x + 3^2] = 4x^2 + 12x + 9$$

#### Reglas/Propiedades aplicadas
- $arctg'(u) = \dfrac{u'}{1 + u^2}$: La derivada de arco tangente "u" es; "u" sobre uno mas "u" al cuadrado.
- **Regla de la potencia**: $y = ax^b \text{; } y' = a \cdot bx^{b-1}$
- **La derivada de una constante es cero**. No confundir con la regla del múltiplo constante.
- `x != 0; y != 0`:
```math
(x + y)^2 = 
(x + y) \cdot (x + y) =
[ (x \cdot x) + (x \cdot y) ] + [ (y \cdot x) + (y \cdot y) ] =
x^2 + xy + yx + y^2
```

---
### Ejercicio 86
```math
y = ( arcsen(x) )^2
```
<p style="text-align: center;">Derivar arco seno de "x", elevado al cuadrado.</p>

```math
y' = 2 \cdot ( arcsen(x) )^{2-1} \cdot \frac{x'}{1 -x^2}
```
```math
\text{Resultado: } 2 \cdot arcsen(x) \cdot \frac{1}{\sqrt{1 -x^2}}
```

### Contexto de soluciones
$$x' =  1 \cdot 1 \cdot x^{1-1} = x^{0} = 1$$

#### Reglas/Propiedades aplicadas
- **Regla de la potencia**: $y = ax^b \text{; } y' = a \cdot bx^{b-1}$
- **Regla de la cadena**: $y = f(g(x)) {\text{; }} y' = f'[g(x)] \cdot g'(x)$
- $arcsen'(u) = \dfrac{u'}{\sqrt{1 -u^2}}$: La derivada de arco seno de "u", es; derivada de "u", sobre raíz de uno menos "u" al cuadrado.
- Cualquier numero elevado a cero, es uno.
# Matemáticas con MathJax

[Video de 100 derivadas resueltas](https://www.youtube.com/watch?v=B5oxL1AQpLo)

### Ejercicio 80
> Tiempo en video `4:14:11`

```math
y = x \cdot {
    \sqrt{4 -x^{2}}
} 
+ 4 \text{arcsen} ( \frac{x}{2} )
```

"x" por la raiz de cuatro menos "x" al cuadrado, esto mas cuatro
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
\sqrt{4 -x^2} + { {-x^2}  \over {\sqrt{4 -x^2}}  }
+ { 
    { 
        2 \cdot ( {2 \over 2} )
    } \over 
    { 
        {1 \over 2} \cdot \sqrt{ {4 -x^2} } 
    } 
}
```

```math
\text{=}
\sqrt{4 -x^2} + { {-x^2}  \over {\sqrt{4 -x^2}}  }
+ { 
    { 
        2
    } \over 
    { 
        {1 \over 2} \cdot \sqrt{ {4 -x^2} } 
    } 
}
```

```math
\text{=}
\sqrt{4 -x^2} - { {x^2}  \over {\sqrt{4 -x^2}}  }
+ { {4} \over { \sqrt{ {4 -x^2} } } }
```
```math
\text{=}
[ \sqrt{ 4 -x^2 } \cdot { \sqrt{ 4 -x^2 } \over \sqrt{ 4 -x^2 } } ]
-{ {x^2}  \over {\sqrt{4 -x^2}}  }
+ { {4} \over { \sqrt{ {4 -x^2} } } }
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
\newline{}\newline{}
\text{Sacamos factor comun al dos:}
\newline{}\newline{}
= 
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
\newline{}\newline{}
=
\frac{
    2 \cdot (4 -x^2 ) \cdot \sqrt{4-x^2}
}{
    4-x^2
}
=
2 \cdot \sqrt{4-x^2}
\newline{}\newline{}
\text{Resultado!}
```


#### Contexto de soluciones
Resolución para:
```math
\sqrt{ 1 -{x^2 \over 2^2}}
=
\sqrt{ {4 \over 4} -{x^2 \over 4}}
=
\sqrt{ {4 -x^2} \over 4 }
=
{ { \sqrt{4 -x^2} } \over { \sqrt{4} } }
=
{ { \sqrt{4 -x^2} } \over {2} }
=
{1 \over 2} \cdot \sqrt{ {4 -x^2} }
```

Resolución para:
```math
{ 
    {
        x \cdot { {2 \cdot -1 \cdot x} \over 2} 
    }  \over 
    {
        \sqrt{4 -x^2} 
    } 
}
= 
{ 
    {
        x \cdot -1 \cdot x
    }  \over 
    {
        \sqrt{4 -x^2} 
    } 
}
=
{ {-x^2}  \over {\sqrt{4 -x^2}}  }
```

Resolución para:
```math
{ 
    { 
        2
    } \over 
    { 
        {1 \over 2} \cdot \sqrt{ {4 -x^2} } 
    } 
}
=
{ 
    { 
        1 \cdot 2
    } \over 
    { 
        {1 \over 2} \cdot \sqrt{ {4 -x^2} } 
    } 
}
=
{ 
    { 
        (1 \cdot 2) \cdot 2
    } \over 
    { 
        {( {1 \over 2} \cdot 2)} \cdot \sqrt{ {4 -x^2} } 
    } 
}
=
{ {  2 \cdot 2 } \over { 1 \cdot \sqrt{ {4 -x^2} } } }
=
{ {4} \over { \sqrt{ {4 -x^2} } } }
```

Resolusión para:
```math
\sqrt { 4 -x^2 }
= \sqrt{ 4 -x^2 } \cdot { \sqrt{ 4 -x^2 } \over \sqrt{ 4 -x^2 } }
```

#### Reglas aplicadas
Primeramente la regla de derivación del producto. Para: 
```math
\sqrt{ 
    1 -{ 
        {x^{2}} \over {2^{2}}
    }
}
```

- **Regla del producto**: $x \cdot y = x \cdot y' + y \cdot x'$

- **Propiedad de la raíz de una división**: $\sqrt{\frac{A}{B}} = \frac{\sqrt{A}}{\sqrt{B}}$

- **Esto es verdadero**: $\sqrt{x} = \sqrt{x} \cdot \frac{\sqrt{x}}{\sqrt{x}}$. Cualquier numero multiplicado por uno, es lo mismo.

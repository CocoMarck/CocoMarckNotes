[Formato de texto](https://www.w3schools.com/html/html_formatting.asp)

# HTML Formato de texto

HTML contiene varios elementos para definir texto con un significado especial.

### Ejemplo:
```xml
<b>Texto en negrita</b>
<i>Texto en cursiva</i>
Texto <sub>subscript</sub> y <sup>superscript</sup>
```

### Así se ve:
<b>Texto en negrita</b>  

<i>Texto en cursiva</i>  

Texto <sub>subscript</sub> y <sup>superscript</sup>  




# Elementos de formato
Los elementos de formato fueron diseñados para mostrar tipos especiales de texto:
- `<b>` Texto en negrita
- `<strong>` Texto importante
- `<i>` Texto en cursiva
- `<em>` Texto enfatizado
- `<mark>` Texto marcado
- `<small>` Texto más pequeño
- `<del>` Texto eliminado
- `<ins>` Texto insertado
- `<sub>` Subscript text
- `<sup>` Superscript text

---




# HTML Elementos `<b>` y `<strong>`
El elemento HTML `<b>`  define texto en negrita, sin ninguna importancia extra:

```html
<b>Este es un texto en negrita</b>
```

El elemento HTML `<strong>` define texto con gran importancia. El contenido que lo contiene suele mostrarse en negrita.
### Ejemplo:
```html
<strong>Este texto es importante</strong>
```




# HTML Elementos `<i>` y `<em>`
El elemento HTML `<i>` define una parte de texto con una voz o un estado de ánimo alternativo. El contenido interior suele mostrarse en itálico.

**Consejo:** La etiqueta `<i>` se utiliza a menudo para indicar un término técnico, una frase de otro idioma, un pensamiento, el nombre de un barco, etc.

### Ejemplo
```html
<i>Este es un texto en cursiva</i>
```

El HTML `<em>` elemento define Texto destacado. El contenido interior suele mostrarse en cursiva.
**Consejo:** Un lecto de pantalla pronunciará las palabras en <em> con énfasis, utilizando el acento verbal.
```html
<em>Texto enfatisado</em>
```

**Resultado:** Texto enfatisado</em>




# Elemento HTML `<small>`
El HTML `<small>` elemento define texto más pequeño:

### Ejemplo:
```html
<small>Este es un texto pequeño</small>
```



# Elemento HTML `<mark>`
El elemento HTML `<mark>` define el text oque debe marcarse o resaltarse:
```html
<p>No olvides comprar <mark>leche</mark> hoy</p>
```


# Elemento HTML `<del>`
El HTML `<del>` elemento define texto que se ha eliminado de un documento. Los navegadores suelen eliminar una línea a través del texto eliminado:

### Ejemplo
```html
<p>El texto es <del>textil</del> caracteres de texto</p>
```




# Elemento HTML `<ins>`
El elemento HTML `<ins>` define un texto que se ha insertado en un documento. Los navegadores suelen subrayar lo insertado. Texto:
```html
<p>Ayuda chaval necesito <ins>comida</ins></p>
```
**Resultado:** Ayuda chaval necesito <ins>comida</ins>



# Elemento HTML `<sub>`
El elemento HTML `<sub>` define texto en subíndice. Este texto aparece medio carácter por debajo de la línea normal y, a veces, se representna con una fuente más pequeña. Se puede usar para fórmulas químicas com H<sub>2</sub>0

### Ejemplo
```html
<p>Texto <sub>pequeño</sub> </p>
```

**Resutlado**: Texto <sub>pequeño</sub>




# Elemento HTML `<sup>`
Este elemento define text oen superíndice. El texto en superíndice aparece medio carácter por encima del texto normal. Línea y a veces se representa en una fuente más pequeña. Se puede usar texto en superíndice. Para notas de pie de página como WWW<sup>[1]</sup>

```html
<p>Texto con <sup>elevación</sup> potente.</p>
```

**Resultado**: <p>Texto con <sup>elevación</sup> potente.</p>
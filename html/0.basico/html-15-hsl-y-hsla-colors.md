[Enlace de tutorial](https://www.w3schools.com/html/html_colors_hsl.asp)

# HTML HSL y HSLA Colors

HSL significa tono, sturación y luminosidad.

Los valores HSLA son una extención de HSL con un canal alfa (opacidad)

# Valores de color HSL
En HTML, un color se puede especificar utilizando tono, saturación y luminosidad (HSL), en la forma:

`hsl(hue, saturation, lightness)`

El tono es un grado en la rueda de color de 0 a 360. 0 es rojo, 120 es verde y 240 es azul.

La saturación es un valor porcentual. 0% significa un tono de gris y 100% es el color completo.

La luminosidad también es un valor porcentual. 0% es negro y 100% es blanco.

<p style="background-color:hsl(0, 100%, 50%);">hsl(0, 100%, 50%)</p>
<p style="background-color:hsl(240, 100%, 50%);">hsl(240, 100%, 50%)</p>
<p style="background-color:hsl(147, 50%, 46%);">hsl(147, 50%, 46%)</p>
<p style="background-color:hsl(300, 76%, 72%);">hsl(300, 76%, 72%)</p>




# Saturación
La saturación se puede descubir como intensidad de un color. 100% es color puro, sin matices de gris. El 50% es 50% gris, pero aún puede ver el color. 0% es completamente gris; ya no se puede ver el color.

<p style="background-color:hsl(0, 100%, 50%);">hsl(0, 100%, 50%)</p>
<p style="background-color:hsl(0, 80%, 50%);">hsl(0, 80%, 50%)</p>
<p style="background-color:hsl(0, 60%, 50%);">hsl(0, 60%, 50%)</p>
<p style="background-color:hsl(0, 40%, 50%);">hsl(0, 40%, 50%)</p>
<p style="background-color:hsl(0, 20%, 50%);">hsl(0, 20%, 50%)</p>
<p style="background-color:hsl(0, 0%, 50%);">hsl(0, 0%, 50%)</p>




# Luminosidad
La luminosidad de un color se puede describir como la cantidad de luz que desea al color, donde 0% significa ninguna luz (negro), 50% significa 50% de luz (ni oscuro ni claro), y 100% significa luminosidad total (blanco).
<p style="background-color:hsl(0, 100%, 0%);">hsl(0, 100%, 0%)</p>
<p style="background-color:hsl(0, 100%, 25%);">hsl(0, 100%, 25%)</p>
<p style="background-color:hsl(0, 100%, 50%);">hsl(0, 100%, 50%)</p>
<p style="background-color:hsl(0, 100%, 75%);">hsl(0, 100%, 75%)</p>
<p style="background-color:hsl(0, 100%, 90%);">hsl(0, 100%, 90%)</p>
<p style="background-color:hsl(0, 100%, 100%);">hsl(0, 100%, 100%)</p>




# Tonos de gris
Los tonos de gris a menudo se definen estableciendo el tono y la sturación en 0, y ajustando la luminosidad del 0% al 100% para obtener tonos más oscuros/claros:

**Ejemplo**

<p style="background-color:hsl(0, 0%, 20%);">hsl(0, 0%, 20%)</p>
<p style="background-color:hsl(0, 0%, 30%);">hsl(0, 0%, 30%)</p>
<p style="background-color:hsl(0, 0%, 40%);">hsl(0, 0%, 40%)</p>
<p style="background-color:hsl(0, 0%, 60%);">hsl(0, 0%, 60%)</p>
<p style="background-color:hsl(0, 0%, 70%);">hsl(0, 0%, 70%)</p>
<p style="background-color:hsl(0, 0%, 90%);">hsl(0, 0%, 90%)</p>





# Valores de color HSLA

Los valores de color HSLA son una extensión de los valores de color HSL, con un canal alfa - que especifica la opacidad de un color.

Un valor de color HSLA es especificado con:

`hsla( tono, saturación, luminosidad, alfa )`

El parámetro alfa es un número entre 0,0 (totalmente transparente), y 1,0 (nada transparente):

<p style="background-color:hsla(9, 100%, 64%, 0);">hsla(9, 100%, 64%, 0)</p>
<p style="background-color:hsla(9, 100%, 64%, 0.25);">hsla(9, 100%, 64%, 0.25)</p>
<p style="background-color:hsla(9, 100%, 64%, 0.5);">hsla(9, 100%, 64%, 0.5)</p>
<p style="background-color:hsla(9, 100%, 64%, 0.75);">hsla(9, 100%, 64%, 0.75)</p>
<p style="background-color:hsla(9, 100%, 64%, 1);">hsla(9, 100%, 64%, 1)</p>
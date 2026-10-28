[Enlace de tutorial](https://www.w3schools.com/html/html_colors_rgb.asp)

# Colores HTML RGB y RGBA
Un valor de color RGB representa la luz ROJA, VERDE y  AZUL.
Un valor de color RGBA es una extensión de RGB con un canal alfa (opacidad).

# Valores de color RGB
En HTML, un color se puede especificar como un valor RGB, utilizando esta fórmula:

`rgb(red, green, blue)`

Cada parametros (red, green, blue) define la intensidad del color con un valor entre 0 y 255.

¡Esto significa que hay 256x256x256 = 16777216 colores posibles!

Por ejemplo, `rgb(255,0,0)` se muestra como rojo, porque el red se establece en su valor mas alto (255), y los otros valores (green, blue) están en 0.

Otro ejemplo, `rgb(0,255,0)` se muestra en verde, porque el verde está configurado en su valor más alto `255`, y los otros dos (red, blue) estan en 0.

Para mostrar el color negro, establezca todos los parámetros de color en 0, de la siguiente manera: `rgb(0,0,0)`.

Para mostrar el color blanco, establezca todos los parámetros de color 255, de la siguiene manera: `rgb(255,255,255)`.



# Tonos de gris
Los tonos de gris a menudo se definen utilizando valores iguales para los tres parámetros:
```
rgb(60, 60, 60)
rgb(100, 100, 100)
rgb(140, 140, 140)
rgb(180, 180, 180)
rgb(200, 200, 200)
rgb(240, 240, 240)
```



# Valores de color RGBA
Los valores de color RGBA son una extensión de los valores de color RGB con un canal alfa - que especifica la opacidad de un color.

Un valor de color RGBA es especificado con: `rgba( red, green, blue, alpha )`

El parámetro alfa es un número entre 0,0 (totalmente transparente) y 1,0 (nada transparente):

<p style="background-color:rgba(266, 99, 71, 1);">rgba(266, 99, 71, 1)</p>

<p style="background-color:rgba(266, 99, 71, 0.75);">rgba(266, 99, 71, 0.75)</p>

<p style="background-color:rgba(266, 99, 71, 0.5);">rgba(266, 99, 71, 0.5)</p>

<p style="background-color:rgba(266, 99, 71, 0.25);">rgba(266, 99, 71, 0.25)</p>

<p style="background-color:rgba(266, 99, 71, 0);">rgba(266, 99, 71, 0)</p>

Esto es lo que hay que saber del rgb, y rgba.
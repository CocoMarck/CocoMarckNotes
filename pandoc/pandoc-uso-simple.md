# Pandoc uso simple
Esta es la manera en la que yo uso pandoc. Lo utilizo para documentar todo, de hecho de md a cualquier cosa. De esta manera documento todo de manera mas rapida y chida.

Para tema pasar de markdown a html, no hay mucha complicacion. De hecho por defecto el pandoc pasa a eso. Para cosas tipo latex si se complica un poco mas, pero en resumen simlemebnte se le pasa un parametro para indicar que sea compatible con latex el pdf.

```bash
pandoc doc.md -o doc.html
pandoc doc.md -o doc.pdf --pdf-engine=xelatex
pandoc doc.tex -s --mathjax -o doc.html
pandoc doc.tex o doc.pdf --pdf-engine=xelatex
```


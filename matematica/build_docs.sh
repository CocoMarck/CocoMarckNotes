#!/bin/bash

INPUT_FORMAT="gfm+hard_line_breaks"
INPUT_MD_FILE="matematicas-100-derivadas-resueltas.md"
OUTPUT_NAME="matematicas-100-derivadas-resueltas"
#pandoc -f $INPUT_FORMAT $INPUT_MD_FILE -s --webtex -o "$OUTPUT_NAME.html"
pandoc -f $INPUT_FORMAT $INPUT_MD_FILE -o "$OUTPUT_NAME.pdf" --pdf-engine=xelatex -V geometry:margin=2cm
pandoc -f $INPUT_FORMAT $INPUT_MD_FILE -o "$OUTPUT_NAME.odt"

# Para los odt, no usar `\over`, solo `\frac`. Y con number antas de `=` siempre. O si no lo marca como `?`, en vez de solo mostrar el igual.
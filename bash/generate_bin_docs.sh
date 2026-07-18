#!/bin/bash

INPUT_FORMAT="gfm+hard_line_breaks"

for file in *.md; do
    name=${file%.md}
    
    pandoc -f $INPUT_FORMAT "$file" -s -o ./html/"$name".html
    pandoc -f $INPUT_FORMAT "$file" -o "./pdf/$name.pdf" --pdf-engine=xelatex -V geometry:margin=2cm
    pandoc -f $INPUT_FORMAT "$file" -o "./odt/$name.odt"
done

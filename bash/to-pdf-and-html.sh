#!/bin/bash

# Constants
SCRIPT_DIR="$(dirname "$(realpath "$0")")"
HTML_DIR="$SCRIPT_DIR/html"
PDF_DIR="$SCRIPT_DIR/pdf"

# Create dirs
if [ ! -d "$HTML_DIR" ]; then
    mkdir $HTML_DIR
else
    echo $HTML_DIR
fi

if [ ! -d "$PDF_DIR" ]; then
    mkdir $PDF_DIR
else
    echo $PDF_DIR
fi

# Using pandoc
for path_md in "$SCRIPT_DIR"/*.md; do
    name=$(basename "$path_md" .md)
    pandoc -f "gfm+hard_line_breaks" "$path_md" -s -o "$HTML_DIR/$name.html"
    pandoc -f "gfm+hard_line_breaks" "$path_md" --pdf-engine=xelatex -o "$PDF_DIR/$name.pdf"
done

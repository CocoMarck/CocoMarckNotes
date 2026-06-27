#!/bin/bash

INPUT_FORMAT="gfm+hard_line_breaks"
pandoc -f $INPUT_FORMAT gastos.md -s -o gastos.html
pandoc -f $INPUT_FORMAT gastos.md -o gastos.pdf --pdf-engine=xelatex
pandoc -f $INPUT_FORMAT gastos.md -o gastos.odt

#!/bin/bash
file=$1
if [ -f "$file" ]; then
    grep -vE '^#|^$' "$file"
fi

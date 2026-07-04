#!/bin/bash
selected_browser=""
for browser in firefox chromium; do
    if command -V "$browser" &>/dev/null; then
        selected_browser="$browser"
        break
    fi
done

if [[ -n "$selected_browser" ]]; then
    "$selected_browser" "https://play.google.com/"
fi


#!/usr/bin/env bash

# Script: `webview.sh`
# Abre URL de la forma mas simple posible. Como webapps.
# Parameters: `browser-codename, url`.
# Uso: `firefox "example.com"`
BROWSER="${1:-default}"
URL="${2:-https://example.com}"

FIREFOX_COMPATIBLES=("firefox")
CHROMIUM_COMPATIBLES=("chromium" "google-chrome" "brave-browser")
COMPATIBLES=("default")
for browser in "${FIREFOX_COMPATIBLES[@]}"; do
    COMPATIBLES+=("$browser")
done
for browser in "${CHROMIUM_COMPATIBLES[@]}"; do
    COMPATIBLES+=("$browser")
done

case "$BROWSER" in
    default)
        xdg-open "${URL}" >/dev/null 2>&1 &
        ;;
    firefox)
        $BROWSER --no-remote -P "WebApps" --class "WebApp" --new-window "${2:-https://example.com}" >/dev/null 2>&1 &
        ;;
    chromium|google-chrome|brave-browser)
        $BROWSER --app="${URL}" >/dev/null 2>&1 &
        ;;
    *)
        echo "Uso: $0 [${COMPATIBLES[@]}]"
        exit 1
        ;;
esac

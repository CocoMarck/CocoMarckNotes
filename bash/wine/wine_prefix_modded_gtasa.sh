#!/usr/bin/env bash
set -e

# 1. Validar argumentos
if [ -z "$1" ]; then
    echo "Error: Debes especificar la ruta de la carpeta para el prefijo."
    echo "Uso: $0 /ruta/a/la/carpeta"
    exit 1
fi

PREFIX_DIR="$1"

# 2. Validar existencia del directorio
if [ ! -d "$PREFIX_DIR" ]; then
    echo "Error: El directorio '$PREFIX_DIR' no existe."
    echo "Crea la carpeta primero para evitar creaciones accidentales."
    exit 1
fi

echo "==> Configurando prefijo de Wine de 64 bits en: $PREFIX_DIR"

# 3. Variables de entorno para arquitectura de 64 bits (win64)
export WINEPREFIX="$PREFIX_DIR"
export WINEARCH="win64"
export WINEDLLOVERRIDES="mscoree,mshtml="

# 4. Inicializar prefijo en modo Windows 10
echo "==> Inicializando arquitectura de 64 bits (win64)..."
wineboot -u
winecfg -v win10

# 5. Dependencias de Windows con Winetricks (Redistribuibles x86 y x64)
echo "==> Instalando librerías y runtimes (Visual C++, DirectPlay, DirectX)..."
winetricks -q --force \
    vcrun2005 \
    vcrun2008 \
    vcrun2010 \
    vcrun2013 \
    vcrun2015 \
    vcrun2019 \
    vcrun2022 \
    directplay \
    d3dx9 \
    d3dcompiler_43 \
    dsound

# 6. Descarga e instalación de DXVK (copiando x32 y x64)
echo "==> Obteniendo e instalando DXVK para 32 y 64 bits..."
TMP_DIR=$(mktemp -d)
DXVK_VERSION=$(curl -s https://api.github.com/repos/doitsujin/dxvk/releases/latest | grep -oP '"tag_name": "\K[^"]+')

if [ -z "$DXVK_VERSION" ]; then
    echo "Aviso: No se pudo obtener la versión de DXVK por API. Usando v2.4 como fallback."
    DXVK_VERSION="v2.4"
fi

echo "==> Descargando DXVK $DXVK_VERSION..."
curl -L -o "$TMP_DIR/dxvk.tar.gz" "https://github.com/doitsujin/dxvk/releases/download/${DXVK_VERSION}/dxvk-${DXVK_VERSION#v}.tar.gz"

tar -xzf "$TMP_DIR/dxvk.tar.gz" -C "$TMP_DIR"
DXVK_DIR="$TMP_DIR/dxvk-${DXVK_VERSION#v}"

# En win64: system32 = 64 bits / syswow64 = 32 bits
echo "==> Copiando DLLs de 64 bits a system32 y 32 bits a syswow64..."
cp "$DXVK_DIR/x64/d3d9.dll" "$PREFIX_DIR/drive_c/windows/system32/"
cp "$DXVK_DIR/x64/dxgi.dll" "$PREFIX_DIR/drive_c/windows/system32/"

cp "$DXVK_DIR/x32/d3d9.dll" "$PREFIX_DIR/drive_c/windows/syswow64/"
cp "$DXVK_DIR/x32/dxgi.dll" "$PREFIX_DIR/drive_c/windows/syswow64/"

# Limpiar archivos temporales
rm -rf "$TMP_DIR"

# 7. Registrar DLL Overrides en el Registro de Wine
echo "==> Configurando DLL overrides (ASI Loaders, DXVK y Audio)..."
wine reg add "HKCU\\Software\\Wine\\DllOverrides" /v vorbisFile /t REG_SZ /d "native,builtin" /f
wine reg add "HKCU\\Software\\Wine\\DllOverrides" /v dsound /t REG_SZ /d "native,builtin" /f
wine reg add "HKCU\\Software\\Wine\\DllOverrides" /v winmm /t REG_SZ /d "native,builtin" /f
wine reg add "HKCU\\Software\\Wine\\DllOverrides" /v d3d9 /t REG_SZ /d "native,builtin" /f
wine reg add "HKCU\\Software\\Wine\\DllOverrides" /v dxgi /t REG_SZ /d "native,builtin" /f

echo "=========================================================="
echo " ¡Prefijo win64 y DXVK listos en $PREFIX_DIR!"
echo " Para ejecutar el juego:"
echo " WINEPREFIX=\"$PREFIX_DIR\" WINEARCH=win64 wine /ruta/a/gta_sa.exe"
echo "=========================================================="

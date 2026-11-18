#!/usr/bin/env bash
set -e

# -----------------------------------------------------------------------------
# Validaciones de Entrada (El directorio debe ser creado previamente por el usuario)
# -----------------------------------------------------------------------------
if [ -z "$1" ]; then
    echo "Error: Debes especificar la ruta de la carpeta para el prefijo."
    echo "Uso: $0 /ruta/existente/al/prefix"
    exit 1
fi

PREFIX_DIR="$1"

if [ ! -d "$PREFIX_DIR" ]; then
    echo "Error: El directorio '$PREFIX_DIR' no existe."
    echo "Por favor, crea la carpeta primero antes de ejecutar este script."
    exit 1
fi

# -----------------------------------------------------------------------------
# Configuración del Entorno Wine
# -----------------------------------------------------------------------------
export WINEPREFIX="$PREFIX_DIR"
export WINEARCH="win64"
export WINEDEBUG="-all"

echo "=========================================================="
echo " Inicializando y configurando Prefix Wine (win64)"
echo " Ruta prefix: $WINEPREFIX"
echo "=========================================================="

# 1. Configurar la botella en modo Windows 10
echo "--> Estableciendo versión de Windows a Windows 10..."
wineboot -u
winecfg -v win10

# 2. Inicializar runtime de Wine omitiendo ventanas iniciales de Mono/Gecko
WINEDLLOVERRIDES="mscoree,mshtml=" wineboot --init

# 3. Instalación de librerías esenciales con Winetricks
# - Runtimes y Motor: .NET 3.5 SP1, VC++ (2015-2019), DXVK
# - DirectX 9/10/11: d3dcompiler (43 y 47), d3dx9, d3dx10, d3dx11_43
# - Web/Fuentes: Gecko, corefonts, ms-sans-serif
echo "--> Instalando dependencias de runtime (Winetricks)..."
winetricks -q dotnet35sp1 vcrun2015 vcrun2017 vcrun2019 vcrun2022 d3dcompiler_43 d3dcompiler_47 d3dx9 d3dx10 d3dx11_43 dxvk gecko corefonts ms-sans-serif gdiplus

# 4. Registrar motor de renderizado HTML
echo "--> Registrando mshtml.dll..."
wine regsvr32 mshtml.dll || true

# 5. Desactivar creación de integraciones de accesos directos en el sistema host
winetricks -q winemenubuilder=disabled

echo "=========================================================="
echo " ¡Prefix configurado con éxito!"
echo "=========================================================="

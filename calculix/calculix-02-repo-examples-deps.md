# Repo de ejemplos para el CalculiX puro.

## Windows CalculiX examples. Dependencias.
```powershell
gsudo winget install Git.Git Python.Python.3.12 
gsudo winget install Gmsh.Gmsh gnuplot.gnuplot
gsudo winget install ImageMagick.Q16
gsudo pip install matplotlib
```
> `gsudo`, es programa de terceros. Para ejecutar todo como admin. Descartarlo si no lo tienes instalado. Entonces ejecutar todo en terminal como admin.

Tambien necesitas el `ccx.exe` y el `cgx.exe`. Pero estos dos los tendremos que descargar, y ponerlos como vars, para que de una jalen.

## Scripts para trabajar con `ccx` y `cgx`.
El dir debe contener los exes, de ccx y cgx. `Dir/Calculix/Bin`
```batch
@echo off

set "CALCULIX_ROOT=%~dp0"
set "PATH=%CALCULIX_ROOT%;\Scripts;%PATH%"

start cmd /k "cd /d "%USERPROFILE%""
```
> Este es un ejemplo. Pon este `script.bat` en la ruta de tu calculix `ccx`, y `cgx`, lo demas dejalo igual.

Asi es el script para llamar powershell. `script.ps1` 
```powershell
$env:CALCULIX_ROOT = $PSScriptRoot
$env:PATH = "$env:CALCULIX_ROOT;$env:CALCULIX_ROOT\Scripts;$env:PATH"

Start-Process powershell -ArgumentList "-NoExit", "-Command", "Set-Location $HOME"
```

Para el windows terminal
```powershell
$env:CALCULIX_ROOT = $PSScriptRoot

$env:PATH = "$env:CALCULIX_ROOT;$env:CALCULIX_ROOT\Scripts;$env:PATH"

wt new-tab powershell -NoExit -Command "cd $env:USERPROFILE"
```

### El script que uso yo
```batch
@echo off

:: Examples dir
set "EXAMPLE_DIR=%USERPROFILE%\source\repos\Calculix-Examples"
set "EXAMPLE_SCRIPTS_DIR=%EXAMPLE_DIR%\Scripts"

:: CalculiX root
set "CALCULIX_ROOT=%~dp0"

:: PATH
set "PATH=%CALCULIX_ROOT%;%EXAMPLE_SCRIPTS_DIR%;%PATH%"

:: Open CMD and create aliases there
start cmd /k ^
doskey param.py=python \"%EXAMPLE_SCRIPTS_DIR%\param.py\" $* ^
& doskey dat2txt.py=python \"%EXAMPLE_SCRIPTS_DIR%\dat2txt.py\" $* ^
& doskey monitor.py=python \"%EXAMPLE_SCRIPTS_DIR%\monitor.py\" $* ^
& doskey periodic.py=python \"%EXAMPLE_SCRIPTS_DIR%\periodic.py\" $* ^
& doskey separate.py=python \"%EXAMPLE_SCRIPTS_DIR%\separate.py\" $* ^
& cd /d %USERPROFILE%
```
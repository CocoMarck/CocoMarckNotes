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
set "PATH=%CALCULIX_ROOT%\Scripts;%PATH%"

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

---
### El script que uso yo
```batch
@echo off

:: Examples dir
set "EXAMPLE_DIR=%USERPROFILE%\source\repos\Calculix-Examples"
set "EXAMPLE_SCRIPTS_DIR=%EXAMPLE_DIR%\Scripts"
set "GNUPLOT_DIR=\Program Files\gnuplot\bin"

:: CalculiX root
set "CALCULIX_ROOT=%~dp0"

:: PATH
set "PATH=%CALCULIX_ROOT%;%EXAMPLE_SCRIPTS_DIR%;%GNUPLOT_DIR%;%PATH%"

:: Open CMD and create aliases there
start cmd /k ^
doskey param.py=python "%EXAMPLE_SCRIPTS_DIR%\param.py" $* ^
& doskey dat2txt.py=python "%EXAMPLE_SCRIPTS_DIR%\dat2txt.py" $* ^
& doskey monitor.py=python "%EXAMPLE_SCRIPTS_DIR%\monitor.py" $* ^
& doskey periodic.py=python "%EXAMPLE_SCRIPTS_DIR%\periodic.py" $* ^
& doskey separate.py=python "%EXAMPLE_SCRIPTS_DIR%\separate.py" $* ^
& cd /d %USERPROFILE%
```

---
## WSL Ubuntu. Calculix examples
Esto es mas facil. Ademas jala mejor. Este comando es pa windows, pero lo demas es pa ubuntu.

Activar Virtualización en BIOS. `Activar Hyper-V/Virtualización en BIOS`.

Activamos la virtualizacion en windows.
```powershell
gsudo dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart
```

```powershell
gsudo winget install Microsoft.WSL --source winget

gsudo wsl --install --no-distribution
gsudo wsl --install ubuntu
```
Reinciciamos el pc.

Configuramos wsl
```powershell
wsl --set-default-version 2
wsl --set-default Ubuntu
```

Ejecutamos ubuntu.
```powershell
wsl -d Ubuntu
```

Instalamos dependencias
```bash
sudo apt update; sudo apt upgrade; sudo apt install -y build-essential gfortran python3 python3-pip git gmsh gnuplot imagemagick python3-matplotlib
```

---

## MSYS2
La instalacion debe ser así:
```powershell
gsudo winget install --id MSYS2.MSYS2 --source winget
```

Abrimos con `MSYS2 UCRT64`

Utilizamos pacman para actualizar.
```bash
pacman -Syu
```
> Le damos yes a todo.

Y volvemos a abrir con lo mismo, y volvemos a actualizar.

Instalamos lo necesario.
```bash
pacman -S --needed \
  git \
  make \
  base-devel \
  mingw-w64-ucrt-x86_64-toolchain \
  mingw-w64-ucrt-x86_64-python \
  mingw-w64-ucrt-x86_64-python-pip \
  mingw-w64-ucrt-x86_64-python-matplotlib \
  mingw-w64-ucrt-x86_64-gmsh \
  mingw-w64-ucrt-x86_64-gnuplot \
  mingw-w64-ucrt-x86_64-imagemagick \
  mingw-w64-ucrt-x86_64-calculix-ccx
```

Para el cgx, tendre que usar el exe.

Desde el MSYS2 UCRT4, poner:
```bash
export PATH="/c/Users/LANIX/Desktop/Build-CalculiX-2.20.0-win-x64/bin:$PATH"
```
> Este es un ejemplo. Para ver que jale, despues de esto escribe. `cgx`

Luego probamos algun example.
```bash
cd /c/Users/LANIX/source/repos/CalculiX-Examples
```


---
## Conclusión
Estos ejemplos de calculix, dependen de varias cosas. Python, Gnuplot, ImageMagick, shell commands mv/join, CGX, CCX.

Pero no hay que olvidar algo, al paracer estos ejemplos son mas linux freandly, pero mas o menos deben jalar en win. Lo se porque segun que `rm`, y pos win no entiende eso, es chino para el.
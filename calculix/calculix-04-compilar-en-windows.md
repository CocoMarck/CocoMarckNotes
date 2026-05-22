# Compilar CalculiX solver en windows
- [Video sobre como compilarlo](https://www.youtube.com/watch?v=tYd7nNkKLfE&list=PLtt36Hde3vMe7TesxPIiEkSY2VW5ga3TX&index=6)

Para esto utilizaremos `MSYS2`. Y el source code de este repositorio. 
- [CalculiX-Windows](https://github.com/calculix/CalculiX-Windows).

Instalamos:
```powershell
gsudo winget install --id MSYS2.MSYS2 --source winget
```

Cabe recalar que `MSYS`. Por defecto trabaja aca: `C:\msys64`. Aca se almacena todo, el home etc. Aun asi puedes trabajar fuera de aca, pero mejor aca adentro.

Abrimos el `MSYS2 UCRT64`.

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
  mingw-w64-ucrt-x86_64-gmsh \
  mingw-w64-ucrt-x86_64-gnuplot \
  mingw-w64-ucrt-x86_64-imagemagick \
  mingw-w64-ucrt-x86_64-wget  \
  mingw-w64-ucrt-x86_64-7zip \
  mingw-w64-ucrt-x86_64-gcc-fortran \
  mingw-w64-ucrt-x86_64-perl \
  mingw-w64-ucrt-x86_64-gcc \
  mingw-w64-x86_64-binutils-2.46-3 \
  mingw-w64-x86_64-crt-14.0.0.r37.g2bfe61fba-1 \
  mingw-w64-x86_64-headers-14.0.0.r37.g2bfe61fba-1 \
  mingw-w64-x86_64-isl-0.27-1 \
  mingw-w64-x86_64-mpc-1.4.1-1 \
  mingw-w64-x86_64-mpfr-4.2.2-3  \
  mingw-w64-x86_64-windows-default-manifest-6.4-4 \
  mingw-w64-x86_64-winpthreads-14.0.0.r37.g2bfe61fba-1 \ 
  mingw-w64-x86_64-gcc-16.1.0-5 \
  mingw-w64-x86_64-gcc-fortran-16.1.0-5-any 
```

Vereficamos que existan los files.
```bash
export PATH=/ucrt64/bin:$PATH
which gcc
which g++
which gfortran
```
Tienen que salir los files.

---

## Clonar repo
```bash
mkdir $HOME/source; mkdir; mkdir $HOME/source/repos; cd $HOME/source/repos

git clone "https://github.com/calculix/CalculiX-Windows.git" "$HOME/source/repos/calculix-windows" --branch master
```

---
### Compilar
```bash
cd "$HOME/source/repos/calculix-windows/src"
chmod 777 ./build.sh

export PATH=/ucrt64/bin:$PATH
export MINGW_HOME=/ucrt64
./build.sh 2.10 2.10
```
> Establecemos ruta de binarios necesarios. Damos permisos al bash script constructor. Y compilamos.

Ejemplo de output satisfactorio:
```
======================== CALCULIX FOR WINDOWS BUILD SCRIPT ========================

Using MINGW_HOME=/ucrt64

All stdout/stderr output is redirected to the directory /home/LANIX/source/repos/calculix-windows/src/x64/output
All builds occur in the directory /home/LANIX/source/repos/calculix-windows/src/x64/build
The script will install the completed builds in the directory /home/LANIX/source/repos/calculix-windows/src/x64/install

Removing previous builds ...

Building libraries ...
- Building pthreads-w32-2-9-1-release ...
- Building SPOOLES.2.2 ...
- Building ARPACK ...
- Building glut-3.7.6-bin ...
- Building CalculiX ...

Installing ...
Adding build information ...
unix2dos: converting file buildInfo.log to DOS format...

All done!
```

Ejemplo de buen build info log:
```
Build date :  Fri May 22 12:27:56 CST 2026
CGX        :  2.10
CCX        :  2.10
G++        :  g++.exe (Rev5, Built by MSYS2 project) 16.1.0
GCC        :  gcc.exe (Rev5, Built by MSYS2 project) 16.1.0
GFortran   :  GNU Fortran (Rev5, Built by MSYS2 project) 16.1.0
```

Vemos que paso:
```bash
ls "$HOME/source/repos/calculix-windows/src/x64/install"
```

Si por alguna razon no estan los exe. Puedes compilar directamente con make. Ejemplo:
```bash
cd $HOME/source/repos/calculix-windows/src/x64/build/CalculiX/ccx_2.10/src
make ccx
```
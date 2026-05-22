# Compilar CalculiX solver en windows
Para esto utilizaremos `MSYS2`. Y el source code de este repositorio. [CalculiX-Windows](https://github.com/calculix/CalculiX-Windows).

Instalamos:
```powershell
gsudo winget install --id MSYS2.MSYS2 --source winget
```

Cabe recalar que `MSYS`. Por defecto trabaja aca: `C:\msys64`. Aca se almacena todo, el home etc. Aun asi puedes trabajar fuera de aca, pero mejor aca adentro.

Abrimos el `MSYS2 MINGW64`.

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
  mingw-w64-x86_64-wget \
  mingw-w64-x86_64-7zip \
  mingw-w64-ucrt-x86_64-gcc-fortran \
  mingw-w64-ucrt-x86_64-perl
```

## Clonar repo
```bash
mkdir $HOME/source; mkdir; mkdir $HOME/source/repos; cd $HOME/source/repos

git clone "https://github.com/calculix/CalculiX-Windows.git" "$HOME/source/repos/calculix-windows" --branch master
```

### Compilar
```bash
export MINGW_HOME=/ucrt64

cd "$HOME/source/repos/calculix-windows/src"
chmod 777 ./build.sh

./build.sh 2.10 2.10
```
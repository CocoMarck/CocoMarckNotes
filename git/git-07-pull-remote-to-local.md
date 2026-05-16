# Obtener cambios del remoto al local
Si solo queremos obtener los nuevos archivos del local, sin remplazar los existentes, usamos:
```bash
# 1. Asegúrate de estar en la rama correcta
git checkout main   # o la rama que uses

# 2. Actualiza la información del remoto
git fetch origin

# 3. Trae los cambios a tu rama local
git pull origin main
```
> En realidad, solo se necesita hacer el pull. Lo demas es opcional.

---
## Si tienes cambios en tu local al remoto, agregalos y dale commit.
```bash
git add .
git commit -m "Cambios"
```

Ahora si el pull
```
git pull origin main
```
> `main`, hace referencia al nombre de tu rama.

---
## Si tienes cambios y files borrados renombrados, o movidos:
Eso si, recuerda agregar tus cambios primero...
```bash
git pull --rebase origin rama
```
> Esto aplica los commits del remoto primero y luego tus cambios encima.

---
## Si tienes modificaciones pero no quieres mantener cambios
```bash
git checkout -- file-to-ignore.xd
git pull origin main
```
> Ignoramos cambios de file, y hacemos pull.

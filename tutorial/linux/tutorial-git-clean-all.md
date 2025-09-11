# limpiar todo el repo, sin historiales, sin nada.

Borrar `.git`.
```bash
rm -rf .git
```
Tienes que estar en la carpeta del repo.

Establecer cambios, todo limpio.
```bash
git init
git add .
git commit -m "Versión limpia sin historial"
git branch -M main # Elige la rama
git remote add origin https://repo.git # indica el repo
git push -u --force origin main # Forzar cambios
```
# Git Crear una rama limpia
Aveces cuando tenemos proyectos complejos, y queremos implementar documentación como rama, es buena idea crear una rama nueva, e independiente a cambios cualquier otra.

# Crear rama vacía desde cero (sin historial)

**Clona tu repo en una carpeta vacia, y crea nueva rama.**
```bash
git clone link-repo carpeta_con_nombre_de_nueva_rama
```

**Creamos rama vacia. Sin conexión con cualquier otra rama.**
```bash
git checkout --orphan nueva_rama
```
Esto crea una rama sin commit previo. Todos los archivos aca seran considerados nuevos. Por lo que puedes borrarlos.

**Una vez estemos en la nueva rama, hacemos un `rm` todo:**
```bash
git rm -rf .
```

**Después puedes crear tus propios archivos y hacer un commit**
```bash
echo "Nueva rama" > README.md
git add README.md
git commit -m "Primer commit de rama vacia"
```

**Agregamos la nueva rama**
```bash
git push origin nueva_rama
```
Listo.
# Clonar ramas
Se vera como clonar una rama, o todas las ramas de un repo.

# Sintaxis de clonar una sola rama
```bash
git clone --branch nombre-de-rama enlace-de-repo
```

# Sintaxis clonar todo las ramas del repo
```bash
git clone enlace-de-repo

git branch

pull --all
```

# Ejemplo
Supongamos que tenemos el repo `aguacate-rico`, este repo tiene las ramas `proteico` y `huesudo`.

Nomas queremos clonar `huesudo`.

Lo haremos de esta manera:
```bash
git clone --branch huesudo git://alimentos.com/aguacate
```

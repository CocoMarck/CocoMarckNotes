# Como lo uso yo

Yo actualmente soy nuevo usando `git` (2025-06-10). Yo ya tengo mis proyectos en el GitHub, con puro upload. Y tengo los proyectos localmente, y los proyectos locales tienen tan mas avanzados por lo que evito clonar del repo github.


Lo mejor y mas facil, es clonar el repo, y metele los archivos nuevos.
```bash
git clone https://github.com/usuario/repo.git ./repo


cp ./proyecto-local/* ./repo
```
Hacer el add y commit y ya esta.


# Establecer rama principal, por defecto git la mete como "master".
```bash
git config --global init.defaultBranch main
```
Esto es mas github, la rama global ahora es `main`. Puedes cambiar ese main por cualquier nombre que se te de la gana, eso si, sin espacios y caracteres locos, puras letras del alfabeto ingles. Por ejemplo; `wakanda_forever, salte-perro, ramaChida, ramen`. Procura usar nombres estandar, esta divertido poner nombres locos, pero a la larga es un problema.


## Crear una carpeta especial para los clones git  
Yo la llamo `github-clones`, github, porque mis repos estan alli.  

Esta carpeta la meto en mis proyectos de programación, alli esta lo local y los clones. Lo local pos todavia no lo meto en repos.

Ejemplo:  
```bash
Proyectos/Programacion
    github-clones/
    
    programa1/
    programa2/
```

Para indicarle especificamente a git donde meter todo pos seria asi:  
```bash
git clone [direccion-HTTPS] "Proyectos/Programacion/github-clones"
```

# Ejemplo de como uso git yo
```bash
git clone [direccion-HTTPS] "Proyectos/Programacion/github-clones"
# Clono el repo en la carpeta que me guta

cd "Proyectos/Programacion/github-clones/nombre-repo"
# Me muevo al repo

git status
# Esto nos sirve para ver que ta jalando el clon. 
# Ademas tambien sirve para ver en que rama estamos. En github por defecto es la main.

git add "archivo"
# Agrego lo que tenga que agregar

git commit -m "Agregando archivo que sirve para probar el git"
# Indico lo que eh hecho.


git push origin main
# Aca puse rama main, puede variar, la rama por defecto de github es main.
``` 

Ya finalmente el `push origin main`, probablemente te pedira Usuario y contra para permitir hacer cambios en el repo. GitHub te pide de contra un token. Hay otros sitios para guardar repos `git` que te piden una contra normalilla.




# Dejar clon local igual que en el repo remoto
Sirve para establecer todos los archivos igual al repo. No usar si tu ya has hecho tus cambios y no los quieres perder. Esto borra y cambia todo lo necesario para dejarlo igual al repo.
```bash
git fetch origin
git reset --hard origin/main
```




# Agrego lo que tenga que agregar y pongo el commit
```bash
git add ./core/prueba.py

git commit -m "Prueba"
```




# Borrar con git `rm`
Si quiero borrar un archivo, ya sea código viejo, documentación mal hecho o una carpeta que no se usa, puede usar `rm`, de esta menera:  
```bash
git rm archivo.txt Carpeta/codigo.py
```

Haces el commit: 
```bash
commit -m "Borrando archivos"
```

Y el push:
```bash
git push origin main
```

El `rm` borrara archivos de forma local y en el remoto repo.




# Crear ramas
[Enlace de tutorial](https://desarrolloweb.com/articulos/trabajar-ramas-git.html)  
Aca veremos como crear una rama, en un rapo git ya establecido.


Como ejemplo, crearemos una rama `docs`, esta nos servira para poner toda la documentación de nuestro programa, bastante util, y excelente para practicar usar ramas.




# Usar .gitignore
[Enlace de tutorial](https://www.freecodecamp.org/espanol/news/gitignore-explicado-que-es-y-como-agregar-a-tu-repositorio/)





# Inicializar git
*Nota: Hacer bash script para establecer usuario y correo de usuario de manera global en git*

Lo primero que tengo que hacer, es entrar a la ruta donde tenga el proyecto. Y inicializar git.

```bash
cd /ruta/proyecto

git init
```

## Lo conecto al repositorio github
```
git remote add origin https://github.com/usuario/repo.git
```

## Moverme a la rama adecuada, por defecto en mis proyectos GitHub es main.
**Para eso puedo renombrar la rama principal local de `master` (default) a `main`**  
```bash
git branch -M main
```

De lo contrario puedo intentar entrar directamente. Y si no jala, crear rama, y entrar en ella.
```bash
git checkout main
```




## Establesco que se permiten cambios a pesar de que no coincida el historial de cambios. (vaya la redundancia)

**IMPORTANE: Evitar forzar el push, puede borrame todo el proyecto en el repo**

```bash
git config pull.rebase false
```
Porque Git moderno (desde hace poco) exige que se defina una estrategia para reconciliar historias. Esto evita que Git aborte con ese mensaje de "Se debe especificar cómo reconciliar ramas divergentes".


Pull para treer y mezclar cambios. Y después resolver conflictos y hacer commit.
```bash
git pull origin main --allow-unrelated-histories

git push origin main
```

Se tienen que resolver los conflictos si es que existen. Los conflictos son archivos que no son exactamente iguales en el repo github y en el repo del pc (local). 

El pull permite establecer, los commit previametne agregados desde el upload, por lo que no deberia remplazarme los archivos locales, no mas los del `.git`








# Borrar `.git` por si quiero volver a empezar el proceso.
Nomas se tiene que borrar la carpeta `.git`.  
Primero que nada asegura te que exista `.git` en la ruta del proyecto. `ls ./.git`

```bash
rm -rf .git
```

Si pone que tiene permisos contra escritura, pos darle permisos de escritura:
```bash
chmod +rwx .git && rm -r .git
```



# Obtener las ramas disponibles en el repo local  
```bash
git branch
```

# Eliminar una rama en especifico
```bash
git branch -d master
# Aca se borra la rama master.
```




Referencias:
- [ARK Puroguramu](https://puroguramu.akcstudio.com/posts/como-encriptar-parte-de-un-repositorio-git/)

# Repo git encriptado
Esto jala en `2025`. Quien sabe en nuevas ver de `git-crypt`.

Se vera como hacer un repo github con todo encriptado. Vamos a depender de una programa. Sera el `git-crypt`.

En debian, con un `sudo apt install git-crypt` ta bien.

En windows, capaz con choco; `gsudo choco install git-crypt`.

# Crear repo o rama
Bueno ya tenemos hecho el git, y supongamos que se llama `privadote`

Adentro de la ruta `privadote` repo agregamos todo lo que queremos.

# Configurar `git-crypt`
Crearemos un archivo de texto llamado `.gitattributes`:
```bash
touch .gitattributes; nano .gitattributes
```

Editamos el archivo y agregamos esto:
```conf
# Para que encripte todo, menos este archivo.
* filter=git-crypt diff=git-crypt

.gitattributes !filter !diff
```
Con los `archivo-o-carpeta !filter !diff`, se ignora las cosas. No se escriptan.

Es necesario hacer que no se encripte `.gitattributes`.

# Inicializar `git-crypt`
Una vez terminado, en la ruta del repo hacemos un:
```bash
git-crypt init
```

## Guardar llave de acceso
El init anterior nos genero un `archivo.key` de acceso, el cual lo vamos a tener que usar para poder desencriptar.

Lo hacemos con un:
```bash
git-crypt export-key "/ruta/donde-guardar-contra/git-crypt-privadote.key"
```

# Agregar todo
Agregamos todo:
```bash
git add .
git commit -m "Repo privado"
git push origin main
```




# Desencriptar con `git-crypt`
Ahora hagamos un clone de nuestro repo.

No podras abrir nadota. Y eso es bueno.

Desde la ruta del clon del repo, para poder abrir todo, usaremos:
```bash
cd "/ruta/mi-repo-clon/"

git-crypt unlock "/ruta/donde-guardar-contra/git-crypt-privadote.key"
```

Ahora puedes trabajar con el repo privado. Fin, lo logramos.
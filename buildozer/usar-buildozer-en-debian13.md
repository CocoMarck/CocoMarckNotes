# Kivy APK con Buildozer en Debian 13
`2025-12-10`

Este tuto jala en `2025` vato. Si estas en otro año de seguro cambio el método, pero pos el metedo contener la distro que recomienda usar el compilador, pos siempre jala.

Debian 13, no tiene forma facil de instalar `bulidozer`, la verdad no es como que haya un script buenorro que lo haga. Lo mejor es hacerlo bajo ubuntu 20.04. Pero pos nimodo que te intales el ubuntu, no no que hueva, uno ta feliz con lo que tiene, pero si puedes usar un contenedor rico, pos ta bien.

Usaremos **podman**. Este contendra a ubuntu 20.04. Y no ejecutes el `podman` como `sudo` vato, nomas en normal, a pelo, y si no tienes, pos a cabezona.

# Alistar podman
Primerazo en debian 13, instalar podman:
```bash
sudo apt update; sudo apt search podman; sudo apt install podman
```
> Aca si `sudo`, porque si no, no se instala.

Checamos que jale:
```bash
podman --version
```

# Alistar proyecto con git
Ahora muy imporante vato, entra al dir de tu app loca.
```bash
cd /dir/de/mi/app
```

Y pos asegurate de que tu app tenga git, y minimo un commit. Esto es necesario.
```bash
git status
```

Si no se ve nadota, haz el init, haz el add, y haz el commit.
```bash
git init; git add .; git commit "Primir commit vato"
```
> Y no esta de mas decir, que tienes que ya tener configurado tu global user y tu global email.

Si no hicites esto aca, igual lo puedes hacer desde el ubuntu contenido, pero como que da mas hueva la verdad.


# Inicializar podman con el ubunto loco
Bueno, una vez en el directorio del proyecto entramos con el podman chidote.

```bash
podman run -it --rm \
  -v "$(pwd)":/home/user/app:Z \
  ubuntu:20.04 \
  /bin/bash
```
> Ya dentro del contenedor, somos `root`, por lo que no usaremos `sudo` en los comandos de instalación.

Aca ya dentro del podman, hacemos un
```bash
ls /home/user/app
```

Y si se ven los archivitos de tu app, pos ahora si continuamos.

## Instalamos las dependencias para compilar aca bien perron.
```bash
apt update

apt install -y git zip unzip openjdk-17-jdk python3-pip autoconf libtool pkg-config zlib1g-dev libncurses5-dev libncursesw5-dev libtinfo5 cmake libffi-dev libssl-dev

pip3 install --upgrade buildozer Cython==0.29.33 virtualenv
# El buildozer y sus compaz.
```

Y ya de paso `nano`; que nos va a servir vato:
```bash
apt install nano
```

## Nos movemos al directorio de nuetra app jejej.
```bash
cd /home/user/app
```
> De seguro este no es el directorio real de nuestra app, pero es porque es el directorio del contenedor a tu app, el tiene el directorio de tu app con esta ruta. Un enlace simbolico. Nada de brujeria, es tecno, y no la musica.

Da un git status vato
```bash
git status
```
Y si muestra algo, nada de error syntaxis o algo así, pos todo clean, podemos seguir.
> Acuerdate de los primeros pasos, el commit es necesario vato.

Inicializamos el buildozer vato
```bash
buildozer init
```

Vemos si esta el archivo
```bash
cat buildozer.spec
```

Y podemos editar el `spec` con nano, alli pos tu sabres que metes vato, y si no sabes investiga, pero para hacer una compilación de test pos no hace falta indagar mucho, lo puedes dejar así.

Nomas te digo que el parametro `android.archs = arm64-v8a, armeabi-v7a`, indica para que arch de arm compilara, para la 32 o pa los 64. 

Algo equivalente a `arm64-v8a, armeabi-v7a`, seria una apk pa 64(`arm64-v8a`) y 32(`armeabi-v7a`) bit. La de 32 bits debe jala pa todos y la de 64 nomas para esos de 64, bien elitistas, bueno no, tambien es por tecno, nada que ver con ser elitista jejej.

Bueno dicho eso, sera tu decisión editar el archivito:
```bash
nano buildozer.spec
```
Que dicho sea de paso; para una compilación seria, si tendras que editar, pero nada loco, nomas el `name`, la `ver`, etc. Puros datos no relacionados con la compilación en si.

### A compilar
```bash
buildozer android debug
```

Ahora espera, de seguro veras warnings, pero no te asutes, no explotara. Si ves contratos locos que sepa que dicen, di que si vato. Nada puede malir sal.

Igual si das que no, pos no compila nada. Ese gugul es bien canijo, like microsoft.

Una vez diga `success`, o `done!`, o algo así, pos ya jalo todo clean, puedes ver el archivito asi:
```bash
ls ./bin/
```
> Asumo que estas en el directorio de tu app.

Y pos es todo, antes de salir verifica en tu gestor de archivitos si esta tu apk compiladita, y pos ahora si, pasa un:
```bash
exit
```

Y mision cumplida. Joer que buena es la vida.
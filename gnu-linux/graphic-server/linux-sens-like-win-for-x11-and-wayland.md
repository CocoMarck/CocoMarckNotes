#    Sensibilidad de Win a GNU Linux    #

# X11 Xfce4
Para quitar la aceleracion en GNU Linux, Debian 12, X11, Xfce4, LightDM:
Crear el archivo de texto `50-mouse-acceleration.conf`, en la ruta `/etc/X11/xorg.conf.d/`. Se requerirarn permisos de sudo/administrador/root.

Utilizaremos nano para hacerlo (se puede usar cualquier editor de texto que permita sudo). Comando: 
```bash
sudo nano /etc/X11/xorg.conf.d/50-mouse-acceleration.conf
```

El archivo contendra lo siguiente:
```bash
Section "InputClass"
    Identifier "Mouse Settings"
    MatchIsPointer "yes"
    #Driver "libinput"                     # Asegúrate de usar libinput como controlador
    Option "AccelerationProfile" "-1"     # Desactiva la aceleración
    Option "AccelerationScheme" "none"    # Utiliza un perfil lineal
    #Option "AccelProfile" "adaptive"      # Multiplica la sens dependiendo la velocidad del mouse
    Option "AccelSpeed" "0"               # Sensibilidad (puedes probar valores entre -1 y 1, a mi me gusta -0.72)
EndSection
```



Lo guardamos y probamos reiniciando el entorno grafico o el pc.
Reinciiar el entorno grafico: `sudo systemctl restart lightdm`
Reiniciar el PC: `systemd reboot`


Puedes verificar que si jala este archivo de configuracion, si te devuelve algo este comando: 
```bash
cat /var/log/Xorg.0.log | grep "Mouse Settings"
```


Existe para xfce4, la app `xfce4-mouse-settings`, la cual puede sobrescribir el `AccelSpeed`, donde 0 seria `-1`, `5` seria `0`, y `10` seria `1`. Yo la pongo
entre `1.2` a `2`. Prefiero `1.4`, que serian `-0.72`.



Para ver la sens actual con:
`xinput list`
Devuelve los id de los perifericos, buscar el mouse.

`xinput list-props [id]`
Devuelve la config actual del mouse.
"libinput Accel Speed" Seria la velocidad actual de la sens





# Wayland Plasma 6

Cambiamos de la sens del mouse, y desactivamos la acleración del mause desde la aplicación de configuración. Para que lo puedas hacer, asegurate de que Plasma 6 esta bien instalado.

La sens por defecto es 0, y la acelaración esta activada por defecto.

## Ver mouses con xinput
Primero vemos los mouses: `xinput --list`

Copiamos el nombre de nuestro mouse, que sera un nombre no muy descriptivo, algo asi como `xwayland-pointer:10`. Lo ponemos entre comillas.

Obtnemos los datos del
```
xinput --list-props "xwayland-pointer:10"
```



## Archivo local de configuración de mouse en Plasma 6
Bueno, el que controla ya todo chido, es el archivo `$HOME/.config/kcminputrc`

Leer archivo:
```bash
cat $HOME/.config/kcminputrc
```

Este contendra algo asi:
```
[Libinput][9354][23343][Mouse Chido]
PointerAcceleration=0
PointerAccelerationProfile=1
ScrollFactor=1

[Libinput][9639][64112][Otro mause chido]
PointerAcceleration=0.000
PointerAccelerationProfile=1

[Mouse]
X11LibInputXAccelProfileFlat=true
XLbInptPointerAcceleration=-0.72
```

`2025-08-30`
Mi sens parecida a Xfce X11, para Wayland Plasma 6 es: `-0.35`


Fijate bien, en KDE plasma 6, es importante que tambien agreges esto: Asi la config de X11 tambien jalara, algunas apps jalan con X11.
```
[Mouse]
X11LibInputXAccelProfileFlat=true
XLbInptPointerAcceleration=-0.72
```

# Videojuego LilyPond

Utilizar un lib de python para interactuar con archivos `midi`. Los archivos `midi` contienen todo lo necesario para reproducir la musica. Tempo, tiempo de notas, notas, acordes, etc.

Con `lilypond` generamos el `midi`, con el midi hacemos las canciones para el game.


Las canciones deben ser `midi`, se utilizara un reproductor midi para python. 

O como alternativa, se necesitara del `midi` y un `ogg` para reproducir la concion, la concion se identificara con que ambos archivos sean del mismo nombre. Por ejemplo:
```
cancion.midi
cancion.ogg
```
Así no se batalla tanto con la sincronización del audio.

Utilizar `pygame`, para mostrar el game. Este motor de juego no puede reproducir midi, pero si `ogg`, entre otros archivos de audio, la complejidad radicara en sincronizar todo, esa inforamción de sincronización la proporcionara el `midi`.
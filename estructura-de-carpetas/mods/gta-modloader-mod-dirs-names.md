# GTA modloader mod dir names
Directorios escritos en `kebab-case` y en ingles.

Esta estructura se probo en `gta sa`, pero cero que deberia funcionar bien para cualquier gta.

## Titulares
- `anim`: Solo mods relacionadas con las animaciones. No solo animaciónes de las personas, sino tambien de los vehiculos, de los objetos en general.
- `ai`: Solo mods relacionados con el comportamiento de los npc.
- `audio`: Solo mods relacionados con el audio. Su control, su reproducción. Incluyendo a los nuevos audios.
- `debug`: Mods para hacer debug in game.
- `graphics`: Mods relacionados con los graficos del juego.
- `interface`: Mods relacionados con la interfaz del juego.
- `funny`: Mods divertidos, sin relación alguna con el juego.
- `map`: Mods relacionados con el mapa del juego.
- `multiplayer`: Solo mods relacionados con multiplayer.
- `optimization`: Mods relacionados con la optimización del juego.
- `physics`: Mods relacionados con la fisica del juego.
- `settings`: Solo mods relacionados con la configuración del juego.
- `object-mechanics`: Mecanicas a objetos del juego, ya sean vehiculos, armas, etc.

## Sub titulos
Estos directorios estaran dentro de un directorio maestro. Se espera que no se necesite nombrar ningun subdirectorio como directorio maestro.
- `damage`: Mods relacionados con el daño.
- `aim`: Mods relacionados con el apuntado.
- `player`: Mods unicamente ralacionados con el jugador. Si tiene efecto en peds, evitar este nombre.
- `clothes`: Mods relacionados con la ropa del jugador.
- `camera`: Mods relacionados con la camara.
- `vehicles`: Mods relacionados con los vehiculos.
- `weapons`: Mods relacionados con las armas.
- `missions`: Mods relacionados con las misiones.
- `gangs`: Mods relacionados con las pandillas o mafias.
- `weather`: Mods relecionados con el clima del juego.
- `textures`: Texturas, modelos, y colliders.
- `effects`: Efectos ocasionados por "x" motivo.
- `peds`: Mods unicamente relacionados con los npc, evitar si tambien aplica al player.
- `radio`: Mods relacionados con el radio. No hace falta tener relación directra con los vehiculos.
- `music`: Mods relacionados con la reproducción de musica.

---

# Nombrado de directorios
- Prefix: `title-subtitle-modname`
Puede aver mas de un subtitle, o ninguno. Se vale poner el mod name como `big-mod-name`.

## Ejemplos:
- `anim-player-open-door`
- `anim-player-weapons`
- `ai-gangs-better-movement`
- `audio-music-mpmv5`
- `graphics-effects-next-gen`
- `graphics-effects-camera-pointfix`
- `graphics-effects-camera-dynamicfov`
- `debug-noclip`
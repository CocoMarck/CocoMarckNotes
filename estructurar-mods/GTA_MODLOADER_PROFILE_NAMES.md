# Grand Theft Auto Nombres de perfiles para modloader
Nombres de perfiles en `kebab-case`, o `PascalCase`. Kebeb, nomas por comodidad, `PascalCase`; Es para mantener la estrucutra coherente. Nombres en ingles.

> Los el archivo `modloader.asi` para gta sa, no le importa el formateo del nombre del perfil, por lo que se puede escribir de muchas maneras.

## Perfiles de dependencia
Estos perfiles, no es para usarlos para jugar, son para usarlos para un perfil que los heredara.
- `optimization`: Solo mods de optimización.
- `graphics`: Mods graficos y relacionados con efectos. FX, shaders, specs, weather, etc.
- `textures`: Mods que remplazan texturas. No relacionadas con la interfaz.
- `physics`: Mods relacionadas con fisicas del juego.
- `interface`: Mods relacionados con la interfaz.
- `ai`: Inteligencia artificial, npc, traffic.
- `settings`: Mods que agregan o remplazan configuraciones del juego. Controles, formas disparar, etc.
- `mechanics-of-objects`: Mods que cambian o agregan mecanismos a objetos del juego. Ya sean armas, vehiculos, y etc.
- `debug`: Mods para hacer debug del juego. No mods ridiculos, solo mods para game testing.
- `funny`: Mods sin relacion alguna con nada.
- `new-map`: Mods que son un nuevo mapa. Remplazo total del mapa.

Estos son prefijos, por lo que puedes agregar texto, para diferenciar funciones, ejemplos:
- `graphics-next-gen`
- `textures-funny`

De preferencia que ese añadido, sea el nombre de un juego. Estos perfiles depenencia, tambien pueden tener dependencias.

## Perfiles de juego
Estos perfiles, no deben ser dependencia de nada. Solo deben usar dependencias.

Para mentener coherencia, usar prefijo `game-` seguido del nombre del juego.
Ejemplos:
- `game-brazil`
- `game-gta-sa-improved`
- `game-gta-sa-zombies`
- `game-gta-sa-snow`
- `game-gta-sa-next-gen`
- `game-lorts`

Es recomendable usar el nombre `gta-sa`, para todos los juegos que aun son `gta-sa`, pero para los que se les cambie la historia o mapa, es recomendable poner otro nombre.
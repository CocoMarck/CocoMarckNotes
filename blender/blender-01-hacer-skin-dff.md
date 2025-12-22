# Blender hacer skin DFF para 3d GTA games
Primero que nada necesitamos del plugin para Blender [DragonDFF](https://github.com/Parik27/DragonFF).

Tambien vamos a necesitar de un `skin.dff`, que usaremos como base. Recomiendo uno con las dimesiones del player.

# Importamos el skin base que usaremos

Es altamente recomendable, poner el esqueleto del skin base, en vista al frente.

Seleccionamos nuestro modelo/skin hecho, y lo acomodamos con el esqueleto.

> Es recomendable no mover el esqueleto, adapta tu modelo al esqueleto, no al esqueleto a tu modelo.

![image-skin](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.imgur.com%2Fffphqpt.png&f=1&nofb=1&ipt=1b6fa290000ebbb709ef493117b247a59140d868f90239721ba86a76722c052e)

# Esqueleto
Una vez acomodado, brazos, piernas y todo. Ahora nos ponemos en `modo objeto`, y seleccionamos nuestro skin, y luego el esqueleto de la skin base. Una vez seleccionado ambos (y en ese orden), precionamos `Ctrl + p`, y establecemos algo que diga algo asi como; `agragar con influencias automaticas`.

![image-esqueleto](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%2Fid%2FOIP.4gGinVO9cc0lDkBNyRZJIQHaEK%3Fcb%3Ducfimg2%26pid%3DApi%26ucfimg%3D1&f=1&ipt=4628a4fc5d2b60c63e09e509930c52d882a984e9ba53ea4761a1e8991b33b1cd&ipo=images)

Una vez hecho, seleccionamos el esqueleto y nos ponemos en modo pose y movemos el esqueleto, y virificamos que se mueva nuestro modelo junto al esqueleto.

![image-pose-mode](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Frekovalev.site%2Fwp-content%2Fuploads%2F2024%2F01%2Fblender_pose_mode_example.gif&f=1&nofb=1&ipt=42f8650ff73c9961a69ff9156a4d676708c8367f6ceedd37cfbb05487be2c0ed)

Si se mueve pos ta bien. Podemos pintar influensias del modelo respecto al esqueleto. Ve videos de como hacerlo. `Blender; Como pintar influencias del modelo`.

![image-pintar-influencias](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%2Fid%2FOIP.7jatw9nKA-YdCZeOPyfoCgAAAA%3Fcb%3Ducfimg2%26pid%3DApi%26ucfimg%3D1&f=1&ipt=d7c6dd33f76d25d60ff2de65cbfaa56ec4ea148f2520929c8e559aa42c4b944e)

# El otro modelo base
Ahora lo que tenemos que hacer, entrar en `modo objeto`, seleccionar el modelo de nuestra skin base, entramos en `modo edición`, y seleccionamos todas las caras, con `Ctrl + A`, o como sea, pero selecciona todas las caras.

Despues entra en `modo objeto`, selecciona tu modelo, y entra en `modo edición`, y asegurate de que no haya ninguna cara seleccionada, nadota seleccionado.

Finalmente entra en `modo objeto`, selecciona primero tu modelo, y despues el modelo base. Junta modelos, con `Ctrl + J`. Entra en modo edición, y borra todas las caras del modelo base.

> El modelo base deberia tener todas las caras seleccionadas, y nuestro modelo deberia estar sin ninguna seleccionada.

![image-join](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fgamedevtraum.com%2Fwp-content%2Fuploads%2Fes%2Fdiseno-grafico%2Fdiseno-3d%2Fblender-2-8%2Fcomo-unir-y-separar-objetos-en-blender%2Fblender-unir-objetos-join.webp&f=1&nofb=1&ipt=1695b496fc98d3a84263807721f0cda6107d3513b4d05110309497e8c57168c9)

# Los mapas UV
Una vez hecho todo lo anterior, veras que tus `MapasUV`, pos como que ya no estan. Pero si estan. Simplemente entra en modo objeto, ve los MapasUV, y elimina `FloatUV` o como se llamen los UV de tu modelo base, y solo deja los MapasUV de tu modelo.

Los materiales dejalos igual, incluso si hay muchos que nada que ver. Esos son para que no de crash el game.


# Exportar
Bueno, puedes exportar a DFF de una, solo asegurate de no exportar junto con camera, o otras cosas que no sean tu modelo ya adaptado para 3d gta games.

La mejor manera de hacerlo, es dando click derecho al conjunto de tu skin; malla, esqueleto, y propiedades. Y seleccionar la opción que diga algo así como: `Exportar como DFF`, normalmente esta mero abajo.

Para probar, no deberias necesitar un `TXD`, sin `TXD` jala, así que pruebalo de una solo con el `DFF`, ya cuando termines haz el `TXD`

# El TXD
Asegurate que así como nombraste la imagen a usar, para tus mapas uv, así llamar a las imagenes dentro del TXD, o si no no detecta nadota.



# Conclusión
Primero haz tu modelo; Y si lo quieres hacer especificamente para gta, asegurate de hacerlo en la pose del esqueleto base, porque si lo haces por ejemplo en `T pose`, vas tener que acomodar el modelo al esqueleto, y eso da mucha hueva. Haz los mapas UV de tu skin de una, solo asegurate de que cuando termines este proseso, solo esten tus mapas UV, y no otros.

Y el tipo de pose que manejan los 3d gta games, es el `A-Pose`.

![image-a-pose](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.renderhub.com%2Fdeep3dstudio%2Fhandsome-young-man-in-a-pose-337%2Fhandsome-young-man-in-a-pose-337-03.jpg&f=1&nofb=1&ipt=81bb944ecb1a5ecf28b296dbedd7f8f6d7d05781b2753b27c98c88036a656cb0)

Pero igual guiete por el modelo base que uses, porque el A pose de gta, como que ta medio raro.
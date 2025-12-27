# Blender | Como hacer arma dff para gta sa
Este tutorial deberia jalar para cualquier gta del universo 3d.

Bueno, primero importamos el `dff` del arma que queremos remplazar.
Usaremos de ejemplo la `ak47.dff`. Si eres nuevo en esto, te recomiendo hacer el tuto con un `ak47.dff`, así evitaras confisiones.

Esta contendra lo siguiente:
```config
ak47.dff                # Carpeta irrelevante, solo contiene lo importante.
    ak47                # dummy importante, no borrar. Remplazar.
        ak47            # Malla/modelo.
            ak47.0      # Material/Textura del modelo
        Modificadores   # EdgeSplit, modificación del dummy. No borrar, dejar igual.
        gunflash        # dummy que dejamos igual. Se puede borrar.
```

# Remplazar malla.
Bueno, primero que nada tenemos que posicionar nuestro modelo ya terminado justamente como esta el `ak47.dff`.

## Seleccionar caras del modelo base
Despues de eso seleccionamos nuestro modelo en modo edición, y nos aseguramos que este sin nada seleccionado.

Despues entramos en modo edición al modelo `ak47`, y seleccionamos todo con `A`.

## Unir nuestro modelo al model base
Entramos en modo objeto, dejamos precionado `ctrl`, y seleccionamos primer nuestro modelo, y despues el modelo del dff `ak47`. Unimos con `ctrl+j`.

Despues entramos en modo edición, y borramos las caras del `ak47` (previamente seleccionadas).


# Asegurarse tener los nombres adecuados
En el caso de `ak47.dff` el nombre del dummy sera `ak47`. El nombre de los material o materiales, sera `ak47.0`. Si tu skin tiene varios materiales pos `ak47.1`. Nomas sumale.
```conf
mi-skin-terminadote     # Carpeta
    ak47                # Dummy
        ak47            # Malla
            ak47.0      # Materiales
        Modificadores
            EdgeSplit
        gunflash        # Otro dummy, dejalo igual
```

Tiene que verese de esa manera. Si se ve por ejemplo asi:
```conf
mi-skin-terminadote     # Carpeta
    mi-skin             # Dummy
        model           # Malla
            texture     # Materiales
        Modificadores
            EdgeSplit
        dummy-mio
```

Esto no jalara.

# Exportar
Ya cuando tengas todo terminado, nombres adecuados, modificadores adecuados, materiales adecuados. Procederemos a exportar el `dummy`, de nuestro skin terminado.

En el caso del `ak47`, pos el dummy que se llame así, le damos click derecho, `exportar como DFF`. Y fin.

# Conclusión
Los nombres, los materiales, y el modificador. Es lo que necesitas para poder exportar un `arma.dff`. El nombre del arma que elijas remplazar, este sera el nombre prefijo de los materiales, y dummy: `nombre.0`, `nombre`. Solo se usara el modificador `EdgeSplit`, y no lo apliques, solo añadelo, pero como el skin base ya lo debe tener, pos solo dejalo así.

No esta de mas decir, que el `gta_sa`, no puede tener armas de mas, son limitadas, así que puedes crear `arma-nueva.dff`, pero pos no jalara. Solo con mods, se puede añadir armas adicionales.
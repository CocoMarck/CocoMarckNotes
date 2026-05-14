## Comentario 1
Añadi opción `Create` en arbol; con click derecho. Seleccion de vertices/nodos de modelo, y guardado (solo en memoria) en un diccionario `Dictionary <int, FeNode>`. Donde `FeNode` es el objeto tipo nodo que maneja PrePoMax.

Para la selección de nodos, se utilizo el `FrmQuery.cs`. Pero pienso hacer otro formulario para esto (parecido a `FrmNodeSet.cs`). Ya vi como almacenar y obtener datos del `archivo.pmx`, solo tengo que usar los métodos, atributos, y etc, en `Controller.cs`, este se encarga de todo.

- [Donde y como se guarda el `.pmx`](https://github.com/CocoMarck/CocoMarckNotes/blob/tutorial/prepomax/prepomax-10-save-to-file.md)
- [PrePoMax Node Sets](https://github.com/CocoMarck/CocoMarckNotes/blob/tutorial/prepomax/prepomax-11-node-sets.md)
- [Evento en tree](https://github.com/CocoMarck/CocoMarckNotes/blob/tutorial/prepomax/prepomax-12-evento-en-node-de-tree.md)

> ChatGPT, me ayudo a obtener la información.

---
## Comentario 2
- Cree un formulario custom de selección de nodos. Basado en FrmQuery (pero independiente de este)
    `PrePoMax/FrmCustomSelect.cs`
- Integrado al Controller.
- Capaz de recibir picks reales del viewport,
- Hacer highlight, annotations, y guardar `FeNodes` en memoria.

[Documento sobre lo hecho](https://github.com/CocoMarck/CocoMarckNotes/blob/tutorial/prepomax/prepomax-12-evento-en-node-de-tree.md)

> Esta vez ChatGPT se confundio igual que yo. Pero ya entendi un poco mas sobre el `controller`.

En el video se ve como sale en el output, los mensajes
```
Selection with `frmCustomSelect` and Query funcs
Count of selected nodes: `1`
```

El contador, es un `dictionatry.Count`. Este almcena id de nodo (como key) y FENode como value. Por lo que esta listo para renderizar, y guardarse.

> A primera vista parece que no avance, porque pase de usar Query Form a hacer el mio, pero es gran cambio. Ya lo que sige es almacenar data, y renderizar chido mis puntitos.

---

## Comentario 3
Ahora el formulario `FrmCustomSelect.cs`. Puede guardar y obtener datos en el `file.pmx`. Por lo que ya se guardan los nodos seleccionados. Tema guardado de datos; Todo se limito a usar el `Controller` de PrePoMax.

Documente como fue hecho: [Custom select nodes save in pmx](https://github.com/CocoMarck/CocoMarckNotes/blob/tutorial/prepomax/prepomax-14-custom-select-nodes-save-in-pmx.md).
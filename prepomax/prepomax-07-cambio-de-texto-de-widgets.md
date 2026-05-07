### Selección de vertices del modelo.
Esto esta en Query Form: 
```bash
ls .\PrePoMax\Forms\62_Query\
```

```bash
cat .\PrePoMax\Forms\62_Query\FrmQuery.cs
```

Opción `"Vertex/Node"`.

> Creo que esto sera clave para saber donde esta la función que selecciona vertices, para despues obtener esa data, para obtener las trayectorias.

> Probablemente `FrmQuery.cs` no contiene toda la lógica geométrica, pero sí puede indicar qué método se ejecuta cuando el usuario consulta o selecciona un `Vertex/Node`.

**Parece ser que se usa `CaeGlobals.vtkSelectBy.Node`.**. 

- `.\CaeGlobals\Selection\Enums\vtkSelectBy.cs`: solo es un enum, pero tiene comentarios que podrian dan información.
    ```csharp
    // Has extension: IsGeometryBased
    ``` 
- `.\CaeGlobals\Selection\SelectionNodeMouse.cs`: este podria contener mas información.

```powershell
Select-String -Path .\CaeGlobals\**\*.cs -Pattern ".Node";  Select-String -Path .\CaeGlobals\**\*.cs -Pattern "SelectBy"
```
> Busca coincidencias de string en `files.cs`, sobre menciones a `.Node` y "SelectBy".

**Conclusion: El code `.\CaeGlobals\Selection\SelectionNodeMouse.cs` es clave.** 

---
## Donde estan los textos de los forms
```powershell
Select-String -Path .\PrepoMax\Forms\*.cs -Pattern ".text = "
```

Textos aca: `PrepoMax\Forms\FrmMain.Designer.cs`
    Para probar, remplaze el valor de estos `this.tsmiTools.Text`, `this.tsbTools.Text`, por `"Herramientas chidas"` 

    - Aca pondre el texto de `"trayectoria"`

Los splash, `PrepoMax\Forms\FrmSplash.Designer.cs`. Algo así como ventanas flotantes.
    - Remplaze el valor de `this.lHelp.Text`, por `"PrePoMax es un preprocesador y postprocesador gráfico para el solucionador FEM gratuito CalculiX."`

Ya estudie un poco el código del PrePoMax. Solo por probar remplaze texto, y compile. Cambie  `Tools` Por  `Herramientas`, y  el texto del About.
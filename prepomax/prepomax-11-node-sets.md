# Prepomax Node Sets
`Controller.cs`
```csharp
_model.Mesh.NodeSets
```

```csharp
public string[] GetAllNodeSetNames()
{
    return _model.Mesh.NodeSets.Keys.ToArray();
}
```

## `PrePoMax/Forms/23_NodeSet`
- `FrmNodeSet.cs`: Formulario UI para crear editar NodeSet.
- `ViewNodeSet.cs`: Wrapper visual/datos que usa la UI.

`PrepPoMax/Command/0050_Model/13_NodeSet`

En el `Controller.cs`. Todo se conecta en el `_model.Mesh.NodeSets`.

Los NodeSets, se guardan como diccionario dentro del mesh. `_model.Mesh.NodeSets`.

## Funciones a usar en `Controller.cs`
`public void SetSelectItemToNode()`, y ` public Selection Selection`

## Archivos para usar `NodeSets`
```
PrePoMax/Forms/23_NodeSet/FrmNodeSet.cs
PrePoMax/Command/0050_Model/13_NodeSet/CAddNodeSet.cs
PrePoMax/Controller.cs
CaeMesh/FeMesh.cs
CaeMesh/FeNodeSet.cs
```
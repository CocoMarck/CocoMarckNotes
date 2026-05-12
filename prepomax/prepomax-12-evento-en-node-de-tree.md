# Evento en nodo de tree | Custom node option

## Simplemente al darlo doble click
**Esto sucede en el `ModelTree.cs`**

Adentro del `private void cltv_MouseDoubleClick`, en el `if (selectedNode.Tag == null)`, agregar mero arriba este if:
```csharp
if (selectedNode.Name == "customSubNode")
{
    Debug.WriteLine("Evento customSubNode");
    MessageBox.Show("Evento customSubNode");

    _doubleClick = false;
    return;
}
``` 
> El `Name`, debe ser el de tu nodo, igualito.

---
## Create option | Al darle click derecho.
**Esto sucede en el `ModelTree.cs`**

El prepomax ya tiene `Create` option contemplado, por eso no es necesario ponerle nombre al boton.

Y recuerda que `Name` es el de tu `TreeNode`.

Adentro de `CanCreate(TreeNode node)` agrega antes del `return false`. Un else if.
```csharp
else if (node.TreeView == cltvCustomTab && node.Name == "customSubNode") return true;
```

Adentro de `private void tsmiCreate_Click(object sender, EventArgs e)`, despues de `TreeNode selectedNode = tree.SelectedNode;`, agregamos este `if`
```csharp
if (selectedNode.Name == "customSubNode")
{
    Debug.WriteLine("Custom create option");
    MessageBox.Show("Custom create option");
    return;
}
```

---
## Evento en `FrmMain.cs`, para usar en `ModelTree.cs`
En `FrmMain.cs`, creamos un atributo al `_modelTree`. Como queramos llamar al evento. `CustomEvent`.
```csharp
_modelTree.CustomEvent += CustomMoment;
```

Adentro del `FrmMain.cs`, creamos el evento. Como un `public void`.
```csharp
private void CustomMoment()
{
    MessageBox.Show("Esta funcionando");
}
```

Adentro de `ModelTree.cs`, junto a los otros `public event Action`, poner:
```csharp
public event Action CustomEvent;
```
> Al CustomEvent.

Y simplemente lo invocamos así:
```csharp
CustomEvent?.Invoke();
```

# Agregar padre a Arbol
## `new TreeNode`
### `PrePoMax\Forms\21_FEModel\FrmCalculixKeywordEditor.cs`


---
## `AddTreeNode`
### `UserControls\ModelTree.cs`
En este código se agregan los nodos del arbol.

En la función `AddTreeNode`. Adentro del `try`, adentro del `elif if (item is MeshPart)`, despues de lo demas agregar:
```csharp
// Padre custom
TreeNode miNodo = new TreeNode("Mi nodo");
miNodo.Name = "MiNodo";
miNodo.Tag = item;
node.Nodes.Add(miNodo);
// Padre custom
```
> Posiblemente esto no haga nada.

En el evento `TreeNode nodeToadd`, adendtro del `foreach (var key in list)`, antes del `SetNodeStatus(nodeToAdd);`
```csharp
// Padre custom
if (dictionary[key] is MeshPart)
{
    TreeNode miNodo = new TreeNode("Mi nodo");
    miNodo.Name = "MiNodo";
    miNodo.Tag = null; // mejor null para que no lo trate como Part
    nodeToAdd.Nodes.Add(miNodo);
}
// Padre custom
```
> Esto si es lo que jala.

#### Hijo de Model
Primeramente, en la clase `ModelTree : UserControl`. Haremos todo.

Inicializamos estas variables, con las demas.
```csharp
// Padre custom
private TreeNode _miNodo;
private string _miNodoName = "Mi nodo";
// Padre custom
```
> De preferencia al final de las otras variables.

En el constructor `public ModelTree()`.
```csharp
// Padre custom
_miNodo = new TreeNode(_miNodoName);
_miNodo.Name = _miNodoName;
// Padre custom
```
> Antes de Results. Después de inicializar los demás nodos del árbol.

Cerca del constructor, dentro del `public void Clear()`, antes del `cltvModel.Nodes.Add(_analyses);`, agregar:
```csharp
// Padre custom
_model.Nodes.Add(_miNodo);
// Padre custom
```
> Que este con los `Nodes.Add`.

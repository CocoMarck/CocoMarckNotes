# Custom Select Nodes Form Save in PMX
Primeramente mencionar que esto fue satisfactoriamente sencillo. Lo dificil fue encontrar las funciones necesarias. Pero todo se resume a que controller ya hace todo. Y que `FENodeSets` ya serializa todo (o quizas es el controller, usando este). Pero el punto es que no tuve que hacer nada loco, como serializar datos. Eso ya lo hace el PrePoMax controller.

Solo cree un formulario, no lo estructure en designer, etc, evite abstracción por motivos de debug/testing.

## `frmCustomSelect.cs`
### Importe las librerias necesarias:
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaeGlobals;
using CaeMesh;
```
> Algunas de estas no las uso, pero pueden servir para despues.

### Cree el formulario
```csharp
// custom select form
namespace PrePoMax.Forms
{
    public partial class FrmCustomSelect : UserControls.PrePoMaxChildForm
    {
        // Code
    }
}
```
> Lo guarde en `PrePoMax/Forms/ZZ_CustomSelect/frmCustomSelect.cs`

---

### Establecemos las variables/widget/controller
```csharp
// Variables
private int _numOfNodesToSelect;
private double[][] _coorNodesToDraw;
private Controller _controller;
        
// widget moment
private System.Windows.Forms.Button btnClose;
private System.Windows.Forms.Button btnSelectNodes;

// Callbacks
public Action<string> Form_WriteDataToOutput; // Para escribir datos en ventana de salida
public Action<object, EventArgs> Form_RemoveAnnotations;

// Para guardado en PMX file
private FeNodeSet _customNodeSet;
```
- `_numOfNodesToSelect`: La cantidad de nodos por seleccionar por ahora solo es uno, seleccionar mas de uno, puede complicar las cosas, requirira mas funciones.
- `_coorNodesToDraw`: Las coordenadas a dibujar.
- `_controller`: Se encarga de meter datos en el PMX, y bastantes cosas mas.
- `Form_*`: Estas son para escribir datos en el output del PrePoMax. No hay mucho misterio, es para Debug.
- `FeNodeSet`: Objeto almacenador de nodos, listo para controller.

---

### Constructor `FrmCustomSelect()`
No hay mucho misterio, se inicializan las vars, y widgets.

Solo mostrare como se inicializan los objetos y vars no genericos del WinForms. 
```csharp
_customNodeSet = new FeNodeSet("CustomSelection", null);
_numOfNodesToSelect = 1; // Este form, solo jala con uno, pero puede que jale despues con mas.
```
> Tambien inicialize todos los widgets, so pos, su size, agregarlos, todo eso. 
- El nombre del `FeNodeSet` es importante, este se usara para obtener su data.

---
## Eventos 

### `PrepareForm`
Funcion public void. Pide de paremetro un objeto `Controller` de PrePoMax. Este obtiene data del controler. Y obtiene data del PMX, es a prueba de crash. Momento arquitectura de app pro. PreProMax :D
```csharp
public void PrepareForm(Controller controller)
{
    // Preparar controlador para formulario.
    _controller = controller;
    _controller.SetSelectByToOff();

    // PMX | Intentar recuperar NodeSet guardado
    if (_controller.Model.Mesh.NodeSets.ContainsKey("CustomSelection"))
    {
        _customNodeSet = _controller.Model.Mesh.NodeSets["CustomSelection"];

        SetDrawDataOfSelectedNodes();
        Highlight();

        Debug.WriteLine("CustomSelection cargado desde PMX");
    }
}    
```
> Aca ya se usa el nombre del `FeNodeSet`.
- `SetDrawDataOfSelectedNodes`: Como su nombre lo indica, obtiene la data para poder dibujar los nodos. Especificamente las coordenadas xyz.
- `Highlight`: Renderiza con las coordenadas antes mencioandas. Usa controller.

### `FrmCustomSelect_FormClosing`
Simplemente oculta el formlario

### `FrmCustomSelect_VisibleChanged`
Permite visualizar cambios. Utiliza controller para ello.

### `RemoveMeasureAnnotation`
Remueve anotaciones de medidas. Utiliza controller para ello.

## Eventos de widgets
- `btnClose_Click`: Oculta formulario.

- `btnSelectNodes_Click`: Selecciona nodos, utiliza controller para ello. `vtk`.
    ```csharp
    private void btnSelectNodes_Click(object sender, EventArgs e)
    {
        _controller.SelectBy = vtkSelectBy.Node;
        _controller.Selection.SelectItem = vtkSelectItem.Node;

        // Clear
        RemoveMeasureAnnotation();
        _controller.ClearSelectionHistoryAndCallSelectionChanged();
    }
    ```

## `PickedIds`
Necesario para obtener nodos, y trabajar con ellos.
```csharp
public void PickedIds(int[] ids)
{
    try
    {
        RemoveMeasureAnnotation(); // Limpiar anotaciones
        //
        if (ids == null || ids.Length == 0) return;
        //
        if (ids.Length == _numOfNodesToSelect)
        {
            if (ids.Length == 1) // Es solo un nodo
            {
                // PMX FeNodeSet
                SelectionChanged(ids);
                SetDrawDataOfSelectedNodes();
            }
            //
            _controller.ClearSelectionHistoryAndCallSelectionChanged();
            //
            Highlight();
        }
    } 
    catch { }
}
```
> Ids, son ids de nodos. Estos se obtienen desde `FrmMain.cs`.

## Render
### `SetDrawDataOfSelectedNodes()`
Sirve para establecer las coordenadas de los nodos en `_coorNodesToDraw`. Se utiliza `Controller`, y es dependiente de lo que contenga `_customNodeSet`.
```csharp
public void SetDrawDataOfSelectedNodes()
{
    if (_customNodeSet.Labels == null || _customNodeSet.Labels.Length == 0)
        return;

    _coorNodesToDraw = new double[_customNodeSet.Labels.Length][];

    for (int i = 0; i < _customNodeSet.Labels.Length; i++)
    {
        int nodeId = _customNodeSet.Labels[i];

        FeNode node = _controller.Model.Mesh.Nodes[nodeId];

        _coorNodesToDraw[i] = node.Coor;
    }

    // Message
    Form_WriteDataToOutput("Selection with `frmCustomSelect`");
    Form_WriteDataToOutput($"Count of selected nodes: {_customNodeSet.Labels.Length}");
}
```


### `Highlight`
Para renderizar las coordenadas seleccionadas. Esto sucede en el evento `SetDrawDataOfSelectedNodes()`
```csharp
// Renderizar las coordenadas de los nodos seleccionados
public void Highlight()
{
    if (_coorNodesToDraw != null)
    {
        _controller.HighlightNodes(_coorNodesToDraw);
    }
}
```

---

 ## `SlectedChanged`
Agregar los nodos obtenidos.
```csharp
public void SelectionChanged(int[] ids)
{
    // Ids unicos
    HashSet<int> uniqueIds;

    if (_customNodeSet.Labels != null)
    {
        uniqueIds = new HashSet<int>(_customNodeSet.Labels);
    }
    else
    {
        uniqueIds = new HashSet<int>();
    }

    foreach (int id in ids)
    {
        uniqueIds.Add(id);
    }

    // Obtener data
    _customNodeSet.Labels = uniqueIds.ToArray();
    _controller.GetNodesCenterOfGravity(_customNodeSet);
}
```



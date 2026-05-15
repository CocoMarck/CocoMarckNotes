# Crear un Cell Picker con `vtkControl.cs`. Usado en PrePoMax.
Para seleccionar un punto cualquiere en una superficie. No necesitamos que sea nodo ni vértice. Lo típìco es usar un **`CellPicker` de superficie**.

En los modulos donde buscaremos el uso de esto seran
- `vtkControl.cs`: Eventos con mouse.
- `PrePoMax/Controller.cs | PrePoMax/Selection/ItemSet/*.cs`: Selection logic.

- [Documentacion `vtkCellPicker`](https://vtk.org/doc/nightly/html/classvtkCellPicker.html)
- [Documentación `vtkControl`](https://gitlab.com/MatejB/PrePoMax/-/blob/master/README.md?ref_type=heads&plain=0#prepomax-visual-studio-setup)
    *  In Solution Explorer find the vtkControl project and then find the References branch
    *  Right click on References from vtkControl project in the Solution Explorer Window and selected Add Reference	
    *  vtkControl: classes for 3D visualization

Ejemplo:
```csharp
vtkCellPicker picker = vtkCellPicker.New();
picker.SetTolerance(0.0005);

int ok = picker.Pick(mouseX, mouseY, 0, renderer);

if (ok == 1)
{
    double[] p = picker.GetPickPosition(); // punto 3D exacto sobre la superficie
    long cellId = picker.GetCellId();      // cara/elemento/celda tocada
}
```

El punto es usar el cell picker `vtkCellPicker`. De `vtkControl`. 

La idea seria usar `vtkCellPicker`, obtengo coordenada 3D, de lo seleccionado. Guardo eso en memoria, y renderizo.

Guardarlo, algo asi:
```csharp
List<double[]> paintedPoints = new List<double[]>();
paintedPoints.Add(p);
```

---

## `vtkControl.cs` | CellPicker
Tiene como atributo un `vtkCellPicker`, el cual se usa pa muchas cosas. Entre ellas, nuestro objetivo. Seleccionar en cualquier parte del modelo un punto.

Cualquier parte visible/intersectable de la superficie renderizada
```csharp
public partial class vtkControl : UserControl
{
    ...
    private bool _querySelectionInProgress;
    private vtkSelectBy _selectBy;
    private vtkSelectItem _selectItem;
    private vtkPropPicker _propPicker;
    private vtkPointPicker _pointPicker;
    private vtkCellPicker _cellPicker;
    private vtkRenderedAreaPicker _areaPicker;
    private vtkCellPicker _cellPicker;
    ...
    // Coustructor
    public vtkControl(){
        ...
        _cellPicker = vtkCellPicker.New();
        _cellPicker.SetTolerance(0.01); 
        ...
    }
    ...
    private void AddActorGeometry(vtkMaxActor actor, vtkRenderLayer layer)
    {
        ...
        _cellPicker.AddLocation(actor.CellLocator);
        ...
    }
    ...
}
```

---
## Busqueda recursiva en VisualStudio
### `_cellPicker.`
```
_cellPicker.SetTolerance(0.01);	vtkControl\vtkControl.cs	329	13	
        if (actor.CellLocator != null) _cellPicker.AddLocator(actor.CellLocator);	vtkControl\vtkControl.cs	4303	52	
        if (actor.CellLocator != null) _cellPicker.AddLocator(actor.CellLocator);	vtkControl\vtkControl.cs	4315	52	
_cellPicker.RemoveAllLocators();	vtkControl\vtkControl.cs	6663	13	
        if (actor.CellLocator != null) _cellPicker.RemoveLocator(actor.CellLocator);	vtkControl\vtkControl.cs	6698	56	
```

### `_pointPicker`
```
    _pointPicker = vtkPointPicker.New();	vtkControl\vtkControl.cs	325	13	
private vtkPointPicker _pointPicker;	vtkControl\vtkControl.cs	113	32	
    _pointPicker.SetTolerance(0.01);	vtkControl\vtkControl.cs	326	13	
```

**En realidad parece que los atributos privados de `vtkControl` no se usan fuera de el.**

---

## Código de ejemplo, en `vtkControl.cs`
```csharp
// Custom Pick Cell Moment
public bool TryPickSurfaceCell( 
    int mouseX, int mouseY, out double[] point, out int globalCellId, out vtkActor pickedActor, out vtkCell pickedCell, out vtkCellLocator pickedCellLocator
) 
{
    point = null;
    globalCellId = -1;
    pickedActor = null;
    pickedCell = null;
    pickedCellLocator = null;

    // Valider estado mínimo de viewport y evitar picking sobre widgets.
    if (_renderer == null) return false;
    else if (_propPicker == null) return false;
    else if (_style != null && _style.IsPositionOverWidget(mouseX, mouseY) ) return false;

    // Obtener actor y punto 3D aproximado sobre la superficie seleccionada. Desde la pos 2D del mouse.
    point = GetPickPoint(out pickedActor, mouseX, mouseY);

    // Validar si no hay punto o actor, no se seleccionó una superficie válida.
    if (point == null) return false;
    else if (pickedActor == null) return false;

    // Encontar la celda real más cercana. Se obtiene la FEM real más cercana el punto seleccionado.
    globalCellId = GetGlobalCellIdClosestTo3DPoint(
        ref point, out pickedCell, out pickedCellLocator
    );

    // Validar que el picking realmete encontró una celda válida.
    if (globalCellId < 0) return false;
    else if (pickedCell == null) return false;
    else if (pickedCellLocator == null) return false;

    return true;
}
// Custom Pick Cell Moment
```

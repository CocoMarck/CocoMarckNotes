# `PickBySurfacePoint`
Método en `vtkControl.cs`. Sirve para renderizar un punto, utilizando `vtkCellPicker`, y se renderiza con `RenderSurfacePoint`.

El punto es que se terminara como funcionara la seleccion de puntos y guardado de estos, en `PickBySurfacePoint`. Y el renderizado deberia ser mas fácil, sucedera en `RenderSurfacePoint`, teoricamente deberia ser sencillo de hacer.

Los puntos que se seleccionen se guardaran y obtendran del `pmx`. Ya despues se renderiza. Creo que el guardado y la obtencion de esto, pasara al form, parece que asi es el flujo del PrePoMax.

---

## Guardar data de ids
Se necesitara de un dict, o lista, que se puede serializar asi como en `CaeMesh/FeNodeSet.cs`

Se usaran de nombres de entidades el prefijo `Coord`, pero para obtener `Coordinates`, método `Coor`, para que tenga sentido con `PrePoMax`.

Context [FeGroup](https://gitlab.com/MatejB/PrePoMax/-/raw/master/CaeMesh/FeGroup.cs?ref_type=heads). Lo que quiero guardar son las coords, por lo que sera una list que almacene tuplas/array de double values.

Se crearon los siguientes modulos, estos estan supuestamente listos para el PMX.

Almacena coordenadas, no fijas a nadota. `CaeMesh/CoordPoint.cs`
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeMesh
{
    [Serializable]
    public class CoordPoint
    {
        // Variables
        private int _id;
        private double _x;
        private double _y;
        private double _z;

        // Constructors
        public CoordPoint()
        {
        }

        public CoordPoint(int id, double x, double y, double z)
        {
            _id = id;
            _x = x;
            _y = y;
            _z = z;
        }

        // Methods
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public double[] Coor 
        { 
            get { return new double[] { _x, _y, _z }; }
            set
            {
                if (value == null || value.Length != 3)
                    throw new ArgumentException();

                _x = value[0];
                _y = value[1];
                _z = value[2];
            }
        }
    }
}
```

Almacena `CoordPoint`. `CaeMesh/CoordPointSet.cs`
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CaeGlobals;

namespace CaeMesh
{
    [Serializable]
    public class CoordPointSet : FeGroup 
    {
        // Variables
        private List<CoordPoint> _points;
        private int _maxPointId;

        // Constructors
        public CoordPointSet(string name) 
            : base(name, new int[0])
        {
            _points = new List<CoordPoint>();
        }

        // Methods
        public List<CoordPoint> Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public void AddPoint(double x, double y, double z)
        {
            _maxPointId++;
            
            _points.Add(
                new CoordPoint(_maxPointId, x, y, z)
            );
        }
    }
}
```

Para el renderizado, seguramente tendre que crear `HighlightCoordPoints`. Metodo que pedira `CoordPointSet`.

### `FeModel`.
Probablemente se tendra que agregar al `FeModel`. El `Controller.cs` lo agrega.
```csharp
protected FeModel _model;
```

Este esta en `CaeModel/FeModel.cs`.

---
## Renderzado
Actualmente `RenderSurfacePoint`, jala, pero deja rastros, mas debug que nada, pero sirve para probar. Este vive en `vtkControl.cs`.

Mientras que `HighlightCoordPoints`, vive en `Controller` y se encargara de dibujar todos los puntos.

Poner este como void, y en `PrePoMax/Controller.cs`:
```csharp
public void HighlightCoordPoints(string pointCoor, bool useSecondaryHighlightColor = false)
    {
        // Code
    }
```

IMPORTANTE: Como que el `HighLightNodes`, le vale quese si es nodo o no, solo renderiza. Si esto es así, ni hace falta usar `RenderSurfacePoint`.
```csharp
public void HighlightNodes(double[][] nodeCoor, bool useSecondaryHighlightColor = false)
{
    Color color = Color.Red;
    vtkRendererLayer layer = vtkRendererLayer.Selection;
    int nodeSize = _settings.Pre.HighlightNodeSymbolSize;
    DrawNodes("Highlight", nodeCoor, color, layer, nodeSize, false, useSecondaryHighlightColor);
}
```
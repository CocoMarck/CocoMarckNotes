# `PickBySurfacePoint`
Método en `vtkControl.cs`. Sirve para renderizar un punto, utilizando `vtkCellPicker`, y se renderiza con `RenderSurfacePoint`.

El punto es que se terminara como funcionara la seleccion de puntos y guardado de estos, en `PickBySurfacePoint`. Y el renderizado deberia ser mas fácil, sucedera en `RenderSurfacePoint`, teoricamente deberia ser sencillo de hacer.

Los puntos que se seleccionen se guardaran y obtendran del `pmx`. Ya despues se renderiza. Creo que el guardado y la obtencion de esto, pasara al form, parece que asi es el flujo del PrePoMax.
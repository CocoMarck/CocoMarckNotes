# Naming en C#
El C# se acostumbra nomas usar `PascalCase` y `camelCase`, se usan para nombrar todo, y se una u otro dependiendo que cosa se nombra.


# PascalCase
- Structs
- Interfaces
- Enums

Ejemplo: `DisplayScaleNumber, PlayerController, IDataService`


- Metodos
- Clases

Ejemplo: `GetScaledNumber(), CalculateDamage()`


- Constantes

Ejemplo: `PixelLimit = 4;`


- Propiedades
- Campos publicos

Ejemplo: `PixelLimit, ResolutionWidth`




# camelCase 
- Variables locales
- Parámetros
- Campos privados

Ejemplo: `int currentResolution, float dimensionNumber, string based`



# Eventos
Tambien en PascalCase, suelen usar subfijo `Event`.
`public event EventHandler ResolutionChanged;`

# Basicamente escribimos un archivo.csproj
El nombre del csproj, debe ser el nombre de la carpeta que lo contiene.

### `carpetaDePrograma.csproj`:
```csharp
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

### El programa que quieras que ejecute
```csharp
dotnet run
```
> Se tendra que llamar `Program.cs`.
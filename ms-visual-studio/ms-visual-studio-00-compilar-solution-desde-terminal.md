# Compilar solution desde la terminal.
Necesitas Visual Studio instalado.

```powershell
MSBuild "\ruta\ProgramSolution.sln" /m /p:Configuration=Debug
```

Puede que no tengas en path el MSBuild de VS. Asi que puedes probar usando ruta de exe.
```powershell
& "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" "\ruta\ProgramSolution.sln" /m /p:Configuration=Debug
```
# Donde y como se guarda el `.pmx`
## `SettingsContainer.cs`
```csharp
public void SaveToFile(string fileName)
{
    if (_regenerationWorkDirectory == null)
    {
        // Use a temporary file to save the data and copy it at the end
        string tmpFileName = Tools.GetNonExistentRandomFileName(Path.GetDirectoryName(fileName), ".tmp");
        ToDictionary().DumpToFile(tmpFileName);
        File.Copy(tmpFileName, fileName, true);
        File.Delete(tmpFileName);
    }
}
```
> Tambien tiene `LoadFromFile`

```csharp
public void SaveToPmxCommand(string fileName)
{
    CSaveToPmx comm = new CSaveToPmx(fileName);
    _commands.AddAndExecute(comm);
}
```
> Parece que se guerda en `Command Pattern`

### `CSaveToPmx.cs`
```csharp
```
> Wrapper, hasg SHA1

---
## `Controller.cs`
```csharp
public string OpenedFileName
{
    get
    {
        return _settings.General.LastFileName;
    }
    set
    {
        if (_settings != null)
        {
            if (value != _settings.General.LastFileName)
            {
                _settings.General.LastFileName = value;
                _settings.SaveToFile();
            }
            //
            if (_settings.General.LastFileName != null)
                _form.SetTitle(Globals.ProgramName + "   " + _settings.General.LastFileName);
            else _form.SetTitle(Globals.ProgramName);
        }
    }
}
```

# `public void SaveToPmx`
```csharp
public void SaveToPmx(string fileName)
{
    try
    {
        _savingFile = true;
        // Create backup if file exists and is from an older version
        CreateBackupIfNeeded(fileName);
        //
        CompressionLevel compressionLevel = _settings.General.CompressionLevel;
        //
        bool[][] states = _form.GetTreeExpandCollapseState();
        OpenedFileName = fileName;
        //
        //_commands.SaveToSeparateFiles(Path.GetDirectoryName(fileName));
        //
        object[] data = new object[] { this, _jobs, states };
        // Use a temporary file to save the data and copy it at the end
        string tmpFileName = Tools.GetNonExistentRandomFileName(Path.GetDirectoryName(fileName), ".tmp");
        //
        SuppressExplodedView();
        //
        using (FileStream fs = new FileStream(tmpFileName, FileMode.Create))
        {
            ResultsCollection allResults = null;
            bool saveResults = _settings.General.SaveResultsInPmx;
            // When controller (data[0]) is dumped to stream, the results should be null if set in settings
            if (saveResults == false)
            {
                allResults = _allResults;
                _allResults = new ResultsCollection();
            }
            // Write program name and version to the file
            Tools.WriteStringToFileStream(fs, Globals.ProgramName, 32);
            // Prepare binary writer
            using (BinaryWriter bw = new BinaryWriter(new MemoryStream()))
            {
                // Dump everything to the stream
                data.DumpToStream(bw);
                // Write model mesh data - data is saved inside data[0]._model but without mesh data - speed up
                FeModel.WriteToBinaryWriter(_model, bw);
                // Rewind the writer
                bw.Flush();
                bw.BaseStream.Position = 0;
                // Compress the writer
                byte[] compressedData = Tools.Compress(bw.BaseStream, compressionLevel);
                // Write the length of the compressed data
                Tools.WriteIntToFileStream(fs, compressedData.Length);
                // Write the compressed data
                fs.Write(compressedData, 0, compressedData.Length);
            }
            // Results - data is saved inside data[0]._allResults but without mesh data - speed up
            ResultsCollection.WriteToFileStream(_allResults, fs, compressionLevel);
            // After dumping restore the results
            if (saveResults == false)
            {
                _allResults = allResults;
            }
        }
        //
        ResumeExplodedViews(false);
        //
        File.Copy(tmpFileName, fileName, true);
        File.Delete(tmpFileName);
        // Settings
        AddFileNameToRecentFiles(fileName); // this line redraws the scene
        //
        ApplySettings(); // work folder and executable
        //
        _modelChanged = false;
    }
    catch (Exception ex)
    {
        ResumeExplodedViews(true);
        throw ex;
    }
    finally
    {
        _savingFile = false;
    }
}
```
> Este es el guardado real.

- Header fijo: `ProgramName, 32 bytes`
- Bloque comprimido: Controller + Jobs + Estado de arbol
- Bloque de results: `ResultsCollection`

```csharp
object[] data = new object[] { this, _jobs, states };
data.DumpToStream(bw);
FeModel.WriteToBinaryWriter(_model, bw);
```

Guarda `__jobs`, y lo comprime.

Es un binario comprimido con datos serializados.

---
## Guardado real del `.pmx`

El guardado real no está en `SettingsContainer`, sino en `Controller.SaveToPmx()`.

El flujo es:

`SaveToPmxCommand()` → `CSaveToPmx.Execute()` → `Controller.SaveToPmx()`

El `.pmx` guarda datos serializados y comprimidos, no texto plano. Incluye el `Controller`, jobs, estado del árbol, modelo/malla y opcionalmente resultados.

---
# FE Model | Node Sets

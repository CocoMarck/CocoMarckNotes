# Crear pestaña personalizada.
## `./UserControls/ModelTree.Designer.cs`

Primeramente agregamos la parte visual.  Esto lo hacemos al final de la clase `partial class ModelTree`.
```csharp
// Custom tab
private System.Windows.Forms.TabPage tpCustomTab;
private CodersLabTreeView cltvCustomTab;
private SearchTextBox stbCustomTab;
// Custom tab
```
### `InitializeComponent()`
Despues en la `private void InitializeComponent()`, abajo del `this.cltvResults`, construimos lo necesario.
```csharp
// Custom tab
this.tpCustomTab = new System.Windows.Forms.TabPage();
this.stbCustomTab = new UserControls.SearchTextBox();
this.cltvCustomTab = new UserControls.CodersLabTreeView();
// Custom tab
```

Y aqui mismo, antes de `this.SuspendLayout();`. Agregamos la suspención del contenedor.
```csharp
// Custom tab
this.tpCustomTab.SuspendLayout();
// Custom tab
```

Agregamos el tab al `TabControl`. Ponemos esto abajo de `this.tcGeometryModelResults.Controls.Add(this.tpResults);`.
```csharp
this.tcGeometryModelResults.Controls.Add(this.tpCustomTab); // CustomTab
```

Finalmente configuramos `TabPage`, buscador, y árbol. Conectamos eventos. Esto lo agregamos abajo de la configuracion de `tpResults`.
```csharp
// Custom tab
this.tpCustomTab.Controls.Add(this.stbCustomTab);
this.tpCustomTab.Controls.Add(this.cltvCustomTab);
this.tpCustomTab.Location = new System.Drawing.Point(4, 24);
this.tpCustomTab.Name = "tpCustomTab";
this.tpCustomTab.TabIndex = 3;
this.tpCustomTab.Size = new System.Drawing.Size(231, 470);
this.tpCustomTab.Text = "Custom";
this.tpCustomTab.UseVisualStyleBackColor = true;

this.stbCustomTab.Anchor = ((System.Windows.Forms.AnchorStyles)
    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
    | System.Windows.Forms.AnchorStyles.Right)));
this.stbCustomTab.Location = new System.Drawing.Point(0, 0);
this.stbCustomTab.Name = "stbCustomTab";
this.stbCustomTab.ReadOnly = false;
this.stbCustomTab.Size = new System.Drawing.Size(270, 22);
this.stbCustomTab.TabIndex = 1;
this.stbCustomTab.TextChanged += new System.Action<object, System.EventArgs>(this.stbCustomTab_TextChanged);

this.cltvCustomTab.Anchor = ((System.Windows.Forms.AnchorStyles)
    ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
    | System.Windows.Forms.AnchorStyles.Left)
    | System.Windows.Forms.AnchorStyles.Right)));
this.cltvCustomTab.BorderStyle = System.Windows.Forms.BorderStyle.None;
this.cltvCustomTab.ChangeHighlightOnFocusLost = false;
this.cltvCustomTab.DisableMouse = false;
this.cltvCustomTab.HideSelection = false;
this.cltvCustomTab.ImageList = this.ilIcons;
this.cltvCustomTab.LabelEdit = true;
this.cltvCustomTab.Location = new System.Drawing.Point(0, 21);
this.cltvCustomTab.Name = "cltvCustomTab";
this.cltvCustomTab.SelectionMode = UserControls.TreeViewSelectionMode.MultiSelect;
this.cltvCustomTab.Size = new System.Drawing.Size(231, 450);
this.cltvCustomTab.TabIndex = 0;
            
this.cltvCustomTab.MouseOverNodeChangedEvent += new System.Action<object>(this.cltv_MouseOverNodeChangedEvent);
this.cltvCustomTab.SelectionsChanged += new System.EventHandler(this.cltv_SelectionsChanged);
this.cltvCustomTab.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.cltv_AfterLabelEdit);
this.cltvCustomTab.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.cltv_BeforeCollapse);
this.cltvCustomTab.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.cltv_AfterCollapse);
this.cltvCustomTab.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.cltv_BeforeExpand);
this.cltvCustomTab.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.cltv_AfterExpand);
this.cltvCustomTab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cltv_KeyDown);
this.cltvCustomTab.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cltv_MouseDoubleClick);
this.cltvCustomTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cltv_MouseDown);
this.cltvCustomTab.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cltv_MouseUp);
// Custom tab
```

Y finalmente lo agregamos a los `ResumeLayout`:
```csharp
this.tpCustomTab.ResumeLayout(false); // Custom tab
```

Esto es puro diseño, bueno casi, menos la conección con el mouse y eso.

---
## `./UserControls/ModelTree.cs` 
Lo agregamos al `enum ViewType`. Aca es donde debera estar la logica general.
```csharp
public enum ViewType
{
    ...
    CustomTab
}
```

Lo agregamos al `DisbleMouse`
```csharp
public bool DisableMouse
{
    ...
    {
        _disableMouse = value;
        ...
        // Custom tab
        cltvCustomTab.DisableMouse = value;
        stbCustomTab.Enabled = !value;
    }
}
```

En el constructor `InitializeComponent()` agregamos el estado, arriba del llamado del método `Clear()`:
```csharp
_prevStates.Add(cltvCustomTab, null); // Custom tab
```

Agregamos el evento del bucador. Junto a los `private void stbSomething_TextChanged`.
```csharp
// Custom tab
private void stbCustomTab_TextChanged(object sender, EventArgs e)
{
    FilterTree(cltvCustomTab, stbCustomTab.Text);
}
// Custom tab
```

En `GetViewType`:
```csharp
else if (tcGeometryModelResults.SelectedTab == tpCustomTab) return ViewType.CustomTab;
```

En `tcGeometryModelResults_SelectedIndexChanged()` ponemos un parche feillo pa que no de mensaje de error.
```csharp
if (tcGeometryModelResults.SelectedTab == tpCustomTab) return;
```
> Si un return brake type, null. Este return es temporal. Evita que el flujo principal procese el CustomTab mientras todavía no tiene lógica propia.

En el `CodersLabTreeView GetActiveTree()`, agregamos nuestro `else if`, antes del `else`/`exception`.
```csharp
else if (tcGeometryModelResults.SelectedTab == tpCustomTab) return cltvCustomTab; // Cusotm tab
```

En el `CodersLabTreView GetTree`, agregamos nuestro `else if` antes del `exception`.
```csharp
else if (view == ViewType.CustomTab) return cltvCustomTab; // Custom tab
```

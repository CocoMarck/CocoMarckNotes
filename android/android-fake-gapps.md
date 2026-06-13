### **Stack Huawei sin GMS: MicroG + FakeGApps + Aurora + F-Droid**

#### **1. MicroG**
**Qué hace**: Reemplaza Google Play Services. Notificaciones push, login, ubicación.
**Repo**: [GitHub MicroG](https://github.com/microg)
**Repo F-Droid**: `https://microg.org/fdroid/repo`
**Instala**: `microG Services Core`, `microG Services Framework Proxy`, `FakeStore`, `microG Companion`

#### **2. FakeGApps**
**Qué hace**: Módulo LSPosed. Engaña a las apps para que crean que tienes GMS real. Quita el error "Se requieren Google Play Services"
**Repo**: [GitHub FakeGApps](https://github.com/WheezyE/FakeGApps)
**Requisito**: Root + LSPosed. Sin root no funciona.

#### **3. LSPosed**
**Qué hace**: Framework para cargar módulos como FakeGApps.
**Repo**: [GitHub LSPosed](https://github.com/LSPosed/LSPosed)

#### **4. Aurora Store**
**Qué hace**: Play Store sin Google. Descargas apps anónimo.
**Repo**: [GitLab Aurora Store](https://gitlab.com/AuroraOSS/AuroraStore)
**F-Droid**: [Aurora Store en F-Droid](https://f-droid.org/packages/com.aurora.store/)

#### **5. F-Droid**
**Qué hace**: Tienda open-source. Desde aquí instalas todo lo de arriba.
**Web**: [F-Droid.org](https://f-droid.org)

### **Pasos express CON root**
1. **Root** con [Magisk](https://github.com/topjohnwu/Magisk) → instala módulo **LSPosed**
2. **F-Droid** → añade repo de MicroG → instala los 4 APKs de MicroG
3. **Instala FakeGApps.apk** → actívalo en LSPosed → reinicia
4. **Instala Aurora Store** desde F-Droid → modo anónimo
5. **MicroG Settings** → Self-Check → activa permisos + Cloud Messaging

### **Pasos express SIN root**
1. **F-Droid** → instala MicroG Core + FakeStore
2. **Aurora Store** desde F-Droid
3. Listo. Algunas apps darán aviso de GMS pero muchas jalan igual.

### **Notas Huawei**
- **Bootloader**: Modelos 2020+ casi imposible abrir. Sin bootloader = sin root = sin FakeGApps.
- **Batería**: Quita optimización de batería a MicroG en Ajustes > Batería > Inicio de apps.
- **No jalan**: Google Pay, Netflix HD, YouTube. Usa [NewPipe](https://github.com/TeamNewPipe/NewPipe) o [ReVanced](https://github.com/revanced) para YouTube.

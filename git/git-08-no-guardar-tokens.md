# Git, desactivar guardado de tokens feos
El windows por motivos raros, el git por defecto guarda tokens, credenciales. Eso puede ser feo para algunos. Como para mi.

Primeramente vemos si se guardan.
```bash
git config --global credential.helper
```
> Si no muestra nada, probablemente no hay helper global configurado.

Si queremos desabilitar el guardado por completo, ponemos el siguiente comando:
```bash
git config --global --unset credential.helper
```

En windows puede que esto no jala, pero seria porque tienes instalado `Git Creadential Manager`, y se configura desde GUI fea: 
```
Panel de control
→ Credential Manager
→ Windows Credentials
```
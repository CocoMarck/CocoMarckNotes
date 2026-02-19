# Estructura de carpetas para guardar drivers y apis
```
apis-and-drivers/
    apis-and-runtimes/          # DirectX, Vulkan, .NET, Java, MSVC++
        cross-platform/ # Para mas de un OS
        windows/ gnu-linux/ android/ # OS
    drivers/                    # Chipset, GPU, Network, Audio (por modelo/marca)
        windows/ gnu-linux/ android/ # OS
            peripherals/ # Perifericos
            motherboard/ # Motherboard
            graphic-card/ # Grafica
            network/ # Network
        
        by-model-name/# Package o dir por nombre de modelo de dispositivo.
            ideapad-120s-14IAP/
            mi-pc-del-2008/
```

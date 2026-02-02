# Estructura de carpetas de proyectos multimedia

Aquí tienes la estructura de carpetas que te propongo para organizar tus proyectos multimedia. La idea es que sea clara, sencilla y fácil de manejar, usando `kebab-case` y todo en minúsculas, como te gusta.

## Directorios tipo modulos
- `01-proyectos-activos`
- `02-proyectos-terminados`
- `03-recursos-generales`

**Carpetas maestras contenidas en `proyectos-*`**
- `musica`
- `dibujo-y-3d`

**Carpetas maestras contenidas en `recursos-generales`**
- `fuentes`
- `texturas`
- `pinceles`
- `samples-generales`
- `otros-asssets`

**Prefijo de nombrado de proyectos**: `[numbre-proyecto-dirmaestro-aaaa-mm-dd]`
- Ejemplo: `[pan-proyecto-dibujo-2026-01-01]`
> Estos directorios estaran adentro de las carpetas contenidos en los `modulo/dir-maestro`.

---

# `01-proyectos-activos`
Este es el directorio principal para todos los proyectos en los que estás trabajando **actualmente**. La idea es que al abrir tu carpeta principal, veas enseguida lo que tienes pendiente.

## `musica`
Aquí guardarías todos los proyectos relacionados con producción musical.

- **`[nombre-proyecto-musica-aaaa-mm-dd]/`**: Cada subcarpeta es un proyecto musical específico, con la fecha de inicio para un mejor orden cronológico.
    - **`lmms/`**: Archivos de proyecto de LMMS.
    - **`audacity/`**: Archivos de proyecto de Audacity.
    - **`audio-bruto/`**: Grabaciones originales, samples no procesados, etc.

## `dibujo-y-3d`
Para tus creaciones visuales, tanto dibujos como modelos 3D.
- **`[nombre-proyecto-dibujo-aaaa-mm-dd]/`**: Cada subcarpeta es un proyecto visual específico.
    - **`originales/`**: Archivos editables de tus dibujos (PSDs, KRAs, etc.).
    - **`modelos-3d/`**: Contiene tus proyectos de modelado 3D.
        - **`blender/`**: Archivos de Blender.
        - **`texturas/`**: Texturas específicas para este modelo 3D.
    - **`referencias/`**: Imágenes o recursos que usaste como inspiración.

    
---

# `02-proyectos-terminados`
Una vez que un proyecto está finalizado y listo para el mundo (o para tu archivo personal), se mueve aquí. Es tu portafolio de cosas ya hechas.

## `musica`
Aquí van los proyectos musicales que ya masterizaste o terminaste.
- **`[nombre-proyecto-musica-aaaa-mm-dd]/`**: La misma carpeta de proyecto, pero ahora en "terminados".
    - **`master/`**: Las versiones finales exportadas (MP3, WAV de alta calidad).
    - **`recursos-finales/`**: Portadas, letras, o cualquier otro material final asociado.

## `dibujo-y-3d`
Tus dibujos e imágenes 3D que ya están exportados y listos.
- **`[nombre-proyecto-dibujo-aaaa-mm-dd]/`**: La carpeta del proyecto original.
    - **`exportados/`**: Las imágenes o renders finales en sus formatos de distribución (PNG, JPG, OBJ).
    - **`iconos-finales/`**: Si el proyecto generó iconos, aquí irían sus versiones finales.


    
    
---

# `03-recursos-generales`

Este es el lugar para todo ese material reutilizable que no pertenece a un solo proyecto, sino que usas constantemente en varios.

## `fuentes`
Tus colecciones de tipografías.

## `texturas`
Un banco de texturas generales que puedes aplicar en diferentes modelos 3D o ilustraciones.

## `pinceles`
Sets de pinceles para tus programas de dibujo.

## `samples-generales`
Samples de audio que usas recurrentemente en diferentes producciones musicales.

## `otros-assets`
Cualquier otro recurso que no encaje en las categorías anteriores, pero que sea de uso común.

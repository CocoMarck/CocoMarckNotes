@echo off

REM Constantes necesarias
set "ROOT=%~dp0"

set "PDF1=%ROOT%windows_shortcuts_chido.pdf"
set "PDF2=%ROOT%windows_shortcuts_official_file.pdf"

if exist "%PDF1%" (
    start "" "%PDF1%"
) else if exist "%PDF2%" (
    start "" "%PDF2%"
) else (
    echo No se encontró ninguno de los archivos PDF.
    timeout /t 5 > nul
)

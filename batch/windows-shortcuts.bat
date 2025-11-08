@echo off
set "PDF1=%USERPROFILE%\Documents\AutoHotKey\w10-11-shortcuts-chido.pdf"
set "PDF2=%USERPROFILE%\Documents\AutoHotKey\w10-shortcuts-official-file.pdf"

if exist "%PDF1%" (
    start "" "%PDF1%"
) else if exist "%PDF2%" (
    start "" "%PDF2%"
) else (
    echo No se encontró ninguno de los archivos PDF.
    timeout /t 5 > nul
)

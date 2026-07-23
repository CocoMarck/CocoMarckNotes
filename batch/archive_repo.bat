@echo off
setlocal

REM Constantes necesarias
set "ROOT=%~dp0"

for /f %%i in ('powershell -Command "Get-Date -Format yyyy-MM-dd-HH-mm-ss"') do set "DATETIME=%%i"

set "ARCHIVE_NAME=mesh-pipeline-%DATETIME%"
set "CLONE_NAME=%ARCHIVE_NAME%-with-history"
set "LOCAL_DESTINATION=%USERPROFILE%\Downloads"
set "CLONE_DIR=%LOCAL_DESTINATION%\%CLONE_NAME%"
set "COMPRESS_CLONE_FILE=%LOCAL_DESTINATION%\%CLONE_NAME%.7z"
set "ZIP_FILE=%LOCAL_DESTINATION%\%ARCHIVE_NAME%.zip"

REM Debug
echo root                   %ROOT%
echo zip file               %ZIP_FILE%
echo clone dir              %CLONE_DIR%
echo compress clone file    %COMPRESS_CLONE_FILE%

REM Archive
cd /d "%ROOT%"
git archive -o "%ZIP_FILE%" main
git clone . "%CLONE_DIR%" --branch main

REM Compress clone and delete poop
7z a "%COMPRESS_CLONE_FILE%" "%CLONE_DIR%\*"
rmdir /s /q "%CLONE_DIR%"


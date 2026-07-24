@echo off
setlocal

REM Constantes necesarias
set "ROOT=%~dp0"

for /f %%i in ('powershell -Command "Get-Date -Format yyyy-MM-dd-HH-mm-ss"') do set "DATETIME=%%i"

for /f "delims=" %%i in ('git -C "%ROOT%.." rev-parse --show-toplevel 2^>nul') do set "REPO_DIR=%%i"
for %%I in ("%REPO_DIR%") do set "REPO_NAME=%%~nxI"

set "ARCHIVE_NAME=%REPO_NAME%-%DATETIME%"
set "CLONE_NAME=%REPO_NAME%-with-history-%DATETIME%"
set "LOCAL_DESTINATION=%USERPROFILE%\Downloads"
set "CLONE_DIR=%LOCAL_DESTINATION%\%CLONE_NAME%"
set "COMPRESS_CLONE_FILE=%LOCAL_DESTINATION%\%CLONE_NAME%.7z"
set "ZIP_FILE=%LOCAL_DESTINATION%\%ARCHIVE_NAME%.zip"

for /f "delims=" %%b in ('git -C "%REPO_DIR%" branch --show-current 2^>nul') do set "CURRENT_BRANCH=%%b"
if "%CURRENT_BRANCH%"=="" set "CURRENT_BRANCH=main"

REM Debug
echo root                   %ROOT%
echo repo dir               %REPO_DIR%
echo repo name              %REPO_NAME%
echo repo branch            %CURRENT_BRANCH%
echo zip file               %ZIP_FILE%
echo clone dir              %CLONE_DIR%
echo compress clone file    %COMPRESS_CLONE_FILE%

REM Archive
cd /d "%REPO_DIR%"
git archive -o "%ZIP_FILE%" "%CURRENT_BRANCH%"
git clone . "%CLONE_DIR%" --branch "%CURRENT_BRANCH%"

REM Compress clone and delete poop
7z a "%COMPRESS_CLONE_FILE%" "%CLONE_DIR%\*"
rmdir /s /q "%CLONE_DIR%"


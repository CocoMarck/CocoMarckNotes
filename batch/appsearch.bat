@echo off
powershell -NoProfile -Command "$wshell = New-Object -ComObject WScript.Shell; $wshell.SendKeys('^{ESC}'); Start-Sleep -Milliseconds 300; $wshell.SendKeys('apps: ');"

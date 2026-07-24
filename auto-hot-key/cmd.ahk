; Con ctrl alt c, abrir el cmd
^!c::
; Descartado porque con gsudo es mas exitante. Y es con c, porque cmd ya es viejon.
;try {
;    Run *RunAs C:\Windows\System32\cmd.exe /k "cd %WINDIR% & cls"
;}
;catch{
;    Run C:\Windows\System32\cmd.exe /k "cd %USERPROFILE% & cls"
;}
Run C:\Windows\System32\cmd.exe /k "cd %USERPROFILE% & cls"

@echo off
:: scrcpy super stable audio
:: Uso: script.bat 954 60
scrcpy --max-size=%1 --max-fps=%2 ^
    --video-codec=h264 --video-bit-rate=16000000 --video-buffer=50 ^
    --audio-codec=aac --audio-bit-rate=64000 --audio-buffer=50
@echo off
:: Uso: 954 60
scrcpy --max-size=%1 --max-fps=%2 ^
  --video-codec=h264 ^
  --video-bit-rate=16000000 ^
  --video-buffer=50 ^
  --no-audio
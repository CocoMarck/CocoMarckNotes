@echo off
:: Uso: ./script.sh 954 60
scrcpy --max-size=%1 --max-fps=%2 ^
  --video-codec=h264 --video-bit-rate=4000000 --video-buffer=0 ^
  --audio-codec=aac --audio-bit-rate=64000 --audio-buffer=0
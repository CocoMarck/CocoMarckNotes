# Debian 13 error en firmas locas

Es por no tener sincronizada la fecha bien.

Añadile a systemd lo necesario
```
sudo apt install systemd-timesyncd -y
sudo systemctl enable --now systemd-timesyncd
```

Instalar y activar ntp
```
sudo apt install ntpsec-ntpdate; sudo ntpdate pool.ntp.org; sudo timedatectl set-ntp true; timedatectl status
```

Resultado:
```
s1 no-leap
               Local time: mié 2025-08-27 20:15:40 CST
           Universal time: jue 2025-08-28 02:15:40 UTC
                 RTC time: jue 2025-08-28 02:15:39
                Time zone: X/Y (Z, -823)
System clock synchronized: yes
              NTP service: active
          RTC in local TZ: no
```

Si se ve algo asi en el resultado, ya ta todo bien.

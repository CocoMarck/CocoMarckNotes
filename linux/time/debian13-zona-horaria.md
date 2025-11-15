#    GNU/Linux Debian | Cambiar region horaria    #
Esto nos servira para configurar la fecha y hora, a una sicronizada con nuestro país. Este tutorial depende de usar Debian, dpkg. Cualquier distro base debian, le deberia jalar ese tutorial.

**Para ver region horaria actual:**
```bash
cat /etc/timezone
```

**Para cambiar region horaria:**
```bash
sudo dpkg-reconfigure tzdata
```

**Para verificar hora:**
```bash
date
```

---

Como pudieron ver, es un proceso bastante sencillo.

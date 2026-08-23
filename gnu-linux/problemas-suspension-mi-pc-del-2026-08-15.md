# Problemas con mi suspensión de mi pc del `2026-08-15`

El culpable fue `NVMe` (`Silicon Motion SM226XT`).

## 1. Crear un servicio systemd que aplique el fix en cada arranque:

Archivo: `sudo nano /etc/systemd/system/disable-nvme-wake.service`.
```conf
[Unit]
Description=Disable NVMe GPP0 PCIe wake (fix instant wake on suspend)
After=local-fs.target

[Service]
Type=oneshot
RemainAfterExit=yes
ExecStart=/usr/bin/sh -c 'echo disabled > /sys/bus/pci/devices/0000:00:01.1/power/wakeup'

[Install]
WantedBy=multi-user.target
```

```bash
sudo systemctl daemon-reload
sudo systemctl enable --now disable-nvme-wake.service
```

## 2. Verificación final:
- Reiniciar y confirmar que sigue activo: `cat /sys/bus/pci/devices/0000:00:01.1/power/wakeup` -> debe decir `disabled`.
- `systemctl suspend`, esperar 1 minuto, despertar -> debe quedarse dormida.


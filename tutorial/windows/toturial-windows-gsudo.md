# Super usuario en windows: `gsudo` el `sudo` de windows
Basicametne gsudo, permite realizar comandos como andmistrador de manera mas controlada. Asi se evita abrir a cada rato una terminal en administrador, y hacer todo como administrador. Una cochinada.

Esta es una aplicacion de terceros, open source, se puede instalar con choco, o con winget.

winget
```batch
winget install gerardog.gsudo
```

chocolatey
```batch
choco install gsudo
```

# Uso de gsudo
Pos como el sudo, solo que el mensaje se ve en ventanita. Le damos que si y ya. No deberia pedir contra, si ya somos admins, solo es una pregunta de si o no.

Prueba esto:
```batch
gsudo cmd
```

Si te abre el cmd, pos jalo chido. Eso es todo.

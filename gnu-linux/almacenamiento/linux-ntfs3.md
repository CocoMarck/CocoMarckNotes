# Linux, y su compatibilidad con ntfs
Ya desde hace rato ntfs esa nativo pa linux. Pero solo para usar, lectura y escritura, no jala pa crear particiones.

Este driver privativo, nativo, se llama `ntfs3`. Si usas ntfs pa juega, si o si necesitas usar `ntfs3`, te dara mejor rendimiento (mejores cargas). Pero la verdad, es que lo mejor es usar sistemas de archivos modernotes y full linux, como `ext4`, `btfs`, etc. Esos jalan mucho mejor.

Checa si tu kernel, tiene `ntfs3`, de seguro si. Bueno si usas un `TriskelOS`, pos de seguro no, pero de lo contrario pos si.

`ntfs-3g`, si jala pa crear particiones, pero pos nomas eso. Y la verdad, no es recomendable, pero pos te puede llegar a servir.

# Detectar discos montados ntfs
Para seber si tu disco ta montado en `ntfs3`.
```bash
mount | grep ntfs
```

Salida de ejemplo
```
/dev/sda1 on /media/midisco type ntfs3 (rw,relatime,uid=1000,gid=1000,dmask=0000,fmask=0000,iocharset=utf8)
```

Aca lo importante es que diga `type ntfs3`, eso ya indica que se monto con el driver privativo. Si dice por ejemplo `type fuse`, pos se monto con `ntfs-3g`, el open surce driver, que ta bueno, pero, para rendimiento maximo, es mucho mjor `ntfs3`.
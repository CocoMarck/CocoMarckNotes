#    PyKivy buildozer abb password key    #

## Primer paso: Generación de key
```bash
keytool -genkey -v -keystore custom-and-logic-name.jks -alias your-name -keylog RSA -keysize 2048 -validity 10000
```

### Debug de comando.
```
Introduzca la contraseña del almacén de claves:  
Volver a escribir la contraseña nueva: 
Enter the distinguished name. Provide a single dot (.) to leave a sub-component empty or press ENTER to use the default value in braces.
¿Cuáles son su nombre y su apellido?
  [Unknown]:  
¿Cuál es el nombre de su unidad de organización?
  [Unknown]:  
¿Cuál es el nombre de su organización?
  [Unknown]:  
¿Cuál es el nombre de su ciudad o localidad?
  [Unknown]:  
¿Cuál es el nombre de su estado o provincia?
  [Unknown]:  
¿Cuál es el código de país de dos letras de la unidad?
  [Unknown]:  
¿Es correcto CN=JeanChacon, OU=CocoMarck, O=CocoMarck, L=Escobedo, ST=Monterrey, C=MX?
  [no]:  

Generando par de claves RSA de 2,048 bits para certificado autofirmado (SHA384withRSA) con una validez de 10,000 días
        para: 
[Almacenando .jks]
```

Guarda para siempre tu contra y usuario. Tambien puedes guarder los otros datos, pero no se necesitan para login.

- alias: `your-name`
- pasword: `****`



---
## Editar `buildozer.spec`
Ahora tenemos que editar el spec.

Hay que tener estas lineas:
```
android.release_artifact = aab

android.keystore = file.jks
android.keystore_passwd = my-pasword
android.keyalias = my-alias
android.keyalias_passwd = my-alias-pasword
```

Tambien podemos poner los alias y pasword como `${CONST_NAME}`. Y antes de compila, exportarlos, ejemplo:
```bash
export KEYSTORE_PASS="****"
export KEYALIAS_PASS="****"
export KEYALIAS="my-alias"
```



---
## Compilar
```bash
buildozer android release
```

Puedes hacer un clean antes.
```bash
buildozer android clean
```

Si quieres reiniciar el proceso de compilación, puedes borrar la data de compilación, con:
```bash
rm -R .buildozer/
```


---
## Verificar `abb`
Si ya compilo, casi seguro que si metio bien el `jks`. Pero aun podemos verificar con:

```bash
java -jar ./bundletool-all-1.18.3.jar validate \
  --bundle=bin/my-app.aab
```

> Usamos `bundletoool`, de google; esta en github. O si no buscar un fork.

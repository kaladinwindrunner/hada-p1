# Práctica 1b: Uso de GitHub/remoto

# P1. ¿Qué rama se ha subido exactamente?

La rama master.

# P2. ¿Qué pasa al utilizar la opción Comparar con la versión no modificada?

VisualStudio abre dos archivos HadaP1.cs;HEAD (versión no modificada) y HadaP1.cs (versión modificada)
comparando ambos archivos. Subrayado en verde aparecen los datos agregados respecto al archivo no modificado,
y subrayado en rojo, los datos eliminados respecto al archivo no modificado.

# P3. ¿Y ahora ves algún cambio en el repositorio remoto? ¿Por qué?

No vemos ningún cambio. Únicamente hemos subido los cambios al repositorio local.

# P4. ¿Qué significa Confirmar > "Configrmar por etapas" y cuál sería el comando git equivalente?

"Confirmar por etapas" permite agregar selectivamente ciertos archivos mientras se pasa por alto
los cambios realizados en otros archivos.

En este caso, el comando git equivalente de hacer clic en el botón "Confirmar por etapas", sería
git add + git commit del archivo en cuestión.

Si modificaramos todos los archivos y quisiésemos agregarlos todos con un único commit, escogeríamos la
opción "Confirmar todo" en lugar de "Confirmar por etapas".

Cabe mencionar que la opción "Confirmar por etapas", como se ha mencionado con anterioridad, sólo
realiza cambios en el repositorio local y no en el repositorio remoto.

# P5. ¿Qué significa Confirmar > "Confirmar por etapas e insertar" y cuál sería el comando git equivalente?

"Confirmar por etapas e insertar" permite agregar un archivo al repositorio local, e inmediatamente,
al repositorio remoto.

Este botón, es una combinación de los comandos git add + git commit + git push.

# P6. ¿Qué significa Confirmar > "Confirmar por etapas y sincronizar" cuál sería el comando git equivalente?

"Confirmar por etapas y sincronizar", permite, como en el caso anterior, agregar un archivo al repositorio local y al remoto.
Además, si existe alguna modificación en el repositorio remoto, también la agrega al repositorio local y al workspace.

Esta opción, es una combinación de los comandos git push y git pull. Sin olvidarnos de los comandos git add y git commit para añadir los cambios
originados en el workspace al repositorio local.

# P7. ¿Cuál es la diferencia entre pulsa Sincronizar o Extraer? ¿Cuáles serían los comandos git equivalentes?

Extraer, agrega los commits del repositorio remoto que no poseemos al repositorio local. Sería el equivalente de ejecutar el comando git fetch.

En cambio, sincronizar, agrega los commits del repositorio remoto que no poseemos tanto al repositorio local, como al workspace. El equivalente de este suceso sería ejecutar el comando git pull.

# P8. ¿Qué significa Ramas > "Fusionar mediante combinación" y cuál sería el comando git equivalente?

"Fusionar mediante combinación" es un proceso en el cual se coge código en dos ramas y se combinan en una de ellas.
Si los ficheros que se han modificado son distintos los actualizará sobre la rama destino.

El comando git equivalente a esta opción de Team Explorer, sería la ejecución de git merge. En este caso, ejecutaríamos el comando
git merge devel situándonos previamente en la rama master.

# P9. ¿Qué significa Confirmar > "Fusionar mediante cambio de base" y cuál sería el comando git equivalente?

"Fusionar mediante cambio de base" unifica las ramas seleccionadas en un árbol lineal sin la necesidad de ejecutart un nuevo commit.
El comando git equivalente sería ejecutar git rebase. En este caso en concreto, nos situaríamos en la rama master y ejecutaríamos git merge devel2.

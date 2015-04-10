# Taller: Introducción a Unity

## I Semana de la Informática

### Facultad de Informática

### Universidad Complutense de Madrid

En este repositorio encontrarás el material relacionado con el Taller de Introducción a Unity celebrado el 13 de abril de 2015 dentro de los eventos de la [__I Semana de la Informática__](https://informatica.ucm.es/i-semana-de-la-informatica) celebrada en la [Facultad de Informática](https://informatica.ucm.es/) de la Universidad Complutense de Madrid. El resto de información sobre el taller [está disponible en esta página](http://gaia.fdi.ucm.es/files/people/guille/tallerUnity2015/).

En la sección de [Releases](https://github.com/GuilleUCM/TallerUnity/releases) tienes puntos intermedios del desarrollo del juego, así como una versión final completa del mismo.

#### Bug detectado

Se ha detectado un pequeño error en las releases, en el script [ScoreItem.cs](https://github.com/GuilleUCM/TallerUnity/blob/master/Assets/Scripts/ScoreItem.cs), de modo que al intentar añadirlo a los cristales muestra un mensaje de error. El error está corregido dentro del trunk del proyecto y se puede solucionar fácilmente sustituyendo en la línea 4 del script:

```
[RequireComponent (typeof (Collider))]
```

por 

```
[RequireComponent (typeof (Collider2D))]
``` 

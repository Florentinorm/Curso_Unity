# Creación de Video Juegos
<p align="center">
    <img src="https://www.industriaanimacion.com///wp-content/uploads/2021/11/4-6.jpg" alt="Logo" width=1200 height=300>

  <p align="center">
    Creación de videojuegos curso Junior Programmer
    <br>
  </p>
</p>


## Contenido
- [Introducción](#introducción)
- [Código Fuente](#código-fuente)
- [Autores](#autor)
- [Lenguaje y Herramientas](#lenguaje-y-herramientas)
- [Copyright](#copyright)

## Introducción

- Nombre del proyecto
  - Space Escape

- Objetivo
  - Derribar asteroides sin dejar que estos nos golpean, y evitar destruir naves amigas

- Plataforma ,Género, Clasificación, Personajes, Escenario.
  - Plataforma: 
    - Desktop
  - Género:
    - Aventura y Disparos
  - Clasificación:
    - Everyone E, contenido apto para todas las edades  
  - Personajes:
    - Nave Destructor Estelar, Nave de Control de Droides clase Lucrehulk
  - Escenario:
    - Espacio exterior, dentro de la nébula darkgreen
  - Tipo de Juego
    - 3D

- Historia
  - Es el año 3074, en el planeta Xandar dentro de la nébula darkgreen ahí se encuentra lo más preciado del universo la estrella del alma, el cual es de altamente valor, donde los Chandilar logran robar esta preciada reliquia, huyen dentro de la nave llamada Destructor Estelar llamada así por sus gran tamaño, y su poder de destrucción que tan solo viéndola es de imponer respeto, los Chandilar se tienen que enfrentar a muchas adversidades como la lluvia de meteoritos que es una característica de la nébula darkgreen, pero no solo de eso se deben de preocupar si no también deben escapar de la guardia galáctica donde tienen naves es la de Control de Droides clase Lucrehulk, caracterizada por su forma en punto y sus destructores rayos lazer los cuales deben de evitar a toda costa. 

- Reglas de Juego.
  - El jugador debe de destruir o esquivar los asteroides, así como las naves
  - El juego termina si:
    - Si el jugador chocado por un asteroide
    - Si es impactado por un rayo láser de las naves
    - Si el jugador tiene una colisión con una nave el juego se termina
  - Puntuación:
    - Destrucción de:
      - Mina   = +1  puntos
      - Ateroide de hielo   = +3  puntos
      - Asteroide de lava  = +5  puntos
      - Nave enemiga       = +10 puntos
  - Disparos:
	  - Solo tendrá 4 disparos por segundo
  - Control del juego
    - [Ver controles del juego](img/control-del-juego.png)
  - Vidas:
	  - 1 vida
  - Dificultad 
	  - Acumulativa (+5 asteroides cada ronda)
    - Velocidad acumulativa (+5 en cada ronda)
	  - Tiempo de espera de 5 segundos entre ronda
	  - Probabilidad de 14% que aparezca alguna nave enemiga


- Pantallas de Juego
  - Escena del juego
    - ![scene-game](img/scene-game.png)

- Plan de creación de VideoJuego
  - [Tablero Space Escape](https://sharing.clickup.com/24530945/g/h/qcm01-85/b473a7031a11b6d)
  - ![gant](img/gant.png)

- Configuración del entorno para el juego 
  - **IMPORTANTE:** Para tener una mejor experiencia es necesario agregar un nuevo aspecto, por lo que se recomienda ir al apartado de **Game** después dirigirse a **Free Aspect** y oprimir el símbolo de **+**, posteriormente agregaremos uno nuevo **Label** con el nombre que sea recomendamos **Space Shooter** después el **Width & Height** pondremos **600 x 900**
  - [Manual](img/Manual.png)

- Versiones 
  - Versión 1: 
    - Se agrego el plano con una textura de nébula 
    - Se agrego la nave igual que se hace que pueda moverse sin salirse del plano además de disparar
    - Se agregaron los meteoritos y cada uno tiene un movimiento diferente
    - Espaunean los meteoritos 
    - Se destruyen todos los objetos que salen del cuadro 
    - Se agregaron las animaciones de explosiones 
    - Se agrego el sonido 
    - Se agregaron los scripts que destruyen a los asteroides y a la nave 
    - [Space Escape V1](https://github.com/Florentinorm/Curso_Unity/blob/main/Space%20Shooter/Space%20Shooter%20V1.unitypackage)

  - Versión 2:
    - Se agrego la puntuación (Score)
    - Se agrego el Juego terminado (Game Over)
    - Se agrego una manera de reiniciar el juego
    - Se agregaron nuevos asteroides con puntuación y velocidades distintas
    - Se implemento la funcionalidad que con cada ronda aumenten (+5) los asteroides
    - A cada tipo de asteroide se le asignó un valor
    - Se implemento la velocidad de los asteroides (+5) conforme cada ronda pase
    - [Space Escape V2](https://github.com/Florentinorm/Curso_Unity/blob/main/Space%20Escape/Space%20Escape%20V2.unitypackage)

  - Versión 3:
    - Se crea el scroll parallax, que hace que el fondo tenga movimiento
    - Se agregaron estrellas al escenario
    - Se creo la nave enemiga
    - Se creo la manera en que pueda disparar
    - [Space Escape V3](https://github.com/Florentinorm/Curso_Unity/blob/main/Space%20Escape/Space%20Escape%20V3.unitypackage)

  - Versión 4:
    - Se agregaron nuevos assets 
    - Se cambio el diseño de las naves
    - Se agregaron minas, asteroides de lava y hielo 
    - Se cambio el fonde de la nébula por uno de mas colores

    - [Space Escape V4](https://mega.nz/file/D6BklCwR#plDInTbegzgmDY6vHTeBpkuySu-2KPFlW9I1kWIl9ls) *Importación desde MEGA, peso estimado 157.6 MB*

- Autores del juego "Space Escape"
  - Ramírez Balderas Florentino - 1219100383
  - Hernández Salazar Diego Joan - 1219100490


## Código Fuente
* Lección 1 - Player Control
  * > [Tutorial 1 - Player Control](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%201%20-%20Player%20Control/Unit%201%20-%20Player%20Control)
  * > [Desafío 1 - Plane Programming](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%201%20-%20Player%20Control/Challenge%201%20-%20Plane%20Programming)
  * > [Video 1 - Plane Programming](https://drive.google.com/file/d/1sdTbtyLJXs9oKxYURwrJO58VVyJozHHB/view?usp=sharing)
  * > [Laboratorio 1 - Project Design Document](https://drive.google.com/file/d/1R6tkGhJorwGi9YTQ3RLckeeuJ72jfLJU/view?usp=sharing)
  * > [Prueba 1](https://github.com/Florentinorm/Curso_Unity/blob/main/Lecci%C3%B3n%201%20-%20Player%20Control/Quiz%201%20-%20Unit%201%20-%20Player%20Control.png)

* Lección 2 - Basic Game Play
  * > [Tutorial 2 - Basic Gameplay](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%202%20-%20Basic%20Game%20Play/Unit%202%20-%20Basic%20Gameplay)
  * > [Desafío 2 - Play Fetch](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%202%20-%20Basic%20Game%20Play/Challenge%202%20-%20Play%20Fetch)
  * > [Video 2 - Play Fetch](https://drive.google.com/file/d/1BkZQpGCWyH1L0HM8wkKRgplz04OJhoEt/view?usp=sharing)
  * > [Laboratorio 2 - New Project with Primitives](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%202%20-%20Basic%20Game%20Play/Lab%202%20-%20New%20Project%20with%20Primitives)
  * > [Prueba 2](https://github.com/Florentinorm/Curso_Unity/blob/main/Lecci%C3%B3n%202%20-%20Basic%20Game%20Play/Quiz%202%20-%20Unit2%20-%20Basic%20Gameplay.png)

* Lección 3 - Sound and Efffects
  * > [Tutorial 3 - Sound and Efffects ](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%203%20-%20Sound%20and%20Efffects/Unit%203%20-%20Sound%20and%20Efffects)
  * > [Desafío 3 - Balloons, Bombs, & Booleans](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%203%20-%20Sound%20and%20Efffects/Challenge%203%20-%20Balloons%2C%20Bombs%2C%20%26%20Booleans)
  * > [Video 3 - Balloons, Bombs, & Booleans](https://drive.google.com/file/d/1I8mAmhb6XU6_lWaiPIn116uVsCBic-vX/view?usp=sharing)
  * > [Laboratorio 3 - Player Control](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%203%20-%20Sound%20and%20Efffects/Lab%203%20-%20Player%20Control)
  * > [Prueba 3](https://github.com/Florentinorm/Curso_Unity/blob/main/Lecci%C3%B3n%203%20-%20Sound%20and%20Efffects/Quiz%203%20-%20Unit%203%20-%20Sound%20and%20Efffects.png)

* Lección 4 - GamePlay Mechanics
  * > [Tutorial 4 - Gameplay Mechanics](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%204%20-%20GamePlay%20Mechanics/Unit%204%20-%20Gameplay%20Mechanics)
  * > [Desafío 4 - Soccer Scripting](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%204%20-%20GamePlay%20Mechanics/Challenge%204%20-%20Soccer%20Scripting)
  * > [Video 4 - Soccer Scripting](https://drive.google.com/file/d/1oxvGdIbeUxvKnpMDuxrTPWLVlm_dCQth/view?usp=share_link)
  * > [Laboratorio 4 - Basic Gameplay](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%204%20-%20GamePlay%20Mechanics/Lab%204%20-%20Basic%20Gameplay)
  * > [Prueba 4](https://github.com/Florentinorm/Curso_Unity/blob/main/Lecci%C3%B3n%204%20-%20GamePlay%20Mechanics/Quiz%204.png)


* Lección 5 - User Interface
  * > [Tutorial 5 - User Interface](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%205%20-%20User%20Interface/Unit%205%20-%20User%20Interface)
  * > [Desafío 5 - Whack-a-Food](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%205%20-%20User%20Interface/Challenge%205%20-%20Whack-a-Food)
  * > [Video 5 - Whack-a-Food](https://drive.google.com/file/d/1j657hBBIsBzMIORCM_QOX_3kBnUrkTs9/view?usp=sharing)
  * > [Laboratorio 5 - Swap out yours Assets](https://github.com/Florentinorm/Curso_Unity/tree/main/Lecci%C3%B3n%205%20-%20User%20Interface/Lab%205%20-%20Swap%20out%20your%20Assets)
  * > [Prueba 5](https://github.com/Florentinorm/Curso_Unity/blob/main/Lecci%C3%B3n%205%20-%20User%20Interface/Quiz%205%20-%20Lecci%C3%B3n%205%20-%20User%20Interface.png)

## Autor
Ramírez Balderas Florentino 

## Lenguaje y Herramientas
<p align="left"> <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> <a href="https://unity.com/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/unity3d/unity3d-icon.svg" alt="unity" width="40" height="40"/> </a> </p>

## Copyright
Derechos Reservados 2022


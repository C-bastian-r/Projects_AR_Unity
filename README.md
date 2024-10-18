# Proyectos de AR haciendo uso de Unity y Vuforia
Se presenta en este repositorio dos proyectos de realidad aumentada a traves de el motor Unity y las bibliotecas de Vuforia
## Sistema solar
### path escena: Assets/SolarSystemProject/Scenes/SolarSystemScene.unity
Sistema solar construido con base a un unico ImageTarget. Se hace uso de URP en la escena para el apartado grafico.
Se emplea una ARCamera con el renderizado desactivado a modo de detección de la ImageTarget, y una MainCamera con CineMachine 
para generar tomas especificas al oprimir sobre los modelos 3D.

## Planeta con Animales MultiTarget
### path escena: Assets/QubeProject/Scenes/QubeProjectScene.unity
Escena de un planeta con modelos 3D de animales animados y canvas con información descriptiva de la especie. Cuenta con un multitarget en forma de cubo, que permite desplazarse a traves de los diferentes ejes de la escena, correspondientes a las caras del mismo.


# Normas de asociación de palabras (NAP)
Este software sirve para calcular diversas medidas de asociación de palabras a partir de los resultados de experimentos en los que las personas reciben palabras estímulo y generan una respuesta.  El proyecto está implementado en Windows Forms con C# y con bases de datos relacionales con MySQL.

##  Contenido
* [Información general](#información-general)
* [Requisitos](#requisitos)
* [Configuración  del proyecto](#configuración-del-proyecto )
* [Cómo usar el software](#cómo-usar-el-software)
* [Status del proyecto](#status-del-proyecto)
* [Motivación](#motivación)
* [Contacto](#contacto)

## Información general
El software sirve para realizar consultas a las bases de datos de los resultados de los experimentos. Además, puedes generar nuevos cálculos según los requerimientos de tus experimentos. Todos los resultados pueden exportarse de forma automática a una hoja de Excel. Por ejemplo, los datos se pueden consultar de forma agrupada según las siguientes opciones y sus diferentes combinaciones :

![alt text](https://github.com/YOSSHUA/LAB-PSICOLINGUISTICA/blob/master/others/diag.PNG?raw=true)

Algunos investigadores lo han usado para comparar las respuestas de personas sanas y personas que desarrollaron enfermedades neuro degenerativas para ver si se podía predecir qué personas podían desarrollar dichas enfermedades.

## Requisitos
Para el proyecto se utilizaron las versiones de 2013, entonces puedes utilizar cualquier versión a partir de ese año.
* Visual Studio (versión >= 2013). [Descárgalo aquí](https://visualstudio.microsoft.com/es/downloads/)
* MySQLWorkbench. [Descárgalo aquí](https://dev.mysql.com/downloads/workbench/)
	* Conector entre MySQL y Visual Studio.  [Descárgalo aquí](https://dev.mysql.com/downloads/connector/net/6.10.html)
* MariaDB. [Descárgalo aquí](https://mariadb.org/download/)
	* Conector ODBC. [Descárgalo aquí](https://downloads.mariadb.org/connector-odbc/)

##  Configuración del proyecto

###  1. Configuración de MySQLWorkbench
1. Primero debes configurar lo necesario en MySQLWorkbench para poder manipular la base de datos. [Tutorial](https://www.ecodeup.com/aprende-a-instalar-mysql-y-mysql-workbench-en-windows-10/)
### 2. Importación de la base de datos
1. Descarga el archivo de la base de datos [aquí](https://github.com/YOSSHUA/LAB-PSICOLINGUISTICA/tree/master/bd).
2. Abre MySQLWorkbench.
3. Inicia sesión con el usuario que vas a utilizar para las consultas a la base de datos.
4. Importa la base de datos con el archivo `.sql` que descargaste. [Ver ejemplo](https://www.raulprietofernandez.net/blog/bases-de-datos/como-exportar-e-importar-una-base-de-datos-mysql-desde-workbench).
###  3. Configuración de Visual Studio
1.  Abre Visual Studio.
2.  Clona el repositorio del proyecto. [Ver ejemplo](https://docs.microsoft.com/en-us/visualstudio/ide/git-with-visual-studio?view=vs-2019)
3. Genera un ejecutable dando clic a *Construir solución* 


![alt text](https://github.com/YOSSHUA/LAB-PSICOLINGUISTICA/blob/master/others/build.PNG?raw=true)


Ya se configuró todo y está listo para usarse.

## Cómo usar el software
Una vez que configuraste todo lo necesario basta con ejecutar el archivo desde Visual Studio, o bien, puedes tomar el proyecto y modificarlo para tus experimentos.

### Página principal
![alt text](https://github.com/YOSSHUA/LAB-PSICOLINGUISTICA/blob/master/others/index.PNG?raw=true )
En la sección de [Consultar medidas porcentuales](#consm) podrás generar tus propios archivos a partir de la base de datos.
En la sección de [Consulta de datos por ID](#cons) podrás consultar los resultados de los participantes.
En la sección de *Descarga de excel de medidas porcentuales* puedes bajar el archivo que calcula las medidas tomando en cuenta a todas las personas de la muestra.

### <a id="consm"></a> Consulta de medidas porcentuales
En la parte superior izquierda de la ventana encontrarás el menú para filtrar los datos. 
En la parte inferior izquierda de la ventana puedes encontrar los botones para mostrar la información de los distintos elementos que se usan en la pantalla.
![alt text](https://github.com/YOSSHUA/LAB-PSICOLINGUISTICA/blob/master/others/opc.PNG?raw=true )
Una vez que seleccionas la opción te va a pedir datos diferente según lo necesario para la clasificación. Por ejemplo, si incluyes la edad te pide el rango de edades que quieres incluir.
![alt text](https://github.com/YOSSHUA/LAB-PSICOLINGUISTICA/blob/master/others/opcs.PNG?raw=true )

Aquí te dejo un ejemplo de cómo será el resultado. 
En la primera tabla aparecen las frecuencias de las palabras, su porcentaje de aparición y el tiempo promedio de respuesta.
En la segunda tabla aparecen las clasificaciones por tipo de respuesta.
Finalmente del lado derecho aparecen las diferentes medidas calculadas.

![alt text](https://github.com/YOSSHUA/LAB-PSICOLINGUISTICA/blob/master/others/ej.PNG?raw=true )
Observa que puedes exportar en un archivo de Excel todas las medidas para cada palabra de la base de datos dadas las características que seleccionaste.
### <a id="cons"></a> Consulta de datos por ID
En esta sección puedes seleccionar el ID de la persona y te aparecerán los resultados de su prueba al dar clic en *Buscar ID*. 
Si quieres ver toda la información puedes dar clic al botón que dice *Buscar todos los ID'S*.

![alt text](https://github.com/YOSSHUA/LAB-PSICOLINGUISTICA/blob/master/others/cons.PNG?raw=true )

## Status del proyecto
El proyecto no se encuentra en desarrollo, pero se puede editar para evaluar diferentes bases de datos. 

## Motivación
Este proyecto se desarrollo como parte del Programa Delfín 2018 en el Verano de Investigación para el Laboratorio de Psicolingüística de la UNAM. [Conocer más sobre el laboratorio](http://www.labpsicolinguistica.psicol.unam.mx/index.html).

## Contacto
Cualquier duda y/o comentario puedes contactarme a través de mi correo: yocisneros@outlook.com 

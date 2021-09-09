# Writer-Kata
vas a crear una aplicación de consola que preguntará en qué formato quieres la salida del objeto que tiene en memoria
así pues al final tendrás un archivo llamado
```
nombreQueTeInventes.json
nombreQueTeInventes.xml
nombreQueTeInventes.yml
nombreQueTeInventes.txt
```

#### Parte 1

Vas a crear
* un objeto Writter el cual obtiene un formateador por el constructor
* el objeto writter le pide al formato el nombre de extensión
* el objeto Writter escribe en un archivo lo que le devuelve el formateador

* una serie de formateadores que provee de una trasformación del objeto y de una extensión de archivo
(no hace falta que creéis la serialización en los formateadores, podéis devolver hola mundo desd xmls, o desde json)

* una clase Factory la cual le pasaras un comando y te devolverá un objeto Writer con el formateador pasado
* la clase Factory recibe por ctor un diccionario o lista de tuplas o array de dos dimensiones o .... con la relación entre un 
string { json, xml, plain} y las implementaciones de formateadores { jsonformateador, xmlformateador, plainformateador} (o si queréis enum de tipos en vez de string)
* la clase Factory se declara en el contenedor

* por consola podéis hacer conseguir los formatos del contenedor y escribir las opciones (por ej) o a piñon en un texto

* Escribid el código de tal manera que empecéis con un número N de Formatos y si incluís alguno más el código no se ve afectado, (aparte quizás del mensaje por consola)
> **NO QUIERO QUE UTILICES IFs**

> Debéis de usar Tests para asegurar vuestro código, podéis usarlos como guías del desarrollo y empezar por ellos


#### Parte 2
Ahora, cambias la lógica para que cdo empiece la aplicación lo primero que hagáis es una pregunta preguntando si quieres que escriba en un archivo o en la nube (no es necesario que lo haga) y después monte el contenedor basándose en esta decisión y cada vez que le pidas uno te devuelva el montado (tip: 2 FactoryWriters + el builder le pasamos la decisión, utilizad IFs en el contenedor)






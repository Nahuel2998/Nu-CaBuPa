drop database jvrpdatabase;
create database jvrpdatabase;
use jvrpdatabase;

CREATE TABLE `funcion` (
  `ID_Funcion` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(128) NOT NULL,
Nombre varchar(16) not null,
  PRIMARY KEY (ID_Funcion)
);
CREATE TABLE `funcionario` (
  `ID_Funcionario` int(6) unsigned NOT NULL AUTO_INCREMENT,
`Telefono` varchar(16) DEFAULT NULL,
  `nombre` varchar(48) NOT NULL,
`Mail` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`ID_Funcionario`)
);
CREATE TABLE `acceso` (
  `id_acceso` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `seccion` varchar(8) NOT NULL,
  `tipo` varchar(2) NOT NULL,
  PRIMARY KEY (`id_acceso`)
);
CREATE TABLE `evento` (
  `ID_Evento` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  `ID_Video` int(6) unsigned,
  PRIMARY KEY (`ID_Evento`),
  Foreign KEY (ID_Video)references Video(`ID_Video`)
);
CREATE TABLE `empresa` (
  `ID_Empresa` int(6) unsigned NOT NULL AUTO_INCREMENT,
`Nombre` varchar(64) NOT NULL,
  `Telefono` varchar(16) DEFAULT NULL,
`Mail` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`ID_Empresa`)
);
CREATE TABLE `publicidad` (
  `ID_Publicidad` int(6) unsigned NOT NULL AUTO_INCREMENT,
 `Nombre` varchar(32) NOT NULL,
  `Tema` varchar(64) NOT NULL,
  `ID_Empresa` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Publicidad`),
  Foreign KEY (ID_Empresa) references Empresa(`ID_Empresa`)
);
CREATE TABLE `usuarios` (
  `id_usuario` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(16) NOT NULL,
  `contrasena` varbinary(256) NOT NULL,
  PRIMARY KEY (`id_usuario`)
);
CREATE TABLE `tanda` (
  `Hora_Inicio` time NOT NULL,
  `Hora_Fin` time NOT NULL,
PRIMARY KEY (`Hora_Inicio`)
);
CREATE TABLE `serie` (
  `ID_Serie` int(6) unsigned NOT NULL AUTO_INCREMENT,
`fecha_finalizacion` date DEFAULT NULL,
`nombre` varchar(48) NOT NULL,
  PRIMARY KEY (`ID_Serie`)
);
CREATE TABLE `video` (
  `ID_Video` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `contenido` varchar(128) NOT NULL,
  `nombre` varchar(48) NOT NULL,
  `ID_Serie` int(6) unsigned DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`ID_Video`),
Foreign KEY (ID_Serie) references Serie(`ID_Serie`)
);
CREATE TABLE `programa` (
  `ID_Programa` int(6) unsigned NOT NULL AUTO_INCREMENT,
`Nombre_Programa` varchar(48) NOT NULL,
  `Descripcion` varchar(128) DEFAULT NULL,
  `Fecha_Finalizacion` datetime DEFAULT NULL,
PRIMARY KEY (`ID_Programa`)
);


CREATE TABLE `aparecepubli` (
  `ID_Publicidad` int(6) unsigned NOT NULL,
`Hora_Inicio` time NOT NULL,
  `Fecha_Inicio` date NOT NULL,
  `Fecha_Finalizacion` date DEFAULT NULL,
  PRIMARY KEY (`ID_Publicidad`,`Hora_Inicio`,`Fecha_Inicio`),
Foreign KEY (Hora_Inicio) references Tanda(Hora_Inicio),
Foreign key (ID_Publicidad) references Publicidad(ID_Publicidad)
);

CREATE TABLE `eventomuestrapubli` (
  `ID_Evento` int(6) unsigned NOT NULL,
  `ID_Publicidad` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Evento`,`ID_Publicidad`),
  Foreign KEY (ID_Publicidad) references Publicidad(`ID_Publicidad`),
Foreign KEY (ID_Evento) references Evento(ID_Evento)
);
CREATE TABLE `fechaevento` (
  `ID_Evento` int(6) unsigned NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`ID_Evento`,`fecha`),
Foreign key (ID_Evento) references Evento(ID_Evento)
);
CREATE TABLE `fechaprograma` (
  `Fecha` date NOT NULL,
  `Hora_Inicio` time NOT NULL,
  `Hora_Fin` time NOT NULL,
  `ID_Programa` int(6) unsigned DEFAULT NULL,
PRIMARY KEY (`Fecha`,`Hora_Inicio`),
Foreign KEY (ID_Programa) references Programa(`ID_Programa`)
);
CREATE TABLE `trabajacomo` (
ID_TrabajaComo int(6) unsigned not null auto_increment,
  `ID_Funcionario` int(6) unsigned NOT NULL,
  `ID_Funcion` int(6) unsigned NOT NULL,
  PRIMARY KEY (ID_TrabajaComo),
  Foreign KEY (ID_Funcion) references Funcion(`ID_Funcion`),
Foreign KEY (ID_Funcionario) references Funcionario(ID_Funcionario)
);
CREATE TABLE `funtrabaja` (
  `ID_TrabajaComo` int(6) unsigned NOT NULL,
  `ID_Programa` int(6) unsigned NOT NULL,
`fecha_inicio` date NOT NULL,
  `fecha_finalizacion` date DEFAULT NULL,
  PRIMARY KEY (`ID_TrabajaComo`,`ID_Programa`,`fecha_inicio`),
Foreign KEY (ID_TrabajaComo) references Funcion(`ID_Funcion`),
Foreign KEY (ID_Programa)references Programa(`ID_Programa`)
);
CREATE TABLE `pmuestrapubli` (
  `ID_Publicidad` int(6) unsigned NOT NULL,
  `ID_Programa` int(6) unsigned NOT NULL,
`Fecha_Inicio` date NOT NULL,
  `Fecha_Finalizacion` date DEFAULT NULL,
  PRIMARY KEY (`Fecha_Inicio`,`ID_Programa`,`ID_Publicidad`),
Foreign KEY (ID_Programa) references Programa(`ID_Programa`),
  Foreign KEY (ID_Publicidad) references Publicidad(`ID_Publicidad`)
);
CREATE TABLE `programacuota` (
  `ID_Programa_Cuota` int(6) unsigned NOT NULL,
  `ID_Programa` int(6) unsigned NOT NULL,
`Fecha_Pago` date DEFAULT NULL,
`Precio` decimal(5,2) unsigned NOT NULL,
  `Fecha_Emision` date NOT NULL,
  PRIMARY KEY (`ID_Programa_Cuota`),
Foreign KEY (ID_Programa) references Programa(`ID_Programa`)
);
CREATE TABLE `publicidadcuota` (
  `ID_PublicidadCuota` int(6) unsigned NOT NULL AUTO_INCREMENT,
`Fecha_Pago` date DEFAULT NULL,
`Precio` int(6) unsigned NOT NULL,
  `ID_Publicidad` int(6) unsigned NOT NULL,
  `Fecha_Emision` date NOT NULL,
  PRIMARY KEY (`ID_PublicidadCuota`),
  Foreign KEY (ID_Publicidad) references Publicidad(`ID_Publicidad`)
);
CREATE TABLE `ustieneacceso` (
`id_usuario` int(6) unsigned NOT NULL,
  `id_acceso` int(6) unsigned NOT NULL,
  PRIMARY KEY (`id_usuario`,`id_acceso`),
  Foreign KEY (id_acceso) references acceso(`id_acceso`)
);




INSERT INTO `acceso` VALUES (1,'Inicio','ac'),(2,'Eventos','ac'),(4,'Empresa','xr'),(5,'nnnn','xr'),(6,'Hola','S'),(7,'Hola','S'),(8,'Hola','S'),(9,'Hola','S'),(10,'Hola','S'),(11,'Hola','S'),(3,'Serie','ac');

INSERT INTO `empresa` VALUES (1,'Mil','113','dd'),(3,'NuCaBuPA',NULL,NULL);

INSERT INTO `evento` VALUES (1,'My ','None'),(2,'We','None');

INSERT INTO `programa` VALUES (1,'lol','The best',NULL),(2,'A es una vocal','The best program',NULL),(3,'Meles program','The program',NULL),(4,'Relleno con Mateo','The',NULL),(5,'Proof or report Manuel','The',NULL);

INSERT INTO `fechaevento` VALUES (1,'2020-12-12 00:00:00'),(1,'2020-11-12 00:00:00'),(2,'2020-11-06 00:00:00');

INSERT INTO `fechaprograma` VALUES ('2020-08-10','07:14:10','18:14:10',1),('2020-08-10','06:14:10','17:14:10',1),('2020-08-10','00:14:10','12:14:10',1),('2020-08-11','09:05:00','21:20:00',3),('2020-08-11','12:30:00','00:00:13',4),('2020-08-12','13:30:00','00:00:14',5),('0000-00-00','10:30:00','14:50:00',2),('2020-10-11','10:20:00','23:10:00',2);

INSERT INTO `funcion` VALUES (1,'Trabaja','Funcionar'),(2,'Trabaja','Peren'),(3,'Trabaja','Pere'),(4,'Trabaja','');

INSERT INTO `funcionario` VALUES (1,'34244','Manuel',NULL),(2,'34244','Mili',NULL),(3,'9483948','Mateo',NULL),(4,'2998','Nahuel',NULL);

INSERT INTO `funtrabaja` VALUES (2,2,'2020-10-07',NULL),(1,2,'2020-10-07',NULL),(3,2,'2020-10-07',NULL),(4,2,'2020-10-07',NULL),(5,2,'2020-10-07',NULL);

INSERT INTO `pmuestrapubli` VALUES (1,3,'2020-04-09','2020-10-10'),(2,3,'2020-04-09','2020-10-10'),(1,4,'2020-04-09','2020-08-09'),(2,1,'2020-04-09','2020-08-10'),(3,1,'2020-02-19','2020-12-12');

INSERT INTO `publicidad` VALUES (1,'De todo un poco',1,''),(2,'Nadita',2,''),(3,'Mili',1,'');

INSERT INTO `serie` VALUES (10,NULL,'Voces'),(5,NULL,'holis'),(11,'2020-10-09','Seri1');

INSERT INTO `tanda` VALUES ('01:00:00','03:00:00'),('03:00:00','05:00:00'),('05:00:00','10:00:00'),('10:00:00','05:00:00'),('15:00:00','16:00:00'),('16:00:00','20:00:00'),('20:00:00','24:00:00');
INSERT INTO `aparecepubli` VALUES (1,'21:05:00','2020-08-09','2020-08-10'),(2,'21:05:00','2020-08-09','2020-08-31'),(1,'22:05:00','2020-08-09','2020-08-10'),(2,'22:05:00','2020-08-09','2020-08-31'),(1,'15:05:00','2020-08-01','2020-08-30'),(1,'05:00:00','2020-02-09','2020-08-19'),(2,'15:00:00','2020-02-09','2020-08-19'),(3,'15:00:00','2020-02-09','2020-08-19'),(2,'16:00:00','2020-02-09','2020-08-19'),(1,'20:00:00','2020-02-09','2020-08-19');

INSERT INTO `trabajacomo` VALUES (1,0,0),(2,4,1),(3,3,2),(4,2,1),(5,1,3);

INSERT INTO `ustieneacceso` VALUES (1,5),(1,6),(1,8),(1,9),(1,10),(2,1),(2,5),(2,6),(2,10),(2,11);

INSERT INTO `video` VALUES (4,'adios','hola',NULL,NULL),(3,'nofffffffdddddgddcdd','LOLd',11,'2020-08-08');


INSERT INTO `usuarios` VALUES (1,'m',_binary '°6µ\Ï\í¦#÷BýO 9'),(2,'d',_binary '°6µ\Ï\í¦#÷BýO 9');
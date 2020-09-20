CREATE DATABASE  IF NOT EXISTS `jvrpdatabase` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `jvrpdatabase`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: jvrpdatabase
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `acceso`
--

DROP TABLE IF EXISTS `acceso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `acceso` (
  `id_acceso` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `seccion` varchar(8) NOT NULL,
  `tipo` varchar(2) NOT NULL,
  PRIMARY KEY (`id_acceso`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acceso`
--

LOCK TABLES `acceso` WRITE;
/*!40000 ALTER TABLE `acceso` DISABLE KEYS */;
INSERT INTO `acceso` VALUES (1,'none','rw'),(3,'ninguna','xr'),(4,'ninguna','xr'),(5,'nnnn','xr');
/*!40000 ALTER TABLE `acceso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aparecepubli`
--

DROP TABLE IF EXISTS `aparecepubli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aparecepubli` (
  `ID_Publicidad` int(6) unsigned NOT NULL,
  `Hora_Inicio` time NOT NULL,
  `Fecha_Inicio` date NOT NULL,
  `Fecha_Finalizacion` date DEFAULT NULL,
  PRIMARY KEY (`ID_Publicidad`,`Hora_Inicio`,`Fecha_Inicio`),
  KEY `Hora_Inicio` (`Hora_Inicio`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aparecepubli`
--

LOCK TABLES `aparecepubli` WRITE;
/*!40000 ALTER TABLE `aparecepubli` DISABLE KEYS */;
INSERT INTO `aparecepubli` VALUES (1,'21:05:00','2020-08-09','2020-08-10'),(2,'21:05:00','2020-08-09','2020-08-31'),(1,'22:05:00','2020-08-09','2020-08-10'),(2,'22:05:00','2020-08-09','2020-08-31'),(1,'15:05:00','2020-08-01','2020-08-30'),(1,'05:00:00','2020-02-09','2020-08-19'),(2,'15:00:00','2020-02-09','2020-08-19'),(3,'15:00:00','2020-02-09','2020-08-19'),(2,'16:00:00','2020-02-09','2020-08-19'),(1,'20:00:00','2020-02-09','2020-08-19');
/*!40000 ALTER TABLE `aparecepubli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empresa` (
  `ID_Empresa` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(64) NOT NULL,
  `Telefono` varchar(16) DEFAULT NULL,
  `Mail` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`ID_Empresa`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
INSERT INTO `empresa` VALUES (1,'Mil','113',NULL),(2,'DosMil','45',NULL);
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `evento` (
  `ID_Evento` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  PRIMARY KEY (`ID_Evento`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
INSERT INTO `evento` VALUES (1,'My ','None'),(2,'We','None');
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eventoesdep`
--

DROP TABLE IF EXISTS `eventoesdep`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `eventoesdep` (
  `ID_Programa` int(6) unsigned NOT NULL,
  `ID_Evento` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Programa`,`ID_Evento`),
  KEY `ID_Evento` (`ID_Evento`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventoesdep`
--

LOCK TABLES `eventoesdep` WRITE;
/*!40000 ALTER TABLE `eventoesdep` DISABLE KEYS */;
/*!40000 ALTER TABLE `eventoesdep` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eventoesdev`
--

DROP TABLE IF EXISTS `eventoesdev`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `eventoesdev` (
  `ID_Evento` int(6) unsigned NOT NULL,
  `ID_Video` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Evento`,`ID_Video`),
  KEY `ID_Video` (`ID_Video`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventoesdev`
--

LOCK TABLES `eventoesdev` WRITE;
/*!40000 ALTER TABLE `eventoesdev` DISABLE KEYS */;
/*!40000 ALTER TABLE `eventoesdev` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `eventomuestrapubli`
--

DROP TABLE IF EXISTS `eventomuestrapubli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `eventomuestrapubli` (
  `ID_Evento` int(6) unsigned NOT NULL,
  `ID_Publicidad` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Evento`,`ID_Publicidad`),
  KEY `ID_Publicidad` (`ID_Publicidad`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eventomuestrapubli`
--

LOCK TABLES `eventomuestrapubli` WRITE;
/*!40000 ALTER TABLE `eventomuestrapubli` DISABLE KEYS */;
/*!40000 ALTER TABLE `eventomuestrapubli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fechaevento`
--

DROP TABLE IF EXISTS `fechaevento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fechaevento` (
  `ID_Evento` int(6) unsigned NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`ID_Evento`,`fecha`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fechaevento`
--

LOCK TABLES `fechaevento` WRITE;
/*!40000 ALTER TABLE `fechaevento` DISABLE KEYS */;
INSERT INTO `fechaevento` VALUES (1,'2020-08-12 00:00:00'),(1,'2020-09-12 00:00:00'),(2,'2020-08-12 00:00:00');
/*!40000 ALTER TABLE `fechaevento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fechaprograma`
--

DROP TABLE IF EXISTS `fechaprograma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fechaprograma` (
  `Fecha` date NOT NULL,
  `Hora_Inicio` time NOT NULL,
  `Hora_Fin` time NOT NULL,
  `ID_Programa` int(6) unsigned DEFAULT NULL,
  PRIMARY KEY (`Fecha`,`Hora_Inicio`),
  KEY `ID_Programa` (`ID_Programa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fechaprograma`
--

LOCK TABLES `fechaprograma` WRITE;
/*!40000 ALTER TABLE `fechaprograma` DISABLE KEYS */;
INSERT INTO `fechaprograma` VALUES ('2020-08-10','07:14:10','18:14:10',1),('2020-08-10','06:14:10','17:14:10',1),('2020-08-10','00:14:10','12:14:10',1),('2020-08-11','09:05:00','21:20:00',3),('2020-08-11','12:30:00','00:00:13',4),('2020-08-12','13:30:00','00:00:14',5);
/*!40000 ALTER TABLE `fechaprograma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcion`
--

DROP TABLE IF EXISTS `funcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcion` (
  `ID_Funcion` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(128) NOT NULL,
  PRIMARY KEY (`ID_Funcion`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcion`
--

LOCK TABLES `funcion` WRITE;
/*!40000 ALTER TABLE `funcion` DISABLE KEYS */;
INSERT INTO `funcion` VALUES (1,'Trabaja'),(2,'Trabaja'),(3,'Trabaja'),(4,'Trabaja');
/*!40000 ALTER TABLE `funcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcionario` (
  `ID_Funcionario` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Telefono` varchar(16) DEFAULT NULL,
  `nombre` varchar(48) NOT NULL,
  `Mail` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`ID_Funcionario`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` VALUES (1,'34244','Manuel',NULL),(2,'34244','Mili',NULL),(3,'9483948','Mateo',NULL),(4,'2998','Nahuel',NULL);
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funtrabaja`
--

DROP TABLE IF EXISTS `funtrabaja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funtrabaja` (
  `ID_Funcionario` int(6) unsigned NOT NULL,
  `ID_Funcion` int(6) unsigned NOT NULL,
  `ID_Programa` int(6) unsigned NOT NULL,
  `fecha_inicio` date NOT NULL,
  `fecha_finalizacion` date DEFAULT NULL,
  PRIMARY KEY (`ID_Funcionario`,`ID_Funcion`,`ID_Programa`,`fecha_inicio`),
  KEY `ID_Funcion` (`ID_Funcion`),
  KEY `ID_Programa` (`ID_Programa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funtrabaja`
--

LOCK TABLES `funtrabaja` WRITE;
/*!40000 ALTER TABLE `funtrabaja` DISABLE KEYS */;
INSERT INTO `funtrabaja` VALUES (1,1,3,'0000-00-00',NULL),(2,1,3,'0000-00-00',NULL),(3,1,3,'0000-00-00',NULL),(4,1,3,'0000-00-00',NULL),(1,1,4,'0000-00-00',NULL),(2,1,4,'0000-00-00',NULL);
/*!40000 ALTER TABLE `funtrabaja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pmuestrapubli`
--

DROP TABLE IF EXISTS `pmuestrapubli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pmuestrapubli` (
  `ID_Publicidad` int(6) unsigned NOT NULL,
  `ID_Programa` int(6) unsigned NOT NULL,
  `Fecha_Inicio` date NOT NULL,
  `Fecha_Finalizacion` date DEFAULT NULL,
  PRIMARY KEY (`Fecha_Inicio`,`ID_Programa`,`ID_Publicidad`),
  KEY `ID_Programa` (`ID_Programa`),
  KEY `ID_Publicidad` (`ID_Publicidad`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pmuestrapubli`
--

LOCK TABLES `pmuestrapubli` WRITE;
/*!40000 ALTER TABLE `pmuestrapubli` DISABLE KEYS */;
INSERT INTO `pmuestrapubli` VALUES (1,3,'2020-04-09','2020-10-10'),(2,3,'2020-04-09','2020-10-10'),(1,4,'2020-04-09','2020-08-09'),(2,1,'2020-04-09','2020-08-10'),(3,1,'2020-02-19','2020-12-12');
/*!40000 ALTER TABLE `pmuestrapubli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programa`
--

DROP TABLE IF EXISTS `programa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programa` (
  `ID_Programa` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre_Programa` varchar(48) NOT NULL,
  `Descripcion` varchar(128) DEFAULT NULL,
  `Fecha_Finalizacion` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_Programa`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programa`
--

LOCK TABLES `programa` WRITE;
/*!40000 ALTER TABLE `programa` DISABLE KEYS */;
INSERT INTO `programa` VALUES (1,'lol','The best',NULL),(2,'A es una vocal','The best program','0000-00-00 00:00:00'),(3,'Meles program','The program','0000-00-00 00:00:00'),(4,'Relleno con Mateo','The','0000-00-00 00:00:00'),(5,'Proof or report Manuel','The',NULL);
/*!40000 ALTER TABLE `programa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programacuota`
--

DROP TABLE IF EXISTS `programacuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programacuota` (
  `ID_Programa_Cuota` int(6) unsigned NOT NULL,
  `ID_Programa` int(6) unsigned NOT NULL,
  `Fecha_Pago` date DEFAULT NULL,
  `Precio` decimal(5,2) unsigned NOT NULL,
  `Fecha_Emision` date NOT NULL,
  PRIMARY KEY (`ID_Programa_Cuota`),
  KEY `ID_Programa` (`ID_Programa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programacuota`
--

LOCK TABLES `programacuota` WRITE;
/*!40000 ALTER TABLE `programacuota` DISABLE KEYS */;
/*!40000 ALTER TABLE `programacuota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicidad`
--

DROP TABLE IF EXISTS `publicidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publicidad` (
  `ID_Publicidad` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Tema` varchar(64) NOT NULL,
  `ID_Empresa` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Publicidad`),
  KEY `ID_Empresa` (`ID_Empresa`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicidad`
--

LOCK TABLES `publicidad` WRITE;
/*!40000 ALTER TABLE `publicidad` DISABLE KEYS */;
INSERT INTO `publicidad` VALUES (1,'De todo un poco',1),(2,'Nadita',2),(3,'Mili',1);
/*!40000 ALTER TABLE `publicidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicidadcuota`
--

DROP TABLE IF EXISTS `publicidadcuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publicidadcuota` (
  `ID_PublicidadCuota` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Fecha_Pago` date DEFAULT NULL,
  `Precio` int(6) unsigned NOT NULL,
  `ID_Publicidad` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_PublicidadCuota`),
  KEY `ID_Publicidad` (`ID_Publicidad`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicidadcuota`
--

LOCK TABLES `publicidadcuota` WRITE;
/*!40000 ALTER TABLE `publicidadcuota` DISABLE KEYS */;
/*!40000 ALTER TABLE `publicidadcuota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serie`
--

DROP TABLE IF EXISTS `serie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `serie` (
  `ID_Serie` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_finalizacion` date DEFAULT NULL,
  `nombre` varchar(48) NOT NULL,
  PRIMARY KEY (`ID_Serie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serie`
--

LOCK TABLES `serie` WRITE;
/*!40000 ALTER TABLE `serie` DISABLE KEYS */;
/*!40000 ALTER TABLE `serie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tanda`
--

DROP TABLE IF EXISTS `tanda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tanda` (
  `Hora_Inicio` time NOT NULL,
  `Hora_Fin` time NOT NULL,
  PRIMARY KEY (`Hora_Inicio`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tanda`
--

LOCK TABLES `tanda` WRITE;
/*!40000 ALTER TABLE `tanda` DISABLE KEYS */;
INSERT INTO `tanda` VALUES ('01:00:00','03:00:00'),('03:00:00','05:00:00'),('05:00:00','10:00:00'),('10:00:00','05:00:00'),('15:00:00','16:00:00'),('16:00:00','20:00:00'),('20:00:00','24:00:00');
/*!40000 ALTER TABLE `tanda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabajacomo`
--

DROP TABLE IF EXISTS `trabajacomo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trabajacomo` (
  `ID_Funcionario` int(6) unsigned NOT NULL,
  `ID_Funcion` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Funcionario`,`ID_Funcion`),
  KEY `ID_Funcion` (`ID_Funcion`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajacomo`
--

LOCK TABLES `trabajacomo` WRITE;
/*!40000 ALTER TABLE `trabajacomo` DISABLE KEYS */;
/*!40000 ALTER TABLE `trabajacomo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ustieneacceso`
--

DROP TABLE IF EXISTS `ustieneacceso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ustieneacceso` (
  `id_usuario` int(6) unsigned NOT NULL,
  `id_acceso` int(6) unsigned NOT NULL,
  PRIMARY KEY (`id_usuario`,`id_acceso`),
  KEY `id_acceso` (`id_acceso`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ustieneacceso`
--

LOCK TABLES `ustieneacceso` WRITE;
/*!40000 ALTER TABLE `ustieneacceso` DISABLE KEYS */;
/*!40000 ALTER TABLE `ustieneacceso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id_usuario` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(16) NOT NULL,
  `contrasena` varbinary(256) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'d',_binary '°6µ\Ï\í¦#÷BýO 9');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `video`
--

DROP TABLE IF EXISTS `video`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `video` (
  `ID_Video` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `contenido` varchar(128) NOT NULL,
  `nombre` varchar(48) NOT NULL,
  `ID_Serie` int(6) unsigned DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`ID_Video`),
  KEY `ID_Serie` (`ID_Serie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `video`
--

LOCK TABLES `video` WRITE;
/*!40000 ALTER TABLE `video` DISABLE KEYS */;
/*!40000 ALTER TABLE `video` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-08-25 11:39:35

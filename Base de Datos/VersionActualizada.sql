CREATE DATABASE  IF NOT EXISTS `jvrpdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE  utf8mb4_general_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `jvrpdb`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: jvrpdb
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
  `id_acceso` int(11) NOT NULL AUTO_INCREMENT,
  `seccion` varchar(64) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_acceso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acceso`
--

LOCK TABLES `acceso` WRITE;
/*!40000 ALTER TABLE `acceso` DISABLE KEYS */;
/*!40000 ALTER TABLE `acceso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `alquiler`
--

DROP TABLE IF EXISTS `alquiler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `alquiler` (
  `id_alquiler` int(11) NOT NULL AUTO_INCREMENT,
  `couta` int(7) unsigned NOT NULL,
  PRIMARY KEY (`id_alquiler`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `alquiler`
--

LOCK TABLES `alquiler` WRITE;
/*!40000 ALTER TABLE `alquiler` DISABLE KEYS */;
/*!40000 ALTER TABLE `alquiler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aparece`
--

DROP TABLE IF EXISTS `aparece`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aparece` (
  `id_publicidad` int(11) NOT NULL,
  `activa` tinyint(1) NOT NULL,
  `pago` tinyint(1) NOT NULL,
  `id_tanda` int(11) NOT NULL,
  PRIMARY KEY (`id_publicidad`,`id_tanda`),
  KEY `id_tanda` (`id_tanda`),
  CONSTRAINT `aparece_ibfk_1` FOREIGN KEY (`id_tanda`) REFERENCES `tanda` (`id_tanda`),
  CONSTRAINT `aparece_ibfk_2` FOREIGN KEY (`id_publicidad`) REFERENCES `publicidad` (`id_publicidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aparece`
--

LOCK TABLES `aparece` WRITE;
/*!40000 ALTER TABLE `aparece` DISABLE KEYS */;
/*!40000 ALTER TABLE `aparece` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conduce`
--

DROP TABLE IF EXISTS `conduce`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conduce` (
  `id_conductor` int(11) NOT NULL,
  `id_programa` int(11) NOT NULL,
  `fecha_inicio` date NOT NULL,
  `actividad_conductor` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_programa`,`id_conductor`),
  KEY `id_conductor` (`id_conductor`),
  CONSTRAINT `conduce_ibfk_1` FOREIGN KEY (`id_conductor`) REFERENCES `conductor` (`id_conductor`),
  CONSTRAINT `conduce_ibfk_2` FOREIGN KEY (`id_programa`) REFERENCES `programa` (`id_programa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conduce`
--

LOCK TABLES `conduce` WRITE;
/*!40000 ALTER TABLE `conduce` DISABLE KEYS */;
/*!40000 ALTER TABLE `conduce` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `conductor`
--

DROP TABLE IF EXISTS `conductor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conductor` (
  `id_conductor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_conductor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conductor`
--

LOCK TABLES `conductor` WRITE;
/*!40000 ALTER TABLE `conductor` DISABLE KEYS */;
/*!40000 ALTER TABLE `conductor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contiene`
--

DROP TABLE IF EXISTS `contiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contiene` (
  `id_usuario` int(11) NOT NULL,
  `id_acceso` int(11) NOT NULL,
  PRIMARY KEY (`id_usuario`,`id_acceso`),
  KEY `id_acceso` (`id_acceso`),
  CONSTRAINT `contiene_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`),
  CONSTRAINT `contiene_ibfk_2` FOREIGN KEY (`id_acceso`) REFERENCES `acceso` (`id_acceso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contiene`
--

LOCK TABLES `contiene` WRITE;
/*!40000 ALTER TABLE `contiene` DISABLE KEYS */;
/*!40000 ALTER TABLE `contiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emite`
--

DROP TABLE IF EXISTS `emite`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `emite` (
  `id_programa` int(11) NOT NULL,
  `id_fecha_programa` int(11) NOT NULL,
  `activo_en_horario` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_programa`,`id_fecha_programa`),
  KEY `id_fecha_programa` (`id_fecha_programa`),
  CONSTRAINT `emite_ibfk_1` FOREIGN KEY (`id_fecha_programa`) REFERENCES `fecha_programa` (`id_fecha_programa`),
  CONSTRAINT `emite_ibfk_2` FOREIGN KEY (`id_programa`) REFERENCES `programa` (`id_programa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emite`
--

LOCK TABLES `emite` WRITE;
/*!40000 ALTER TABLE `emite` DISABLE KEYS */;
/*!40000 ALTER TABLE `emite` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empresa` (
  `id_empresa` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa`
--

LOCK TABLES `empresa` WRITE;
/*!40000 ALTER TABLE `empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `evento` (
  `id_evento` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(256) NOT NULL,
  `nombre` varchar(64) NOT NULL,
  PRIMARY KEY (`id_evento`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE= utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fecha_programa`
--

DROP TABLE IF EXISTS `fecha_programa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fecha_programa` (
  `id_fecha_programa` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_inicio` date NOT NULL,
  `fecha_final` date NOT NULL,
  PRIMARY KEY (`id_fecha_programa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fecha_programa`
--

LOCK TABLES `fecha_programa` WRITE;
/*!40000 ALTER TABLE `fecha_programa` DISABLE KEYS */;
/*!40000 ALTER TABLE `fecha_programa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fechas`
--

DROP TABLE IF EXISTS `fechas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fechas` (
  `id_evento` int(11) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_evento`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE= utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fechas`
--

LOCK TABLES `fechas` WRITE;
/*!40000 ALTER TABLE `fechas` DISABLE KEYS */;
/*!40000 ALTER TABLE `fechas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horas`
--

DROP TABLE IF EXISTS `horas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horas` (
  `id_tanda` int(11) NOT NULL,
  `horas` time NOT NULL,
  PRIMARY KEY (`id_tanda`),
  CONSTRAINT `horas_ibfk_1` FOREIGN KEY (`id_tanda`) REFERENCES `tanda` (`id_tanda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horas`
--

LOCK TABLES `horas` WRITE;
/*!40000 ALTER TABLE `horas` DISABLE KEYS */;
/*!40000 ALTER TABLE `horas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programa`
--

DROP TABLE IF EXISTS `programa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programa` (
  `id_programa` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_programa` varchar(64) COLLATE utf8mb4_general_ci NOT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_programa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programa`
--

LOCK TABLES `programa` WRITE;
/*!40000 ALTER TABLE `programa` DISABLE KEYS */;
/*!40000 ALTER TABLE `programa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `promociona`
--

DROP TABLE IF EXISTS `promociona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `promociona` (
  `id_evento` int(11) NOT NULL,
  `id_publicidad` int(11) NOT NULL,
  `pago` int(11) DEFAULT '0',
  PRIMARY KEY (`id_evento`,`id_publicidad`),
  KEY `id_publicidad` (`id_publicidad`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE= utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `promociona`
--

LOCK TABLES `promociona` WRITE;
/*!40000 ALTER TABLE `promociona` DISABLE KEYS */;
/*!40000 ALTER TABLE `promociona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicidad`
--

DROP TABLE IF EXISTS `publicidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publicidad` (
  `id_publicidad` int(11) NOT NULL AUTO_INCREMENT,
  `tema` varchar(64) COLLATE utf8mb4_general_ci NOT NULL,
  `id_empresa` int(11) NOT NULL,
  PRIMARY KEY (`id_publicidad`),
  KEY `id_empresa` (`id_empresa`),
  CONSTRAINT `publicidad_ibfk_1` FOREIGN KEY (`id_empresa`) REFERENCES `empresa` (`id_empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicidad`
--

LOCK TABLES `publicidad` WRITE;
/*!40000 ALTER TABLE `publicidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `publicidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `relaciona`
--

DROP TABLE IF EXISTS `relaciona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `relaciona` (
  `id_evento` int(11) NOT NULL,
  `id_programa` int(11) NOT NULL,
  PRIMARY KEY (`id_evento`,`id_programa`),
  KEY `id_programa` (`id_programa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE= utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `relaciona`
--

LOCK TABLES `relaciona` WRITE;
/*!40000 ALTER TABLE `relaciona` DISABLE KEYS */;
/*!40000 ALTER TABLE `relaciona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serie`
--

DROP TABLE IF EXISTS `serie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `serie` (
  `id_serie` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) COLLATE utf8mb4_general_ci NOT NULL,
  `activo` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_serie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serie`
--

LOCK TABLES `serie` WRITE;
/*!40000 ALTER TABLE `serie` DISABLE KEYS */;
/*!40000 ALTER TABLE `serie` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sobre`
--

DROP TABLE IF EXISTS `sobre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sobre` (
  `id_evento` int(11) NOT NULL,
  `id_video` int(11) NOT NULL,
  PRIMARY KEY (`id_evento`,`id_video`),
  KEY `id_video` (`id_video`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE= utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sobre`
--

LOCK TABLES `sobre` WRITE;
/*!40000 ALTER TABLE `sobre` DISABLE KEYS */;
/*!40000 ALTER TABLE `sobre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tanda`
--

DROP TABLE IF EXISTS `tanda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tanda` (
  `id_tanda` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_tanda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tanda`
--

LOCK TABLES `tanda` WRITE;
/*!40000 ALTER TABLE `tanda` DISABLE KEYS */;
/*!40000 ALTER TABLE `tanda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tiene`
--

DROP TABLE IF EXISTS `tiene`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tiene` (
  `fecha_couta` date NOT NULL,
  `pago` tinyint(1) NOT NULL,
  `id_alquiler` int(11) NOT NULL,
  `id_programa` int(11) NOT NULL,
  PRIMARY KEY (`id_alquiler`,`id_programa`),
  KEY `id_programa` (`id_programa`),
  CONSTRAINT `tiene_ibfk_1` FOREIGN KEY (`id_alquiler`) REFERENCES `alquiler` (`id_alquiler`),
  CONSTRAINT `tiene_ibfk_2` FOREIGN KEY (`id_programa`) REFERENCES `programa` (`id_programa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tiene`
--

LOCK TABLES `tiene` WRITE;
/*!40000 ALTER TABLE `tiene` DISABLE KEYS */;
/*!40000 ALTER TABLE `tiene` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(32) COLLATE utf8mb4_general_ci NOT NULL,
  `contrasena` varbinary(100) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Prueba',_binary 'Aµ)uÉ$\‰¯~˛µá'),(3,'l',_binary '\ÍWo¢ö\·€ï4™\0ê&@\‰|'),(4,'k',_binary 'PE\'ø∏≤j\√\‰±\Ï{h3jé'),(5,'m',_binary '\⁄Bß∏$o\ ˛Ös	ß°\''),(6,'a',_binary '\ÍWo¢ö\·€ï4™\0ê&@\‰|'),(7,'ss',_binary '¬±Ö\Êê\ BØ#håu˙\ÿ');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `video`
--

DROP TABLE IF EXISTS `video`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `video` (
  `id_video` int(11) NOT NULL AUTO_INCREMENT,
  `contenido` varchar(64) COLLATE utf8mb4_general_ci NOT NULL,
  `nombre` varchar(33) COLLATE utf8mb4_general_ci NOT NULL,
  `emitido` tinyint(1) NOT NULL,
  `id_serie` int(11) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`id_video`),
  KEY `id_serie` (`id_serie`),
  CONSTRAINT `video_ibfk_1` FOREIGN KEY (`id_serie`) REFERENCES `serie` (`id_serie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
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

-- Dump completed on 2020-06-07 10:19:33

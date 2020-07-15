CREATE DATABASE  IF NOT EXISTS `jvrpdatabase` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
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
  `seccion` varchar(64) NOT NULL,
  PRIMARY KEY (`id_acceso`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
  PRIMARY KEY (`ID_Publicidad`,`Hora_Inicio`),
  KEY `Hora_Inicio` (`Hora_Inicio`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `empresa`
--

DROP TABLE IF EXISTS `empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empresa` (
  `ID_Empresa` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(64) NOT NULL,
  `Telefono` int(9) unsigned DEFAULT NULL,
  PRIMARY KEY (`ID_Empresa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `evento` (
  `ID_Evento` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(64) NOT NULL,
  `descripcion` varchar(256) NOT NULL,
  PRIMARY KEY (`ID_Evento`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `funcion`
--

DROP TABLE IF EXISTS `funcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcion` (
  `ID_Funcion` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(256) NOT NULL,
  PRIMARY KEY (`ID_Funcion`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `funcionario` (
  `ID_Funcionario` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `telefono` int(9) NOT NULL,
  `nombre` varchar(64) NOT NULL,
  PRIMARY KEY (`ID_Funcionario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
  PRIMARY KEY (`ID_Funcionario`,`ID_Funcion`,`ID_Programa`),
  KEY `ID_Funcion` (`ID_Funcion`),
  KEY `ID_Programa` (`ID_Programa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `pmuestrapubli`
--

DROP TABLE IF EXISTS `pmuestrapubli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pmuestrapubli` (
  `ID_Publicidad` int(6) unsigned NOT NULL,
  `ID_Programa` int(6) unsigned NOT NULL,
  `Fecha_Finalizacion` date DEFAULT NULL,
  KEY `ID_Programa` (`ID_Programa`),
  KEY `ID_Publicidad` (`ID_Publicidad`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `precioespacio`
--

DROP TABLE IF EXISTS `precioespacio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `precioespacio` (
  `ID_Precio_Espacio` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(256) NOT NULL,
  `Precio` int(5) unsigned DEFAULT NULL,
  PRIMARY KEY (`ID_Precio_Espacio`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `programa`
--

DROP TABLE IF EXISTS `programa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programa` (
  `ID_Programa` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Nombre_Programa` varchar(64) NOT NULL,
  `Fecha_Finalizacion` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_Programa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `programacuota`
--

DROP TABLE IF EXISTS `programacuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programacuota` (
  `ID_Precio_Espacio` int(6) unsigned NOT NULL,
  `ID_Programa` int(6) unsigned NOT NULL,
  `Fecha_Pago` date DEFAULT NULL,
  `Nro_Recibo` int(7) unsigned DEFAULT NULL,
  PRIMARY KEY (`ID_Programa`,`ID_Precio_Espacio`),
  KEY `ID_Precio_Espacio` (`ID_Precio_Espacio`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `publicidad`
--

DROP TABLE IF EXISTS `publicidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publicidad` (
  `ID_Publicidad` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Tema` varchar(256) NOT NULL,
  `ID_Empresa` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Publicidad`),
  KEY `ID_Empresa` (`ID_Empresa`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `publicidadcuota`
--

DROP TABLE IF EXISTS `publicidadcuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publicidadcuota` (
  `ID_Cuota` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `Fecha_Pago` date DEFAULT NULL,
  `Precio` int(6) unsigned NOT NULL,
  `ID_Publicidad` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Cuota`),
  KEY `ID_Publicidad` (`ID_Publicidad`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `serie`
--

DROP TABLE IF EXISTS `serie`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `serie` (
  `ID_Serie` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `fecha_finalizacion` date DEFAULT NULL,
  `nombre` varchar(64) NOT NULL,
  PRIMARY KEY (`ID_Serie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id_usuario` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(64) NOT NULL,
  `contrasena` varbinary(256) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `vesdeevento`
--

DROP TABLE IF EXISTS `vesdeevento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vesdeevento` (
  `ID_Evento` int(6) unsigned NOT NULL,
  `ID_Video` int(6) unsigned NOT NULL,
  `ID_Serie` int(6) unsigned NOT NULL,
  PRIMARY KEY (`ID_Evento`,`ID_Video`,`ID_Serie`),
  KEY `ID_Video` (`ID_Video`),
  KEY `ID_Serie` (`ID_Serie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `video`
--

DROP TABLE IF EXISTS `video`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `video` (
  `ID_Video` int(6) unsigned NOT NULL AUTO_INCREMENT,
  `contenido` varchar(256) NOT NULL,
  `nombre` varchar(64) NOT NULL,
  `ID_Serie` int(6) unsigned DEFAULT NULL,
  `fecha` datetime DEFAULT NULL,
  PRIMARY KEY (`ID_Video`),
  KEY `ID_Serie` (`ID_Serie`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-15 19:34:07

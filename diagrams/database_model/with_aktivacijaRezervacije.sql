CREATE DATABASE  IF NOT EXISTS `e_bioskop` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `e_bioskop`;
-- MySQL dump 10.13  Distrib 5.6.23, for Win64 (x86_64)
--
-- Host: localhost    Database: e_bioskop
-- ------------------------------------------------------
-- Server version	5.6.24-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `distributer`
--

DROP TABLE IF EXISTS `distributer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `distributer` (
  `idDistributer` int(11) NOT NULL AUTO_INCREMENT,
  `nazivDistributer` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `adresaDistributer` varchar(200) COLLATE utf8_unicode_ci DEFAULT NULL,
  `telefonDistributer` char(64) COLLATE utf8_unicode_ci DEFAULT NULL,
  `e_mailDistributer` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idDistributer`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `film`
--

DROP TABLE IF EXISTS `film`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `film` (
  `trajanjeFilm` int(11) DEFAULT NULL,
  `idDistributer` int(11) NOT NULL,
  `idFilm` int(11) NOT NULL AUTO_INCREMENT,
  `nazivFilm` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `idStatusFilm` int(11) NOT NULL,
  `opisFilm` text CHARACTER SET utf8,
  `idZanr` int(11) DEFAULT NULL,
  PRIMARY KEY (`idFilm`),
  KEY `R_4` (`idDistributer`),
  KEY `R_5` (`idStatusFilm`),
  KEY `R_21` (`idZanr`),
  CONSTRAINT `film_ibfk_1` FOREIGN KEY (`idDistributer`) REFERENCES `distributer` (`idDistributer`),
  CONSTRAINT `film_ibfk_2` FOREIGN KEY (`idStatusFilm`) REFERENCES `status_film` (`idStatusFilm`),
  CONSTRAINT `film_ibfk_3` FOREIGN KEY (`idZanr`) REFERENCES `zanr` (`idZanr`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `karta`
--

DROP TABLE IF EXISTS `karta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `karta` (
  `cijenaKarta` int(11) NOT NULL,
  `datumProdaje` date DEFAULT NULL,
  `idZaposleni` int(11) NOT NULL,
  `idProjekcija` int(11) NOT NULL,
  `idKarta` int(11) NOT NULL AUTO_INCREMENT,
  `idRezervacija` int(11) DEFAULT NULL,
  `idStatusKarta` int(11) NOT NULL,
  `brojReda` int(11) NOT NULL,
  `brojSjedista` int(11) NOT NULL,
  PRIMARY KEY (`idKarta`),
  KEY `R_9` (`idProjekcija`),
  KEY `R_12` (`idZaposleni`),
  KEY `R_17` (`idRezervacija`),
  KEY `R_19` (`idStatusKarta`),
  CONSTRAINT `karta_ibfk_1` FOREIGN KEY (`idProjekcija`) REFERENCES `projekcija` (`idProjekcija`),
  CONSTRAINT `karta_ibfk_3` FOREIGN KEY (`idZaposleni`) REFERENCES `zaposleni` (`idZaposleni`),
  CONSTRAINT `karta_ibfk_4` FOREIGN KEY (`idRezervacija`) REFERENCES `rezervacija` (`idRezervacija`),
  CONSTRAINT `karta_ibfk_5` FOREIGN KEY (`idStatusKarta`) REFERENCES `status_karta` (`idStatusKarta`)
) ENGINE=InnoDB AUTO_INCREMENT=238 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `projekcija`
--

DROP TABLE IF EXISTS `projekcija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `projekcija` (
  `vrijemeProjekcija` datetime NOT NULL,
  `idFilm` int(11) NOT NULL,
  `idSala` int(11) NOT NULL,
  `idProjekcija` int(11) NOT NULL AUTO_INCREMENT,
  `cijenaProjekcija` float NOT NULL,
  PRIMARY KEY (`idProjekcija`),
  KEY `R_7` (`idSala`),
  KEY `R_8` (`idFilm`),
  CONSTRAINT `projekcija_ibfk_1` FOREIGN KEY (`idSala`) REFERENCES `sala` (`idSala`),
  CONSTRAINT `projekcija_ibfk_2` FOREIGN KEY (`idFilm`) REFERENCES `film` (`idFilm`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `radno_mjesto`
--

DROP TABLE IF EXISTS `radno_mjesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `radno_mjesto` (
  `idRadnoMjesto` int(11) NOT NULL AUTO_INCREMENT,
  `nazivRadnoMjesto` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `opisRadnoMjesto` varchar(200) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idRadnoMjesto`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `rezervacija`
--

DROP TABLE IF EXISTS `rezervacija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rezervacija` (
  `vrijemeRezervacija` datetime DEFAULT NULL,
  `idZaposleni` int(11) NOT NULL,
  `opisRezervacija` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `idRezervacija` int(11) NOT NULL AUTO_INCREMENT,
  `aktivnaRezervacija` int(11) DEFAULT NULL,
  PRIMARY KEY (`idRezervacija`),
  KEY `R_13` (`idZaposleni`),
  CONSTRAINT `rezervacija_ibfk_1` FOREIGN KEY (`idZaposleni`) REFERENCES `zaposleni` (`idZaposleni`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `sala`
--

DROP TABLE IF EXISTS `sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sala` (
  `aktivna` int(11) NOT NULL,
  `idSala` int(11) NOT NULL AUTO_INCREMENT,
  `nazivSala` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  `brojRedova` int(11) NOT NULL,
  `brojSjedistaURedu` int(11) NOT NULL,
  PRIMARY KEY (`idSala`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `sjediste`
--

DROP TABLE IF EXISTS `sjediste`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sjediste` (
  `redSjediste` int(11) NOT NULL,
  `brojSjediste` int(11) NOT NULL,
  `idSala` int(11) NOT NULL,
  `idSjediste` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idSjediste`),
  KEY `R_6` (`idSala`),
  CONSTRAINT `sjediste_ibfk_1` FOREIGN KEY (`idSala`) REFERENCES `sala` (`idSala`)
) ENGINE=InnoDB AUTO_INCREMENT=389 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `status_film`
--

DROP TABLE IF EXISTS `status_film`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `status_film` (
  `idStatusFilm` int(11) NOT NULL AUTO_INCREMENT,
  `nazivStatusFilm` varchar(40) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idStatusFilm`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `status_karta`
--

DROP TABLE IF EXISTS `status_karta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `status_karta` (
  `idStatusKarta` int(11) NOT NULL AUTO_INCREMENT,
  `NazivStatusKarta` char(64) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idStatusKarta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zanr`
--

DROP TABLE IF EXISTS `zanr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zanr` (
  `idZanr` int(11) NOT NULL AUTO_INCREMENT,
  `nazivZanr` char(64) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idZanr`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zaposleni`
--

DROP TABLE IF EXISTS `zaposleni`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zaposleni` (
  `idZaposleni` int(11) NOT NULL AUTO_INCREMENT,
  `datumRodjenja` date DEFAULT NULL,
  `korisnickoIme` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `lozinka` char(64) CHARACTER SET utf8 NOT NULL,
  `ime` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `prezime` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  `telefon` char(64) COLLATE utf8_unicode_ci NOT NULL,
  `e_mail` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `aktivan` int(11) NOT NULL,
  PRIMARY KEY (`idZaposleni`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `zaposleni_radno_mjesto`
--

DROP TABLE IF EXISTS `zaposleni_radno_mjesto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zaposleni_radno_mjesto` (
  `idZaposleni` int(11) NOT NULL,
  `idRadnoMjesto` int(11) NOT NULL,
  `datumZaposlenja` date NOT NULL,
  `datumOtkaza` date DEFAULT NULL,
  PRIMARY KEY (`idZaposleni`,`idRadnoMjesto`),
  KEY `R_3` (`idRadnoMjesto`),
  CONSTRAINT `zaposleni_radno_mjesto_ibfk_1` FOREIGN KEY (`idZaposleni`) REFERENCES `zaposleni` (`idZaposleni`),
  CONSTRAINT `zaposleni_radno_mjesto_ibfk_2` FOREIGN KEY (`idRadnoMjesto`) REFERENCES `radno_mjesto` (`idRadnoMjesto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-02-06  9:58:45

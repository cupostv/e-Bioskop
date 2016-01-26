CREATE DATABASE  IF NOT EXISTS `e_bioskop` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci */;
USE `e_bioskop`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: e_bioskop
-- ------------------------------------------------------
-- Server version	5.7.10-log

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
-- Dumping data for table `distributer`
--

LOCK TABLES `distributer` WRITE;
/*!40000 ALTER TABLE `distributer` DISABLE KEYS */;
INSERT INTO `distributer` VALUES (1,'Sony Pictures','Culver City 32, California','089321452','sonypictures@sony.com'),(2,'Universal Pictures','Universal City, California, U.S.','012365903670','universal.pictures@uni.com'),(3,'Antidote Films','Ulica neznanih junaka 22, Beograd','02313321','antidote123@gmail.com'),(4,'Movie Cinestar','Pere Drljače 48, Tuzla','066123123','moviecinestar@gmail.com'),(5,'2i Film','Primorska 26, 10000 Zagreb, Hrvatska','+385 1 8894699','info@2ifilm.hr'),(6,'Continental Film','Zavrtnica 17, 10000 Zagreb','+357 1 6194660','distributer@film.com'),(7,'Centar Film d.o.o.','Beogradska 71, 17000 Beograd','+381 0 113240458','dist@gmail,com'),(8,'Košutnjak Film','Kneza Višeslava 88, 11030 Beograd','+381 0 11 354 34 55','distributer@info.com'),(9,'Movie Distribution','King Arthur 3, 56444 Slovenia','00332933321','movieslovenia@slo.com');
/*!40000 ALTER TABLE `distributer` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `film`
--

LOCK TABLES `film` WRITE;
/*!40000 ALTER TABLE `film` DISABLE KEYS */;
INSERT INTO `film` VALUES (119,4,1,'Notebook',1,'Ostarjeli Noah često posjećuje Allie, polusenilnu ženu koja boravi u domu za starije i nemoćne...',3),(90,1,2,'Harry Potter',3,'Film opisuje avanture mladog čarobnjaka Harry Potter-a i njegovih najboljih prijatelja Rona Weasleyja i Hermione Granger, učenika škole vještičarenja i čarobnjaštva Hogwarts.',6),(90,4,5,'Strumfovi (Animirani)',1,'Da li će se štrumfovi ovaj put izboriti sa zlim Gargamelom?!',10),(86,4,6,'Diablo',3,'Mladi ratni veteran koji je prisiljen na očajno putovanje u potrazi za svojom kidnapovanom ženom.',1),(135,4,7,'Ratovi zvjezda: Sila se budi',3,'Tri decenije nakon poraza Galactic Empire, javlja se nova prijetnja...',8),(94,4,9,'Glup, gluplji, najgluplji',5,'Jim Carry u nezaboravnoj komediji',2),(123,4,12,'Rush',1,'The merciless 1970s rivalry between Formula One rivals James Hund and Niki Lauda',5),(144,4,13,'Hobbit: Bitka pet vojski',3,'Bilbo and Company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness',6),(103,4,14,'The Angry Birds Movie',3,'Film baziran na poznatoj android igrici...',2),(121,4,15,'Marsovac',3,'Nakon što ih zadesi oluja na Marsu, on ostaje sam i treba da preživi 2 godine',5),(133,6,16,'50 nijansi crne',3,'Parodija na 50 nijansi sive',2),(144,3,17,'The Dark Knight',1,'When the menace known as Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.',8),(122,5,18,'Žikina Dinastija (2. deo)',3,'Nastavak poznate komedije...',2),(123,7,19,'Fight Club (1999)',2,'An insomniac office worker, looking for a way to change his life, crosses paths with a devil-may-care soap maker...',3),(120,1,20,'Game of Thrones',2,'Dok se civilski rat zakuhava izmedju nekoliko noble familija u Westeros-u... U medjuvremenu zaboravljena trka se nastavlja nakon 1000 godina na sjeveru.',6),(143,2,21,'The Shawshank Redemption',5,'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency',5),(154,3,22,'Pulp Fiction',3,'The lives of two mob hit men, a boxer, a gangster\'s wife and a pair of diner bandits intertwine in four tales of violence and redemption',5),(230,4,23,'Crni gruja i kamen mudrosti',3,'Domaća komedija ...',2),(137,8,24,'The Matrix',5,'A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.',8),(150,8,25,'The Pianist',3,'A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II',5);
/*!40000 ALTER TABLE `film` ENABLE KEYS */;
UNLOCK TABLES;

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
  `idSjediste` int(11) NOT NULL,
  `idProjekcija` int(11) NOT NULL,
  `idKarta` int(11) NOT NULL AUTO_INCREMENT,
  `idRezervacija` int(11) DEFAULT NULL,
  `idStatusKarta` int(11) NOT NULL,
  PRIMARY KEY (`idKarta`),
  KEY `R_9` (`idProjekcija`),
  KEY `R_10` (`idSjediste`),
  KEY `R_12` (`idZaposleni`),
  KEY `R_17` (`idRezervacija`),
  KEY `R_19` (`idStatusKarta`),
  CONSTRAINT `karta_ibfk_1` FOREIGN KEY (`idProjekcija`) REFERENCES `projekcija` (`idProjekcija`),
  CONSTRAINT `karta_ibfk_2` FOREIGN KEY (`idSjediste`) REFERENCES `sjediste` (`idSjediste`),
  CONSTRAINT `karta_ibfk_3` FOREIGN KEY (`idZaposleni`) REFERENCES `zaposleni` (`idZaposleni`),
  CONSTRAINT `karta_ibfk_4` FOREIGN KEY (`idRezervacija`) REFERENCES `rezervacija` (`idRezervacija`),
  CONSTRAINT `karta_ibfk_5` FOREIGN KEY (`idStatusKarta`) REFERENCES `status_karta` (`idStatusKarta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `karta`
--

LOCK TABLES `karta` WRITE;
/*!40000 ALTER TABLE `karta` DISABLE KEYS */;
/*!40000 ALTER TABLE `karta` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekcija`
--

LOCK TABLES `projekcija` WRITE;
/*!40000 ALTER TABLE `projekcija` DISABLE KEYS */;
/*!40000 ALTER TABLE `projekcija` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `radno_mjesto`
--

LOCK TABLES `radno_mjesto` WRITE;
/*!40000 ALTER TABLE `radno_mjesto` DISABLE KEYS */;
INSERT INTO `radno_mjesto` VALUES (1,'Administrator','Administrator opis'),(2,'Upravnik','Upravnik opis'),(3,'Radnik','Radnik opis');
/*!40000 ALTER TABLE `radno_mjesto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rezervacija`
--

DROP TABLE IF EXISTS `rezervacija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rezervacija` (
  `vrijemeRezervacija` date DEFAULT NULL,
  `idZaposleni` int(11) NOT NULL,
  `opisRezervacija` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `idRezervacija` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idRezervacija`),
  KEY `R_13` (`idZaposleni`),
  CONSTRAINT `rezervacija_ibfk_1` FOREIGN KEY (`idZaposleni`) REFERENCES `zaposleni` (`idZaposleni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rezervacija`
--

LOCK TABLES `rezervacija` WRITE;
/*!40000 ALTER TABLE `rezervacija` DISABLE KEYS */;
/*!40000 ALTER TABLE `rezervacija` ENABLE KEYS */;
UNLOCK TABLES;

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
  PRIMARY KEY (`idSala`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
/*!40000 ALTER TABLE `sala` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sjediste`
--

LOCK TABLES `sjediste` WRITE;
/*!40000 ALTER TABLE `sjediste` DISABLE KEYS */;
/*!40000 ALTER TABLE `sjediste` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `status_film`
--

LOCK TABLES `status_film` WRITE;
/*!40000 ALTER TABLE `status_film` DISABLE KEYS */;
INSERT INTO `status_film` VALUES (1,'Spreman za naručivanje'),(2,'Naručen'),(3,'Spreman za prikazivanje'),(4,'Prikazuje se'),(5,'Arhiviran');
/*!40000 ALTER TABLE `status_film` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_karta`
--

LOCK TABLES `status_karta` WRITE;
/*!40000 ALTER TABLE `status_karta` DISABLE KEYS */;
/*!40000 ALTER TABLE `status_karta` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `zanr`
--

LOCK TABLES `zanr` WRITE;
/*!40000 ALTER TABLE `zanr` DISABLE KEYS */;
INSERT INTO `zanr` VALUES (1,'Akcija'),(2,'Komedija'),(3,'Romansa'),(4,'Triler'),(5,'Drama'),(6,'Avantura'),(7,'Horor'),(8,'Fantazija'),(9,'Misterija'),(10,'Animirani crtani');
/*!40000 ALTER TABLE `zanr` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zaposleni`
--

LOCK TABLES `zaposleni` WRITE;
/*!40000 ALTER TABLE `zaposleni` DISABLE KEYS */;
INSERT INTO `zaposleni` VALUES (1,'1993-07-25','mladen.stupar','afc16c9e71ddd74466deb8698e02e876aaab49a3c5aa19cd775ffd37b7ca1eaa','Mladen','Stupar','065903670','cupostv@gmail.com',1),(2,'1993-07-25','cupostv','afc16c9e71ddd74466deb8698e02e876aaab49a3c5aa19cd775ffd37b7ca1eaa','Mladen','Stupar','065903670','mladen.stupar@rt-rk.com',1),(3,'1971-01-17','pero','0db9df7d8e7ff24ae5980d8862caf37b60f0e3ef9165630a8d64247c9d42cfd3','Pero','Perić','065123125','pero.peric@yahoo.com',1),(4,'1990-01-17','vidan','67e821251b5d1e91eceaaeb6589c72e9216ebb61782f1f07b501d7c1fd98895b','Vidan','Vidaković','009321332','vidan@emal.com',0),(5,'2016-01-17','mitar','59a43d94b3735510edb2615e1a49916f418ae7301cb1987ede2f9867575d9cba','Mitar','Mitrović','0342323','mitar@gmail.com',1),(6,'1984-01-17','nikola','a108d6d354a18ab7b395f000a7f08d1dd26cd64666b396281d7b4df08ac5bdb6','Nikola','Nikolić','09322332','nikola@gmail.com',1),(7,'1980-01-18','marko','6201eb4dccc956cc4fa3a78dca0c2888177ec52efd48f125df214f046eb43138','Marko','Marković','065903672','nekiemail@neki.com',0),(8,'1989-01-20','zivan','569d00afd67f2369c650fb6303ff5dff447166206edf108f650d5981e1fe376f','Živan','Živanović','057922112','zivan@gmail.com',1),(9,'2016-01-21','branka','9073f193e9cf459922d8e832c12aaa33501e9bead3d68aadbf9be04b5bfb2d37','Branka','Pekez','0321323','branka.p@gmail.com',1),(10,'1993-01-21','sasa','5cd38f85f66bc64702320d8cb9cb702914e210fc4756e158660976cc9df664c0','Saša','Mihajlica','098312312','sasamih@gmail.com',0),(11,'1992-01-21','mirko','6eb44ff6ac59c9b9d39e7ac203910f0384e4c2d3a59c8bfd7fecb7a5f6de1e10','Mirkan','Mirković','23132321','mirko@yahoo.com',0),(12,'1955-01-21','stan','1a5e497a2bfa7bfd8aab38a1d576ed882f4a82e855ec610880b4c186ec3f4e73','Nikola','Stanković','3122321','stankic@gmail.com',1),(13,'1989-01-24','nenad.neskovic','6e0626a779a150c6c3d302bc3880f16c60943955350da4a3775658fa228e3028','Nenad','Nešković','003123123','nenad@gmail.com',0),(14,'1970-01-24','gago','6a875698c661dd427fc31aa089d5a36e4ceb5d90fd53cd5fc8b34d2450a3dc2c','Dragan','Torbica','065065065','gago.torbica@arhivatori.rs',1);
/*!40000 ALTER TABLE `zaposleni` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Dumping data for table `zaposleni_radno_mjesto`
--

LOCK TABLES `zaposleni_radno_mjesto` WRITE;
/*!40000 ALTER TABLE `zaposleni_radno_mjesto` DISABLE KEYS */;
INSERT INTO `zaposleni_radno_mjesto` VALUES (1,1,'2016-01-10','0001-01-01'),(2,1,'2016-01-23','2016-01-23'),(3,2,'2016-01-17','2016-01-17'),(4,3,'2016-01-17','2016-01-17'),(5,1,'2016-01-17','2016-01-17'),(6,3,'2016-01-17','2016-01-17'),(7,3,'2016-01-18','2016-01-18'),(8,1,'2016-01-20','2016-01-20'),(9,3,'2016-01-21','2016-01-21'),(10,3,'2016-01-21','2016-01-21'),(11,3,'2016-01-21','2016-01-21'),(12,3,'2016-01-21','2016-01-21'),(13,3,'2016-01-24','2016-01-24'),(14,3,'2016-01-24','2016-01-24');
/*!40000 ALTER TABLE `zaposleni_radno_mjesto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-01-24 15:39:42
grant all on e_bioskop.*  to 'bioskop'@'localhost' identified by 'bioskop';
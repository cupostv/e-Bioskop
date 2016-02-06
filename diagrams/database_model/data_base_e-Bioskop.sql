-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: e_bioskop
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
INSERT INTO `film` VALUES (119,4,1,'Notebook',2,'Ostarjeli Noah često posjećuje Allie, polusenilnu ženu koja boravi u domu za starije i nemoćne...',3),(90,1,2,'Harry Potter',3,'Film opisuje avanture mladog čarobnjaka Harry Potter-a i njegovih najboljih prijatelja Rona Weasleyja i Hermione Granger, učenika škole vještičarenja i čarobnjaštva Hogwarts.',6),(90,4,5,'Strumfovi (Animirani)',2,'Da li će se štrumfovi ovaj put izboriti sa zlim Gargamelom?!',10),(86,4,6,'Diablo',3,'Mladi ratni veteran koji je prisiljen na očajno putovanje u potrazi za svojom kidnapovanom ženom.',1),(135,4,7,'Ratovi zvjezda: Sila se budi',3,'Tri decenije nakon poraza Galactic Empire, javlja se nova prijetnja...',8),(94,4,9,'Glup, gluplji, najgluplji',5,'Jim Carry u nezaboravnoj komediji',2),(123,4,12,'Rush',1,'The merciless 1970s rivalry between Formula One rivals James Hund and Niki Lauda',5),(144,4,13,'Hobbit: Bitka pet vojski',3,'Bilbo and Company are forced to engage in a war against an array of combatants and keep the Lonely Mountain from falling into the hands of a rising darkness',6),(103,4,14,'The Angry Birds Movie',3,'Film baziran na poznatoj android igrici...',2),(121,4,15,'Marsovac',3,'Nakon što ih zadesi oluja na Marsu, on ostaje sam i treba da preživi 2 godine',5),(133,6,16,'50 nijansi crne',3,'Parodija na 50 nijansi sive',2),(144,3,17,'The Dark Knight',1,'When the menace known as Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.',8),(122,5,18,'Žikina Dinastija (2. deo)',3,'Nastavak poznate komedije...',2),(123,7,19,'Fight Club (1999)',2,'An insomniac office worker, looking for a way to change his life, crosses paths with a devil-may-care soap maker...',3),(120,1,20,'Game of Thrones',2,'Dok se civilski rat zakuhava izmedju nekoliko noble familija u Westeros-u... U medjuvremenu zaboravljena trka se nastavlja nakon 1000 godina na sjeveru.',6),(143,2,21,'The Shawshank Redemption',5,'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency',5),(154,3,22,'Pulp Fiction',3,'The lives of two mob hit men, a boxer, a gangster\'s wife and a pair of diner bandits intertwine in four tales of violence and redemption',5),(230,4,23,'Crni gruja i kamen mudrosti',3,'Domaća komedija ...',2),(137,8,24,'The Matrix',5,'A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.',8),(150,8,25,'The Pianist',3,'A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II',5);
/*!40000 ALTER TABLE `film` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `karta`
--

DROP TABLE IF EXISTS `karta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `karta` (
  `cijenaKarta` float NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=290 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `karta`
--

LOCK TABLES `karta` WRITE;
/*!40000 ALTER TABLE `karta` DISABLE KEYS */;
INSERT INTO `karta` VALUES (0,'0001-01-01',17,13,270,NULL,3,0,0),(0,'0001-01-01',17,14,271,NULL,3,1,3),(0,'0001-01-01',17,14,272,30,1,1,4),(0,'0001-01-01',17,14,273,30,1,1,5),(0,'0001-01-01',17,13,274,NULL,2,0,1),(0,'0001-01-01',17,14,275,NULL,2,2,3),(0,'0001-01-01',17,14,276,NULL,2,2,4),(0,'0001-01-01',17,14,277,NULL,2,2,5),(0,'0001-01-01',17,13,278,31,1,2,1),(0,'0001-01-01',17,13,279,31,1,2,2),(0,'0001-01-01',17,14,280,NULL,3,3,5),(4,'0001-01-01',17,14,281,NULL,2,3,4),(4,'0001-01-01',17,14,282,NULL,2,3,3),(5,'0001-01-01',17,14,283,NULL,2,3,2),(5,'0001-01-01',17,14,284,NULL,2,2,2),(5,'0001-01-01',17,14,285,NULL,2,1,2),(5,'0001-01-01',17,14,286,NULL,2,0,2),(5,'0001-01-01',17,14,287,NULL,2,0,3),(0,'0001-01-01',17,14,288,32,1,3,6),(0.5,'0001-01-01',17,14,289,NULL,2,1,6);
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projekcija`
--

LOCK TABLES `projekcija` WRITE;
/*!40000 ALTER TABLE `projekcija` DISABLE KEYS */;
INSERT INTO `projekcija` VALUES ('2016-01-30 16:39:08',6,1,1,10),('2016-01-31 16:41:39',13,1,2,10),('2016-01-30 18:22:07',15,1,3,10),('2016-01-31 07:31:46',16,1,4,5),('2016-01-31 11:55:13',15,1,5,10),('2016-02-01 09:21:50',16,1,6,8),('2016-01-31 04:49:32',2,1,7,5),('2016-01-31 14:00:07',13,1,8,1),('2016-02-01 15:51:05',18,1,9,5),('2016-02-03 09:51:28',18,1,10,5),('2016-01-31 19:23:41',25,1,11,1),('2016-02-06 10:16:10',15,1,12,10),('2016-02-06 12:51:00',16,1,13,5),('2016-02-06 17:49:48',23,1,14,5);
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
  `vrijemeRezervacija` datetime DEFAULT NULL,
  `idZaposleni` int(11) NOT NULL,
  `opisRezervacija` varchar(70) COLLATE utf8_unicode_ci DEFAULT NULL,
  `idRezervacija` int(11) NOT NULL AUTO_INCREMENT,
  `aktivnaRezervacija` int(11) DEFAULT NULL,
  PRIMARY KEY (`idRezervacija`),
  KEY `R_13` (`idZaposleni`),
  CONSTRAINT `rezervacija_ibfk_1` FOREIGN KEY (`idZaposleni`) REFERENCES `zaposleni` (`idZaposleni`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rezervacija`
--

LOCK TABLES `rezervacija` WRITE;
/*!40000 ALTER TABLE `rezervacija` DISABLE KEYS */;
INSERT INTO `rezervacija` VALUES ('2016-01-31 15:03:27',17,'MM',10,0),('2016-01-31 15:12:36',17,'',11,0),('2016-01-31 15:52:07',17,'',12,0),('2016-01-31 16:53:59',17,'',13,0),('2016-01-31 16:54:03',17,'',14,0),('2016-01-31 16:54:07',17,'',15,0),('2016-01-31 20:03:27',17,'',16,0),('2016-02-01 11:20:24',17,'uhafrisudfhi',17,0),('2016-02-01 11:20:59',17,'uhafrisudfhi',18,0),('2016-02-06 08:16:58',17,'Kooonj',19,0),('2016-02-06 08:43:45',17,'Opis',20,0),('2016-02-06 08:48:52',17,'aa',21,0),('2016-02-06 08:51:46',17,'MM',22,0),('2016-02-06 09:13:56',17,'a',23,0),('2016-02-06 09:17:56',17,'2',24,0),('2016-02-06 09:19:50',17,'d',25,0),('2016-02-06 09:53:14',17,'ndsaundiajsdiasjd',26,0),('2016-02-06 09:53:41',17,'ndsaundiajsdiasjd',27,0),('2016-02-06 10:20:01',17,'',28,0),('2016-02-06 11:46:59',17,'',29,0),('2016-02-06 11:50:20',17,'',30,0),('2016-02-06 12:34:57',17,'Nddsf',31,0),('2016-02-06 13:42:40',17,'',32,0);
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
  `brojRedova` int(11) NOT NULL,
  `brojSjedistaURedu` int(11) NOT NULL,
  PRIMARY KEY (`idSala`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sala`
--

LOCK TABLES `sala` WRITE;
/*!40000 ALTER TABLE `sala` DISABLE KEYS */;
INSERT INTO `sala` VALUES (1,1,'Sala 1',5,10);
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
) ENGINE=InnoDB AUTO_INCREMENT=389 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sjediste`
--

LOCK TABLES `sjediste` WRITE;
/*!40000 ALTER TABLE `sjediste` DISABLE KEYS */;
INSERT INTO `sjediste` VALUES (0,0,4,184),(1,0,4,185),(2,0,4,186),(3,0,4,187),(4,0,4,188),(5,0,4,189),(6,0,4,190),(7,0,4,191),(8,0,4,192),(9,0,4,193),(0,1,4,194),(1,1,4,195),(2,1,4,196),(3,1,4,197),(4,1,4,198),(5,1,4,199),(6,1,4,200),(7,1,4,201),(8,1,4,202),(9,1,4,203),(0,2,4,204),(1,2,4,205),(2,2,4,206),(3,2,4,207),(4,2,4,208),(5,2,4,209),(6,2,4,210),(7,2,4,211),(8,2,4,212),(9,2,4,213),(0,3,4,214),(1,3,4,215),(2,3,4,216),(3,3,4,217),(4,3,4,218),(5,3,4,219),(6,3,4,220),(7,3,4,221),(8,3,4,222),(9,3,4,223),(0,4,4,224),(1,4,4,225),(2,4,4,226),(3,4,4,227),(4,4,4,228),(5,4,4,229),(6,4,4,230),(7,4,4,231),(8,4,4,232),(9,4,4,233),(0,5,4,234),(1,5,4,235),(2,5,4,236),(3,5,4,237),(4,5,4,238),(5,5,4,239),(6,5,4,240),(7,5,4,241),(8,5,4,242),(9,5,4,243),(0,6,4,244),(1,6,4,245),(2,6,4,246),(3,6,4,247),(4,6,4,248),(5,6,4,249),(6,6,4,250),(7,6,4,251),(8,6,4,252),(9,6,4,253),(0,7,4,254),(1,7,4,255),(2,7,4,256),(3,7,4,257),(4,7,4,258),(5,7,4,259),(6,7,4,260),(7,7,4,261),(8,7,4,262),(9,7,4,263),(0,8,4,264),(1,8,4,265),(2,8,4,266),(3,8,4,267),(4,8,4,268),(5,8,4,269),(6,8,4,270),(7,8,4,271),(8,8,4,272),(9,8,4,273),(0,9,4,274),(1,9,4,275),(2,9,4,276),(3,9,4,277),(4,9,4,278),(5,9,4,279),(6,9,4,280),(7,9,4,281),(8,9,4,282),(9,9,4,283),(0,0,5,284),(1,0,5,285),(2,0,5,286),(3,0,5,287),(4,0,5,288),(0,1,5,289),(1,1,5,290),(2,1,5,291),(3,1,5,292),(4,1,5,293),(0,2,5,294),(1,2,5,295),(2,2,5,296),(3,2,5,297),(4,2,5,298),(0,3,5,299),(1,3,5,300),(2,3,5,301),(3,3,5,302),(4,3,5,303),(0,4,5,304),(1,4,5,305),(2,4,5,306),(3,4,5,307),(4,4,5,308),(0,0,6,309),(1,0,6,310),(2,0,6,311),(3,0,6,312),(4,0,6,313),(5,0,6,314),(6,0,6,315),(7,0,6,316),(8,0,6,317),(9,0,6,318),(0,1,6,319),(1,1,6,320),(2,1,6,321),(3,1,6,322),(4,1,6,323),(5,1,6,324),(6,1,6,325),(7,1,6,326),(8,1,6,327),(9,1,6,328),(0,2,6,329),(1,2,6,330),(2,2,6,331),(3,2,6,332),(4,2,6,333),(5,2,6,334),(6,2,6,335),(7,2,6,336),(8,2,6,337),(9,2,6,338),(0,3,6,339),(1,3,6,340),(2,3,6,341),(3,3,6,342),(4,3,6,343),(5,3,6,344),(6,3,6,345),(7,3,6,346),(8,3,6,347),(9,3,6,348),(0,4,6,349),(1,4,6,350),(2,4,6,351),(3,4,6,352),(4,4,6,353),(5,4,6,354),(6,4,6,355),(7,4,6,356),(8,4,6,357),(9,4,6,358),(0,5,6,359),(1,5,6,360),(2,5,6,361),(3,5,6,362),(4,5,6,363),(5,5,6,364),(6,5,6,365),(7,5,6,366),(8,5,6,367),(9,5,6,368),(0,6,6,369),(1,6,6,370),(2,6,6,371),(3,6,6,372),(4,6,6,373),(5,6,6,374),(6,6,6,375),(7,6,6,376),(8,6,6,377),(9,6,6,378),(0,7,6,379),(1,7,6,380),(2,7,6,381),(3,7,6,382),(4,7,6,383),(5,7,6,384),(6,7,6,385),(7,7,6,386),(8,7,6,387),(9,7,6,388);
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
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `status_karta`
--

LOCK TABLES `status_karta` WRITE;
/*!40000 ALTER TABLE `status_karta` DISABLE KEYS */;
INSERT INTO `status_karta` VALUES (1,'Rezervisana'),(2,'Prodana'),(3,'Ponistena');
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
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zaposleni`
--

LOCK TABLES `zaposleni` WRITE;
/*!40000 ALTER TABLE `zaposleni` DISABLE KEYS */;
INSERT INTO `zaposleni` VALUES (1,'1993-07-25','mladen.stupar','afc16c9e71ddd74466deb8698e02e876aaab49a3c5aa19cd775ffd37b7ca1eaa','Mladen','Stupar','065903670','cupostv@gmail.com',1),(2,'1993-07-25','cupostv','afc16c9e71ddd74466deb8698e02e876aaab49a3c5aa19cd775ffd37b7ca1eaa','Mladen','Stupar','065903670','mladen.stupar@rt-rk.com',1),(3,'1971-01-17','pero','0db9df7d8e7ff24ae5980d8862caf37b60f0e3ef9165630a8d64247c9d42cfd3','Pero','Perić','065123125','pero.peric@yahoo.com',1),(4,'1990-01-17','vidan','67e821251b5d1e91eceaaeb6589c72e9216ebb61782f1f07b501d7c1fd98895b','Vidan','Vidaković','009321332','vidan@emal.com',0),(5,'2016-01-17','mitar','59a43d94b3735510edb2615e1a49916f418ae7301cb1987ede2f9867575d9cba','Mitar','Mitrović','0342323','mitar@gmail.com',1),(6,'1984-01-17','nikola','a108d6d354a18ab7b395f000a7f08d1dd26cd64666b396281d7b4df08ac5bdb6','Nikola','Nikolić','09322332','nikola@gmail.com',1),(7,'1980-01-18','marko','6201eb4dccc956cc4fa3a78dca0c2888177ec52efd48f125df214f046eb43138','Marko','Marković','065903672','nekiemail@neki.com',0),(8,'1989-01-20','zivan','569d00afd67f2369c650fb6303ff5dff447166206edf108f650d5981e1fe376f','Živan','Živanović','057922112','zivan@gmail.com',1),(9,'2016-01-21','branka','9073f193e9cf459922d8e832c12aaa33501e9bead3d68aadbf9be04b5bfb2d37','Branka','Pekez','0321323','branka.p@gmail.com',1),(10,'1993-01-21','sasa','5cd38f85f66bc64702320d8cb9cb702914e210fc4756e158660976cc9df664c0','Saša','Mihajlica','098312312','sasamih@gmail.com',0),(11,'1992-01-21','mirko','6eb44ff6ac59c9b9d39e7ac203910f0384e4c2d3a59c8bfd7fecb7a5f6de1e10','Mirkan','Mirković','23132321','mirko@yahoo.com',0),(12,'1955-01-21','stan','1a5e497a2bfa7bfd8aab38a1d576ed882f4a82e855ec610880b4c186ec3f4e73','Nikola','Stanković','3122321','stankic@gmail.com',1),(13,'1989-01-24','nenad.neskovic','6e0626a779a150c6c3d302bc3880f16c60943955350da4a3775658fa228e3028','Nenad','Nešković','003123123','nenad@gmail.com',0),(14,'1970-01-24','gago','6a875698c661dd427fc31aa089d5a36e4ceb5d90fd53cd5fc8b34d2450a3dc2c','Dragan','Torbica','065065065','gago.torbica@arhivatori.rs',1),(15,'2016-01-30','mm','8fa1dddd53606ceb933c5c6a12e714ed41e11d37a2b7bc48e91d15b54171d033','Milan','Maric','066922043','',1),(16,'2016-01-30','jelena','8fa1dddd53606ceb933c5c6a12e714ed41e11d37a2b7bc48e91d15b54171d033','Jelena','Mijatovic','024','',1),(17,'2016-01-30','nn','fab66aa01347d3f11a16468941378cea495937e5f482e18ea6472681e03d3936','nn','nn','nn','nn',1);
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
INSERT INTO `zaposleni_radno_mjesto` VALUES (1,1,'2016-01-10','0001-01-01'),(2,1,'2016-01-23','2016-01-23'),(3,2,'2016-01-17','2016-01-17'),(4,3,'2016-01-17','2016-01-17'),(5,1,'2016-01-17','2016-01-17'),(6,3,'2016-01-17','2016-01-17'),(7,3,'2016-01-18','2016-01-18'),(8,1,'2016-01-20','2016-01-20'),(9,3,'2016-01-21','2016-01-21'),(10,3,'2016-01-21','2016-01-21'),(11,3,'2016-01-21','2016-01-21'),(12,3,'2016-01-21','2016-01-21'),(13,3,'2016-01-24','2016-01-24'),(14,3,'2016-01-24','2016-01-24'),(15,1,'2016-01-30','2016-01-30'),(16,2,'2016-01-30','2016-01-30'),(17,3,'2016-01-30','2016-01-30');
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

-- Dump completed on 2016-02-06 15:08:38

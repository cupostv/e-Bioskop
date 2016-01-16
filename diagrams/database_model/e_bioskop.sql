drop schema if exists e_bioskop;
create schema e_bioskop collate utf8_unicode_ci;
use e_bioskop;

CREATE USER 'bioskop'@'%' IDENTIFIED BY 'bioskop';
GRANT ALL PRIVILEGES ON e_bioskop.* TO 'bioskop'@'%' WITH GRANT OPTION;

CREATE TABLE DISTRIBUTER
(
	idDistributer         INTEGER NOT NULL auto_increment,
	naziv                 VARCHAR(50) NOT NULL,
	adresa                VARCHAR(200) NULL,
	telefon               CHAR(64) NULL,
	e_mail                VARCHAR(70) NULL,
	 PRIMARY KEY (idDistributer)
)
;



CREATE TABLE FILM
(
	trajanje              INTEGER NULL,
	idDistributer         INTEGER NOT NULL,
	idFilm                INTEGER NOT NULL auto_increment,
	naziv                 VARCHAR(50) NOT NULL,
	idStatus              INTEGER NOT NULL,
	opis                  VARCHAR(70) NULL,
	idZanr                INTEGER NULL,
	 PRIMARY KEY (idFilm)
)
;



CREATE TABLE KARTA
(
	cijena                INTEGER NOT NULL,
	datumProdaje          DATE NULL,
	idZaposleni           INTEGER NOT NULL,
	idSjediste            INTEGER NOT NULL,
	idProjekcija          INTEGER NOT NULL,
	idKarte               INTEGER NOT NULL auto_increment,
	idRezervacije         INTEGER NULL,
	idStatus              INTEGER NOT NULL,
	 PRIMARY KEY (idKarte)
)
;



CREATE TABLE PROJEKCIJA
(
	vrijeme               DATE NOT NULL,
	idFilm                INTEGER NOT NULL,
	idSala                INTEGER NOT NULL,
	idProjekcija          INTEGER NOT NULL auto_increment,
	cijena                FLOAT NOT NULL,
	 PRIMARY KEY (idProjekcija)
)
;



CREATE TABLE RADNO_MJESTO
(
	idRadnoMjesto         INTEGER NOT NULL auto_increment,
	naziv                 VARCHAR(100) NOT NULL,
	opis                  VARCHAR(200) NOT NULL,
	 PRIMARY KEY (idRadnoMjesto)
)
;



CREATE TABLE REZERVACIJA
(
	vrijemeRezervacije    DATE NULL,
	idZaposleni           INTEGER NOT NULL,
	opisRezervacije       VARCHAR(70) NULL,
	idRezervacije         INTEGER NOT NULL auto_increment,
	 PRIMARY KEY (idRezervacije)
)
;



CREATE TABLE SALA
(
	aktivna               INTEGER NOT NULL,
	idSala                INTEGER NOT NULL auto_increment,
	naziv                 VARCHAR(40) NOT NULL,
	 PRIMARY KEY (idSala)
)
;



CREATE TABLE SJEDISTE
(
	red                   INTEGER NOT NULL,
	broj                  INTEGER NOT NULL,
	idSala                INTEGER NOT NULL,
	idSjediste            INTEGER NOT NULL auto_increment,
	 PRIMARY KEY (idSjediste)
)
;



CREATE TABLE STATUS_FILM
(
	idStatus              INTEGER NOT NULL auto_increment,
	naziv                 VARCHAR(40) NOT NULL,
	 PRIMARY KEY (idStatus)
)
;



CREATE TABLE STATUS_KARTA
(
	idStatus              INTEGER NOT NULL auto_increment,
	Naziv                 CHAR(64) NOT NULL,
	 PRIMARY KEY (idStatus)
)
;



CREATE TABLE Zanr
(
	idZanr                INTEGER NOT NULL auto_increment,
	naziv                 CHAR(64) NOT NULL,
	opis                  CHAR(18) NULL,
	 PRIMARY KEY (idZanr)
)
;



CREATE TABLE ZAPOSLENI
(
	idZaposleni           INTEGER NOT NULL auto_increment,
	datumRodjenja         DATE NULL,
	korisnickoIme         VARCHAR(30) NOT NULL,
	lozinka               CHAR(32) NOT NULL,
	ime                   VARCHAR(50) NOT NULL,
	prezime               VARCHAR(50) NOT NULL,
	telefon               CHAR(64) NOT NULL,
	e_mail                VARCHAR(70) NULL,
	aktivan               INTEGER NOT NULL,
	 PRIMARY KEY (idZaposleni)
)
;



CREATE TABLE ZAPOSLENI_RADNO_MJESTO
(
	idZaposleni           INTEGER NOT NULL,
	idRadnoMjesto         INTEGER NOT NULL,
	datumZaposlenja       DATE NOT NULL,
	datumOtkaza           DATE NULL,
	 PRIMARY KEY (idZaposleni,idRadnoMjesto)
)
;



ALTER TABLE FILM
	ADD FOREIGN KEY R_4 (idDistributer) REFERENCES DISTRIBUTER(idDistributer)
;


ALTER TABLE FILM
	ADD FOREIGN KEY R_5 (idStatus) REFERENCES STATUS_FILM(idStatus)
;


ALTER TABLE FILM
	ADD FOREIGN KEY R_21 (idZanr) REFERENCES Zanr(idZanr)
;



ALTER TABLE KARTA
	ADD FOREIGN KEY R_9 (idProjekcija) REFERENCES PROJEKCIJA(idProjekcija)
;


ALTER TABLE KARTA
	ADD FOREIGN KEY R_10 (idSjediste) REFERENCES SJEDISTE(idSjediste)
;


ALTER TABLE KARTA
	ADD FOREIGN KEY R_12 (idZaposleni) REFERENCES ZAPOSLENI(idZaposleni)
;


ALTER TABLE KARTA
	ADD FOREIGN KEY R_17 (idRezervacije) REFERENCES REZERVACIJA(idRezervacije)
;


ALTER TABLE KARTA
	ADD FOREIGN KEY R_19 (idStatus) REFERENCES STATUS_KARTA(idStatus)
;



ALTER TABLE PROJEKCIJA
	ADD FOREIGN KEY R_7 (idSala) REFERENCES SALA(idSala)
;


ALTER TABLE PROJEKCIJA
	ADD FOREIGN KEY R_8 (idFilm) REFERENCES FILM(idFilm)
;



ALTER TABLE REZERVACIJA
	ADD FOREIGN KEY R_13 (idZaposleni) REFERENCES ZAPOSLENI(idZaposleni)
;



ALTER TABLE SJEDISTE
	ADD FOREIGN KEY R_6 (idSala) REFERENCES SALA(idSala)
;



ALTER TABLE ZAPOSLENI_RADNO_MJESTO
	ADD FOREIGN KEY R_2 (idZaposleni) REFERENCES ZAPOSLENI(idZaposleni)
;


ALTER TABLE ZAPOSLENI_RADNO_MJESTO
	ADD FOREIGN KEY R_3 (idRadnoMjesto) REFERENCES RADNO_MJESTO(idRadnoMjesto)
;



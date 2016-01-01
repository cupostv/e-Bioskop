#drop schema if exists e_bioskop;
#create schema e_bioskop collate utf8_unicode_ci;

CREATE TABLE DISTRIBUTER
(
	idDistributer         VARCHAR(20) NULL,
	naziv                 VARCHAR(20) NULL,
	adresa                VARCHAR(20) NULL,
	telefon               VARCHAR(20) NULL,
	e_mail                VARCHAR(20) NULL
)
;



ALTER TABLE DISTRIBUTER
	ADD  PRIMARY KEY (idDistributer)
;



CREATE TABLE FILM
(
	idFilm                VARCHAR(20) NULL,
	naziv                 VARCHAR(20) NULL,
	zanr                  VARCHAR(20) NULL,
	trajanje              INTEGER NULL,
	idDistributer         VARCHAR(20) NOT NULL,
	idStatus              VARCHAR(20) NOT NULL,
	opis                  VARCHAR(20) NULL
)
;



ALTER TABLE FILM
	ADD  PRIMARY KEY (idFilm)
;



CREATE TABLE KARTA
(
	idKarte               VARCHAR(20) NULL,
	cijena                INTEGER NULL,
	datumProdaje          DATE NULL,
	idProjekcija          VARCHAR(20) NOT NULL,
	idSjediste            VARCHAR(20) NOT NULL,
	idZaposleni           VARCHAR(20) NOT NULL
)
;



ALTER TABLE KARTA
	ADD  PRIMARY KEY (idKarte)
;



CREATE TABLE PROJEKCIJA
(
	idProjekcija          VARCHAR(20) NULL,
	vrijeme               DATE NULL,
	idSala                VARCHAR(20) NOT NULL,
	idFilm                VARCHAR(20) NOT NULL
)
;



ALTER TABLE PROJEKCIJA
	ADD  PRIMARY KEY (idProjekcija)
;



CREATE TABLE RADNO_MJESTO
(
	idRadnoMjesto         VARCHAR(20) NULL,
	naziv                 VARCHAR(20) NULL,
	opis                  VARCHAR(20) NULL
)
;



ALTER TABLE RADNO_MJESTO
	ADD  PRIMARY KEY (idRadnoMjesto)
;



CREATE TABLE REZERVACIJA
(
	idKarte               VARCHAR(20) NOT NULL,
	vrijemeRezervacije    DATE NULL,
	opisRezervacije       VARCHAR(20) NULL,
	idZaposleni           VARCHAR(20) NOT NULL
)
;



ALTER TABLE REZERVACIJA
	ADD  PRIMARY KEY (idKarte)
;



CREATE TABLE SALA
(
	idSala                VARCHAR(20) NULL,
	naziv                 VARCHAR(20) NULL,
	aktivna               INTEGER NULL
)
;



ALTER TABLE SALA
	ADD  PRIMARY KEY (idSala)
;



CREATE TABLE SJEDISTE
(
	idSjediste            VARCHAR(20) NULL,
	red                   INTEGER NULL,
	broj                  INTEGER NULL,
	slobodno              INTEGER NULL,
	idSala                VARCHAR(20) NOT NULL
)
;



ALTER TABLE SJEDISTE
	ADD  PRIMARY KEY (idSjediste)
;



CREATE TABLE STATUS_FILM
(
	idStatus              VARCHAR(20) NULL,
	naziv                 VARCHAR(20) NULL
)
;



ALTER TABLE STATUS_FILM
	ADD  PRIMARY KEY (idStatus)
;



CREATE TABLE STATUS_ZAPOSLENI
(
	idStatus              VARCHAR(20) NULL,
	naziv                 VARCHAR(20) NULL
)
;



ALTER TABLE STATUS_ZAPOSLENI
	ADD  PRIMARY KEY (idStatus)
;



CREATE TABLE ZAPOSLENI
(
	idZaposleni           VARCHAR(20) NULL,
	korisnickoIme         VARCHAR(20) NULL,
	lozinka               VARCHAR(20) NULL,
	ime                   VARCHAR(20) NULL,
	prezime               VARCHAR(20) NULL,
	datumRodjenja         DATE NULL,
	telefon               VARCHAR(20) NULL,
	datumZaposlenja       VARCHAR(20) NULL,
	datumOtkaza           CHAR(18) NULL,
	idStatus              VARCHAR(20) NOT NULL,
	e_mail                VARCHAR(20) NULL
)
;



ALTER TABLE ZAPOSLENI
	ADD  PRIMARY KEY (idZaposleni)
;



CREATE TABLE ZAPOSLENI_RADNO_MJESTO
(
	idZaposleni           VARCHAR(20) NOT NULL,
	idRadnoMjesto         VARCHAR(20) NOT NULL
)
;



ALTER TABLE ZAPOSLENI_RADNO_MJESTO
	ADD  PRIMARY KEY (idZaposleni,idRadnoMjesto)
;



ALTER TABLE FILM
	ADD FOREIGN KEY R_4 (idDistributer) REFERENCES DISTRIBUTER(idDistributer)
;


ALTER TABLE FILM
	ADD FOREIGN KEY R_5 (idStatus) REFERENCES STATUS_FILM(idStatus)
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



ALTER TABLE PROJEKCIJA
	ADD FOREIGN KEY R_7 (idSala) REFERENCES SALA(idSala)
;


ALTER TABLE PROJEKCIJA
	ADD FOREIGN KEY R_8 (idFilm) REFERENCES FILM(idFilm)
;



ALTER TABLE REZERVACIJA
	ADD FOREIGN KEY R_11 (idKarte) REFERENCES KARTA(idKarte)
;


ALTER TABLE REZERVACIJA
	ADD FOREIGN KEY R_13 (idZaposleni) REFERENCES ZAPOSLENI(idZaposleni)
;



ALTER TABLE SJEDISTE
	ADD FOREIGN KEY R_6 (idSala) REFERENCES SALA(idSala)
;



ALTER TABLE ZAPOSLENI
	ADD FOREIGN KEY R_1 (idStatus) REFERENCES STATUS_ZAPOSLENI(idStatus)
;



ALTER TABLE ZAPOSLENI_RADNO_MJESTO
	ADD FOREIGN KEY R_2 (idZaposleni) REFERENCES ZAPOSLENI(idZaposleni)
;


ALTER TABLE ZAPOSLENI_RADNO_MJESTO
	ADD FOREIGN KEY R_3 (idRadnoMjesto) REFERENCES RADNO_MJESTO(idRadnoMjesto)
;


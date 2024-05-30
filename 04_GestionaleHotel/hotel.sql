hotelcamere-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versione server:              10.4.20-MariaDB - mariadb.org binary distribution
-- S.O. server:                  Win64
-- HeidiSQL Versione:            11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dump della struttura del database hotel
CREATE DATABASE IF NOT EXISTS `hotel` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `hotel`;

-- Dump della struttura di tabella hotel.camere
CREATE TABLE IF NOT EXISTS `camere` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Posti` int(11) NOT NULL,
  `Foto` varchar(50) DEFAULT NULL,
  `Costo` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4;

-- Dump dei dati della tabella hotel.camere: ~10 rows (circa)
/*!40000 ALTER TABLE `camere` DISABLE KEYS */;
INSERT INTO `camere` (`ID`, `Posti`, `Foto`, `Costo`) VALUES
	(1, 3, 'Camera1.jpg', 79.99),
	(2, 2, 'Camera2.jpg', 84.99),
	(3, 4, 'Camera3.jpg', 99.99),
	(4, 3, 'Camera7.jpg', 74.99),
	(5, 2, 'Camera4.jpg', 114.99),
	(7, 2, 'Camera4_2.jpg', 69.99),
	(8, 2, 'Camera4_3.jpg', 74.99),
	(9, 3, 'Camera5.jpg', 94.99),
	(10, 2, 'Camera6.jpg', 64.99),
	(11, 4, 'Camera_1.jpg', 79.98);
/*!40000 ALTER TABLE `camere` ENABLE KEYS */;

-- Dump della struttura di tabella hotel.clienti
CREATE TABLE IF NOT EXISTS `clienti` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Cognome` varchar(50) NOT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

-- Dump dei dati della tabella hotel.clienti: ~6 rows (circa)
/*!40000 ALTER TABLE `clienti` DISABLE KEYS */;
INSERT INTO `clienti` (`ID`, `Nome`, `Cognome`, `Telefono`, `email`) VALUES
	(1, 'Luca', 'Scala', '3755780851', 'luca.scalabrin@barsanti.edu.it'),
	(2, 'Simone', 'Marchi', NULL, 'simone.marchi@barsanti.edu.it'),
	(3, 'Nicolò', 'Russello', '3458173115', NULL),
	(4, 'Enrico', 'Guarda', NULL, NULL),
	(5, 'Alessandro', 'Favaro', '3290643591', 'alessandro.favaro@barsanti.edu.it'),
	(6, 'Alessandro', 'Dinato', NULL, 'alessanfro.dinato@barsanti.edu.it'),
	(7, 'Matteo', 'Messina Denaro', NULL, NULL);
/*!40000 ALTER TABLE `clienti` ENABLE KEYS */;

-- Dump della struttura di tabella hotel.prenotazioni
CREATE TABLE IF NOT EXISTS `prenotazioni` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CheckIn` date NOT NULL,
  `CheckOut` date NOT NULL,
  `NumPersone` int(11) NOT NULL,
  `IDTrattamento` varchar(50) NOT NULL,
  `IDCliente` int(11) NOT NULL,
  `IDCamera` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_prenotazioni_trattamenti` (`IDTrattamento`),
  KEY `FK_prenotazioni_clienti` (`IDCliente`),
  KEY `FK_prenotazioni_camere` (`IDCamera`),
  CONSTRAINT `FK_prenotazioni_camere` FOREIGN KEY (`IDCamera`) REFERENCES `camere` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK_prenotazioni_clienti` FOREIGN KEY (`IDCliente`) REFERENCES `clienti` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `FK_prenotazioni_trattamenti` FOREIGN KEY (`IDTrattamento`) REFERENCES `trattamenti` (`Tipo`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

-- Dump dei dati della tabella hotel.prenotazioni: ~0 rows (circa)
/*!40000 ALTER TABLE `prenotazioni` DISABLE KEYS */;
INSERT INTO `prenotazioni` (`ID`, `CheckIn`, `CheckOut`, `NumPersone`, `IDTrattamento`, `IDCliente`, `IDCamera`) VALUES
	(1, '2023-01-20', '2023-01-24', 2, 'luxury', 1, 5),
	(2, '2023-01-27', '2023-02-02', 1, 'mezza-pensione', 4, 8),
	(3, '2023-01-25', '2023-01-29', 1, 'all-inclusive', 6, 10),
	(4, '2023-01-20', '2023-01-27', 3, 'pensione', 3, 3),
	(5, '2023-01-27', '2023-01-30', 2, 'luxury', 2, 1),
	(6, '2023-01-28', '2023-02-03', 1, 'all-inclusive', 5, 2),
	(8, '2023-02-07', '2023-02-10', 1, 'pensione', 3, 5);
/*!40000 ALTER TABLE `prenotazioni` ENABLE KEYS */;

-- Dump della struttura di tabella hotel.recensioni
CREATE TABLE IF NOT EXISTS `recensioni` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDCamera` int(11) NOT NULL,
  `Voto` double NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__camere` (`IDCamera`),
  CONSTRAINT `FK__camere` FOREIGN KEY (`IDCamera`) REFERENCES `camere` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- Dump dei dati della tabella hotel.recensioni: ~0 rows (circa)
/*!40000 ALTER TABLE `recensioni` DISABLE KEYS */;
INSERT INTO `recensioni` (`ID`, `IDCamera`, `Voto`) VALUES
	(1, 5, 4.75),
	(2, 8, 4),
	(3, 8, 4.5),
	(4, 2, 4),
	(5, 3, 4.25),
	(6, 3, 4),
	(7, 7, 4.75),
	(8, 7, 4.25);
/*!40000 ALTER TABLE `recensioni` ENABLE KEYS */;

-- Dump della struttura di tabella hotel.trattamenti
CREATE TABLE IF NOT EXISTS `trattamenti` (
  `Tipo` varchar(50) NOT NULL,
  `MoltiplicatoreCosto` double NOT NULL,
  PRIMARY KEY (`Tipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dump dei dati della tabella hotel.trattamenti: ~0 rows (circa)
/*!40000 ALTER TABLE `trattamenti` DISABLE KEYS */;
INSERT INTO `trattamenti` (`Tipo`, `MoltiplicatoreCosto`) VALUES
	('all-inclusive', 2),
	('luxury', 1.75),
	('mezza-pensione', 1),
	('pensione', 1.5);
/*!40000 ALTER TABLE `trattamenti` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.32-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             12.7.0.6850
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for hotel
CREATE DATABASE IF NOT EXISTS `hotel` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `hotel`;

-- Dumping structure for table hotel.camere
CREATE TABLE IF NOT EXISTS `camere` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Posti` int(11) NOT NULL,
  `Foto` varchar(50) DEFAULT NULL,
  `Costo` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table hotel.clienti
CREATE TABLE IF NOT EXISTS `clienti` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Cognome` varchar(50) NOT NULL,
  `Telefono` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table hotel.prenotazioni
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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table hotel.recensioni
CREATE TABLE IF NOT EXISTS `recensioni` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDCamera` int(11) NOT NULL,
  `Voto` double NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__camere` (`IDCamera`),
  CONSTRAINT `FK__camere` FOREIGN KEY (`IDCamera`) REFERENCES `camere` (`ID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table hotel.trattamenti
CREATE TABLE IF NOT EXISTS `trattamenti` (
  `Tipo` varchar(50) NOT NULL,
  `MoltiplicatoreCosto` double NOT NULL,
  PRIMARY KEY (`Tipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

-- --------------------------------------------------------
-- Hôte :                        localhost
-- Version du serveur:           5.6.35 - MySQL Community Server (GPL)
-- SE du serveur:                Win32
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Listage de la structure de la base pour projet_web
CREATE DATABASE IF NOT EXISTS `projet_web` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `projet_web`;

-- Listage de la structure de la table projet_web. commentaires
CREATE TABLE IF NOT EXISTS `commentaires` (
  `ID_COMMENTAIRES` int(11) NOT NULL AUTO_INCREMENT,
  `COMMENTAIRE` varchar(50) NOT NULL DEFAULT '',
  `PHOTO_ID` int(11) NOT NULL DEFAULT '0',
  `USERS_ID` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID_COMMENTAIRES`),
  KEY `FK__users` (`USERS_ID`),
  KEY `FK_commentaires_photos` (`PHOTO_ID`),
  CONSTRAINT `FK__users` FOREIGN KEY (`USERS_ID`) REFERENCES `users` (`LOGIN`),
  CONSTRAINT `FK_commentaires_photos` FOREIGN KEY (`PHOTO_ID`) REFERENCES `photos` (`ID_PHOTO`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Listage des données de la table projet_web.commentaires : ~1 rows (environ)
/*!40000 ALTER TABLE `commentaires` DISABLE KEYS */;
REPLACE INTO `commentaires` (`ID_COMMENTAIRES`, `COMMENTAIRE`, `PHOTO_ID`, `USERS_ID`) VALUES
	(1, 'Ca me rappelle mon voyage avec Reddington', 10, 'Koslov123');
/*!40000 ALTER TABLE `commentaires` ENABLE KEYS */;

-- Listage de la structure de la table projet_web. messages
CREATE TABLE IF NOT EXISTS `messages` (
  `ID_MESSAGE` int(11) NOT NULL AUTO_INCREMENT,
  `MESSAGE` text NOT NULL,
  `ENVOYEUR_ID` varchar(50) NOT NULL,
  `RECEPTEUR_ID` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_MESSAGE`),
  KEY `FK_messages_users` (`ENVOYEUR_ID`),
  KEY `FK_messages_users_2` (`RECEPTEUR_ID`),
  CONSTRAINT `FK_messages_users` FOREIGN KEY (`ENVOYEUR_ID`) REFERENCES `users` (`LOGIN`),
  CONSTRAINT `FK_messages_users_2` FOREIGN KEY (`RECEPTEUR_ID`) REFERENCES `users` (`LOGIN`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Listage des données de la table projet_web.messages : ~5 rows (environ)
/*!40000 ALTER TABLE `messages` DISABLE KEYS */;
REPLACE INTO `messages` (`ID_MESSAGE`, `MESSAGE`, `ENVOYEUR_ID`, `RECEPTEUR_ID`) VALUES
	(1, 'Salut mec', 'Momods', 'GrosseMoula'),
	(2, 'Je t\'ai dis salut reponds moi', 'Momods', 'GrosseMoula'),
	(3, 'Laisse moi tranquille avec tes messages', 'GrosseMoula', 'Momods'),
	(4, 'DZdz', 'GrosseMoula', 'Momods'),
	(5, 'J\'ai demandé à Katarina Rostova de protéger Macha', 'Koslov123', 'GrosseMoula'),
	(6, 'J\'espère qu\'elle tiendra parole, je ne veux pas que Reddington fasse n\'importe quoi', 'GrosseMoula', 'Koslov123');
/*!40000 ALTER TABLE `messages` ENABLE KEYS */;

-- Listage de la structure de la table projet_web. photos
CREATE TABLE IF NOT EXISTS `photos` (
  `ID_PHOTO` int(11) NOT NULL AUTO_INCREMENT,
  `PHOTO` varchar(50) NOT NULL,
  `LIEU` varchar(50) NOT NULL,
  `MOMENT` varchar(50) NOT NULL,
  `LONGITUDE` double NOT NULL DEFAULT '0',
  `LATITUDE` double NOT NULL DEFAULT '0',
  `USERS_ID` varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID_PHOTO`),
  KEY `FK_photos_users` (`USERS_ID`),
  CONSTRAINT `FK_photos_users` FOREIGN KEY (`USERS_ID`) REFERENCES `users` (`LOGIN`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Listage des données de la table projet_web.photos : ~0 rows (environ)
/*!40000 ALTER TABLE `photos` DISABLE KEYS */;
REPLACE INTO `photos` (`ID_PHOTO`, `PHOTO`, `LIEU`, `MOMENT`, `LONGITUDE`, `LATITUDE`, `USERS_ID`) VALUES
	(10, 'unnamed.jpg', 'Brussels-Capital', 'dimanche 16 ao', 4.3477615, 50.8585388, 'Momods');
/*!40000 ALTER TABLE `photos` ENABLE KEYS */;

-- Listage de la structure de la table projet_web. users
CREATE TABLE IF NOT EXISTS `users` (
  `LOGIN` varchar(50) NOT NULL,
  `PASSWORD` varchar(50) NOT NULL,
  `NOM` varchar(50) NOT NULL,
  `PRENOM` varchar(50) NOT NULL,
  `EMAIL` varchar(50) NOT NULL,
  `ROLE` varchar(50) NOT NULL,
  PRIMARY KEY (`LOGIN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Listage des données de la table projet_web.users : ~1 rows (environ)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
REPLACE INTO `users` (`LOGIN`, `PASSWORD`, `NOM`, `PRENOM`, `EMAIL`, `ROLE`) VALUES
	('GrosseMoula', 'e10adc3949ba59abbe56e057f20f883e', 'Hajjioui', 'Khalid', 'khalid-bxl@hotmail.fr', 'admin'),
	('Koslov123', '827ccb0eea8a706c4c34a16891f84e7b', 'Koslov', 'Ilya', 'ilyakoslov@kgb.ru', 'user'),
	('Momods', 'e10adc3949ba59abbe56e057f20f883e', 'Derazi', 'Mohamed', 'momods@momods.com', 'user');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

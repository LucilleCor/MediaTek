-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 15 mai 2026 à 13:14
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek`
--
CREATE DATABASE IF NOT EXISTS mediatek DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'MediaAdmin'@'%' IDENTIFIED BY 'media';
GRANT USAGE ON *.* TO 'mediatek'@'%';
GRANT ALL PRIVILEGES ON `mediatek`.* TO 'mediatek'@'%';
USE mediatek;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime NOT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`) USING BTREE,
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(1, '2025-12-03 22:52:58', '2025-12-18 01:59:01', 3),
(2, '2025-11-27 03:10:10', '2025-12-28 02:08:18', 4),
(3, '2025-12-08 19:43:17', '2026-01-11 03:08:18', 3),
(4, '2025-12-08 10:59:52', '2026-01-09 19:26:31', 2),
(5, '2025-12-06 18:48:28', '2026-01-03 17:23:18', 1),
(6, '2025-11-23 14:09:22', '2026-01-11 03:03:55', 2),
(7, '2025-11-17 00:55:14', '2026-01-03 11:32:19', 1),
(8, '2025-11-20 00:33:55', '2026-01-11 16:17:09', 4),
(9, '2025-12-10 12:33:04', '2026-01-04 16:55:25', 3),
(10, '2025-11-29 15:05:11', '2025-12-15 15:56:33', 2),
(1, '2026-02-06 17:34:45', '2026-02-19 22:05:18', 3),
(2, '2026-02-06 13:07:45', '2026-02-20 23:28:42', 2),
(3, '2026-02-12 22:45:13', '2026-02-19 08:47:51', 3),
(4, '2026-02-10 02:56:43', '2026-02-20 20:56:53', 3),
(5, '2026-02-10 02:26:46', '2026-02-15 08:09:49', 3),
(6, '2026-02-12 09:44:40', '2026-02-17 19:15:28', 3),
(7, '2026-02-13 02:24:00', '2026-02-20 22:44:59', 1),
(8, '2026-02-06 13:07:08', '2026-02-20 21:49:17', 1),
(9, '2026-02-08 19:05:14', '2026-02-16 07:08:07', 2),
(10, '2026-02-11 16:48:07', '2026-02-16 12:25:56', 2)
(1, '2026-02-26 16:39:51', '2026-03-02 19:51:06', 4),
(2, '2026-02-27 14:05:55', '2026-03-04 21:53:12', 3),
(3, '2026-02-25 15:22:35', '2026-03-02 19:21:48', 1),
(4, '2026-02-26 06:48:14', '2026-03-12 19:27:15', 1),
(5, '2026-02-24 20:57:50', '2026-03-01 16:54:10', 2),
(6, '2026-02-27 05:30:27', '2026-03-20 10:51:28', 3),
(7, '2026-02-23 19:18:14', '2026-03-05 09:24:52', 2),
(8, '2026-02-27 08:38:06', '2026-03-09 07:43:44', 1),
(9, '2026-02-27 22:52:10', '2026-03-21 11:14:46', 1),
(10, '2026-02-26 20:17:57', '2026-03-04 05:29:35', 3),
(1, '2026-03-09 16:15:41', '2026-03-15 13:50:22', 4),
(2, '2026-03-10 08:38:30', '2026-03-20 18:22:58', 3),
(3, '2026-03-13 23:24:39', '2026-03-20 00:40:33', 1),
(4, '2026-03-09 01:50:20', '2026-03-19 01:47:13', 1),
(5, '2026-03-14 05:45:06', '2026-03-20 05:44:48', 2),
(6, '2026-03-10 20:20:14', '2026-03-19 11:44:49', 3),
(7, '2026-03-08 13:07:08', '2026-03-19 11:48:07', 2),
(8, '2026-03-11 04:02:41', '2026-03-17 01:53:05', 2),
(9, '2026-03-11 11:10:04', '2026-03-21 10:44:04', 1),
(10, '2026-03-09 00:56:09', '2026-03-16 17:16:49', 3),
(6, '2026-04-04 17:56:58', '2026-04-10 17:56:58', 4),
(1, '2026-03-23 15:19:41', '2026-03-31 20:11:39', 4),
(2, '2026-03-28 08:27:01', '2026-04-02 10:34:57', 3),
(3, '2026-03-28 06:59:26', '2026-04-01 13:51:28', 1),
(4, '2026-03-26 14:18:15', '2026-03-31 17:09:36', 1),
(5, '2026-03-24 13:56:53', '2026-03-29 16:07:01', 2),
(6, '2026-03-22 18:52:46', '2026-04-03 19:11:37', 3),
(7, '2026-03-27 14:42:42', '2026-03-29 21:00:59', 2),
(8, '2026-05-13 19:05:18', '2026-05-14 19:05:19', 2),
(9, '2026-03-25 17:21:11', '2026-04-02 12:32:18', 1),
(10, '2026-03-22 23:17:52', '2026-04-01 14:51:54', 3),
(6, '2026-05-13 19:03:49', '2026-05-14 19:03:49', 4);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Small', 'Fay', '05 11 35 29 61', 'tempus.non@outlook.edu', 1),
(2, 'Hudson', 'Xanthus', '02 87 14 46 54', 'enim@outlook.com', 3),
(3, 'Beach', 'Signe', '02 55 95 11 55', 'vestibulum.accumsan.neque@protonmail.ca', 2),
(4, 'Willis', 'Emery', '08 42 91 22 47', 'amet.consectetuer@outlook.com', 2),
(5, 'Shepard', 'Finn', '08 03 63 52 11', 'a.odio@protonmail.edu', 1),
(6, 'Brock', 'Judah', '06 17 67 11 17', 'ac.feugiat.non@hotmail.edu', 2),
(7, 'Riggs', 'Nathan', '02 40 71 18 74', 'nisi.aenean@google.edu', 2),
(8, 'Barker', 'Abdul', '05 85 32 94 54', 'pede.cras@aol.edu', 1),
(9, 'Freema', 'Winte', '08 17 10 26 96', 'mi.tempor.lorem@aol.c', 3),
(10, 'Jenkins', 'Candace', '02 48 14 54 56', 'faucibus.leo.in@hotmail.couk', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('MediaAdmin', '721c9525ade2ea8903d343ef25cf68b9bf4ab0aad56bb7b01fbe48d09bc7fcf4');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'mediation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

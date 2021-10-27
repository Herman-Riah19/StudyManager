-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Lun 14 Octobre 2019 à 19:36
-- Version du serveur :  10.1.9-MariaDB
-- Version de PHP :  5.6.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `gestion_etudiant`
--

-- --------------------------------------------------------

--
-- Structure de la table `avoir_note`
--

CREATE TABLE `avoir_note` (
  `Id_avoirNote` int(11) NOT NULL,
  `Note1` double DEFAULT NULL,
  `Note2` double DEFAULT NULL,
  `Note3` double DEFAULT NULL,
  `Note4` double DEFAULT NULL,
  `Note5` double DEFAULT NULL,
  `Note6` double DEFAULT NULL,
  `Moyenne` double NOT NULL,
  `Mention` varchar(50) NOT NULL,
  `Commentaire` varchar(100) NOT NULL,
  `Id_etudiant` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `avoir_note`
--

INSERT INTO `avoir_note` (`Id_avoirNote`, `Note1`, `Note2`, `Note3`, `Note4`, `Note5`, `Note6`, `Moyenne`, `Mention`, `Commentaire`, `Id_etudiant`) VALUES
(1, 4, 4, 13, 12, 1, 10, 7, 'Mauvais', 'Vous êtes Eliminer', 136);

-- --------------------------------------------------------

--
-- Structure de la table `filiere`
--

CREATE TABLE `filiere` (
  `Code_filiere` int(11) NOT NULL,
  `Denomination` varchar(50) NOT NULL,
  `Abreviation` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `filiere`
--

INSERT INTO `filiere` (`Code_filiere`, `Denomination`, `Abreviation`) VALUES
(1, 'Management', 'MA'),
(2, 'Telecommunication', 'TELCOM'),
(3, 'Tourisme et Hotelerie', 'TVH'),
(4, 'Multimedia et Communication', 'MC'),
(5, 'Informatique de gestion', 'IG');

-- --------------------------------------------------------

--
-- Structure de la table `tableetudiant`
--

CREATE TABLE `tableetudiant` (
  `Id_etudiant` int(11) NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `DateNaissance` varchar(50) NOT NULL,
  `Code_filiere` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `tableetudiant`
--

INSERT INTO `tableetudiant` (`Id_etudiant`, `Nom`, `Prenom`, `DateNaissance`, `Code_filiere`) VALUES
(136, 'Beraketa', 'Beenjy', '12/11/1998', 1);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `avoir_note`
--
ALTER TABLE `avoir_note`
  ADD PRIMARY KEY (`Id_avoirNote`),
  ADD KEY `Id_etudiant` (`Id_etudiant`);

--
-- Index pour la table `filiere`
--
ALTER TABLE `filiere`
  ADD PRIMARY KEY (`Code_filiere`);

--
-- Index pour la table `tableetudiant`
--
ALTER TABLE `tableetudiant`
  ADD PRIMARY KEY (`Id_etudiant`),
  ADD KEY `Code_filiere` (`Code_filiere`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `avoir_note`
--
ALTER TABLE `avoir_note`
  MODIFY `Id_avoirNote` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `avoir_note`
--
ALTER TABLE `avoir_note`
  ADD CONSTRAINT `avoir_note_ibfk_3` FOREIGN KEY (`Id_etudiant`) REFERENCES `tableetudiant` (`Id_etudiant`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `tableetudiant`
--
ALTER TABLE `tableetudiant`
  ADD CONSTRAINT `tableetudiant_ibfk_2` FOREIGN KEY (`Code_filiere`) REFERENCES `filiere` (`Code_filiere`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

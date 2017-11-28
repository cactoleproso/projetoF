-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.22-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para test
CREATE DATABASE IF NOT EXISTS `test` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `test`;

-- Copiando estrutura para tabela test.bandas
CREATE TABLE IF NOT EXISTS `bandas` (
  `id` int(225) NOT NULL AUTO_INCREMENT,
  `nome` text NOT NULL,
  `numint` int(11) NOT NULL,
  `nomemusica` text NOT NULL,
  `diapref` int(11) NOT NULL,
  `instru` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela test.bandas: ~6 rows (aproximadamente)
/*!40000 ALTER TABLE `bandas` DISABLE KEYS */;
INSERT INTO `bandas` (`id`, `nome`, `numint`, `nomemusica`, `diapref`, `instru`) VALUES
	(1, 'aaaa', 1, 'Rodeio', 1, 0),
	(2, 'caralho', 1, 'caralho', 1, 1),
	(3, 'a', 2, 'aa', 1, 1),
	(4, 'Meupau', 2, 'Meupau', 2, 1),
	(5, 'cacete queimado', 2, 'risos', 1, 1),
	(6, 'ronaldinho', 3, 'gaucho', 2, 1);
/*!40000 ALTER TABLE `bandas` ENABLE KEYS */;

-- Copiando estrutura para tabela test.login
CREATE TABLE IF NOT EXISTS `login` (
  `nome` text,
  `senha` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela test.login: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` (`nome`, `senha`) VALUES
	('admin', 'senha');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

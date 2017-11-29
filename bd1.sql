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

-- Copiando estrutura para tabela test.banda
CREATE TABLE IF NOT EXISTS `banda` (
  `id` int(225) NOT NULL AUTO_INCREMENT,
  `nome` text NOT NULL,
  `numint` int(11) NOT NULL,
  `nomemusica` text NOT NULL,
  `diapref` int(11) NOT NULL,
  `instru` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=80 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela test.banda: ~62 rows (aproximadamente)
/*!40000 ALTER TABLE `banda` DISABLE KEYS */;
INSERT INTO `banda` (`id`, `nome`, `numint`, `nomemusica`, `diapref`, `instru`) VALUES
	(18, 'Alpacas em Chamas', 4, 'MusicaRuim', 1, 0),
	(19, 'Rodeio', 3, 'Is this it', 2, 1),
	(20, 'Passeio', 5, 'MusicaPica', 2, 1),
	(21, 'Coxi', 1, 'ProfessorDaora', 1, 0),
	(22, 'Bruno', 1, 'ProfessorDaora', 1, 0),
	(23, 'Marcelo', 1, 'Professor', 1, 0),
	(24, 'Walmir', 1, 'ProfessorDaora', 1, 0),
	(25, '2001', 5, 'Musica', 1, 0),
	(26, 'O cara', 1, 'Lolicon', 2, 1),
	(27, 'AnimeÉmerda', 1, 'Realmente', 2, 1),
	(28, 'é um facista', 4, 'asdas', 2, 1),
	(29, 'EduardoPeidao', 1, 'Cheira mal', 2, 0),
	(30, 'Pizza Do Bruno', 1, 'ProfessorPICA', 1, 1),
	(31, 'Banda Dos Professores', 1, 'HMm', 2, 0),
	(32, 'EH msm e', 6, 'hmm', 1, 0),
	(33, 'Final de evangelion me faz chorar', 1, 'shinji lixo', 2, 0),
	(34, 'CARAMBA', 1, 'REALMENTE', 1, 0),
	(35, 'PAF', 6, 'PAFEIROS', 2, 0),
	(36, 'caraca', 3, 'a', 1, 1),
	(37, 'a', 1, 'a', 1, 1),
	(38, 'teste', 1, 'b', 1, 1),
	(39, 'b', 2, 'b', 1, 0),
	(40, 'c', 2, 'c', 1, 0),
	(41, 'd', 1, 'd', 1, 1),
	(42, 'e', 1, 'e', 1, 1),
	(43, 'f', 1, 'f', 1, 1),
	(44, 'g', 1, 'g', 1, 1),
	(45, 'h', 1, 'h', 1, 1),
	(46, 'i', 1, 'i', 2, 0),
	(47, 'j', 1, 'j', 2, 0),
	(48, 'k', 1, 'k', 1, 1),
	(49, 'll', 1, 'l', 1, 0),
	(50, 'ads', 1, 'asd', 1, 1),
	(51, 'bbb', 1, 'asd', 1, 1),
	(52, 'er', 1, 'er', 1, 1),
	(53, 'erefd', 1, 'efr', 1, 1),
	(54, 'aaaaaa', 1, '1', 1, 1),
	(55, 'bbbbbanda', 1, '1', 1, 1),
	(56, 'kkk', 1, '1', 1, 1),
	(57, 'jjjjj', 1, '1', 1, 1),
	(58, 'lllllllll', 1, '1', 1, 1),
	(59, 'abc', 1, '1', 1, 1),
	(60, 'hmmmmm', 1, '1', 1, 1),
	(61, 'asdfkljakldaskld', 1, '1', 1, 1),
	(62, 'sdçlfjdmwklmd', 1, '1', 1, 1),
	(63, 'tiroteio', 1, '1', 1, 1),
	(64, 'Torneio', 1, '1', 1, 1),
	(65, 'Carambeio', 1, '1', 1, 1),
	(66, 'cabeceio', 1, '1', 1, 1),
	(67, 'senteio', 1, '1', 1, 1),
	(68, 'chameio', 1, '1', 1, 1),
	(69, 'felipeio', 1, '1', 1, 1),
	(70, 'eduardo fdp', 1, '1', 1, 1),
	(71, 'viadoa', 1, '1', 1, 1),
	(72, 'aklsdjkaldjwlakjdakld', 1, '1', 1, 1),
	(73, 'vermeeeeee', 1, '1', 1, 1),
	(74, 'MEC', 1, '1', 1, 1),
	(75, 'Enem', 1, '1', 1, 1),
	(76, 'dudupeidao', 1, '1', 1, 1),
	(77, 'comeovopodre', 1, '1', 1, 1),
	(78, 'piruzal', 1, '1', 1, 1),
	(79, 'pirulivei', 1, '1', 1, 1);
/*!40000 ALTER TABLE `banda` ENABLE KEYS */;

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

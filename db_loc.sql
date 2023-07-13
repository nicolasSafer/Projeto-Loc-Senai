-- MariaDB dump 10.19  Distrib 10.4.24-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: db_loc
-- ------------------------------------------------------
-- Server version	10.4.24-MariaDB

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
-- Table structure for table `tb_bloco`
--

DROP TABLE IF EXISTS `tb_bloco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_bloco` (
  `id_bloco` int(6) NOT NULL AUTO_INCREMENT,
  `nome_bloco` varchar(50) NOT NULL,
  PRIMARY KEY (`id_bloco`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_bloco`
--

LOCK TABLES `tb_bloco` WRITE;
/*!40000 ALTER TABLE `tb_bloco` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_bloco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cadastro_evento`
--

DROP TABLE IF EXISTS `tb_cadastro_evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cadastro_evento` (
  `id_cevento` int(6) NOT NULL,
  `id_funcionario` int(6) NOT NULL,
  `id_evento` int(6) NOT NULL,
  `dia_do_cadastro` date NOT NULL,
  `horario_do_cadastro` time NOT NULL,
  PRIMARY KEY (`id_cevento`),
  KEY `fk_id_funcionario` (`id_funcionario`),
  KEY `fk_id_evento` (`id_evento`),
  CONSTRAINT `fk_id_evento` FOREIGN KEY (`id_evento`) REFERENCES `tb_evento` (`id_evento`) ON UPDATE CASCADE,
  CONSTRAINT `fk_id_funcionario` FOREIGN KEY (`id_funcionario`) REFERENCES `tb_funcionario` (`id_funcionario`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cadastro_evento`
--

LOCK TABLES `tb_cadastro_evento` WRITE;
/*!40000 ALTER TABLE `tb_cadastro_evento` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cadastro_evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_cadastro_sala`
--

DROP TABLE IF EXISTS `tb_cadastro_sala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_cadastro_sala` (
  `id_csala` int(6) NOT NULL AUTO_INCREMENT,
  `id_funcionario` int(6) NOT NULL,
  `id_sala` int(6) NOT NULL,
  `dia_do_cadastro` date NOT NULL,
  `hora_do_cadastro` time NOT NULL,
  PRIMARY KEY (`id_csala`),
  KEY `fk_id_funcionario_3` (`id_funcionario`),
  KEY `fk_id_sala` (`id_sala`),
  CONSTRAINT `fk_id_funcionario_3` FOREIGN KEY (`id_funcionario`) REFERENCES `tb_funcionario` (`id_funcionario`) ON UPDATE CASCADE,
  CONSTRAINT `fk_id_sala` FOREIGN KEY (`id_sala`) REFERENCES `tb_sala_do_predio` (`id_sala`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_cadastro_sala`
--

LOCK TABLES `tb_cadastro_sala` WRITE;
/*!40000 ALTER TABLE `tb_cadastro_sala` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_cadastro_sala` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_evento`
--

DROP TABLE IF EXISTS `tb_evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_evento` (
  `id_evento` int(6) NOT NULL AUTO_INCREMENT,
  `nome_evento` varchar(50) NOT NULL,
  `local_evento` varchar(50) NOT NULL,
  `data_evento` varchar(50) NOT NULL,
  `horario_evento` varchar(50) NOT NULL,
  `descricao_evento` varchar(250) NOT NULL,
  `dia_semana` varchar(45) NOT NULL,
  PRIMARY KEY (`id_evento`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_evento`
--

LOCK TABLES `tb_evento` WRITE;
/*!40000 ALTER TABLE `tb_evento` DISABLE KEYS */;
INSERT INTO `tb_evento` VALUES (1,'PALESTRA - MULHERES NA INFRAESTRUTURA','Sala de Convenções 1','10/07/23','19:00','No ramo da Engenharia, Arquitetura, Agronomia e Geociência as mulheres estão cada vez mais presentes, esta iniciativa é para que Elas venham, cada vez mais, fazer parte das discussões, sugestões e ideias.',''),(2,'Palestra - Biotecnologia, a Proteção Ambiental','Sala de Convenções 2','11/07/23','17:00','O Palestrante Rui Alexandre Sabatke Gutierrez nasceu em Curitiba – PR, é oficial Reformado da Marinha no Posto de Capitão de Mar e Guerra (FN). Durante os mais de trinta anos em que esteve na ativa na Marinha de Guerra morou nas cidades do Rio de Jan',''),(3,'#Elas Inspiram: A Criar e Inovar','Átrios I e II','13/07/23','13:00','Apresentamos a você o evento mais aguardado do ano: \"Elas Inspiram a Criar e Inovar\". Em um cenário encantador e inusitado, a renomada Queijaria Vaca Profana, sob o comando da inspiradora Maristela Dalla Lasta, abrirá suas portas para nos contar sua ',''),(4,'Encontro de Negócios','Sala de Convenções 2','10/07/23','15:00','Participe do Encontro de Negócios e potencialize sua empresa! Conecte-se, apresente sua empresa e feche negócios com outros empreendedores. Garanta sua vaga agora!',''),(5,'Barragens de Terra e Enrocamento','AUDITÓRIO CAIO AMARAL GRUBER','14/07/23','09:00','',''),(6,'TRILHA MEI - GESTÃO FINANCEIRA','Átrios I e II','12/07/23','14:00','Essa trilha de capacitação foi desenvolvida especialmente para empreendedores como você, que desejam desenvolver uma visão empreendedora ampliada sobre a gestão financeira do seu negócio. Com ela, você aprenderá um conjunto de ações e procedimentos f','');
/*!40000 ALTER TABLE `tb_evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_feedback_software`
--

DROP TABLE IF EXISTS `tb_feedback_software`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_feedback_software` (
  `id_feedback` int(6) NOT NULL AUTO_INCREMENT,
  `nome_usuario` varchar(50) NOT NULL,
  `avaliacao_software` varchar(50) NOT NULL,
  `observacoes` varchar(250) NOT NULL,
  PRIMARY KEY (`id_feedback`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_feedback_software`
--

LOCK TABLES `tb_feedback_software` WRITE;
/*!40000 ALTER TABLE `tb_feedback_software` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_feedback_software` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcao_funcionario`
--

DROP TABLE IF EXISTS `tb_funcao_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_funcao_funcionario` (
  `id_funcao` int(6) NOT NULL AUTO_INCREMENT,
  `funcao_funcionario` varchar(50) NOT NULL,
  PRIMARY KEY (`id_funcao`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcao_funcionario`
--

LOCK TABLES `tb_funcao_funcionario` WRITE;
/*!40000 ALTER TABLE `tb_funcao_funcionario` DISABLE KEYS */;
INSERT INTO `tb_funcao_funcionario` VALUES (1,'ADM');
/*!40000 ALTER TABLE `tb_funcao_funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcionario`
--

DROP TABLE IF EXISTS `tb_funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_funcionario` (
  `id_funcionario` int(6) NOT NULL AUTO_INCREMENT,
  `nome_funcionario` varchar(50) NOT NULL,
  `email_funcionario` varchar(50) NOT NULL,
  `senha_funcionario` varchar(50) NOT NULL,
  `id_funcao` int(11) NOT NULL,
  `img` varchar(50) DEFAULT NULL,
  `usuario_funcionario` varchar(50) NOT NULL,
  PRIMARY KEY (`id_funcionario`),
  KEY `fk_id_funcao` (`id_funcao`),
  CONSTRAINT `fk_id_funcao` FOREIGN KEY (`id_funcao`) REFERENCES `tb_funcao_funcionario` (`id_funcao`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcionario`
--

LOCK TABLES `tb_funcionario` WRITE;
/*!40000 ALTER TABLE `tb_funcionario` DISABLE KEYS */;
INSERT INTO `tb_funcionario` VALUES (1,'Nicolas Fernandes','Nicolasfernandes@gmail.com','3013',1,' ','Nicolas'),(2,'Daniel Ferreira','Daniel@gmail.com','3013',1,' ','Daniel'),(3,'Lucas das Neves','Lucasneves@hotmail.com','3013',1,' ','Lucas'),(4,'Jorge Ciffoni','Jorginhociffoni@outlook.com','3013',1,' ','Jorge');
/*!40000 ALTER TABLE `tb_funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_sala_do_predio`
--

DROP TABLE IF EXISTS `tb_sala_do_predio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_sala_do_predio` (
  `id_sala` int(6) NOT NULL AUTO_INCREMENT,
  `nome_sala` varchar(50) NOT NULL,
  `descricao_sala` varchar(250) NOT NULL,
  `numeracao` varchar(50) DEFAULT NULL,
  `bloco` varchar(50) NOT NULL,
  PRIMARY KEY (`id_sala`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_sala_do_predio`
--

LOCK TABLES `tb_sala_do_predio` WRITE;
/*!40000 ALTER TABLE `tb_sala_do_predio` DISABLE KEYS */;
INSERT INTO `tb_sala_do_predio` VALUES (1,'Secretaria','Recepcionar pessoas; fornecer informações; atender pedidos, solicitações e chamadas telefônicas; filtrar ligações; anotar e transmitir recados; orientar e encaminhar pessoas; prestar atendimento especial a autoridades e usuários diferenciados.','0','C'),(2,'Coordenação','Alinhamento da grade do curso; Oferta de curso; Contratação de professores.','0','C'),(3,'Almoxarifado','O Almoxarifado é o local destinado à guarda, localização, segurança e preservação do material adquirido, adequado à sua natureza, a fim de suprir as necessidades operacionais dos setores integrantes da estrutura organizacional do SENAI.','0','C'),(4,'Biblioteca','É um espaço que reúne coleção de informações de qualquer tipo, sejam livros, enciclopédias, dicionário, monografias, revista, folhetos etc.','0','C'),(5,'Sala de aula','Reservado para aula','03','C'),(6,'Sala de Aula','Reservado para aula','10','C'),(7,'Lab. de Modelagem','O Laboratório de Modelagem e Vestuário é destinado ao desenvolvimento de trabalhos manuais dando assistência a várias disciplinas do curso e de outros cursos que necessitem da área de modelagem e costura.','01','C'),(8,'Lab. de Costura','Espaço reservado para aulas de costura','0','C');
/*!40000 ALTER TABLE `tb_sala_do_predio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_usuario`
--

DROP TABLE IF EXISTS `tb_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tb_usuario` (
  `id_usuario` int(6) NOT NULL AUTO_INCREMENT,
  `perfil` varchar(50) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_usuario`
--

LOCK TABLES `tb_usuario` WRITE;
/*!40000 ALTER TABLE `tb_usuario` DISABLE KEYS */;
INSERT INTO `tb_usuario` VALUES (1,'Nicolas'),(2,'lucas'),(3,'jorge');
/*!40000 ALTER TABLE `tb_usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-13 12:11:03

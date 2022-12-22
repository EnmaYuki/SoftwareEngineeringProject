-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 22, 2022 at 11:18 AM
-- Server version: 8.0.27
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `softwareengineera2`
--

-- --------------------------------------------------------

--
-- Table structure for table `testjson`
--

DROP TABLE IF EXISTS `testjson`;
CREATE TABLE IF NOT EXISTS `testjson` (
  `id` int NOT NULL AUTO_INCREMENT,
  `student` varchar(255) NOT NULL,
  `time` timestamp NOT NULL,
  `CourseId` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=1074 DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `testjson`
--

INSERT INTO `testjson` (`id`, `student`, `time`, `CourseId`) VALUES
(979, 's101', '2022-12-08 06:33:42', '3'),
(980, 's102', '2022-12-08 02:34:48', '3'),
(981, 's103', '2022-12-08 03:52:16', '3'),
(982, 's104', '2022-12-08 07:51:31', '3'),
(987, 's102', '2022-12-09 06:33:42', '3'),
(988, 's101', '2022-12-09 02:34:48', '3'),
(989, 's103', '2022-12-09 03:52:16', '3'),
(990, 's104', '2022-12-09 04:34:48', '3'),
(991, 's104', '2022-12-10 04:34:48', '3'),
(994, 's101', '2022-12-10 06:33:42', '3'),
(995, 's102', '2022-12-10 03:34:48', '3'),
(996, 's103', '2022-12-10 03:52:16', '3'),
(1001, 's101', '2022-12-11 06:33:42', '3'),
(1002, 's102', '2022-12-11 06:50:39', '3'),
(1003, 's103', '2022-12-11 03:52:16', '3'),
(1004, 's104', '2022-12-11 07:51:31', '3'),
(1009, 's102', '2022-12-12 06:33:42', '3'),
(1010, 's101', '2022-12-12 02:34:48', '3'),
(1011, 's103', '2022-12-12 03:52:16', '3'),
(1013, 's104', '2022-12-12 04:34:48', '3'),
(1017, 's101', '2022-12-13 06:33:42', '3'),
(1018, 's102', '2022-12-13 03:34:48', '3'),
(1019, 's103', '2022-12-13 03:52:16', '3'),
(1020, 's104', '2022-12-13 04:51:31', '3');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

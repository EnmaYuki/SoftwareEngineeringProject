-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 22, 2022 at 08:59 AM
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
CREATE DATABASE IF NOT EXISTS `softwareengineera2` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `softwareengineera2`;

-- --------------------------------------------------------

--
-- Table structure for table `lessons`
--

DROP TABLE IF EXISTS `lessons`;
CREATE TABLE IF NOT EXISTS `lessons` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Lesson` int NOT NULL,
  `Date` date NOT NULL,
  `courseId` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `lessons`
--

INSERT INTO `lessons` (`id`, `Lesson`, `Date`, `courseId`) VALUES
(1, 1, '2022-12-18', 2),
(2, 1, '2022-12-08', 3),
(3, 1, '2022-12-20', 1),
(4, 1, '2022-12-20', 6),
(5, 1, '2022-12-14', 4),
(6, 1, '2022-12-14', 5),
(7, 2, '2022-12-19', 2),
(8, 2, '2022-12-09', 3),
(9, 2, '2022-12-21', 1),
(10, 2, '2022-12-21', 6),
(11, 2, '2022-12-15', 4),
(12, 2, '2022-12-15', 5),
(13, 3, '2022-12-20', 2),
(14, 3, '2022-12-10', 3),
(15, 3, '2022-12-22', 1),
(16, 3, '2022-12-22', 6),
(17, 3, '2022-12-16', 4),
(18, 3, '2022-12-16', 5),
(19, 4, '2022-12-21', 2),
(20, 4, '2022-12-11', 3),
(21, 4, '2022-12-23', 1),
(22, 4, '2022-12-23', 6),
(23, 4, '2022-12-17', 4),
(24, 4, '2022-12-17', 5),
(25, 5, '2022-12-22', 2),
(26, 5, '2022-12-12', 3),
(27, 5, '2022-12-24', 1),
(28, 5, '2022-12-24', 6),
(29, 5, '2022-12-18', 4),
(30, 5, '2022-12-18', 5),
(31, 6, '2022-12-23', 2),
(32, 6, '2022-12-13', 3),
(33, 6, '2022-12-25', 1),
(34, 6, '2022-12-25', 6),
(35, 6, '2022-12-19', 4),
(36, 6, '2022-12-19', 5);

-- --------------------------------------------------------

--
-- Table structure for table `studentinfo`
--

DROP TABLE IF EXISTS `studentinfo`;
CREATE TABLE IF NOT EXISTS `studentinfo` (
  `student_id` varchar(10) NOT NULL,
  `Student_Name` varchar(255) NOT NULL,
  `Year` int NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `studentinfo`
--

INSERT INTO `studentinfo` (`student_id`, `Student_Name`, `Year`) VALUES
('s101', 'Ink', 1),
('s102', 'Jet', 1),
('s103', 'Kit', 1),
('s201', 'Ark', 2),
('s202', 'Blue', 2),
('s203', 'Cyan', 2),
('s204', 'Dark', 2),
('s205', 'Elf', 2),
('s104', 'Light', 1),
('s206', 'Fire', 2),
('s207', 'Grey', 2),
('s208', 'Hatred', 2);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
CREATE TABLE IF NOT EXISTS `subject` (
  `id` int NOT NULL AUTO_INCREMENT,
  `course_name` varchar(255) NOT NULL,
  `start_time` time NOT NULL,
  `class size` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`id`, `course_name`, `start_time`, `class size`) VALUES
(1, 'Unity', '22:30:00', 8),
(2, 'ionic', '22:30:00', 8),
(3, 'CSharp', '22:30:00', 8),
(4, 'Python', '22:30:00', 8),
(5, 'Java', '22:30:00', 8),
(6, 'SQL', '22:30:00', 8);

-- --------------------------------------------------------

--
-- Table structure for table `teacherinfo`
--

DROP TABLE IF EXISTS `teacherinfo`;
CREATE TABLE IF NOT EXISTS `teacherinfo` (
  `teacher_id` varchar(8) NOT NULL,
  `Teacher_Name` varchar(255) NOT NULL,
  `Greeting` varchar(255) NOT NULL,
  PRIMARY KEY (`teacher_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `teacherinfo`
--

INSERT INTO `teacherinfo` (`teacher_id`, `Teacher_Name`, `Greeting`) VALUES
('FT_H-CLT', 'Cheng Lok To', 'Terry'),
('PT_T-WWH', 'Woo Wing Hung', 'Charles'),
('PT_T-LPH', 'Lam Ping Him', 'Vincent'),
('PT_T-NWT', 'Ng Wing Ting', 'Stephen'),
('PT_T-FKH', 'Fung Kwok Ho', 'Dave');

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
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

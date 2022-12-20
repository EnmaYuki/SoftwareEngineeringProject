-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 20, 2022 at 10:33 AM
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
-- Table structure for table `attendance`
--

DROP TABLE IF EXISTS `attendance`;
CREATE TABLE IF NOT EXISTS `attendance` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Date` date NOT NULL,
  `course_name` varchar(255) NOT NULL,
  `Number_of_student` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=142 DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`id`, `Date`, `course_name`, `Number_of_student`) VALUES
(1, '2022-09-13', 'Java', 25),
(2, '2022-09-13', 'Mathetatics', 25),
(3, '2022-09-15', 'Final Year Project', 20),
(4, '2022-09-15', '2D Game Development', 20),
(5, '2022-09-16', 'Ionic', 20),
(6, '2022-09-16', 'Software Engineering', 20),
(7, '2022-09-17', 'Web Development', 25),
(8, '2022-09-17', 'Android Development', 20),
(9, '2022-09-17', 'Networking', 25),
(10, '2022-09-19', 'English tutorial', 25),
(11, '2022-09-20', 'Java', 25),
(12, '2022-09-20', 'Mathetatics', 25),
(13, '2022-09-22', 'Final Year Project', 20),
(14, '2022-09-22', '2D Game Development', 20),
(15, '2022-09-23', 'Ionic', 20),
(16, '2022-09-23', 'Software Engineering', 20),
(17, '2022-09-24', 'Web Development', 25),
(18, '2022-09-24', 'Android Development', 20),
(19, '2022-09-24', 'Networking', 25),
(20, '2022-09-26', 'English tutorial', 25),
(21, '2022-09-27', 'Java', 25),
(22, '2022-09-27', 'Mathetatics', 25),
(23, '2022-09-29', 'Final Year Project', 20),
(24, '2022-09-29', '2D Game Development', 20),
(25, '2022-09-30', 'Ionic', 20),
(26, '2022-09-30', 'Software Engineering', 20),
(27, '2022-10-03', 'English tutorial', 25),
(28, '2022-10-04', 'Java', 25),
(29, '2022-10-04', 'Mathetatics', 25),
(30, '2022-10-06', 'Final Year Project', 20),
(31, '2022-10-06', '2D Game Development', 20),
(32, '2022-10-07', 'Ionic', 20),
(33, '2022-10-07', 'Software Engineering', 20),
(34, '2022-10-08', 'Web Development', 25),
(35, '2022-10-08', 'Android Development', 20),
(36, '2022-10-08', 'Networking', 25),
(37, '2022-10-10', 'English tutorial', 25),
(38, '2022-10-11', 'Java', 25),
(39, '2022-10-11', 'Mathetatics', 25),
(40, '2022-10-13', 'Final Year Project', 20),
(41, '2022-10-13', '2D Game Development', 20),
(42, '2022-10-14', 'Ionic', 20),
(43, '2022-10-14', 'Software Engineering', 20),
(44, '2022-10-15', 'Web Development', 25),
(45, '2022-10-15', 'Android Development', 20),
(46, '2022-10-15', 'Networking', 25),
(47, '2022-10-17', 'English tutorial', 25),
(48, '2022-10-18', 'Java', 25),
(49, '2022-10-18', 'Mathetatics', 25),
(50, '2022-10-20', 'Final Year Project', 20),
(51, '2022-10-20', '2D Game Development', 20),
(52, '2022-10-21', 'Ionic', 20),
(53, '2022-10-21', 'Software Engineering', 20),
(54, '2022-10-22', 'Web Development', 25),
(55, '2022-10-22', 'Android Development', 20),
(56, '2022-10-22', 'Networking', 25),
(57, '2022-10-24', 'English tutorial', 25),
(58, '2022-10-25', 'Java', 25),
(59, '2022-10-25', 'Mathetatics', 25),
(60, '2022-10-27', 'Final Year Project', 20),
(61, '2022-10-27', '2D Game Development', 20),
(62, '2022-10-28', 'Ionic', 20),
(63, '2022-10-28', 'Software Engineering', 20),
(64, '2022-10-29', 'Web Development', 25),
(65, '2022-10-29', 'Android Development', 20),
(66, '2022-10-29', 'Networking', 25),
(67, '2022-10-31', 'English tutorial', 25),
(68, '2022-11-01', 'Java', 25),
(69, '2022-11-01', 'Mathetatics', 25),
(70, '2022-11-03', 'Final Year Project', 20),
(71, '2022-11-03', '2D Game Development', 20),
(72, '2022-11-04', 'Ionic', 20),
(73, '2022-11-04', 'Software Engineering', 20),
(74, '2022-11-05', 'Web Development', 25),
(75, '2022-11-05', 'Android Development', 20),
(76, '2022-11-05', 'Networking', 25),
(77, '2022-11-07', 'English tutorial', 25),
(78, '2022-11-08', 'Java', 25),
(79, '2022-11-08', 'Mathetatics', 25),
(80, '2022-11-10', 'Final Year Project', 20),
(81, '2022-11-10', '2D Game Development', 20),
(82, '2022-11-11', 'Ionic', 20),
(83, '2022-11-11', 'Software Engineering', 20),
(84, '2022-11-12', 'Web Development', 25),
(85, '2022-11-12', 'Android Development', 20),
(86, '2022-11-12', 'Networking', 25),
(87, '2022-11-14', 'English tutorial', 25),
(88, '2022-11-15', 'Java', 25),
(89, '2022-11-15', 'Mathetatics', 25),
(90, '2022-11-17', 'Final Year Project', 20),
(91, '2022-11-17', '2D Game Development', 20),
(92, '2022-11-18', 'Ionic', 20),
(93, '2022-11-18', 'Software Engineering', 20),
(94, '2022-11-19', 'Web Development', 25),
(95, '2022-11-19', 'Android Development', 20),
(96, '2022-11-19', 'Networking', 25),
(97, '2022-11-21', 'English tutorial', 25),
(98, '2022-11-22', 'Java', 25),
(99, '2022-11-22', 'Mathetatics', 25),
(100, '2022-11-24', 'Final Year Project', 20),
(101, '2022-11-24', '2D Game Development', 20),
(102, '2022-11-25', 'Ionic', 20),
(103, '2022-11-25', 'Software Engineering', 20),
(104, '2022-11-26', 'Web Development', 25),
(105, '2022-11-26', 'Android Development', 20),
(106, '2022-11-26', 'Networking', 25),
(107, '2022-11-28', 'English tutorial', 25),
(108, '2022-11-29', 'Java', 25),
(109, '2022-11-29', 'Mathetatics', 25),
(110, '2022-12-01', 'Final Year Project', 20),
(111, '2022-12-01', '2D Game Development', 20),
(112, '2022-12-02', 'Ionic', 20),
(113, '2022-12-02', 'Software Engineering', 20),
(114, '2022-12-03', 'Web Development', 25),
(115, '2022-12-03', 'Android Development', 20),
(116, '2022-12-03', 'Networking', 25),
(117, '2022-12-12', 'English tutorial', 25),
(118, '2022-12-13', 'Java', 25),
(119, '2022-12-13', 'Mathetatics', 25);

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
) ENGINE=MyISAM AUTO_INCREMENT=289 DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `testjson`
--

INSERT INTO `testjson` (`id`, `student`, `time`, `CourseId`) VALUES
(1, 's201', '2022-12-18 14:33:42', '2'),
(2, 's202', '2022-12-18 10:34:48', '2'),
(3, 's203', '2022-12-18 11:52:16', '2'),
(4, 's204', '2022-12-18 15:51:31', '2'),
(5, 's205', '2022-12-18 12:34:48', '2'),
(6, 's206', '2022-12-18 14:23:48', '2'),
(7, 's207', '2022-12-18 14:23:48', '2'),
(8, 's208', '2022-12-18 14:33:55', '2'),
(249, 's202', '2022-12-19 14:33:42', '2'),
(250, 's201', '2022-12-19 10:34:48', '2'),
(251, 's203', '2022-12-19 11:52:16', '2'),
(252, 's205', '2022-12-19 15:51:31', '2'),
(253, 's204', '2022-12-19 12:34:48', '2'),
(255, 's207', '2022-12-19 14:23:48', '2'),
(256, 's208', '2022-12-19 14:33:55', '2'),
(257, 's201', '2022-12-20 14:33:42', '2'),
(258, 's202', '2022-12-20 11:34:48', '2'),
(259, 's203', '2022-12-20 11:52:16', '2'),
(261, 's205', '2022-12-20 12:34:48', '2'),
(262, 's206', '2022-12-20 14:23:48', '2'),
(263, 's207', '2022-12-20 14:23:48', '2'),
(264, 's208', '2022-12-20 14:33:55', '2'),
(265, 's201', '2022-12-21 14:33:42', '2'),
(266, 's202', '2022-12-21 14:50:39', '2'),
(267, 's203', '2022-12-21 11:52:16', '2'),
(268, 's204', '2022-12-21 15:51:31', '2'),
(269, 's205', '2022-12-21 12:34:48', '2'),
(270, 's206', '2022-12-21 14:23:48', '2'),
(271, 's207', '2022-12-21 14:23:48', '2'),
(272, 's208', '2022-12-21 14:33:55', '2'),
(273, 's202', '2022-12-22 14:33:42', '2'),
(274, 's201', '2022-12-22 10:34:48', '2'),
(275, 's203', '2022-12-22 11:52:16', '2'),
(276, 's205', '2022-12-22 15:51:31', '2'),
(277, 's204', '2022-12-22 12:34:48', '2'),
(278, 's206', '2022-12-22 14:23:48', '2'),
(279, 's207', '2022-12-22 14:23:48', '2'),
(280, 's208', '2022-12-22 14:33:55', '2'),
(281, 's201', '2022-12-23 14:33:42', '2'),
(282, 's202', '2022-12-23 11:34:48', '2'),
(283, 's203', '2022-12-23 11:52:16', '2'),
(284, 's204', '2022-12-23 12:51:31', '2'),
(285, 's205', '2022-12-23 12:34:48', '2'),
(286, 's206', '2022-12-23 14:23:48', '2'),
(287, 's207', '2022-12-23 14:23:48', '2'),
(288, 's208', '2022-12-23 14:33:55', '2');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

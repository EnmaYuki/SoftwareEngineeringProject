-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 15, 2022 at 02:44 PM
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
DROP DATABASE IF EXISTS `softwareengineera2`;
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
) ENGINE=MyISAM AUTO_INCREMENT=142 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
-- Table structure for table `daytable`
--

DROP TABLE IF EXISTS `daytable`;
CREATE TABLE IF NOT EXISTS `daytable` (
  `WeekDay_ID` int NOT NULL AUTO_INCREMENT,
  `Day_Name` varchar(10) NOT NULL,
  PRIMARY KEY (`WeekDay_ID`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `daytable`
--

INSERT INTO `daytable` (`WeekDay_ID`, `Day_Name`) VALUES
(1, 'Monday'),
(2, 'Tuesday'),
(3, 'Wednesday'),
(4, 'Thursday'),
(5, 'Friday'),
(6, 'Saturday'),
(7, 'Sunday');

-- --------------------------------------------------------

--
-- Table structure for table `studentinfo`
--

DROP TABLE IF EXISTS `studentinfo`;
CREATE TABLE IF NOT EXISTS `studentinfo` (
  `student_id` varchar(10) NOT NULL,
  `Student_Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Year` int NOT NULL,
  PRIMARY KEY (`student_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `studentinfo`
--

INSERT INTO `studentinfo` (`student_id`, `Student_Name`, `Year`) VALUES
('sn22710143', 'Chan Tai Ming', 1),
('sn19910144', 'Fung Ming Tai', 1),
('sn20201189', 'Yuen Lok Ming', 1),
('sn21899387', 'Lo Dong Lok', 1),
('sn19342046', 'Lam Doe Jong', 1),
('sn23769351', 'So Yan Ying', 1),
('sn22465786', 'Ye Tsz Tsz', 1),
('sn19810143', 'Cheuk Fung Yuk', 2),
('sn21540473', 'Kwok Yiu Man', 2),
('sn20807626', 'Lai Joe Wing', 2),
('sn21537561', 'Lam Yin Ying Elayne', 2),
('sn21536159', 'Lau Wing Yan', 2),
('sn20574118', 'Lee Hiu Ling', 2),
('sn20812542', 'Lee Hiu Ling', 2),
('sn20575893', 'Leung Fat Leung', 2),
('sn20816825', 'Luqman Hamza', 2),
('sn21539989', 'Mak Ka Yan', 2),
('sn20813128', 'Ng Chi Ho', 1),
('sn20819514', 'Ng Ka Ho', 2),
('sn11075836', 'Ng Yik Lok', 2),
('sn21562477', 'Sin Ho Yeung', 2),
('sn21544318', 'So Man Ching', 2),
('sn20820040', 'To Tsz Yeung', 2),
('sn20814209', 'Wang Dong Yang', 2),
('sn21530648', 'Wang Ho Nin', 1),
('sn21544376', 'Wong Lok Tin', 1),
('sn21561403', 'Wong Sau Hang', 2),
('sn20819481', 'Yan Wai Kwok', 2),
('sn20812641', 'Ye Ping', 2),
('sn20811495', 'Yuen Chi Ming', 2),
('sn23568397', 'Lee Ming Ming', 1),
('sn24393451', 'Mok Ka Yi', 1),
('sn19548123', 'Mui Mei Kwun', 1),
('sn21563892', 'Cheung Ming Lok', 1),
('sn21563920', 'Bai Tin Ming', 1),
('sn22329501', 'Wong Yat Hei', 1),
('sn21497021', 'Ng Cheung Yat', 1),
('sn22092965', 'Lee Ming Shun', 1),
('sn23504739', 'Yong Tsz Tang', 1),
('sn22568740', 'Tang Tsz Heng', 1),
('sn21894574', 'Ho Yu Tin', 1),
('sn20566982', 'Kwan Tin Sau', 1),
('sn20665453', 'Wong Yau San', 1);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
CREATE TABLE IF NOT EXISTS `subject` (
  `id` int NOT NULL AUTO_INCREMENT,
  `SchoolYear` int NOT NULL,
  `course_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `venue` varchar(6) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Weekdays` int NOT NULL,
  `start_time` time NOT NULL,
  `class size` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`id`, `SchoolYear`, `course_name`, `venue`, `Weekdays`, `start_time`, `class size`) VALUES
(1, 2, 'Final Year Project', 'MUC508', 4, '10:30:00', 20),
(2, 2, 'Ionic', 'MUC508', 5, '10:00:00', 20),
(3, 2, '2D Game Development', 'MUC305', 4, '14:30:00', 20),
(4, 1, '3D Game Development', 'MUC508', 4, '10:00:00', 25),
(5, 1, 'Networking', 'MUC508', 6, '14:00:00', 25),
(6, 1, 'Web Development', 'MUC508', 6, '10:00:00', 25),
(7, 1, 'Java', 'MUC508', 2, '10:00:00', 25),
(8, 1, 'OOAD', 'MUC508', 3, '14:00:00', 25),
(9, 1, 'Database', 'MUC508', 3, '10:00:00', 25),
(10, 2, 'Android Development', 'MUC305', 6, '14:00:00', 20),
(11, 2, 'IOS Development', 'MUC209', 5, '14:30:00', 20),
(12, 2, 'Python', 'MUC505', 6, '10:00:00', 20),
(13, 2, 'Software Engineering', 'MUC305', 5, '13:30:00', 20),
(14, 1, 'Mathetatics', 'MUC202', 2, '14:30:00', 25),
(15, 1, 'English tutorial', 'MUC103', 1, '14:00:00', 25),
(18, 2, 'English tutorial', 'MUC202', 3, '10:00:00', 20);

-- --------------------------------------------------------

--
-- Table structure for table `teacherinfo`
--

DROP TABLE IF EXISTS `teacherinfo`;
CREATE TABLE IF NOT EXISTS `teacherinfo` (
  `teacher_id` varchar(8) NOT NULL,
  `Teacher_Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Greeting` varchar(255) NOT NULL,
  PRIMARY KEY (`teacher_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
  `weekday` int NOT NULL,
  `time` timestamp NOT NULL,
  `Venue` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

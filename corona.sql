-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 27, 2021 at 05:25 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `corona`
--

-- --------------------------------------------------------

--
-- Table structure for table `doctor`
--

CREATE TABLE `doctor` (
  `D_id` int(11) NOT NULL,
  `D_dept` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `hospital`
--

CREATE TABLE `hospital` (
  `H_id` int(11) NOT NULL,
  `H_name` varchar(30) NOT NULL,
  `H_pwd` varchar(200) DEFAULT NULL,
  `H_contactno` decimal(30,0) DEFAULT NULL,
  `H_type` char(1) NOT NULL,
  `H_address` decimal(6,0) NOT NULL,
  `H_email` varchar(30) DEFAULT NULL,
  `H_vac` varchar(20) DEFAULT NULL,
  `quant_rem` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `hospital`
--

INSERT INTO `hospital` (`H_id`, `H_name`, `H_pwd`, `H_contactno`, `H_type`, `H_address`, `H_email`, `H_vac`, `quant_rem`) VALUES
(1, '7поликлиника', 'renat3004', '79872860274', 'G', '420000', '7@gmail.com', 'Спутник-5', 30),
(2, '9Поликлиника', 'renat3004', '79869151445', 'G', '420000', '9@gmail.com', 'Спутник-5', 6),
(4, 'Центральная', '342515', '75757757', 'G', '101000', 'centr@gmail.com', 'Спутник-5', 8);

-- --------------------------------------------------------

--
-- Stand-in structure for view `hosp_data`
-- (See below for the actual view)
--
CREATE TABLE `hosp_data` (
`H_id` int(11)
,`H_name` varchar(30)
,`H_contactno` decimal(30,0)
,`H_type` char(1)
,`H_address` decimal(6,0)
,`H_email` varchar(30)
,`H_vac` varchar(20)
);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `I_id` int(11) NOT NULL,
  `I_name` varchar(20) NOT NULL,
  `I_contactno` decimal(30,0) DEFAULT NULL,
  `I_address` decimal(6,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`I_id`, `I_name`, `I_contactno`, `I_address`) VALUES
(1, 'Склад Апрель', '7789234', '420000'),
(2, 'Отличный Склад', '8056379', '101000'),
(3, 'Склад Сеть', '5882310', '620000'),
(4, 'Большой склад', '8909090', '420000'),
(5, 'центральный', '232322232', '101000');

-- --------------------------------------------------------

--
-- Table structure for table `location`
--

CREATE TABLE `location` (
  `pincode` decimal(6,0) NOT NULL,
  `city` varchar(20) NOT NULL,
  `state` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `location`
--

INSERT INTO `location` (`pincode`, `city`, `state`) VALUES
('101000', 'Москва', 'Москва'),
('190000', 'Санкт-Петербург', 'Санкт-Петербург'),
('364000', 'Грозный', 'Чечня'),
('420000', 'Казань', 'Татарстан'),
('620000', 'Екатеринбург', 'Сверловская область'),
('630000', 'Новосибирск', 'Новосибирская обл-ть');

-- --------------------------------------------------------

--
-- Table structure for table `person`
--

CREATE TABLE `person` (
  `P_id` int(11) NOT NULL,
  `P_name` varchar(30) NOT NULL,
  `P_Gender` char(20) NOT NULL,
  `P_DOB` date DEFAULT NULL,
  `P_contactno` decimal(30,0) DEFAULT NULL,
  `P_address` decimal(6,0) DEFAULT NULL,
  `P_email` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `person`
--

INSERT INTO `person` (`P_id`, `P_name`, `P_Gender`, `P_DOB`, `P_contactno`, `P_address`, `P_email`) VALUES
(1, 'ren', 'Male', '2021-12-23', '342515', '420000', 'ren@gmail.com'),
(2, 'ren', 'Male', '2021-12-23', '342515', '420000', 'renat'),
(3, 'ren', 'Male', '2021-12-23', '2323232', '420000', 'ren'),
(4, 'renat', 'Male', '2021-12-23', '342551', '420000', 'r'),
(5, 'rerww', 'Male', '2021-12-23', '345678', '420000', 'reerrerwrw'),
(6, 'wffddg', 'Male', '2021-12-23', '43433534', '101000', 'dgdggd'),
(7, 'efwfgsg', 'Male', '2021-12-23', '344343', '420000', 'gsggg'),
(8, 'пвпвпв', 'Male', '2021-12-23', '343434343', '420000', 'gess'),
(9, 'Renat', 'Male', '2021-12-23', '79872860274', '420000', 'galifanov.renat@gmail.com'),
(10, 'Bubu', 'Male', '2021-12-24', '798733773', '101000', 'gaggagqa'),
(11, 'Anton', 'Male', '2021-12-24', '88181881', '420000', 'anton@gmail.com'),
(12, 'Ренат', 'Male', '2021-12-24', '79872860274', '420000', 'galifanov.renat@gmail.com'),
(13, 'Renat', 'Male', '2021-12-24', '798728690274', '420000', 'gamil'),
(14, 'Renat', 'Male', '2021-12-25', '79872860274', '420000', 'galifanov.renat@gmail.com'),
(15, 'Renat', 'Male', '2021-12-25', '4444', '420000', 'ddff'),
(16, 'djdsjds', 'Male', '2021-12-25', '4243424', '420000', 'shdsh'),
(17, 'ddsfs', 'Male', '2021-12-25', '76555', '420000', 'ffffssf'),
(18, 'dvvxvxvx', 'Male', '2021-12-25', '474773', '420000', 'svvvs'),
(19, 'sdds', 'Male', '2021-12-25', '34252', '420000', 'sfsf'),
(20, 'Renat', 'Male', '2021-12-25', '7588584', '420000', 'galifanov.renat@gmail.com'),
(21, 'renat', 'Male', '2021-12-25', '798765432', '420000', 'galifanov.renat@gmail.com'),
(22, 'jjjdjd', 'Male', '2021-12-25', '42224244', '420000', 'sflsls,s'),
(23, 'Ренат', 'Male', '1998-04-30', '79869151445', '101000', 'galifanov.renat@gmail.com'),
(24, 'Ренат', 'Male', '2021-12-03', '79869151445', '101000', 'galifanov.renat@gmail.com'),
(25, 'Her', 'Male', '2021-12-27', '363636', '420000', 'her@gmail.com'),
(26, 'ger', 'Male', '2021-12-27', '33663', '101000', 'ger@gmail.com'),
(27, 'ds', 'Male', '2021-12-27', '4242', '101000', 'dwwd'),
(31, 'sds', 'Male', '2021-12-27', '31313', '420000', 'dadda'),
(32, 'dadda', 'Male', '2021-12-27', '44242442', '101000', 'dadad'),
(33, 'rere', 'Male', '2021-12-27', '433424223', '420000', 'hdsjsd'),
(34, 'djdjda', 'Male', '2021-12-27', '133133', '420000', 'daaddad'),
(35, 'dhahd', 'Male', '2021-12-27', '13232', '420000', 'faff'),
(36, 'fbsffjfs', 'Male', '2021-12-27', '444232', '420000', 'dladljkad'),
(37, 'ffsf', 'Male', '2021-12-27', '24242', '101000', 'ffs'),
(38, 'hfhff', 'Male', '2021-12-27', '313131', '101000', 'faffaa'),
(39, 'asdaad', 'Male', '2021-12-27', '4647373', '101000', 'adada'),
(40, 'аыааы', 'Male', '2021-12-27', '4242', '101000', 'ыааыы'),
(41, 'сясся', 'Male', '2021-12-27', '31313131', '101000', 'ясяяс');

-- --------------------------------------------------------

--
-- Table structure for table `supplies`
--

CREATE TABLE `supplies` (
  `S_id` int(11) NOT NULL,
  `S_hospital` int(11) DEFAULT NULL,
  `S_inventory` int(11) DEFAULT NULL,
  `S_quantity` decimal(10,0) DEFAULT NULL,
  `S_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `supplies`
--

INSERT INTO `supplies` (`S_id`, `S_hospital`, `S_inventory`, `S_quantity`, `S_time`) VALUES
(44, 1, 1, '2', '2021-12-24 08:41:12'),
(45, 1, 3, '10', '2021-12-24 08:41:31'),
(46, 1, 4, '2', '2021-12-24 08:45:51'),
(47, 1, 1, '5', '2021-12-24 09:18:35'),
(48, 1, 3, '6', '2021-12-24 09:18:59'),
(49, 1, 2, '5', '2021-12-24 09:19:15'),
(50, 1, 3, '5', '2021-12-24 09:21:30'),
(51, 2, 1, '10', '2021-12-25 04:46:17'),
(52, 4, 3, '10', '2021-12-25 07:11:20');

--
-- Triggers `supplies`
--
DELIMITER $$
CREATE TRIGGER `trig1` AFTER INSERT ON `supplies` FOR EACH ROW update hospital set quant_rem = quant_rem + new.s_quantity where h_id = new.s_hospital
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `vaccinates`
--

CREATE TABLE `vaccinates` (
  `P` int(11) NOT NULL,
  `Hosp` int(11) NOT NULL,
  `Date_first` date DEFAULT NULL,
  `Date_second` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `vaccinates`
--

INSERT INTO `vaccinates` (`P`, `Hosp`, `Date_first`, `Date_second`) VALUES
(16, 1, '2021-12-25', '2021-12-25'),
(17, 1, '2021-12-31', '2022-01-06'),
(18, 1, '2022-01-20', '2022-02-24'),
(19, 1, '2021-12-25', '2021-12-25'),
(20, 1, '2022-01-20', '2022-02-23'),
(21, 2, '2022-01-25', '2021-02-25'),
(22, 2, '2022-02-16', '2021-03-16'),
(24, 4, '2021-12-30', '2022-01-31');

--
-- Triggers `vaccinates`
--
DELIMITER $$
CREATE TRIGGER `trig2` AFTER UPDATE ON `vaccinates` FOR EACH ROW BEGIN IF old.Date_second is null && old.Date_first is null && new.Date_second is not null && new.Date_first is not null THEN update hospital set quant_rem = quant_rem - 2 where h_id = new.hosp; end IF;  END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `vaccine`
--

CREATE TABLE `vaccine` (
  `V_name` varchar(20) NOT NULL,
  `V_company` varchar(20) NOT NULL,
  `V_cost` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `vaccine`
--

INSERT INTO `vaccine` (`V_name`, `V_company`, `V_cost`) VALUES
('КовиВак', 'Chumakov\'s center', 3500),
('Спутник-5', 'Gamaley\'s center', 3000);

-- --------------------------------------------------------

--
-- Structure for view `hosp_data`
--
DROP TABLE IF EXISTS `hosp_data`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `hosp_data`  AS SELECT `hospital`.`H_id` AS `H_id`, `hospital`.`H_name` AS `H_name`, `hospital`.`H_contactno` AS `H_contactno`, `hospital`.`H_type` AS `H_type`, `hospital`.`H_address` AS `H_address`, `hospital`.`H_email` AS `H_email`, `hospital`.`H_vac` AS `H_vac` FROM `hospital` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `doctor`
--
ALTER TABLE `doctor`
  ADD PRIMARY KEY (`D_id`);

--
-- Indexes for table `hospital`
--
ALTER TABLE `hospital`
  ADD PRIMARY KEY (`H_id`),
  ADD KEY `H_address` (`H_address`),
  ADD KEY `H_vac` (`H_vac`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`I_id`),
  ADD KEY `I_address` (`I_address`);

--
-- Indexes for table `location`
--
ALTER TABLE `location`
  ADD PRIMARY KEY (`pincode`);

--
-- Indexes for table `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`P_id`),
  ADD KEY `P_address` (`P_address`);

--
-- Indexes for table `supplies`
--
ALTER TABLE `supplies`
  ADD PRIMARY KEY (`S_id`),
  ADD KEY `S_hospital` (`S_hospital`),
  ADD KEY `S_inventory` (`S_inventory`);

--
-- Indexes for table `vaccinates`
--
ALTER TABLE `vaccinates`
  ADD PRIMARY KEY (`P`,`Hosp`),
  ADD KEY `Hosp` (`Hosp`);

--
-- Indexes for table `vaccine`
--
ALTER TABLE `vaccine`
  ADD PRIMARY KEY (`V_name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `hospital`
--
ALTER TABLE `hospital`
  MODIFY `H_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `I_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `person`
--
ALTER TABLE `person`
  MODIFY `P_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `supplies`
--
ALTER TABLE `supplies`
  MODIFY `S_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `doctor`
--
ALTER TABLE `doctor`
  ADD CONSTRAINT `doctor_ibfk_1` FOREIGN KEY (`D_id`) REFERENCES `person` (`P_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `hospital`
--
ALTER TABLE `hospital`
  ADD CONSTRAINT `hospital_ibfk_1` FOREIGN KEY (`H_address`) REFERENCES `location` (`pincode`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `hospital_ibfk_2` FOREIGN KEY (`H_vac`) REFERENCES `vaccine` (`V_name`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`I_address`) REFERENCES `location` (`pincode`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `person`
--
ALTER TABLE `person`
  ADD CONSTRAINT `person_ibfk_1` FOREIGN KEY (`P_address`) REFERENCES `location` (`pincode`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `supplies`
--
ALTER TABLE `supplies`
  ADD CONSTRAINT `supplies_ibfk_1` FOREIGN KEY (`S_hospital`) REFERENCES `hospital` (`H_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplies_ibfk_2` FOREIGN KEY (`S_inventory`) REFERENCES `inventory` (`I_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `vaccinates`
--
ALTER TABLE `vaccinates`
  ADD CONSTRAINT `vaccinates_ibfk_1` FOREIGN KEY (`P`) REFERENCES `person` (`P_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `vaccinates_ibfk_2` FOREIGN KEY (`Hosp`) REFERENCES `hospital` (`H_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

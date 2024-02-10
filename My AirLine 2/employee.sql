-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 10, 2024 at 04:45 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `employee`
--

-- --------------------------------------------------------

--
-- Table structure for table `aemployee`
--

CREATE TABLE `aemployee` (
  `ID` int(255) NOT NULL,
  `txtEmployeename` varchar(1000) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `Age` varchar(1000) NOT NULL,
  `City` varchar(100) NOT NULL,
  `Address` varchar(1000) NOT NULL,
  `JoinDate` varchar(1000) NOT NULL,
  `Work` varchar(1000) NOT NULL,
  `MobileNumber` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `bemployee`
--

CREATE TABLE `bemployee` (
  `ID` int(11) NOT NULL,
  `txtEmployeename` varchar(1000) NOT NULL,
  `Gender` varchar(1000) NOT NULL,
  `Age` varchar(1000) NOT NULL,
  `City` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `JoinDate` varchar(100) NOT NULL,
  `Work` varchar(100) NOT NULL,
  `MobileNumber` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bemployee`
--

INSERT INTO `bemployee` (`ID`, `txtEmployeename`, `Gender`, `Age`, `City`, `Address`, `JoinDate`, `Work`, `MobileNumber`) VALUES
(1, 'Mukul', 'Male', '29', 'Dom', '', '16-Mar-23 12:00:00 AM', 'Controller', 0),
(3, 'Tanay', 'Female', '13', 'dom', '', '20-Mar-23 12:00:00 AM', 'Condutor', 2147483647);

-- --------------------------------------------------------

--
-- Table structure for table `remployee`
--

CREATE TABLE `remployee` (
  `ID` int(255) NOT NULL,
  `txtEmployeename` varchar(255) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `Age` int(100) NOT NULL,
  `City` varchar(100) NOT NULL,
  `Address` varchar(1000) NOT NULL,
  `JoinDate` varchar(100) NOT NULL,
  `Work` varchar(100) NOT NULL,
  `MobileNumber` int(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `remployee`
--

INSERT INTO `remployee` (`ID`, `txtEmployeename`, `Gender`, `Age`, `City`, `Address`, `JoinDate`, `Work`, `MobileNumber`) VALUES
(2, 'Ruta', 'Female', 5, 'fsdfd', 'sdfsdfsdrf', '17-Mar-23 12:00:00 AM', 'Moterman', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `aemployee`
--
ALTER TABLE `aemployee`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bemployee`
--
ALTER TABLE `bemployee`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `remployee`
--
ALTER TABLE `remployee`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `aemployee`
--
ALTER TABLE `aemployee`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `bemployee`
--
ALTER TABLE `bemployee`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `remployee`
--
ALTER TABLE `remployee`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

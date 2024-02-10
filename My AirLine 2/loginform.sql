-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 10, 2024 at 04:46 AM
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
-- Database: `loginform`
--

-- --------------------------------------------------------

--
-- Table structure for table `acompanyinfo`
--

CREATE TABLE `acompanyinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Street Name` varchar(1000) NOT NULL,
  `Lane Name` varchar(1000) NOT NULL,
  `Postal Code` varchar(1000) NOT NULL,
  `City` varchar(100) NOT NULL,
  `State` varchar(100) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `acompanyinfo`
--

INSERT INTO `acompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `Street Name`, `Lane Name`, `Postal Code`, `City`, `State`, `LastLogin`) VALUES
(1, 'Mahesh', 'Vistara', 'Vistara@gmail.com', '7778882220', '', '', '', '', '', '15-Dec-22 5:59:56 PM'),
(2, 'Tanay', 'Tanay', 'Tanay@gmail.com', '1234567890', '', '', '', '', '', '25-Dec-22 6:05:48 PM'),
(3, 'Swati', 'BlueBird', 'BlueBird@gmail.com', '9876543201', '', '', '', '', '', ''),
(4, 'Nilesh', 'Nilkamal', 'Nilkamal@gmail.com', '0112233114', 'near nilkamal socity', 'lane 2, thakurwadi', 'Mumbai', '421202 dombivli', 'Maharashtra	', '18-Mar-23 10:40:20 AM');

-- --------------------------------------------------------

--
-- Table structure for table `bcompanyinfo`
--

CREATE TABLE `bcompanyinfo` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` int(10) NOT NULL,
  `Street Name` varchar(1000) NOT NULL,
  `Lane Name` varchar(1000) NOT NULL,
  `Postal Code` varchar(1000) NOT NULL,
  `City` varchar(100) NOT NULL,
  `State` varchar(100) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bcompanyinfo`
--

INSERT INTO `bcompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `Street Name`, `Lane Name`, `Postal Code`, `City`, `State`, `LastLogin`) VALUES
(1, 'MSRTC', 'MSRTC', 'MSRTC@gmail.com', 2147483647, '', '', '', '', '', '18-Dec-22 12:19:09 PM'),
(2, 'Tanay Puranik', 'Ruta Ltd', 'Ruta@gmail.com', 1234509875, '', '', '', '', '', ''),
(3, 'Mukul', 'Scoda', 'Scoda@gmail.com', 1234567899, 'janpath nager', 'New Delhi', 'Delhi', '421102 New Delhi', 'Delhi	', '19-Mar-23 12:14:25 PM');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`ID`, `Name`, `Gender`, `Email`, `Password`, `LastLogin`) VALUES
(1, 'Tanay', 'Male', 'tanay.puranik2002@gmail.com', 'Tanay', '13-Mar-23 5:56:25 PM'),
(2, 'vinay', 'Male', 'vinay@gmail.com', '12345', '26-Jan-23 10:42:47 AM'),
(3, 'VSK', 'Other', 'vsk@gmail.com', '123456', '19-Mar-23 12:16:42 PM');

-- --------------------------------------------------------

--
-- Table structure for table `gcompanyinfo`
--

CREATE TABLE `gcompanyinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` int(10) NOT NULL,
  `Street Name` varchar(1000) NOT NULL,
  `Lane Name` varchar(1000) NOT NULL,
  `Postal Code` varchar(1000) NOT NULL,
  `City` varchar(100) NOT NULL,
  `State` varchar(100) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `gcompanyinfo`
--

INSERT INTO `gcompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `Street Name`, `Lane Name`, `Postal Code`, `City`, `State`, `LastLogin`) VALUES
(1, 'JCB', 'JCB', 'JCB@gmail.com', 1234598760, '', '', '', '', '', '17-Jan-23 9:52:39 AM'),
(2, 'Swati', 'Priya Private Ltd', 'Priya@gmail.com', 2147483647, '', '', '', '', '', ''),
(3, 'Tanay', 'JBM Private Ltd', 'JBM@gmail.com', 1234568901, '', '', '', '', '', '26-Jan-23 12:34:56 PM'),
(4, 'GSD', 'SSd', 'GS@gmail.com', 1234567899, 'opposite meal ', 'thakuwadi cross lane', 'Pune', '421202 Dombivli', 'Uttar Pradesh	', ''),
(5, 'Gonda', 'Gonda', 'Gonda@gmail.com', 2147483647, 'home basse', 'home assssdf', 'Merth', '343001 Gonda', 'Odisha	', '18-Mar-23 10:35:04 AM');

-- --------------------------------------------------------

--
-- Table structure for table `rcompanyinfo`
--

CREATE TABLE `rcompanyinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` int(10) NOT NULL,
  `Street Name` varchar(1000) NOT NULL,
  `Lane Name` varchar(1000) NOT NULL,
  `Postal Code` int(6) NOT NULL,
  `City` varchar(100) NOT NULL,
  `State` varchar(100) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rcompanyinfo`
--

INSERT INTO `rcompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `Street Name`, `Lane Name`, `Postal Code`, `City`, `State`, `LastLogin`) VALUES
(1, 'Tanay Puranik', 'TanayP', 'Tanay@gmail.com', 12345789, '', '', 0, '', '', '17-Dec-22 11:20:22 AM'),
(2, 'TanayP', 'Monk', 'Tanay1@gmail.com', 2147483647, '', '', 0, '', '', '15-Dec-22 12:12:28 PM'),
(3, 'TMP', 'TMP', 'TMP@gmail.com', 2147483647, '', '', 0, '', '', '15-Dec-22 11:16:19 AM'),
(4, 'Tan', 'Tan', 'Tan@gmail.com', 2147483647, '', '', 0, '', '', '17-Jan-23 9:49:47 AM'),
(5, 'Swati', 'Swati Pvt Ltd', 'Swati@gmail.com', 1234567890, 'Gupte rode,opposite janta store,dombivli', 'Ramvadi', 421202, 'Dombivli west', 'Maharashtra', ''),
(6, 'Ruta', 'Godavari', 'Godavari@gmail.com', 2147483647, 'Lane18,Binkaner Shop', 'near NMS college', 0, '234001 Bhandup', 'Maharashtra	', '18-Mar-23 10:16:51 AM');

-- --------------------------------------------------------

--
-- Table structure for table `scompanyinfo`
--

CREATE TABLE `scompanyinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` int(10) NOT NULL,
  `Street Name` varchar(1000) NOT NULL,
  `Lane Name` varchar(1000) NOT NULL,
  `Postal Code` varchar(1000) NOT NULL,
  `City` varchar(100) NOT NULL,
  `State` varchar(100) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `scompanyinfo`
--

INSERT INTO `scompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `Street Name`, `Lane Name`, `Postal Code`, `City`, `State`, `LastLogin`) VALUES
(1, 'Tanay', 'Tas', 'Tanay@gmail.com', 123456789, '', '', '', '', '', '15-Dec-22 6:00:30 PM'),
(2, 'Tan', 'Tan', 'Tan@gmail.com', 1234567890, '', '', '', '', '', '23-Dec-22 6:01:46 PM'),
(3, 'Mahesh', 'Maho', 'Maho@gmail.com', 2147483647, 'opps.ganesh nager', '14 lane', 'Nashik', 'nashik 230021', 'Maharashtra	', '18-Mar-23 10:29:55 AM');

-- --------------------------------------------------------

--
-- Table structure for table `userinfo`
--

CREATE TABLE `userinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`ID`, `Name`, `Gender`, `UserName`, `Email`, `Password`, `LastLogin`) VALUES
(1, 'Tanay', 'Male', 'Tanay', 'Tanay@gmail.com', '0', '19-Mar-23 12:12:08 PM'),
(2, 'Tanay1', 'Female', 'Tanay1', 'Tanay1@gmail.com', '0', '18-Dec-22 12:14:54 PM'),
(3, 'Tanay2', 'Male', 'Tanay2', 'Tanay2@gmail.com', 'Tanay2', '15-Dec-22 12:08:34 PM'),
(4, 'Mahesh', 'Male', 'Mahesh', 'Mahesh@gmail.com', 'Mahesh', '20-Dec-22 6:22:56 PM'),
(5, 'Swati', 'Female', 'Swati', 'Swati@gmail.com', 'Swati', ''),
(6, 'vinay', 'Male', 'vinay24', 'vinay@gmail.com', '12345', '26-Jan-23 12:31:38 PM'),
(7, 'Mukul', 'Male', 'M22', 'Mukul@gmail.com', '123456', '18-Mar-23 10:03:26 AM');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `acompanyinfo`
--
ALTER TABLE `acompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bcompanyinfo`
--
ALTER TABLE `bcompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `gcompanyinfo`
--
ALTER TABLE `gcompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `rcompanyinfo`
--
ALTER TABLE `rcompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `scompanyinfo`
--
ALTER TABLE `scompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `userinfo`
--
ALTER TABLE `userinfo`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `acompanyinfo`
--
ALTER TABLE `acompanyinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `bcompanyinfo`
--
ALTER TABLE `bcompanyinfo`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `gcompanyinfo`
--
ALTER TABLE `gcompanyinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `rcompanyinfo`
--
ALTER TABLE `rcompanyinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `scompanyinfo`
--
ALTER TABLE `scompanyinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

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
-- Database: `transportadd`
--

-- --------------------------------------------------------

--
-- Table structure for table `busadd`
--

CREATE TABLE `busadd` (
  `ID` int(100) NOT NULL,
  `BusNumber` varchar(100) NOT NULL,
  `BusType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `SHour` int(100) NOT NULL,
  `SMinute` int(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `DHour` int(100) NOT NULL,
  `DMinute` int(100) NOT NULL,
  `BusHalt` varchar(255) NOT NULL,
  `NoOfDaysRunning` varchar(50) NOT NULL,
  `BusLunchDate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `busadd`
--

INSERT INTO `busadd` (`ID`, `BusNumber`, `BusType`, `Source`, `SHour`, `SMinute`, `Destination`, `DHour`, `DMinute`, `BusHalt`, `NoOfDaysRunning`, `BusLunchDate`) VALUES
(3, 'GJ10AM1010', '3x2 Seater', 'Varanasi', 21, 25, 'Nagpur', 18, 24, '', 'Monday Thursday', '14-Mar-23 12:00:00 AM'),
(4, 'DL25AZ2023', '2x2 Seater', 'Delhi', 23, 23, 'Varanasi', 5, 24, 'Old Delhi,Janpath,Agra,Agra Cant', 'Tuesday Thursday saturday', '18-Mar-23 12:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `flightadd`
--

CREATE TABLE `flightadd` (
  `ID` int(100) NOT NULL,
  `FlightNumber` varchar(100) NOT NULL,
  `AircraftType` varchar(100) NOT NULL,
  `FlightType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `SHour` int(100) NOT NULL,
  `SMinute` int(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `DHour` int(100) NOT NULL,
  `DMinute` int(100) NOT NULL,
  `NoDaysFlying` varchar(50) NOT NULL,
  `FlightLaunchDate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `flightadd`
--

INSERT INTO `flightadd` (`ID`, `FlightNumber`, `AircraftType`, `FlightType`, `Source`, `SHour`, `SMinute`, `Destination`, `DHour`, `DMinute`, `NoDaysFlying`, `FlightLaunchDate`) VALUES
(2, 'SW-01', 'Jets', 'Regional', 'Chhatrapati Shivaji International Airport – BOM	Mumbai, Maharashtra', 9, 20, 'Vadodara Airport	Gujarat', 12, 28, '', '31-Dec-22 12:00:00 AM'),
(3, 'A12488', 'Jets', 'Passenger', 'Chaudhary Charan Singh International Airport – LKO 	Lucknow, Uttar Pradesh', 1, 22, 'Netaji Subhas Chandra Bose International Airport – CCU	Kolkata, West Bengal', 24, 24, 'Wednesday', '01-Mar-23 12:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `goodsadd`
--

CREATE TABLE `goodsadd` (
  `ID` int(100) NOT NULL,
  `VehicleNumber` varchar(100) NOT NULL,
  `VehicleType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `StateSource` varchar(100) NOT NULL,
  `StateDestination` varchar(100) NOT NULL,
  `VehicleRollOutDate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `goodsadd`
--

INSERT INTO `goodsadd` (`ID`, `VehicleNumber`, `VehicleType`, `Source`, `Destination`, `StateSource`, `StateDestination`, `VehicleRollOutDate`) VALUES
(1, 'MH01AA0001', 'Mail Truck', 'ff', 'sd', 'Mizoram', 'Punjab', '22-Dec-22 12:00:00 AM'),
(3, 'MH04AB1222', 'Tanker Truck', 'Kamothe', 'JLPT', 'Madhya Pradesh', 'Maharashtra', '17-Jan-23 12:00:00 AM'),
(4, 'MH14AZ1122', 'Mail Truck', 'Tarapur', 'Bhivpuri', 'Maharashtra', 'Maharashtra', '28-Jan-23 12:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `shipadd`
--

CREATE TABLE `shipadd` (
  `ID` int(100) NOT NULL,
  `ShipNumber` varchar(100) NOT NULL,
  `ShipType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `ShipLaunchDate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `shipadd`
--

INSERT INTO `shipadd` (`ID`, `ShipNumber`, `ShipType`, `Source`, `Destination`, `ShipLaunchDate`) VALUES
(1, 'AZ1516', 'Container', 'Mumbai,Maharashtra', 'Kochi,Kerala', '0000-00-00'),
(2, 'AA1234', 'Bulk Carrier', 'Tuticorin,Tamil Nadu', 'Mo’orea, French Polynesia', '28-Dec-22 12:00:00 AM'),
(3, 'AZ01', 'Bulk Carrier', 'Kolkata,West Bengal', 'Tuticorin,Tamil Nadu', '18-Mar-23 12:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `trainadd`
--

CREATE TABLE `trainadd` (
  `ID` int(100) NOT NULL,
  `TrainNumberAndName` varchar(100) NOT NULL,
  `TrainType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `SHour` int(100) NOT NULL,
  `SMinute` int(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `DHour` int(100) NOT NULL,
  `DMinute` int(100) NOT NULL,
  `NoOfCoches` int(255) NOT NULL,
  `HaltStation` varchar(1000) NOT NULL,
  `TrainLaunchDate` varchar(100) NOT NULL,
  `NoOfDaysRunning` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `trainadd`
--

INSERT INTO `trainadd` (`ID`, `TrainNumberAndName`, `TrainType`, `Source`, `SHour`, `SMinute`, `Destination`, `DHour`, `DMinute`, `NoOfCoches`, `HaltStation`, `TrainLaunchDate`, `NoOfDaysRunning`) VALUES
(4, '11227 Pun mumbai deccan queen express', 'Luxury Railway', 'Mumbai', 14, 11, 'Pune', 16, 7, 18, 'Thane,Shivajinager', '11-Jan-23 12:00:00 AM', 'All Days'),
(5, '22222 Pune Mumbai Special', 'Inter-City', 'Delhi', 3, 0, 'Jaipur', 7, 6, 18, '', '13-Mar-23 12:00:00 AM', 'Thursday'),
(6, '12345 Saraighat Express', 'Mountain Railway', 'Merth', 2, 3, 'Agra', 4, 18, 4, '', '14-Mar-23 12:00:00 AM', 'Weekend only');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `busadd`
--
ALTER TABLE `busadd`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `flightadd`
--
ALTER TABLE `flightadd`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `goodsadd`
--
ALTER TABLE `goodsadd`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `shipadd`
--
ALTER TABLE `shipadd`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `trainadd`
--
ALTER TABLE `trainadd`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `busadd`
--
ALTER TABLE `busadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `flightadd`
--
ALTER TABLE `flightadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `goodsadd`
--
ALTER TABLE `goodsadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `shipadd`
--
ALTER TABLE `shipadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `trainadd`
--
ALTER TABLE `trainadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

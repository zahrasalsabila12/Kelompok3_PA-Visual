-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2023 at 04:59 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbblossom`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbakun`
--

CREATE TABLE `tbakun` (
  `id` int(10) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbakun`
--

INSERT INTO `tbakun` (`id`, `username`, `password`) VALUES
(1, 'irvan', 'irvan123'),
(2, 'user1', '123');

-- --------------------------------------------------------

--
-- Table structure for table `tbkeranjang`
--

CREATE TABLE `tbkeranjang` (
  `id` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `merk` varchar(50) NOT NULL,
  `jenis` varchar(50) NOT NULL,
  `harga_satuan` int(11) NOT NULL,
  `jumlah_barang` int(11) NOT NULL,
  `total` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbkeranjang`
--

INSERT INTO `tbkeranjang` (`id`, `nama`, `merk`, `jenis`, `harga_satuan`, `jumlah_barang`, `total`) VALUES
(1, 'UV Moisture Milk', 'Skin Aqua', 'Skin Care', 48500, 2, 97000);

-- --------------------------------------------------------

--
-- Table structure for table `tbmakeup`
--

CREATE TABLE `tbmakeup` (
  `id` int(11) NOT NULL,
  `nama` text NOT NULL,
  `merk` text NOT NULL,
  `jenis` text NOT NULL,
  `harga` int(50) NOT NULL,
  `stok` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbmakeup`
--

INSERT INTO `tbmakeup` (`id`, `nama`, `merk`, `jenis`, `harga`, `stok`) VALUES
(6, 'Lip Cream', 'Pixy', 'Make Up', 45000, 100);

-- --------------------------------------------------------

--
-- Table structure for table `tbskincare`
--

CREATE TABLE `tbskincare` (
  `id` int(11) NOT NULL,
  `nama` text NOT NULL,
  `merk` text NOT NULL,
  `jenis` text NOT NULL,
  `harga` int(50) NOT NULL,
  `stok` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbskincare`
--

INSERT INTO `tbskincare` (`id`, `nama`, `merk`, `jenis`, `harga`, `stok`) VALUES
(6, 'UV Moisture Milk', 'Skin Aqua', 'Skin Care', 48500, 198),
(7, 'Foaming Face Wash', 'Clean and Clear', 'Skin Care', 16000, 200),
(8, 'Bright Stuff Face Wash', 'Emina', 'Skin Care', 16000, 100);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbakun`
--
ALTER TABLE `tbakun`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbmakeup`
--
ALTER TABLE `tbmakeup`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbskincare`
--
ALTER TABLE `tbskincare`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbmakeup`
--
ALTER TABLE `tbmakeup`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbskincare`
--
ALTER TABLE `tbskincare`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2023 at 10:57 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

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
(1, 'Lipstick Merah', 'Wardah', 'Make Up', 100000, 10, 100000),
(2, 'Sabun', 'Kiyowo', 'Skin Care', 1000, 10, 1000);

-- --------------------------------------------------------

--
-- Table structure for table `tbmakeup`
--

CREATE TABLE `tbmakeup` (
  `id` text CHARACTER SET utf8 NOT NULL,
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
('1', 'Bedak', 'Samsul', 'Make Up', 2000, 15),
('2', '2', '2', 'Make Up', 2, 15),
('3', 'Lipstick Merah', 'Wardah', 'Make Up', 100000, 15);

-- --------------------------------------------------------

--
-- Table structure for table `tbskincare`
--

CREATE TABLE `tbskincare` (
  `id` text CHARACTER SET utf8 NOT NULL,
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
('1', 'Sabun', 'Kiyowo', 'Skin Care', 1000, 15),
('2', 'Masker Jeruk', 'Orange', 'Skin Care', -1, 15);

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
  ADD PRIMARY KEY (`id`(50));

--
-- Indexes for table `tbskincare`
--
ALTER TABLE `tbskincare`
  ADD PRIMARY KEY (`id`(50));

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbakun`
--
ALTER TABLE `tbakun`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbkeranjang`
--
ALTER TABLE `tbkeranjang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

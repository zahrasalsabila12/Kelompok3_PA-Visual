-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2023 at 11:24 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

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
  `id` text NOT NULL,
  `usename` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbmakeup`
--

CREATE TABLE `tbmakeup` (
  `id` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `nama` text NOT NULL,
  `merk` text NOT NULL,
  `jenis` text NOT NULL,
  `harga` int(50) NOT NULL,
  `stok` int(50) NOT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbskincare`
--

CREATE TABLE `tbskincare` (
  `id` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `nama` text NOT NULL,
  `merk` text NOT NULL,
  `jenis` text NOT NULL,
  `harga` int(50) NOT NULL,
  `stok` int(50) NOT NULL,
  `gambar` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbakun`
--
ALTER TABLE `tbakun`
  ADD PRIMARY KEY (`id`(50));

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
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.4.12
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2019 at 07:55 AM
-- Server version: 5.6.25
-- PHP Version: 5.5.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_listrik`
--

-- --------------------------------------------------------

--
-- Table structure for table `pembayaran_detail`
--

CREATE TABLE IF NOT EXISTS `pembayaran_detail` (
  `id` varchar(237) CHARACTER SET latin1 NOT NULL,
  `id_pelanggan` varchar(255) CHARACTER SET latin1 DEFAULT NULL,
  `nama_pelanggan` varchar(250) CHARACTER SET latin1 DEFAULT NULL,
  `nometer` varchar(40) CHARACTER SET latin1 DEFAULT NULL,
  `kode_tarif` varchar(40) CHARACTER SET latin1 DEFAULT NULL,
  `kode_unik` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `pemakaian` varchar(50) CHARACTER SET latin1 DEFAULT NULL,
  `daya` varchar(60) CHARACTER SET latin1 DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `total` varchar(40) CHARACTER SET latin1 DEFAULT NULL,
  `biaya_admin` varchar(60) CHARACTER SET latin1 DEFAULT NULL,
  `bayar` varchar(60) CHARACTER SET latin1 DEFAULT NULL,
  `kembalian` varchar(90) CHARACTER SET latin1 DEFAULT NULL,
  `status` varchar(90) CHARACTER SET latin1 DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `pembayaran_detail`
--

INSERT INTO `pembayaran_detail` (`id`, `id_pelanggan`, `nama_pelanggan`, `nometer`, `kode_tarif`, `kode_unik`, `pemakaian`, `daya`, `tanggal`, `total`, `biaya_admin`, `bayar`, `kembalian`, `status`) VALUES
('PEM0001', 'PLG0001', 'Samsudin', '6666666666666666', 'KT45', 'VAPLXSHJ', '78', '450 VA', '2019-03-12', '7000', '2,500', '7000', '3602', 'Sudah Dibayar'),
('PEM0002', 'PLG0003', 'Sugeng', '6567645786468754', 'KT45', 'ZOLBUGBF', '6000', '450 VA', '2019-03-20', '33,600', '2,500', '50000', '16400', 'Sudah Dibayar'),
('PEM0003', 'PLG0004', 'Tukiyem', '9838749328749832', 'KT45', 'XMRMDPVI', '35000', '450 VA', '2019-03-23', '200000', '2,500', '200000', '18500', 'Sudah Dibayar');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pelanggan`
--

CREATE TABLE IF NOT EXISTS `tb_pelanggan` (
  `id_pelanggan` varchar(10) COLLATE latin1_general_ci NOT NULL,
  `nometer` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `nama_pelanggan` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `alamat_pelanggan` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `kode_tarif` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `kode_unik` varchar(255) COLLATE latin1_general_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `tb_pelanggan`
--

INSERT INTO `tb_pelanggan` (`id_pelanggan`, `nometer`, `nama_pelanggan`, `alamat_pelanggan`, `kode_tarif`, `kode_unik`) VALUES
('PLG0002', '8903745817385537', 'Urip', 'Apa', 'KT90', 'KGKGACQC'),
('PLG0001', '4765676543467864', 'Samsudin', 'Dimana', 'KT45', 'VAPLXSHJ'),
('PLG0003', '6567645786468754', 'Sugeng', 'Ahh', 'KT45', 'ZOLBUGBF'),
('PLG0004', '9838749328749832', 'Tukiyem', 'Bekasi', 'KT45', 'XMRMDPVI');

-- --------------------------------------------------------

--
-- Table structure for table `tb_pembayaran`
--

CREATE TABLE IF NOT EXISTS `tb_pembayaran` (
  `id_bayar` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `id_pelanggan` varchar(25) COLLATE latin1_general_ci NOT NULL DEFAULT '0',
  `tanggal` date DEFAULT NULL,
  `bulan_bayar` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `biaya_admin` varchar(255) COLLATE latin1_general_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `tb_pembayaran`
--

INSERT INTO `tb_pembayaran` (`id_bayar`, `id_pelanggan`, `tanggal`, `bulan_bayar`, `biaya_admin`) VALUES
('PEM0001', 'PLG0001', '2019-03-12', '7000', '2,500'),
('PEM0002', 'PLG0003', '2019-03-20', '33,600', '2,500'),
('PEM0003', 'PLG0004', '2019-03-23', '181,500', '2,500');

-- --------------------------------------------------------

--
-- Table structure for table `tb_penggunaan`
--

CREATE TABLE IF NOT EXISTS `tb_penggunaan` (
  `id_pelanggan` varchar(255) NOT NULL DEFAULT '',
  `bulan_pelanggan` date DEFAULT NULL,
  `meter_awal` varchar(200) DEFAULT NULL,
  `meter_akhir` varchar(200) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_penggunaan`
--

INSERT INTO `tb_penggunaan` (`id_pelanggan`, `bulan_pelanggan`, `meter_awal`, `meter_akhir`) VALUES
('PLG0001', '2019-03-12', '2', '78'),
('PLG0002', '2019-03-12', '100', '800'),
('PLG0003', '2019-03-15', '6000', '6000'),
('PLG0004', '2019-03-20', '5000', '35000');

-- --------------------------------------------------------

--
-- Table structure for table `tb_tagih`
--

CREATE TABLE IF NOT EXISTS `tb_tagih` (
  `id_pelanggan` varchar(25) NOT NULL DEFAULT '',
  `tanggal` date DEFAULT NULL,
  `jumlah_meter` varchar(255) DEFAULT NULL,
  `status_tagih` varchar(255) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_tagih`
--

INSERT INTO `tb_tagih` (`id_pelanggan`, `tanggal`, `jumlah_meter`, `status_tagih`) VALUES
('PLG0001', '2019-03-12', '78', 'Sudah Dibayar'),
('PLG0002', '2019-03-12', '800', 'Sudah Dibayar'),
('PLG0003', '2019-03-18', '6000', 'Sudah Dibayar'),
('PLG0004', '2019-03-20', '35000', 'Sudah Dibayar');

-- --------------------------------------------------------

--
-- Table structure for table `tb_tarif`
--

CREATE TABLE IF NOT EXISTS `tb_tarif` (
  `kode_tarif` varchar(255) NOT NULL,
  `daya_tarif` varchar(50) DEFAULT NULL,
  `tarif_kwh` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tb_tarif`
--

INSERT INTO `tb_tarif` (`kode_tarif`, `daya_tarif`, `tarif_kwh`) VALUES
('KT45', '450 VA', '170'),
('KT90', '900 VA', '310'),
('KT130', '1300 VA', '390'),
('KT220', '2200 VA', '400'),
('KT660', '6600 VA', '620');

-- --------------------------------------------------------

--
-- Table structure for table `tb_user`
--

CREATE TABLE IF NOT EXISTS `tb_user` (
  `id_user` varchar(10) COLLATE latin1_general_ci NOT NULL,
  `nama_user` varchar(244) COLLATE latin1_general_ci NOT NULL,
  `password` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `alamat` varchar(255) COLLATE latin1_general_ci NOT NULL,
  `status` varchar(124) COLLATE latin1_general_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1 COLLATE=latin1_general_ci;

--
-- Dumping data for table `tb_user`
--

INSERT INTO `tb_user` (`id_user`, `nama_user`, `password`, `alamat`, `status`) VALUES
('USR001', 'admin', 'admin', '', 'Administrator'),
('USR002', 'admoon', 'admoon', 'admoon', 'Administrator'),
('USR003', 'pusing', 'pusing', 'asdasdasd', 'User'),
('USR004', 'a', 'b', 'c', 'Administrator');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pembayaran_detail`
--
ALTER TABLE `pembayaran_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tb_pelanggan`
--
ALTER TABLE `tb_pelanggan`
  ADD PRIMARY KEY (`id_pelanggan`);

--
-- Indexes for table `tb_pembayaran`
--
ALTER TABLE `tb_pembayaran`
  ADD PRIMARY KEY (`id_bayar`);

--
-- Indexes for table `tb_penggunaan`
--
ALTER TABLE `tb_penggunaan`
  ADD PRIMARY KEY (`id_pelanggan`);

--
-- Indexes for table `tb_tagih`
--
ALTER TABLE `tb_tagih`
  ADD PRIMARY KEY (`id_pelanggan`);

--
-- Indexes for table `tb_user`
--
ALTER TABLE `tb_user`
  ADD PRIMARY KEY (`id_user`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

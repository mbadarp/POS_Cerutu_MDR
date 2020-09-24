-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Sep 2020 pada 05.50
-- Versi server: 10.3.16-MariaDB
-- Versi PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_pos`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `kodeadmin` varchar(6) NOT NULL,
  `nama_admin` varchar(70) NOT NULL,
  `password` varchar(50) NOT NULL,
  `level` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_admin`
--

INSERT INTO `tbl_admin` (`kodeadmin`, `nama_admin`, `password`, `level`) VALUES
('ADM001', 'admin', 'admin', 'admin'),
('ADM002', 'user', 'user', 'user'),
('ADM003', 'Badar', 'badar', 'Admin'),
('ADM004', 'pamungkas', 'pamungkas', 'User');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `kodebarang` varchar(6) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga_barang` int(11) NOT NULL,
  `jumlah_barang` int(11) NOT NULL,
  `satuanbarang` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_barang`
--

INSERT INTO `tbl_barang` (`kodebarang`, `nama_barang`, `harga_barang`, `jumlah_barang`, `satuanbarang`) VALUES
('BRG001', 'Tembakau A', 50000, 426, 'Karton'),
('BRG002', 'Tembakau B', 25000, 493, 'Karton');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barangbeli`
--

CREATE TABLE `tbl_barangbeli` (
  `kodebarang` varchar(7) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga_barang` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_barangbeli`
--

INSERT INTO `tbl_barangbeli` (`kodebarang`, `nama_barang`, `harga_barang`) VALUES
('BBLI001', 'Pita Cukai', 5000),
('BBLI002', 'Korek', 2000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_beli`
--

CREATE TABLE `tbl_beli` (
  `nobeli` varchar(10) NOT NULL,
  `tgl_beli` date NOT NULL,
  `jam_beli` time NOT NULL,
  `total_beli` double(12,2) NOT NULL,
  `dibayar` int(11) NOT NULL,
  `kembali` int(11) NOT NULL,
  `kodeadmin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailbeli`
--

CREATE TABLE `tbl_detailbeli` (
  `nobeli` varchar(10) NOT NULL,
  `kodebarang` varchar(6) NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `harga_beli` int(11) NOT NULL,
  `jumlah_beli` int(11) NOT NULL,
  `subtotal` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailjual`
--

CREATE TABLE `tbl_detailjual` (
  `nojual` varchar(10) NOT NULL,
  `kodebarang` varchar(6) NOT NULL,
  `nama_barang` varchar(100) NOT NULL,
  `harga_jual` int(11) NOT NULL,
  `jumlah_jual` int(11) NOT NULL,
  `subtotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_detailjual`
--

INSERT INTO `tbl_detailjual` (`nojual`, `kodebarang`, `nama_barang`, `harga_jual`, `jumlah_jual`, `subtotal`) VALUES
('J200923001', 'BRG001', 'Tembakau A', 50000, 2, 100000),
('J200923001', 'BRG002', 'Tembakau B', 25000, 2, 50000),
('J200923002', 'BRG001', 'Tembakau A', 50000, 2, 100000),
('J200923002', 'BRG002', 'Tembakau B', 25000, 2, 50000),
('J200923003', 'BRG001', 'Tembakau A', 50000, 50, 2500000),
('J200923004', 'BRG001', 'Tembakau A', 50000, 20, 1000000),
('J200923004', 'BRG002', 'Tembakau B', 25000, 3, 75000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jual`
--

CREATE TABLE `tbl_jual` (
  `nojual` varchar(10) NOT NULL,
  `tgl_jual` date NOT NULL,
  `jam_jual` time NOT NULL,
  `item_jual` int(11) NOT NULL,
  `total_jual` int(11) NOT NULL,
  `dibayar` int(11) NOT NULL,
  `kembali` int(11) NOT NULL,
  `kodepelanggan` varchar(6) NOT NULL,
  `kodeadmin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_jual`
--

INSERT INTO `tbl_jual` (`nojual`, `tgl_jual`, `jam_jual`, `item_jual`, `total_jual`, `dibayar`, `kembali`, `kodepelanggan`, `kodeadmin`) VALUES
('J200923001', '2020-09-23', '04:27:06', 4, 150000, 200000, 50000, 'PLG001', 'ADM003'),
('J200923002', '2020-09-23', '04:29:12', 4, 150000, 200000, 50000, 'PLG002', 'ADM003'),
('J200923003', '2020-09-23', '04:30:07', 50, 2500000, 3000000, 500000, 'PLG001', 'ADM003'),
('J200923004', '2020-09-23', '07:12:58', 23, 1075000, 1100000, 25000, 'PLG001', 'ADM003');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `kodepelanggan` varchar(6) NOT NULL,
  `nama_pelanggan` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_hp` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`kodepelanggan`, `nama_pelanggan`, `alamat`, `no_hp`) VALUES
('PLG001', 'Ega', 'Jenggawah', '089998771221'),
('PLG002', 'Dani', 'Patrang', '087234543555');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_supplier`
--

CREATE TABLE `tbl_supplier` (
  `kodesupplier` varchar(6) NOT NULL,
  `nama_supplier` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `telepon` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_supplier`
--

INSERT INTO `tbl_supplier` (`kodesupplier`, `nama_supplier`, `alamat`, `telepon`) VALUES
('SPL001', 'Ella', 'Bukit Permai', '089222333222'),
('SPL002', 'Sari', 'Tanggul Kulon', '089111222111');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`kodeadmin`);

--
-- Indeks untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`kodebarang`);

--
-- Indeks untuk tabel `tbl_barangbeli`
--
ALTER TABLE `tbl_barangbeli`
  ADD PRIMARY KEY (`kodebarang`);

--
-- Indeks untuk tabel `tbl_beli`
--
ALTER TABLE `tbl_beli`
  ADD PRIMARY KEY (`nobeli`);

--
-- Indeks untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD PRIMARY KEY (`nojual`);

--
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`kodepelanggan`);

--
-- Indeks untuk tabel `tbl_supplier`
--
ALTER TABLE `tbl_supplier`
  ADD PRIMARY KEY (`kodesupplier`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 21, 2023 at 08:43 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_xtrememusix`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbartist`
--

CREATE TABLE `tbartist` (
  `id_artist` int(10) NOT NULL,
  `name` varchar(50) NOT NULL,
  `country` varchar(25) NOT NULL,
  `photo` varchar(50) NOT NULL,
  `description` text NOT NULL,
  `update_at` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbartist`
--

INSERT INTO `tbartist` (`id_artist`, `name`, `country`, `photo`, `description`, `update_at`) VALUES
(1, 'Nadin Amizah', 'Indonesia', 'defaultPerson.png', 'Penyanyi dan penulis lagu berkebangsaan Indonesia.', '2018-11-25'),
(2, 'One Direction', 'United Kingdom', 'defaultPerson.png', 'One Direction adalah sebuah grup vokal Inggris-Irlandia berbasis di London, terdiri dari Niall Horan, Liam Payne, Harry Styles, Louis Tomlinson dan Zayn Malik.', '2010-05-23'),
(3, 'Virgoun', 'Indonesia', 'defaultPerson.png', 'Virgoun Putra Tambunan merupakan seorang penyanyi dan pencipta lagu berkebangsaan Indonesia yang juga merupakan vokalis dari grup musik Last Child.', '2013-04-15'),
(6, 'Random', 'Indonesia', 'defaultPerson.png', 'Random Artist', '2023-05-21'),
(7, 'Ed Sheeran', 'Inggris', 'Ed_Sheeran.jpg', 'Ed Sheeran', '2023-05-21');

-- --------------------------------------------------------

--
-- Table structure for table `tbplaylist`
--

CREATE TABLE `tbplaylist` (
  `id_playlist` int(10) NOT NULL,
  `uid` int(10) NOT NULL,
  `name` varchar(50) NOT NULL,
  `description` text NOT NULL,
  `cover` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbplaylist`
--

INSERT INTO `tbplaylist` (`id_playlist`, `uid`, `name`, `description`, `cover`) VALUES
(1, 1, 'INDO HITS', 'Menampilkan lagu-lagu indo paling hits tahun ini.', 'doremi.jpg'),
(2, 3, 'TOP BARAT', 'Daftar lagu-lagu barat teratas!', 'bruno.jpg'),
(3, 1, 'First Playlist', 'First Description', 'boom.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tbplaylist_song`
--

CREATE TABLE `tbplaylist_song` (
  `id_playlist` int(10) NOT NULL,
  `id_song` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbplaylist_song`
--

INSERT INTO `tbplaylist_song` (`id_playlist`, `id_song`) VALUES
(1, 3),
(1, 7),
(2, 4),
(2, 5),
(2, 6),
(3, 8),
(1, 5),
(2, 8),
(1, 4),
(1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tbsong`
--

CREATE TABLE `tbsong` (
  `id_song` int(10) NOT NULL,
  `id_artist` int(10) NOT NULL,
  `title` varchar(50) NOT NULL,
  `genre` varchar(25) NOT NULL,
  `description` text NOT NULL,
  `cover` varchar(50) NOT NULL,
  `source` varchar(50) NOT NULL,
  `update_at` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbsong`
--

INSERT INTO `tbsong` (`id_song`, `id_artist`, `title`, `genre`, `description`, `cover`, `source`, `update_at`) VALUES
(2, 1, 'Sorai', 'Indie', 'Secara garis besar, lagu Sorai karangan Nadin Amizah menceritakan tentang seseorang yang sudah melepaskan kepergian mantan kekasihnya dengan penuh rasa ikhlas, bersyukur, dan lapang dada. Istilah sorai dipakai untuk merayakan perpisahan tersebut dengan gembira.', 'Sorai.jpeg', 'Sorai.mp3', '2021-03-22'),
(3, 1, 'Bertaut', 'Indie', 'Lagu Bertaut karya Nadin Amizah menghadirkan makna yang mendalam mengenai hubungan ikatan batin dan kasih sayang yang amat erat antara ibu dan anak sampai maut memisahkan.', 'Bertaut.jpg', 'Bertaut.mp3', '2020-09-22'),
(4, 2, 'What\'s Makes You Beautiful', 'Pop', 'Pada lirik lagu “What Makes You Beautiful” yang asli memiliki makna lagu rasa kekaguman seorang lelaki kepada seorang wanita yang baru pertama kali dilihatnya. Sedangkan pada video parodi “What Makes You Beautiful” yang dibuat oleh Cameo Project lebih menceritakan tentang permasalahan yang terjadi di ibu kota.', 'Whats_Makes.jpg', 'What\'s Makes You Beautiful.mp3', '2013-02-04'),
(5, 2, 'Night Changes', 'Pop', 'Untuk diketahui, arti lirik lagu Night Changes - One Direction, memang tentang seseorang yang tumbuh dan menjadi lebih dewasa serta menyadari kalau ia sudah tumbuh semakin tua.', 'Night_Changes.jpg', 'Night Changes.mp3', '2015-10-15'),
(6, 2, 'Strong', 'Pop', 'Arti lagu strong - One Direction menceritakan tentang seseorang yang merasa kuat saat berada dekat dengan kekasihnya. Ia tidak takut akan cinta yang katanya rasa cinta sama saja dengan rasa sakit dan bila siap mencinta, maka juga harus siap terluka.', 'Strong.jpg', 'Strong.mp3', '2017-10-18'),
(7, 3, 'Orang Yang Sama', 'Jazz', 'Lagu ini menceritakan tentang rasa bersyukur karena merasa telah dipertemukan dengan pasangan yang tepat, pasangan yang selalu ada dan mampu mengerti disegala kondisi, pasangan yang selalu disemogakan menjadi jodoh sejatinya.', 'Orang_Yang_Sama.jpeg', 'Orang Yang Sama.mp3', '2018-02-12'),
(8, 3, 'Selamat Tinggal', 'Pop', 'Makna lagu “Selamat (Selamat Tinggal)” dari Virgoun adalah menceritakan tentang bentuk ucapan selamat tinggal dan perpisahan dari mantan kekasih yang kini ia sudah bahagia dengan pasangan barunya.', 'Selamat_Tinggal.jpg', 'Selamat Tinggal.mp3', '2016-06-28'),
(12, 2, 'Komang', 'Pop', 'Sebuah lagu', 'chainsmo.jpg', 'Komang - Raim Laode.mp3', '2023-05-21'),
(15, 6, 'A Sky Full Of Stars', 'Pop', 'Description A Sky Full Of Stars', 'payphone.jpg', 'Coldplay - A Sky Full Of Stars.mp3', '2023-05-21'),
(16, 7, 'Perfect', 'Pop', 'Description Perfect', 'payphone.jpg', 'Ed Sheeran - Perfect.mp3', '2023-05-21');

-- --------------------------------------------------------

--
-- Table structure for table `tbuser`
--

CREATE TABLE `tbuser` (
  `uid` int(10) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` enum('user','admin') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbuser`
--

INSERT INTO `tbuser` (`uid`, `username`, `password`, `role`) VALUES
(1, 'rian', '78', 'user'),
(2, 'admin', '123', 'admin'),
(3, 'hadi', '58', 'user'),
(4, 'dhiya', '56', 'user'),
(5, 'rizky', '59', 'user'),
(6, 'a', 'a', 'user'),
(7, 'budi', '1', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbartist`
--
ALTER TABLE `tbartist`
  ADD PRIMARY KEY (`id_artist`);

--
-- Indexes for table `tbplaylist`
--
ALTER TABLE `tbplaylist`
  ADD PRIMARY KEY (`id_playlist`),
  ADD KEY `uid` (`uid`);

--
-- Indexes for table `tbplaylist_song`
--
ALTER TABLE `tbplaylist_song`
  ADD KEY `id_playlist` (`id_playlist`),
  ADD KEY `id_song` (`id_song`);

--
-- Indexes for table `tbsong`
--
ALTER TABLE `tbsong`
  ADD PRIMARY KEY (`id_song`),
  ADD KEY `id_artist` (`id_artist`);

--
-- Indexes for table `tbuser`
--
ALTER TABLE `tbuser`
  ADD PRIMARY KEY (`uid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbartist`
--
ALTER TABLE `tbartist`
  MODIFY `id_artist` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbplaylist`
--
ALTER TABLE `tbplaylist`
  MODIFY `id_playlist` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `tbsong`
--
ALTER TABLE `tbsong`
  MODIFY `id_song` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tbuser`
--
ALTER TABLE `tbuser`
  MODIFY `uid` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbplaylist`
--
ALTER TABLE `tbplaylist`
  ADD CONSTRAINT `tbplaylist_ibfk_1` FOREIGN KEY (`uid`) REFERENCES `tbuser` (`uid`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbplaylist_song`
--
ALTER TABLE `tbplaylist_song`
  ADD CONSTRAINT `tbplaylist_song_ibfk_1` FOREIGN KEY (`id_playlist`) REFERENCES `tbplaylist` (`id_playlist`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbplaylist_song_ibfk_2` FOREIGN KEY (`id_song`) REFERENCES `tbsong` (`id_song`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbsong`
--
ALTER TABLE `tbsong`
  ADD CONSTRAINT `tbsong_ibfk_1` FOREIGN KEY (`id_artist`) REFERENCES `tbartist` (`id_artist`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

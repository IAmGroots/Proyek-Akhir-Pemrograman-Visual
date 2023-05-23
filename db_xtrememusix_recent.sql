-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 26, 2023 at 06:14 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

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
(7, 'Ed Sheeran', 'Inggris', 'Ed_Sheeran.jpg', 'Ed Sheeran', '2023-05-21'),
(8, 'Hindia', 'Indonesia', '2559460670.jpg', 'Hindia adalah band indie asal indonesia', '2023-05-26'),
(9, 'Harry Styles', 'Inggris', 'Harry-Styles.jpg', 'Harry Edward Styles (lahir 1 Februari 1994) adalah seorang penyanyi, penulis lagu dan aktor berkebangsaan Inggris. Dia dikenal sebagai anggota dari boy band One Direction. Redditch, Worcestershire, Inggris. Styles tumbuh besar di Holmes Chapel, Cheshire.', '2023-05-26'),
(10, 'Coldplay', 'Inggris', 'Coldplay.jpg', 'Coldplay adalah band rock Inggris yang dibentuk di London pada tahun 1997. Mereka terdiri dari vokalis dan pianis Chris Martin, gitaris Jonny Buckland, bassis Guy Berryman, drummer Will Champion dan direktur kreatif Phil Harvey.', '2023-05-26'),
(11, 'Fiersa Besari', 'Indonesia', 'Fiersa Besari.jpeg', 'Fiersa Besari adalah Penulis, YouTuber, dan Musisi asal Indonesia. Sebagai penulis, Fiersa telah menghasilkan enam novel. Ia juga terlibat sebagai salah satu pendiri Komunitas Pecandu Buku. Ia pun aktif sebagai YouTuber pendakian. Episode-episode YouTube terkenal miliknya adalah \"Sebuah Jurnal\".', '2023-05-26'),
(12, 'Nosstress', 'Indonesia', 'Nosstress.jpg', 'Nosstress adalah grup musik indie akustik yang berasal dari Bali, Indonesia. Grup ini terdiri dari Man Angga dan Guna Warma. Awalnya Nosstress hanya membawakan cover lagu versi akustik hingga akhirnya merilis karya orisinalnya dengan balutan genre blues dan folk Bali.', '2023-05-26'),
(13, 'Lobow', 'Indonesia', 'Lobow.jpg', 'Lobow Ilyas Lahir di Ujung Pandang Makassar, Sulawesi Selatan, Indonesia, 1 September 1977 adalah penyanyi berkebangsaan Indonesia yang dikenal dengan lagu Salah, Kau Cantik Hari Ini, Siapakah Dirimu, Ironis, Belum Siap Aku kehilanganmu, dan banyak lagi karya Penyanyi Pria Ini.', '2023-05-26'),
(14, 'Chrisye', 'Indonesia', 'Chrisye.jpg', 'H. Chrismansyah Rahadi lahir dengan nama Christian Rahadi yang lebih dikenal dengan nama panggung Chrisye, merupakan seorang penyanyi dan pencipta lagu asal Indonesia. Ia dilahirkan di Jakarta dari keluarga Tionghoa-Indonesia, Chrisye menjadi tertarik dengan musik saat masih muda.', '2023-05-26'),
(15, 'My Chemycal Romance', 'Amerika', 'My Chemycal Romance.jpeg', 'My Chemical Romance adalah grup musik asal New Jersey, yang dibentuk pada bulan September tahun 2001 oleh Gerard Way dan Matt Pelissier. Saat ini, band ini beranggotakan Gerard Way, Mikey Way, Ray Toro, dan Frank Iero.', '2023-05-26'),
(16, 'Feby Putri', 'Indonesia', 'Feby putri.jpg', 'Feby Putri Nilam Cahyani merupakan penyanyi-penulis lagu berkebangsaan Indonesia. Feby mulai dikenal melalui debut singelnya \"Halu\" yang dirilis pada tahun 2019, selanjutnya ia mendapat pengakuan luas pasca merilis singel keenamnya, \"Runtuh\" berkolaborasi dengan Fiersa Besari pada tahun 2021.', '2023-05-26'),
(17, 'Denny Caknan', 'Indonesia', 'Denny Caknan.jpg', 'Deni Setiawan, S.E.; atau lebih dikenal dengan nama panggung Denny Caknan adalah seorang penyanyi dan pencipta lagu pop Jawa dan koplo berkebangsaan Indonesia. Ia mulai dikenal berkat lagu \"Kartonyono Medot Janji\" yang merupakan singel perdananya pada tahun 2019.', '2023-05-26'),
(18, 'Coboy Junior', 'Indonesia', 'cjr.jpg', 'CJR atau ditulis bernama Coboy Junior adalah sebuah grup musik asal Indonesia yang dibentuk pada tanggal 23 Juli 2011 oleh Patrick Effendy. Grup musik ini beranggotakan 3 orang yaitu Aldi, Kiki, dan Iqbaal.', '2023-05-26');

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
(2, 3, 'TOP BARAT', 'Daftar lagu-lagu barat teratas!', 'Ed_Sheeran.jpg'),
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
(16, 7, 'Perfect', 'Pop', 'Description Perfect', 'payphone.jpg', 'Ed Sheeran - Perfect.mp3', '2023-05-21'),
(17, 8, 'Rumah Ke Rumah', 'Indie', 'Lagu Rumah ke Rumah ini memiliki makna bahwa kisah cinta ada yang berakhir baik ada yang berakhir buruk. Itulah mengapa banyak nama-nama perempuan yang muncul didalam liriknya.', 'Rumah Ke Rumah.jpg', 'Hindia - Rumah Ke Rumah.mp3', '2023-05-26'),
(18, 9, 'As It Was', 'Pop', 'Lirik lagu As It Was menceritakan tentang perjalanan hidup dan berbagai kesulitan yang dialami Styles selama berkarier sebagai artis. Ia berbicara tentang pentingnya memahami dan menerima diri sendiri, walau menghadapi beranekaragam kesulitan dan kritik dari dunia luar.', 'As It Was.jpg', 'Harry Styles - As It Was Lyrics.mp3', '2023-05-26'),
(19, 10, 'Viva La Vida', 'Edm', 'Viva La Vida menceritakan sosok seorang raja yang memiliki kerajaan besar dan bahkan menguasai dunia. Sang raja harus kehilangan kerajaannya namun nggak menyerah dan berputus asa terhadap keadaan yang terjadi Raja tersebut malah memilih untuk bangkit dari keterpurukan yang dialaminya.', 'Viva La Vida.jpg', 'Coldplay - Viva la Vida.mp3', '2023-05-26'),
(20, 10, 'Yellow', 'Edm', 'Yellow menceritakan tentang seseorang yang sangat mencintai orang yang dicintainya, yang ia gambarkan seperti warna kuning yang cerah dan bercahaya. Ia menunjukkan betapa spesialnya orang tersebut dengan menulis lagu berjudul \"Yellow\" dan melakukan segala hal yang mungkin untuk memenangkan hatinya.', 'Yellow.jpg', 'Coldplay - Yellow.mp3', '2023-05-26'),
(21, 11, 'April', 'Pop', 'lagu ini menceritakan tentang kondisi pria yang sulit untuk menatap ke depan karena terpaku oleh romantisme masa lalu bersama mantannya.', 'april.jpg', 'Fiersa Besari - April.mp3', '2023-05-26'),
(22, 11, 'Melawan Hati', 'Pop', 'Lagu Melawan Hati yang dibawakan Fiersa Besari feat Prinsa Mandagie. Lirik lagu ini menceritakan tentang sepasang kekasih yang masih saling mencintai namun terpaksa berpisah', 'Melawan hati.jpg', 'FIERSA BESARI - Melawan Hati.mp3', '2023-05-26'),
(23, 12, 'Istirahat', 'Indie', 'Lagu ini menceritakan tentang kepedulian lingkungan, tentang bumi yang terlihat semakin rusak dan parah akibat ulah dari penghuninya, yakni manusia itu sendiri. Semakin hari manusia semakin senonoh saja dengan tempat tinggalnya.', 'Istirahat.jpeg', 'Nosstress - Istirahat.mp3', '2023-05-26'),
(24, 12, 'Tumbuh', 'Indie', 'lagu ini adalah motivasi yang sangat kuat tentang seseorang yang mengejar mimpinya, bait ini menyadarkan kita untuk segera bangkit mengejar apa yang dulu pernah kita harapkan tentang mimpi-mimpi yang dulu pernah kita rangkai dan mungkin boleh jadi saat ini  kita sudah lupa tentang semuanya itu, entah karena apa pun alasannya. Lagu ini mengajak kita untuk kembali mengingat mimpi-mimpi kita yang dulu pernah kita rangkai dan tak sempat terwujud saat ini. ', 'Tumbuh.jpg', 'Nosstress - TUMBUH.mp3', '2023-05-26'),
(25, 13, 'Kau Cantik Hari Ini', 'Pop', 'Lagu Kau Canti Hari Ini menceritakan tentang seorang pria yang mengagumi seorang wanita yang telah lama tak ia temui.', 'Kau cantik hari ini.jpg', 'Lobow - Kau Cantik Hari Ini.mp3', '2023-05-26'),
(26, 14, 'Kala Cinta Menggoda', 'Pop', 'Lagu Kala Cinta Menggoda berkisah tentang rasa cinta seseorang dengan gaya pengisahan sudut pandang orang pertama. Diceritakan bahwa sejak pertama kali berjumpa dengan mitra tutur, penutur dalam cerita langsung tertarik dan jatuh cinta kepada mitra tutur.', 'kala Cimta Menggoda.jpg', 'Chrisye - Kala Cinta Menggoda.mp3', '2023-05-26'),
(27, 14, 'Kisah Kasih Di Sekolah', 'Pop', 'Makna dan Lirik Lagu Kisah Kasih Di Sekolah - Obbie Messakh adalah menceritakan tentang kehidupan romantis dikala sekolah yang pastinya adalah masa-masa terindah bagi semua orang.', 'Kisah kasih di sekolah.jpg', 'Chrisye - Kisah Kasih di Sekolah.mp3', '2023-05-26'),
(28, 15, 'Black Parade', 'Rock', 'Vokalis dari My Chemical Romance tersebut menjelaskan inspirasi besar lahirnya lagu Welcome To The Black Parade ini mengisahkan tentang perjuangan seseorang untuk keluar dari masa kelam yang ada di dalam hidupnya.', 'MCR.jpg', 'My Chemical Romance - Welcome To The Black Parade.', '2023-05-26'),
(29, 15, 'Dischanted', 'Rock', 'Lagu ini menceritakan tentang seseorang yang membenci hidupnya karena sebuah penyakit. Dalam kebencian yang dirasakannya, perlahan ia mengingat kebahagiaan-kebahagiaan yang pernah dialaminya.', 'Dischanted.jpg', 'My Chemical Romance - Disenchanted.mp3', '2023-05-26'),
(30, 16, 'Usik', 'Indie', 'Makna yang ada dalam lagu \"Usik\" dikatakan relate dengan masalah yang sering dihadapi oleh anak remaja yaitu berharap cahaya datang disekitar orang-orang yang mulai menjatuhkan. Dalam video klip yang diunggah melalui YouTube Feby Putri NC, tertera bahwa videonya didedikasikan untuk teman-teman tuli.', 'Usik.jpg', 'Feby Putri - Usik.mp3', '2023-05-26'),
(31, 17, 'Widodari', 'Koplo', 'Widodari adalah lagu yang menceritakan seorang yang ditinggal kekasihnya kemudian menemukan penggantinya yang membuatnya bahagia lagi. Cerita itu bisa didengarkan dari lirik lagunya yang menggambarkan kebahagian menemukan pengganti kekasihnya, Aku nemu Widodari.', 'widodari.jpg', 'DENNY CAKNAN -  WIDODARI.mp3', '2023-05-26'),
(32, 17, 'Los Dol', 'Koplo', 'Dalam bahasa Jawa, Los Dol artinya gas pol alias lanjut terus tidak usah kebanyakan mikir. Lagu Los dol menceritakan tentang seseorang yang sedang kesal dengan kekasihnya yang masih berhubungan dengan mantan.', 'Los Dol.jpg', 'Denny Caknan - LOS DOL.mp3', '2023-05-26'),
(33, 18, 'Terhebat', 'Pop', 'Lagu yang berjudul \"TERHEBAT\" dipopulerkan oleh group Coboy Junior yang dirilis pada tahun 2013. makna atau arti Lagu ini menceritakan tentang semangat anak muda yang terus digaungkan untuk meraih mimpi mereka.', 'terhebat.jpg', 'COBOY JUNIOR - TERHEBAT.mp3', '2023-05-26'),
(34, 18, 'Kamu', 'Pop', 'Lagu Kamu bercerita tentang perasaan sang penyanyi terhadap seorang perempuan yang ditemuinya sejak awal mereka bertemu. Dia merasa perempuan tersebut menarik. Sehingga dia selalu menunggu notifikasi dari media sosial pujaan hatinya untuk mengetahui apakah mereka punya perasaan yang sama.', 'kamu.jpg', 'COBOY JUNIOR - Kamu.mp3', '2023-05-26');

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
(6, 'a', '1', 'user'),
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
  MODIFY `id_artist` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT for table `tbplaylist`
--
ALTER TABLE `tbplaylist`
  MODIFY `id_playlist` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `tbsong`
--
ALTER TABLE `tbsong`
  MODIFY `id_song` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

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

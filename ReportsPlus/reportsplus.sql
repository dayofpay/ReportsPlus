-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Време на генериране: 20 окт 2021 в 00:42
-- Версия на сървъра: 10.4.19-MariaDB
-- Версия на PHP: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данни: `reportsplus`
--

-- --------------------------------------------------------

--
-- Структура на таблица `persons`
--

CREATE TABLE `persons` (
  `firstName` varchar(256) CHARACTER SET utf8 NOT NULL,
  `secondName` varchar(256) CHARACTER SET utf8 NOT NULL,
  `thridName` varchar(256) CHARACTER SET utf8 NOT NULL,
  `address` varchar(256) CHARACTER SET utf8 NOT NULL,
  `egn` varchar(256) NOT NULL,
  `education_type` varchar(256) CHARACTER SET utf8 NOT NULL,
  `education_status` varchar(256) CHARACTER SET utf8 NOT NULL,
  `known_nicknames` varchar(256) CHARACTER SET utf8 NOT NULL,
  `photo` varchar(256) CHARACTER SET utf8 NOT NULL,
  `phone_number` varchar(256) CHARACTER SET utf8 NOT NULL,
  `signature` varchar(256) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `persons`
--

INSERT INTO `persons` (`firstName`, `secondName`, `thridName`, `address`, `egn`, `education_type`, `education_status`, `known_nicknames`, `photo`, `phone_number`, `signature`) VALUES
('Иван', 'Христов', 'Виденов', 'Ulitsa Pirin №2', '8707078063', 'Организация на обслужването в хотелиерството', 'обл. Добрич, общ. Добрич, гр. Добрич ', 'hristov777', 'https://gcdn.pbrd.co/images/OxKYL6NJg1VR.png?o=1', '0878777777', 'https://gcdn.pbrd.co/images/mbGQeUCdbChS.png?o=1'),
('Киро', 'Кирчов', 'Иванов', 'Ген Колев №8', '2147483647', 'Висше', 'Дора габе Варна', 'ЛИПСВА', 'https://img.freepik.com/free-icon/important-person_318-10744.jpg?size=338&ext=jpg', '087878512', 'https://e7.pngegg.com/pngimages/8/721/png-clipart-signature-graphology-optima-carne-baldwinsville-text-signature.png'),
('ЛИПСВА', 'ЛИПСВА', 'ЛИПСВА', 'ЛИПСВА', '0', 'ЛИПСВА', 'ЛИПСВА', 'ЛИПСВА', 'ЛИПСВА', 'ЛИПСВА', 'ЛИПСВА');

-- --------------------------------------------------------

--
-- Структура на таблица `persons_status`
--

CREATE TABLE `persons_status` (
  `workplace` varchar(256) CHARACTER SET utf8 NOT NULL,
  `workplace_role` varchar(256) CHARACTER SET utf8 NOT NULL,
  `workplace_salary` varchar(256) CHARACTER SET utf8 NOT NULL,
  `egn` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Схема на данните от таблица `persons_status`
--

INSERT INTO `persons_status` (`workplace`, `workplace_role`, `workplace_salary`, `egn`) VALUES
('PERFE LTD(Брокер)', 'КОНСУЛТАНТ', '2400', '8707078063'),
('ЛИПСВА', 'ЛИПСВА', 'ЛИПСВА', '');

--
-- Indexes for dumped tables
--

--
-- Индекси за таблица `persons`
--
ALTER TABLE `persons`
  ADD PRIMARY KEY (`firstName`);

--
-- Индекси за таблица `persons_status`
--
ALTER TABLE `persons_status`
  ADD PRIMARY KEY (`workplace`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

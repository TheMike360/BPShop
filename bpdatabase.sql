-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Дек 25 2023 г., 17:42
-- Версия сервера: 10.4.28-MariaDB
-- Версия PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `bpdatabase`
--

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE `orders` (
  `ID` int(11) NOT NULL,
  `Time` datetime NOT NULL,
  `ProductIds` text NOT NULL,
  `Count` text NOT NULL,
  `Address` varchar(200) NOT NULL,
  `HisName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `RecipientName` varchar(100) NOT NULL,
  `RecipientContact` varchar(100) NOT NULL,
  `PayType` int(11) NOT NULL,
  `OrderStatuses` int(11) NOT NULL,
  `DeliverDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `products`
--

CREATE TABLE `products` (
  `ID` int(11) NOT NULL,
  `Name` varchar(200) NOT NULL,
  `Cost` decimal(18,2) NOT NULL,
  `Description` varchar(2000) NOT NULL,
  `Count` int(11) NOT NULL,
  `CountFlowersInBouquet` int(11) DEFAULT NULL,
  `ProductType` int(11) NOT NULL,
  `FlowersType` int(11) NOT NULL DEFAULT 0,
  `ImgRef` varchar(200) DEFAULT NULL,
  `SearchPrompt` varchar(2000) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `products`
--

INSERT INTO `products` (`ID`, `Name`, `Cost`, `Description`, `Count`, `CountFlowersInBouquet`, `ProductType`, `FlowersType`, `ImgRef`, `SearchPrompt`) VALUES
(1, 'Розыы', 150000.00, 'лолфы', 10, 2, 1, 1, '/Content/productImgs/flowers.jpg', ''),
(2, 'Пионы', 15000.00, 'лолфы', 10, 2, 1, 2, '/Content/productImgs/flowers.jpg', ''),
(3, 'Гортензии', 15000.00, 'лолфы', 10, 2, 1, 3, '/Content/productImgs/flowers.jpg', ''),
(4, 'Пионические Розы', 15000.00, 'лолфы', 10, 2, 1, 4, '/Content/productImgs/flowers.jpg', ''),
(5, 'КустарникиРозы', 15000.00, 'лолфы', 10, 2, 1, 5, '/Content/productImgs/flowers.jpg', ''),
(6, 'Альстромерия', 15000.00, 'лолфы', 10, 2, 1, 6, '/Content/productImgs/flowers.jpg', ''),
(7, 'Гвоздики', 15000.00, 'лолфы', 10, 2, 1, 7, '/Content/productImgs/flowers.jpg', ''),
(8, 'Георгины', 15000.00, 'лолфы', 10, 2, 1, 8, '/Content/productImgs/flowers.jpg', ''),
(9, 'Герберы', 15000.00, 'лолфы', 10, 2, 1, 9, '/Content/productImgs/flowers.jpg', ''),
(10, 'Гипсафила', 15000.00, 'лолфы', 10, 2, 1, 10, '/Content/productImgs/flowers.jpg', ''),
(11, 'Калла', 15000.00, 'лолфы', 10, 2, 1, 11, '/Content/productImgs/flowers.jpg', ''),
(12, 'Ирисы', 15000.00, 'лолфы', 10, 2, 1, 12, '/Content/productImgs/flowers.jpg', ''),
(13, 'Эндиши', 15000.00, 'лолфы', 10, 2, 1, 13, '/Content/productImgs/flowers.jpg', ''),
(14, 'Эндиши', 15000.00, 'лолфы', 10, 2, 1, 14, '/Content/productImgs/flowers.jpg', ''),
(15, 'Лилии', 15000.00, 'лолфы', 10, 2, 1, 15, '/Content/productImgs/flowers.jpg', ''),
(16, 'Орхидеи', 15000.00, 'лолфы', 10, 2, 1, 16, '/Content/productImgs/flowers.jpg', ''),
(17, 'Подсолнухи', 15000.00, 'лолфы', 10, 2, 1, 17, '/Content/productImgs/flowers.jpg', ''),
(18, 'Лютик', 15000.00, 'лолфы', 10, 2, 1, 18, '/Content/productImgs/flowers.jpg', ''),
(19, 'Ромашки', 15000.00, 'лолфы', 10, 2, 1, 19, '/Content/productImgs/flowers.jpg', ''),
(20, 'Сирень', 15000.00, 'лолфы', 10, 2, 1, 20, '/Content/productImgs/flowers.jpg', ''),
(21, 'Сушеные цветы', 15000.00, 'лолфы', 10, 2, 1, 21, '/Content/productImgs/flowers.jpg', ''),
(22, 'Хризантемы', 15000.00, 'лолфы', 10, 2, 1, 22, '/Content/productImgs/flowers.jpg', ''),
(23, 'Антуриумы', 15000.00, 'лолфы', 10, 2, 1, 23, '/Content/productImgs/flowers.jpg', ''),
(24, 'Амариллис', 15000.00, 'лолфы', 10, 2, 1, 24, '/Content/productImgs/flowers.jpg', ''),
(25, 'гладиолусы', 15000.00, 'лолфы', 10, 2, 1, 25, '/Content/productImgs/flowers.jpg', ''),
(26, 'Лизиантус', 15000.00, 'лолфы', 10, 2, 1, 26, '/Content/productImgs/flowers.jpg', ''),
(27, 'Ландыши', 15000.00, 'лолфы', 10, 2, 1, 27, '/Content/productImgs/flowers.jpg', '');

-- --------------------------------------------------------

--
-- Структура таблицы `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20231103153616_init', '3.1.32'),
('20231103161521_addRows', '3.1.32'),
('20231119151728_addOrderTable', '3.1.32'),
('20231219155417_row', '3.1.32');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `orders`
--
ALTER TABLE `orders`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `products`
--
ALTER TABLE `products`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

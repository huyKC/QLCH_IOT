-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th7 09, 2021 lúc 08:15 PM
-- Phiên bản máy phục vụ: 10.4.10-MariaDB
-- Phiên bản PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `qlch`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `card`
--

CREATE TABLE `card` (
  `ID` varchar(20) NOT NULL,
  `Status` varchar(10) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `card`
--

INSERT INTO `card` (`ID`, `Status`) VALUES
('1111111', '1'),
('1111112', '1'),
('1111113', '1'),
('1111114', '1'),
('1111115', '1'),
('1111116', '1'),
('1111117', '1'),
('1111118', '1'),
('1111119', '1'),
('1111120', '1'),
('1111121', '1'),
('1111122', '1'),
('1111123', '1'),
('1111124', '1'),
('1111125', '0'),
('1111126', '1');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `carinout`
--

CREATE TABLE `carinout` (
  `ID` varchar(20) NOT NULL,
  `Type` varchar(10) NOT NULL,
  `Time` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `carinout`
--

INSERT INTO `carinout` (`ID`, `Type`, `Time`) VALUES
('1111111', 'IN', '2021-07-09 23:16:23'),
('1111111', 'IN', '2021-07-09 23:17:15'),
('1111111', 'OUT', '2021-07-09 23:16:15'),
('1111113', 'IN', '2021-07-09 23:21:37'),
('1111113', 'OUT', '2021-07-09 23:21:08'),
('1111126', 'IN', '2021-07-10 00:13:58'),
('1111126', 'OUT', '2021-07-10 00:14:07');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `contract`
--

CREATE TABLE `contract` (
  `C_ID` int(100) NOT NULL,
  `Room` varchar(10) NOT NULL,
  `Cmnd` varchar(10) NOT NULL,
  `Start_Day` varchar(100) NOT NULL,
  `End_Date` varchar(100) NOT NULL,
  `Status` varchar(10) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `contract`
--

INSERT INTO `contract` (`C_ID`, `Room`, `Cmnd`, `Start_Day`, `End_Date`, `Status`) VALUES
(41412222, 'A110', 'A110', 'x', 'x', '1'),
(41412223, 'A111', 'A111', 'x', 'x', '1'),
(41412224, 'A112', 'A112', 'x', 'x', '1'),
(41412225, 'B110', 'B110', 'x', 'x', '1'),
(41412226, 'B111', 'B111', 'x', 'x', '1'),
(41412227, 'C110', 'C110', 'x', 'x', '1'),
(41412228, 'un_use', 'un_use', 'x', 'x', '1'),
(41412231, 'A110', '1999', '7/9/2021 10:27:43 PM', '7/18/2021 10:27:43 PM', '0'),
(41412232, 'A110', '2000', '7/9/2021 10:27:43 PM', '7/23/2021 10:27:43 PM', '0'),
(41412233, 'C110', '2000', '7/10/2021 12:11:13 AM', '7/15/2021 12:11:13 AM', '0'),
(41412234, 'C110', '2001', '7/10/2021 12:23:26 AM', '7/22/2021 12:23:26 AM', '0'),
(41412235, 'C110', '2002', '7/10/2021 12:25:54 AM', '7/10/2021 12:25:54 AM', '0'),
(41412236, 'C110', '214', '7/10/2021 12:25:54 AM', '7/24/2021 12:25:54 AM', '0'),
(41412237, 'A110', '2000', '7/10/2021 12:37:54 AM', '7/31/2021 12:37:54 AM', '0');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `guest`
--

CREATE TABLE `guest` (
  `CMND` varchar(20) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `sdt` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `guest`
--

INSERT INTO `guest` (`CMND`, `firstname`, `lastname`, `sdt`) VALUES
('1999', 'K', 'H', '1115'),
('2000', 'A', 'B', '11113'),
('2001', 'X', 'Y', '974631'),
('2002', 'f', 'a', '214'),
('214', 'áafas', 'àdgsdg', '124124'),
('A110', 'x', 'x', 'x'),
('A111', 'x', 'x', 'x'),
('A112', 'x', 'x', 'x'),
('B110', 'x', 'x', 'x'),
('B111', 'x', 'x', 'x'),
('C110', 'x', 'x', 'x'),
('un_use', 'x', 'x', 'x');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `guest_hold_card`
--

CREATE TABLE `guest_hold_card` (
  `Card` varchar(20) NOT NULL,
  `CMND` varchar(10) NOT NULL DEFAULT 'x',
  `Status` varchar(10) NOT NULL DEFAULT '1',
  `stt` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `guest_hold_card`
--

INSERT INTO `guest_hold_card` (`Card`, `CMND`, `Status`, `stt`) VALUES
('1111111', '1999', '0', 1),
('1111111', 'x', '1', 2),
('1111112', 'x', '1', 3),
('1111113', '2000', '0', 4),
('1111113', '2000', '0', 5),
('1111113', 'x', '1', 6),
('1111114', 'x', '1', 7),
('1111115', 'x', '1', 8),
('1111116', 'x', '1', 9),
('1111117', 'x', '1', 10),
('1111118', 'x', '1', 11),
('1111119', 'x', '1', 12),
('1111120', 'x', '1', 13),
('1111121', 'x', '1', 14),
('1111122', '214', '0', 15),
('1111122', 'x', '1', 16),
('1111123', '2002', '0', 17),
('1111123', 'x', '1', 18),
('1111124', '2001', '0', 19),
('1111124', 'x', '1', 20),
('1111125', 'x', '1', 21),
('1111126', '2000', '0', 22),
('1111126', 'x', '1', 23);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roomin`
--

CREATE TABLE `roomin` (
  `ID` varchar(20) NOT NULL,
  `Room` varchar(10) NOT NULL,
  `Time` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `roomin`
--

INSERT INTO `roomin` (`ID`, `Room`, `Time`) VALUES
('1111111', 'A110', '2021-07-09 23:52:54'),
('1111126', 'C110', '2021-07-10 00:14:21');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roominfo`
--

CREATE TABLE `roominfo` (
  `RoomID` varchar(10) NOT NULL,
  `RoomType` varchar(10) NOT NULL,
  `RoomStatus` varchar(10) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `roominfo`
--

INSERT INTO `roominfo` (`RoomID`, `RoomType`, `RoomStatus`) VALUES
('A110', '2 người', '0'),
('A111', '2 người', '0'),
('A112', '2 người', '0'),
('B110', '4 người', '0'),
('B111', '4 người', '0'),
('C110', '6 người', '0'),
('un_use', '2 người', '0');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roomscardsvalid`
--

CREATE TABLE `roomscardsvalid` (
  `RoomID` varchar(10) NOT NULL DEFAULT 'un_use',
  `CardID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `roomscardsvalid`
--

INSERT INTO `roomscardsvalid` (`RoomID`, `CardID`) VALUES
('A110', '1111111'),
('A110', '1111113'),
('A111', '1111112'),
('A111', '1111114'),
('A112', '1111115'),
('A112', '1111116'),
('B110', '1111117'),
('B110', '1111118'),
('B110', '1111119'),
('B110', '1111120'),
('C110', '1111121'),
('C110', '1111122'),
('C110', '1111123'),
('C110', '1111124'),
('C110', '1111126'),
('un_use', '1111125');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `card`
--
ALTER TABLE `card`
  ADD PRIMARY KEY (`ID`);

--
-- Chỉ mục cho bảng `carinout`
--
ALTER TABLE `carinout`
  ADD PRIMARY KEY (`ID`,`Type`,`Time`);

--
-- Chỉ mục cho bảng `contract`
--
ALTER TABLE `contract`
  ADD PRIMARY KEY (`C_ID`),
  ADD KEY `contract_belong_room` (`Room`),
  ADD KEY `contract_of_guest` (`Cmnd`);

--
-- Chỉ mục cho bảng `guest`
--
ALTER TABLE `guest`
  ADD PRIMARY KEY (`CMND`) USING BTREE;

--
-- Chỉ mục cho bảng `guest_hold_card`
--
ALTER TABLE `guest_hold_card`
  ADD PRIMARY KEY (`stt`);

--
-- Chỉ mục cho bảng `roomin`
--
ALTER TABLE `roomin`
  ADD PRIMARY KEY (`ID`,`Room`,`Time`);

--
-- Chỉ mục cho bảng `roominfo`
--
ALTER TABLE `roominfo`
  ADD PRIMARY KEY (`RoomID`);

--
-- Chỉ mục cho bảng `roomscardsvalid`
--
ALTER TABLE `roomscardsvalid`
  ADD PRIMARY KEY (`RoomID`,`CardID`),
  ADD KEY `Card_belong_room` (`CardID`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `contract`
--
ALTER TABLE `contract`
  MODIFY `C_ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41412238;

--
-- AUTO_INCREMENT cho bảng `guest_hold_card`
--
ALTER TABLE `guest_hold_card`
  MODIFY `stt` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `carinout`
--
ALTER TABLE `carinout`
  ADD CONSTRAINT `Card_valid` FOREIGN KEY (`ID`) REFERENCES `card` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Các ràng buộc cho bảng `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `contract_belong_room` FOREIGN KEY (`Room`) REFERENCES `roominfo` (`RoomID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `contract_of_guest` FOREIGN KEY (`Cmnd`) REFERENCES `guest` (`CMND`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `roomin`
--
ALTER TABLE `roomin`
  ADD CONSTRAINT `Id_correct` FOREIGN KEY (`ID`) REFERENCES `roomscardsvalid` (`CardID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Các ràng buộc cho bảng `roomscardsvalid`
--
ALTER TABLE `roomscardsvalid`
  ADD CONSTRAINT `Card_belong_room` FOREIGN KEY (`CardID`) REFERENCES `card` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `room_have_card` FOREIGN KEY (`RoomID`) REFERENCES `roominfo` (`RoomID`) ON DELETE NO ACTION ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

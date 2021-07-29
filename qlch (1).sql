-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th7 29, 2021 lúc 01:21 PM
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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `carinout`
--

CREATE TABLE `carinout` (
  `stt` int(200) NOT NULL,
  `ID` varchar(20) NOT NULL,
  `Types` varchar(10) NOT NULL,
  `Time` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `contract`
--

CREATE TABLE `contract` (
  `C_ID` int(100) NOT NULL,
  `Room` varchar(10) NOT NULL,
  `Cmnd` varchar(10) NOT NULL,
  `Start_Date` varchar(100) NOT NULL,
  `End_Date` varchar(100) NOT NULL,
  `Status` varchar(10) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roomin`
--

CREATE TABLE `roomin` (
  `stt` int(200) NOT NULL,
  `ID` varchar(20) NOT NULL,
  `Room` varchar(10) NOT NULL,
  `Time` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roominfo`
--

CREATE TABLE `roominfo` (
  `RoomID` varchar(10) NOT NULL,
  `RoomType` varchar(10) NOT NULL,
  `RoomStatus` varchar(10) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `roomscardsvalid`
--

CREATE TABLE `roomscardsvalid` (
  `RoomID` varchar(10) NOT NULL DEFAULT 'un_use',
  `CardID` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

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
  ADD PRIMARY KEY (`stt`),
  ADD KEY `Card_valid` (`ID`);

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
  ADD PRIMARY KEY (`stt`);

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
-- AUTO_INCREMENT cho bảng `carinout`
--
ALTER TABLE `carinout`
  MODIFY `stt` int(200) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `contract`
--
ALTER TABLE `contract`
  MODIFY `C_ID` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `guest_hold_card`
--
ALTER TABLE `guest_hold_card`
  MODIFY `stt` int(200) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `roomin`
--
ALTER TABLE `roomin`
  MODIFY `stt` int(200) NOT NULL AUTO_INCREMENT;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `contract`
--
ALTER TABLE `contract`
  ADD CONSTRAINT `contract_belong_room` FOREIGN KEY (`Room`) REFERENCES `roominfo` (`RoomID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `contract_of_guest` FOREIGN KEY (`Cmnd`) REFERENCES `guest` (`CMND`) ON DELETE NO ACTION ON UPDATE CASCADE;

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

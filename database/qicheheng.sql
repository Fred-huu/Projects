-- phpMyAdmin SQL Dump
-- version 4.0.10deb1
-- http://www.phpmyadmin.net
--
-- 主机: localhost
-- 生成日期: 2016-04-08 20:02:43
-- 服务器版本: 5.5.47-0ubuntu0.14.04.1
-- PHP 版本: 5.5.9-1ubuntu4.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- 数据库: `qicheheng`
--

-- --------------------------------------------------------

--
-- 表的结构 `car`
--

CREATE TABLE IF NOT EXISTS `car` (
  `carnum` varchar(10) NOT NULL,
  `model` varchar(10) NOT NULL,
  `photo` varchar(30) NOT NULL,
  `fload` int(10) NOT NULL,
  `pdtime` date NOT NULL,
  `remarks` text,
  PRIMARY KEY (`carnum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 表的结构 `driver`
--

CREATE TABLE IF NOT EXISTS `driver` (
  `driver_id` varchar(18) NOT NULL,
  `dpassword` varchar(20) NOT NULL,
  `carnum` varchar(10) NOT NULL,
  `name` varchar(10) NOT NULL,
  `bday` date NOT NULL,
  `dkind` text NOT NULL,
  `part` text NOT NULL,
  `telnum` varchar(11) NOT NULL,
  PRIMARY KEY (`driver_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 表的关联 `driver`:
--   `carnum`
--       `car` -> `carnum`
--

-- --------------------------------------------------------

--
-- 表的结构 `manage`
--

CREATE TABLE IF NOT EXISTS `manage` (
  `manage_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` varchar(10) NOT NULL,
  `carnum` varchar(10) CHARACTER SET utf8 NOT NULL,
  `kind` varchar(10) NOT NULL,
  `weight` int(10) NOT NULL,
  `time` datetime NOT NULL,
  `remarks` text,
  PRIMARY KEY (`manage_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=15 ;

--
-- 表的关联 `manage`:
--   `carnum`
--       `car` -> `carnum`
--   `user_id`
--       `users` -> `user_id`
--

-- --------------------------------------------------------

--
-- 表的结构 `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(10) NOT NULL,
  `user_id` varchar(10) NOT NULL,
  `password` varchar(40) NOT NULL,
  `perm` int(1) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

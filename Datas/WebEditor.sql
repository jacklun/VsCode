-- --------------------------------------------------------
-- 主机:                           127.0.0.1
-- 服务器版本:                        10.2.14-MariaDB - mariadb.org binary distribution
-- 服务器操作系统:                      Win64
-- HeidiSQL 版本:                  9.5.0.5272
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- 导出 webeditor 的数据库结构
CREATE DATABASE IF NOT EXISTS `webeditor` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `webeditor`;

-- 正在导出表  webeditor.artcategorys 的数据：0 rows
/*!40000 ALTER TABLE `artcategorys` DISABLE KEYS */;
INSERT INTO `artcategorys` (`id`, `aname`) VALUES
	(1, 'aaasd'),
	(2, 'zxczxc');
/*!40000 ALTER TABLE `artcategorys` ENABLE KEYS */;

-- 正在导出表  webeditor.articles 的数据：0 rows
/*!40000 ALTER TABLE `articles` DISABLE KEYS */;
INSERT INTO `articles` (`id`, `pname`, `description`, `priority`, `ArtCategoryid`, `UserRelationshipid`) VALUES
	(1, 'sfsdfsfsf', NULL, 2, 1, 2),
	(2, 'sdfgdfgdgdg', NULL, 2, 2, 2);
/*!40000 ALTER TABLE `articles` ENABLE KEYS */;

-- 正在导出表  webeditor.artreferenceimages 的数据：0 rows
/*!40000 ALTER TABLE `artreferenceimages` DISABLE KEYS */;
/*!40000 ALTER TABLE `artreferenceimages` ENABLE KEYS */;

-- 正在导出表  webeditor.companys 的数据：0 rows
/*!40000 ALTER TABLE `companys` DISABLE KEYS */;
/*!40000 ALTER TABLE `companys` ENABLE KEYS */;

-- 正在导出表  webeditor.industrys 的数据：0 rows
/*!40000 ALTER TABLE `industrys` DISABLE KEYS */;
/*!40000 ALTER TABLE `industrys` ENABLE KEYS */;

-- 正在导出表  webeditor.prodcategorys 的数据：0 rows
/*!40000 ALTER TABLE `prodcategorys` DISABLE KEYS */;
INSERT INTO `prodcategorys` (`id`, `tname`) VALUES
	(1, 'sdfsdf'),
	(2, 'wer');
/*!40000 ALTER TABLE `prodcategorys` ENABLE KEYS */;

-- 正在导出表  webeditor.products 的数据：0 rows
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` (`id`, `pname`, `description`, `price`, `discount`, `image_url`, `ProdCategoryId`, `UserRelationshipid`) VALUES
	(1, 'aaa', 'asd', 1.00, 1.00, NULL, 1, 2),
	(2, 'bbb', 'asd', 1.00, 1.00, NULL, 1, 2),
	(3, 'ccc', 'asd', 1.00, 1.00, NULL, 2, 2),
	(4, 'ddd', 'asd', 1.00, 1.00, NULL, 2, 2);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;

-- 正在导出表  webeditor.userartcategroys 的数据：0 rows
/*!40000 ALTER TABLE `userartcategroys` DISABLE KEYS */;
/*!40000 ALTER TABLE `userartcategroys` ENABLE KEYS */;

-- 正在导出表  webeditor.userbases 的数据：0 rows
/*!40000 ALTER TABLE `userbases` DISABLE KEYS */;
INSERT INTO `userbases` (`id`, `openid`, `uname`, `password`, `phone`) VALUES
	(1, NULL, 'admin', '123456', '123456'),
	(2, NULL, 'test', '123456', '123456');
/*!40000 ALTER TABLE `userbases` ENABLE KEYS */;

-- 正在导出表  webeditor.userdetials 的数据：0 rows
/*!40000 ALTER TABLE `userdetials` DISABLE KEYS */;
INSERT INTO `userdetials` (`id`, `openid`, `uname`, `password`, `nickname`, `phone`, `photo`, `signatureline`, `UserBaseId`) VALUES
	(1, NULL, 'admin', '123456', 'admin', '13456', NULL, NULL, 1),
	(2, NULL, 'test', '123456', 'admin', '13456', NULL, NULL, 2);
/*!40000 ALTER TABLE `userdetials` ENABLE KEYS */;

-- 正在导出表  webeditor.userfollowartcategorys 的数据：0 rows
/*!40000 ALTER TABLE `userfollowartcategorys` DISABLE KEYS */;
INSERT INTO `userfollowartcategorys` (`id`, `ArtCategoryid`, `UserRelationshipid`) VALUES
	(1, 1, 2),
	(2, 2, 2);
/*!40000 ALTER TABLE `userfollowartcategorys` ENABLE KEYS */;

-- 正在导出表  webeditor.userfollowprodcategorys 的数据：0 rows
/*!40000 ALTER TABLE `userfollowprodcategorys` DISABLE KEYS */;
INSERT INTO `userfollowprodcategorys` (`id`, `ProdCategoryid`, `UserRelationshipid`) VALUES
	(1, 1, 2),
	(2, 2, 2);
/*!40000 ALTER TABLE `userfollowprodcategorys` ENABLE KEYS */;

-- 正在导出表  webeditor.userimages 的数据：0 rows
/*!40000 ALTER TABLE `userimages` DISABLE KEYS */;
/*!40000 ALTER TABLE `userimages` ENABLE KEYS */;

-- 正在导出表  webeditor.userprodcategorys 的数据：0 rows
/*!40000 ALTER TABLE `userprodcategorys` DISABLE KEYS */;
/*!40000 ALTER TABLE `userprodcategorys` ENABLE KEYS */;

-- 正在导出表  webeditor.userrelationships 的数据：0 rows
/*!40000 ALTER TABLE `userrelationships` DISABLE KEYS */;
INSERT INTO `userrelationships` (`id`, `openid`, `uname`, `password`, `phone`, `UserBaseId`) VALUES
	(1, NULL, 'admin', '123456', '123456', 1),
	(2, NULL, 'test', '123456', '123456', 2);
/*!40000 ALTER TABLE `userrelationships` ENABLE KEYS */;

-- 正在导出表  webeditor.__efmigrationshistory 的数据：32 rows
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
	('20181120155954_aaa', '2.1.4-rtm-31024'),
	('20181120160308_bb', '2.1.4-rtm-31024'),
	('20181120160648_a', '2.1.4-rtm-31024'),
	('20181120161248_b', '2.1.4-rtm-31024'),
	('20181120161447_c', '2.1.4-rtm-31024'),
	('20181120161606_d', '2.1.4-rtm-31024'),
	('20181120161836_e', '2.1.4-rtm-31024'),
	('20181120162552_a', '2.1.4-rtm-31024'),
	('20181120162807_b', '2.1.4-rtm-31024'),
	('20181120162940_c', '2.1.4-rtm-31024'),
	('20181120163008_d', '2.1.4-rtm-31024'),
	('20181120163035_e', '2.1.4-rtm-31024'),
	('20181120163322_f', '2.1.4-rtm-31024'),
	('20181120163451_g', '2.1.4-rtm-31024'),
	('20181121035740_a', '2.1.4-rtm-31024'),
	('20181121040100_a', '2.1.4-rtm-31024'),
	('20181122032318_aa', '2.1.4-rtm-31024'),
	('20181122070315_a', '2.1.4-rtm-31024'),
	('20181122070737_b', '2.1.4-rtm-31024'),
	('20181122071617_c', '2.1.4-rtm-31024'),
	('20181122072009_a', '2.1.4-rtm-31024'),
	('20181122072334_b', '2.1.4-rtm-31024'),
	('20181122072746_c', '2.1.4-rtm-31024'),
	('20181122073825_d', '2.1.4-rtm-31024'),
	('20181122073848_e', '2.1.4-rtm-31024'),
	('20181122074346_f', '2.1.4-rtm-31024'),
	('20181122074708_a', '2.1.4-rtm-31024'),
	('20181122081433_a', '2.1.4-rtm-31024'),
	('20181123035718_a', '2.1.4-rtm-31024'),
	('20181123070115_a', '2.1.4-rtm-31024'),
	('20181123073333_b', '2.1.4-rtm-31024'),
	('20181123073618_a', '2.1.4-rtm-31024');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

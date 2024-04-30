-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.3.0 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.6.0.6765
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for db_ims
CREATE DATABASE IF NOT EXISTS `db_ims` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_ims`;

-- Dumping structure for table db_ims.agency_table
CREATE TABLE IF NOT EXISTS `agency_table` (
  `agency_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  `cluster_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`agency_id`),
  UNIQUE KEY `agency_title` (`title`) USING BTREE,
  UNIQUE KEY `agency_code` (`code`) USING BTREE,
  KEY `cluster_code` (`cluster_code`),
  CONSTRAINT `FK_agency_table_cluster_table` FOREIGN KEY (`cluster_code`) REFERENCES `cluster_table` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.agency_table: ~9 rows (approximately)
INSERT INTO `agency_table` (`agency_id`, `code`, `title`, `description`, `cluster_code`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(1, 'AGY000000001', 'Department of Trade and Industries 5', 'sadasdasdsad', 'CLU000000002', 0, 'james', '2024-04-01 14:55:25', 'james', '2024-04-06 13:52:34'),
	(3, 'AGY000000002', 'Department of Education', '', 'CLU000000001', 0, 'james', '2024-04-02 10:41:08', NULL, NULL),
	(4, 'AGY000000003', 'Department of Agriculture 23', 'Help', 'CLU000000002', 1, 'james', '2024-04-02 10:42:03', 'james', '2024-04-06 15:30:11'),
	(5, 'AGY000000004', 'ate mo', 'fsfsga', 'CLU000000001', 0, 'james', '2024-04-02 15:14:17', NULL, NULL),
	(6, 'AGY000000005', 'Department of Public Works and Highways', 'Help', 'CLU000000001', 1, 'james', '2024-04-06 10:45:20', NULL, NULL),
	(11, 'AGY000000006', 'asdasd', 'asdas', 'CLU000000002', 0, 'james', '2024-04-06 13:27:37', 'james', '2024-04-06 14:05:27'),
	(14, 'AGY000000007', 'Testasdasdasd', 'kjhgf', 'CLU000000001', 0, 'james', '2024-04-06 13:33:29', 'james', '2024-04-15 16:20:31'),
	(16, 'AGY000000008', 'asdasdasdascsdvxcbv', 'asdasd', 'CLU000000001', 0, 'james', '2024-04-06 13:51:09', NULL, NULL),
	(18, 'AGY000000009', 'asdasdas', 'asdasdasdasdasdasdasd', 'CLU000000002', 0, 'james', '2024-04-06 13:52:23', NULL, NULL);

-- Dumping structure for table db_ims.cluster_table
CREATE TABLE IF NOT EXISTS `cluster_table` (
  `cluster_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  `sector_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `status` int NOT NULL DEFAULT (1),
  `created_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`cluster_id`),
  UNIQUE KEY `cluster_title` (`title`) USING BTREE,
  UNIQUE KEY `code` (`code`),
  KEY `sector_id` (`sector_code`) USING BTREE,
  CONSTRAINT `FK_cluster_table_sector_table` FOREIGN KEY (`sector_code`) REFERENCES `sector_table` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.cluster_table: ~4 rows (approximately)
INSERT INTO `cluster_table` (`cluster_id`, `code`, `title`, `description`, `sector_code`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(1, 'CLU000000001', 'CLUSTER A', NULL, 'SEC000000001', 1, 'admin', '2024-03-31 16:47:22', NULL, NULL),
	(2, 'CLU000000002', 'CLUSTER B', NULL, 'SEC000000001', 0, 'admin', '2024-03-31 17:59:19', NULL, NULL),
	(6, 'CLU000000003', 'test', 'qtedfddf', 'SEC000000001', 0, 'james', '2024-04-02 14:28:18', NULL, NULL),
	(7, 'CLU000000004', 'ate mo', 'gsdgzxd', 'SEC000000001', 0, 'james', '2024-04-02 15:14:26', NULL, NULL);

-- Dumping structure for table db_ims.code_table
CREATE TABLE IF NOT EXISTS `code_table` (
  `id` int NOT NULL AUTO_INCREMENT,
  `module` text NOT NULL,
  `table` varchar(20) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL DEFAULT '',
  `code` varchar(3) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `num_length` varchar(1) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `initial_num` int NOT NULL DEFAULT (1),
  PRIMARY KEY (`id`),
  UNIQUE KEY `table` (`table`),
  UNIQUE KEY `code` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.code_table: ~13 rows (approximately)
INSERT INTO `code_table` (`id`, `module`, `table`, `code`, `num_length`, `initial_num`) VALUES
	(1, 'EMPLOYEE', 'emp_info_table', 'EMP', '9', 1),
	(2, 'AGENCY', 'agency_table', 'AGY', '9', 1),
	(3, 'CLUSTER', 'cluster_table', 'CLU', '9', 1),
	(4, 'CONTRACTOR', 'contractor_table', 'CTR', '9', 1),
	(5, 'DIVISION', 'division_table', 'DIV', '9', 1),
	(6, 'NATURE', 'nature_table', 'NAT', '9', 1),
	(7, 'OFFICE', 'office_table', 'OFC', '9', 1),
	(8, 'POSITION', 'position_table', 'POS', '9', 1),
	(9, 'PROJECTS', 'remarks_table', 'RMK', '9', 1),
	(10, 'SECTION', 'section_table', 'SXN', '9', 1),
	(11, 'SECTOR', 'sector_table', 'SEC', '9', 1),
	(12, 'STATUS', 'status_table', 'STS', '9', 1),
	(13, 'HISTORY', 'history_table', 'HIS', '9', 1);

-- Dumping structure for table db_ims.contractor_table
CREATE TABLE IF NOT EXISTS `contractor_table` (
  `contractor_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`contractor_id`),
  UNIQUE KEY `contractor_title` (`title`) USING BTREE,
  UNIQUE KEY `code` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.contractor_table: ~3 rows (approximately)
INSERT INTO `contractor_table` (`contractor_id`, `code`, `title`, `description`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(1, 'CTR000000001', 'testtt', '12swadsadfds', 1, 'james', '2024-04-02 14:34:43', NULL, NULL),
	(2, 'CTR000000002', 'ate mo', 'fasFda', 1, 'james', '2024-04-02 15:14:33', NULL, NULL),
	(3, 'CTR000000003', 'John Michael Candelaria', 'HOR', 1, 'james', '2024-04-15 08:45:49', NULL, NULL);

-- Dumping structure for table db_ims.division_table
CREATE TABLE IF NOT EXISTS `division_table` (
  `division_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text,
  `office_code` varchar(12) NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`division_id`) USING BTREE,
  UNIQUE KEY `divison_title` (`title`) USING BTREE,
  UNIQUE KEY `code` (`code`),
  KEY `office_code` (`office_code`),
  CONSTRAINT `FK_division_table_office_table` FOREIGN KEY (`office_code`) REFERENCES `office_table` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.division_table: ~2 rows (approximately)
INSERT INTO `division_table` (`division_id`, `code`, `title`, `description`, `office_code`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(3, 'DIV000000001', 'DIVISION A', NULL, 'OFC000000001', 1, 'james', '2024-04-02 09:55:30', NULL, NULL),
	(4, 'DIV000000002', 'ate mo', 'vasdfcadsc', 'OFC000000001', 1, 'james', '2024-04-02 15:14:39', NULL, NULL);

-- Dumping structure for table db_ims.docu_info_table
CREATE TABLE IF NOT EXISTS `docu_info_table` (
  `document_id` int NOT NULL AUTO_INCREMENT,
  `document_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `document_no` varchar(50) NOT NULL,
  `amount` float NOT NULL,
  `title` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `period` datetime NOT NULL,
  `subject` text NOT NULL,
  `receiveing_date` datetime NOT NULL,
  PRIMARY KEY (`document_id`) USING BTREE,
  UNIQUE KEY `document_no` (`document_no`),
  UNIQUE KEY `document_code` (`document_code`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.docu_info_table: ~0 rows (approximately)
INSERT INTO `docu_info_table` (`document_id`, `document_code`, `document_no`, `amount`, `title`, `period`, `subject`, `receiveing_date`) VALUES
	(1, '1', '1', 1000, 'Payment', '2024-04-08 00:00:00', 'To pay, or not to pay', '2024-04-08 00:00:00');

-- Dumping structure for table db_ims.docu_transaction_table
CREATE TABLE IF NOT EXISTS `docu_transaction_table` (
  `transaction_id` int NOT NULL AUTO_INCREMENT,
  `document_code` varchar(12) NOT NULL,
  `sector_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `contractor_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `division_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `nature_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `remarks_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `employee_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `history_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `status_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `filed_date` datetime NOT NULL,
  PRIMARY KEY (`transaction_id`),
  KEY `document_code` (`document_code`),
  KEY `sector_code` (`sector_code`),
  KEY `contractor_code` (`contractor_code`),
  KEY `division_code` (`division_code`),
  KEY `nature_code` (`nature_code`),
  KEY `remarks_code` (`remarks_code`),
  KEY `employee_code` (`employee_code`),
  KEY `history_code` (`history_code`),
  KEY `status_code` (`status_code`),
  CONSTRAINT `FK_docu_transaction_table_contractor_table` FOREIGN KEY (`contractor_code`) REFERENCES `contractor_table` (`code`),
  CONSTRAINT `FK_docu_transaction_table_division_table` FOREIGN KEY (`division_code`) REFERENCES `division_table` (`code`),
  CONSTRAINT `FK_docu_transaction_table_docu_info_table` FOREIGN KEY (`document_code`) REFERENCES `docu_info_table` (`document_code`),
  CONSTRAINT `FK_docu_transaction_table_nature_table` FOREIGN KEY (`nature_code`) REFERENCES `nature_table` (`code`),
  CONSTRAINT `FK_docu_transaction_table_position_table` FOREIGN KEY (`remarks_code`) REFERENCES `position_table` (`code`),
  CONSTRAINT `FK_docu_transaction_table_sector_table` FOREIGN KEY (`sector_code`) REFERENCES `sector_table` (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.docu_transaction_table: ~0 rows (approximately)

-- Dumping structure for table db_ims.emp_info_table
CREATE TABLE IF NOT EXISTS `emp_info_table` (
  `emp_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `full_name` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `email` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `contact_no` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `section_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `position_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`emp_id`),
  UNIQUE KEY `employee_no` (`code`) USING BTREE,
  KEY `section_code` (`section_code`),
  KEY `position_code` (`position_code`),
  CONSTRAINT `FK_emp_info_table_position_table` FOREIGN KEY (`position_code`) REFERENCES `position_table` (`code`),
  CONSTRAINT `FK_emp_info_table_section_table` FOREIGN KEY (`section_code`) REFERENCES `section_table` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.emp_info_table: ~3 rows (approximately)
INSERT INTO `emp_info_table` (`emp_id`, `code`, `full_name`, `email`, `contact_no`, `section_code`, `position_code`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(2, 'EMPL00000001', 'James', 'jmaes', '0920', 'SXN000000003', 'POS000000002', 1, 'james', '2024-03-23 18:52:02', NULL, NULL),
	(3, 'EMPL00000002', 'James', 'sadas', 'sadasd', 'SXN000000003', 'POS000000001', 1, 'james', '2024-03-25 13:39:24', NULL, NULL),
	(4, 'EMPL00000003', 'Christian James R.Vinas', 'jamesvinas09@gmail.com', '09208902063', 'SXN000000003', 'POS000000002', 1, 'james', '2024-04-06 19:39:24', NULL, NULL);

-- Dumping structure for table db_ims.history_table
CREATE TABLE IF NOT EXISTS `history_table` (
  `history_id` int NOT NULL,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `date` datetime NOT NULL,
  `instruction` longtext NOT NULL,
  PRIMARY KEY (`history_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.history_table: ~0 rows (approximately)

-- Dumping structure for table db_ims.items_table
CREATE TABLE IF NOT EXISTS `items_table` (
  `item_code` varchar(50) NOT NULL DEFAULT '',
  `item_desc_id` varchar(50) NOT NULL,
  `unit_id` int NOT NULL,
  `unit_cost` double NOT NULL DEFAULT (0),
  `est_useful_life` int NOT NULL,
  `quantity` int NOT NULL,
  `added_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL DEFAULT '',
  `date_added` datetime NOT NULL DEFAULT (now()),
  `date_modified` datetime DEFAULT NULL,
  `modified_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`item_code`),
  KEY `FK_items_table_item_desc_table` (`item_desc_id`),
  KEY `FK_items_table_item_unit_table` (`unit_id`),
  KEY `FK_items_table_user_info_table` (`added_by`),
  KEY `FK_items_table_user_info_table_2` (`modified_by`),
  CONSTRAINT `FK_items_table_item_desc_table` FOREIGN KEY (`item_desc_id`) REFERENCES `item_desc_table` (`item_desc_id`),
  CONSTRAINT `FK_items_table_item_unit_table` FOREIGN KEY (`unit_id`) REFERENCES `item_unit_table` (`unit_id`),
  CONSTRAINT `FK_items_table_user_info_table` FOREIGN KEY (`added_by`) REFERENCES `user_info_table` (`user_name`),
  CONSTRAINT `FK_items_table_user_info_table_2` FOREIGN KEY (`modified_by`) REFERENCES `user_info_table` (`user_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.items_table: ~1 rows (approximately)
INSERT INTO `items_table` (`item_code`, `item_desc_id`, `unit_id`, `unit_cost`, `est_useful_life`, `quantity`, `added_by`, `date_added`, `date_modified`, `modified_by`, `status`) VALUES
	('456', '125', 2, 20, 5, 50, 'admin', '2024-04-30 13:44:35', NULL, NULL, 1),
	('721', 'I2CP640FEIXL', 2, 500, 5, 20, 'admin', '2024-04-30 16:10:12', NULL, NULL, 1);

-- Dumping structure for table db_ims.item_brand_table
CREATE TABLE IF NOT EXISTS `item_brand_table` (
  `item_brand_id` int NOT NULL AUTO_INCREMENT,
  `item_brand` text NOT NULL,
  `date_added` datetime NOT NULL DEFAULT (now()),
  `added_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL DEFAULT '',
  `updated_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `updated_date` datetime NOT NULL DEFAULT (now()) ON UPDATE CURRENT_TIMESTAMP,
  `status` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`item_brand_id`),
  KEY `FK_item_brand_table_user_info_table` (`updated_by`),
  KEY `FK_item_brand_table_db_ims.user_info_table` (`added_by`),
  CONSTRAINT `FK_item_brand_table_db_ims.user_info_table` FOREIGN KEY (`added_by`) REFERENCES `user_info_table` (`user_name`),
  CONSTRAINT `FK_item_brand_table_user_info_table` FOREIGN KEY (`updated_by`) REFERENCES `user_info_table` (`user_name`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.item_brand_table: ~3 rows (approximately)
INSERT INTO `item_brand_table` (`item_brand_id`, `item_brand`, `date_added`, `added_by`, `updated_by`, `updated_date`, `status`) VALUES
	(19, 'Lenovo', '2024-04-29 14:46:29', 'admin', NULL, '2024-04-29 14:46:29', 1),
	(20, 'Intel', '2024-04-29 14:47:01', 'admin', NULL, '2024-04-29 14:47:01', 1),
	(21, 'ASUS', '2024-04-30 10:00:21', 'admin', NULL, '2024-04-30 10:00:21', 1);

-- Dumping structure for table db_ims.item_brand_type_af_table
CREATE TABLE IF NOT EXISTS `item_brand_type_af_table` (
  `item_brand_type_af_id` int NOT NULL AUTO_INCREMENT,
  `item_brand_id` int NOT NULL DEFAULT '0',
  `item_type_id` int NOT NULL DEFAULT '0',
  `updated_by` varchar(50) NOT NULL DEFAULT '',
  `updated_date` datetime NOT NULL DEFAULT (now()) ON UPDATE CURRENT_TIMESTAMP,
  `status` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`item_brand_type_af_id`),
  KEY `FK_item_brand_type_af_table_item_brand_table` (`item_brand_id`),
  KEY `FK_item_brand_type_af_table_item_type_table` (`item_type_id`),
  KEY `FK_item_brand_type_af_table_user_info_table` (`updated_by`),
  CONSTRAINT `FK_item_brand_type_af_table_item_brand_table` FOREIGN KEY (`item_brand_id`) REFERENCES `item_brand_table` (`item_brand_id`),
  CONSTRAINT `FK_item_brand_type_af_table_item_type_table` FOREIGN KEY (`item_type_id`) REFERENCES `item_type_table` (`item_type_id`),
  CONSTRAINT `FK_item_brand_type_af_table_user_info_table` FOREIGN KEY (`updated_by`) REFERENCES `user_info_table` (`user_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.item_brand_type_af_table: ~0 rows (approximately)

-- Dumping structure for table db_ims.item_desc_table
CREATE TABLE IF NOT EXISTS `item_desc_table` (
  `item_desc_id` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `item_type_id` int NOT NULL DEFAULT (0),
  `item_brand_id` int NOT NULL DEFAULT (0),
  `product_name` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`item_desc_id`),
  KEY `FK_item_desc_table_item_type_table` (`item_type_id`),
  KEY `FK_item_desc_table_item_brand_table` (`item_brand_id`),
  CONSTRAINT `FK_item_desc_table_item_brand_table` FOREIGN KEY (`item_brand_id`) REFERENCES `item_brand_table` (`item_brand_id`),
  CONSTRAINT `FK_item_desc_table_item_type_table` FOREIGN KEY (`item_type_id`) REFERENCES `item_type_table` (`item_type_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.item_desc_table: ~4 rows (approximately)
INSERT INTO `item_desc_table` (`item_desc_id`, `item_type_id`, `item_brand_id`, `product_name`) VALUES
	('123', 16, 21, 'WT300'),
	('124', 16, 21, 'WT300'),
	('125', 16, 21, 'WT300'),
	('I2CP640FEIXL', 16, 21, 'Wireless Mouse');

-- Dumping structure for table db_ims.item_supplier_af_table
CREATE TABLE IF NOT EXISTS `item_supplier_af_table` (
  `item_supplier_af_code` int NOT NULL AUTO_INCREMENT,
  `item_code` varchar(50) NOT NULL DEFAULT '0',
  `supplier_id` int NOT NULL DEFAULT '0',
  `updated_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL DEFAULT '',
  `updated_date` datetime NOT NULL DEFAULT (now()) ON UPDATE CURRENT_TIMESTAMP,
  `status` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`item_supplier_af_code`),
  KEY `FK_item_supplier_af_table_item_supplier_table` (`supplier_id`),
  KEY `FK_item_supplier_af_table_items_table` (`item_code`),
  KEY `FK_item_supplier_af_table_user_info_table` (`updated_by`),
  CONSTRAINT `FK_item_supplier_af_table_item_supplier_table` FOREIGN KEY (`supplier_id`) REFERENCES `item_supplier_table` (`supplier_id`),
  CONSTRAINT `FK_item_supplier_af_table_items_table` FOREIGN KEY (`item_code`) REFERENCES `items_table` (`item_code`),
  CONSTRAINT `FK_item_supplier_af_table_user_info_table` FOREIGN KEY (`updated_by`) REFERENCES `user_info_table` (`user_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.item_supplier_af_table: ~0 rows (approximately)

-- Dumping structure for table db_ims.item_supplier_table
CREATE TABLE IF NOT EXISTS `item_supplier_table` (
  `supplier_id` int NOT NULL AUTO_INCREMENT,
  `supplier_name` text NOT NULL,
  `supplier_address` text NOT NULL,
  `supplier_contact_num` text NOT NULL,
  `supplier_contact_person` text NOT NULL,
  `date_added` datetime NOT NULL DEFAULT (now()),
  `added_by` varchar(50) NOT NULL DEFAULT '',
  `date_modified` datetime DEFAULT NULL,
  `modified_by` varchar(50) DEFAULT NULL,
  `status` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`supplier_id`),
  KEY `FK_item_supplier_table_user_info_table` (`added_by`),
  KEY `FK_item_supplier_table_user_info_table_2` (`modified_by`),
  CONSTRAINT `FK_item_supplier_table_user_info_table` FOREIGN KEY (`added_by`) REFERENCES `user_info_table` (`user_name`),
  CONSTRAINT `FK_item_supplier_table_user_info_table_2` FOREIGN KEY (`modified_by`) REFERENCES `user_info_table` (`user_name`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.item_supplier_table: ~2 rows (approximately)
INSERT INTO `item_supplier_table` (`supplier_id`, `supplier_name`, `supplier_address`, `supplier_contact_num`, `supplier_contact_person`, `date_added`, `added_by`, `date_modified`, `modified_by`, `status`) VALUES
	(1, 'James & Co.', 'Quezon Ave.', '0900 000 0001', 'James Po', '2024-04-29 16:27:41', 'admin', NULL, NULL, 1),
	(2, 'D4C Ugay Limited', 'SM Fairview', '0900 000 0002', 'Clarence Ugay', '2024-04-29 16:40:01', 'admin', NULL, NULL, 1);

-- Dumping structure for table db_ims.item_type_table
CREATE TABLE IF NOT EXISTS `item_type_table` (
  `item_type_id` int NOT NULL AUTO_INCREMENT,
  `item_type` text NOT NULL,
  `updated_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL DEFAULT '',
  `updated_date` datetime NOT NULL DEFAULT (now()) ON UPDATE CURRENT_TIMESTAMP,
  `status` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`item_type_id`),
  KEY `FK_item_type_table_user_info_table` (`updated_by`),
  CONSTRAINT `FK_item_type_table_user_info_table` FOREIGN KEY (`updated_by`) REFERENCES `user_info_table` (`user_name`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.item_type_table: ~5 rows (approximately)
INSERT INTO `item_type_table` (`item_type_id`, `item_type`, `updated_by`, `updated_date`, `status`) VALUES
	(16, 'Mouse', 'admin', '2024-04-29 14:31:25', 1),
	(17, 'Laptop', 'admin', '2024-04-29 14:42:46', 1),
	(18, 'Comp. Desktop', 'admin', '2024-04-29 14:42:56', 1),
	(19, 'Tablet', 'admin', '2024-04-29 14:43:04', 1),
	(21, 'Mouse Pad', 'admin', '2024-04-30 09:59:25', 1);

-- Dumping structure for table db_ims.item_unit_table
CREATE TABLE IF NOT EXISTS `item_unit_table` (
  `unit_id` int NOT NULL AUTO_INCREMENT,
  `unit` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`unit_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.item_unit_table: ~3 rows (approximately)
INSERT INTO `item_unit_table` (`unit_id`, `unit`) VALUES
	(2, 'unit'),
	(3, 'ml'),
	(4, 'l');

-- Dumping structure for table db_ims.log_table
CREATE TABLE IF NOT EXISTS `log_table` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `activity` longtext NOT NULL,
  `activity_datetime` datetime NOT NULL,
  `activity_type` int NOT NULL,
  PRIMARY KEY (`log_id`) USING BTREE,
  KEY `user_name` (`user_name`) USING BTREE,
  CONSTRAINT `FK_log_table_user_info_table` FOREIGN KEY (`user_name`) REFERENCES `user_info_table` (`user_name`)
) ENGINE=InnoDB AUTO_INCREMENT=713 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.log_table: ~668 rows (approximately)
INSERT INTO `log_table` (`log_id`, `user_name`, `activity`, `activity_datetime`, `activity_type`) VALUES
	(1, 'admin', 'Logged In', '2024-03-31 15:14:46', 1),
	(12, 'admin', 'Logged Out', '2024-04-06 14:39:52', 1),
	(13, 'admin', 'Logged Out', '2024-04-06 15:05:31', 1),
	(14, 'admin', 'Logged Out', '2024-04-06 15:06:13', 1),
	(15, 'admin', 'Logged Out', '2024-04-06 15:13:23', 1),
	(16, 'admin', 'Logged Out', '2024-04-06 15:25:34', 1),
	(17, 'admin', 'Logged Out', '2024-04-06 15:26:47', 1),
	(18, 'admin', 'Logged Out', '2024-04-06 15:27:40', 1),
	(19, 'admin', 'Logged Out', '2024-04-06 15:30:51', 1),
	(20, 'admin', 'Logged Out', '2024-04-06 15:32:08', 1),
	(21, 'admin', 'Logged Out', '2024-04-06 15:41:39', 1),
	(22, 'admin', 'Logged Out', '2024-04-06 15:45:30', 1),
	(23, 'admin', 'Logged Out', '2024-04-06 15:49:59', 1),
	(24, 'admin', 'Logged Out', '2024-04-06 15:51:32', 1),
	(25, 'admin', 'Logged Out', '2024-04-06 15:52:35', 1),
	(26, 'admin', 'Logged Out', '2024-04-06 15:58:13', 1),
	(27, 'admin', 'Logged Out', '2024-04-06 16:01:06', 1),
	(28, 'admin', 'Logged Out', '2024-04-06 16:02:07', 1),
	(29, 'admin', 'Logged Out', '2024-04-06 16:27:32', 1),
	(30, 'admin', 'Logged Out', '2024-04-06 16:29:15', 1),
	(31, 'admin', 'Logged Out', '2024-04-06 16:30:22', 1),
	(32, 'admin', 'Logged Out', '2024-04-06 16:31:57', 1),
	(33, 'admin', 'Logged Out', '2024-04-06 16:33:13', 1),
	(34, 'admin', 'Logged Out', '2024-04-06 16:34:03', 1),
	(35, 'admin', 'Logged Out', '2024-04-06 16:36:40', 1),
	(36, 'admin', 'Logged Out', '2024-04-06 16:38:53', 1),
	(37, 'admin', 'Logged Out', '2024-04-06 19:26:52', 1),
	(38, 'admin', 'Logged Out', '2024-04-06 19:29:56', 1),
	(39, 'admin', 'Logged Out', '2024-04-06 19:31:12', 1),
	(40, 'admin', 'Logged Out', '2024-04-06 19:34:36', 1),
	(41, 'admin', 'Logged Out', '2024-04-06 19:37:56', 1),
	(42, 'admin', 'Logged Out', '2024-04-06 20:15:20', 1),
	(43, 'admin', 'Logged Out', '2024-04-06 20:17:37', 1),
	(44, 'admin', 'Logged Out', '2024-04-06 20:18:39', 1),
	(45, 'admin', 'Logged Out', '2024-04-06 20:19:44', 1),
	(46, 'admin', 'Logged Out', '2024-04-06 20:42:25', 1),
	(47, 'admin', 'Logged Out', '2024-04-06 20:43:58', 1),
	(48, 'admin', 'Logged Out', '2024-04-06 20:45:44', 1),
	(49, 'admin', 'Logged Out', '2024-04-06 20:47:21', 1),
	(50, 'admin', 'Logged Out', '2024-04-06 21:04:15', 1),
	(51, 'admin', 'Logged Out', '2024-04-06 21:27:21', 1),
	(52, 'admin', 'Logged Out', '2024-04-07 07:10:50', 1),
	(53, 'admin', 'Logged Out', '2024-04-07 07:12:01', 1),
	(54, 'admin', 'Logged Out', '2024-04-07 07:19:35', 1),
	(55, 'admin', 'Logged Out', '2024-04-07 07:28:16', 1),
	(56, 'admin', 'Logged Out', '2024-04-07 19:46:10', 1),
	(57, 'admin', 'Logged Out', '2024-04-07 19:48:32', 1),
	(58, 'admin', 'Logged Out', '2024-04-07 19:54:26', 1),
	(59, 'admin', 'Logged Out', '2024-04-07 19:55:01', 1),
	(60, 'admin', 'Logged Out', '2024-04-07 19:56:19', 1),
	(61, 'admin', 'Logged Out', '2024-04-07 19:58:29', 1),
	(62, 'admin', 'Logged Out', '2024-04-07 20:02:48', 1),
	(63, 'admin', 'Logged Out', '2024-04-07 20:04:52', 1),
	(64, 'admin', 'Logged Out', '2024-04-07 20:06:35', 1),
	(65, 'admin', 'Logged Out', '2024-04-07 20:20:58', 1),
	(66, 'admin', 'Logged Out', '2024-04-07 20:25:04', 1),
	(67, 'admin', 'Logged Out', '2024-04-07 20:26:12', 1),
	(68, 'admin', 'Logged Out', '2024-04-07 20:40:28', 1),
	(69, 'admin', 'Logged Out', '2024-04-07 20:41:50', 1),
	(70, 'admin', 'Logged Out', '2024-04-07 20:44:10', 1),
	(71, 'admin', 'Logged Out', '2024-04-07 21:14:21', 1),
	(72, 'admin', 'Logged Out', '2024-04-07 21:30:06', 1),
	(73, 'admin', 'Logged Out', '2024-04-07 21:35:36', 1),
	(74, 'admin', 'Logged Out', '2024-04-07 22:01:49', 1),
	(75, 'admin', 'Logged Out', '2024-04-07 22:08:57', 1),
	(76, 'admin', 'Logged Out', '2024-04-07 22:11:29', 1),
	(77, 'admin', 'Logged Out', '2024-04-07 22:16:44', 1),
	(78, 'admin', 'Logged Out', '2024-04-07 22:21:24', 1),
	(79, 'admin', 'Logged Out', '2024-04-07 22:25:49', 1),
	(80, 'admin', 'Logged Out', '2024-04-07 22:31:11', 1),
	(81, 'admin', 'Logged Out', '2024-04-07 22:36:18', 1),
	(82, 'admin', 'Logged Out', '2024-04-08 08:17:12', 1),
	(83, 'admin', 'Logged Out', '2024-04-08 09:13:36', 1),
	(84, 'admin', 'Logged Out', '2024-04-08 13:10:55', 1),
	(85, 'admin', 'Logged Out', '2024-04-11 08:09:34', 1),
	(86, 'admin', 'Logged Out', '2024-04-11 08:11:32', 1),
	(87, 'admin', 'Logged In', '2024-04-11 10:05:21', 1),
	(88, 'admin', 'Logged Out', '2024-04-11 10:05:34', 1),
	(89, 'admin', 'Logged In', '2024-04-11 10:05:39', 1),
	(90, 'admin', 'Logged In', '2024-04-11 10:17:31', 1),
	(91, 'admin', 'Logged Out', '2024-04-11 10:17:44', 1),
	(92, 'admin', 'Logged In', '2024-04-11 10:17:48', 1),
	(93, 'admin', 'Logged In', '2024-04-11 10:25:11', 1),
	(94, 'admin', 'Logged In', '2024-04-11 10:27:36', 1),
	(95, 'admin', 'Logged In', '2024-04-11 10:52:14', 1),
	(96, 'admin', 'Logged In', '2024-04-11 10:54:01', 1),
	(97, 'admin', 'Logged In', '2024-04-11 10:54:11', 1),
	(98, 'admin', 'Logged In', '2024-04-11 10:56:40', 1),
	(99, 'admin', 'Logged In', '2024-04-11 13:06:25', 1),
	(100, 'admin', 'Logged In', '2024-04-11 13:07:15', 1),
	(101, 'admin', 'Logged In', '2024-04-11 13:09:54', 1),
	(102, 'admin', 'Logged In', '2024-04-11 13:13:52', 1),
	(103, 'admin', 'Logged In', '2024-04-11 13:16:33', 1),
	(104, 'admin', 'Logged Out', '2024-04-11 13:16:40', 1),
	(105, 'admin', 'Logged In', '2024-04-11 13:34:01', 1),
	(106, 'admin', 'Logged Out', '2024-04-11 13:34:28', 1),
	(107, 'admin', 'Logged In', '2024-04-11 13:34:33', 1),
	(108, 'admin', 'Logged In', '2024-04-11 13:34:33', 1),
	(109, 'admin', 'Logged Out', '2024-04-11 13:34:36', 1),
	(110, 'admin', 'Logged Out', '2024-04-11 13:34:36', 1),
	(111, 'admin', 'Logged In', '2024-04-11 13:36:31', 1),
	(112, 'admin', 'Logged Out', '2024-04-11 13:40:12', 1),
	(113, 'admin', 'Logged In', '2024-04-11 13:50:08', 1),
	(114, 'admin', 'Logged Out', '2024-04-11 13:50:16', 1),
	(115, 'admin', 'Logged In', '2024-04-11 13:51:09', 1),
	(116, 'admin', 'Logged In', '2024-04-11 13:52:13', 1),
	(117, 'admin', 'Logged Out', '2024-04-11 13:52:32', 1),
	(118, 'admin', 'Logged In', '2024-04-11 13:53:12', 1),
	(119, 'admin', 'Logged Out', '2024-04-11 13:53:45', 1),
	(120, 'admin', 'Logged In', '2024-04-11 14:11:31', 1),
	(121, 'admin', 'Logged Out', '2024-04-11 14:17:11', 1),
	(122, 'admin', 'Logged In', '2024-04-11 14:20:45', 1),
	(123, 'admin', 'Logged In', '2024-04-11 14:25:50', 1),
	(124, 'admin', 'Logged Out', '2024-04-11 14:31:02', 1),
	(125, 'admin', 'Logged In', '2024-04-11 14:31:08', 1),
	(126, 'admin', 'Logged Out', '2024-04-11 14:31:53', 1),
	(127, 'admin', 'Logged In', '2024-04-11 14:31:58', 1),
	(128, 'admin', 'Logged Out', '2024-04-11 14:32:06', 1),
	(129, 'admin', 'Logged In', '2024-04-11 14:32:25', 1),
	(130, 'admin', 'Logged Out', '2024-04-11 14:32:59', 1),
	(131, 'admin', 'Logged In', '2024-04-11 14:57:26', 1),
	(132, 'admin', 'Logged Out', '2024-04-11 14:57:29', 1),
	(133, 'admin', 'Logged In', '2024-04-11 15:58:22', 1),
	(134, 'admin', 'Logged In', '2024-04-11 15:59:13', 1),
	(135, 'admin', 'Logged In', '2024-04-11 16:03:02', 1),
	(136, 'admin', 'Logged In', '2024-04-11 16:06:14', 1),
	(137, 'admin', 'Logged In', '2024-04-11 16:13:20', 1),
	(138, 'admin', 'Logged In', '2024-04-11 16:14:26', 1),
	(139, 'admin', 'Logged In', '2024-04-11 16:15:41', 1),
	(140, 'admin', 'Logged In', '2024-04-11 16:18:57', 1),
	(142, 'admin', 'Logged Out', '2024-04-11 16:24:29', 1),
	(143, 'admin', 'Logged In', '2024-04-11 16:27:56', 1),
	(144, 'admin', 'Logged Out', '2024-04-11 16:28:23', 1),
	(145, 'admin', 'Logged In', '2024-04-11 16:28:52', 1),
	(146, 'admin', 'Logged In', '2024-04-15 08:04:02', 1),
	(147, 'admin', 'Logged In', '2024-04-15 08:04:37', 1),
	(148, 'admin', 'Logged In', '2024-04-15 08:39:48', 1),
	(149, 'admin', 'Logged In', '2024-04-15 08:41:00', 1),
	(150, 'admin', 'Logged Out', '2024-04-15 08:42:54', 1),
	(151, 'admin', 'Logged In', '2024-04-15 08:44:33', 1),
	(153, 'admin', 'Logged In', '2024-04-15 08:46:32', 1),
	(154, 'admin', 'Logged Out', '2024-04-15 08:46:38', 1),
	(155, 'admin', 'Logged In', '2024-04-15 08:47:25', 1),
	(156, 'admin', 'Logged In', '2024-04-15 09:53:54', 1),
	(157, 'admin', 'Logged In', '2024-04-15 09:54:34', 1),
	(158, 'admin', 'Logged Out', '2024-04-15 09:56:14', 1),
	(159, 'admin', 'Logged In', '2024-04-15 09:58:26', 1),
	(160, 'admin', 'Logged Out', '2024-04-15 10:06:50', 1),
	(161, 'admin', 'Logged In', '2024-04-15 13:21:54', 1),
	(162, 'admin', 'Logged Out', '2024-04-15 13:23:11', 1),
	(163, 'admin', 'Logged In', '2024-04-15 13:25:41', 1),
	(164, 'admin', 'Logged Out', '2024-04-15 13:27:30', 1),
	(165, 'admin', 'Logged In', '2024-04-15 13:47:50', 1),
	(166, 'admin', 'Logged Out', '2024-04-15 13:49:01', 1),
	(167, 'admin', 'Logged In', '2024-04-15 13:50:35', 1),
	(168, 'admin', 'Logged In', '2024-04-15 13:52:05', 1),
	(169, 'admin', 'Logged In', '2024-04-15 13:54:32', 1),
	(170, 'admin', 'Logged Out', '2024-04-15 13:55:25', 1),
	(171, 'admin', 'Logged In', '2024-04-15 13:55:42', 1),
	(172, 'admin', 'Logged Out', '2024-04-15 14:01:04', 1),
	(173, 'admin', 'Logged In', '2024-04-15 14:01:28', 1),
	(174, 'admin', 'Logged Out', '2024-04-15 14:02:32', 1),
	(175, 'admin', 'Logged In', '2024-04-15 14:03:00', 1),
	(176, 'admin', 'Logged Out', '2024-04-15 14:04:02', 1),
	(177, 'admin', 'Logged In', '2024-04-15 14:09:52', 1),
	(178, 'admin', 'Logged Out', '2024-04-15 14:11:45', 1),
	(179, 'admin', 'Logged In', '2024-04-15 14:11:49', 1),
	(180, 'admin', 'Logged Out', '2024-04-15 14:13:03', 1),
	(181, 'admin', 'Logged In', '2024-04-15 14:13:07', 1),
	(182, 'admin', 'Logged Out', '2024-04-15 14:14:18', 1),
	(183, 'admin', 'Logged In', '2024-04-15 14:14:22', 1),
	(184, 'admin', 'Logged Out', '2024-04-15 14:21:17', 1),
	(185, 'admin', 'Logged In', '2024-04-15 14:21:22', 1),
	(186, 'admin', 'Logged Out', '2024-04-15 14:22:21', 1),
	(187, 'admin', 'Logged In', '2024-04-15 14:22:25', 1),
	(188, 'admin', 'Logged In', '2024-04-15 14:23:51', 1),
	(189, 'admin', 'Logged Out', '2024-04-15 14:25:51', 1),
	(190, 'admin', 'Logged In', '2024-04-15 14:27:33', 1),
	(191, 'admin', 'Logged Out', '2024-04-15 14:28:12', 1),
	(192, 'admin', 'Logged In', '2024-04-15 14:28:16', 1),
	(193, 'admin', 'Logged Out', '2024-04-15 14:30:02', 1),
	(194, 'admin', 'Logged In', '2024-04-15 14:30:15', 1),
	(195, 'admin', 'Logged Out', '2024-04-15 14:34:26', 1),
	(196, 'admin', 'Logged In', '2024-04-15 14:34:30', 1),
	(197, 'admin', 'Logged Out', '2024-04-15 14:36:02', 1),
	(198, 'admin', 'Logged In', '2024-04-15 14:37:28', 1),
	(199, 'admin', 'Logged Out', '2024-04-15 14:38:29', 1),
	(200, 'admin', 'Logged In', '2024-04-15 14:38:33', 1),
	(201, 'admin', 'Logged Out', '2024-04-15 14:39:04', 1),
	(202, 'admin', 'Logged In', '2024-04-15 16:12:03', 1),
	(203, 'admin', 'Logged In', '2024-04-15 16:12:46', 1),
	(204, 'admin', 'Logged In', '2024-04-15 16:13:03', 1),
	(205, 'admin', 'Logged In', '2024-04-15 16:13:34', 1),
	(206, 'admin', 'Logged In', '2024-04-15 16:14:23', 1),
	(207, 'admin', 'Logged In', '2024-04-15 16:15:02', 1),
	(209, 'admin', 'Logged Out', '2024-04-15 16:17:02', 1),
	(210, 'admin', 'Logged In', '2024-04-15 16:17:08', 1),
	(212, 'admin', 'Logged Out', '2024-04-15 16:19:06', 1),
	(213, 'admin', 'Logged In', '2024-04-15 16:19:57', 1),
	(221, 'admin', 'Logged Out', '2024-04-15 16:27:46', 1),
	(222, 'admin', 'Logged In', '2024-04-16 10:41:27', 1),
	(223, 'admin', 'Logged Out', '2024-04-16 10:42:02', 1),
	(224, 'admin', 'Logged In', '2024-04-16 11:00:57', 1),
	(225, 'admin', 'Logged Out', '2024-04-16 11:02:37', 1),
	(226, 'admin', 'Logged In', '2024-04-16 11:04:03', 1),
	(227, 'admin', 'Logged Out', '2024-04-16 11:05:22', 1),
	(228, 'admin', 'Logged In', '2024-04-16 11:07:10', 1),
	(229, 'admin', 'Logged Out', '2024-04-16 11:12:53', 1),
	(230, 'admin', 'Logged In', '2024-04-16 11:16:27', 1),
	(231, 'admin', 'Logged Out', '2024-04-16 11:16:31', 1),
	(232, 'admin', 'Logged In', '2024-04-16 11:17:29', 1),
	(233, 'admin', 'Logged Out', '2024-04-16 11:18:39', 1),
	(234, 'admin', 'Logged In', '2024-04-16 11:25:05', 1),
	(235, 'admin', 'Logged Out', '2024-04-16 11:26:30', 1),
	(236, 'admin', 'Logged In', '2024-04-16 11:26:34', 1),
	(237, 'admin', 'Logged Out', '2024-04-16 11:28:56', 1),
	(238, 'admin', 'Logged In', '2024-04-16 14:37:22', 1),
	(239, 'admin', 'Logged In', '2024-04-16 14:40:22', 1),
	(240, 'admin', 'Logged In', '2024-04-16 14:46:23', 1),
	(241, 'admin', 'Logged In', '2024-04-16 14:50:25', 1),
	(242, 'admin', 'Logged In', '2024-04-16 14:51:05', 1),
	(243, 'admin', 'Logged In', '2024-04-16 14:51:24', 1),
	(244, 'admin', 'Logged In', '2024-04-16 14:52:15', 1),
	(245, 'admin', 'Logged In', '2024-04-16 14:53:23', 1),
	(246, 'admin', 'Logged In', '2024-04-16 14:53:46', 1),
	(247, 'admin', 'Logged In', '2024-04-16 14:58:08', 1),
	(248, 'admin', 'Logged In', '2024-04-16 14:58:23', 1),
	(249, 'admin', 'Logged In', '2024-04-16 15:00:42', 1),
	(250, 'admin', 'Logged In', '2024-04-16 15:10:26', 1),
	(251, 'admin', 'Logged In', '2024-04-16 15:14:26', 1),
	(252, 'admin', 'Logged In', '2024-04-16 16:06:15', 1),
	(253, 'admin', 'Logged In', '2024-04-16 16:22:01', 1),
	(254, 'admin', 'Logged In', '2024-04-16 16:22:35', 1),
	(255, 'admin', 'Logged In', '2024-04-16 16:24:12', 1),
	(256, 'admin', 'Logged In', '2024-04-16 16:24:57', 1),
	(257, 'admin', 'Logged In', '2024-04-16 16:27:51', 1),
	(258, 'admin', 'Logged In', '2024-04-17 09:18:39', 1),
	(259, 'admin', 'Logged Out', '2024-04-17 09:18:49', 1),
	(260, 'admin', 'Logged In', '2024-04-17 09:20:11', 1),
	(261, 'admin', 'Logged Out', '2024-04-17 09:20:56', 1),
	(262, 'admin', 'Logged In', '2024-04-17 09:22:56', 1),
	(263, 'admin', 'Logged Out', '2024-04-17 09:26:02', 1),
	(264, 'admin', 'Logged In', '2024-04-17 09:27:10', 1),
	(265, 'admin', 'Logged Out', '2024-04-17 09:28:00', 1),
	(266, 'admin', 'Logged In', '2024-04-17 09:28:22', 1),
	(267, 'admin', 'Logged Out', '2024-04-17 09:29:53', 1),
	(268, 'admin', 'Logged In', '2024-04-17 09:40:33', 1),
	(269, 'admin', 'Logged In', '2024-04-17 10:10:06', 1),
	(270, 'admin', 'Logged Out', '2024-04-17 10:10:08', 1),
	(271, 'admin', 'Logged In', '2024-04-17 10:12:56', 1),
	(272, 'admin', 'Logged Out', '2024-04-17 10:14:51', 1),
	(273, 'admin', 'Logged In', '2024-04-17 10:14:57', 1),
	(274, 'admin', 'Logged Out', '2024-04-17 10:15:07', 1),
	(275, 'admin', 'Logged In', '2024-04-17 10:16:06', 1),
	(276, 'admin', 'Logged Out', '2024-04-17 10:33:59', 1),
	(277, 'admin', 'Logged In', '2024-04-17 10:42:24', 1),
	(278, 'admin', 'Logged Out', '2024-04-17 10:43:05', 1),
	(279, 'admin', 'Logged In', '2024-04-17 10:44:02', 1),
	(280, 'admin', 'Logged In', '2024-04-17 10:45:07', 1),
	(281, 'admin', 'Logged Out', '2024-04-17 10:45:56', 1),
	(282, 'admin', 'Logged In', '2024-04-17 10:46:02', 1),
	(283, 'admin', 'Logged Out', '2024-04-17 10:47:27', 1),
	(284, 'admin', 'Logged In', '2024-04-17 10:49:11', 1),
	(285, 'admin', 'Logged Out', '2024-04-17 10:50:32', 1),
	(286, 'admin', 'Logged In', '2024-04-17 10:54:13', 1),
	(287, 'admin', 'Logged Out', '2024-04-17 10:56:24', 1),
	(288, 'admin', 'Logged In', '2024-04-17 11:04:16', 1),
	(289, 'admin', 'Logged In', '2024-04-17 11:05:21', 1),
	(290, 'admin', 'Logged In', '2024-04-17 11:06:57', 1),
	(291, 'admin', 'Logged In', '2024-04-17 13:23:18', 1),
	(292, 'admin', 'Logged In', '2024-04-17 13:23:18', 1),
	(293, 'admin', 'Logged Out', '2024-04-17 13:23:25', 1),
	(294, 'admin', 'Logged In', '2024-04-17 13:25:31', 1),
	(295, 'admin', 'Logged In', '2024-04-17 13:25:31', 1),
	(296, 'admin', 'Logged In', '2024-04-17 13:32:54', 1),
	(297, 'admin', 'Logged In', '2024-04-17 13:32:54', 1),
	(298, 'admin', 'Logged In', '2024-04-17 13:35:23', 1),
	(299, 'admin', 'Logged In', '2024-04-17 13:35:23', 1),
	(300, 'admin', 'Logged Out', '2024-04-17 13:35:25', 1),
	(301, 'admin', 'Logged In', '2024-04-17 13:52:36', 1),
	(302, 'admin', 'Logged In', '2024-04-17 13:52:36', 1),
	(303, 'admin', 'Logged Out', '2024-04-17 13:52:50', 1),
	(304, 'admin', 'Logged In', '2024-04-17 13:54:01', 1),
	(305, 'admin', 'Logged In', '2024-04-17 13:54:02', 1),
	(306, 'admin', 'Logged Out', '2024-04-17 13:54:07', 1),
	(307, 'admin', 'Logged In', '2024-04-17 13:55:04', 1),
	(308, 'admin', 'Logged In', '2024-04-17 13:55:05', 1),
	(309, 'admin', 'Logged Out', '2024-04-17 13:55:08', 1),
	(310, 'admin', 'Logged In', '2024-04-17 13:55:15', 1),
	(311, 'admin', 'Logged In', '2024-04-17 13:55:15', 1),
	(312, 'admin', 'Logged Out', '2024-04-17 13:55:20', 1),
	(313, 'admin', 'Logged Out', '2024-04-17 13:55:52', 1),
	(314, 'admin', 'Logged Out', '2024-04-17 13:55:52', 1),
	(315, 'admin', 'Logged In', '2024-04-17 13:57:15', 1),
	(316, 'admin', 'Logged In', '2024-04-17 13:57:16', 1),
	(317, 'admin', 'Logged Out', '2024-04-17 13:57:19', 1),
	(318, 'admin', 'Logged Out', '2024-04-17 13:57:26', 1),
	(319, 'admin', 'Logged In', '2024-04-17 13:59:10', 1),
	(320, 'admin', 'Logged In', '2024-04-17 13:59:10', 1),
	(321, 'admin', 'Logged Out', '2024-04-17 13:59:15', 1),
	(322, 'admin', 'Logged In', '2024-04-17 14:00:18', 1),
	(323, 'admin', 'Logged In', '2024-04-17 14:00:19', 1),
	(324, 'admin', 'Logged Out', '2024-04-17 14:00:22', 1),
	(325, 'admin', 'Logged In', '2024-04-17 14:02:21', 1),
	(326, 'admin', 'Logged In', '2024-04-17 14:02:22', 1),
	(327, 'admin', 'Logged Out', '2024-04-17 14:02:25', 1),
	(328, 'admin', 'Logged In', '2024-04-17 14:04:51', 1),
	(329, 'admin', 'Logged In', '2024-04-17 14:04:51', 1),
	(330, 'admin', 'Logged Out', '2024-04-17 14:04:54', 1),
	(331, 'admin', 'Logged In', '2024-04-17 14:05:26', 1),
	(332, 'admin', 'Logged In', '2024-04-17 14:05:26', 1),
	(333, 'admin', 'Logged Out', '2024-04-17 14:05:29', 1),
	(334, 'admin', 'Logged In', '2024-04-17 14:06:00', 1),
	(335, 'admin', 'Logged In', '2024-04-17 14:06:00', 1),
	(336, 'admin', 'Logged Out', '2024-04-17 14:06:03', 1),
	(337, 'admin', 'Logged In', '2024-04-17 14:07:40', 1),
	(338, 'admin', 'Logged In', '2024-04-17 14:07:40', 1),
	(339, 'admin', 'Logged Out', '2024-04-17 14:07:42', 1),
	(340, 'admin', 'Logged In', '2024-04-17 14:08:33', 1),
	(341, 'admin', 'Logged In', '2024-04-17 14:08:33', 1),
	(342, 'admin', 'Logged Out', '2024-04-17 14:08:35', 1),
	(343, 'admin', 'Logged In', '2024-04-17 14:10:31', 1),
	(344, 'admin', 'Logged In', '2024-04-17 14:10:31', 1),
	(345, 'admin', 'Logged Out', '2024-04-17 14:10:34', 1),
	(346, 'admin', 'Logged In', '2024-04-17 14:30:14', 1),
	(347, 'admin', 'Logged In', '2024-04-17 14:30:14', 1),
	(348, 'admin', 'Logged Out', '2024-04-17 14:30:16', 1),
	(349, 'admin', 'Logged In', '2024-04-17 14:31:14', 1),
	(350, 'admin', 'Logged In', '2024-04-17 14:31:14', 1),
	(351, 'admin', 'Logged Out', '2024-04-17 14:31:16', 1),
	(352, 'admin', 'Logged In', '2024-04-17 14:33:22', 1),
	(353, 'admin', 'Logged In', '2024-04-17 14:33:22', 1),
	(354, 'admin', 'Logged Out', '2024-04-17 14:33:24', 1),
	(355, 'admin', 'Logged In', '2024-04-17 14:33:44', 1),
	(356, 'admin', 'Logged In', '2024-04-17 14:33:44', 1),
	(357, 'admin', 'Logged Out', '2024-04-17 14:33:46', 1),
	(358, 'admin', 'Logged In', '2024-04-17 14:34:23', 1),
	(359, 'admin', 'Logged In', '2024-04-17 14:34:23', 1),
	(360, 'admin', 'Logged Out', '2024-04-17 14:34:24', 1),
	(361, 'admin', 'Logged In', '2024-04-17 14:35:44', 1),
	(362, 'admin', 'Logged In', '2024-04-17 14:35:44', 1),
	(363, 'admin', 'Logged Out', '2024-04-17 14:39:45', 1),
	(364, 'admin', 'Logged In', '2024-04-17 14:43:44', 1),
	(365, 'admin', 'Logged In', '2024-04-17 14:43:45', 1),
	(366, 'admin', 'Logged In', '2024-04-17 14:49:09', 1),
	(367, 'admin', 'Logged In', '2024-04-17 14:49:09', 1),
	(368, 'admin', 'Logged In', '2024-04-17 16:28:43', 1),
	(369, 'admin', 'Logged In', '2024-04-17 16:28:43', 1),
	(370, 'admin', 'Logged Out', '2024-04-17 16:33:57', 1),
	(371, 'admin', 'Logged In', '2024-04-17 16:40:46', 1),
	(372, 'admin', 'Logged In', '2024-04-17 16:40:46', 1),
	(373, 'admin', 'Logged Out', '2024-04-17 16:41:19', 1),
	(374, 'admin', 'Logged In', '2024-04-18 08:15:30', 1),
	(375, 'admin', 'Logged Out', '2024-04-18 08:52:51', 1),
	(376, 'admin', 'Logged In', '2024-04-18 09:29:53', 1),
	(377, 'admin', 'Logged In', '2024-04-18 09:30:45', 1),
	(378, 'admin', 'Logged Out', '2024-04-18 09:33:40', 1),
	(379, 'admin', 'Logged In', '2024-04-18 09:53:01', 1),
	(380, 'admin', 'Logged Out', '2024-04-18 09:54:45', 1),
	(381, 'admin', 'Logged In', '2024-04-18 09:55:15', 1),
	(382, 'admin', 'Logged Out', '2024-04-18 10:03:32', 1),
	(383, 'admin', 'Logged In', '2024-04-18 11:08:00', 1),
	(384, 'admin', 'Logged In', '2024-04-18 11:08:17', 1),
	(385, 'admin', 'Logged In', '2024-04-18 11:35:13', 1),
	(386, 'admin', 'Logged In', '2024-04-18 11:36:44', 1),
	(387, 'admin', 'Logged In', '2024-04-18 11:37:01', 1),
	(388, 'admin', 'Logged Out', '2024-04-18 11:37:55', 1),
	(389, 'admin', 'Logged In', '2024-04-18 11:39:01', 1),
	(390, 'admin', 'Logged Out', '2024-04-18 11:39:25', 1),
	(391, 'admin', 'Logged In', '2024-04-18 13:07:37', 1),
	(392, 'admin', 'Logged Out', '2024-04-18 13:07:55', 1),
	(393, 'admin', 'Logged In', '2024-04-18 13:09:22', 1),
	(394, 'admin', 'Logged Out', '2024-04-18 13:09:49', 1),
	(395, 'admin', 'Logged In', '2024-04-18 13:13:40', 1),
	(396, 'admin', 'Logged Out', '2024-04-18 13:14:15', 1),
	(397, 'admin', 'Logged In', '2024-04-18 13:20:27', 1),
	(398, 'admin', 'Logged In', '2024-04-18 13:22:45', 1),
	(399, 'admin', 'Logged Out', '2024-04-18 13:24:34', 1),
	(400, 'admin', 'Logged In', '2024-04-18 13:24:58', 1),
	(401, 'admin', 'Logged Out', '2024-04-18 13:26:19', 1),
	(402, 'admin', 'Logged In', '2024-04-20 14:56:26', 1),
	(403, 'admin', 'Logged Out', '2024-04-20 15:08:21', 1),
	(404, 'admin', 'Logged In', '2024-04-21 17:09:57', 1),
	(405, 'admin', 'Logged Out', '2024-04-21 17:51:35', 1),
	(406, 'admin', 'Logged In', '2024-04-22 00:13:51', 1),
	(407, 'admin', 'Logged In', '2024-04-22 09:49:43', 1),
	(408, 'admin', 'Logged Out', '2024-04-22 10:07:58', 1),
	(409, 'admin', 'Logged In', '2024-04-22 10:09:49', 1),
	(410, 'admin', 'Logged Out', '2024-04-22 10:12:42', 1),
	(411, 'admin', 'Logged In', '2024-04-22 10:13:30', 1),
	(412, 'admin', 'Logged Out', '2024-04-22 10:15:00', 1),
	(413, 'admin', 'Logged In', '2024-04-22 10:15:43', 1),
	(414, 'admin', 'Logged Out', '2024-04-22 10:16:14', 1),
	(415, 'admin', 'Logged In', '2024-04-22 10:16:17', 1),
	(416, 'admin', 'Logged Out', '2024-04-22 10:16:29', 1),
	(417, 'admin', 'Logged In', '2024-04-22 10:18:30', 1),
	(418, 'admin', 'Logged Out', '2024-04-22 10:19:00', 1),
	(419, 'admin', 'Logged In', '2024-04-22 10:21:06', 1),
	(420, 'admin', 'Logged Out', '2024-04-22 10:21:31', 1),
	(421, 'admin', 'Logged In', '2024-04-22 10:21:40', 1),
	(422, 'admin', 'Logged Out', '2024-04-22 10:21:47', 1),
	(423, 'admin', 'Logged In', '2024-04-22 10:23:47', 1),
	(424, 'admin', 'Logged Out', '2024-04-22 10:30:04', 1),
	(425, 'admin', 'Logged In', '2024-04-22 10:32:29', 1),
	(426, 'admin', 'Logged In', '2024-04-22 10:51:51', 1),
	(427, 'admin', 'Logged In', '2024-04-22 11:05:06', 1),
	(428, 'admin', 'Logged Out', '2024-04-22 11:11:19', 1),
	(429, 'admin', 'Logged Out', '2024-04-22 11:11:23', 1),
	(430, 'admin', 'Logged In', '2024-04-22 11:11:27', 1),
	(431, 'admin', 'Logged Out', '2024-04-22 11:15:15', 1),
	(432, 'admin', 'Logged In', '2024-04-22 13:57:59', 1),
	(433, 'admin', 'Logged Out', '2024-04-22 14:00:57', 1),
	(434, 'admin', 'Logged In', '2024-04-22 14:02:26', 1),
	(435, 'admin', 'Logged Out', '2024-04-22 14:03:05', 1),
	(436, 'admin', 'Logged In', '2024-04-22 14:05:26', 1),
	(437, 'admin', 'Logged Out', '2024-04-22 14:06:23', 1),
	(438, 'admin', 'Logged In', '2024-04-22 14:08:53', 1),
	(439, 'admin', 'Logged Out', '2024-04-22 14:10:01', 1),
	(440, 'admin', 'Logged In', '2024-04-22 14:22:10', 1),
	(441, 'admin', 'Logged Out', '2024-04-22 14:22:55', 1),
	(442, 'admin', 'Logged In', '2024-04-22 14:25:26', 1),
	(443, 'admin', 'Logged Out', '2024-04-22 14:25:48', 1),
	(444, 'admin', 'Logged In', '2024-04-22 14:26:40', 1),
	(445, 'admin', 'Logged Out', '2024-04-22 14:28:37', 1),
	(446, 'admin', 'Logged In', '2024-04-22 14:30:40', 1),
	(447, 'admin', 'Logged Out', '2024-04-22 14:36:41', 1),
	(448, 'admin', 'Logged In', '2024-04-22 14:43:19', 1),
	(449, 'admin', 'Logged Out', '2024-04-22 14:49:39', 1),
	(450, 'admin', 'Logged In', '2024-04-22 14:49:44', 1),
	(451, 'admin', 'Logged Out', '2024-04-22 14:50:03', 1),
	(452, 'admin', 'Logged In', '2024-04-22 14:51:35', 1),
	(453, 'admin', 'Logged Out', '2024-04-22 14:52:40', 1),
	(454, 'admin', 'Logged In', '2024-04-22 14:56:21', 1),
	(455, 'admin', 'Logged Out', '2024-04-22 14:57:43', 1),
	(456, 'admin', 'Logged In', '2024-04-22 15:00:26', 1),
	(457, 'admin', 'Logged Out', '2024-04-22 15:05:45', 1),
	(458, 'admin', 'Logged In', '2024-04-22 15:07:35', 1),
	(459, 'admin', 'Logged Out', '2024-04-22 15:07:55', 1),
	(460, 'admin', 'Logged In', '2024-04-22 16:12:34', 1),
	(461, 'admin', 'Logged Out', '2024-04-22 16:13:42', 1),
	(462, 'admin', 'Logged In', '2024-04-22 16:27:24', 1),
	(463, 'admin', 'Logged Out', '2024-04-22 16:28:01', 1),
	(464, 'admin', 'Logged In', '2024-04-22 16:31:41', 1),
	(465, 'admin', 'Logged Out', '2024-04-22 16:36:40', 1),
	(466, 'admin', 'Logged In', '2024-04-23 09:55:00', 1),
	(467, 'admin', 'Logged Out', '2024-04-23 09:56:28', 1),
	(468, 'admin', 'Logged In', '2024-04-23 09:58:34', 1),
	(469, 'admin', 'Logged Out', '2024-04-23 09:59:55', 1),
	(470, 'admin', 'Logged In', '2024-04-23 10:07:07', 1),
	(471, 'admin', 'Logged Out', '2024-04-23 10:08:45', 1),
	(472, 'admin', 'Logged In', '2024-04-23 10:12:02', 1),
	(473, 'admin', 'Logged Out', '2024-04-23 10:12:24', 1),
	(474, 'admin', 'Logged In', '2024-04-23 10:17:07', 1),
	(475, 'admin', 'Logged Out', '2024-04-23 10:19:02', 1),
	(476, 'admin', 'Logged In', '2024-04-23 10:19:06', 1),
	(477, 'admin', 'Logged Out', '2024-04-23 10:21:10', 1),
	(478, 'admin', 'Logged In', '2024-04-23 10:21:15', 1),
	(479, 'admin', 'Logged Out', '2024-04-23 10:22:51', 1),
	(480, 'admin', 'Logged In', '2024-04-23 10:27:57', 1),
	(481, 'admin', 'Logged Out', '2024-04-23 10:28:52', 1),
	(482, 'admin', 'Logged In', '2024-04-23 10:32:04', 1),
	(483, 'admin', 'Logged Out', '2024-04-23 10:34:18', 1),
	(484, 'admin', 'Logged In', '2024-04-23 10:39:02', 1),
	(485, 'admin', 'Logged Out', '2024-04-23 10:40:34', 1),
	(486, 'admin', 'Logged In', '2024-04-23 10:52:31', 1),
	(487, 'admin', 'Logged Out', '2024-04-23 10:55:42', 1),
	(488, 'admin', 'Logged In', '2024-04-23 10:57:42', 1),
	(489, 'admin', 'Logged Out', '2024-04-23 10:57:51', 1),
	(490, 'admin', 'Logged In', '2024-04-23 10:59:57', 1),
	(491, 'admin', 'Logged Out', '2024-04-23 11:05:35', 1),
	(492, 'admin', 'Logged In', '2024-04-23 14:30:43', 1),
	(493, 'admin', 'Logged Out', '2024-04-23 14:31:42', 1),
	(494, 'admin', 'Logged In', '2024-04-23 14:33:00', 1),
	(495, 'admin', 'Logged Out', '2024-04-23 14:33:27', 1),
	(496, 'admin', 'Logged In', '2024-04-23 14:35:40', 1),
	(497, 'admin', 'Logged Out', '2024-04-23 14:36:16', 1),
	(498, 'admin', 'Logged In', '2024-04-23 14:37:27', 1),
	(499, 'admin', 'Logged Out', '2024-04-23 14:37:59', 1),
	(500, 'admin', 'Logged In', '2024-04-23 14:39:43', 1),
	(501, 'admin', 'Logged Out', '2024-04-23 14:40:39', 1),
	(502, 'admin', 'Logged In', '2024-04-23 14:43:16', 1),
	(503, 'admin', 'Logged Out', '2024-04-23 14:43:53', 1),
	(504, 'admin', 'Logged In', '2024-04-23 14:49:11', 1),
	(505, 'admin', 'Logged Out', '2024-04-23 14:49:32', 1),
	(506, 'admin', 'Logged In', '2024-04-23 14:52:01', 1),
	(507, 'admin', 'Logged Out', '2024-04-23 14:55:13', 1),
	(508, 'admin', 'Logged In', '2024-04-23 14:55:17', 1),
	(509, 'admin', 'Logged Out', '2024-04-23 14:56:52', 1),
	(510, 'admin', 'Logged In', '2024-04-23 14:58:28', 1),
	(511, 'admin', 'Logged Out', '2024-04-23 14:58:56', 1),
	(512, 'admin', 'Logged In', '2024-04-23 14:59:54', 1),
	(513, 'admin', 'Logged Out', '2024-04-23 15:04:46', 1),
	(514, 'admin', 'Logged In', '2024-04-23 15:06:22', 1),
	(515, 'admin', 'Logged Out', '2024-04-23 15:08:49', 1),
	(516, 'admin', 'Logged In', '2024-04-23 15:12:29', 1),
	(517, 'admin', 'Logged Out', '2024-04-23 15:41:15', 1),
	(518, 'admin', 'Logged In', '2024-04-23 15:42:41', 1),
	(519, 'admin', 'Logged Out', '2024-04-23 15:45:21', 1),
	(520, 'admin', 'Logged In', '2024-04-23 16:15:27', 1),
	(524, 'admin', 'Logged Out', '2024-04-23 16:16:39', 1),
	(525, 'admin', 'Logged In', '2024-04-23 16:20:10', 1),
	(527, 'admin', 'Logged Out', '2024-04-23 16:21:15', 1),
	(528, 'admin', 'Logged In', '2024-04-23 16:36:14', 1),
	(531, 'admin', 'Logged Out', '2024-04-23 16:36:58', 1),
	(532, 'admin', 'Logged In', '2024-04-23 16:38:43', 1),
	(534, 'admin', 'Logged Out', '2024-04-23 16:39:26', 1),
	(535, 'admin', 'Logged In', '2024-04-23 16:39:38', 1),
	(538, 'admin', 'Logged Out', '2024-04-23 16:40:14', 1),
	(539, 'admin', 'Logged In', '2024-04-24 08:22:54', 1),
	(540, 'admin', 'Logged Out', '2024-04-24 08:23:44', 1),
	(541, 'admin', 'Logged In', '2024-04-24 08:23:48', 1),
	(542, 'admin', 'Logged Out', '2024-04-24 08:24:26', 1),
	(543, 'admin', 'Logged In', '2024-04-24 08:24:43', 1),
	(544, 'admin', 'Logged Out', '2024-04-24 08:25:05', 1),
	(545, 'admin', 'Logged In', '2024-04-24 08:26:44', 1),
	(546, 'admin', 'Logged Out', '2024-04-24 08:26:56', 1),
	(547, 'admin', 'Logged In', '2024-04-24 09:07:32', 1),
	(548, 'admin', 'Logged Out', '2024-04-24 09:08:08', 1),
	(549, 'admin', 'Logged In', '2024-04-24 09:15:44', 1),
	(552, 'admin', 'Logged Out', '2024-04-24 09:17:13', 1),
	(553, 'admin', 'Logged In', '2024-04-24 09:18:33', 1),
	(554, 'admin', 'Logged In', '2024-04-24 09:18:33', 1),
	(555, 'admin', 'Logged Out', '2024-04-24 09:20:03', 1),
	(556, 'admin', 'Logged In', '2024-04-24 09:29:15', 1),
	(557, 'admin', 'Logged Out', '2024-04-24 09:29:21', 1),
	(558, 'admin', 'Logged In', '2024-04-24 09:55:20', 1),
	(559, 'admin', 'Logged Out', '2024-04-24 09:55:23', 1),
	(560, 'admin', 'Logged In', '2024-04-24 09:55:26', 1),
	(561, 'admin', 'Logged In', '2024-04-24 09:55:27', 1),
	(562, 'admin', 'Logged Out', '2024-04-24 09:55:52', 1),
	(563, 'admin', 'Logged In', '2024-04-24 10:12:48', 1),
	(564, 'admin', 'Logged Out', '2024-04-24 10:27:33', 1),
	(565, 'admin', 'Logged In', '2024-04-24 10:37:12', 1),
	(566, 'admin', 'Logged Out', '2024-04-24 10:37:19', 1),
	(567, 'admin', 'Logged In', '2024-04-24 10:46:08', 1),
	(568, 'admin', 'Logged In', '2024-04-24 10:51:46', 1),
	(569, 'admin', 'Logged In', '2024-04-24 10:52:44', 1),
	(570, 'admin', 'Logged In', '2024-04-24 10:53:30', 1),
	(571, 'admin', 'Logged In', '2024-04-24 11:00:43', 1),
	(572, 'admin', 'Logged In', '2024-04-24 11:03:48', 1),
	(573, 'admin', 'Logged In', '2024-04-24 13:12:06', 1),
	(574, 'admin', 'Logged In', '2024-04-24 13:13:32', 1),
	(575, 'admin', 'Logged Out', '2024-04-24 13:18:33', 1),
	(576, 'admin', 'Logged In', '2024-04-24 13:18:39', 1),
	(577, 'admin', 'Logged Out', '2024-04-24 13:18:59', 1),
	(578, 'admin', 'Logged In', '2024-04-24 13:19:05', 1),
	(579, 'admin', 'Logged Out', '2024-04-24 13:19:12', 1),
	(580, 'admin', 'Logged In', '2024-04-24 13:19:16', 1),
	(581, 'admin', 'Logged Out', '2024-04-24 13:20:12', 1),
	(582, 'admin', 'Logged In', '2024-04-24 13:20:21', 1),
	(583, 'admin', 'Logged Out', '2024-04-24 13:20:30', 1),
	(584, 'admin', 'Logged In', '2024-04-24 13:23:44', 1),
	(585, 'admin', 'Logged Out', '2024-04-24 13:24:14', 1),
	(586, 'admin', 'Logged In', '2024-04-24 13:24:18', 1),
	(587, 'admin', 'Logged Out', '2024-04-24 13:25:52', 1),
	(588, 'admin', 'Logged In', '2024-04-24 13:25:56', 1),
	(589, 'admin', 'Logged Out', '2024-04-24 13:28:57', 1),
	(590, 'admin', 'Logged In', '2024-04-24 13:29:05', 1),
	(591, 'admin', 'Logged Out', '2024-04-24 13:29:40', 1),
	(592, 'admin', 'Logged In', '2024-04-24 13:33:01', 1),
	(593, 'admin', 'Logged Out', '2024-04-24 13:35:39', 1),
	(594, 'admin', 'Logged In', '2024-04-24 13:35:43', 1),
	(595, 'admin', 'Logged In', '2024-04-24 13:36:12', 1),
	(596, 'admin', 'Logged In', '2024-04-24 13:36:26', 1),
	(597, 'admin', 'Logged In', '2024-04-24 13:36:43', 1),
	(598, 'admin', 'Logged In', '2024-04-24 13:44:19', 1),
	(599, 'admin', 'Logged Out', '2024-04-24 13:44:45', 1),
	(600, 'admin', 'Logged In', '2024-04-24 15:16:17', 1),
	(601, 'admin', 'Logged Out', '2024-04-24 15:16:31', 1),
	(602, 'admin', 'Logged In', '2024-04-24 15:17:40', 1),
	(603, 'admin', 'Logged Out', '2024-04-24 15:18:20', 1),
	(604, 'admin', 'Logged In', '2024-04-24 15:18:44', 1),
	(605, 'admin', 'Logged Out', '2024-04-24 15:19:44', 1),
	(606, 'admin', 'Logged In', '2024-04-24 15:25:00', 1),
	(607, 'admin', 'Logged Out', '2024-04-24 15:25:47', 1),
	(608, 'admin', 'Logged In', '2024-04-24 15:28:00', 1),
	(609, 'admin', 'Logged Out', '2024-04-24 15:28:13', 1),
	(610, 'admin', 'Logged In', '2024-04-24 15:31:18', 1),
	(611, 'admin', 'Logged Out', '2024-04-24 15:34:55', 1),
	(612, 'admin', 'Logged In', '2024-04-24 15:36:20', 1),
	(613, 'admin', 'Logged Out', '2024-04-24 15:42:32', 1),
	(614, 'admin', 'Logged In', '2024-04-24 15:42:44', 1),
	(615, 'admin', 'Logged Out', '2024-04-24 15:43:40', 1),
	(616, 'admin', 'Logged In', '2024-04-24 15:44:47', 1),
	(617, 'admin', 'Logged In', '2024-04-24 15:49:20', 1),
	(618, 'admin', 'Logged Out', '2024-04-24 15:55:59', 1),
	(619, 'admin', 'Logged In', '2024-04-24 16:00:09', 1),
	(620, 'admin', 'Logged Out', '2024-04-24 16:01:05', 1),
	(621, 'admin', 'Logged In', '2024-04-24 16:18:18', 1),
	(623, 'admin', 'Logged Out', '2024-04-24 16:19:25', 1),
	(624, 'admin', 'Logged In', '2024-04-24 16:22:55', 1),
	(627, 'admin', 'Logged Out', '2024-04-24 16:25:43', 1),
	(628, 'admin', 'Logged In', '2024-04-24 16:26:05', 1),
	(629, 'admin', 'Logged Out', '2024-04-24 16:28:39', 1),
	(630, 'admin', 'Logged In', '2024-04-25 08:36:47', 1),
	(631, 'admin', 'Logged Out', '2024-04-25 08:37:36', 1),
	(632, 'admin', 'Logged In', '2024-04-25 08:43:48', 1),
	(633, 'admin', 'Logged Out', '2024-04-25 08:44:14', 1),
	(634, 'admin', 'Logged In', '2024-04-29 09:41:08', 1),
	(635, 'admin', 'Logged Out', '2024-04-29 09:51:47', 1),
	(636, 'admin', 'Logged In', '2024-04-29 10:08:41', 1),
	(637, 'admin', 'Logged Out', '2024-04-29 10:24:18', 1),
	(638, 'admin', 'Logged In', '2024-04-29 10:37:25', 1),
	(639, 'admin', 'Logged Out', '2024-04-29 10:37:51', 1),
	(640, 'admin', 'Logged In', '2024-04-29 10:38:56', 1),
	(641, 'admin', 'Logged Out', '2024-04-29 10:45:36', 1),
	(642, 'admin', 'Logged In', '2024-04-29 10:52:32', 1),
	(643, 'admin', 'Logged Out', '2024-04-29 13:12:46', 1),
	(644, 'admin', 'Logged In', '2024-04-29 14:23:16', 1),
	(645, 'admin', 'Logged Out', '2024-04-29 14:23:40', 1),
	(646, 'admin', 'Logged In', '2024-04-29 14:24:15', 1),
	(647, 'admin', 'Add Record: item_unit unit', '2024-04-29 14:24:21', 2),
	(648, 'admin', 'Logged Out', '2024-04-29 14:25:30', 1),
	(649, 'admin', 'Logged In', '2024-04-29 14:26:58', 1),
	(650, 'admin', 'Add Record: item_type Mouse', '2024-04-29 14:31:25', 2),
	(651, 'admin', 'Logged Out', '2024-04-29 14:42:13', 1),
	(652, 'admin', 'Logged In', '2024-04-29 14:42:40', 1),
	(653, 'admin', 'Add Record: item_type Laptop', '2024-04-29 14:42:46', 2),
	(654, 'admin', 'Add Record: item_type Comp. Desktop', '2024-04-29 14:42:56', 2),
	(655, 'admin', 'Add Record: item_type Tablet', '2024-04-29 14:43:04', 2),
	(656, 'admin', 'Logged Out', '2024-04-29 14:44:17', 1),
	(657, 'admin', 'Logged In', '2024-04-29 14:44:33', 1),
	(658, 'admin', 'Add Record: item_brand Intel', '2024-04-29 14:47:01', 2),
	(659, 'admin', 'Logged Out', '2024-04-29 15:06:19', 1),
	(660, 'admin', 'Logged In', '2024-04-29 15:58:17', 1),
	(661, 'admin', 'Logged Out', '2024-04-29 15:59:27', 1),
	(662, 'admin', 'Logged In', '2024-04-29 16:22:11', 1),
	(663, 'admin', 'Logged Out', '2024-04-29 16:22:44', 1),
	(664, 'admin', 'Logged In', '2024-04-29 16:23:24', 1),
	(665, 'admin', 'Logged Out', '2024-04-29 16:24:41', 1),
	(666, 'admin', 'Logged In', '2024-04-29 16:26:25', 1),
	(667, 'admin', 'Logged Out', '2024-04-29 16:26:30', 1),
	(668, 'admin', 'Logged In', '2024-04-29 16:27:17', 1),
	(669, 'admin', 'Add Record: Item Supplier-James & Co.', '2024-04-29 16:27:41', 2),
	(670, 'admin', 'Logged Out', '2024-04-29 16:36:36', 1),
	(671, 'admin', 'Logged In', '2024-04-29 16:37:40', 1),
	(672, 'admin', 'Logged Out', '2024-04-29 16:39:01', 1),
	(673, 'admin', 'Logged In', '2024-04-29 16:39:16', 1),
	(674, 'admin', 'Add Record: Item Supplier-D4C Ugay Limited', '2024-04-29 16:40:01', 2),
	(675, 'admin', 'Logged Out', '2024-04-29 16:40:18', 1),
	(676, 'admin', 'Logged In', '2024-04-30 08:34:13', 1),
	(677, 'admin', 'Logged Out', '2024-04-30 08:38:45', 1),
	(678, 'admin', 'Logged In', '2024-04-30 08:38:49', 1),
	(679, 'admin', 'Logged Out', '2024-04-30 08:39:26', 1),
	(680, 'admin', 'Logged In', '2024-04-30 08:51:52', 1),
	(681, 'admin', 'Logged Out', '2024-04-30 08:52:00', 1),
	(682, 'admin', 'Logged In', '2024-04-30 08:52:03', 1),
	(683, 'admin', 'Logged Out', '2024-04-30 08:52:19', 1),
	(684, 'admin', 'Logged In', '2024-04-30 08:57:02', 1),
	(685, 'admin', 'Logged Out', '2024-04-30 08:57:17', 1),
	(686, 'admin', 'Logged In', '2024-04-30 09:01:01', 1),
	(687, 'admin', 'Logged Out', '2024-04-30 09:03:58', 1),
	(688, 'admin', 'Logged In', '2024-04-30 09:15:56', 1),
	(689, 'admin', 'Logged Out', '2024-04-30 09:16:26', 1),
	(690, 'admin', 'Logged In', '2024-04-30 09:16:39', 1),
	(691, 'admin', 'Logged Out', '2024-04-30 09:18:14', 1),
	(692, 'admin', 'Logged In', '2024-04-30 09:33:42', 1),
	(693, 'admin', 'Logged Out', '2024-04-30 09:36:22', 1),
	(694, 'admin', 'Logged In', '2024-04-30 09:43:42', 1),
	(695, 'admin', 'Logged Out', '2024-04-30 09:45:58', 1),
	(696, 'admin', 'Logged In', '2024-04-30 09:54:32', 1),
	(697, 'admin', 'Add Record: item_type-Mouse Pad', '2024-04-30 09:59:25', 2),
	(698, 'admin', 'Add Record: item_brand-ASUS', '2024-04-30 10:00:21', 2),
	(699, 'admin', 'Logged Out', '2024-04-30 10:11:21', 1),
	(700, 'admin', 'Logged In', '2024-04-30 10:43:38', 1),
	(701, 'admin', 'Logged In', '2024-04-30 10:44:34', 1),
	(702, 'admin', 'Logged In', '2024-04-30 11:00:28', 1),
	(703, 'admin', 'Logged Out', '2024-04-30 11:00:56', 1),
	(704, 'admin', 'Logged In', '2024-04-30 15:48:50', 1),
	(705, 'admin', 'Logged In', '2024-04-30 16:06:45', 1),
	(706, 'admin', 'Logged Out', '2024-04-30 16:07:59', 1),
	(707, 'admin', 'Logged In', '2024-04-30 16:08:24', 1),
	(708, 'admin', 'Logged Out', '2024-04-30 16:08:54', 1),
	(709, 'admin', 'Logged In', '2024-04-30 16:09:18', 1),
	(710, 'admin', 'Add Record: Item Description-I2CP640FEIXL', '2024-04-30 16:10:09', 2),
	(711, 'admin', 'Add Record: Item-721', '2024-04-30 16:10:12', 2),
	(712, 'admin', 'Logged Out', '2024-04-30 16:19:07', 1);

-- Dumping structure for table db_ims.nature_table
CREATE TABLE IF NOT EXISTS `nature_table` (
  `nature_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`nature_id`) USING BTREE,
  UNIQUE KEY `Column 2` (`code`) USING BTREE,
  UNIQUE KEY `title` (`title`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.nature_table: ~7 rows (approximately)
INSERT INTO `nature_table` (`nature_id`, `code`, `title`, `description`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(1, 'NAT000000001', 'NATURAL TITLE', NULL, 1, 'james', '2024-04-02 10:04:23', NULL, NULL),
	(2, 'NAT000000002', 'mama mo', 'qewrteyeu', 1, 'james', '2024-04-02 14:39:05', NULL, NULL),
	(3, 'NAT000000003', 'ate mo', 'savSXVCxz', 0, 'james', '2024-04-02 15:14:45', NULL, NULL),
	(4, 'NAT000000004', 'Protein Powder', 'Not really', 1, 'james', '2024-04-11 16:13:58', NULL, NULL),
	(5, 'NAT000000005', 'Monggo', 'Best Food', 1, 'james', '2024-04-11 16:14:53', NULL, NULL),
	(6, 'NAT000000006', 'Milo', 'Milo Everyday', 0, 'james', '2024-04-11 16:15:53', NULL, NULL),
	(7, 'NAT000000007', 'Tiger', 'Tiger Chocolate Biscuits', 1, 'james', '2024-04-11 16:19:14', NULL, NULL);

-- Dumping structure for table db_ims.office_table
CREATE TABLE IF NOT EXISTS `office_table` (
  `office_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text,
  `sector_code` varchar(12) NOT NULL DEFAULT '',
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`office_id`) USING BTREE,
  UNIQUE KEY `office_name` (`title`) USING BTREE,
  UNIQUE KEY `code` (`code`),
  KEY `division_id` (`sector_code`) USING BTREE,
  CONSTRAINT `FK_office_table_sector_table` FOREIGN KEY (`sector_code`) REFERENCES `sector_table` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.office_table: ~3 rows (approximately)
INSERT INTO `office_table` (`office_id`, `code`, `title`, `description`, `sector_code`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(2, 'OFC000000001', 'OFFICE A', NULL, 'SEC000000001', 1, 'james', '2024-04-02 09:49:09', NULL, NULL),
	(3, 'OFC000000002', 'papa mo', 'svadgfasvcxczcvxz', 'SEC000000001', 1, 'james', '2024-04-02 15:02:54', NULL, NULL),
	(4, 'OFC000000003', 'ate mo', 'vasVZXVx', 'SEC000000002', 1, 'james', '2024-04-02 15:14:51', NULL, NULL);

-- Dumping structure for table db_ims.position_table
CREATE TABLE IF NOT EXISTS `position_table` (
  `position_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_dated` datetime DEFAULT NULL,
  PRIMARY KEY (`position_id`),
  UNIQUE KEY `position_title` (`title`) USING BTREE,
  UNIQUE KEY `code` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.position_table: ~2 rows (approximately)
INSERT INTO `position_table` (`position_id`, `code`, `title`, `description`, `status`, `created_by`, `created_date`, `updated_by`, `updated_dated`) VALUES
	(1, 'POS000000001', 'POSITION A', NULL, 0, 'james', '2024-04-02 09:01:20', NULL, NULL),
	(2, 'POS000000002', 'papa mo', 'qwqwertyuiopasdfghjklzxcvbnm', 1, 'james', '2024-04-02 14:43:18', NULL, NULL);

-- Dumping structure for table db_ims.remarks_table
CREATE TABLE IF NOT EXISTS `remarks_table` (
  `remarks_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) NOT NULL,
  `description` mediumtext CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`remarks_id`),
  UNIQUE KEY `code` (`code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.remarks_table: ~0 rows (approximately)

-- Dumping structure for table db_ims.section_table
CREATE TABLE IF NOT EXISTS `section_table` (
  `section_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) NOT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  `division_code` varchar(12) NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`section_id`) USING BTREE,
  UNIQUE KEY `code` (`code`),
  KEY `division_code` (`division_code`),
  CONSTRAINT `FK_section_table_division_table` FOREIGN KEY (`division_code`) REFERENCES `division_table` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.section_table: ~3 rows (approximately)
INSERT INTO `section_table` (`section_id`, `code`, `title`, `description`, `division_code`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(3, 'SXN000000001', 'SECTION A', 'asd', 'DIV000000001', 1, 'james', '2024-04-02 10:05:26', NULL, NULL),
	(4, 'SXN000000002', 'mama mo', 'dasfasf', 'DIV000000001', 1, 'james', '2024-04-02 14:58:20', NULL, NULL),
	(5, 'SXN000000003', 'ate mo', 'casfcas', 'DIV000000001', 1, 'james', '2024-04-02 15:15:05', NULL, NULL);

-- Dumping structure for table db_ims.sector_table
CREATE TABLE IF NOT EXISTS `sector_table` (
  `sector_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `title` varchar(128) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`sector_id`) USING BTREE,
  UNIQUE KEY `sector_title` (`title`) USING BTREE,
  UNIQUE KEY `code` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.sector_table: ~3 rows (approximately)
INSERT INTO `sector_table` (`sector_id`, `code`, `title`, `description`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(1, 'SEC000000001', 'TEST SECTOR A', NULL, 1, 'james', '2024-04-02 09:06:14', NULL, NULL),
	(2, 'SEC000000002', 'papa moo', 'qsfdfgfzvcxzvasd', 1, 'james', '2024-04-02 14:53:48', NULL, NULL),
	(3, 'SEC000000003', 'ate mo', 'casVSV', 1, 'james', '2024-04-02 15:15:10', NULL, NULL);

-- Dumping structure for table db_ims.status_table
CREATE TABLE IF NOT EXISTS `status_table` (
  `state_id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `title` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `description` text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  `created_by` varchar(50) NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`state_id`),
  UNIQUE KEY `state_title` (`title`) USING BTREE,
  UNIQUE KEY `status_code` (`code`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.status_table: ~2 rows (approximately)
INSERT INTO `status_table` (`state_id`, `code`, `title`, `description`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(1, 'STS000000001', 'Active', 'Usable record', 'System', '2024-04-02 08:22:55', NULL, NULL),
	(2, 'STS000000002', 'Inactive', 'Deactivated record', 'System', '2024-04-02 08:23:23', NULL, NULL);

-- Dumping structure for table db_ims.user_access_table
CREATE TABLE IF NOT EXISTS `user_access_table` (
  `uacc_id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) NOT NULL,
  `dashboard` int NOT NULL DEFAULT (1),
  PRIMARY KEY (`uacc_id`),
  KEY `user_name` (`user_name`),
  CONSTRAINT `FK_user_access_table_user_info_table` FOREIGN KEY (`user_name`) REFERENCES `user_info_table` (`user_name`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.user_access_table: ~0 rows (approximately)

-- Dumping structure for table db_ims.user_cred_table
CREATE TABLE IF NOT EXISTS `user_cred_table` (
  `uc_id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) NOT NULL,
  `password` varchar(48) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`uc_id`),
  UNIQUE KEY `user_name` (`user_name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.user_cred_table: ~0 rows (approximately)
INSERT INTO `user_cred_table` (`uc_id`, `user_name`, `password`) VALUES
	(3, 'admin', 'wuPhfMB5XcLu0ff+n3MS7VmtVjHzcDMjEM/ww1t7uPTiC2tt');

-- Dumping structure for table db_ims.user_info_table
CREATE TABLE IF NOT EXISTS `user_info_table` (
  `u_id` int NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) NOT NULL,
  `employee_code` varchar(12) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `role_title` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `status` int NOT NULL DEFAULT '1',
  `created_by` varchar(50) NOT NULL,
  `created_date` datetime NOT NULL,
  `updated_by` varchar(50) DEFAULT NULL,
  `updated_date` datetime DEFAULT NULL,
  PRIMARY KEY (`u_id`) USING BTREE,
  KEY `user_name` (`user_name`),
  KEY `role_title` (`role_title`),
  KEY `employee_no` (`employee_code`) USING BTREE,
  CONSTRAINT `FK_user_info_table_emp_info_table` FOREIGN KEY (`employee_code`) REFERENCES `emp_info_table` (`code`),
  CONSTRAINT `FK_user_info_table_user_cred_table` FOREIGN KEY (`user_name`) REFERENCES `user_cred_table` (`user_name`),
  CONSTRAINT `FK_user_info_table_user_role_table` FOREIGN KEY (`role_title`) REFERENCES `user_role_table` (`role_title`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.user_info_table: ~0 rows (approximately)
INSERT INTO `user_info_table` (`u_id`, `user_name`, `employee_code`, `role_title`, `status`, `created_by`, `created_date`, `updated_by`, `updated_date`) VALUES
	(6, 'admin', 'EMPL00000001', 'Super Admin', 1, 'james', '2024-03-31 15:14:43', NULL, NULL);

-- Dumping structure for table db_ims.user_role_table
CREATE TABLE IF NOT EXISTS `user_role_table` (
  `urt_id` int NOT NULL AUTO_INCREMENT,
  `role_title` varchar(50) NOT NULL,
  `dashboard` int NOT NULL,
  PRIMARY KEY (`urt_id`) USING BTREE,
  UNIQUE KEY `role_title` (`role_title`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;

-- Dumping data for table db_ims.user_role_table: ~0 rows (approximately)
INSERT INTO `user_role_table` (`urt_id`, `role_title`, `dashboard`) VALUES
	(1, 'Super Admin', 1);

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

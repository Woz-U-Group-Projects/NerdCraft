-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: nerdcraft
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `addresses`
--

DROP TABLE IF EXISTS `addresses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `addresses` (
  `CustomerID` int NOT NULL,
  `Address1` varchar(200) NOT NULL,
  `Address2` varchar(200) NOT NULL,
  `City` varchar(85) NOT NULL,
  `StateProvince` varchar(50) NOT NULL,
  `Country` varchar(50) NOT NULL,
  `PostalID` varchar(10) NOT NULL,
  PRIMARY KEY (`CustomerID`,`Address1`,`Address2`,`City`,`StateProvince`,`Country`,`PostalID`),
  CONSTRAINT `addresses_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `addresses`
--

LOCK TABLES `addresses` WRITE;
/*!40000 ALTER TABLE `addresses` DISABLE KEYS */;
/*!40000 ALTER TABLE `addresses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cards`
--

DROP TABLE IF EXISTS `cards`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cards` (
  `CustomerID` int NOT NULL,
  `CardComp` varchar(20) NOT NULL,
  `CardName` varchar(20) NOT NULL,
  `CardNum` varchar(16) NOT NULL,
  `CardExp` date NOT NULL,
  `CardSec` varchar(3) NOT NULL,
  PRIMARY KEY (`CustomerID`,`CardName`,`CardNum`,`CardComp`,`CardExp`,`CardSec`),
  UNIQUE KEY `CardNum` (`CardNum`),
  UNIQUE KEY `CardSec` (`CardSec`),
  CONSTRAINT `cards_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cards`
--

LOCK TABLES `cards` WRITE;
/*!40000 ALTER TABLE `cards` DISABLE KEYS */;
/*!40000 ALTER TABLE `cards` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `CustomerID` int NOT NULL AUTO_INCREMENT,
  `Userpass` varchar(30) NOT NULL,
  `HasMembership` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`CustomerID`),
  UNIQUE KEY `CustomerID` (`CustomerID`),
  CONSTRAINT `customer_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `person` (`ID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discount`
--

DROP TABLE IF EXISTS `discount`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discount` (
  `DiscountID` int NOT NULL,
  `DiscountPercent` decimal(2,2) DEFAULT NULL,
  `DiscountCode` varchar(10) DEFAULT NULL,
  `Valid` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`DiscountID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discount`
--

LOCK TABLES `discount` WRITE;
/*!40000 ALTER TABLE `discount` DISABLE KEYS */;
/*!40000 ALTER TABLE `discount` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `ID` int NOT NULL,
  `EmployeeEmail` varchar(50) NOT NULL,
  `Supervisor` varchar(50) DEFAULT NULL,
  `Userpass` varchar(30) NOT NULL,
  PRIMARY KEY (`EmployeeEmail`),
  KEY `Supervisor` (`Supervisor`),
  KEY `ID` (`ID`),
  CONSTRAINT `employee_ibfk_1` FOREIGN KEY (`Supervisor`) REFERENCES `employee` (`EmployeeEmail`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `employee_ibfk_2` FOREIGN KEY (`ID`) REFERENCES `person` (`ID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item` (
  `ItemID` int NOT NULL AUTO_INCREMENT,
  `Quantity` int NOT NULL,
  `Price` decimal(9,2) NOT NULL,
  `ItemType` varchar(30) NOT NULL,
  `Seller` varchar(30) NOT NULL,
  `ItemDesc` varchar(200) DEFAULT NULL,
  `Category` varchar(30) NOT NULL,
  `Image` longblob NOT NULL,
  PRIMARY KEY (`ItemID`),
  UNIQUE KEY `ItemID` (`ItemID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordereditems`
--

DROP TABLE IF EXISTS `ordereditems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordereditems` (
  `OrderID` int NOT NULL,
  `ItemID` int NOT NULL,
  `Quantity` int DEFAULT NULL,
  PRIMARY KEY (`OrderID`,`ItemID`),
  KEY `ItemID` (`ItemID`),
  CONSTRAINT `ordereditems_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderNum`) ON UPDATE CASCADE,
  CONSTRAINT `ordereditems_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordereditems`
--

LOCK TABLES `ordereditems` WRITE;
/*!40000 ALTER TABLE `ordereditems` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordereditems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderNum` int NOT NULL AUTO_INCREMENT,
  `CustomerID` int DEFAULT NULL,
  `OrderDate` date NOT NULL,
  `Completed` tinyint(1) DEFAULT NULL,
  `OrderName` varchar(30) NOT NULL,
  `OrderEmail` varchar(50) NOT NULL,
  PRIMARY KEY (`OrderNum`),
  UNIQUE KEY `OrderNum` (`OrderNum`),
  KEY `CustomerID` (`CustomerID`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `OrderID` int NOT NULL,
  `CardComp` varchar(20) NOT NULL,
  `CardName` varchar(20) NOT NULL,
  `CardNum` varchar(16) NOT NULL,
  `CardExp` date NOT NULL,
  `CardSec` varchar(3) NOT NULL,
  `Address1` varchar(200) NOT NULL,
  `Address2` varchar(200) DEFAULT NULL,
  `City` varchar(85) NOT NULL,
  `StateProvince` varchar(50) NOT NULL,
  `Country` varchar(50) NOT NULL,
  `PostalID` varchar(10) NOT NULL,
  PRIMARY KEY (`OrderID`),
  UNIQUE KEY `CardNum` (`CardNum`),
  UNIQUE KEY `CardSec` (`CardSec`),
  CONSTRAINT `payment_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderNum`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `person`
--

DROP TABLE IF EXISTS `person`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `person` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(50) NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `FirstName` varchar(30) NOT NULL,
  `DateofBirth` date NOT NULL,
  `Phone` varchar(15) NOT NULL,
  `DateJoined` date NOT NULL,
  `IsEmployee` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `person`
--

LOCK TABLES `person` WRITE;
/*!40000 ALTER TABLE `person` DISABLE KEYS */;
/*!40000 ALTER TABLE `person` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `returnment`
--

DROP TABLE IF EXISTS `returnment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `returnment` (
  `OrderID` int NOT NULL,
  `ItemID` int NOT NULL,
  `Quantity` int DEFAULT NULL,
  `Comments` varchar(200) NOT NULL,
  `Approval` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`OrderID`,`ItemID`),
  KEY `ItemID` (`ItemID`),
  CONSTRAINT `returnment_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `ordereditems` (`OrderID`) ON UPDATE CASCADE,
  CONSTRAINT `returnment_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `ordereditems` (`ItemID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `returnment`
--

LOCK TABLES `returnment` WRITE;
/*!40000 ALTER TABLE `returnment` DISABLE KEYS */;
/*!40000 ALTER TABLE `returnment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reviews` (
  `CustomerID` int NOT NULL,
  `ItemID` int NOT NULL,
  `Ratings` int NOT NULL,
  `Comments` varchar(200) NOT NULL,
  PRIMARY KEY (`CustomerID`,`ItemID`),
  KEY `ItemID` (`ItemID`),
  CONSTRAINT `reviews_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON UPDATE CASCADE,
  CONSTRAINT `reviews_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shipment`
--

DROP TABLE IF EXISTS `shipment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shipment` (
  `OrderID` int NOT NULL,
  `Address1` varchar(200) NOT NULL,
  `Address2` varchar(200) DEFAULT NULL,
  `City` varchar(85) NOT NULL,
  `StateProvince` varchar(50) NOT NULL,
  `Country` varchar(50) NOT NULL,
  `PostalID` varchar(10) NOT NULL,
  `Fee` int NOT NULL,
  `Company` varchar(20) NOT NULL,
  `ShipName` varchar(20) NOT NULL,
  PRIMARY KEY (`OrderID`),
  CONSTRAINT `shipment_ibfk_1` FOREIGN KEY (`OrderID`) REFERENCES `orders` (`OrderNum`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shipment`
--

LOCK TABLES `shipment` WRITE;
/*!40000 ALTER TABLE `shipment` DISABLE KEYS */;
/*!40000 ALTER TABLE `shipment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shoppingcart`
--

DROP TABLE IF EXISTS `shoppingcart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shoppingcart` (
  `CustomerID` int NOT NULL,
  `ItemID` int NOT NULL,
  `Quantity` int NOT NULL,
  PRIMARY KEY (`CustomerID`,`ItemID`),
  KEY `ItemID` (`ItemID`),
  CONSTRAINT `shoppingcart_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `shoppingcart_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shoppingcart`
--

LOCK TABLES `shoppingcart` WRITE;
/*!40000 ALTER TABLE `shoppingcart` DISABLE KEYS */;
/*!40000 ALTER TABLE `shoppingcart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wishlist`
--

DROP TABLE IF EXISTS `wishlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `wishlist` (
  `CustomerID` int NOT NULL,
  `ItemID` int NOT NULL,
  PRIMARY KEY (`CustomerID`,`ItemID`),
  KEY `ItemID` (`ItemID`),
  CONSTRAINT `wishlist_ibfk_1` FOREIGN KEY (`CustomerID`) REFERENCES `customer` (`CustomerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `wishlist_ibfk_2` FOREIGN KEY (`ItemID`) REFERENCES `item` (`ItemID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wishlist`
--

LOCK TABLES `wishlist` WRITE;
/*!40000 ALTER TABLE `wishlist` DISABLE KEYS */;
/*!40000 ALTER TABLE `wishlist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-03 22:28:58

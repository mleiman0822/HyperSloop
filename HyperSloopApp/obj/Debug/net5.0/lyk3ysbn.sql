ALTER DATABASE CHARACTER SET utf8mb4;
CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Location` (
    `LocationId` int NOT NULL AUTO_INCREMENT,
    `Name` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Location` PRIMARY KEY (`LocationId`)
) CHARACTER SET utf8mb4;

CREATE TABLE `Users` (
    `UserId` int NOT NULL AUTO_INCREMENT,
    `Name` longtext CHARACTER SET utf8mb4 NULL,
    `Email` longtext CHARACTER SET utf8mb4 NULL,
    `ScanEventId` int NOT NULL,
    CONSTRAINT `PK_Users` PRIMARY KEY (`UserId`)
) CHARACTER SET utf8mb4;

CREATE TABLE `Slides` (
    `SlideId` int NOT NULL AUTO_INCREMENT,
    `HexColor` longtext CHARACTER SET utf8mb4 NULL,
    `LengthInFeet` double NOT NULL,
    `HeightInFeet` double NOT NULL,
    `StartingFloor` int NOT NULL,
    `EndingFloor` int NOT NULL,
    `LocationId` int NOT NULL,
    CONSTRAINT `PK_Slides` PRIMARY KEY (`SlideId`),
    CONSTRAINT `FK_Slides_Location_LocationId` FOREIGN KEY (`LocationId`) REFERENCES `Location` (`LocationId`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE TABLE `ScanEvents` (
    `ScanEventId` int NOT NULL AUTO_INCREMENT,
    `UserId` int NULL,
    `SlideId` int NULL,
    `StartTime` datetime(6) NOT NULL,
    CONSTRAINT `PK_ScanEvents` PRIMARY KEY (`ScanEventId`),
    CONSTRAINT `FK_ScanEvents_Slides_SlideId` FOREIGN KEY (`SlideId`) REFERENCES `Slides` (`SlideId`) ON DELETE RESTRICT,
    CONSTRAINT `FK_ScanEvents_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`UserId`) ON DELETE RESTRICT
) CHARACTER SET utf8mb4;

CREATE TABLE `Sensors` (
    `SensorId` int NOT NULL AUTO_INCREMENT,
    `SlideId` int NOT NULL,
    `PercentageOfSlide` double NOT NULL,
    CONSTRAINT `PK_Sensors` PRIMARY KEY (`SensorId`),
    CONSTRAINT `FK_Sensors_Slides_SlideId` FOREIGN KEY (`SlideId`) REFERENCES `Slides` (`SlideId`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE TABLE `SensorEvents` (
    `SensorEventId` int NOT NULL AUTO_INCREMENT,
    `SensorId` int NOT NULL,
    `Time` datetime(6) NOT NULL,
    CONSTRAINT `PK_SensorEvents` PRIMARY KEY (`SensorEventId`),
    CONSTRAINT `FK_SensorEvents_Sensors_SensorId` FOREIGN KEY (`SensorId`) REFERENCES `Sensors` (`SensorId`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE TABLE `SlideEvents` (
    `SlideEventId` int NOT NULL AUTO_INCREMENT,
    `SlideId` int NOT NULL,
    `UserId` int NOT NULL,
    `ScanEventId` int NOT NULL,
    `StartingSensorEventId` int NOT NULL,
    `EndingSensorEventId` int NOT NULL,
    CONSTRAINT `PK_SlideEvents` PRIMARY KEY (`SlideEventId`),
    CONSTRAINT `FK_SlideEvents_ScanEvents_ScanEventId` FOREIGN KEY (`ScanEventId`) REFERENCES `ScanEvents` (`ScanEventId`) ON DELETE CASCADE,
    CONSTRAINT `FK_SlideEvents_SensorEvents_EndingSensorEventId` FOREIGN KEY (`EndingSensorEventId`) REFERENCES `SensorEvents` (`SensorEventId`) ON DELETE CASCADE,
    CONSTRAINT `FK_SlideEvents_SensorEvents_StartingSensorEventId` FOREIGN KEY (`StartingSensorEventId`) REFERENCES `SensorEvents` (`SensorEventId`) ON DELETE CASCADE,
    CONSTRAINT `FK_SlideEvents_Slides_SlideId` FOREIGN KEY (`SlideId`) REFERENCES `Slides` (`SlideId`) ON DELETE CASCADE,
    CONSTRAINT `FK_SlideEvents_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `Users` (`UserId`) ON DELETE CASCADE
) CHARACTER SET utf8mb4;

CREATE INDEX `IX_ScanEvents_SlideId` ON `ScanEvents` (`SlideId`);

CREATE INDEX `IX_ScanEvents_UserId` ON `ScanEvents` (`UserId`);

CREATE INDEX `IX_SensorEvents_SensorId` ON `SensorEvents` (`SensorId`);

CREATE INDEX `IX_Sensors_SlideId` ON `Sensors` (`SlideId`);

CREATE INDEX `IX_SlideEvents_EndingSensorEventId` ON `SlideEvents` (`EndingSensorEventId`);

CREATE INDEX `IX_SlideEvents_ScanEventId` ON `SlideEvents` (`ScanEventId`);

CREATE INDEX `IX_SlideEvents_SlideId` ON `SlideEvents` (`SlideId`);

CREATE INDEX `IX_SlideEvents_StartingSensorEventId` ON `SlideEvents` (`StartingSensorEventId`);

CREATE INDEX `IX_SlideEvents_UserId` ON `SlideEvents` (`UserId`);

CREATE INDEX `IX_Slides_LocationId` ON `Slides` (`LocationId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20210604135210_init', '5.0.5');

COMMIT;


CREATE SCHEMA IF NOT EXISTS `kvdb`;

CREATE TABLE IF NOT EXISTS `kvdb`.`user` (
  `userId` INT NOT NULL AUTO_INCREMENT,
  `firstName` VARCHAR(45) NULL,
  `lastName` VARCHAR(45) NULL,
  `dateOfBirth` DATETIME NULL,
  `email` VARCHAR(45) NULL,
  `password` VARCHAR(45) NULL,
  PRIMARY KEY (`userId`));
  INSERT INTO `kvdb`.`user` (`userId`, `firstName`, `lastName`, `dateOfBirth`, `email`, `password`) VALUES ('1', 'test', 'user', '2000-01-01 00:00:00', 'test@mail.de', 'Passwort1');

  

CREATE TABLE IF NOT EXISTS `kvdb`.`admin`(
	`adminId` INT NOT NULL AUTO_INCREMENT,
    `email` VARCHAR(45) NULL,
    `password` VARCHAR(45) NULL,
    PRIMARY KEY (`adminId`));
	INSERT INTO `kvdb`.`admin` (`adminId`, `email`, `password`) VALUES ('1', 'dennis.echtner@its-stuttgart.de', '123123');


CREATE TABLE IF NOT EXISTS `kvdb`.`course` (
  `courseId` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `description` VARCHAR(256) NULL,
  `maxUsers` INT NULL,
  `currentUsers` INT NULL,
  `startDateTime` DATETIME NULL,
  `duration` INT NULL,
  `registrDeadline` DATETIME NULL,
  `adminId` INT NOT NULL,
  PRIMARY KEY (`courseId`),
  INDEX `adminFk_idx` (`adminId` ASC),
  CONSTRAINT `adminFk`
    FOREIGN KEY (`adminId`)
    REFERENCES `kvdb`.`admin` (`adminId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
    INSERT INTO `kvdb`.`course` (`courseId`, `name`, `description`, `maxUsers`, `currentUsers`, `startDateTime`, `duration`, `registrDeadline`, `adminId`) VALUES ('1', 'kurs1', 'test', '10', '5', '2024-02-21 10:00:00', '60', '2024-02-20 10:00:00', '1');
	INSERT INTO `kvdb`.`course` (`courseId`, `name`, `description`, `maxUsers`, `currentUsers`, `startDateTime`, `duration`, `registrDeadline`, `adminId`) VALUES ('2', 'kurs2', 'test2', '20', '10', '2024-02-22 11:00:00', '30', '2024-02-21 19:00:00', '1');
  
CREATE TABLE IF NOT EXISTS `kvdb`.`matchcourseuser` (
  `matchId` INT NOT NULL AUTO_INCREMENT,
  `courseId` INT NULL,
  `userId` INT NULL,
  PRIMARY KEY (`matchId`),
  INDEX `courseFk_idx` (`courseId` ASC),
  INDEX `userFk_idx` (`userId` ASC),
  CONSTRAINT `courseFk`
    FOREIGN KEY (`courseId`)
    REFERENCES `kvdb`.`course` (`courseId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `userFk`
    FOREIGN KEY (`userId`)
    REFERENCES `kvdb`.`user` (`userId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

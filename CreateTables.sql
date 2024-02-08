CREATE TABLE IF NOT EXISTS `test`.`user` (
  `userId` INT NOT NULL AUTO_INCREMENT,
  `firstName` VARCHAR(45) NULL,
  `lastName` VARCHAR(45) NULL,
  `dateOfBirth` DATETIME NULL,
  `email` VARCHAR(45) NULL,
  `password` VARCHAR(45) NULL,
  PRIMARY KEY (`userId`));
  INSERT INTO `test`.`user` (`userId`, `firstName`, `lastName`, `dateOfBirth`, `email`, `password`) VALUES ('1', 'test', 'user', '2000-01-01 00:00:00', 'test@mail.de', 'Passwort1');

  

CREATE TABLE IF NOT EXISTS `test`.`admin`(
	`adminId` INT NOT NULL AUTO_INCREMENT,
    `email` VARCHAR(45) NULL,
    `password` VARCHAR(45) NULL,
    PRIMARY KEY (`adminId`));
	INSERT INTO `test`.`admin` (`adminId`, `email`, `password`) VALUES ('1', 'dennis.echtner@its-stuttgart.de', '123123');


CREATE TABLE IF NOT EXISTS `test`.`course` (
  `courseId` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `description` VARCHAR(256) NULL,
  `maxUsers` INT NULL,
  `startDateTime` DATETIME NULL,
  `duration` INT NULL,
  `registrDeadline` DATETIME NULL,
  `adminId` INT NOT NULL,
  PRIMARY KEY (`courseId`),
  INDEX `adminFk_idx` (`adminId` ASC),
  CONSTRAINT `adminFk`
    FOREIGN KEY (`adminId`)
    REFERENCES `test`.`admin` (`adminId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
  
CREATE TABLE IF NOT EXISTS `test`.`matchcourseuser` (
  `matchId` INT NOT NULL AUTO_INCREMENT,
  `courseId` INT NULL,
  `userId` INT NULL,
  PRIMARY KEY (`matchId`),
  INDEX `courseFk_idx` (`courseId` ASC),
  INDEX `userFk_idx` (`userId` ASC),
  CONSTRAINT `courseFk`
    FOREIGN KEY (`courseId`)
    REFERENCES `test`.`course` (`courseId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `userFk`
    FOREIGN KEY (`userId`)
    REFERENCES `test`.`user` (`userId`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

CREATE TABLE `test`.`user` (
  `userId` INT NOT NULL AUTO_INCREMENT,
  `firstName` VARCHAR(45) NULL,
  `lastName` VARCHAR(45) NULL,
  `dateOfBirth` DATETIME NULL,
  `email` VARCHAR(45) NULL,
  PRIMARY KEY (`userId`));

CREATE TABLE `test`.`course` (
  `courseId` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `description` VARCHAR(256) NULL,
  `maxUsers` INT NULL,
  `startDateTime` DATETIME NULL,
  `duration` INT NULL,
  `registrDeadline` DATETIME NULL,
  PRIMARY KEY (`courseId`));
  
CREATE TABLE `test`.`matchcourseuser` (
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

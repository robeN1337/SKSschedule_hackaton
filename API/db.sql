-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema db_sks
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema db_sks
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `db_sks` DEFAULT CHARACTER SET utf8 ;
USE `db_sks` ;

-- -----------------------------------------------------
-- Table `db_sks`.`group`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sks`.`group` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sks`.`role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sks`.`role` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sks`.`user`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sks`.`user` (
  `login` VARCHAR(45) NOT NULL,
  `password` VARCHAR(30) NOT NULL,
  `fio` VARCHAR(70) NOT NULL,
  `birthday` DATE NOT NULL,
  `group_id` INT NULL,
  `role_id` INT NOT NULL,
  PRIMARY KEY (`login`),
  INDEX `fk_user_group_idx` (`group_id` ASC) VISIBLE,
  INDEX `fk_user_role1_idx` (`role_id` ASC) VISIBLE,
  CONSTRAINT `fk_user_group`
    FOREIGN KEY (`group_id`)
    REFERENCES `db_sks`.`group` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_user_role1`
    FOREIGN KEY (`role_id`)
    REFERENCES `db_sks`.`role` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sks`.`subject`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sks`.`subject` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `description` TEXT(250) NULL,
  `cabinet` VARCHAR(4) NOT NULL,
  `user_login` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_subject_user1_idx` (`user_login` ASC) VISIBLE,
  CONSTRAINT `fk_subject_user1`
    FOREIGN KEY (`user_login`)
    REFERENCES `db_sks`.`user` (`login`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_sks`.`lesson`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_sks`.`lesson` (
  `group_id` INT NOT NULL,
  `subject_id` INT NOT NULL,
  `date` DATE NOT NULL,
  `number` INT NOT NULL,
  PRIMARY KEY (`group_id`, `subject_id`),
  INDEX `fk_lesson_group1_idx` (`group_id` ASC) VISIBLE,
  CONSTRAINT `fk_lesson_subject1`
    FOREIGN KEY (`subject_id`)
    REFERENCES `db_sks`.`subject` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_lesson_group1`
    FOREIGN KEY (`group_id`)
    REFERENCES `db_sks`.`group` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


/*
 * 说明：
 *	   以下SQL语句，是基于mysql，如需在sqlserver执行，需要将`替换为[和]
*/

CREATE DATABASE CodeBuild;

CREATE TABLE 
  `codebuild`.`DbConnectionString`(  
  `id` BIGINT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(128),
  `dbname` VARCHAR(128),
  `server` VARCHAR(64),
  `port` INT,
  `username` VARCHAR(128),
  `password` VARCHAR(128),
  `dbtype` VARCHAR(64),
  `other` VARCHAR(256),
  `description` VARCHAR(512),
  `remark` TEXT,
  PRIMARY KEY (`id`)
) ENGINE=INNODB CHARSET=utf8 COLLATE=utf8_general_ci;



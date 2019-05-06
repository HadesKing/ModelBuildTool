
/*
 * 说明：
 *	   以下SQL语句，是基于mysql，如需在sqlserver执行，需要将`替换为[和]
*/

CREATE DATABASE CodeBuild;

USE CodeBuild;

CREATE TABLE 
  `codebuild`.`DbConnectionString`(  
  `Id` BIGINT NOT NULL AUTO_INCREMENT COMMENT '自增',
  `Identity` varchar(64) NOT NULL COMMENT '身份认证',
  `Name` varchar(128) DEFAULT NULL COMMENT '配置名称',
  `DbName` varchar(128) DEFAULT NULL COMMENT '数据库名称',
  `Server` varchar(64) DEFAULT NULL COMMENT '数据库服务器地址/IP',
  `Port` int(11) DEFAULT NULL COMMENT '端口',
  `UserName` varchar(128) DEFAULT NULL COMMENT '登录数据库用户名',
  `Password` varchar(128) DEFAULT NULL COMMENT '密码',
  `DbType` varchar(64) DEFAULT NULL COMMENT '数据库类型',
  `Other` varchar(256) DEFAULT NULL COMMENT '连接字符串的其他信息',
  `Description` varchar(512) DEFAULT NULL COMMENT '描述信息',
  `Remark` text COMMENT '备注',
  `IsEnable` smallint(6) DEFAULT NULL COMMENT '是否启用',
  `CreateTime` datetime DEFAULT NULL COMMENT '创建时间',
  `CreateBy` varchar(64) DEFAULT NULL COMMENT '创建人',
  `LastUpdateTime` datetime DEFAULT NULL COMMENT '最后修改时间',
  `UpdateBy` varchar(64) DEFAULT NULL COMMENT '最后修改人',
  PRIMARY KEY (`id`)
) ENGINE=INNODB CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE `codebuild`.`CodeBuildTemplate`(  
  `Id` BIGINT NOT NULL AUTO_INCREMENT,
  `Identity` VARCHAR(64),
  `Name` VARCHAR(128),
  `AuthorInfo` VARCHAR(512),
  `UsingInfo` VARCHAR(512),
  `NamespaceInfo` VARCHAR(512),
  `ClassInfo` VARCHAR(512),
  `PropertyInfo` VARCHAR(512),
  `IsEnable` SMALLINT,
  `CreateTime` DATETIME,
  `CreateBy` VARCHAR(64),
  `LastUpdateTime` DATETIME,
  `UpdateBy` VARCHAR(64),
  PRIMARY KEY (`Id`)
) ENGINE=INNODB CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


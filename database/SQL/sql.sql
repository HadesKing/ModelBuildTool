
/*
 * ˵����
 *	   ����SQL��䣬�ǻ���mysql��������sqlserverִ�У���Ҫ��`�滻Ϊ[��]
*/

CREATE DATABASE CodeBuild;

CREATE TABLE 
  `codebuild`.`DbConnectionString`(  
  `Id` BIGINT NOT NULL AUTO_INCREMENT COMMENT '����',
  `Identity` varchar(64) NOT NULL COMMENT '�����֤',
  `Name` varchar(128) DEFAULT NULL COMMENT '��������',
  `DbName` varchar(128) DEFAULT NULL COMMENT '���ݿ�����',
  `Server` varchar(64) DEFAULT NULL COMMENT '���ݿ��������ַ/IP',
  `Port` int(11) DEFAULT NULL COMMENT '�˿�',
  `UserName` varchar(128) DEFAULT NULL COMMENT '��¼���ݿ��û���',
  `Password` varchar(128) DEFAULT NULL COMMENT '����',
  `DbType` varchar(64) DEFAULT NULL COMMENT '���ݿ�����',
  `Other` varchar(256) DEFAULT NULL COMMENT '�����ַ�����������Ϣ',
  `Description` varchar(512) DEFAULT NULL COMMENT '������Ϣ',
  `Remark` text COMMENT '��ע',
  `IsEnable` smallint(6) DEFAULT NULL COMMENT '�Ƿ�����',
  `CreateTime` datetime DEFAULT NULL COMMENT '����ʱ��',
  `CreateBy` varchar(64) DEFAULT NULL COMMENT '������',
  `LastUpdateTime` datetime DEFAULT NULL COMMENT '����޸�ʱ��',
  `UpdateBy` varchar(64) DEFAULT NULL COMMENT '����޸���',
  PRIMARY KEY (`id`)
) ENGINE=INNODB CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;



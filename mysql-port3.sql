create database teste;
use teste;
CREATE TABLE `teste`.`clientes` (
  `IdClientes` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  `Endereco` VARCHAR(45) NULL,
  `Telefone` VARCHAR(45) NULL,
  PRIMARY KEY (`IdClientes`));
select * from clientes;
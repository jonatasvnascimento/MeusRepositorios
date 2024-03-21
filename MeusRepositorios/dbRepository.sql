DROP DATABASE dbRepository;

CREATE DATABASE dbRepository;

USE dbRepository

CREATE TABLE MyRepository(
    Id int PRIMARY KEY IDENTITY,
    Nome NVARCHAR(200) NOT NULL,
    Descricao NVARCHAR(MAX) NOT NULL,
    Linguagem NVARCHAR(100) NOT NULL,
    DataAtualizacao DATETIME NOT NULL,
    DonoRepositorio NVARCHAR(500) NOT NULL
)

CREATE TABLE Favorite(
    Id int PRIMARY KEY IDENTITY,
    MyRepositoryId int NOT NULL,
    Nome NVARCHAR(120) NOT NULL,
    Descricao NVARCHAR(MAX) NOT NULL,
    Linguagem NVARCHAR(100) NOT NULL,
    DataAtualizacao DATETIME NOT NULL,
    DonoRepositorio NVARCHAR(200) NOT NULL
)


INSERT INTO dbRepository.dbo.MyRepository (Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (N'AutoUpdate',N'Sistema de atualização de aplicações com c# e powershell',N'C# e PowerShell','2024-03-20 23:46:58.177',N'Jonatas Nascimento');
INSERT INTO dbRepository.dbo.MyRepository (Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (N'ELanches',N'Ecommerce feito com ASP.NET MVC para gerenciamento de burgueria',N'C# ASP.NET MVC','2024-03-20 23:47:06.780',N'https://github.com/jonatasvnascimento/ELanches');
INSERT INTO dbRepository.dbo.MyRepository (Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (N'ComparacaoBases',N'Projeto de comparação de base Postgres sql para verificar banco de outras plantas',N'C#','2024-03-20 23:31:06.937',N'Jonatas Nascimento - Privado');
INSERT INTO dbRepository.dbo.MyRepository (Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (N'RatingBarbearia',N'Esse Projeto consiste em um App de Registro de Usuários, com as funcionalidades básicas de um CRUD ( Create / Read / Update / Delete ), utilizando o banco de Dados SQLite para gravação local dos dados. Ao rodar o projeto, ele verifica se o banco existe, caso não exista, ele cria o banco de dados e a estrutura da tabela, para já dar início a utilização do App.',N'JavaScript - ReactNative','2024-03-20 23:31:09.400',N'https://github.com/jonatasvnascimento/RatingBarbearia');
INSERT INTO dbRepository.dbo.MyRepository (Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (N'EstoqueEntityFramework',N'Sistema de estoque com EntityFramework',N'C#','2024-03-20 23:40:50.967',N'https://github.com/jonatasvnascimento/EstoqueEntityFramework');
INSERT INTO dbRepository.dbo.MyRepository (Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (N'AntennaSetupAPP',N'Sistema de configuração de antena RFID',N'C#','2024-03-20 23:43:56.850',N'https://github.com/jonatasvnascimento/AntennaSetupAPP');
INSERT INTO dbRepository.dbo.MyRepository (Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (N'ProjectEX',N'Projeto para migração de codigo de barra gerando sql server apartir de uma planilha excel',N'C#','2024-03-20 23:45:02.467',N'https://github.com/jonatasvnascimento/ProjectEX');
INSERT INTO dbRepository.dbo.MyRepository (Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (N'CrudCsharpMysql',N'Projeto simples crud com login completo e cadastro de usuario e de notas',N'C#','2024-03-20 23:46:20.777',N'https://github.com/jonatasvnascimento/CrudCsharpMysql');


INSERT INTO dbRepository.dbo.Favorite (MyRepositoryId,Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (1,N'AutoUpdate',N'Sistema de atualização de aplicações com c# e powershell',N'C# e PowerShell','2024-03-20 23:46:58.177',N'Jonatas Nascimento');
INSERT INTO dbRepository.dbo.Favorite (MyRepositoryId,Nome,Descricao,Linguagem,DataAtualizacao,DonoRepositorio)
    VALUES (2,N'ELanches',N'Ecommerce feito com ASP.NET MVC para gerenciamento de burgueria',N'C# ASP.NET MVC','2024-03-20 23:47:06.780',N'https://github.com/jonatasvnascimento/ELanches');



SELECT * FROM MyRepository

SELECT * FROM Favorite

--DROP TABLE MyRepository

--DROP TABLE Favorite

TRUNCATE TABLE MyRepository

TRUNCATE TABLE Favorite


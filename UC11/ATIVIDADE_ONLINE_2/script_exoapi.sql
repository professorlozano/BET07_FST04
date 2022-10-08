CREATE DATABASE dbExoAPI;

USE dbExoAPI;

CREATE TABLE Projetos 
(
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	Status VARCHAR(150) NOT NULL,
	Data_De_Inicio VARCHAR(10) NOT NULL,
	Area VARCHAR(150) NOT NULL
);

INSERT INTO Projetos (Titulo, Status, Data_De_Inicio, Area)
VALUES ('Projeto A', 'Em Planejamento', '10/04/2022', 'T.I.');

INSERT INTO Projetos (Titulo, Status, Data_De_Inicio, Area)
VALUES ('Projeto B', 'Iniciado', '18/02/2022', 'RH');

select * from Projetos;


CREATE TABLE Usuarios(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(255) NOT NULL UNIQUE,
	Senha VARCHAR(120) NOT NULL,
	Tipo CHAR(1) NOT NULL
);

INSERT INTO Usuarios VALUES ('teste@email.com.br','1234','0');

SELECT * FROM Usuarios;

SELECT * FROM Usuarios WHERE email = 'teste@email.com.br' AND senha='1234';
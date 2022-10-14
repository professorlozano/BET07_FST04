CREATE TABLE Usuarios(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(255) NOT NULL UNIQUE,
	Senha VARCHAR(120) NOT NULL,
	Tipo CHAR(1) NOT NULL
);

INSERT INTO Usuarios VALUES ('teste@email.com.br','1234','0');

SELECT * FROM Usuarios;

SELECT * FROM Usuarios WHERE email = 'teste@email.com.br' AND senha='1234';
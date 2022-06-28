-- criação do banco de dandod
CREATE DATABASE Escola;

-- criação da tabela Turma
CREATE TABLE Turma(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(20) NOT NULL,
	Ativo BIT
);

-- criação da tabela Aluno
CREATE TABLE Aluno(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
	DataNascimento DATE NOT NULL,
	Sexo CHAR(1) NOT NULL,
	TotalFaltas INT,
	TurmaID INT NOT NULL FOREIGN KEY REFERENCES Turma(ID)
);


-- testando dml com as tabelas
SELECT * FROM Turma;

SELECT * FROM Turma WHERE ID=1;

SELECT * FROM Aluno;

SELECT * FROM Aluno WHERE ID=1;

INSERT INTO Turma (Nome, Ativo) VALUES ('CSharp',1);

INSERT INTO Aluno (Nome, DataNascimento, Sexo, TotalFaltas, TurmaID) VALUES ('Carolina', 05-03-1995, 'F',0,1);

DROP Turma WHERE ID=1;

DROP Aluno WHERE ID=1;

UPDATE Turma SET Nome = 'RDI C#' WHERE ID=1;

UPDATE Alunno SET Nome = 'Carolina Bastos' WHERE ID=1;

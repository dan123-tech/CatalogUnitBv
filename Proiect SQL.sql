create database CatalogUnitbv;
use CatalogUnitbv;

CREATE TABLE Catalog (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Disciplina VARCHAR(100),
    ProfesorId INT,
    StudentId INT, 
    Nota INT,
    FOREIGN KEY (StudentId) REFERENCES Student(Id), 
    FOREIGN KEY (ProfesorId) REFERENCES Profesor(Id)
);
CREATE TABLE Student (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Ciclu_de_invatamant VARCHAR(100),
    Program_de_studiu VARCHAR(100),
    An_de_studiu INT,
    Grupa VARCHAR(50),
    Nume VARCHAR(100),
    email VARCHAR(100),
    parola VARCHAR(100)
);
CREATE TABLE Profesor(
	Id INT AUTO_INCREMENT PRIMARY KEY,
    Ciclu_de_invatamant VARCHAR(100),
    Program_de_studiu VARCHAR(100),
    An_de_studiu INT,
    Disciplina VARCHAR(100),
    Nume VARCHAR(100),
    Email VARCHAR(100),
    Parola VARCHAR(100)
);

INSERT INTO Student (Ciclu_de_invatamant, Program_de_studiu, An_de_studiu, Grupa, Nume, email, parola) VALUES
('Licenta', 'TI', 2, '4LF321', 'Daniel Cocu', 'daniel.cocu@student.unitbv.ro', 'danidani123');
SELECT * FROM Student;
CREATE DATABASE StudentUiDB

USE StudentUiDB

CREATE TABLE Students
(
ID int IDENTITY(1,1),
Name VARCHAR(300),
RollNo int,
Contact int,
Email VARCHAR(300)
)

INSERT INTO Students (Name, RollNo, Contact, Email) 
VALUES ('Fariha Reza', 234207, 01737082366, 'reza.fariha@gmail.com')

SELECT * FROM Students

DROP TABLE Students
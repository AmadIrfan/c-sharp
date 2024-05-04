CREATE TABLE Students(RegNo VARCHAR(50),
FirstName VARCHAR(50),
LastName VARCHAR(50),
GPA real,
Contact BIGINT,
);

SELECT * 
FROM Students 

SELECT RegNo,FirstName,LastName
FROM Students

SELECT * 
FROM Students 
WHERE GPA <= 3.5;

SELECT CONCAT(FirstName,LastName)
From Students;

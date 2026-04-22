CREATE DATABASE StudentDb;
use StudentDb;

CREATE TABLE Course (
	CourseId INT IDENTITY PRIMARY KEY,
	CourseName NVARCHAR(100)
);

CREATE TABLE Student (
    StudentId INT IDENTITY PRIMARY KEY,
    StudentName NVARCHAR(100),
    CourseId INT,
    FOREIGN KEY (CourseId) REFERENCES Course(CourseId)
);

INSERT INTO Course VALUES ('CSE'), ('ECE');
INSERT INTO Student VALUES ('Bharath',1), ('Bhuvan',1), ('Sush',2);

SELECT * FROM Course;
SELECT * FROM Student;
CREATE DATABASE studentManagement;
go
USE studentManagement;
go
CREATE TABLE Class (
    ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Name varchar(50) NOT NULL,
    Description varchar(100)
);

CREATE TABLE Student (
    ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Name varchar(50) NOT NULL,
    Email varchar(100),
    ClassID int NOT NULL,
    FOREIGN KEY (ClassID) REFERENCES Class(ID)
);

CREATE TABLE Subject (
    ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    Name varchar(50) NOT NULL,
    Description varchar(100)
);

CREATE TABLE Score (
    ID int NOT NULL PRIMARY KEY IDENTITY(1,1),
    StudentID int NOT NULL,
    SubjectID int NOT NULL,
    ScoreValue decimal NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Student(ID),
    FOREIGN KEY (SubjectID) REFERENCES Subject(ID)
);
go

-- Insert data into Class table
INSERT INTO Class ( Name, Description) VALUES ('Math', 'Class about mathematics'),
 ( 'English', 'Class about English literature'),
 ( 'History', 'Class about world history'),
 ( 'Science', 'Class about scientific principles'),
 ( 'Art', 'Class about different types of art'),
 ( 'Music', 'Class about different types of music'),
 ( 'Physical Education', 'Class about fitness and sports'),
 ( 'Computer Science', 'Class about computer programming'),
 ( 'Foreign Language', 'Class about learning a foreign language'),
 ( 'Social Studies', 'Class about social sciences');

go
-- Insert data into Student table
INSERT INTO Student ( Name, Email, ClassID) VALUES ( 'John Doe', 'johndoe@example.com', 1),
 ( 'Jane Smith', 'janesmith@example.com', 1),
 ( 'Bob Johnson', 'bobjohnson@example.com', 2),
 ( 'Sara Williams', 'sarawilliams@example.com', 2),
 ( 'Mike Davis', 'mikedavis@example.com', 3),
 ( 'Emily Lee', 'emilylee@example.com', 3),
 ( 'David Garcia', 'davidgarcia@example.com', 4),
 ( 'Jessica Kim', 'jessicakim@example.com', 4),
 ( 'Tom Brown', 'tombrown@example.com', 5),
 ( 'Lucy Chen', 'lucychen@example.com', 5);


-- Insert data into Subject table
INSERT INTO Subject (Name, Description) VALUES ('Algebra', 'Mathematical study of algebraic structures'),
 ( 'Shakespeare', 'Study of Shakespearean literature'),
 ( 'World War II', 'Study of events during World War II'),
 ( 'Chemistry', 'Study of chemical reactions and properties'),
 ( 'Painting', 'Study of different painting techniques'),
 ( 'Jazz', 'Study of different jazz musicians and techniques'),
 ( 'Soccer', 'Study of soccer rules and strategies'),
 ( 'Python', 'Study of Python programming language'),
 ( 'Spanish', 'Study of Spanish language and culture'),
 ('Economics', 'Study of economic systems and principles');


go
-- Insert data into Score table
INSERT INTO Score (StudentID, SubjectID, ScoreValue) VALUES ( 1, 1, 90),
 ( 1, 2, 85),
 ( 2, 1, 95),
 ( 2, 2, 92),
 ( 3, 3, 87),
 ( 3, 4, 91),
 ( 4, 3, 90),
 ( 4, 4, 88),
 ( 5, 5, 93),
 ( 5, 6, 89),
 ( 6, 5, 92),
 ( 6, 6, 90),
 ( 7, 7, 85),
 ( 7, 8, 93),
 ( 8, 7, 87),
 ( 8, 8, 90),
 ( 9, 9, 94),
 ( 9, 10, 88),
 ( 10, 9, 91),
 ( 10, 10, 85);
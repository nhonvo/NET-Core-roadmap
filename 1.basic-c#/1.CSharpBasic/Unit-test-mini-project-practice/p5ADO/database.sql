CREATE DATABASE p5ADONET;

USE p5ADONET;

CREATE TABLE Class (
    ID int IDENTITY(1,1) PRIMARY KEY,
    [Name] nvarchar(50),
    [Description] nvarchar(250)
);

CREATE TABLE Student (
    ID int IDENTITY(1,1) PRIMARY KEY,
    [Name] nvarchar(50),
    Email nvarchar(50),
    ClassID int,
    FOREIGN KEY (ClassID) REFERENCES Class(ID)
);

CREATE TABLE [Subject] (
    ID int IDENTITY(1,1) PRIMARY KEY,
    [Name] nvarchar(50),
    [Description] nvarchar(250)
);

CREATE TABLE Score (
    ID int IDENTITY(1,1) PRIMARY KEY,
    StudentID int,
    SubjectID int,
    ScoreValue int,
    FOREIGN KEY (StudentID) REFERENCES Student(ID),
    FOREIGN KEY (SubjectID) REFERENCES [Subject](ID)
);


CREATE DATABASE UserDB;
GO

USE UserDB;
GO

CREATE TABLE Users
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    Mobile NVARCHAR(15)
);

INSERT INTO Users(Name, Email, Mobile)
VALUES
('John', 'john@gmail.com', '9876543210'),
('Sarah', 'sarah@gmail.com', '9123456789');
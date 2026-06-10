--1. Create a new Database










--2. Create a new table
CREATE TABLE employee(
  id INT PRIMARY KEY AUTO_INCREMENT,
  department VARCHAR(50),
  name VARCHAR(100) NOT NULL,
  hire_date DATE
 );

--Show all tables
SHOW TABLES;

--Describe Table Structure
DESCRIBE employees;

--Delete Table
DELETE employee;

--Modify existing table(add column)
ALTER TABLE employees ADD email VARCHAR(100);

--Modify existing table(change column type)
ALTER TABLE employees MODIFY salary DECIMAL(12,2);

--Remove Column
ALTER TABLE employee ?????????????




--3. Insertion Commands

--Insert single row

INSERT INTO employees (name,department,salary,hire_date)
VALUES (''.'','','');

--Insert multiple rows

INSERT INTO employees (name,department,salary,hire_date)
VALUES (''.'','',''),
VALUES (''.'','',''),
VALUES (''.'','','');




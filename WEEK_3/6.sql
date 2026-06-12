--CREATE TABLE Departments DepartmentID ,  DepartmentName ,  City
 -- Employees table
--CREATE TABLE Employees  EmployeeID   EmployeeName,    Salary ,    DepartmentID ,   
--FOREIGN KEY (DepartmentID)        REFERENCES Departments(DepartmentID)
--);
--find employees whose salaries are above the company’s average salary. 
--list the names of employees who work in departments located in Pune.
--calculates the average salary of their department.
--Computes the average salary per department. Returns only departments with an average salary above 50,000.
--Returns the names of departments that have at least one employee. Departments with no employees will be excluded.
--list the names of employees who belong to the HR department.


-- Create Departments table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(50),
    City VARCHAR(50)
);

-- Create Employees table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    Salary DECIMAL(10,2),
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

-- 1. Find employees whose salaries are above the company's average salary
SELECT EmployeeName, Salary
FROM Employees
WHERE Salary > (
    SELECT AVG(Salary)
    FROM Employees
);

-- 2. List the names of employees who work in departments located in Pune
SELECT E.EmployeeName
FROM Employees E
JOIN Departments D
ON E.DepartmentID = D.DepartmentID
WHERE D.City = 'Pune';

-- 3. Calculate the average salary of each employee's department
SELECT E.EmployeeName,
       D.DepartmentName,
       (SELECT AVG(Salary)
        FROM Employees
        WHERE DepartmentID = E.DepartmentID) AS Avg_Department_Salary
FROM Employees E
JOIN Departments D
ON E.DepartmentID = D.DepartmentID;

-- 4. Compute the average salary per department.
-- Return only departments with average salary above 50000
SELECT D.DepartmentName,
       AVG(E.Salary) AS Avg_Salary
FROM Departments D
JOIN Employees E
ON D.DepartmentID = E.DepartmentID
GROUP BY D.DepartmentID, D.DepartmentName
HAVING AVG(E.Salary) > 50000;

-- 5. Return names of departments that have at least one employee
SELECT DISTINCT D.DepartmentName
FROM Departments D
JOIN Employees E
ON D.DepartmentID = E.DepartmentID;

-- 6. List the names of employees who belong to the HR department
SELECT E.EmployeeName
FROM Employees E
JOIN Departments D
ON E.DepartmentID = D.DepartmentID
WHERE D.DepartmentName = 'HR';

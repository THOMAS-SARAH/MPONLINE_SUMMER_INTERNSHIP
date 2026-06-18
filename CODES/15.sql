--QUESTION
--on the basis of aggregate and group by solve the following
--there are 3 tables
--(CustomerID, CustomerName)
--(ProductID, ProductName,Price)
--(OrderID, CustomerID, ProductID, Quantity)
--insert respective data into 3 tables
--total amount spent by each customer
--number of orders per customer
--AVG ORDER VALUE
--total quantity sold each product

-- CUSTOMER TABLE
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(50)
);

-- PRODUCT TABLE
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Price DECIMAL(10,2)
);

-- ORDERS TABLE
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- INSERT DATA INTO CUSTOMERS
INSERT INTO Customers VALUES
(1,'Alice'),
(2,'Bob'),
(3,'Charlie');

-- INSERT DATA INTO PRODUCTS
INSERT INTO Products VALUES
(101,'Laptop',50000),
(102,'Mouse',500),
(103,'Keyboard',1000);

-- INSERT DATA INTO ORDERS
INSERT INTO Orders VALUES
(1,1,101,1),
(2,1,102,2),
(3,2,103,3),
(4,2,102,4),
(5,3,101,1),
(6,3,103,2);

---------------------------------------------------
-- 1. TOTAL AMOUNT SPENT BY EACH CUSTOMER
---------------------------------------------------
SELECT
    c.CustomerID,
    c.CustomerName,
    SUM(p.Price * o.Quantity) AS TotalAmountSpent
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN Products p ON o.ProductID = p.ProductID
GROUP BY c.CustomerID, c.CustomerName;

---------------------------------------------------
-- 2. NUMBER OF ORDERS PER CUSTOMER
---------------------------------------------------
SELECT
    c.CustomerID,
    c.CustomerName,
    COUNT(o.OrderID) AS NumberOfOrders
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.CustomerID, c.CustomerName;

---------------------------------------------------
-- 3. AVERAGE ORDER VALUE
---------------------------------------------------
SELECT
    AVG(OrderValue) AS AvgOrderValue
FROM (
    SELECT
        o.OrderID,
        SUM(p.Price * o.Quantity) AS OrderValue
    FROM Orders o
    JOIN Products p ON o.ProductID = p.ProductID
    GROUP BY o.OrderID
) x;

---------------------------------------------------
-- 4. TOTAL QUANTITY SOLD OF EACH PRODUCT
---------------------------------------------------
SELECT
    p.ProductID,
    p.ProductName,
    SUM(o.Quantity) AS TotalQuantitySold
FROM Products p
JOIN Orders o ON p.ProductID = o.ProductID
GROUP BY p.ProductID, p.ProductName;

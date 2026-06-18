--QUESTION
--CALCULATE THE TOTAL STOCK VALUE FOR THE PRODUCT TABLE

-- Create Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Price DECIMAL(10,2),
    StockQuantity INT
);

-- Insert Sample Data
INSERT INTO Products VALUES
(101,'Laptop',50000,10),
(102,'Mouse',500,100),
(103,'Keyboard',1000,50);

-- Display All Products
SELECT * FROM Products;

-- Calculate Stock Value of Each Product
SELECT
    ProductID,
    ProductName,
    Price,
    StockQuantity,
    Price * StockQuantity AS StockValue
FROM Products;

-- Calculate Total Stock Value of Entire Inventory
SELECT
    SUM(Price * StockQuantity) AS TotalStockValue
FROM Products;

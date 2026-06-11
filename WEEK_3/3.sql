--QUESTION
--Create Table Products with ProductID, ProductName, ProductStockQuantity
--add three items to the new table
--read all columns and all rows of the table
--read specific columns for cheap items only
--the price of the product1 went up, and we sold 5 of them
--delete the product which we are no longer selling
--read and confirm the delete

-- Create Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50) NOT NULL,
    ProductPrice DECIMAL(10,2),
    ProductStockQuantity INT
);

-- Add Three Items
INSERT INTO Products VALUES
(1, 'Laptop', 50000, 20),
(2, 'Mouse', 500, 100),
(3, 'Keyboard', 1000, 50);

-- Read All Columns and All Rows
SELECT * FROM Products;

-- Read Specific Columns for Cheap Items Only
-- (Assume cheap items cost less than 2000)
SELECT ProductID, ProductName, ProductPrice
FROM Products
WHERE ProductPrice < 2000;

-- Product 1 Price Went Up and 5 Units Were Sold
UPDATE Products
SET ProductPrice = ProductPrice + 5000,
    ProductStockQuantity = ProductStockQuantity - 5
WHERE ProductID = 1;

-- Delete Product We Are No Longer Selling
DELETE FROM Products
WHERE ProductID = 2;

-- Read and Confirm the Delete
SELECT * FROM Products;

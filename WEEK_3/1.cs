-- ACCOUNT TABLE
-- Balance must be greater than 0

CREATE TABLE Account (
    account_no INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    balance DECIMAL(10,2) NOT NULL CHECK (balance > 0)
);

INSERT INTO Account VALUES
(101, 'Alice', 10000),
(102, 'Bob', 5000),
(103, 'Charlie', 8000);



-- CUSTOMER TABLE
-- Country defaults to India

CREATE TABLE Customer (
    customer_id INT PRIMARY KEY,
    customer_name VARCHAR(50) NOT NULL,
    country VARCHAR(30) DEFAULT 'India'
);

INSERT INTO Customer (customer_id, customer_name)
VALUES
(1, 'Rahul'),
(2, 'Priya');

INSERT INTO Customer (customer_id, customer_name, country)
VALUES
(3, 'John', 'USA');



-- TICKET BOOKING TABLE
-- Source and Destination city cannot be NULL

CREATE TABLE TicketBooking (
    ticket_id INT PRIMARY KEY,
    passenger_name VARCHAR(50) NOT NULL,
    source_city VARCHAR(50) NOT NULL,
    destination_city VARCHAR(50) NOT NULL,
    journey_date DATE
);

INSERT INTO TicketBooking VALUES
(1001, 'Rahul', 'Delhi', 'Mumbai', '2026-06-15'),
(1002, 'Priya', 'Chennai', 'Bangalore', '2026-06-20'),
(1003, 'John', 'Kolkata', 'Hyderabad', '2026-06-25');



-- DISPLAY DATA

SELECT * FROM Account;
SELECT * FROM Customer;
SELECT * FROM TicketBooking;

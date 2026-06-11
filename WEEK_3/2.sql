-- Create Account Table
CREATE TABLE Account (
    account_no INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    balance DECIMAL(10,2) NOT NULL CHECK (balance >= 0)
);

-- Insert Dummy Data
INSERT INTO Account VALUES
(101, 'Alice', 10000),
(102, 'Bob', 5000),
(103, 'Charlie', 8000);

-- Stored Procedure
DELIMITER $$

CREATE PROCEDURE TransferMoney(
    IN p_sender INT,
    IN p_receiver INT,
    OUT p_status VARCHAR(50)
)
BEGIN
    DECLARE sender_balance DECIMAL(10,2);

    START TRANSACTION;

    SELECT balance
    INTO sender_balance
    FROM Account
    WHERE account_no = p_sender;

    IF sender_balance >= 1000 THEN

        UPDATE Account
        SET balance = balance - 1000
        WHERE account_no = p_sender;

        UPDATE Account
        SET balance = balance + 1000
        WHERE account_no = p_receiver;

        COMMIT;
        SET p_status = 'Transaction Successful';

    ELSE

        ROLLBACK;
        SET p_status = 'Insufficient Balance';

    END IF;
END$$

DELIMITER ;

-- Execute Procedure
CALL TransferMoney(101, 102, @result);

-- Display Transaction Status
SELECT @result AS Status;

-- Display Updated Account Details
SELECT * FROM Account;

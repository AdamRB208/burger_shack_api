-- Active: 1747676458886@@mysql.codeworksacademy.com@3306@curious_lion_0df1_db
CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL PRIMARY KEY COMMENT 'primary key',
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
    updated_at DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
    name VARCHAR(255) COMMENT 'User Name',
    email VARCHAR(255) UNIQUE COMMENT 'User Email',
    picture VARCHAR(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE burgers (
    id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    name TINYTEXT NOT NULL,
    price DECIMAL(19, 2) NOT NULL
) DEFAULT CHARSET utf8mb4;

DROP TABLE burgers;

INSERT INTO
    burgers (name, price)
VALUES ('Cheese Burger', 5.00),
    ('Bacon Cheese Burger', 7.00),
    ('Hamburger', 4.50),
    ('Double Cheese Burger', 7.50);

DELETE FROM burgers WHERE id = 1;

SELECT * FROM burgers;
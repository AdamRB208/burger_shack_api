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
    price TINYINT UNSIGNED NOT NULL
) DEFAULT CHARSET utf8mb4;

DROP TABLE burgers;

INSERT INTO
    burgers (name, price)
VALUES ('Cheese Burger', 5),
    ('Bacon Cheese Burger', 7),
    ('Hamburger', 4),
    ('Double Cheese Burger', 8);

DELETE FROM burgers WHERE id = 1;

SELECT name FROM burgers;
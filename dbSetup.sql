CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS houses(
        id INT AUTO_INCREMENT PRIMARY KEY,
        year INT NOT NULL DEFAULT 0,
        size INT NOT NULL DEFAULT 0,
        bedrooms INT NOT NULL,
        bathrooms INT NOT NULL,
        price DOUBLE NOT NULL,
        description TEXT,
        address VARCHAR(25) NOT NULL
    ) default charset utf8 COMMENT '';

INSERT INTO
    houses (
        year,
        size,
        bedrooms,
        bathrooms,
        price,
        description,
        address
    )
VALUES (
        2008,
        4200,
        6,
        6,
        7000,
        'BIGGER and BETTER',
        '24  N Autumn'
    );
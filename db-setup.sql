-- USE bugtracker010;

-- CREATE TABLE bugs (
--     id int NOT NULL AUTO_INCREMENT,
--     userId VARCHAR(255),
--     title VARCHAR(255) NOT NULL,
--      subject VARCHAR(255) NOT NULL,
--     description VARCHAR(255) NOT NULL,
--     reportedBy VARCHAR(255) NOT NULL,
--     isClosed TINYINT,
--     daysOpen INT,
--     lastModified DATETIME,
--     bugCreated DATETIME,
--     bugClosed DATETIME,
--     INDEX userId (userId),
--     PRIMARY KEY (id)
-- );

-- CREATE TABLE notes (
--   id int NOT NULL AUTO_INCREMENT,
--   userId VARCHAR(255),
--   title VARCHAR(255) NOT NULL,
--   description VARCHAR(255) NOT NULL,
--   noteCreatedBy VARCHAR(255) NOT NULL,
--   INDEX userId(userId),
--    PRIMARY KEY (id)
-- )

-- -- USE THIS TO SELECT ALL THE DATA IN THE TABLE
-- SELECT * FROM bugs;
-- SELECT * FROM notes;

-- -- USE THIS TO WIPE DATA INSIDE OF TABLE
-- TRUNCATE TABLE bugs;
-- TRUNCATE TABLE notes;

-- -- USE THIS TO CLEAN OUT YOUR DATABASE
-- DROP TABLE IF EXISTS bugs;
-- DROP TABLE IF EXISTS notes;

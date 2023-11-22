# Clean_Architecture_Practice1_MySQL

CREATE TABLE Books
(
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Author VARCHAR(255) NOT NULL,
    Year INT NOT NULL,
);



GET Method: https://localhost:5001/api/v1.0/people

Post Method: https://localhost:5001/api/v1.0/people

{
    "title":"X",
    "author":"Y",
    "year":0
}


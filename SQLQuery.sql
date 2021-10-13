CREATE TABLE Customers
(
    Id INT IDENTITY PRIMARY KEY,
    CustomerName NVARCHAR(30) NOT NULL,
);
CREATE TABLE Orders
(
    Id INT IDENTITY PRIMARY KEY,
    CustomerId INT NOT NULL REFERENCES Customers(Id) ON DELETE CASCADE,
);
INSERT INTO Customers VALUES
('Max'),
('Pavel'),
('Ivan'),
('Leonid')

INSERT INTO Orders VALUES
(2),
(4)

SELECT Customers.CustomerName
FROM Customers
EXCEPT SELECT Customers.CustomerName
FROM Customers
JOIN Orders ON Orders.CustomerId = Customers.Id
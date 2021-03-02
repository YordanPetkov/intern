USE Bank
GO

CREATE PROCEDURE SelectFullnames
AS
SELECT Persons.FirstName + space(1) + Persons.LastName as Name
FROM Persons
GO


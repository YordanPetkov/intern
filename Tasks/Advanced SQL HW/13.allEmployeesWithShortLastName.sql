USE TelerikAcademy
GO

SELECT CONCAT(Employees.FirstName,' ',Employees.MiddleName,' ',Employees.LastName) as Name
FROM Employees
WHERE LEN(Employees.LastName) = 5
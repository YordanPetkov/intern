USE TelerikAcademy
GO

SELECT Count(Employees.DepartmentID) as countEmployees
FROM Employees
WHERE Employees.ManagerID IS NOT NULL
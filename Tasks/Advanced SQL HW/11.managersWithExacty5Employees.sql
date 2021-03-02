USE TelerikAcademy
GO

SELECT Employees.FirstName,Employees.LastName
FROM Employees
INNER JOIN (
	SELECT e.ManagerID, COUNT(e.EmployeeID) as numberOfEmployees
	FROM Employees as e
	INNER JOIN Employees as m
	ON e.ManagerID = m.EmployeeID
	GROUP BY e.ManagerID
) as Managers
ON Employees.EmployeeID = Managers.ManagerID
WHERE Managers.numberOfEmployees = 5

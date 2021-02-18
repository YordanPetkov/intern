SELECT e.*, CONCAT(m.FirstName, ' ', m.MiddleName, ' ', m.LastName) as ManagerName
FROM Employees as e
INNER JOIN Employees as m
ON e.ManagerID = m.EmployeeID
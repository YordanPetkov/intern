SELECT e.*,CONCAT(m.FirstName, ' ', m.MiddleName, ' ', m.LastName) as managerName
FROM Employees as m
RIGHT OUTER JOIN Employees as e
ON e.ManagerID = m.EmployeeID
ORDER BY e.EmployeeID
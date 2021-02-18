SELECT e.*,CONCAT(m.FirstName, ' ', m.MiddleName, ' ', m.LastName) as ManagerName
FROM Employees as e
LEFT OUTER JOIN Employees as m
ON e.ManagerID = m.EmployeeID
ORDER BY e.EmployeeID
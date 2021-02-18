SELECT e.*, 
	CONCAT(m.FirstName, ' ', m.MiddleName, ' ', m.LastName) as ManagerName,
	a.AddressText,a.TownID
FROM Employees as e
INNER JOIN Employees as m
ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses as a
ON e.AddressID = a.AddressID
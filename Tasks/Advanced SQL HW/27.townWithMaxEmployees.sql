
SELECT EmployeesByTown.Name
	FROM
	(
		SELECT TOP 1 Towns.Name,COUNT(Employees.EmployeeID) as numberOfEmployees
		FROM Towns
		INNER JOIN Addresses
		ON Towns.TownID = Addresses.TownID
		INNER JOIN Employees
		ON Addresses.AddressID = Employees.AddressID
		GROUP BY Towns.Name
		ORDER BY numberOfEmployees DESC
	) as EmployeesByTown
	
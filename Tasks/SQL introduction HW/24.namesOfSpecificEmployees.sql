SELECT CONCAT(e.FirstName, ' ', e.MiddleName, ' ', e.LastName) as Name
FROM Employees as e
INNER JOIN Departments
ON e.DepartmentID = Departments.DepartmentID
WHERE (Departments.Name = 'Sales' OR Departments.Name = 'Finance')
	AND (YEAR(e.HireDate) >= 1995 AND YEAR(e.HireDate) <= 2005)
SELECT Count(Employees.DepartmentID) as countEmployees
FROM Employees
INNER JOIN Departments
ON Employees.DepartmentID = Departments.DepartmentID
WHERE Departments.Name = 'Sales'
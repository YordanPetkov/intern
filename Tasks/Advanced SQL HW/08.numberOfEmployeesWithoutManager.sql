SELECT Count(Employees.DepartmentID) as countEmployees
FROM Employees
WHERE Employees.ManagerID IS NULL
SELECT Departments.Name, COUNT(Employees.EmployeeID) as numberOfEmployees
FROM Departments
INNER JOIN Employees
ON Departments.DepartmentID = Employees.DepartmentID
GROUP BY Departments.Name

UNION

SELECT Towns.Name, COUNT(Employees.EmployeeID) as numberOfEmployees
FROM Employees
INNER JOIN Addresses
ON Employees.AddressID = Addresses.AddressID
INNER JOIN Towns
ON Addresses.TownID = Towns.TownID
GROUP BY Towns.Name

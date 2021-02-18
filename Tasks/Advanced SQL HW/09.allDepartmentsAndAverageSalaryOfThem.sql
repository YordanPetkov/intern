SELECT Departments.Name, AVG(Employees.Salary) as avgSalary
FROM Employees INNER JOIN Departments
ON Departments.DepartmentID = Employees.DepartmentID
GROUP BY Departments.Name

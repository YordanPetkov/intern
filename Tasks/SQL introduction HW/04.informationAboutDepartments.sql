SELECT Departments.*,Employees.FirstName,Employees.LastName 
FROM Departments
LEFT JOIN Employees
ON Departments.ManagerID = Employees.EmployeeID
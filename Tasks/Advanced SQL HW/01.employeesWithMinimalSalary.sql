SELECT * FROM Employees
WHERE Employees.Salary = (
	SELECT MIN(Employees.Salary) 
	FROM Employees);
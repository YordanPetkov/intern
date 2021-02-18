SELECT *
FROM Employees as em
WHERE 
(
	em.Salary = 25000 
	OR em.Salary = 14000 
	OR em.Salary = 12500 
	OR em.Salary = 26000
);
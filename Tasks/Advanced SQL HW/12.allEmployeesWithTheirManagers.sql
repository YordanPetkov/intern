SELECT em.EmployeeID,em.FirstName,em.LastName,em.JobTitle,em.ManagerID,
CASE WHEN em.ManagerID IS NULL THEN 'no manager'
ELSE em.ManagerName
END AS Manager
FROM
(
	SELECT  e.*,CONCAT(m.FirstName,' ',m.LastName) as ManagerName
	FROM Employees as e
	LEFT JOIN Employees as m
	ON e.ManagerID = m.EmployeeID
) as em
ORDER BY em.EmployeeID
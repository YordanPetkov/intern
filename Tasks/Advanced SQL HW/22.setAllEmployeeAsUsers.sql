INSERT INTO Users (UserName,Password,FullName,LastLogin)
SELECT DISTINCT
	LOWER
	(
		CONCAT(substring(e.FirstName, 1, 1), e.LastName)
	),
	LOWER
	(
		CONCAT(substring(e.FirstName, 1, 1), e.LastName)
	),
	CONCAT(e.FirstName,' ',e.LastName),
	NULL
FROM Employees as e
WHERE LEN(CONCAT(substring(e.FirstName, 1, 1), e.LastName)) >= 5
GROUP BY LOWER
	(
		CONCAT(substring(e.FirstName, 1, 1), e.LastName)
	)



SELECT LOWER(CONCAT(substring(e.FirstName, 1, 1), e.LastName))
FROM Employees as e

SELECT * FROM Employees as e
WHERE e.LastName = 'Hill'
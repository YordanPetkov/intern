USE TelerikAcademy
GO

INSERT INTO Users (UserName,Password,FullName,LastLogin)
SELECT DISTINCT
	LOWER
	(
		CONCAT(substring(e.FirstName, 1, 1), e.LastName)
	) as username,
	LOWER
	(
		CONCAT(substring(e.FirstName, 1, 1), e.LastName)
	) as pass,
	CONCAT(e.FirstName,' ',e.LastName) as Name,
	NULL as lastLogin
FROM Employees as e
WHERE LEN(CONCAT(substring(e.FirstName, 1, 1), e.LastName)) >= 5
ORDER BY username

SELECT * FROM Users

INSERT INTO Users (UserName,Password,FullName,LastLogin)





SELECT DISTINCT UNM.* FROM
(
	SELECT DISTINCT
		LOWER
		(
			CONCAT(substring(e.FirstName, 1, 1), e.LastName)
		) as username
	FROM Employees as e
	WHERE LEN(CONCAT(substring(e.FirstName, 1, 1), e.LastName)) >= 5
) UN
INNER JOIN
(
	SELECT DISTINCT
	LOWER
	(
		CONCAT(substring(e.FirstName, 1, 1), e.LastName)
	) as username,
	LOWER
	(
		CONCAT(substring(e.FirstName, 1, 1), e.LastName)
	) as pass,
	CONCAT(e.FirstName,' ',e.LastName) as Name,
	NULL as lastLogin
	FROM Employees as e
	GROUP BY CONCAT(substring(e.FirstName, 1, 1), e.LastName)
	HAVING LEN(CONCAT(substring(e.FirstName, 1, 1), e.LastName)) >= 5
	
) UNM
ON UNM.username = UN.username
GROUP BY UNM.username
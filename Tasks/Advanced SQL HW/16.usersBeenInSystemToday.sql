CREATE or ALTER VIEW TodaysUsers AS
	SELECT Users.UserName,Users.FullName
	FROM Users
	WHERE DAY(Users.LastLogin) = DAY(GETDATE())
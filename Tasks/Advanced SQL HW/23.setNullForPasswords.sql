UPDATE Users
SET Password = NULL
WHERE convert(varchar,Users.LastLogin,104) <= '10.03.2010'
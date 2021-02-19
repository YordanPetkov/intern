UPDATE Users
SET UserName = 'Bliokl22'
WHERE UserName = 'B_iokl22'

UPDATE Users
SET Password = '0943232811'
WHERE UserName = 'Bliokl22'

UPDATE Users
SET FullName = 'Kaloqn Botev Manchev'
WHERE UserName = 'Bliokl22'

UPDATE Users
SET LastLogin = GETDATE()
WHERE UserName = 'Bliokl22'

UPDATE Groups
SET Name = 'Owner'
WHERE GroupID = 4
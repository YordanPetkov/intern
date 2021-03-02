USE TelerikAcademy
GO

ALTER TABLE Users
ADD GroupID int FOREIGN KEY REFERENCES Groups(GroupID)

INSERT INTO Groups VALUES ('Admins')
INSERT INTO Groups VALUES ('Moderators')
INSERT INTO Groups VALUES ('Vip')
INSERT INTO Groups VALUES ('Owners')
INSERT INTO Groups VALUES ('Members')
INSERT INTO Groups VALUES ('Guests')

UPDATE Users
SET Users.GroupID = 4
WHERE Users.UserName = 'Ivan'

UPDATE Users
SET Users.GroupID = 1
WHERE Users.UserName = 'Petar'

UPDATE Users
SET Users.GroupID = 2
WHERE Users.UserName = 'joris'

UPDATE Users
SET Users.GroupID = 3
WHERE Users.UserName = 'fippol'

UPDATE Users
SET Users.GroupID = 6
WHERE Users.UserName = 'niko55'
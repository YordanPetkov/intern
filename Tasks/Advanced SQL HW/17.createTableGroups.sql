USE TelerikAcademy
GO

CREATE TABLE Groups
(
	GroupID int IDENTITY PRIMARY KEY NOT NULL,
	Name varchar(255) UNIQUE
)
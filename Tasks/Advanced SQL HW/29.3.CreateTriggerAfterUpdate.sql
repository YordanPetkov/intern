USE TelerikAcademy
GO

CREATE TRIGGER tr_up_wh ON WorkHours
AFTER UPDATE
AS

BEGIN
	DECLARE @OldRecordData varchar(1023)
	DECLARE @NewRecordData varchar(1023)
	SELECT @OldRecordData =
		CONCAT(deleted.WorkHoursID, ' ', deleted.EmployeeID, ' ', deleted.Date, ' ',
		deleted.Task, ' ', deleted.Hours, deleted.Comments),
		@NewRecordData = 
		CONCAT(INSERTED.WorkHoursID, ' ', inserted.EmployeeID, ' ', inserted.Date, ' ',
		inserted.Task, ' ', inserted.Hours, inserted.Comments)
	FROM inserted,deleted

	INSERT INTO WorkHoursLogs
	inserted.Task
	VALUES(@OldRecordData, @NewRecordData, 'Update')
END

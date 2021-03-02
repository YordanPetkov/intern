USE TelerikAcademy
GO

CREATE TRIGGER tr_del_wh ON WorkHours
AFTER DELETE
AS

BEGIN
	DECLARE @OldRecordData varchar(1023)
	DECLARE @NewRecordData varchar(1023)
	SELECT @OldRecordData =
		CONCAT(deleted.WorkHoursID, ' ', deleted.EmployeeID, ' ', deleted.Date, ' ',
		deleted.Task, ' ', deleted.Hours, deleted.Comments),
		@NewRecordData = ' '
	FROM deleted

	INSERT INTO WorkHoursLogs
	VALUES(@OldRecordData, @NewRecordData, 'Delete')
END
USE TelerikAcademy
GO

CREATE TRIGGER tr_ins_wh ON WorkHours
AFTER INSERT
AS

BEGIN
	DECLARE @OldRecordData varchar(1023)
	DECLARE @NewRecordData varchar(1023)
	SELECT @OldRecordData = 
		'',
		@NewRecordData = CONCAT(INSERTED.WorkHoursID, ' ', inserted.EmployeeID, ' ', inserted.Date, ' ',
		inserted.Task, ' ', inserted.Hours, inserted.Comments)
	FROM inserted

	INSERT INTO WorkHoursLogs
	VALUES(@OldRecordData,@NewRecordData,'Insert')
END
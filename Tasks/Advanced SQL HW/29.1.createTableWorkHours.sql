USE TelerikAcademy
GO

CREATE TABLE WorkHours
(
	WorkHoursID int Identity Primary KEY,
	EmployeeID int FOREIGN KEY REFERENCES Employees(EmployeeID),
	Date date,
	Task varchar(255),
	Hours float,
	Comments varchar(255)
)

CREATE TABLE WorkHoursLogs
(
	OldRecordData varchar(1023),
	NewRecordData varchar(1023),
	Command varchar(50)
)


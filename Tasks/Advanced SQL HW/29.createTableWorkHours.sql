CREATE TABLE WorkHours
(
	WorkHoursID int Identity,
	EmployeeID int FOREIGN KEY REFERENCES Employees(EmployeeID),
	Date date,
	Task varchar(255),
	Hours float,
	Comments varchar(255)
)
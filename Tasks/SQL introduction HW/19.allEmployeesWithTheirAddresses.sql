SELECT Employees.*,Addresses.AddressText,Addresses.TownID
FROM Employees,Addresses
WHERE Employees.AddressID = Addresses.AddressID
ORDER BY Employees.EmployeeID
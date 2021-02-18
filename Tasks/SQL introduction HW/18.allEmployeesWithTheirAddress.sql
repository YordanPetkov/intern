SELECT Employees.*,Addresses.AddressText,Addresses.TownID
FROM Employees
INNER JOIN Addresses
ON Employees.AddressID = Addresses.AddressID
ORDER BY Employees.EmployeeID
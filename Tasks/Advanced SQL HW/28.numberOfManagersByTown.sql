SELECT Towns.Name,COUNT(Employees.ManagerID) as Managers
FROM Employees
INNER JOIN Addresses
ON Employees.AddressID = Addresses.AddressID
INNER JOIN Towns
ON Addresses.TownID = Towns.TownID
WHERE Employees.ManagerID IS NOT NULL
GROUP BY Towns.Name
ORDER BY Managers DESC
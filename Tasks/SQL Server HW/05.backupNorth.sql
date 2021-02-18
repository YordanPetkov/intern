BACKUP DATABASE Northwind
TO DISK = 'D:\Yordan\intern yordan\intern\Tasks\SQL Server HW\northwind-backup.bak';

RESTORE DATABASE North 
FROM DISK = 'D:\Yordan\intern yordan\intern\Tasks\SQL Server HW\northwind-backup.bak';
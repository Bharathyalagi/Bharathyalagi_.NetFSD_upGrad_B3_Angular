-- Find total number of employees in the Employees table.
SELECT Count(*) AS TotalEmployees
FROM Employees;

-- Find the average salary of employees in the Employees table.
SELECT AVG(Salary) AS AverageSalary	
	FROM Employees;

-- Find the maximum salary in the Employees table.	
SELECT MAX(Salary) AS MaxSalary
FROM Employees;

-- Find the minimum salary in the Employees table.
SELECT MIN(Salary) AS MinSalary
FROM Employees;

-- Find total salary paid to all employees in the Employees table.
SELECT SUM(Salary) AS TotalSalary
FROM Employees;
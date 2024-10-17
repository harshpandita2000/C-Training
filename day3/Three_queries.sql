-- Query to retrieve all employees who work in a specific department,along with their job titles and email addresses.
SELECT FirstName, LastName, JobTitle, Email
FROM Employees
WHERE Department = 'IT'; 

-- Query to update the salary of an employee based on their EmployeeID.

UPDATE Employees
SET Salary = 75000.00 
WHERE EmployeeID = 1; 

-- Query to deactivate an employee by setting the IsActive flag to false.

UPDATE Employees
SET IsActive = 0 -- 0- false 1- true
WHERE EmployeeID = 2;

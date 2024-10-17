
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Phone VARCHAR(15),
    HireDate DATE NOT NULL,
    JobTitle VARCHAR(50),
    Department VARCHAR(50),
    Salary DECIMAL(10, 2),
    IsActive BIT DEFAULT 1
);



INSERT INTO Employees (FirstName, LastName, DateOfBirth, Email, Phone, HireDate, JobTitle, Department, Salary, IsActive)
VALUES
('Arjun', 'Sharma', '1985-06-15', 'arjun.sharma@example.com', '9876543210', '2015-01-10', 'Software Engineer', 'IT', 70000.00, 1),
('Priya', 'Gupta', '1990-03-20', 'priya.gupta@example.com', '9871234567', '2018-05-15', 'Project Manager', 'IT', 85000.00, 1),
('Sneha', 'Reddy', '1988-09-10', 'sneha.reddy@example.com', '9879876543', '2020-07-25', 'HR Specialist', 'HR', 60000.00, 1),
('Rahul', 'Patel', '1975-12-01', 'rahul.patel@example.com', '9873210987', '2012-03-20', 'Marketing Manager', 'Marketing', 75000.00, 1),
('Kavya', 'Iyer', '1995-04-30', 'kavya.iyer@example.com', '9875555555', '2021-09-01', 'Sales Associate', 'Sales', 50000.00, 1);


-- STEP 1: Create Departments Table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
GO

-- STEP 2: Create Employees Table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1), -- Auto-increment ID
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);
GO

-- STEP 3: Insert Departments Data
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');
GO

-- STEP 4: Insert Employees Data
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 5000.00, '2020-01-15'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22'),
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
('Emily', 'Davis', 4, 5500.00, '2021-11-05');
GO

-- STEP 5: Create Procedure to Get Employees by Department
CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DeptID INT
AS
BEGIN
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DeptID;
END;
GO

-- STEP 6: Create Procedure to Insert New Employee
CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO

-- STEP 7: Execute the Get Procedure (Example)
EXEC sp_GetEmployeesByDepartment @DeptID = 2;
GO

-- STEP 8: Execute the Insert Procedure (Example)
EXEC sp_InsertEmployee 
    @FirstName = 'Arjun',
    @LastName = 'Patel',
    @DepartmentID = 2,
    @Salary = 6200.00,
    @JoinDate = '2023-04-01';
GO

-- STEP 9: Verify Inserted Record
SELECT * FROM Employees WHERE DepartmentID = 2;
GO


-- Drop the procedure if it already exists
IF OBJECT_ID('sp_GetEmployeeCountByDepartment', 'P') IS NOT NULL
    DROP PROCEDURE sp_GetEmployeeCountByDepartment;
GO

-- Create the procedure
CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DeptID INT
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM Employees
    WHERE DepartmentID = @DeptID;
END;
GO

EXEC sp_GetEmployeeCountByDepartment @DeptID = 2;


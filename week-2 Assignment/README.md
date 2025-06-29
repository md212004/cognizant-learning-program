#  Assignment: Advanced SQL & NUnit + Moq Testing

This project demonstrates core concepts of backend development and testing using:

- **Microsoft SQL Server** for database design and stored procedures
- **NUnit** for unit testing .NET classes
- **Moq** for mocking dependencies like mail senders or databases

---

##  Project Overview

This assignment contains two major modules:

1. **Advanced SQL Scripts**
2. **.NET Unit Testing with NUnit + Moq**

Each part is structured to show clean, modular, and testable code that follows best practices for modern software development.

---

##  Part 1: Advanced SQL (Microsoft SQL Server)

### 🛠 Technologies Used

- SQL Server 2019 or above
- SQL Server Management Studio (SSMS)

###  Features Covered

- `CREATE TABLE` statements with `PRIMARY KEY`, `FOREIGN KEY` constraints
- `INSERT`, `SELECT`, `JOIN` queries
- Window functions: `ROW_NUMBER()`, `RANK()`, `DENSE_RANK()`
- Stored procedures with parameters

###  Sample Execution

To retrieve employees by department:
```sql
EXEC sp_GetEmployeesByDepartment @DeptID = 2;

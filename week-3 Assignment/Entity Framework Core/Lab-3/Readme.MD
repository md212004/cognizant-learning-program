# Lab 3: Using EF Core CLI to Create and Apply Migrations

## Scenario
The retail store's database needs to be created based on the models you've defined.  
In this lab, we use the EF Core CLI to generate and apply migrations to create the required schema in SQL Server.

---

## Objective
Learn how to use EF Core CLI to:  
- Generate migration files for the database schema.  
- Apply migrations to create the database.  
- Verify the changes in SQL Server.  

---

## Steps

### 1. Install EF Core CLI
Install the EF Core CLI globally if not already installed:  
```bash
dotnet tool install --global dotnet-ef

### 2. Create Initial Migration
After configuring your models and DbContext, create the initial migration:

```bash
dotnet ef migrations add InitialCreate

### 3.Apply Migration to Create Database
Run the following command to apply the migration and create the database:

```bash
dotnet ef database update

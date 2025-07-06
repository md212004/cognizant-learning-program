
#  Entity Framework Core (EF Core)

This repository provides an overview of **Entity Framework Core (EF Core)** and its usage in .NET applications.

---

##  What is Entity Framework Core?

Entity Framework Core (**EF Core**) is a modern, lightweight, open-source, and cross-platform Object-Relational Mapper (**ORM**) for .NET. It enables developers to interact with a database using C# objects rather than writing SQL queries directly.

###  ORM Mapping

EF Core maps your **C# classes** (entities) to database tables and allows you to perform CRUD operations seamlessly.

- **Classes → Tables**
- **Properties → Columns**
- **Relationships → Foreign Keys**

---

##  Benefits of Using EF Core

- **Productivity**: Rapid development without manual SQL queries.
- **Maintainability**: Clean and consistent data access code.
- **Cross-platform**: Works on Windows, Linux, and macOS.
- **Modern Features**: Supports LINQ, async operations, migrations, and more.

---

##  EF Core vs Entity Framework (EF6)

| Feature                | EF Core                        | EF Framework (EF6)         |
|------------------------|----------------------------------|-----------------------------|
| Platform Support       | Cross-platform (Windows/Linux/Mac) | Windows-only                |
| Performance            | Lightweight & faster            | Mature but heavier          |
| Modern Features        | LINQ, async queries, compiled queries | Limited support             |
| Release Year           | 2016                             | 2008                        |

---

## EF Core 8.0 Features

- **JSON Column Mapping**: Store and query JSON data directly.
- **Compiled Models**: Improves startup performance.
- **Interceptors**: Intercept EF Core operations for custom logic.
- **Improved Bulk Operations**: Efficient updates and deletes.

---

##  Basic Workflow

1. **Define Models**
2. **Create a DbContext**
3. **Run Migrations**
4. **Query and Update Data**

```csharp
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Your_Connection_String_Here");
    }
}
```

---

##  Useful Commands

- **Install EF Core CLI Tools**
  ```bash
  dotnet tool install --global dotnet-ef
  ```
- **Create a Migration**
  ```bash
  dotnet ef migrations add InitialCreate
  ```
- **Apply Migration**
  ```bash
  dotnet ef database update
  ```


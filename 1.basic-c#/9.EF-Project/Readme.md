# EF Project learn about entity framework

- [EF Project learn about entity framework](#ef-project-learn-about-entity-framework)
  - [Command](#command)
  - [Conventions in Entity Framework Core](#conventions-in-entity-framework-core)
  - [Migrations](#migrations)
  - [Lazy loading, eager loading, Explicit loading??](#lazy-loading-eager-loading-explicit-loading)
  - [Caching](#caching)
  - [cascade delete](#cascade-delete)
  - [change tracker](#change-tracker)
  - [shadow property](#shadow-property)
  - [logging](#logging)
  - [raw sql queries](#raw-sql-queries)
  - [Repository Pattern](#repository-pattern)
  - [An in-memory database](#an-in-memory-database)
  - [Database providers: An overview of different database providers that can be used with EF Core, such as SQL Server, SQLite, PostgreSQL, etc](#database-providers-an-overview-of-different-database-providers-that-can-be-used-with-ef-core-such-as-sql-server-sqlite-postgresql-etc)
  - [Transactions](#transactions)
  - [Handling Concurrency and Conflicts](#handling-concurrency-and-conflicts)
  - [Stored Procedures and Functions](#stored-procedures-and-functions)
  - [Using LINQ to Query Advance](#using-linq-to-query-advance)
  - [Asynchronous Queries](#asynchronous-queries)
  - [Cascading Updates and Deletes](#cascading-updates-and-deletes)
  - [Global Query Filters](#global-query-filters)
  - [Split Queries](#split-queries)
  - [Performance Considerations](#performance-considerations)
  - [Testing and Debugging](#testing-and-debugging)

## Command

- Install

```console
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

```console
dotnet add package AutoMapper
dotnet add package Microsoft.AspNetCore.Mvc.Versioning.ApiExplorer
dotnet add package Microsoft.AspNetCore.OpenApi
```

```console
dotnet add package Microsoft.AspNetCore.JsonPatch
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add package Microsoft.AspNetCore.Mvc.Versioning
```

```console
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection

```

- Remove

```console
dotnet remove package <package-name>
```

- Create new model from existing database

```console
dotnet ef dbcontext scaffold "Data Source=CVPNHONVTT; Initial Catalog=studentManagement; TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -o Models
```

- create project

```console
dotnet new console -n <project-name>
dotnet sln add <project-path>
```

- migrations  database

```console
dotnet ef migrations add <Command-Name>
dotnet ef database update
dotnet ef remove migrations
```

- run project

```console
dotnet run
dotnet watch run
dotnet build 
dotnet restore
```

- publish project

```console
dotnet publish -c Release -o <output-path>
```

## Conventions in Entity Framework Core

- Schema: create dbo in default schema(contain login, relationship in database, each database can has multiped schema).
- Table
- Column
- Column data type

| C# Data Type | Mapping to SQL Server Data Type |
| ------------ | ------------------------------- |
| int          | int                             |
| string       | nvarchar(Max)                   |
| decimal      | decimal(18,2)                   |
| float        | real                            |
| byte         | []varbinary(Max)                |
| datetime     | datetime                        |
| bool         | bit                             |
| byte         | tinyint                         |
| short        | smallint                        |
| long         | bigint                          |
| double       | float                           |
| char         | No mapping                      |
| sbyte        | No mapping (throws exception)   |
| object       | No mapping                      |

- Nullable Column
- NotNull Column
- Primary key
- Foreign key
- Index

## Migrations

Database migrations are a technique used to manage changes to a database schema over time. They provide a way to evolve the database schema and keep it in sync with the application code as the requirements of the application change.

Migrations in EF Core allow you to:
    - Create or modify database tables, columns, indexes, and constraints.
    - Seed initial data into the database.
    - Update the database schema to reflect changes in your entity classes, such as adding or removing properties, changing data types, or creating new relationships.

rollback migration
    - `Update-Database <LastMigrationName>`
    - `Update-Database <SecondToLastMigrationName> -Migration <MigrationIndex>`

## Lazy loading, eager loading, Explicit loading??

- **lazy loading:** only load the necessary data not to load again so can increase performance.
  - normal loading:

```c#
using (var context = new MyDbContext())
{
    var authors = context.Authors.Include(a => a.Books).ToList();
}
```

    - lazy loading:

```c#
using (var context = new MyDbContext())
{
    var authors = context.Authors.ToList();

    foreach (var author in authors)
    {
        var books = author.Books.ToList(); // Lazy loading here
    }
}

```

## Caching

- is a technique used in software development to store frequently accessed data in a cache memory, to improve performance and reduce the load on the database or other data sources.
  - EF Core supports two types of caching: query result caching and second-level caching.

```c#
var products = context.Products
    .Where(p => p.Price > 100)
    .OrderByDescending(p => p.Name)
    .Cacheable()
    .ToList();

```

```c#
services.AddMemoryCache();
services.AddDbContext<MyDbContext>(options =>
    options
        .UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
        .UseMemoryCacheProvider());

```

## cascade delete

## change tracker

- **Change Tracking vs No Tracking**
  - Change Tracking is the default behavior in EF Core and is used to keep track of changes to data. No Tracking is a way to improve performance by disabling change tracking, but it requires you to manually manage changes when you want to save them back to the database.
  - When we modify data in db the ef auto tracking modify and save the modify when we use asnotracking() ef don't track so we want savechanges() we need to attach the object to the context and mark it as modified.

Entity state and change tracking are important concepts in Entity Framework Core (EF Core).

- In EF Core, entity state refers to the state of an entity (i.e., an instance of a class that maps to a database table) with respect to the database. There are several states an entity can be in, including:

  - Added: The entity is new and has been added to the context but has not yet been saved to the database.
  - Unchanged: The entity is in the context and has not been modified since it was last retrieved from or saved to the database.
  - Modified: The entity has been changed in the context and needs to be updated in the database.
  - Deleted: The entity has been deleted from the context and needs to be deleted from the database.
  - Change tracking in EF Core refers to the ability of EF Core to track changes made to entities in the context and automatically generate the appropriate SQL statements to update the database. When an entity is added to the context or retrieved from the database, EF Core keeps track of its state. When changes are made to the entity, EF Core updates its state accordingly. When the context is saved, EF Core generates SQL statements to update the database based on the state of the entities in the context.

You can manually change the state of an entity in EF Core using the Entry method of the context. For example, to mark an entity as modified, you can use the following code:

context.Entry(entity).State = EntityState.Modified;
You can also use change tracking to detect changes made to entities in the context and apply those changes to the database. For example, to update a modified entity in the database, you can simply call the SaveChanges method of the context:

context.SaveChanges();

## shadow property

## logging

## raw sql queries

- **Query with raw sql**
  - use fromsql() method, we also use parameterized query
  
    ```c#
    var context = new SchoolContext();

    var students = context.Students
                    .FromSql("Select * from Students where Name = 'Bill'")
                    .ToList();
    ```

- Parameterized Query

    ```c#
    string name = "Bill";

    var context = new SchoolContext();
    var students = context.Students
                        .FromSql($"Select * from Students where Name = '{name}'")
                        .ToList();
    ```

- The following is also valid.

    ```c#
    string name = "Bill";

    var context = new SchoolContext();
    var students = context.Students
                        .FromSql("Select * from Students where Name = '{0}'", name)
                        .ToList();
    ```

- LINQ Operators:

```c#
    string name = "Bill";

    var context = new SchoolContext();
    var students = context.Students
                    .FromSql("Select * from Students where Name = '{0}'", name)
                    .OrderBy(s => s.StudentId)
                    .ToList();
```

- working with stored procedures

```c#
    var context = new SchoolContext(); 

    var students = context.Students.FromSql("GetStudents 'Bill'").ToList();
```

- migration
  - PMC Commands
  - CLI Commands

## Repository Pattern

The repository pattern is a design pattern that provides an abstraction layer between the application/business logic and the data access layer. It helps to improve the maintainability and testability of code by separating concerns and providing a clear interface for accessing data.

In the repository pattern, a repository acts as a mediator between the application and the data access layer. The repository provides a set of methods for performing CRUD (Create, Read, Update, Delete) operations on entities, abstracting away the details of the underlying data store. The application/business logic interacts with the repository instead of directly with the data access layer, which makes it easier to maintain and test the code.

## An in-memory database

- is a database that resides entirely in memory, as opposed to on disk or other persistent storage. In-memory databases are commonly used for testing and development purposes, as they provide a lightweight and fast way to test database-related functionality without the overhead of disk I/O and other performance bottlenecks.

   In-memory databases can be useful in a variety of scenarios, such as:

  - Unit testing: In-memory databases can be used to quickly and easily test database-related functionality, without the need to set up and tear down a full database.

  - Integration testing: In-memory databases can be used to test the interaction between application code and the database, without the need for a full database instance.

  - Rapid prototyping: In-memory databases can be used to quickly prototype database schemas and test data without the need for a full database instance.

  - Performance testing: In-memory databases can be used to test the performance of database-related functionality, without the overhead of disk I/O and other performance bottlenecks.

## Database providers: An overview of different database providers that can be used with EF Core, such as SQL Server, SQLite, PostgreSQL, etc

- Entity Framework Core (EF Core) is a flexible and extensible ORM (Object-Relational Mapping) framework that supports a wide variety of database providers. By leveraging different database providers, you can use EF Core to interact with different types of databases and data sources, such as SQL Server, SQLite, PostgreSQL, MySQL, Oracle, and more.

  - Microsoft SQL Server: Microsoft SQL Server is a popular relational database management system (RDBMS) that is widely used in enterprise and web applications. EF Core includes built-in support for SQL Server, allowing you to easily interact with SQL Server databases using EF Core.
  - SQLite: SQLite is a lightweight and self-contained SQL database engine that can be embedded in applications. EF Core includes built-in support for SQLite, making it easy to use SQLite databases in your applications.
  - PostgreSQL: PostgreSQL is a powerful open-source object-relational database management system that is popular among developers for its reliability and scalability. EF Core includes built-in support for PostgreSQL, allowing you to interact with PostgreSQL databases using EF Core.
  - MySQL: MySQL is a popular open-source RDBMS that is widely used in web applications. EF Core includes built-in support for MySQL, making it easy to use MySQL databases in your applications.
  - Oracle: Oracle is a widely used commercial RDBMS that is popular among enterprise and web applications. EF Core includes built-in support for Oracle, allowing you to interact with Oracle databases using EF Core.
  - Cosmos DB: Cosmos DB is a globally distributed, multi-model database service that is designed for high availability, low latency, and scalability. EF Core includes built-in support for Cosmos DB, allowing you to interact with Cosmos DB databases using EF Core.

## Transactions

Transactions can be used to ensure data consistency and integrity. EF Core allows you to create transactions using the DbContext.Database.BeginTransaction() method. You can then make changes to the database using the DbContext.SaveChanges() method, and commit or roll back the transaction using the DbContext.Database.CommitTransaction() or DbContext.Database.RollbackTransaction() methods respectively.

## Handling Concurrency and Conflicts

Concurrency and conflicts can occur when multiple users are trying to modify the same data simultaneously. EF Core supports optimistic concurrency, where it checks if the data has been changed since it was last accessed, and pessimistic concurrency, where it locks the data to prevent other users from modifying it. You can configure concurrency handling using attributes or the Fluent API.

## Stored Procedures and Functions

Stored procedures and functions can be executed using the DbContext.Database.ExecuteSqlRaw() or DbContext.Database.ExecuteSqlInterpolated() methods. You can also call stored procedures using the FromSqlRaw() or FromSqlInterpolated() methods in LINQ queries.

## Using LINQ to Query Advance

LINQ provides a powerful and flexible way to query the database and manipulate data. You can use LINQ to perform operations such as filtering, ordering, grouping, and aggregating data. You can also use LINQ to join tables and perform complex queries.

## Asynchronous Queries

Asynchronous queries can improve the performance of your application by allowing other tasks to run while the query is executing. You can execute asynchronous queries using the ToListAsync() or FirstOrDefaultAsync() methods.

## Cascading Updates and Deletes

Cascading updates and deletes can be configured using the Fluent API. You can specify whether changes to a parent entity should cascade to child entities, or whether child entities should be deleted when the parent entity is deleted.

## Global Query Filters

Global query filters can be configured using the Fluent API. You can specify a filter expression that will be applied to all queries for a given entity.

## Split Queries

Split queries can be used to split a query into multiple smaller queries to improve performance and reduce memory usage. You can use the AsSplitQuery() method to split a query into smaller queries.

## Performance Considerations

There are many performance considerations to keep in mind when using EF Core. Some tips include: using appropriate indexing, using eager loading to minimize database round trips, caching frequently accessed data, and minimizing data transfers between the database and application.

## Testing and Debugging

There are many techniques you can use to test and debug your EF Core application. For example, you can use unit testing to test individual components of your application, logging and tracing to identify and diagnose issues, and profiling to analyze application performance.

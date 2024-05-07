# Framework Basics

An ORM (Object-Relational Mapping) framework is a tool that maps the objects in an application to the database tables, allowing developers to work with the database using familiar, object-oriented concepts.

ORM frameworks are tools that map the objects in an application to the database tables, allowing developers to work with the database using familiar, object-oriented concepts:

Console app which has:

-[x] Entities(Order, Product, OrderDetail, Customer, Address)
-[x] Context
-[x] Fluent api configuration
-[x] Queries
-[x] Lazy, eager and explicit Loading
-[x] Change Tracking
-[ ] Caching

| Loading Strategy | Description | Usage Example | SQL Queries | Performance Impact | Pros | Cons |
| ---------------- | ----------- | ------------- | ----------- | ------------------ | ---- | ---- |
| **Lazy Loading** | Related data is loaded on-demand when accessed for the first time. | `var courses = student.Posts;` | Multiple queries when accessing each related entity. | May lead to multiple database calls and increased load. | Simple code and convenient for accessing related data dynamically. | Performance can be inefficient; unexpected database calls. |
| **Eager Loading** | Related data is loaded along with the main data in a single query using the `Include` method. | `var relatedUsers = context.Users.Include(c => c.Posts).FirstOrDefault();` | A single query fetches main and related data. | Reduces number of queries sent to the database; improves performance. | Reduces database round trips and is efficient for predictable data loading. | May load more data than necessary, affecting memory usage. |
| **Explicit Loading** | Related data is loaded explicitly using `Load` or `Query()` methods. | `context.Entry(userExplicit).Reference(x => x.Address).Load();` | Each explicit load triggers a separate SQL query for each related entity. | Provides fine-grained control over when and what data is loaded. | More control over data loading and usage. | May result in multiple database calls, but can be optimized. |

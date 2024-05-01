
```c#
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```
- insert parent table & children table in 1 command

using (var transaction = _context.Database.BeginTransaction())
{
    try
    {
        var parent = new Parent { Name = "Parent 1" };
        var child1 = new Child { Name = "Child 1", Parent = parent };
        var child2 = new Child { Name = "Child 2", Parent = parent };

        await _context.Database.ExecuteSqlRawAsync(
            @"INSERT INTO Parents (Name) VALUES (@p0);
              DECLARE @ParentId int;
              SET @ParentId = SCOPE_IDENTITY();
              INSERT INTO Children (Name, ParentId) VALUES (@p1, @ParentId);
              INSERT INTO Children (Name, ParentId) VALUES (@p2, @ParentId);",
            parent.Name, child1.Name, child2.Name);

        await transaction.CommitAsync();
    }
    catch (Exception ex)
    {
        await transaction.RollbackAsync();
        throw;
    }
}

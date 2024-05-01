var context = new AppDbContext();
// lazy load
// Lazy Loading
var student = context.Users.FirstOrDefault();
// SELECT TOP(1) [u].[Id], [u].[Name]
// FROM [Users] AS [u]
var courses = student.Posts; // related courses are loaded on demand

// exec sp_executesql N'SELECT [p].[Id], [p].[Title], [p].[UserId]
// FROM [Posts] AS [p]
// WHERE [p].[UserId] = @__p_0',N'@__p_0 int',@__p_0=1
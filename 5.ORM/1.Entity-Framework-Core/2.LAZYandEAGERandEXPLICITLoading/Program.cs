using Microsoft.EntityFrameworkCore;

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
// ------------------------------------------------
// EAGER loading
// load 1 related

var relatedUsers = context.Users
                    .Include(c => c.Posts)
                    .FirstOrDefault();

// SELECT [t].[Id], [t].[Name], [p].[Id], [p].[Title], [p].[UserId]
// FROM (
//     SELECT TOP(1) [u].[Id], [u].[Name]
//     FROM [Users] AS [u]
// ) AS [t]
// LEFT JOIN [Posts] AS [p] ON [t].[Id] = [p].[UserId]
// ORDER BY [t].[Id]

// Load multiple related

var loadMultiple = context.Users
                    .Include(c => c.Posts)
                    .Include(a => a.Address)
                    .FirstOrDefault();

// SELECT [t].[Id], [t].[Name], [t].[Id0], [p].[Id], [p].[Title], [p].[UserId], [t].[Detail], [t].[UserId]
// FROM (
//     SELECT TOP(1) [u].[Id], [u].[Name], [a].[Id] AS [Id0], [a].[Detail], [a].[UserId]
//     FROM [Users] AS [u]
//     LEFT JOIN [Address] AS [a] ON [u].[Id] = [a].[UserId]
// ) AS [t]
// LEFT JOIN [Posts] AS [p] ON [t].[Id] = [p].[UserId]
// ORDER BY [t].[Id], [t].[Id0]
// // Load Related of Related
var loadRelated = context.Users
                    .Include(c => c.Posts)
                        .ThenInclude(x => x.Tags)
                    .Include(a => a.Address)
                    .ToList();

// SELECT [u].[Id], [u].[Name], [a].[Id], [t0].[Id], [t0].[Title], [t0].[UserId], [t0].[Id0], [t0].[Name], [t0].[PostId], [a].[Detail], [a].[UserId]
// FROM [Users] AS [u]
// LEFT JOIN [Address] AS [a] ON [u].[Id] = [a].[UserId]
// LEFT JOIN (
//     SELECT [p].[Id], [p].[Title], [p].[UserId], [t].[Id] AS [Id0], [t].[Name], [t].[PostId]
//     FROM [Posts] AS [p]
//     LEFT JOIN [Tag] AS [t] ON [p].[Id] = [t].[PostId]
// ) AS [t0] ON [u].[Id] = [t0].[UserId]
// ORDER BY [u].[Id], [a].[Id], [t0].[Id]

// ------------------------------------------------
// EXPLICIT loading
var userExplicit = context.Users.FirstOrDefault();
context.Entry(userExplicit).Reference(x => x.Address).Load();
context.Entry(userExplicit).Collection(x => x.Posts).Load();

// 1
// SELECT TOP(1) [u].[Id], [u].[Name]
// FROM [Users] AS [u]

// 2
// exec sp_executesql N'SELECT [a].[Id], [a].[Detail], [a].[UserId]
// FROM [Addresss] AS [a]
// WHERE [a].[UserId] = @__p_0',N'@__p_0 int',@__p_0=1
// 3
// exec sp_executesql N'SELECT [p].[Id], [p].[Title], [p].[UserId]
// FROM [Posts] AS [p]
// WHERE [p].[UserId] = @__p_0',N'@__p_0 int',@__p_0=1


// EXPLICIT loading
var explicitUser = context.Users.FirstOrDefault();
context.Entry(explicitUser).Reference(x => x.Address).Load();
context.Entry(explicitUser).Collection(x => x.Posts)
                    .Query()
                    .Include(x => x.Tags)
                    .ToList();

// 1
// SELECT TOP(1) [u].[Id], [u].[Name]
// FROM [Users] AS [u]
//2
// exec sp_executesql N'SELECT [a].[Id], [a].[Detail], [a].[UserId]
// FROM [Addresss] AS [a]
// WHERE [a].[UserId] = @__p_0',N'@__p_0 int',@__p_0=1
// 3
// exec sp_executesql N'SELECT [p].[Id], [p].[Title], [p].[UserId], [t].[Id], [t].[Name], [t].[PostId]
// FROM [Posts] AS [p]
// LEFT JOIN [Tag] AS [t] ON [p].[Id] = [t].[PostId]
// WHERE [p].[UserId] = @__p_0
// ORDER BY [p].[Id]',N'@__p_0 int',@__p_0=1